// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.Form_About
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class Form_About : Form
  {
    private IContainer components;
    private GroupBox groupBox1;
    private Label label1;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private PictureBox pictureBox1;
    private TextBox textBox_cCompany;
    private TextBox textBox_cHWID;
    private TextBox textBox_cName;

    public Form_About() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void Form_About_Load(object sender, EventArgs e)
    {
      StringBuilder lpBuffer1 = new StringBuilder(100);
      StringBuilder lpBuffer2 = new StringBuilder(500);
      if (Form_About.Kernel32.GetEnvironmentVariable("WLHardwareGetID", lpBuffer1, 100))
        this.textBox_cHWID.Text = lpBuffer1.ToString();
      if (!Form_About.Kernel32.GetEnvironmentVariable("WLRegGetLicenseInfo", lpBuffer2, 500))
        return;
      string[] strArray = lpBuffer2.ToString().Split(',');
      this.textBox_cName.Text = strArray[0].TrimStart(' ');
      this.textBox_cCompany.Text = strArray[1].TrimStart(' ');
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.groupBox1 = new GroupBox();
      this.textBox_cHWID = new TextBox();
      this.textBox_cCompany = new TextBox();
      this.textBox_cName = new TextBox();
      this.label6 = new Label();
      this.pictureBox1 = new PictureBox();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.BackColor = Color.Transparent;
      this.label1.Font = new Font("Segoe UI", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Black;
      this.label1.Location = new Point(61, 17);
      this.label1.Name = "label1";
      this.label1.Size = new Size(243, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "MU.ToolKit [Silver Edition]";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(10, 71);
      this.label3.Name = "label3";
      this.label3.Size = new Size(35, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "HWID:";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(10, 23);
      this.label4.Name = "label4";
      this.label4.Size = new Size(35, 12);
      this.label4.TabIndex = 3;
      this.label4.Text = "Name:";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(10, 47);
      this.label5.Name = "label5";
      this.label5.Size = new Size(53, 12);
      this.label5.TabIndex = 4;
      this.label5.Text = "Company:";
      this.groupBox1.Controls.Add((Control) this.textBox_cHWID);
      this.groupBox1.Controls.Add((Control) this.textBox_cCompany);
      this.groupBox1.Controls.Add((Control) this.textBox_cName);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Location = new Point(12, 55);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(333, 101);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "This copy is Licensed to:";
      this.textBox_cHWID.Location = new Point(70, 68);
      this.textBox_cHWID.Name = "textBox_cHWID";
      this.textBox_cHWID.ReadOnly = true;
      this.textBox_cHWID.Size = new Size(254, 21);
      this.textBox_cHWID.TabIndex = 8;
      this.textBox_cHWID.Text = "XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX";
      this.textBox_cCompany.Location = new Point(70, 44);
      this.textBox_cCompany.Name = "textBox_cCompany";
      this.textBox_cCompany.ReadOnly = true;
      this.textBox_cCompany.Size = new Size(254, 21);
      this.textBox_cCompany.TabIndex = 7;
      this.textBox_cCompany.Text = "XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX";
      this.textBox_cName.Location = new Point(70, 20);
      this.textBox_cName.Name = "textBox_cName";
      this.textBox_cName.ReadOnly = true;
      this.textBox_cName.Size = new Size(254, 21);
      this.textBox_cName.TabIndex = 6;
      this.textBox_cName.Text = "XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(18, 170);
      this.label6.Name = "label6";
      this.label6.Size = new Size(326, 19);
      this.label6.TabIndex = 7;
      this.label6.Text = "MU.ToolKit is coded and developed by © TopReal.IT\r\n";
      this.pictureBox1.BackgroundImage = (Image) Resources.pictureBox1_BackgroundImage;
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox1.Location = new Point(118, 199);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(113, 57);
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Control;
      this.ClientSize = new Size(359, 272);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.label1);
      this.ForeColor = Color.Black;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Form_About);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "About";
      this.Load += new EventHandler(this.Form_About_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private class Kernel32
    {
      [DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall)]
      public static extern bool GetEnvironmentVariable(
        string lpName,
        StringBuilder lpBuffer,
        int nSize);
    }
  }
}
