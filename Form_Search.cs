// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.Form_Search
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class Form_Search : Form
  {
    private Button button_Find;
    private ComboBox comboBox_SearchIn;
    private IContainer components;
    private Form1 f_main = (Form1) Application.OpenForms[0];
    private GroupBox groupBox1;
    private Label label1;
    private Label label2;
    private RadioButton radioButton_FindDown;
    private RadioButton radioButton_FindUp;
    private TextBox textBox_SearchFor;

    public Form_Search() => this.InitializeComponent();

    private void button_Find_Click(object sender, EventArgs e)
    {
      if (this.radioButton_FindDown.Checked)
        this.f_main.FindNextValue(this.comboBox_SearchIn.Text, this.textBox_SearchFor.Text);
      else
        this.f_main.FindPreviousValue(this.comboBox_SearchIn.Text, this.textBox_SearchFor.Text);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void Form_Search_Load(object sender, EventArgs e)
    {
      this.f_main.AddColumnsToComboBox(ref this.comboBox_SearchIn);
      if (this.comboBox_SearchIn.Items.Count <= 0)
        return;
      this.comboBox_SearchIn.SelectedIndex = 0;
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.comboBox_SearchIn = new ComboBox();
      this.textBox_SearchFor = new TextBox();
      this.button_Find = new Button();
      this.groupBox1 = new GroupBox();
      this.radioButton_FindDown = new RadioButton();
      this.radioButton_FindUp = new RadioButton();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(8, 10);
      this.label1.Name = "label1";
      this.label1.Size = new Size(65, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "Find what:";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(8, 34);
      this.label2.Name = "label2";
      this.label2.Size = new Size(65, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "In Column:";
      this.comboBox_SearchIn.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_SearchIn.FormattingEnabled = true;
      this.comboBox_SearchIn.Location = new Point(70, 31);
      this.comboBox_SearchIn.Name = "comboBox_SearchIn";
      this.comboBox_SearchIn.Size = new Size(179, 20);
      this.comboBox_SearchIn.TabIndex = 1;
      this.textBox_SearchFor.Location = new Point(70, 7);
      this.textBox_SearchFor.Name = "textBox_SearchFor";
      this.textBox_SearchFor.Size = new Size(179, 21);
      this.textBox_SearchFor.TabIndex = 0;
      this.button_Find.Location = new Point(363, 10);
      this.button_Find.Name = "button_Find";
      this.button_Find.Size = new Size(102, 43);
      this.button_Find.TabIndex = 4;
      this.button_Find.Text = "Find Next";
      this.button_Find.UseVisualStyleBackColor = true;
      this.button_Find.Click += new EventHandler(this.button_Find_Click);
      this.groupBox1.Controls.Add((Control) this.radioButton_FindDown);
      this.groupBox1.Controls.Add((Control) this.radioButton_FindUp);
      this.groupBox1.Location = new Point((int) byte.MaxValue, 7);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(102, 46);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Direction";
      this.radioButton_FindDown.AutoSize = true;
      this.radioButton_FindDown.Checked = true;
      this.radioButton_FindDown.Location = new Point(47, 19);
      this.radioButton_FindDown.Name = "radioButton_FindDown";
      this.radioButton_FindDown.Size = new Size(47, 16);
      this.radioButton_FindDown.TabIndex = 3;
      this.radioButton_FindDown.TabStop = true;
      this.radioButton_FindDown.Text = "Down";
      this.radioButton_FindDown.UseVisualStyleBackColor = true;
      this.radioButton_FindUp.AutoSize = true;
      this.radioButton_FindUp.Location = new Point(8, 19);
      this.radioButton_FindUp.Name = "radioButton_FindUp";
      this.radioButton_FindUp.Size = new Size(35, 16);
      this.radioButton_FindUp.TabIndex = 2;
      this.radioButton_FindUp.TabStop = true;
      this.radioButton_FindUp.Text = "Up";
      this.radioButton_FindUp.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(477, 64);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.button_Find);
      this.Controls.Add((Control) this.textBox_SearchFor);
      this.Controls.Add((Control) this.comboBox_SearchIn);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Form_Search);
      this.Opacity = 0.8;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Find";
      this.TopMost = true;
      this.Load += new EventHandler(this.Form_Search_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
