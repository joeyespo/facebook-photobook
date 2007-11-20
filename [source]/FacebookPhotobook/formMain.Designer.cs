namespace FacebookPhotobook
{
  partial class formMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
      this.labelUserName = new System.Windows.Forms.Label();
      this.imageListPhotos = new System.Windows.Forms.ImageList(this.components);
      this.buttonGetPhotos = new System.Windows.Forms.Button();
      this.groupBoxConnect = new System.Windows.Forms.GroupBox();
      this.panelTimeout = new System.Windows.Forms.Panel();
      this.labelTimeoutTimeSec = new System.Windows.Forms.Label();
      this.labelTimeoutTime = new System.Windows.Forms.Label();
      this.numericUpDownTimeoutTime = new System.Windows.Forms.NumericUpDown();
      this.buttonAbout = new System.Windows.Forms.Button();
      this.checkBoxImmediateDownload = new System.Windows.Forms.CheckBox();
      this.buttonGetOptions = new System.Windows.Forms.Button();
      this.buttonConnect = new System.Windows.Forms.Button();
      this.pictureUserPicture = new System.Windows.Forms.PictureBox();
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.panelPhotobook = new System.Windows.Forms.Panel();
      this.groupBoxPhotobook = new System.Windows.Forms.GroupBox();
      this.buttonView = new System.Windows.Forms.Button();
      this.checkBoxSkipExisting = new System.Windows.Forms.CheckBox();
      this.splitContainerPhotos = new System.Windows.Forms.SplitContainer();
      this.treeViewPhotos = new Ascentium.Research.Windows.Forms.Components.ThreeStateTreeView();
      this.flowLayoutPanelOwnerUserOrAlbum = new System.Windows.Forms.FlowLayoutPanel();
      this.buttonExpandAll = new System.Windows.Forms.Button();
      this.buttonCollapseAll = new System.Windows.Forms.Button();
      this.buttonShowAlbum = new System.Windows.Forms.Button();
      this.buttonCheckAll = new System.Windows.Forms.Button();
      this.buttonUncheckAll = new System.Windows.Forms.Button();
      this.linkLabelViewLarge = new System.Windows.Forms.LinkLabel();
      this.labelDescriptionTitle = new System.Windows.Forms.Label();
      this.labelDateCreated = new System.Windows.Forms.Label();
      this.labelDescription = new System.Windows.Forms.Label();
      this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
      this.buttonBrowse = new System.Windows.Forms.Button();
      this.buttonDownload = new System.Windows.Forms.Button();
      this.labelDirectory = new System.Windows.Forms.Label();
      this.textBoxDirectory = new System.Windows.Forms.TextBox();
      this.contextMenuGetOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.retrieveOnlyRelevantPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.retrieveAllPhotosFromAllFriendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.includeAlbumCoverPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.includeAlbumsUploadedByYouToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.dialogBrowse = new System.Windows.Forms.FolderBrowserDialog();
      this.pictureBoxDownloader = new System.Windows.Forms.PictureBox();
      this.buttonCancelDownload = new System.Windows.Forms.Button();
      this.buttonCancelGetPhotos = new System.Windows.Forms.Button();
      this.progressBarDownloadPhoto = new System.Windows.Forms.ProgressBar();
      this.progressBarDownloadTotal = new System.Windows.Forms.ProgressBar();
      this.groupBoxConnect.SuspendLayout();
      this.panelTimeout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeoutTime)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureUserPicture)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.Panel2.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      this.panelPhotobook.SuspendLayout();
      this.groupBoxPhotobook.SuspendLayout();
      this.splitContainerPhotos.Panel1.SuspendLayout();
      this.splitContainerPhotos.Panel2.SuspendLayout();
      this.splitContainerPhotos.SuspendLayout();
      this.flowLayoutPanelOwnerUserOrAlbum.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
      this.contextMenuGetOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownloader)).BeginInit();
      this.SuspendLayout();
      // 
      // labelUserName
      // 
      this.labelUserName.AutoSize = true;
      this.labelUserName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelUserName.Location = new System.Drawing.Point(8, 192);
      this.labelUserName.Name = "labelUserName";
      this.labelUserName.Size = new System.Drawing.Size(38, 14);
      this.labelUserName.TabIndex = 5;
      this.labelUserName.Text = "Name";
      // 
      // imageListPhotos
      // 
      this.imageListPhotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPhotos.ImageStream")));
      this.imageListPhotos.TransparentColor = System.Drawing.Color.Transparent;
      this.imageListPhotos.Images.SetKeyName(0, "User.png");
      this.imageListPhotos.Images.SetKeyName(1, "Album.png");
      this.imageListPhotos.Images.SetKeyName(2, "Photo.png");
      this.imageListPhotos.Images.SetKeyName(3, "Album Cover.png");
      this.imageListPhotos.Images.SetKeyName(4, "Uncovered Album.png");
      this.imageListPhotos.Images.SetKeyName(5, "Untagged User.png");
      this.imageListPhotos.Images.SetKeyName(6, "Untagged Album.png");
      this.imageListPhotos.Images.SetKeyName(7, "Untagged Photo.png");
      this.imageListPhotos.Images.SetKeyName(8, "Untagged Album Cover.png");
      this.imageListPhotos.Images.SetKeyName(9, "Untagged Uncovered Album.png");
      this.imageListPhotos.Images.SetKeyName(10, "Albumless.png");
      // 
      // buttonGetPhotos
      // 
      this.buttonGetPhotos.Location = new System.Drawing.Point(8, 60);
      this.buttonGetPhotos.Name = "buttonGetPhotos";
      this.buttonGetPhotos.Size = new System.Drawing.Size(104, 40);
      this.buttonGetPhotos.TabIndex = 1;
      this.buttonGetPhotos.Text = "Get Photos";
      this.buttonGetPhotos.UseVisualStyleBackColor = true;
      this.buttonGetPhotos.Click += new System.EventHandler(this.buttonGetPhotos_Click);
      // 
      // groupBoxConnect
      // 
      this.groupBoxConnect.Controls.Add(this.panelTimeout);
      this.groupBoxConnect.Controls.Add(this.buttonAbout);
      this.groupBoxConnect.Controls.Add(this.checkBoxImmediateDownload);
      this.groupBoxConnect.Controls.Add(this.buttonGetOptions);
      this.groupBoxConnect.Controls.Add(this.buttonConnect);
      this.groupBoxConnect.Controls.Add(this.pictureUserPicture);
      this.groupBoxConnect.Controls.Add(this.labelUserName);
      this.groupBoxConnect.Controls.Add(this.buttonGetPhotos);
      this.groupBoxConnect.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBoxConnect.Location = new System.Drawing.Point(0, 0);
      this.groupBoxConnect.Name = "groupBoxConnect";
      this.groupBoxConnect.Size = new System.Drawing.Size(146, 408);
      this.groupBoxConnect.TabIndex = 0;
      this.groupBoxConnect.TabStop = false;
      this.groupBoxConnect.Text = "Connection";
      // 
      // panelTimeout
      // 
      this.panelTimeout.Controls.Add(this.labelTimeoutTimeSec);
      this.panelTimeout.Controls.Add(this.labelTimeoutTime);
      this.panelTimeout.Controls.Add(this.numericUpDownTimeoutTime);
      this.panelTimeout.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelTimeout.Location = new System.Drawing.Point(3, 360);
      this.panelTimeout.Name = "panelTimeout";
      this.panelTimeout.Size = new System.Drawing.Size(140, 45);
      this.panelTimeout.TabIndex = 15;
      // 
      // labelTimeoutTimeSec
      // 
      this.labelTimeoutTimeSec.AutoSize = true;
      this.labelTimeoutTimeSec.Location = new System.Drawing.Point(92, 24);
      this.labelTimeoutTimeSec.Name = "labelTimeoutTimeSec";
      this.labelTimeoutTimeSec.Size = new System.Drawing.Size(24, 13);
      this.labelTimeoutTimeSec.TabIndex = 17;
      this.labelTimeoutTimeSec.Text = "sec";
      // 
      // labelTimeoutTime
      // 
      this.labelTimeoutTime.AutoSize = true;
      this.labelTimeoutTime.Location = new System.Drawing.Point(4, 4);
      this.labelTimeoutTime.Name = "labelTimeoutTime";
      this.labelTimeoutTime.Size = new System.Drawing.Size(74, 13);
      this.labelTimeoutTime.TabIndex = 16;
      this.labelTimeoutTime.Text = "Timeout Time:";
      // 
      // numericUpDownTimeoutTime
      // 
      this.numericUpDownTimeoutTime.Location = new System.Drawing.Point(4, 20);
      this.numericUpDownTimeoutTime.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
      this.numericUpDownTimeoutTime.Name = "numericUpDownTimeoutTime";
      this.numericUpDownTimeoutTime.Size = new System.Drawing.Size(84, 20);
      this.numericUpDownTimeoutTime.TabIndex = 15;
      this.numericUpDownTimeoutTime.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
      // 
      // buttonAbout
      // 
      this.buttonAbout.Location = new System.Drawing.Point(8, 104);
      this.buttonAbout.Name = "buttonAbout";
      this.buttonAbout.Size = new System.Drawing.Size(80, 36);
      this.buttonAbout.TabIndex = 3;
      this.buttonAbout.Text = "About";
      this.buttonAbout.UseVisualStyleBackColor = true;
      this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
      // 
      // checkBoxImmediateDownload
      // 
      this.checkBoxImmediateDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.checkBoxImmediateDownload.Location = new System.Drawing.Point(8, 148);
      this.checkBoxImmediateDownload.Name = "checkBoxImmediateDownload";
      this.checkBoxImmediateDownload.Size = new System.Drawing.Size(124, 32);
      this.checkBoxImmediateDownload.TabIndex = 4;
      this.checkBoxImmediateDownload.Text = "Automatically start downloading";
      this.checkBoxImmediateDownload.UseVisualStyleBackColor = true;
      // 
      // buttonGetOptions
      // 
      this.buttonGetOptions.Image = global::FacebookPhotobook.Properties.Resources.Dropdown;
      this.buttonGetOptions.Location = new System.Drawing.Point(112, 60);
      this.buttonGetOptions.Name = "buttonGetOptions";
      this.buttonGetOptions.Size = new System.Drawing.Size(16, 40);
      this.buttonGetOptions.TabIndex = 2;
      this.buttonGetOptions.UseVisualStyleBackColor = true;
      this.buttonGetOptions.Click += new System.EventHandler(this.buttonGetOptions_Click);
      this.buttonGetOptions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGetOptions_MouseDown);
      // 
      // buttonConnect
      // 
      this.buttonConnect.Image = global::FacebookPhotobook.Properties.Resources.facebook_login;
      this.buttonConnect.Location = new System.Drawing.Point(8, 20);
      this.buttonConnect.Name = "buttonConnect";
      this.buttonConnect.Size = new System.Drawing.Size(120, 36);
      this.buttonConnect.TabIndex = 0;
      this.buttonConnect.UseVisualStyleBackColor = true;
      this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
      // 
      // pictureUserPicture
      // 
      this.pictureUserPicture.BackColor = System.Drawing.Color.Transparent;
      this.pictureUserPicture.Location = new System.Drawing.Point(8, 208);
      this.pictureUserPicture.Name = "pictureUserPicture";
      this.pictureUserPicture.Size = new System.Drawing.Size(120, 120);
      this.pictureUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureUserPicture.TabIndex = 5;
      this.pictureUserPicture.TabStop = false;
      // 
      // splitContainerMain
      // 
      this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainerMain.Location = new System.Drawing.Point(8, 8);
      this.splitContainerMain.Name = "splitContainerMain";
      // 
      // splitContainerMain.Panel1
      // 
      this.splitContainerMain.Panel1.Controls.Add(this.groupBoxConnect);
      // 
      // splitContainerMain.Panel2
      // 
      this.splitContainerMain.Panel2.Controls.Add(this.panelPhotobook);
      this.splitContainerMain.Size = new System.Drawing.Size(662, 408);
      this.splitContainerMain.SplitterDistance = 146;
      this.splitContainerMain.TabIndex = 0;
      // 
      // panelPhotobook
      // 
      this.panelPhotobook.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panelPhotobook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panelPhotobook.Controls.Add(this.groupBoxPhotobook);
      this.panelPhotobook.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelPhotobook.Location = new System.Drawing.Point(0, 0);
      this.panelPhotobook.Name = "panelPhotobook";
      this.panelPhotobook.Size = new System.Drawing.Size(512, 408);
      this.panelPhotobook.TabIndex = 6;
      // 
      // groupBoxPhotobook
      // 
      this.groupBoxPhotobook.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.groupBoxPhotobook.Controls.Add(this.buttonView);
      this.groupBoxPhotobook.Controls.Add(this.checkBoxSkipExisting);
      this.groupBoxPhotobook.Controls.Add(this.splitContainerPhotos);
      this.groupBoxPhotobook.Controls.Add(this.buttonBrowse);
      this.groupBoxPhotobook.Controls.Add(this.buttonDownload);
      this.groupBoxPhotobook.Controls.Add(this.labelDirectory);
      this.groupBoxPhotobook.Controls.Add(this.textBoxDirectory);
      this.groupBoxPhotobook.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBoxPhotobook.Location = new System.Drawing.Point(0, 0);
      this.groupBoxPhotobook.Name = "groupBoxPhotobook";
      this.groupBoxPhotobook.Size = new System.Drawing.Size(508, 404);
      this.groupBoxPhotobook.TabIndex = 0;
      this.groupBoxPhotobook.TabStop = false;
      this.groupBoxPhotobook.Text = "Photobook";
      this.groupBoxPhotobook.Visible = false;
      // 
      // buttonView
      // 
      this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonView.Location = new System.Drawing.Point(244, 376);
      this.buttonView.Name = "buttonView";
      this.buttonView.Size = new System.Drawing.Size(76, 22);
      this.buttonView.TabIndex = 3;
      this.buttonView.Text = "View...";
      this.buttonView.UseVisualStyleBackColor = true;
      this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
      // 
      // checkBoxSkipExisting
      // 
      this.checkBoxSkipExisting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.checkBoxSkipExisting.AutoSize = true;
      this.checkBoxSkipExisting.Checked = true;
      this.checkBoxSkipExisting.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxSkipExisting.Location = new System.Drawing.Point(8, 380);
      this.checkBoxSkipExisting.Name = "checkBoxSkipExisting";
      this.checkBoxSkipExisting.Size = new System.Drawing.Size(85, 17);
      this.checkBoxSkipExisting.TabIndex = 2;
      this.checkBoxSkipExisting.Text = "Skip existing";
      this.checkBoxSkipExisting.UseVisualStyleBackColor = true;
      // 
      // splitContainerPhotos
      // 
      this.splitContainerPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainerPhotos.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainerPhotos.Location = new System.Drawing.Point(8, 20);
      this.splitContainerPhotos.Name = "splitContainerPhotos";
      // 
      // splitContainerPhotos.Panel1
      // 
      this.splitContainerPhotos.Panel1.Controls.Add(this.treeViewPhotos);
      this.splitContainerPhotos.Panel1.Controls.Add(this.flowLayoutPanelOwnerUserOrAlbum);
      // 
      // splitContainerPhotos.Panel2
      // 
      this.splitContainerPhotos.Panel2.Controls.Add(this.linkLabelViewLarge);
      this.splitContainerPhotos.Panel2.Controls.Add(this.labelDescriptionTitle);
      this.splitContainerPhotos.Panel2.Controls.Add(this.labelDateCreated);
      this.splitContainerPhotos.Panel2.Controls.Add(this.labelDescription);
      this.splitContainerPhotos.Panel2.Controls.Add(this.pictureBoxPreview);
      this.splitContainerPhotos.Size = new System.Drawing.Size(492, 312);
      this.splitContainerPhotos.SplitterDistance = 358;
      this.splitContainerPhotos.TabIndex = 0;
      // 
      // treeViewPhotos
      // 
      this.treeViewPhotos.CheckBoxes = true;
      this.treeViewPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeViewPhotos.HideSelection = false;
      this.treeViewPhotos.ImageIndex = 0;
      this.treeViewPhotos.ImageList = this.imageListPhotos;
      this.treeViewPhotos.Location = new System.Drawing.Point(0, 28);
      this.treeViewPhotos.Name = "treeViewPhotos";
      this.treeViewPhotos.SelectedImageIndex = 0;
      this.treeViewPhotos.Size = new System.Drawing.Size(358, 284);
      this.treeViewPhotos.TabIndex = 0;
      this.treeViewPhotos.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewPhotos_NodeMouseDoubleClick);
      this.treeViewPhotos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPhotos_AfterSelect);
      // 
      // flowLayoutPanelOwnerUserOrAlbum
      // 
      this.flowLayoutPanelOwnerUserOrAlbum.Controls.Add(this.buttonExpandAll);
      this.flowLayoutPanelOwnerUserOrAlbum.Controls.Add(this.buttonCollapseAll);
      this.flowLayoutPanelOwnerUserOrAlbum.Controls.Add(this.buttonShowAlbum);
      this.flowLayoutPanelOwnerUserOrAlbum.Controls.Add(this.buttonCheckAll);
      this.flowLayoutPanelOwnerUserOrAlbum.Controls.Add(this.buttonUncheckAll);
      this.flowLayoutPanelOwnerUserOrAlbum.Dock = System.Windows.Forms.DockStyle.Top;
      this.flowLayoutPanelOwnerUserOrAlbum.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanelOwnerUserOrAlbum.Name = "flowLayoutPanelOwnerUserOrAlbum";
      this.flowLayoutPanelOwnerUserOrAlbum.Size = new System.Drawing.Size(358, 28);
      this.flowLayoutPanelOwnerUserOrAlbum.TabIndex = 0;
      // 
      // buttonExpandAll
      // 
      this.buttonExpandAll.Location = new System.Drawing.Point(3, 3);
      this.buttonExpandAll.Name = "buttonExpandAll";
      this.buttonExpandAll.Size = new System.Drawing.Size(56, 22);
      this.buttonExpandAll.TabIndex = 0;
      this.buttonExpandAll.Text = "Expand";
      this.buttonExpandAll.UseVisualStyleBackColor = true;
      this.buttonExpandAll.Click += new System.EventHandler(this.buttonExpandAll_Click);
      // 
      // buttonCollapseAll
      // 
      this.buttonCollapseAll.Location = new System.Drawing.Point(65, 3);
      this.buttonCollapseAll.Name = "buttonCollapseAll";
      this.buttonCollapseAll.Size = new System.Drawing.Size(56, 22);
      this.buttonCollapseAll.TabIndex = 1;
      this.buttonCollapseAll.Text = "Collapse";
      this.buttonCollapseAll.UseVisualStyleBackColor = true;
      this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
      // 
      // buttonShowAlbum
      // 
      this.buttonShowAlbum.Location = new System.Drawing.Point(127, 3);
      this.buttonShowAlbum.Name = "buttonShowAlbum";
      this.buttonShowAlbum.Size = new System.Drawing.Size(97, 22);
      this.buttonShowAlbum.TabIndex = 2;
      this.buttonShowAlbum.Text = "Show Albums";
      this.buttonShowAlbum.UseVisualStyleBackColor = true;
      this.buttonShowAlbum.Click += new System.EventHandler(this.buttonShowAlbums_Click);
      // 
      // buttonCheckAll
      // 
      this.buttonCheckAll.Location = new System.Drawing.Point(230, 3);
      this.buttonCheckAll.Name = "buttonCheckAll";
      this.buttonCheckAll.Size = new System.Drawing.Size(22, 22);
      this.buttonCheckAll.TabIndex = 3;
      this.buttonCheckAll.Text = "+";
      this.buttonCheckAll.UseVisualStyleBackColor = true;
      this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
      // 
      // buttonUncheckAll
      // 
      this.buttonUncheckAll.Location = new System.Drawing.Point(258, 3);
      this.buttonUncheckAll.Name = "buttonUncheckAll";
      this.buttonUncheckAll.Size = new System.Drawing.Size(22, 22);
      this.buttonUncheckAll.TabIndex = 4;
      this.buttonUncheckAll.Text = "-";
      this.buttonUncheckAll.UseVisualStyleBackColor = true;
      this.buttonUncheckAll.Click += new System.EventHandler(this.buttonUncheckAll_Click);
      // 
      // linkLabelViewLarge
      // 
      this.linkLabelViewLarge.AutoSize = true;
      this.linkLabelViewLarge.Location = new System.Drawing.Point(4, 92);
      this.linkLabelViewLarge.Name = "linkLabelViewLarge";
      this.linkLabelViewLarge.Size = new System.Drawing.Size(92, 13);
      this.linkLabelViewLarge.TabIndex = 0;
      this.linkLabelViewLarge.TabStop = true;
      this.linkLabelViewLarge.Text = "View Large Image";
      this.linkLabelViewLarge.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelViewLarge_LinkClicked);
      // 
      // labelDescriptionTitle
      // 
      this.labelDescriptionTitle.AutoSize = true;
      this.labelDescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelDescriptionTitle.Location = new System.Drawing.Point(4, 136);
      this.labelDescriptionTitle.Name = "labelDescriptionTitle";
      this.labelDescriptionTitle.Size = new System.Drawing.Size(71, 13);
      this.labelDescriptionTitle.TabIndex = 2;
      this.labelDescriptionTitle.Text = "Description";
      // 
      // labelDateCreated
      // 
      this.labelDateCreated.AutoSize = true;
      this.labelDateCreated.ForeColor = System.Drawing.SystemColors.GrayText;
      this.labelDateCreated.Location = new System.Drawing.Point(4, 112);
      this.labelDateCreated.Name = "labelDateCreated";
      this.labelDateCreated.Size = new System.Drawing.Size(30, 13);
      this.labelDateCreated.TabIndex = 1;
      this.labelDateCreated.Text = "Date";
      // 
      // labelDescription
      // 
      this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.labelDescription.Location = new System.Drawing.Point(4, 152);
      this.labelDescription.Name = "labelDescription";
      this.labelDescription.Size = new System.Drawing.Size(124, 156);
      this.labelDescription.TabIndex = 3;
      // 
      // pictureBoxPreview
      // 
      this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBoxPreview.BackColor = System.Drawing.Color.Transparent;
      this.pictureBoxPreview.Location = new System.Drawing.Point(4, 28);
      this.pictureBoxPreview.Name = "pictureBoxPreview";
      this.pictureBoxPreview.Size = new System.Drawing.Size(64, 60);
      this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBoxPreview.TabIndex = 6;
      this.pictureBoxPreview.TabStop = false;
      this.pictureBoxPreview.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBoxPreview_LoadCompleted);
      this.pictureBoxPreview.SizeChanged += new System.EventHandler(this.pictureBoxPreview_SizeChanged);
      // 
      // buttonBrowse
      // 
      this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonBrowse.Location = new System.Drawing.Point(320, 376);
      this.buttonBrowse.Name = "buttonBrowse";
      this.buttonBrowse.Size = new System.Drawing.Size(76, 22);
      this.buttonBrowse.TabIndex = 4;
      this.buttonBrowse.Text = "Browse...";
      this.buttonBrowse.UseVisualStyleBackColor = true;
      this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
      // 
      // buttonDownload
      // 
      this.buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDownload.Location = new System.Drawing.Point(400, 336);
      this.buttonDownload.Name = "buttonDownload";
      this.buttonDownload.Size = new System.Drawing.Size(100, 64);
      this.buttonDownload.TabIndex = 5;
      this.buttonDownload.Text = "Download Selected Photos";
      this.buttonDownload.UseVisualStyleBackColor = true;
      this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
      // 
      // labelDirectory
      // 
      this.labelDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.labelDirectory.AutoSize = true;
      this.labelDirectory.Location = new System.Drawing.Point(8, 340);
      this.labelDirectory.Name = "labelDirectory";
      this.labelDirectory.Size = new System.Drawing.Size(49, 13);
      this.labelDirectory.TabIndex = 0;
      this.labelDirectory.Text = "Directory";
      // 
      // textBoxDirectory
      // 
      this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxDirectory.Location = new System.Drawing.Point(8, 356);
      this.textBoxDirectory.Name = "textBoxDirectory";
      this.textBoxDirectory.Size = new System.Drawing.Size(388, 20);
      this.textBoxDirectory.TabIndex = 1;
      // 
      // contextMenuGetOptions
      // 
      this.contextMenuGetOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retrieveOnlyRelevantPhotosToolStripMenuItem,
            this.retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem,
            this.retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem,
            this.retrieveAllPhotosFromAllFriendsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.includeAlbumCoverPhotosToolStripMenuItem,
            this.includeAlbumsUploadedByYouToolStripMenuItem1});
      this.contextMenuGetOptions.Name = "contextMenuGetOptions";
      this.contextMenuGetOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.contextMenuGetOptions.Size = new System.Drawing.Size(323, 142);
      this.contextMenuGetOptions.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuGetOptions_Opening);
      // 
      // retrieveOnlyRelevantPhotosToolStripMenuItem
      // 
      this.retrieveOnlyRelevantPhotosToolStripMenuItem.Name = "retrieveOnlyRelevantPhotosToolStripMenuItem";
      this.retrieveOnlyRelevantPhotosToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
      this.retrieveOnlyRelevantPhotosToolStripMenuItem.Text = "Retrieve only relevant photos";
      this.retrieveOnlyRelevantPhotosToolStripMenuItem.Click += new System.EventHandler(this.retrieveOnlyRelevantPhotosToolStripMenuItem_Click);
      // 
      // retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem
      // 
      this.retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem.Name = "retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem";
      this.retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
      this.retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem.Text = "Retrieve all photos from included albums";
      this.retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem.Click += new System.EventHandler(this.retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem_Click);
      // 
      // retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem
      // 
      this.retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem.Name = "retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem";
      this.retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
      this.retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem.Text = "Retrieve all photos from all included user\'s albums";
      this.retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem.Click += new System.EventHandler(this.retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem_Click);
      // 
      // retrieveAllPhotosFromAllFriendsToolStripMenuItem
      // 
      this.retrieveAllPhotosFromAllFriendsToolStripMenuItem.Name = "retrieveAllPhotosFromAllFriendsToolStripMenuItem";
      this.retrieveAllPhotosFromAllFriendsToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
      this.retrieveAllPhotosFromAllFriendsToolStripMenuItem.Text = "Retrieve all photos from all friends";
      this.retrieveAllPhotosFromAllFriendsToolStripMenuItem.Click += new System.EventHandler(this.retrieveAllPhotosFromAllFriendsToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(319, 6);
      // 
      // includeAlbumCoverPhotosToolStripMenuItem
      // 
      this.includeAlbumCoverPhotosToolStripMenuItem.Name = "includeAlbumCoverPhotosToolStripMenuItem";
      this.includeAlbumCoverPhotosToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
      this.includeAlbumCoverPhotosToolStripMenuItem.Text = "Include album cover photos";
      this.includeAlbumCoverPhotosToolStripMenuItem.Click += new System.EventHandler(this.includeAlbumCoversToolStripMenuItem_Click);
      // 
      // includeAlbumsUploadedByYouToolStripMenuItem1
      // 
      this.includeAlbumsUploadedByYouToolStripMenuItem1.Name = "includeAlbumsUploadedByYouToolStripMenuItem1";
      this.includeAlbumsUploadedByYouToolStripMenuItem1.Size = new System.Drawing.Size(322, 22);
      this.includeAlbumsUploadedByYouToolStripMenuItem1.Text = "Include albums uploaded by &you";
      this.includeAlbumsUploadedByYouToolStripMenuItem1.Click += new System.EventHandler(this.includeAlbumsUploadedByYouToolStripMenuItem_Click);
      // 
      // dialogBrowse
      // 
      this.dialogBrowse.Description = "Browse for photosbook directory";
      // 
      // pictureBoxDownloader
      // 
      this.pictureBoxDownloader.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pictureBoxDownloader.Location = new System.Drawing.Point(288, 244);
      this.pictureBoxDownloader.Name = "pictureBoxDownloader";
      this.pictureBoxDownloader.Size = new System.Drawing.Size(100, 72);
      this.pictureBoxDownloader.TabIndex = 11;
      this.pictureBoxDownloader.TabStop = false;
      this.pictureBoxDownloader.Visible = false;
      this.pictureBoxDownloader.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.pictureBoxDownloader_LoadProgressChanged);
      this.pictureBoxDownloader.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBoxDownloader_LoadCompleted);
      // 
      // buttonCancelDownload
      // 
      this.buttonCancelDownload.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.buttonCancelDownload.Location = new System.Drawing.Point(288, 178);
      this.buttonCancelDownload.Name = "buttonCancelDownload";
      this.buttonCancelDownload.Size = new System.Drawing.Size(100, 64);
      this.buttonCancelDownload.TabIndex = 0;
      this.buttonCancelDownload.Text = "Cancel Downloading";
      this.buttonCancelDownload.UseVisualStyleBackColor = true;
      this.buttonCancelDownload.Visible = false;
      this.buttonCancelDownload.Click += new System.EventHandler(this.buttonCancelDownload_Click);
      // 
      // buttonCancelGetPhotos
      // 
      this.buttonCancelGetPhotos.Location = new System.Drawing.Point(162, 12);
      this.buttonCancelGetPhotos.Name = "buttonCancelGetPhotos";
      this.buttonCancelGetPhotos.Size = new System.Drawing.Size(100, 64);
      this.buttonCancelGetPhotos.TabIndex = 3;
      this.buttonCancelGetPhotos.Text = "Cancel Photo Retrieval";
      this.buttonCancelGetPhotos.UseVisualStyleBackColor = true;
      this.buttonCancelGetPhotos.Visible = false;
      this.buttonCancelGetPhotos.Click += new System.EventHandler(this.buttonCancelGetPhotos_Click);
      // 
      // progressBarDownloadPhoto
      // 
      this.progressBarDownloadPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarDownloadPhoto.Location = new System.Drawing.Point(4, 400);
      this.progressBarDownloadPhoto.Name = "progressBarDownloadPhoto";
      this.progressBarDownloadPhoto.Size = new System.Drawing.Size(668, 16);
      this.progressBarDownloadPhoto.TabIndex = 2;
      this.progressBarDownloadPhoto.Visible = false;
      // 
      // progressBarDownloadTotal
      // 
      this.progressBarDownloadTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBarDownloadTotal.Location = new System.Drawing.Point(4, 380);
      this.progressBarDownloadTotal.Name = "progressBarDownloadTotal";
      this.progressBarDownloadTotal.Size = new System.Drawing.Size(668, 16);
      this.progressBarDownloadTotal.TabIndex = 1;
      this.progressBarDownloadTotal.Visible = false;
      // 
      // formMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(677, 421);
      this.Controls.Add(this.progressBarDownloadTotal);
      this.Controls.Add(this.progressBarDownloadPhoto);
      this.Controls.Add(this.buttonCancelGetPhotos);
      this.Controls.Add(this.buttonCancelDownload);
      this.Controls.Add(this.pictureBoxDownloader);
      this.Controls.Add(this.splitContainerMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "formMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Facebook Photobook";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
      this.groupBoxConnect.ResumeLayout(false);
      this.groupBoxConnect.PerformLayout();
      this.panelTimeout.ResumeLayout(false);
      this.panelTimeout.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeoutTime)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureUserPicture)).EndInit();
      this.splitContainerMain.Panel1.ResumeLayout(false);
      this.splitContainerMain.Panel2.ResumeLayout(false);
      this.splitContainerMain.ResumeLayout(false);
      this.panelPhotobook.ResumeLayout(false);
      this.groupBoxPhotobook.ResumeLayout(false);
      this.groupBoxPhotobook.PerformLayout();
      this.splitContainerPhotos.Panel1.ResumeLayout(false);
      this.splitContainerPhotos.Panel2.ResumeLayout(false);
      this.splitContainerPhotos.Panel2.PerformLayout();
      this.splitContainerPhotos.ResumeLayout(false);
      this.flowLayoutPanelOwnerUserOrAlbum.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
      this.contextMenuGetOptions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownloader)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonConnect;
    private System.Windows.Forms.PictureBox pictureUserPicture;
    private System.Windows.Forms.Label labelUserName;
    private System.Windows.Forms.GroupBox groupBoxConnect;
    private System.Windows.Forms.SplitContainer splitContainerMain;
    private System.Windows.Forms.Button buttonGetPhotos;
    private System.Windows.Forms.ImageList imageListPhotos;
    private System.Windows.Forms.Panel panelPhotobook;
    private System.Windows.Forms.GroupBox groupBoxPhotobook;
    private System.Windows.Forms.CheckBox checkBoxSkipExisting;
    private System.Windows.Forms.Button buttonBrowse;
    private System.Windows.Forms.Button buttonDownload;
    private System.Windows.Forms.SplitContainer splitContainerPhotos;
    private Ascentium.Research.Windows.Forms.Components.ThreeStateTreeView treeViewPhotos;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOwnerUserOrAlbum;
    private System.Windows.Forms.Button buttonExpandAll;
    private System.Windows.Forms.Button buttonCollapseAll;
    private System.Windows.Forms.Button buttonShowAlbum;
    private System.Windows.Forms.TextBox textBoxDirectory;
    private System.Windows.Forms.Label labelDirectory;
    private System.Windows.Forms.Button buttonCheckAll;
    private System.Windows.Forms.Button buttonUncheckAll;
    private System.Windows.Forms.PictureBox pictureBoxPreview;
    private System.Windows.Forms.Button buttonGetOptions;
    private System.Windows.Forms.ContextMenuStrip contextMenuGetOptions;
    private System.Windows.Forms.ToolStripMenuItem includeAlbumsUploadedByYouToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem includeAlbumCoverPhotosToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem retrieveOnlyRelevantPhotosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem retrieveAllPhotosFromIncludedAlbumsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem retrieveAllPhotosFromAllIncludedUsersAlbumsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem retrieveAllPhotosFromAllFriendsToolStripMenuItem;
    private System.Windows.Forms.Label labelDescription;
    private System.Windows.Forms.Label labelDateCreated;
    private System.Windows.Forms.Label labelDescriptionTitle;
    private System.Windows.Forms.Button buttonView;
    private System.Windows.Forms.CheckBox checkBoxImmediateDownload;
    private System.Windows.Forms.FolderBrowserDialog dialogBrowse;
    private System.Windows.Forms.LinkLabel linkLabelViewLarge;
    private System.Windows.Forms.PictureBox pictureBoxDownloader;
    private System.Windows.Forms.Button buttonCancelDownload;
    private System.Windows.Forms.Button buttonCancelGetPhotos;
    private System.Windows.Forms.ProgressBar progressBarDownloadPhoto;
    private System.Windows.Forms.ProgressBar progressBarDownloadTotal;
    private System.Windows.Forms.Button buttonAbout;
    private System.Windows.Forms.Panel panelTimeout;
    private System.Windows.Forms.Label labelTimeoutTimeSec;
    private System.Windows.Forms.Label labelTimeoutTime;
    private System.Windows.Forms.NumericUpDown numericUpDownTimeoutTime;
  }
}

