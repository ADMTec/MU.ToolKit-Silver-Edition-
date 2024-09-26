// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.RegisterationForm
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class RegisterationForm : Form
  {
    private Button button_Activate;
    private IContainer components;
    private bool isActivated;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox textBox_HWID;
    private TextBox textBox_Key;
    private TextBox textBox_Name;
    private TextBox textBox_Org;

    public RegisterationForm() => this.InitializeComponent();

    private void button_Activate_Click(object sender, EventArgs e)
    {
      StringBuilder lpBuffer = new StringBuilder(500)
      {
        Length = 0
      };
      lpBuffer.Append(this.textBox_Name.Text + "," + this.textBox_Org.Text + ",0," + this.textBox_Key.Text);
      if (!RegisterationForm.Kernel32.GetEnvironmentVariable("WLRegSmartKeyInstallToRegistry", lpBuffer, 500))
        return;
      this.isActivated = true;
      Application.Restart();
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
      this.textBox_HWID = new TextBox();
      this.textBox_Key = new TextBox();
      this.label2 = new Label();
      this.button_Activate = new Button();
      this.label3 = new Label();
      this.textBox_Name = new TextBox();
      this.label4 = new Label();
      this.textBox_Org = new TextBox();
      this.label5 = new Label();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 65);
      this.label1.Name = "label1";
      this.label1.Size = new Size(77, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "Hardware ID:";
      this.textBox_HWID.Location = new Point(111, 62);
      this.textBox_HWID.Name = "textBox_HWID";
      this.textBox_HWID.ReadOnly = true;
      this.textBox_HWID.Size = new Size(254, 21);
      this.textBox_HWID.TabIndex = 0;
      this.textBox_HWID.Text = "XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX-XXXX";
      this.textBox_Key.Location = new Point(112, 134);
      this.textBox_Key.Name = "textBox_Key";
      this.textBox_Key.Size = new Size(254, 21);
      this.textBox_Key.TabIndex = 3;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(13, 137);
      this.label2.Name = "label2";
      this.label2.Size = new Size(113, 12);
      this.label2.TabIndex = 3;
      this.label2.Text = "Registeration Key:";
      this.button_Activate.Location = new Point(15, 161);
      this.button_Activate.Name = "button_Activate";
      this.button_Activate.Size = new Size(350, 31);
      this.button_Activate.TabIndex = 4;
      this.button_Activate.Text = "Activate";
      this.button_Activate.UseVisualStyleBackColor = true;
      this.button_Activate.Click += new EventHandler(this.button_Activate_Click);
      this.label3.AutoSize = true;
      this.label3.Location = new Point(13, 89);
      this.label3.Name = "label3";
      this.label3.Size = new Size(35, 12);
      this.label3.TabIndex = 6;
      this.label3.Text = "Name:";
      this.textBox_Name.Location = new Point(112, 86);
      this.textBox_Name.Name = "textBox_Name";
      this.textBox_Name.Size = new Size(254, 21);
      this.textBox_Name.TabIndex = 1;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(13, 113);
      this.label4.Name = "label4";
      this.label4.Size = new Size(59, 12);
      this.label4.TabIndex = 8;
      this.label4.Text = "Company: ";
      this.textBox_Org.Location = new Point(112, 110);
      this.textBox_Org.Name = "textBox_Org";
      this.textBox_Org.Size = new Size(254, 21);
      this.textBox_Org.TabIndex = 2;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(33, 23);
      this.label5.Name = "label5";
      this.label5.Size = new Size(302, 21);
      this.label5.TabIndex = 9;
      this.label5.Text = "* Please enter your info and press Activate";
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(378, 203);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.textBox_Org);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.textBox_Name);
      this.Controls.Add((Control) this.button_Activate);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.textBox_Key);
      this.Controls.Add((Control) this.textBox_HWID);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (RegisterationForm);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "MU.ToolKit Product Activation";
      this.FormClosing += new FormClosingEventHandler(this.RegisterationForm_FormClosing);
      this.Load += new EventHandler(this.RegisterationForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void RegisterationForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.isActivated)
        return;
      Environment.Exit(0);
    }

    private void RegisterationForm_Load(object sender, EventArgs e)
    {
      StringBuilder lpBuffer = new StringBuilder(100);
      RegisterationForm.Kernel32.GetEnvironmentVariable("WLHardwareGetID", lpBuffer, 100);
      this.textBox_HWID.Text = lpBuffer.ToString();
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
