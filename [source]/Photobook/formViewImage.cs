using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Photobook
{
  public partial class formViewImage : Form
  {
    formViewImage()
    {
      InitializeComponent();
    }

    public formViewImage(string imageUrl)
      : this()
    {
      pictureBoxDownloader.LoadAsync(imageUrl);
      imagePaintBox.Image = pictureBoxDownloader.InitialImage;
    }
    public formViewImage(Image image)
      : this()
    {
      imagePaintBox.Image = image;
    }

    private void pictureBoxDownloader_LoadCompleted(object sender, AsyncCompletedEventArgs e)
    {
      imagePaintBox.Image = pictureBoxDownloader.Image;
    }

    private void imagePaintBox_DoubleClick(object sender, EventArgs e)
    {
      this.Close();
    }

    private void imagePaintBox_Click(object sender, EventArgs e)
    {
      if ((imagePaintBox.CanvasLocation.X < 0) || (imagePaintBox.CanvasLocation.Y < 0)
        || (imagePaintBox.CanvasSize.Width > imagePaintBox.DisplayRectangle.Width) || (imagePaintBox.CanvasSize.Height > imagePaintBox.DisplayRectangle.Height))
      return;
      this.Close();
    }
  }
}