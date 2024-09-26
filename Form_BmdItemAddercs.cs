// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.Form_BmdItemAddercs
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class Form_BmdItemAddercs : Form
  {
    private int BMDType;
    private Button button_InsertItem;
    public ComboBox comboBox_ToGroup;
    private IContainer components;
    private DataGridView dataGridView_NewItem;
    private Form1 frmOwner;
    private int iIndexLocation;
    private bool isFinishedInit;
    public bool isWorkingMainForm;
    private Label label1;
    private Panel panel1;

    public Form_BmdItemAddercs(int BmdType)
    {
      this.InitializeComponent();
      this.BMDType = BmdType;
    }

    private void button_InsertItem_Click(object sender, EventArgs e)
    {
      DataGridView workingDgv = ((Form1) this.Owner).workingDGV;
      int int32 = Convert.ToInt32(this.dataGridView_NewItem[this.iIndexLocation, 0].Value);
      if (int32 > 511)
        return;
      for (int columnIndex = 0; columnIndex < workingDgv.Columns.Count; ++columnIndex)
        workingDgv[columnIndex, int32].Value = this.dataGridView_NewItem[columnIndex, 0].Value;
      workingDgv.CurrentCell = workingDgv[this.iIndexLocation, int32];
    }

    private void comboBox_ToGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.isFinishedInit)
        return;
      if (!this.isWorkingMainForm)
        ((Form1) this.Owner).tc_Items.SelectedIndex = this.comboBox_ToGroup.SelectedIndex;
      this.dataGridView_NewItem[this.iIndexLocation - 1, 0].Value = (object) this.comboBox_ToGroup.SelectedIndex;
    }

    private void dataGridView_NewItem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; ++columnIndex)
        dataGridView[columnIndex, e.RowIndex].Value = (object) 0;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void Form_BmdItemAddercs_Load(object sender, EventArgs e)
    {
      this.frmOwner = (Form1) this.Owner;
      switch (this.BMDType)
      {
        case 0:
          this.frmOwner.initializeItem_S6E3Grid(this.dataGridView_NewItem);
          this.iIndexLocation = 1;
          break;
        case 1:
          this.frmOwner.initializeItemEx700Grid(this.dataGridView_NewItem);
          this.iIndexLocation = 5;
          break;
        case 2:
          this.frmOwner.initializeItemEx700PlusGrid(this.dataGridView_NewItem);
          this.iIndexLocation = 5;
          break;
        case 3:
          this.frmOwner.initializeItemSeason8Episode1Grid(this.dataGridView_NewItem);
          this.iIndexLocation = 5;
          break;
        case 4:
          this.frmOwner.initializeITTGrid(this.dataGridView_NewItem);
          this.iIndexLocation = 1;
          break;
        case 5:
          this.frmOwner.initializeISTGrid(this.dataGridView_NewItem);
          this.iIndexLocation = 1;
          break;
        case 6:
          this.frmOwner.initializeIAOGrid(this.dataGridView_NewItem);
          this.iIndexLocation = 1;
          break;
        case 7:
          this.frmOwner.initializeJOHSGrid(this.dataGridView_NewItem);
          this.iIndexLocation = 1;
          break;
      }
      this.dataGridView_NewItem.Rows.Add();
      this.comboBox_ToGroup.SelectedIndex = 0;
      this.isFinishedInit = true;
      this.dataGridView_NewItem.Columns[this.iIndexLocation].ReadOnly = false;
      this.dataGridView_NewItem.Columns[this.iIndexLocation].DefaultCellStyle.BackColor = Color.White;
      this.dataGridView_NewItem.Columns[this.iIndexLocation - 1].ReadOnly = true;
      this.dataGridView_NewItem.Columns[this.iIndexLocation - 1].DefaultCellStyle.BackColor = Color.LightGray;
      this.dataGridView_NewItem.Dock = DockStyle.Fill;
    }

    private void InitializeComponent()
    {
      this.dataGridView_NewItem = new DataGridView();
      this.label1 = new Label();
      this.comboBox_ToGroup = new ComboBox();
      this.button_InsertItem = new Button();
      this.panel1 = new Panel();
      ((ISupportInitialize) this.dataGridView_NewItem).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.dataGridView_NewItem.AllowUserToAddRows = false;
      this.dataGridView_NewItem.AllowUserToDeleteRows = false;
      this.dataGridView_NewItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_NewItem.Location = new Point(13, 16);
      this.dataGridView_NewItem.Name = "dataGridView_NewItem";
      this.dataGridView_NewItem.Size = new Size(198, 37);
      this.dataGridView_NewItem.TabIndex = 0;
      this.dataGridView_NewItem.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView_NewItem_RowsAdded);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(6, 111);
      this.label1.Name = "label1";
      this.label1.Size = new Size(47, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "Add to:";
      this.comboBox_ToGroup.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_ToGroup.FormattingEnabled = true;
      this.comboBox_ToGroup.Items.AddRange(new object[16]
      {
        (object) "Swords",
        (object) "Axes",
        (object) "Maces/Scapters",
        (object) "Spears",
        (object) "Bows/Crosswobs",
        (object) "Staffs/Sticks",
        (object) "Shields",
        (object) "Helms",
        (object) "Armors",
        (object) "Pants",
        (object) "Gloves",
        (object) "Boots",
        (object) "Wings/Other",
        (object) "Misc 1",
        (object) "Misc 2",
        (object) "Scrolls"
      });
      this.comboBox_ToGroup.Location = new Point(53, 107);
      this.comboBox_ToGroup.Name = "comboBox_ToGroup";
      this.comboBox_ToGroup.Size = new Size(158, 20);
      this.comboBox_ToGroup.TabIndex = 2;
      this.comboBox_ToGroup.SelectedIndexChanged += new EventHandler(this.comboBox_ToGroup_SelectedIndexChanged);
      this.button_InsertItem.Location = new Point(217, 95);
      this.button_InsertItem.Name = "button_InsertItem";
      this.button_InsertItem.Size = new Size(563, 41);
      this.button_InsertItem.TabIndex = 3;
      this.button_InsertItem.Text = "Insert Item";
      this.button_InsertItem.UseVisualStyleBackColor = true;
      this.button_InsertItem.Click += new EventHandler(this.button_InsertItem_Click);
      this.panel1.Controls.Add((Control) this.dataGridView_NewItem);
      this.panel1.Location = new Point(4, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(776, 86);
      this.panel1.TabIndex = 4;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(785, 139);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.button_InsertItem);
      this.Controls.Add((Control) this.comboBox_ToGroup);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Form_BmdItemAddercs);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Item Adder";
      this.TopMost = true;
      this.Load += new EventHandler(this.Form_BmdItemAddercs_Load);
      ((ISupportInitialize) this.dataGridView_NewItem).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
