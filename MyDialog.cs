// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.MyDialog
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class MyDialog : Form
  {
    private IContainer components;
    private Label label_NewVer;
    private Label label_ProductVer;
    private Label label1;
    private Label label2;
    private string Link = string.Empty;
    private LinkLabel linkLabel_Download;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;

    public MyDialog(string NewVersion, string Location)
    {
      this.InitializeComponent();
      this.label_NewVer.Text = NewVersion;
      this.Link = Location;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.linkLabel_Download = new LinkLabel();
      this.label_ProductVer = new Label();
      this.label_NewVer = new Label();
      this.pictureBox2 = new PictureBox();
      this.pictureBox1 = new PictureBox();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point((int) sbyte.MaxValue, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(119, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "Your Version............";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point((int) sbyte.MaxValue, 40);
      this.label2.Name = "label2";
      this.label2.Size = new Size(121, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Required Version....";
      this.linkLabel_Download.AutoSize = true;
      this.linkLabel_Download.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.linkLabel_Download.Location = new Point(161, 69);
      this.linkLabel_Download.Name = "linkLabel_Download";
      this.linkLabel_Download.Size = new Size(163, 17);
      this.linkLabel_Download.TabIndex = 4;
      this.linkLabel_Download.TabStop = true;
      this.linkLabel_Download.Text = ">> Click here to Get it! <<";
      this.linkLabel_Download.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel_Download_LinkClicked);
      this.label_ProductVer.AutoSize = true;
      this.label_ProductVer.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_ProductVer.ForeColor = Color.SteelBlue;
      this.label_ProductVer.Location = new Point(245, 12);
      this.label_ProductVer.Name = "label_ProductVer";
      this.label_ProductVer.Size = new Size(43, 17);
      this.label_ProductVer.TabIndex = 5;
      this.label_ProductVer.Text = "label3";
      this.label_NewVer.AutoSize = true;
      this.label_NewVer.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label_NewVer.ForeColor = Color.DarkRed;
      this.label_NewVer.Location = new Point(245, 40);
      this.label_NewVer.Name = "label_NewVer";
      this.label_NewVer.Size = new Size(43, 17);
      this.label_NewVer.TabIndex = 6;
      this.label_NewVer.Text = "label4";
      this.pictureBox2.BackColor = Color.Gainsboro;
      this.pictureBox2.Location = new Point(-1, 100);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(353, 50);
      this.pictureBox2.TabIndex = 1;
      this.pictureBox2.TabStop = false;
      this.pictureBox1.BackgroundImage = (Image) Resources.pictureBox1_BackgroundImage;
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox1.Location = new Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(100, 71);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.WhiteSmoke;
      this.ClientSize = new Size(349, 148);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.label_NewVer);
      this.Controls.Add((Control) this.label_ProductVer);
      this.Controls.Add((Control) this.linkLabel_Download);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.pictureBox1);
      this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (MyDialog);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Unsupported Version Detected";
      this.TopMost = true;
      this.Load += new EventHandler(this.MyDialog_Load);
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void linkLabel_Download_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(this.Link);
      this.Close();
    }

    private void MyDialog_Load(object sender, EventArgs e)
    {
      new SoundPlayer((Stream) Resources.notify).Play();
      this.label_ProductVer.Text = "v" + this.ProductVersion;
    }
  }
}
