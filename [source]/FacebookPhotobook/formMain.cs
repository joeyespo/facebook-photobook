using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ascentium.Research.Windows.Forms.Components;
using Facebook.Entity;
using Facebook.Components;
using Facebook.Exceptions;

namespace FacebookPhotobook
{
  // TODO: Right-click on list
  // - View, expand/collapse/album-only, links, etc
  // TODO: Progress bars
  // TODO: Contact facebook

  public partial class formMain : Form
  {

    #region Local Classes and Enumerations

    enum RetrievalLevel
    {
      RetrieveOnlyRelevantPhotos,
      RetrieveAllPhotosFromIncludedAlbums,
      RetrieveAllPhotosFromAllIncludedUsersAlbums,
      RetrieveAllPhotosFromAllFriends,
    }

    class UserPhotobook
    {
      User user;
      Photo[] photos;
      Album[] albums;
      User[] users;

      Dictionary<string, Photo> photoMap = new Dictionary<string,Photo>();
      Dictionary<string, Album> albumMap = new Dictionary<string,Album>();
      Dictionary<string, User> userMap = new Dictionary<string,User>();

      Dictionary<Photo, bool> taggedPhotos = new Dictionary<Photo, bool>();
      Dictionary<Album, bool> taggedAlbums = new Dictionary<Album, bool>();
      Dictionary<User, bool> taggedUsers = new Dictionary<User, bool>();

      public UserPhotobook(User currentUser, Photo[] photos, Album[] albums, User[] users, bool[] taggedPhotoTable)
      {
        this.user = currentUser;
        this.photos = photos;
        this.albums = albums;
        this.users = users;

        // Get photo map
        foreach (Photo photo in photos)
          photoMap[photo.PhotoId] = photo;
        // Get album map
        foreach (Album album in albums)
          albumMap[album.AlbumId] = album;
        // Get user map
        foreach (User user in users)
          userMap[user.UserId] = user;

        // Get additional information
        for (int i = 0; i < photos.Length; i++)
        {
          // Tagged information
          if (!taggedPhotos.ContainsKey(photos[i]) || (!taggedPhotos[photos[i]]))
          taggedPhotos[photos[i]] = taggedPhotoTable[i];
        if ((!taggedAlbums.ContainsKey(albumMap[photos[i].AlbumId])) || (!taggedAlbums[albumMap[photos[i].AlbumId]]))
            taggedAlbums[albumMap[photos[i].AlbumId]] = taggedPhotoTable[i];
          if ((!taggedUsers.ContainsKey(userMap[photos[i].OwnerUserId])) || (!taggedUsers[userMap[photos[i].OwnerUserId]]))
            taggedUsers[userMap[photos[i].OwnerUserId]] = taggedPhotoTable[i];
        }
      }

      public Photo[] Photos
      { get { return photos; } }

      public Album[] Albums
      { get { return albums; } }

      public User[] Users
      { get { return users; } }

      public Photo PhotoFromPhotoId(string photoId)
      {
        Photo result;
        if (!photoMap.TryGetValue(photoId, out result))
          return null;
        return result;
      }

      public Album AlbumFromAlbumId(string albumId)
      {
        Album result;
        if (!albumMap.TryGetValue(albumId, out result))
          return null;
        return result;
      }

      public User UserFromUserId(string userId)
      {
        User result;
        if (!userMap.TryGetValue(userId, out result))
          return null;
        return result;
      }

      public bool IsTaggedPhoto(Photo photo)
      {
        bool result;
        if (!taggedPhotos.TryGetValue(photo, out result))
          return false;
        return result;
      }

      public bool IsTaggedAlbum(Album album)
      {
        bool result;
        if (!taggedAlbums.TryGetValue(album, out result))
          return false;
        return result;
      }

      public bool IsTaggedUser(User user)
      {
        bool result;
        if (!taggedUsers.TryGetValue(user, out result))
          return false;
        return result;
      }

      public bool IsAlbumCoverArtIncluded(Album album)
      {
        return photoMap.ContainsKey(album.CoverPhotoId);
      }

      public bool IsPhotoAlbumCover(Photo photo)
      {
        return albumMap[photo.AlbumId].CoverPhotoId == photo.PhotoId;
      }
    }

    class UserConnection
    {
      FacebookService service;
      User user = null;
      UserPhotobook photobook = null;

      public UserConnection()
      {
        service = new FacebookService();
        service.IsDesktopApplication = true;
        service.ApplicationKey = "d2699d3dcc6211fcb77314e9d20804fe";
        service.Secret = "2e39e76d36012095416d294a52aeb618";
        service.ConnectToFacebook();
        // Set up data
        user = service.GetUserInfo();
      }

      public FacebookService Service
      { get { return service; } }

      public User User
      { get { return user; } }

      public UserPhotobook Photobook
      {
        get { return photobook; }
        set { photobook = value; }
      }

      public string Name
      { get { return user.Name; } }
      public string UserId
      { get { return user.UserId; } }
    }

    #endregion

    UserConnection connection;
    Font boldFont = new Font(DefaultFont, FontStyle.Bold);
    bool getAlbumCoverPhotos = true;
    bool getYourAlbums = true;
    RetrievalLevel retrievalLevel = RetrievalLevel.RetrieveOnlyRelevantPhotos;

    public formMain()
    {
      InitializeComponent();
      textBoxDirectory.Text = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Photobook");
      textBoxDirectory.SelectionStart = textBoxDirectory.Text.Length;
      doDisconnect();
      labelUserName.Text = "";
      doUpdatePreview();
    }

    

    #region Control Events

    private void buttonCancelGetPhotos_Click(object sender, EventArgs e)
    {
      doCancelGetPhotos();
    }

    private void buttonDownload_Click(object sender, EventArgs e)
    {
      doDownload();
    }

    private void buttonCancelDownload_Click(object sender, EventArgs e)
    {
      doCancelDownload();
    }

    private void pictureBoxDownloader_LoadCompleted(object sender, AsyncCompletedEventArgs e)
    {
      if (e.Error != null)
        pictureBoxDownloader.Image = null;
      doDownloadPhotoComplete(pictureBoxDownloader.Image);
    }

    private void pictureBoxDownloader_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      // TODO: Progress
    }

    private void buttonBrowse_Click(object sender, EventArgs e)
    {
      dialogBrowse.SelectedPath = textBoxDirectory.Text;
      if (dialogBrowse.ShowDialog(this) != DialogResult.OK) return;
      textBoxDirectory.Text = dialogBrowse.SelectedPath;
      textBoxDirectory.SelectionStart = textBoxDirectory.Text.Length;
    }

    private void buttonView_Click(object sender, EventArgs e)
    {
      if (!Directory.Exists(textBoxDirectory.Text))
      {
        MessageBox.Show(this, "Directory does not exist.", "Facebook Photobook", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      Process.Start(textBoxDirectory.Text);
    }

    private void contextMenuGetOptions_Opening(object sender, CancelEventArgs e)
    {
      includeAlbumCoverPhotosToolStripMenuItem.Checked = getAlbumCoverPhotos;
      includeAlbumsUploadedByYouToolStripMenuItem1.Checked = getYourAlbums;
      retrieveOnlyRelevantPhotosToolStripMenuItem.Checked = (retrievalLevel == RetrievalLevel.RetrieveOnlyRelevantPhotos);
      retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem.Checked = (retrievalLevel == RetrievalLevel.RetrieveAllPhotosFromIncludedAlbums);
      retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem.Checked = (retrievalLevel == RetrievalLevel.RetrieveAllPhotosFromAllIncludedUsersAlbums);
      retrieveAllPhotosFromAllFriendsToolStripMenuItem.Checked = (retrievalLevel == RetrievalLevel.RetrieveAllPhotosFromAllFriends);
    }

    private void includeAlbumCoversToolStripMenuItem_Click(object sender, EventArgs e)
    {
      getAlbumCoverPhotos = !getAlbumCoverPhotos;
    }

    private void includeAlbumsUploadedByYouToolStripMenuItem_Click(object sender, EventArgs e)
    {
      getYourAlbums = !getYourAlbums;
    }

    private void retrieveOnlyRelevantPhotosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      retrievalLevel = RetrievalLevel.RetrieveOnlyRelevantPhotos;
    }

    private void retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      retrievalLevel = RetrievalLevel.RetrieveAllPhotosFromIncludedAlbums;
    }

    private void retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      retrievalLevel = RetrievalLevel.RetrieveAllPhotosFromAllIncludedUsersAlbums;
    }

    private void retrieveAllPhotosFromAllFriendsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      retrievalLevel = RetrievalLevel.RetrieveAllPhotosFromAllFriends;
    }

    private void buttonGetOptions_MouseDown(object sender, MouseEventArgs e)
    {
      contextMenuGetOptions.Show(buttonGetPhotos, new Point(0, buttonGetPhotos.Height));
      contextMenuGetOptions.Focus();
    }
    private void buttonGetOptions_Click(object sender, EventArgs e)
    {
      contextMenuGetOptions.Show(buttonGetPhotos , new Point(0, buttonGetPhotos.Height));
      contextMenuGetOptions.Focus();
    }

    private void treeViewPhotos_AfterSelect(object sender, TreeViewEventArgs e)
    {
      doUpdatePreview();
    }

    private void treeViewPhotos_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      doViewCurrentPhoto();
    }

    private void pictureBoxPreview_SizeChanged(object sender, EventArgs e)
    {
      doUpdateInfoPanel();
    }

    private void pictureBoxPreview_LoadCompleted(object sender, AsyncCompletedEventArgs e)
    {
      doUpdateInfoPanel();
    }

    private void linkLabelViewLarge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      doViewCurrentPhoto();
    }

    private void buttonConnect_Click(object sender, EventArgs e)
    {
      if (connection == null)
        doConnect();
      else
        doDisconnect();
    }

    private void buttonGetPhotos_Click(object sender, EventArgs e)
    {
      onUngetPhotos();
      doGetPhotos();
    }

    private void buttonExpandAll_Click(object sender, EventArgs e)
    {
      TreeNode selectedNode = treeViewPhotos.SelectedNode;
      treeViewPhotos.ExpandAll();
      for (; selectedNode != null && selectedNode.Parent != null; selectedNode = selectedNode.Parent)
      treeViewPhotos.SelectedNode = selectedNode;
      selectedNode.EnsureVisible();
    }

    private void buttonCollapseAll_Click(object sender, EventArgs e)
    {
      TreeNode selectedNode = treeViewPhotos.SelectedNode;
      treeViewPhotos.CollapseAll();
      treeViewPhotos.SelectedNode = selectedNode;
      selectedNode.EnsureVisible();
    }

    private void buttonShowAlbums_Click(object sender, EventArgs e)
    {
      TreeNode selectedNode = treeViewPhotos.SelectedNode;
      foreach (TreeNode node in treeViewPhotos.Nodes)
      {
        node.Expand();
        foreach (TreeNode child in node.Nodes)
          child.Collapse();
      }
      if ((selectedNode != null) && (selectedNode.Parent != null) && (selectedNode.Parent.Parent != null))
        selectedNode = selectedNode.Parent;
      treeViewPhotos.SelectedNode = selectedNode;
      selectedNode.EnsureVisible();
    }

    private void buttonCheckAll_Click(object sender, EventArgs e)
    {
      foreach (ThreeStateTreeNode node in treeViewPhotos.Nodes)
        node.Toggle(Ascentium.Research.Windows.Forms.Components.Enumerations.CheckBoxState.Unchecked);
    }

    private void buttonUncheckAll_Click(object sender, EventArgs e)
    {
      foreach (ThreeStateTreeNode node in treeViewPhotos.Nodes)
        node.Toggle(Ascentium.Research.Windows.Forms.Components.Enumerations.CheckBoxState.Checked);
    }

    private void checkBoxPreview_CheckedChanged(object sender, EventArgs e)
    {
      doUpdatePreview();
    }

    private void formMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      doCancelGetPhotos();
      doCancelDownload();
      doDisconnect();
    }

    #endregion

    #region Class Events

    void onConnected()
    {
      buttonConnect.Text = "Logout";
      buttonConnect.Image = null;

      // Set up data
      labelUserName.Text = connection.User.Name;
      pictureUserPicture.LoadAsync(connection.User.PictureUrl.ToString());
      buttonGetPhotos.Focus();
      doUpdatePreview();
    }

    void onDisconnected()
    {
      buttonConnect.Text = "";
      buttonConnect.Image = FacebookPhotobook.Properties.Resources.facebook_login;

      // Clean up data
      labelUserName.Text = "";
      pictureUserPicture.Image = null;
      groupBoxPhotobook.Visible = false;
      panelPhotobook.BorderStyle = BorderStyle.Fixed3D;
      buttonGetPhotos.Text = "Get Photos";
      treeViewPhotos.Nodes.Clear();
      buttonConnect.Focus();
      doUpdatePreview();
    }

    bool onGetPhotos()
    {
      groupBoxPhotobook.Visible = true;
      panelPhotobook.BorderStyle = BorderStyle.None;
      buttonGetPhotos.Text = "Refresh Photos";
      treeViewPhotos.Focus();
      doUpdatePreview();
      if (checkBoxImmediateDownload.Checked)
        doDownload();
      return true;
    }

    bool onUngetPhotos()
    {
      groupBoxPhotobook.Visible = false;
      panelPhotobook.BorderStyle = BorderStyle.Fixed3D;
      buttonGetPhotos.Focus();
      return true;
    }

    #endregion

    #region Class Commands

    delegate T QueryFunction<T>();
    T doServiceQuery<T>(QueryFunction<T> f)
    { return doServiceQuery<T>(f, 60000); }
    T doServiceQuery<T>(QueryFunction<T> f, int uTimeout)
    {
      while (true)
      {
        try
        {
          return f();
        }
        catch (FacebookRequestLimitException)
        {
          if (MessageBoxEx.Show(this, "Too many requests have been sent to Facebook in a short amount of time.\n\nWait a few minutes then try again, or click Cancel to stop trying.\nThis message will timeout in 120 seconds", "Facebook Photobook", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 120000) == DialogResult.Cancel)
            throw;
        }
      }
    }

    bool doConnect()
    {
      if (!doDisconnect())
        return false;

      try
      {
        connection = new UserConnection();
      }
      catch (FacebookException ex)
      {
        MessageBox.Show(this, ex.Message, "Facebook Photobook", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }

      // Connected event
      onConnected();
      return true;
    }

    bool doDisconnect()
    {
      if (connection != null)
      {
        try
        { connection.Service.LogOff(); }
        catch (FacebookException ex)
        { Console.Error.WriteLine(ex.Message); }
        // Set connection to null, signifying not logged in.
        connection = null;
      }

      // Disconnected event
      onDisconnected();
      return true;
    }

    bool doCancelGetPhotos()
    {
      cancelGetPhotos = true;
      return true;
    }
    bool cancelGetPhotos = false;
    bool doGetPhotos()
    {

      if (connection == null)
      {
        MessageBox.Show(this, "Not logged in.", "Facebook Photobook", MessageBoxButtons.OK, MessageBoxIcon.Information);
        buttonConnect.Focus();
        return false;
      }

      treeViewPhotos.Nodes.Clear();

      try
      {
        try
        {
          this.Text = "Facebook Photobook - Busy...";
          cancelGetPhotos = false;
          splitContainerMain.Enabled = false;
          buttonCancelGetPhotos.Visible = true;
          Application.DoEvents();
          if (cancelGetPhotos) return false;

          // Total lists and maps
          List<Photo> photos = new List<Photo>();
          List<Album> albums = new List<Album>();
          List<User> users = new List<User>();
          List<Photo> albumCovers = new List<Photo>();
          Dictionary<string, Photo> photoMap = new Dictionary<string, Photo>();

          #region Get Tagged Photos

          // Get tagged photos
          Collection<Photo> taggedPhotos = doServiceQuery<Collection<Photo>>(
            delegate() { return connection.Service.GetPhotos(connection.User); });
          Application.DoEvents(); if (cancelGetPhotos) return false;
          // Get tagged albums
          Collection<string> taggedAlbumIds = new Collection<string>();
          foreach (Photo photo in taggedPhotos)
            if (!taggedAlbumIds.Contains(photo.AlbumId))
              taggedAlbumIds.Add(photo.AlbumId);
          Collection<Album> taggedAlbums = doServiceQuery<Collection<Album>>(
            delegate() { return connection.Service.GetPhotoAlbums(taggedAlbumIds); });
          Application.DoEvents(); if (cancelGetPhotos) return false;
          // Get tagged users 
          Collection<string> taggedUserIds = new Collection<string>();
          foreach (Album album in taggedAlbums)
            if (!taggedUserIds.Contains(album.OwnerUserId))
              taggedUserIds.Add(album.OwnerUserId);
          Collection<User> taggedUsers = doServiceQuery<Collection<User>>(
            delegate() { return connection.Service.GetUserInfo(taggedUserIds); });
          Application.DoEvents(); if (cancelGetPhotos) return false;

          // Get total list data
          users.AddRange(taggedUsers);
          albums.AddRange(taggedAlbums);
          photos.AddRange(taggedPhotos);
          foreach (Photo photo in photos)
            photoMap[photo.PhotoId] = photo;

          #endregion

          #region Get List of Photos, Albums, and Users

          // Get list of photos, albums, and users to receive
          switch (retrievalLevel)
          {
            case RetrievalLevel.RetrieveOnlyRelevantPhotos:
              // Have enough information from here
              break;
            case RetrievalLevel.RetrieveAllPhotosFromIncludedAlbums:
              // Get every photo in each album
              foreach (Album album in albums)
              {
                // TODO: Do not loop the service call
                Collection<Photo> albumPhotos = doServiceQuery<Collection<Photo>>(
                  delegate() { return connection.Service.GetPhotos(album.AlbumId); });
                Application.DoEvents(); if (cancelGetPhotos) return false;
                foreach (Photo photo in albumPhotos)
                  if (!photos.Contains(photo))
                    photos.Add(photo);
              }
              // TODO: Use this form
              /*
              string allAlbumIdsString = "";
              foreach (string albumId in allAlbumIdsString)
              {
                if (taggedAlbumIdsString != "") taggedAlbumIdsString += ", ";
                taggedAlbumIdsString += albumId;
              }
              Collection<string> allPhotos = new Collection<string>();
              taggedAlbumIds.Add(taggedAlbumIdsString);
              */
              break;
            case RetrievalLevel.RetrieveAllPhotosFromAllIncludedUsersAlbums:
              // Get every album from every user
              Collection<Album> allAlbums = new Collection<Album>();
              foreach (User user in users)
              {
                // TODO: Do not loop the service call
                Collection<Album> userAlbums = doServiceQuery<Collection<Album>>(
                  delegate() { return connection.Service.GetPhotoAlbums(user.UserId); });
                Application.DoEvents(); if (cancelGetPhotos) return false;
                foreach (Album album in userAlbums)
                  if (!albums.Contains(album))
                    albums.Add(album);
              }
              goto case RetrievalLevel.RetrieveAllPhotosFromIncludedAlbums;
            case RetrievalLevel.RetrieveAllPhotosFromAllFriends:
              // Add all friends as users and get all albums and photos
              Collection<User> friends = doServiceQuery<Collection<User>>(
                delegate() { return connection.Service.GetFriends(); });
              Application.DoEvents(); if (cancelGetPhotos) return false;
              foreach (User friend in friends)
                if (!users.Contains(friend))
                  users.Add(friend);
              goto case RetrievalLevel.RetrieveAllPhotosFromAllIncludedUsersAlbums;
          }

          if (getYourAlbums)
          {
            // Get your albums (need to add your user if not already added)
            Collection<Album> yourAlbums = doServiceQuery<Collection<Album>>(
              delegate() { return connection.Service.GetPhotoAlbums(connection.UserId); });
            Application.DoEvents(); if (cancelGetPhotos) return false;
            Collection<Album> yourMissingAlbums = new Collection<Album>();
            foreach (Album album in yourAlbums)
              if (!albums.Contains(album))
                yourMissingAlbums.Add(album);
            // Get your photos
            Collection<Photo> yourMissingPhotos = new Collection<Photo>();
            foreach (Album album in yourMissingAlbums)
            {
              // TODO: Do not loop the service call
              Collection<Photo> albumPhotos = doServiceQuery<Collection<Photo>>(
                delegate() { return connection.Service.GetPhotos(album.AlbumId); });
              Application.DoEvents(); if (cancelGetPhotos) return false;
              foreach (Photo photo in albumPhotos)
                if (!photos.Contains(photo))
                  yourMissingPhotos.Add(photo);
            }
            // Add user
            if (!users.Contains(connection.User))
              users.Add(connection.User);
            // Add your albums and photos
            albums.AddRange(yourMissingAlbums);
            photos.AddRange(yourMissingPhotos);
          }

          if (getAlbumCoverPhotos)
          {
            // Get album cover photos (owned by users who own the album)
            Collection<string> missingAlbumCoverPhotoIds = new Collection<string>();
            foreach (Album album in albums)
              if (!photoMap.ContainsKey(album.CoverPhotoId))
                missingAlbumCoverPhotoIds.Add(album.CoverPhotoId);
            Collection<Photo> missingAlbumCoverPhotos = doServiceQuery<Collection<Photo>>(
              delegate() { return connection.Service.GetPhotos(missingAlbumCoverPhotoIds); });
            Application.DoEvents(); if (cancelGetPhotos) return false;
            photos.AddRange(missingAlbumCoverPhotos);
          }

          #endregion

          bool[] taggedPhotoTable = new bool[photos.Count];
          for (int i = 0; i < photos.Count; i++)
            taggedPhotoTable[i] = taggedPhotos.Contains(photos[i]);
          // Set photo data
          connection.Photobook = new UserPhotobook(connection.User, photos.ToArray(), albums.ToArray(), users.ToArray(), taggedPhotoTable);

          // Populate photo list
          doPopulatePhotos();

          // Get photos event
          onGetPhotos();
        }
        finally
        {
          this.Text = "Facebook Photobook";
          buttonCancelGetPhotos.Visible = false;
          splitContainerMain.Enabled = true;
        }
      }
      catch (ApplicationException ex)
      {
        MessageBox.Show(this, ex.Message, "Facebook Photobook", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      catch (FacebookException ex)
      {
        MessageBox.Show(this, ex.Message, "Facebook Photobook", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    void doPopulatePhotos()
    {
      if (connection == null) return;
      if (connection.Photobook == null) return;
      UserPhotobook pb = connection.Photobook;

      #region Populate Tree

      // Populate tree with appropriate photos (user, album, photo)
      treeViewPhotos.Nodes.Clear();
      doUpdatePreview();
      treeViewPhotos.BeginUpdate();
      try
      {
        // Add owner users
        foreach (User user in pb.Users)
        {
          ThreeStateTreeNode userNode = new ThreeStateTreeNode();
          userNode.Tag = user;
          // TODO: Untagged users
          userNode.ImageIndex = (pb.IsTaggedUser(user)) ? (0) : (5);
          userNode.SelectedImageIndex = userNode.ImageIndex;
          userNode.Text = user.Name;
          userNode.NodeFont = boldFont;
          treeViewPhotos.Nodes.Add(userNode);
          // Add albums
          foreach (Album album in pb.Albums)
          {
            // Only display those albums owned by user
            if (album.OwnerUserId != user.UserId) continue;
            ThreeStateTreeNode albumNode = new ThreeStateTreeNode();
            albumNode.Tag = album;
            // TODO: Untagged albums
            albumNode.ImageIndex = (pb.IsAlbumCoverArtIncluded(album))
              ? ((pb.IsTaggedAlbum(album)) ? (1) : (6))
              : ((pb.IsTaggedAlbum(album)) ? (4) : (9));
            albumNode.SelectedImageIndex = albumNode.ImageIndex;
            albumNode.Text = album.Name;
            userNode.Nodes.Add(albumNode);
            // Add photos
            foreach (Photo photo in pb.Photos)
            {
              // Only display those pictures in album
              if (photo.AlbumId != album.AlbumId) continue;
              ThreeStateTreeNode photoNode = new ThreeStateTreeNode();
              photoNode.Tag = photo;
              // TODO: Untagged photos
              photoNode.ImageIndex = (pb.IsPhotoAlbumCover(photo))
                ? ((pb.IsTaggedPhoto(photo)) ? (3) : (8))
                : ((pb.IsTaggedPhoto(photo)) ? (2) : (7));
              photoNode.SelectedImageIndex = photoNode.ImageIndex;
              photoNode.Text = photo.PhotoId;
              albumNode.Nodes.Add(photoNode);
              // Initail check
              photoNode.Toggle();
            }
            albumNode.Collapse();
          }
          userNode.Expand();
        }
      }
      finally
      {
        try
        {
          treeViewPhotos.EndUpdate();
        }
        catch
        { }
      }

      #endregion

    }

    bool doViewCurrentPhoto()
    {
      Photo photo = (Photo)pictureBoxPreview.Tag;
      if (photo == null) return false;
      (new formViewImage(photo.PictureBigUrl.ToString())).ShowDialog(this);
      return true;
    }

    bool doUpdateInfoPanel()
    {
      linkLabelViewLarge.Top = pictureBoxPreview.Bottom;
      int top = pictureBoxPreview.Top;
      if (pictureBoxPreview.Image != null)
        top = linkLabelViewLarge.Bottom + 4;
      labelDateCreated.Top = top;
      labelDescriptionTitle.Top = labelDateCreated.Bottom + 8;
      labelDescription.Top = labelDescriptionTitle.Bottom;
      return true;
    }

    bool doUpdatePreview()
    {
      pictureBoxPreview.Image = null;
      pictureBoxPreview.Tag = null;
      labelDescriptionTitle.Text = "";
      labelDescription.Text = "";
      labelDateCreated.Text = "";
      linkLabelViewLarge.Visible = false;

      if (treeViewPhotos.SelectedNode == null) return true;
      // Check for owner user
      if (treeViewPhotos.SelectedNode.Parent == null) return true;
      // Check for album
      if (treeViewPhotos.SelectedNode.Parent.Parent == null)
      {
        Album album = (Album)treeViewPhotos.SelectedNode.Tag;
        Photo photo = connection.Photobook.PhotoFromPhotoId(album.CoverPhotoId);
        if (photo != null)
        {
          pictureBoxPreview.LoadAsync(photo.PictureSmallUrl.ToString());
          pictureBoxPreview.Tag = photo;
        }
        labelDescription.Text = album.Description.Trim();
        if (labelDescription.Text != "")
          labelDescriptionTitle.Text = "Description";
        labelDateCreated.Text = album.CreateDate.ToString();
        linkLabelViewLarge.Visible = (photo != null);
      }
      else    // Else is photo
      {
        Photo photo = (Photo)treeViewPhotos.SelectedNode.Tag;
        pictureBoxPreview.LoadAsync(photo.PictureSmallUrl.ToString());
        pictureBoxPreview.Tag = photo;
        labelDescription.Text = photo.Caption.Trim();
        if (labelDescription.Text != "")
          labelDescriptionTitle.Text = "Caption";
        labelDateCreated.Text = photo.CreateDate.ToString();
        linkLabelViewLarge.Visible = true;
      }
      doUpdateInfoPanel();
      return true;
    }

    bool doCancelDownload()
    {
      cancelDownload = true;
      return true;
    }
    bool cancelDownload = false;
    bool nextDownloaded = false;
    bool doDownload()
    {
      try
      {
        try
        {
          this.Text = "Facebook Photobook - Downloading...";
          this.Refresh();
          splitContainerMain.Enabled = false;
          buttonCancelDownload.Visible = true;
          buttonCancelDownload.BringToFront();
          cancelDownload = false;

          List<char> invalidPathCharList = new List<char>();
          invalidPathCharList.AddRange(Path.GetInvalidPathChars());
          invalidPathCharList.Add('/');
          invalidPathCharList.Add('\\');
          invalidPathCharList.Add(':');
          invalidPathCharList.Add('*');
          invalidPathCharList.Add('?');
          invalidPathCharList.Add('"');
          invalidPathCharList.Add('<');
          invalidPathCharList.Add('>');
          invalidPathCharList.Add('|');
          invalidPathCharList.Add(Path.VolumeSeparatorChar);
          invalidPathCharList.Add(Path.PathSeparator);
          invalidPathCharList.Add(Path.AltDirectorySeparatorChar);
          invalidPathCharList.Add(Path.DirectorySeparatorChar);
          char[] invalidPathChars = invalidPathCharList.ToArray();
          string basedirectory = Path.GetFullPath(textBoxDirectory.Text);
          UserPhotobook pb = connection.Photobook;

          // Get each user
          foreach (TreeNode userNode in treeViewPhotos.Nodes)
          {
            Application.DoEvents();
            if (this.IsDisposed) break;
            if (cancelDownload) break;

            if (!userNode.Checked) continue;
            User user = (User)userNode.Tag;

            // Get each album
            foreach (TreeNode albumNode in userNode.Nodes)
            {
              Application.DoEvents();
              if (this.IsDisposed) break;
              if (cancelDownload) break;

              if (!albumNode.Checked) continue;
              Album album = (Album)albumNode.Tag;
              string userName = user.Name.Trim();
              string albumName = album.Name.Trim();
              int index = 0;
              while ((index = userName.IndexOfAny(invalidPathChars)) != -1) userName = userName.Replace(userName[index], '-');
              while ((index = albumName.IndexOfAny(invalidPathChars)) != -1) albumName = albumName.Replace(albumName[index], '-');
              userName = userName.Trim('.');
              albumName = albumName.Trim('.');
              if (userName == "") userName = "untitled";
              if (albumName == "") albumName = "untitled";
              string directory = Path.Combine(Path.Combine(basedirectory, userName), albumName);
              // Create directory
              if (!Directory.Exists(directory))
              {
                try
                { Directory.CreateDirectory(directory); }
                catch (IOException ex)
                {
                  if (MessageBoxEx.Show(this, ex.Message + "\n\nTo continue with the process click OK, otherwise click Cancel.\nThis message will timeout in 60 seconds.", "Facebook Photobook", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, 60000) == DialogResult.Cancel)
                    throw;
                  continue;
                }
              }

              // Get each photo
              foreach (TreeNode photoNode in albumNode.Nodes)
              {
                Application.DoEvents();
                if (this.IsDisposed) break;
                if (cancelDownload) break;

                if (!photoNode.Checked) continue;
                Photo photo = (Photo)photoNode.Tag;
                string filetitle = photo.PhotoId;
                string filename = Path.Combine(directory, photo.PhotoId + ".png");

                // Save image
                if ((checkBoxSkipExisting.Checked) && (File.Exists(filename))) continue;
                nextDownloaded = false;
                pictureBoxDownloader.LoadAsync(photo.PictureBigUrl.ToString());
                while (!nextDownloaded)
                {
                  if (this.IsDisposed) break;
                  if (cancelDownload) break;
                  Application.DoEvents();
                }
                if (this.IsDisposed) break;
                if (cancelDownload) break;
                if (pictureBoxDownloader.Image != null)
                  pictureBoxDownloader.Image.Save(filename);
              }
              if (this.IsDisposed) break;
              if (cancelDownload) break;

              // TODO: Album description and date, photo comments and dates
            }
            if (this.IsDisposed) break;
            if (cancelDownload) break;
          }
        }
        finally
        {
          buttonCancelDownload.Visible = false;
          splitContainerMain.Enabled = true;
          this.Text = "Facebook Photobook";
        }
      }
      catch (ApplicationException ex)
      {
        MessageBox.Show(this, ex.Message, "Facebook Photobook", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      catch (FacebookException ex)
      {
        MessageBox.Show(this, ex.Message, "Facebook Photobook", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      return true;
    }

    bool doDownloadPhotoComplete(Image image)
    {
      if (this.IsDisposed) return false;
      if (cancelDownload) return false;
      nextDownloaded = true;
      return true;
    }

    #endregion

  }
}
