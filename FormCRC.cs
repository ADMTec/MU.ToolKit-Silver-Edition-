// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.FormCRC
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class FormCRC : Form
  {
    private Button button_BrowseFile;
    private IContainer components;
    private Label label1;
    private TextBox textBox_CRC;

    public FormCRC() => this.InitializeComponent();

    private void button_BrowseFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.textBox_CRC.Text = "0x" + this.ComputeCRC(File.ReadAllBytes(openFileDialog.FileName)).ToString("X");
    }

    private long ComputeCRC(byte[] data)
    {
      long num1 = 0;
      foreach (byte num2 in data)
      {
        num1 ^= (long) ((int) num2 << 8);
        for (int index = 0; index < 8; ++index)
        {
          if ((num1 & 32768L) == 32768L)
            num1 = num1 << 1 ^ 270611557L;
          else
            num1 <<= 1;
        }
      }
      return num1 & (long) uint.MaxValue;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.button_BrowseFile = new Button();
      this.label1 = new Label();
      this.textBox_CRC = new TextBox();
      this.SuspendLayout();
      this.button_BrowseFile.Location = new Point(12, 11);
      this.button_BrowseFile.Name = "button_BrowseFile";
      this.button_BrowseFile.Size = new Size(241, 30);
      this.button_BrowseFile.TabIndex = 0;
      this.button_BrowseFile.Text = "Browse a File";
      this.button_BrowseFile.UseVisualStyleBackColor = true;
      this.button_BrowseFile.Click += new EventHandler(this.button_BrowseFile_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 50);
      this.label1.Name = "label1";
      this.label1.Size = new Size(65, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "CRC Value:";
      this.textBox_CRC.Location = new Point(80, 47);
      this.textBox_CRC.Name = "textBox_CRC";
      this.textBox_CRC.ReadOnly = true;
      this.textBox_CRC.Size = new Size(173, 21);
      this.textBox_CRC.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(265, 77);
      this.Controls.Add((Control) this.textBox_CRC);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button_BrowseFile);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = nameof (FormCRC);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "MU CRC Calculator";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
