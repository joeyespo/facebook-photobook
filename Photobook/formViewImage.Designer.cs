namespace Photobook
{
  partial class formViewImage
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
      this.imagePaintBox = new PaintBox.ImagePaintBox();
      this.pictureBoxDownloader = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownloader)).BeginInit();
      this.SuspendLayout();
      // 
      // imagePaintBox
      // 
      this.imagePaintBox.CanvasSize = new System.Drawing.Size(0, 0);
      this.imagePaintBox.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.imagePaintBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.imagePaintBox.Location = new System.Drawing.Point(0, 0);
      this.imagePaintBox.Name = "imagePaintBox";
      this.imagePaintBox.Size = new System.Drawing.Size(714, 487);
      this.imagePaintBox.SmallChange = 20;
      this.imagePaintBox.TabIndex = 0;
      this.imagePaintBox.Zoom = 1;
      this.imagePaintBox.ZoomX = 1;
      this.imagePaintBox.ZoomY = 1;
      this.imagePaintBox.Click += new System.EventHandler(this.imagePaintBox_Click);
      this.imagePaintBox.DoubleClick += new System.EventHandler(this.imagePaintBox_DoubleClick);
      // 
      // pictureBoxDownloader
      // 
      this.pictureBoxDownloader.Location = new System.Drawing.Point(12, 12);
      this.pictureBoxDownloader.Name = "pictureBoxDownloader";
      this.pictureBoxDownloader.Size = new System.Drawing.Size(76, 60);
      this.pictureBoxDownloader.TabIndex = 1;
      this.pictureBoxDownloader.TabStop = false;
      this.pictureBoxDownloader.Visible = false;
      this.pictureBoxDownloader.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBoxDownloader_LoadCompleted);
      // 
      // formViewImage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(714, 487);
      this.Controls.Add(this.imagePaintBox);
      this.Controls.Add(this.pictureBoxDownloader);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "formViewImage";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "View Image";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownloader)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private PaintBox.ImagePaintBox imagePaintBox;
    private System.Windows.Forms.PictureBox pictureBoxDownloader;
  }
}