// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.EventBagEditor_XML
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class EventBagEditor_XML : Form
  {
    private Structures.EventBagDrop BagDrop = new Structures.EventBagDrop();
    private BindingList<Structures.EventBagItem> BagItemList = new BindingList<Structures.EventBagItem>();
    private Button button_AddItem;
    private Button button_Item_Remove;
    private Button button_Item_Update;
    private List<Structures.UniItem> C_Armors = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Axes = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Boots = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_BowsCrossBows = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Gloves = new List<Structures.UniItem>();
    private List<Structures.c_Groups> C_Groups = new List<Structures.c_Groups>();
    private List<Structures.UniItem> C_Helms = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_MacesScepters = new List<Structures.UniItem>();
    private List<Structures.c_OptionData> c_OptionDatas_Add = new List<Structures.c_OptionData>();
    private List<Structures.c_OptionData> c_OptionDatas_Added = new List<Structures.c_OptionData>();
    private List<Structures.c_OptionData> c_OptionDatas_Default = new List<Structures.c_OptionData>();
    private List<Structures.UniItem> C_Others1 = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Others2 = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Pants = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Scrolls = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Shields = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Spears = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Staffs = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Swords = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_WingsSkillsSeedsOthers = new List<Structures.UniItem>();
    private CheckBox checkBox_Add_Anc;
    private CheckBox checkBox_Add_Exc;
    private CheckBox checkBox_Add_Luck;
    private CheckBox checkBox_Add_Skill;
    private CheckBox checkBox_Add_Sock;
    private CheckBox checkBox_Added_Anc;
    private CheckBox checkBox_Added_Exc;
    private CheckBox checkBox_Added_Luck;
    private CheckBox checkBox_Added_Skill;
    private CheckBox checkBox_Added_Sock;
    private CheckBox checkBox_DefAnc;
    private CheckBox checkBox_DefExc;
    private CheckBox checkBox_DefLuck;
    private CheckBox checkBox_DefSkill;
    private CheckBox checkBox_DefSocket;
    private ComboBox comboBox_Add_MaxOption;
    private ComboBox comboBox_Added_MaxOption;
    private ComboBox comboBox_DefMaxOption;
    private IContainer components;
    private bool DontWork;
    private ToolStripMenuItem fileToolStripMenuItem;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private GroupBox groupBox5;
    private GroupBox groupBox7;
    private int isEx700ItemList;
    private string[,] ItemName = new string[16, 513];
    private List<Structures.UniItem> L_Armors = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Axes = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Boots = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_BowsCrossBows = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Gloves = new List<Structures.UniItem>();
    private List<Structures.c_Groups> L_Groups = new List<Structures.c_Groups>();
    private List<Structures.UniItem> L_Helms = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_MacesScepters = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Others1 = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Others2 = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Pants = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Scrolls = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Shields = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Spears = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Staffs = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_Swords = new List<Structures.UniItem>();
    private List<Structures.UniItem> L_WingsSkillsSeedsOthers = new List<Structures.UniItem>();
    private Label label_FileName;
    private Label label_ItemCount;
    private Label label1;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private Label label15;
    private Label label16;
    private Label label17;
    private Label label18;
    private Label label19;
    private Label label2;
    private Label label20;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private int LastSelectedItemIndex;
    private ListBox listBox_Add_Group;
    private ListBox listBox_Add_Index;
    private ListBox listBox_AddedItems;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem newToolStripMenuItem;
    private NumericUpDown numericUpDown_Add_MaxLevel;
    private NumericUpDown numericUpDown_Add_MinLevel;
    private NumericUpDown numericUpDown_Added_MaxLevel;
    private NumericUpDown numericUpDown_Added_MinLevel;
    private NumericUpDown numericUpDown_AncDropRate;
    private NumericUpDown numericUpDown_BagZen;
    private NumericUpDown numericUpDown_DefMaxLvl;
    private NumericUpDown numericUpDown_DefMinLvl;
    private NumericUpDown numericUpDown_DropRate;
    private NumericUpDown numericUpDown_ExcDropRate;
    private NumericUpDown numericUpDown_SocketDropRate;
    private ToolStripMenuItem openToolStripMenuItem;
    private PictureBox pictureBox_Add_ItemPreview;
    private PictureBox pictureBox_Added_ItemPreview;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private Structures strct = new Structures();
    private TextBox textBox_EventName;

    public EventBagEditor_XML() => this.InitializeComponent();

    private void button_AddItem_Click(object sender, EventArgs e)
    {
      if (this.BagItemList.Count >= 150)
        return;
      Structures.EventBagItem eventBagItem = new Structures.EventBagItem()
      {
        Group = (int) this.listBox_Add_Group.SelectedValue,
        Index = (int) this.listBox_Add_Index.SelectedValue,
        Luck = this.checkBox_Add_Luck.Checked,
        MaxLevel = (int) this.numericUpDown_Add_MaxLevel.Value,
        MinLevel = (int) this.numericUpDown_Add_MinLevel.Value,
        new_MaxOption = (int) this.comboBox_Add_MaxOption.SelectedValue,
        Skill = this.checkBox_Add_Skill.Checked,
        Excellent = this.checkBox_Add_Exc.Checked,
        Ancient = this.checkBox_Add_Anc.Checked,
        Socket = this.checkBox_Add_Sock.Checked
      };
      eventBagItem.Name = this.ItemName[eventBagItem.Group, eventBagItem.Index];
      this.BagItemList.Add(eventBagItem);
      if (!this.button_Item_Remove.Enabled)
      {
        this.button_Item_Remove.Enabled = true;
        this.button_Item_Update.Enabled = true;
      }
      this.label_ItemCount.Text = ((int) Convert.ToInt16(this.label_ItemCount.Text) + 1).ToString();
      this.listBox_AddedItems.SelectedIndex = -1;
      this.listBox_AddedItems.SelectedIndex = this.listBox_AddedItems.Items.Count - 1;
    }

    private void button_Item_Remove_Click(object sender, EventArgs e)
    {
      this.BagItemList.Remove((Structures.EventBagItem) this.listBox_AddedItems.SelectedItem);
      this.label_ItemCount.Text = ((int) Convert.ToInt16(this.label_ItemCount.Text) - 1).ToString();
      if (Convert.ToInt16(this.label_ItemCount.Text) != (short) 0)
        return;
      this.button_Item_Remove.Enabled = false;
      this.button_Item_Update.Enabled = false;
    }

    private void button_Item_Update_Click(object sender, EventArgs e)
    {
      this.DontWork = true;
      Structures.EventBagItem selectedItem = (Structures.EventBagItem) this.listBox_AddedItems.SelectedItem;
      Structures.EventBagItem eventBagItem = selectedItem with
      {
        Excellent = this.checkBox_Added_Exc.Checked,
        Luck = this.checkBox_Added_Luck.Checked,
        MaxLevel = (int) this.numericUpDown_Added_MaxLevel.Value,
        MinLevel = (int) this.numericUpDown_Added_MinLevel.Value,
        new_MaxOption = (int) this.comboBox_Added_MaxOption.SelectedValue,
        Skill = this.checkBox_Added_Skill.Checked,
        Ancient = this.checkBox_Added_Anc.Checked,
        Socket = this.checkBox_Added_Sock.Checked
      };
      this.BagItemList[this.BagItemList.IndexOf(selectedItem)] = eventBagItem;
      this.DontWork = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void EventBagEditor_XML_FormClosed(object sender, FormClosedEventArgs e) => Application.OpenForms["Form1"].WindowState = FormWindowState.Normal;

    private void EventBagEditor_XML_Load(object sender, EventArgs e)
    {
      this.isEx700ItemList = ((Form1) Application.OpenForms[0]).isEx700ItemList ? 1 : 0;
      string[,] ItemSize = (string[,]) null;
      if (this.isEx700ItemList == 1)
        this.strct.ReadItemList("Data\\ItemListSettings_ex700.ini", true, ref this.L_Groups, ref this.L_Swords, ref this.L_Axes, ref this.L_MacesScepters, ref this.L_Spears, ref this.L_BowsCrossBows, ref this.L_Staffs, ref this.L_Shields, ref this.L_Helms, ref this.L_Armors, ref this.L_Pants, ref this.L_Gloves, ref this.L_Boots, ref this.L_WingsSkillsSeedsOthers, ref this.L_Others1, ref this.L_Others2, ref this.L_Scrolls, ref this.ItemName, ref ItemSize);
      else
        this.strct.ReadItemList("Data\\ItemListSettings.ini", false, ref this.L_Groups, ref this.L_Swords, ref this.L_Axes, ref this.L_MacesScepters, ref this.L_Spears, ref this.L_BowsCrossBows, ref this.L_Staffs, ref this.L_Shields, ref this.L_Helms, ref this.L_Armors, ref this.L_Pants, ref this.L_Gloves, ref this.L_Boots, ref this.L_WingsSkillsSeedsOthers, ref this.L_Others1, ref this.L_Others2, ref this.L_Scrolls, ref this.ItemName, ref ItemSize);
      this.C_Swords = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Swords);
      this.C_Axes = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Axes);
      this.C_MacesScepters = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_MacesScepters);
      this.C_Spears = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Spears);
      this.C_BowsCrossBows = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_BowsCrossBows);
      this.C_Staffs = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Staffs);
      this.C_Shields = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Shields);
      this.C_Helms = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Helms);
      this.C_Armors = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Armors);
      this.C_Pants = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Pants);
      this.C_Gloves = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Gloves);
      this.C_Boots = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Boots);
      this.C_WingsSkillsSeedsOthers = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_WingsSkillsSeedsOthers);
      this.C_Others1 = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Others1);
      this.C_Others2 = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Others2);
      this.C_Scrolls = new List<Structures.UniItem>((IEnumerable<Structures.UniItem>) this.L_Scrolls);
      this.C_Groups = new List<Structures.c_Groups>((IEnumerable<Structures.c_Groups>) this.L_Groups);
      this.listBox_Add_Group.DisplayMember = "GroupName";
      this.listBox_Add_Group.ValueMember = "Group";
      this.listBox_Add_Group.DataSource = (object) this.L_Groups;
      this.listBox_AddedItems.DataSource = (object) this.BagItemList;
      this.listBox_AddedItems.DisplayMember = "Name";
      this.strct.Setc_OptionData(ref this.c_OptionDatas_Add);
      this.c_OptionDatas_Added = new List<Structures.c_OptionData>((IEnumerable<Structures.c_OptionData>) this.c_OptionDatas_Add);
      this.c_OptionDatas_Default = new List<Structures.c_OptionData>((IEnumerable<Structures.c_OptionData>) this.c_OptionDatas_Add);
      this.comboBox_Add_MaxOption.DataSource = (object) this.c_OptionDatas_Add;
      this.comboBox_Add_MaxOption.DisplayMember = "Name";
      this.comboBox_Add_MaxOption.ValueMember = "ID";
      this.comboBox_Added_MaxOption.DataSource = (object) this.c_OptionDatas_Added;
      this.comboBox_Added_MaxOption.DisplayMember = "Name";
      this.comboBox_Added_MaxOption.ValueMember = "ID";
      this.comboBox_DefMaxOption.DataSource = (object) this.c_OptionDatas_Default;
      this.comboBox_DefMaxOption.DisplayMember = "Name";
      this.comboBox_DefMaxOption.ValueMember = "ID";
      Application.OpenForms["Form1"].WindowState = FormWindowState.Minimized;
      this.WindowState = FormWindowState.Normal;
      this.TopMost = true;
      this.TopMost = false;
      this.BringToFront();
      this.Focus();
    }

    private void InitializeComponent()
    {
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.newToolStripMenuItem = new ToolStripMenuItem();
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new ToolStripMenuItem();
      this.groupBox5 = new GroupBox();
      this.checkBox_Add_Sock = new CheckBox();
      this.checkBox_Add_Anc = new CheckBox();
      this.comboBox_Add_MaxOption = new ComboBox();
      this.label20 = new Label();
      this.pictureBox_Add_ItemPreview = new PictureBox();
      this.listBox_Add_Group = new ListBox();
      this.checkBox_Add_Exc = new CheckBox();
      this.listBox_Add_Index = new ListBox();
      this.checkBox_Add_Luck = new CheckBox();
      this.numericUpDown_Add_MinLevel = new NumericUpDown();
      this.numericUpDown_Add_MaxLevel = new NumericUpDown();
      this.checkBox_Add_Skill = new CheckBox();
      this.button_AddItem = new Button();
      this.label17 = new Label();
      this.label18 = new Label();
      this.label_FileName = new Label();
      this.groupBox7 = new GroupBox();
      this.comboBox_Added_MaxOption = new ComboBox();
      this.label3 = new Label();
      this.checkBox_Added_Sock = new CheckBox();
      this.button_Item_Remove = new Button();
      this.checkBox_Added_Anc = new CheckBox();
      this.button_Item_Update = new Button();
      this.label16 = new Label();
      this.checkBox_Added_Exc = new CheckBox();
      this.label_ItemCount = new Label();
      this.listBox_AddedItems = new ListBox();
      this.pictureBox_Added_ItemPreview = new PictureBox();
      this.numericUpDown_Added_MinLevel = new NumericUpDown();
      this.label13 = new Label();
      this.checkBox_Added_Luck = new CheckBox();
      this.numericUpDown_Added_MaxLevel = new NumericUpDown();
      this.label14 = new Label();
      this.checkBox_Added_Skill = new CheckBox();
      this.groupBox3 = new GroupBox();
      this.numericUpDown_SocketDropRate = new NumericUpDown();
      this.label6 = new Label();
      this.numericUpDown_AncDropRate = new NumericUpDown();
      this.label8 = new Label();
      this.numericUpDown_ExcDropRate = new NumericUpDown();
      this.label12 = new Label();
      this.numericUpDown_DropRate = new NumericUpDown();
      this.label5 = new Label();
      this.label10 = new Label();
      this.numericUpDown_BagZen = new NumericUpDown();
      this.label4 = new Label();
      this.textBox_EventName = new TextBox();
      this.label2 = new Label();
      this.label7 = new Label();
      this.label11 = new Label();
      this.label9 = new Label();
      this.groupBox4 = new GroupBox();
      this.checkBox_DefSocket = new CheckBox();
      this.checkBox_DefAnc = new CheckBox();
      this.comboBox_DefMaxOption = new ComboBox();
      this.label1 = new Label();
      this.numericUpDown_DefMinLvl = new NumericUpDown();
      this.label15 = new Label();
      this.checkBox_DefLuck = new CheckBox();
      this.numericUpDown_DefMaxLvl = new NumericUpDown();
      this.label19 = new Label();
      this.checkBox_DefSkill = new CheckBox();
      this.checkBox_DefExc = new CheckBox();
      this.menuStrip1.SuspendLayout();
      this.groupBox5.SuspendLayout();
      ((ISupportInitialize) this.pictureBox_Add_ItemPreview).BeginInit();
      this.numericUpDown_Add_MinLevel.BeginInit();
      this.numericUpDown_Add_MaxLevel.BeginInit();
      this.groupBox7.SuspendLayout();
      ((ISupportInitialize) this.pictureBox_Added_ItemPreview).BeginInit();
      this.numericUpDown_Added_MinLevel.BeginInit();
      this.numericUpDown_Added_MaxLevel.BeginInit();
      this.groupBox3.SuspendLayout();
      this.numericUpDown_SocketDropRate.BeginInit();
      this.numericUpDown_AncDropRate.BeginInit();
      this.numericUpDown_ExcDropRate.BeginInit();
      this.numericUpDown_DropRate.BeginInit();
      this.numericUpDown_BagZen.BeginInit();
      this.groupBox4.SuspendLayout();
      this.numericUpDown_DefMinLvl.BeginInit();
      this.numericUpDown_DefMaxLvl.BeginInit();
      this.SuspendLayout();
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.fileToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(686, 25);
      this.menuStrip1.TabIndex = 5;
      this.menuStrip1.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.newToolStripMenuItem,
        (ToolStripItem) this.openToolStripMenuItem,
        (ToolStripItem) this.saveAsToolStripMenuItem
      });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(39, 21);
      this.fileToolStripMenuItem.Text = "File";
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new Size(121, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new EventHandler(this.newToolStripMenuItem_Click);
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new Size(121, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new Size(121, 22);
      this.saveAsToolStripMenuItem.Text = "Save As";
      this.saveAsToolStripMenuItem.Click += new EventHandler(this.saveAsToolStripMenuItem_Click);
      this.groupBox5.Controls.Add((Control) this.checkBox_Add_Sock);
      this.groupBox5.Controls.Add((Control) this.checkBox_Add_Anc);
      this.groupBox5.Controls.Add((Control) this.comboBox_Add_MaxOption);
      this.groupBox5.Controls.Add((Control) this.label20);
      this.groupBox5.Controls.Add((Control) this.pictureBox_Add_ItemPreview);
      this.groupBox5.Controls.Add((Control) this.listBox_Add_Group);
      this.groupBox5.Controls.Add((Control) this.checkBox_Add_Exc);
      this.groupBox5.Controls.Add((Control) this.listBox_Add_Index);
      this.groupBox5.Controls.Add((Control) this.checkBox_Add_Luck);
      this.groupBox5.Controls.Add((Control) this.numericUpDown_Add_MinLevel);
      this.groupBox5.Controls.Add((Control) this.numericUpDown_Add_MaxLevel);
      this.groupBox5.Controls.Add((Control) this.checkBox_Add_Skill);
      this.groupBox5.Controls.Add((Control) this.button_AddItem);
      this.groupBox5.Controls.Add((Control) this.label17);
      this.groupBox5.Controls.Add((Control) this.label18);
      this.groupBox5.Location = new Point(12, 211);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(387, 174);
      this.groupBox5.TabIndex = 10;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "New Item";
      this.checkBox_Add_Sock.AutoSize = true;
      this.checkBox_Add_Sock.Location = new Point(213, 126);
      this.checkBox_Add_Sock.Name = "checkBox_Add_Sock";
      this.checkBox_Add_Sock.Size = new Size(60, 16);
      this.checkBox_Add_Sock.TabIndex = 44;
      this.checkBox_Add_Sock.Text = "Socket";
      this.checkBox_Add_Sock.UseVisualStyleBackColor = true;
      this.checkBox_Add_Anc.AutoSize = true;
      this.checkBox_Add_Anc.Location = new Point(213, 103);
      this.checkBox_Add_Anc.Name = "checkBox_Add_Anc";
      this.checkBox_Add_Anc.Size = new Size(66, 16);
      this.checkBox_Add_Anc.TabIndex = 43;
      this.checkBox_Add_Anc.Text = "Ancient";
      this.checkBox_Add_Anc.UseVisualStyleBackColor = true;
      this.comboBox_Add_MaxOption.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Add_MaxOption.FormattingEnabled = true;
      this.comboBox_Add_MaxOption.Location = new Point(71, 150);
      this.comboBox_Add_MaxOption.Name = "comboBox_Add_MaxOption";
      this.comboBox_Add_MaxOption.Size = new Size(50, 20);
      this.comboBox_Add_MaxOption.TabIndex = 44;
      this.label20.AutoSize = true;
      this.label20.Location = new Point(6, 152);
      this.label20.Name = "label20";
      this.label20.Size = new Size(71, 12);
      this.label20.TabIndex = 43;
      this.label20.Text = "Max Option:";
      this.pictureBox_Add_ItemPreview.BackColor = Color.FromArgb(37, 47, 1);
      this.pictureBox_Add_ItemPreview.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_Add_ItemPreview.Location = new Point(287, 21);
      this.pictureBox_Add_ItemPreview.Name = "pictureBox_Add_ItemPreview";
      this.pictureBox_Add_ItemPreview.Size = new Size(94, 76);
      this.pictureBox_Add_ItemPreview.TabIndex = 29;
      this.pictureBox_Add_ItemPreview.TabStop = false;
      this.listBox_Add_Group.FormattingEnabled = true;
      this.listBox_Add_Group.ItemHeight = 12;
      this.listBox_Add_Group.Location = new Point(6, 21);
      this.listBox_Add_Group.Name = "listBox_Add_Group";
      this.listBox_Add_Group.Size = new Size((int) sbyte.MaxValue, 76);
      this.listBox_Add_Group.TabIndex = 16;
      this.listBox_Add_Group.SelectedIndexChanged += new EventHandler(this.listBox_Add_Group_SelectedIndexChanged);
      this.checkBox_Add_Exc.AutoSize = true;
      this.checkBox_Add_Exc.Location = new Point(133, 150);
      this.checkBox_Add_Exc.Name = "checkBox_Add_Exc";
      this.checkBox_Add_Exc.Size = new Size(78, 16);
      this.checkBox_Add_Exc.TabIndex = 23;
      this.checkBox_Add_Exc.Text = "Excellent";
      this.checkBox_Add_Exc.UseVisualStyleBackColor = true;
      this.listBox_Add_Index.FormattingEnabled = true;
      this.listBox_Add_Index.ItemHeight = 12;
      this.listBox_Add_Index.Location = new Point(139, 21);
      this.listBox_Add_Index.Name = "listBox_Add_Index";
      this.listBox_Add_Index.Size = new Size(142, 76);
      this.listBox_Add_Index.TabIndex = 17;
      this.listBox_Add_Index.SelectedIndexChanged += new EventHandler(this.listBox_Add_Index_SelectedIndexChanged);
      this.checkBox_Add_Luck.AutoSize = true;
      this.checkBox_Add_Luck.Location = new Point(133, 126);
      this.checkBox_Add_Luck.Name = "checkBox_Add_Luck";
      this.checkBox_Add_Luck.Size = new Size(48, 16);
      this.checkBox_Add_Luck.TabIndex = 21;
      this.checkBox_Add_Luck.Text = "Luck";
      this.checkBox_Add_Luck.UseVisualStyleBackColor = true;
      this.numericUpDown_Add_MinLevel.Location = new Point(71, 101);
      this.numericUpDown_Add_MinLevel.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown_Add_MinLevel.Name = "numericUpDown_Add_MinLevel";
      this.numericUpDown_Add_MinLevel.Size = new Size(50, 21);
      this.numericUpDown_Add_MinLevel.TabIndex = 18;
      this.numericUpDown_Add_MaxLevel.Location = new Point(71, 125);
      this.numericUpDown_Add_MaxLevel.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown_Add_MaxLevel.Name = "numericUpDown_Add_MaxLevel";
      this.numericUpDown_Add_MaxLevel.Size = new Size(50, 21);
      this.numericUpDown_Add_MaxLevel.TabIndex = 19;
      this.checkBox_Add_Skill.AutoSize = true;
      this.checkBox_Add_Skill.Location = new Point(133, 103);
      this.checkBox_Add_Skill.Name = "checkBox_Add_Skill";
      this.checkBox_Add_Skill.Size = new Size(54, 16);
      this.checkBox_Add_Skill.TabIndex = 20;
      this.checkBox_Add_Skill.Text = "Skill";
      this.checkBox_Add_Skill.UseVisualStyleBackColor = true;
      this.button_AddItem.Location = new Point(287, 102);
      this.button_AddItem.Name = "button_AddItem";
      this.button_AddItem.Size = new Size(94, 67);
      this.button_AddItem.TabIndex = 24;
      this.button_AddItem.Text = "Add to Bag";
      this.button_AddItem.UseVisualStyleBackColor = true;
      this.button_AddItem.Click += new EventHandler(this.button_AddItem_Click);
      this.label17.AutoSize = true;
      this.label17.Location = new Point(6, 102);
      this.label17.Name = "label17";
      this.label17.Size = new Size(65, 12);
      this.label17.TabIndex = 23;
      this.label17.Text = "Min Level:";
      this.label18.AutoSize = true;
      this.label18.Location = new Point(6, 126);
      this.label18.Name = "label18";
      this.label18.Size = new Size(59, 12);
      this.label18.TabIndex = 24;
      this.label18.Text = "Max Level";
      this.label_FileName.ForeColor = Color.DarkGreen;
      this.label_FileName.Location = new Point(210, 13);
      this.label_FileName.Name = "label_FileName";
      this.label_FileName.Size = new Size(292, 14);
      this.label_FileName.TabIndex = 2;
      this.label_FileName.TextAlign = ContentAlignment.TopRight;
      this.groupBox7.Controls.Add((Control) this.label_FileName);
      this.groupBox7.Controls.Add((Control) this.comboBox_Added_MaxOption);
      this.groupBox7.Controls.Add((Control) this.label3);
      this.groupBox7.Controls.Add((Control) this.checkBox_Added_Sock);
      this.groupBox7.Controls.Add((Control) this.button_Item_Remove);
      this.groupBox7.Controls.Add((Control) this.checkBox_Added_Anc);
      this.groupBox7.Controls.Add((Control) this.button_Item_Update);
      this.groupBox7.Controls.Add((Control) this.label16);
      this.groupBox7.Controls.Add((Control) this.checkBox_Added_Exc);
      this.groupBox7.Controls.Add((Control) this.label_ItemCount);
      this.groupBox7.Controls.Add((Control) this.listBox_AddedItems);
      this.groupBox7.Controls.Add((Control) this.pictureBox_Added_ItemPreview);
      this.groupBox7.Controls.Add((Control) this.numericUpDown_Added_MinLevel);
      this.groupBox7.Controls.Add((Control) this.label13);
      this.groupBox7.Controls.Add((Control) this.checkBox_Added_Luck);
      this.groupBox7.Controls.Add((Control) this.numericUpDown_Added_MaxLevel);
      this.groupBox7.Controls.Add((Control) this.label14);
      this.groupBox7.Controls.Add((Control) this.checkBox_Added_Skill);
      this.groupBox7.Location = new Point(12, 31);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(508, 174);
      this.groupBox7.TabIndex = 1;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Existing Items";
      this.comboBox_Added_MaxOption.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Added_MaxOption.FormattingEnabled = true;
      this.comboBox_Added_MaxOption.Location = new Point(364, 110);
      this.comboBox_Added_MaxOption.Name = "comboBox_Added_MaxOption";
      this.comboBox_Added_MaxOption.Size = new Size(53, 20);
      this.comboBox_Added_MaxOption.TabIndex = 44;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(302, 113);
      this.label3.Name = "label3";
      this.label3.Size = new Size(71, 12);
      this.label3.TabIndex = 43;
      this.label3.Text = "Max Option:";
      this.checkBox_Added_Sock.AutoSize = true;
      this.checkBox_Added_Sock.Location = new Point(430, 118);
      this.checkBox_Added_Sock.Name = "checkBox_Added_Sock";
      this.checkBox_Added_Sock.Size = new Size(60, 16);
      this.checkBox_Added_Sock.TabIndex = 44;
      this.checkBox_Added_Sock.Text = "Socket";
      this.checkBox_Added_Sock.UseVisualStyleBackColor = true;
      this.button_Item_Remove.Enabled = false;
      this.button_Item_Remove.Location = new Point(6, 138);
      this.button_Item_Remove.Name = "button_Item_Remove";
      this.button_Item_Remove.Size = new Size(142, 27);
      this.button_Item_Remove.TabIndex = 26;
      this.button_Item_Remove.Text = "Remove";
      this.button_Item_Remove.UseVisualStyleBackColor = true;
      this.button_Item_Remove.Click += new EventHandler(this.button_Item_Remove_Click);
      this.checkBox_Added_Anc.AutoSize = true;
      this.checkBox_Added_Anc.Location = new Point(430, 97);
      this.checkBox_Added_Anc.Name = "checkBox_Added_Anc";
      this.checkBox_Added_Anc.Size = new Size(66, 16);
      this.checkBox_Added_Anc.TabIndex = 43;
      this.checkBox_Added_Anc.Text = "Ancient";
      this.checkBox_Added_Anc.UseVisualStyleBackColor = true;
      this.button_Item_Update.Enabled = false;
      this.button_Item_Update.Location = new Point(302, 138);
      this.button_Item_Update.Name = "button_Item_Update";
      this.button_Item_Update.Size = new Size(200, 27);
      this.button_Item_Update.TabIndex = 33;
      this.button_Item_Update.Text = "Update";
      this.button_Item_Update.UseVisualStyleBackColor = true;
      this.button_Item_Update.Click += new EventHandler(this.button_Item_Update_Click);
      this.label16.AutoSize = true;
      this.label16.Location = new Point(30, 20);
      this.label16.Name = "label16";
      this.label16.Size = new Size(35, 12);
      this.label16.TabIndex = 22;
      this.label16.Text = "/ 150";
      this.checkBox_Added_Exc.AutoSize = true;
      this.checkBox_Added_Exc.Location = new Point(430, 76);
      this.checkBox_Added_Exc.Name = "checkBox_Added_Exc";
      this.checkBox_Added_Exc.Size = new Size(78, 16);
      this.checkBox_Added_Exc.TabIndex = 32;
      this.checkBox_Added_Exc.Text = "Excellent";
      this.checkBox_Added_Exc.UseVisualStyleBackColor = true;
      this.label_ItemCount.AutoSize = true;
      this.label_ItemCount.Location = new Point(8, 20);
      this.label_ItemCount.Name = "label_ItemCount";
      this.label_ItemCount.RightToLeft = RightToLeft.Yes;
      this.label_ItemCount.Size = new Size(11, 12);
      this.label_ItemCount.TabIndex = 21;
      this.label_ItemCount.Text = "0";
      this.label_ItemCount.TextAlign = ContentAlignment.MiddleLeft;
      this.listBox_AddedItems.FormattingEnabled = true;
      this.listBox_AddedItems.ItemHeight = 12;
      this.listBox_AddedItems.Location = new Point(6, 35);
      this.listBox_AddedItems.Name = "listBox_AddedItems";
      this.listBox_AddedItems.Size = new Size(142, 100);
      this.listBox_AddedItems.TabIndex = 25;
      this.listBox_AddedItems.SelectedIndexChanged += new EventHandler(this.listBox_AddedItems_SelectedIndexChanged);
      this.pictureBox_Added_ItemPreview.BackColor = Color.FromArgb(37, 47, 1);
      this.pictureBox_Added_ItemPreview.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_Added_ItemPreview.Location = new Point(154, 35);
      this.pictureBox_Added_ItemPreview.Name = "pictureBox_Added_ItemPreview";
      this.pictureBox_Added_ItemPreview.Size = new Size(142, 130);
      this.pictureBox_Added_ItemPreview.TabIndex = 12;
      this.pictureBox_Added_ItemPreview.TabStop = false;
      this.numericUpDown_Added_MinLevel.Location = new Point(364, 49);
      this.numericUpDown_Added_MinLevel.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown_Added_MinLevel.Name = "numericUpDown_Added_MinLevel";
      this.numericUpDown_Added_MinLevel.Size = new Size(53, 21);
      this.numericUpDown_Added_MinLevel.TabIndex = 27;
      this.label13.AutoSize = true;
      this.label13.Location = new Point(302, 81);
      this.label13.Name = "label13";
      this.label13.Size = new Size(59, 12);
      this.label13.TabIndex = 6;
      this.label13.Text = "Max Level";
      this.checkBox_Added_Luck.AutoSize = true;
      this.checkBox_Added_Luck.Location = new Point(430, 54);
      this.checkBox_Added_Luck.Name = "checkBox_Added_Luck";
      this.checkBox_Added_Luck.Size = new Size(48, 16);
      this.checkBox_Added_Luck.TabIndex = 30;
      this.checkBox_Added_Luck.Text = "Luck";
      this.checkBox_Added_Luck.UseVisualStyleBackColor = true;
      this.numericUpDown_Added_MaxLevel.Location = new Point(364, 79);
      this.numericUpDown_Added_MaxLevel.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown_Added_MaxLevel.Name = "numericUpDown_Added_MaxLevel";
      this.numericUpDown_Added_MaxLevel.Size = new Size(53, 21);
      this.numericUpDown_Added_MaxLevel.TabIndex = 28;
      this.label14.AutoSize = true;
      this.label14.Location = new Point(302, 51);
      this.label14.Name = "label14";
      this.label14.Size = new Size(65, 12);
      this.label14.TabIndex = 5;
      this.label14.Text = "Min Level:";
      this.checkBox_Added_Skill.AutoSize = true;
      this.checkBox_Added_Skill.Location = new Point(430, 33);
      this.checkBox_Added_Skill.Name = "checkBox_Added_Skill";
      this.checkBox_Added_Skill.Size = new Size(54, 16);
      this.checkBox_Added_Skill.TabIndex = 29;
      this.checkBox_Added_Skill.Text = "Skill";
      this.checkBox_Added_Skill.UseVisualStyleBackColor = true;
      this.groupBox3.Controls.Add((Control) this.numericUpDown_SocketDropRate);
      this.groupBox3.Controls.Add((Control) this.label6);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_AncDropRate);
      this.groupBox3.Controls.Add((Control) this.label8);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_ExcDropRate);
      this.groupBox3.Controls.Add((Control) this.label12);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_DropRate);
      this.groupBox3.Controls.Add((Control) this.label5);
      this.groupBox3.Controls.Add((Control) this.label10);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_BagZen);
      this.groupBox3.Controls.Add((Control) this.label4);
      this.groupBox3.Controls.Add((Control) this.textBox_EventName);
      this.groupBox3.Controls.Add((Control) this.label2);
      this.groupBox3.Controls.Add((Control) this.label7);
      this.groupBox3.Controls.Add((Control) this.label11);
      this.groupBox3.Controls.Add((Control) this.label9);
      this.groupBox3.Location = new Point(405, 211);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(270, 174);
      this.groupBox3.TabIndex = 9;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Drop Configs";
      this.numericUpDown_SocketDropRate.DecimalPlaces = 1;
      this.numericUpDown_SocketDropRate.Location = new Point(97, 141);
      this.numericUpDown_SocketDropRate.Name = "numericUpDown_SocketDropRate";
      this.numericUpDown_SocketDropRate.Size = new Size(50, 21);
      this.numericUpDown_SocketDropRate.TabIndex = 19;
      this.numericUpDown_SocketDropRate.TextAlign = HorizontalAlignment.Right;
      this.numericUpDown_SocketDropRate.UpDownAlign = LeftRightAlignment.Left;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(13, 144);
      this.label6.Name = "label6";
      this.label6.Size = new Size(77, 12);
      this.label6.TabIndex = 22;
      this.label6.Text = "Socket Rate:";
      this.numericUpDown_AncDropRate.DecimalPlaces = 1;
      this.numericUpDown_AncDropRate.Location = new Point(97, 117);
      this.numericUpDown_AncDropRate.Name = "numericUpDown_AncDropRate";
      this.numericUpDown_AncDropRate.Size = new Size(50, 21);
      this.numericUpDown_AncDropRate.TabIndex = 18;
      this.numericUpDown_AncDropRate.TextAlign = HorizontalAlignment.Right;
      this.numericUpDown_AncDropRate.UpDownAlign = LeftRightAlignment.Left;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(11, 120);
      this.label8.Name = "label8";
      this.label8.Size = new Size(83, 12);
      this.label8.TabIndex = 20;
      this.label8.Text = "Ancient Rate:";
      this.numericUpDown_ExcDropRate.DecimalPlaces = 1;
      this.numericUpDown_ExcDropRate.Location = new Point(97, 93);
      this.numericUpDown_ExcDropRate.Name = "numericUpDown_ExcDropRate";
      this.numericUpDown_ExcDropRate.Size = new Size(50, 21);
      this.numericUpDown_ExcDropRate.TabIndex = 11;
      this.numericUpDown_ExcDropRate.TextAlign = HorizontalAlignment.Right;
      this.numericUpDown_ExcDropRate.UpDownAlign = LeftRightAlignment.Left;
      this.label12.AutoSize = true;
      this.label12.Location = new Point(11, 96);
      this.label12.Name = "label12";
      this.label12.Size = new Size(95, 12);
      this.label12.TabIndex = 15;
      this.label12.Text = "Excellent Rate:";
      this.numericUpDown_DropRate.DecimalPlaces = 1;
      this.numericUpDown_DropRate.Location = new Point(97, 69);
      this.numericUpDown_DropRate.Name = "numericUpDown_DropRate";
      this.numericUpDown_DropRate.Size = new Size(50, 21);
      this.numericUpDown_DropRate.TabIndex = 10;
      this.numericUpDown_DropRate.TextAlign = HorizontalAlignment.Right;
      this.numericUpDown_DropRate.UpDownAlign = LeftRightAlignment.Left;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(11, 45);
      this.label5.Name = "label5";
      this.label5.Size = new Size(59, 12);
      this.label5.TabIndex = 3;
      this.label5.Text = "Zen Drop:";
      this.label10.AutoSize = true;
      this.label10.Location = new Point(11, 72);
      this.label10.Name = "label10";
      this.label10.Size = new Size(65, 12);
      this.label10.TabIndex = 12;
      this.label10.Text = "Item Rate:";
      this.numericUpDown_BagZen.Location = new Point(73, 42);
      this.numericUpDown_BagZen.Maximum = new Decimal(new int[4]
      {
        int.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_BagZen.Name = "numericUpDown_BagZen";
      this.numericUpDown_BagZen.Size = new Size(183, 21);
      this.numericUpDown_BagZen.TabIndex = 9;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(11, 19);
      this.label4.Name = "label4";
      this.label4.Size = new Size(59, 12);
      this.label4.TabIndex = 1;
      this.label4.Text = "Bag Name:";
      this.textBox_EventName.Location = new Point(73, 17);
      this.textBox_EventName.Name = "textBox_EventName";
      this.textBox_EventName.Size = new Size(183, 21);
      this.textBox_EventName.TabIndex = 8;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label2.Location = new Point(144, 141);
      this.label2.Name = "label2";
      this.label2.Size = new Size(23, 20);
      this.label2.TabIndex = 23;
      this.label2.Text = "%";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label7.Location = new Point(144, 118);
      this.label7.Name = "label7";
      this.label7.Size = new Size(23, 20);
      this.label7.TabIndex = 21;
      this.label7.Text = "%";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label11.Location = new Point(144, 94);
      this.label11.Name = "label11";
      this.label11.Size = new Size(23, 20);
      this.label11.TabIndex = 17;
      this.label11.Text = "%";
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label9.Location = new Point(144, 69);
      this.label9.Name = "label9";
      this.label9.Size = new Size(23, 20);
      this.label9.TabIndex = 14;
      this.label9.Text = "%";
      this.groupBox4.Controls.Add((Control) this.checkBox_DefSocket);
      this.groupBox4.Controls.Add((Control) this.checkBox_DefAnc);
      this.groupBox4.Controls.Add((Control) this.comboBox_DefMaxOption);
      this.groupBox4.Controls.Add((Control) this.label1);
      this.groupBox4.Controls.Add((Control) this.numericUpDown_DefMinLvl);
      this.groupBox4.Controls.Add((Control) this.label15);
      this.groupBox4.Controls.Add((Control) this.checkBox_DefLuck);
      this.groupBox4.Controls.Add((Control) this.numericUpDown_DefMaxLvl);
      this.groupBox4.Controls.Add((Control) this.label19);
      this.groupBox4.Controls.Add((Control) this.checkBox_DefSkill);
      this.groupBox4.Controls.Add((Control) this.checkBox_DefExc);
      this.groupBox4.Location = new Point(526, 31);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(149, 174);
      this.groupBox4.TabIndex = 11;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Item Defaults";
      this.checkBox_DefSocket.AutoSize = true;
      this.checkBox_DefSocket.Location = new Point(49, 147);
      this.checkBox_DefSocket.Name = "checkBox_DefSocket";
      this.checkBox_DefSocket.Size = new Size(60, 16);
      this.checkBox_DefSocket.TabIndex = 42;
      this.checkBox_DefSocket.Text = "Socket";
      this.checkBox_DefSocket.UseVisualStyleBackColor = true;
      this.checkBox_DefAnc.AutoSize = true;
      this.checkBox_DefAnc.Location = new Point(78, 122);
      this.checkBox_DefAnc.Name = "checkBox_DefAnc";
      this.checkBox_DefAnc.Size = new Size(66, 16);
      this.checkBox_DefAnc.TabIndex = 40;
      this.checkBox_DefAnc.Text = "Ancient";
      this.checkBox_DefAnc.UseVisualStyleBackColor = true;
      this.comboBox_DefMaxOption.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_DefMaxOption.FormattingEnabled = true;
      this.comboBox_DefMaxOption.Location = new Point(71, 66);
      this.comboBox_DefMaxOption.Name = "comboBox_DefMaxOption";
      this.comboBox_DefMaxOption.Size = new Size(72, 20);
      this.comboBox_DefMaxOption.TabIndex = 38;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(6, 69);
      this.label1.Name = "label1";
      this.label1.Size = new Size(71, 12);
      this.label1.TabIndex = 37;
      this.label1.Text = "Max Option:";
      this.numericUpDown_DefMinLvl.Location = new Point(71, 18);
      this.numericUpDown_DefMinLvl.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown_DefMinLvl.Name = "numericUpDown_DefMinLvl";
      this.numericUpDown_DefMinLvl.Size = new Size(72, 21);
      this.numericUpDown_DefMinLvl.TabIndex = 33;
      this.label15.AutoSize = true;
      this.label15.Location = new Point(6, 45);
      this.label15.Name = "label15";
      this.label15.Size = new Size(59, 12);
      this.label15.TabIndex = 32;
      this.label15.Text = "Max Level";
      this.checkBox_DefLuck.AutoSize = true;
      this.checkBox_DefLuck.Location = new Point(78, 98);
      this.checkBox_DefLuck.Name = "checkBox_DefLuck";
      this.checkBox_DefLuck.Size = new Size(48, 16);
      this.checkBox_DefLuck.TabIndex = 36;
      this.checkBox_DefLuck.Text = "Luck";
      this.checkBox_DefLuck.UseVisualStyleBackColor = true;
      this.numericUpDown_DefMaxLvl.Location = new Point(71, 42);
      this.numericUpDown_DefMaxLvl.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown_DefMaxLvl.Name = "numericUpDown_DefMaxLvl";
      this.numericUpDown_DefMaxLvl.Size = new Size(72, 21);
      this.numericUpDown_DefMaxLvl.TabIndex = 34;
      this.label19.AutoSize = true;
      this.label19.Location = new Point(6, 21);
      this.label19.Name = "label19";
      this.label19.Size = new Size(65, 12);
      this.label19.TabIndex = 31;
      this.label19.Text = "Min Level:";
      this.checkBox_DefSkill.AutoSize = true;
      this.checkBox_DefSkill.Location = new Point(11, 98);
      this.checkBox_DefSkill.Name = "checkBox_DefSkill";
      this.checkBox_DefSkill.Size = new Size(54, 16);
      this.checkBox_DefSkill.TabIndex = 35;
      this.checkBox_DefSkill.Text = "Skill";
      this.checkBox_DefSkill.UseVisualStyleBackColor = true;
      this.checkBox_DefExc.AutoSize = true;
      this.checkBox_DefExc.Location = new Point(11, 122);
      this.checkBox_DefExc.Name = "checkBox_DefExc";
      this.checkBox_DefExc.Size = new Size(78, 16);
      this.checkBox_DefExc.TabIndex = 39;
      this.checkBox_DefExc.Text = "Excellent";
      this.checkBox_DefExc.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(686, 394);
      this.Controls.Add((Control) this.groupBox5);
      this.Controls.Add((Control) this.groupBox7);
      this.Controls.Add((Control) this.groupBox4);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.menuStrip1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = nameof (EventBagEditor_XML);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "EventBag Editor (XML)";
      this.FormClosed += new FormClosedEventHandler(this.EventBagEditor_XML_FormClosed);
      this.Load += new EventHandler(this.EventBagEditor_XML_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      ((ISupportInitialize) this.pictureBox_Add_ItemPreview).EndInit();
      this.numericUpDown_Add_MinLevel.EndInit();
      this.numericUpDown_Add_MaxLevel.EndInit();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      ((ISupportInitialize) this.pictureBox_Added_ItemPreview).EndInit();
      this.numericUpDown_Added_MinLevel.EndInit();
      this.numericUpDown_Added_MaxLevel.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.numericUpDown_SocketDropRate.EndInit();
      this.numericUpDown_AncDropRate.EndInit();
      this.numericUpDown_ExcDropRate.EndInit();
      this.numericUpDown_DropRate.EndInit();
      this.numericUpDown_BagZen.EndInit();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.numericUpDown_DefMinLvl.EndInit();
      this.numericUpDown_DefMaxLvl.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void listBox_Add_Group_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.listBox_Add_Group.SelectedIndex == -1)
        return;
      this.DontWork = true;
      switch ((int) this.listBox_Add_Group.SelectedValue)
      {
        case 0:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Swords;
          break;
        case 1:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Axes;
          break;
        case 2:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_MacesScepters;
          break;
        case 3:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Spears;
          break;
        case 4:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_BowsCrossBows;
          break;
        case 5:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Staffs;
          break;
        case 6:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Shields;
          break;
        case 7:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Helms;
          break;
        case 8:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Armors;
          break;
        case 9:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Pants;
          break;
        case 10:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Gloves;
          break;
        case 11:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Boots;
          break;
        case 12:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_WingsSkillsSeedsOthers;
          break;
        case 13:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Others1;
          break;
        case 14:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Others2;
          break;
        case 15:
          this.listBox_Add_Index.DisplayMember = "Name";
          this.listBox_Add_Index.ValueMember = "Index";
          this.listBox_Add_Index.DataSource = (object) this.L_Scrolls;
          break;
      }
      this.listBox_Add_Index.SelectedIndex = -1;
      this.DontWork = false;
      if (this.LastSelectedItemIndex > this.listBox_Add_Index.Items.Count)
        return;
      this.listBox_Add_Index.SelectedIndex = this.LastSelectedItemIndex;
    }

    private void listBox_Add_Index_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(this.listBox_Add_Index.SelectedIndex != -1 & !this.DontWork))
        return;
      this.LastSelectedItemIndex = this.listBox_Add_Index.SelectedIndex;
      try
      {
        this.pictureBox_Add_ItemPreview.BackgroundImage = (Image) Resources.ResourceManager.GetObject("_" + this.listBox_Add_Group.SelectedValue + this.listBox_Add_Index.SelectedValue);
        if (this.pictureBox_Add_ItemPreview.BackgroundImage.Size.Width > this.pictureBox_Add_ItemPreview.Size.Width || this.pictureBox_Add_ItemPreview.BackgroundImage.Size.Height > this.pictureBox_Add_ItemPreview.Size.Height)
          this.pictureBox_Add_ItemPreview.BackgroundImageLayout = ImageLayout.Zoom;
        else
          this.pictureBox_Add_ItemPreview.BackgroundImageLayout = ImageLayout.Center;
      }
      catch
      {
        this.pictureBox_Add_ItemPreview.BackgroundImage = (Image) Resources.ResourceManager.GetObject("no_img");
      }
    }

    private void listBox_AddedItems_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(this.listBox_AddedItems.SelectedIndex != -1 & !this.DontWork))
        return;
      Structures.EventBagItem selectedItem = (Structures.EventBagItem) this.listBox_AddedItems.SelectedItem;
      this.numericUpDown_Added_MaxLevel.Value = (Decimal) selectedItem.MaxLevel;
      this.numericUpDown_Added_MinLevel.Value = (Decimal) selectedItem.MinLevel;
      this.checkBox_Added_Exc.Checked = selectedItem.Excellent;
      this.checkBox_Added_Luck.Checked = selectedItem.Luck;
      this.comboBox_Added_MaxOption.SelectedValue = (object) selectedItem.new_MaxOption;
      this.checkBox_Added_Skill.Checked = selectedItem.Skill;
      this.checkBox_Added_Anc.Checked = selectedItem.Ancient;
      this.checkBox_Added_Sock.Checked = selectedItem.Socket;
      try
      {
        this.pictureBox_Added_ItemPreview.BackgroundImage = (Image) Resources.ResourceManager.GetObject("_" + (object) selectedItem.Group + (object) selectedItem.Index);
        if (this.pictureBox_Added_ItemPreview.BackgroundImage.Size.Width > this.pictureBox_Added_ItemPreview.Size.Width || this.pictureBox_Added_ItemPreview.BackgroundImage.Size.Height > this.pictureBox_Added_ItemPreview.Size.Height)
          this.pictureBox_Added_ItemPreview.BackgroundImageLayout = ImageLayout.Zoom;
        else
          this.pictureBox_Added_ItemPreview.BackgroundImageLayout = ImageLayout.Center;
      }
      catch
      {
        this.pictureBox_Added_ItemPreview.BackgroundImage = (Image) Resources.ResourceManager.GetObject("no_img");
      }
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.button_Item_Update.Enabled = false;
      this.button_Item_Remove.Enabled = false;
      this.BagDrop = new Structures.EventBagDrop();
      this.BagItemList.Clear();
      this.numericUpDown_DropRate.Value = 0M;
      this.numericUpDown_ExcDropRate.Value = 0M;
      this.numericUpDown_AncDropRate.Value = 0M;
      this.numericUpDown_SocketDropRate.Value = 0M;
      this.numericUpDown_BagZen.Value = 0M;
      this.numericUpDown_Add_MinLevel.Value = 0M;
      this.numericUpDown_Add_MaxLevel.Value = 15M;
      this.numericUpDown_Added_MinLevel.Value = 0M;
      this.numericUpDown_Added_MaxLevel.Value = 15M;
      this.comboBox_Added_MaxOption.SelectedIndex = 0;
      this.checkBox_Add_Skill.Checked = false;
      this.checkBox_Add_Luck.Checked = false;
      this.checkBox_Add_Anc.Checked = false;
      this.checkBox_Add_Sock.Checked = false;
      this.comboBox_Add_MaxOption.SelectedIndex = 0;
      this.checkBox_Add_Exc.Checked = false;
      this.checkBox_Added_Skill.Checked = false;
      this.checkBox_Added_Luck.Checked = false;
      this.checkBox_Added_Anc.Checked = false;
      this.checkBox_Added_Sock.Checked = false;
      this.checkBox_Added_Exc.Checked = false;
      this.numericUpDown_DefMinLvl.Value = 0M;
      this.numericUpDown_DefMaxLvl.Value = 15M;
      this.comboBox_DefMaxOption.SelectedIndex = 0;
      this.checkBox_DefSkill.Checked = false;
      this.checkBox_DefLuck.Checked = false;
      this.checkBox_DefExc.Checked = false;
      this.checkBox_DefAnc.Checked = false;
      this.checkBox_DefSocket.Checked = false;
      this.label_ItemCount.Text = "0";
      this.textBox_EventName.Text = "";
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the EventBag (xml) file to load";
      openFileDialog1.Filter = "XML files (*.xml)|*.xml";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = openFileDialog2.FileName.Split('\\');
      this.label_FileName.Text = strArray[strArray.Length - 1];
      this.BagDrop = new Structures.EventBagDrop();
      this.BagItemList.Clear();
      this.label_ItemCount.Text = "0";
      this.strct.ReadXMLEventBagFile(openFileDialog2.FileName, ref this.BagDrop, ref this.BagItemList, this.ItemName);
      if (this.listBox_AddedItems.Items.Count > 0)
      {
        this.listBox_AddedItems.SelectedIndex = -1;
        this.listBox_AddedItems.SelectedIndex = 0;
        this.button_Item_Update.Enabled = true;
        this.button_Item_Remove.Enabled = true;
        this.label_ItemCount.Text = this.listBox_AddedItems.Items.Count.ToString();
      }
      this.textBox_EventName.Text = this.BagDrop.Name;
      this.numericUpDown_BagZen.Value = (Decimal) this.BagDrop.Zen;
      this.numericUpDown_DropRate.Value = (Decimal) this.BagDrop.ItemDropRate;
      this.numericUpDown_ExcDropRate.Value = (Decimal) this.BagDrop.ExcDropRate;
      this.numericUpDown_AncDropRate.Value = (Decimal) this.BagDrop.AncDropRate;
      this.numericUpDown_SocketDropRate.Value = (Decimal) this.BagDrop.SocketDropRate;
      this.numericUpDown_DefMinLvl.Value = (Decimal) this.BagDrop.Default_minlv;
      this.numericUpDown_DefMaxLvl.Value = (Decimal) this.BagDrop.Default_maxlv;
      this.comboBox_DefMaxOption.SelectedValue = (object) this.BagDrop.Default_addopt;
      this.checkBox_DefSkill.Checked = this.BagDrop.Default_skill;
      this.checkBox_DefAnc.Checked = this.BagDrop.Default_anc;
      this.checkBox_DefLuck.Checked = this.BagDrop.Default_luck;
      this.checkBox_DefExc.Checked = this.BagDrop.Default_exc;
      this.checkBox_DefSocket.Checked = this.BagDrop.Default_sock;
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Title = "Select a location to save the EventBag";
      saveFileDialog1.Filter = "XML files (*.xml)|*.xml";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = saveFileDialog2.FileName.Split('\\');
      this.label_FileName.Text = strArray[strArray.Length - 1];
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName);
      streamWriter.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
      streamWriter.WriteLine("\t<ItemBag>");
      streamWriter.WriteLine("\t\t<Bag>");
      streamWriter.WriteLine("\t\t\t<!-- ItemRate [0..100];  ExcRate [0..100]; AncientRate [0..100]; SocketRate [0..100]; -->");
      streamWriter.WriteLine("\t\t\t<BagConfig Name=\"" + this.textBox_EventName.Text + "\" ZenDrop=\"" + (object) this.numericUpDown_BagZen.Value + "\" ItemRate=\"" + (object) this.numericUpDown_DropRate.Value + "\" ExcRate=\"" + (object) this.numericUpDown_ExcDropRate.Value + "\" AncientRate=\"" + (object) this.numericUpDown_AncDropRate.Value + "\" SocketRate=\"" + (object) this.numericUpDown_SocketDropRate.Value + "\"/>");
      streamWriter.WriteLine("\t\t</Bag>");
      streamWriter.WriteLine("\t\t<Default>");
      streamWriter.WriteLine("\t\t\t<!-- addopt [0..7];  exc [0/1]; anc [0/1]; sock [0/1]; -->");
      streamWriter.WriteLine("\t\t\t<DefaultConfig cat=\"0\" id=\"0\" minlv=\"" + (object) this.numericUpDown_DefMinLvl.Value + "\" maxlv=\"" + (object) this.numericUpDown_DefMaxLvl.Value + "\" skill=\"" + (this.checkBox_DefSkill.Checked ? (object) "1" : (object) "0") + "\" luck=\"" + (this.checkBox_DefLuck.Checked ? (object) "1" : (object) "0") + "\" addopt=\"" + this.comboBox_DefMaxOption.SelectedValue + "\" exc=\"" + (this.checkBox_DefExc.Checked ? (object) "1" : (object) "0") + "\" anc=\"" + (this.checkBox_DefAnc.Checked ? (object) "1" : (object) "0") + "\" sock=\"" + (this.checkBox_DefSocket.Checked ? (object) "1" : (object) "0") + "\"/>");
      streamWriter.WriteLine("\t\t</Default>");
      streamWriter.WriteLine("\t\t<Items>");
      streamWriter.WriteLine("\t\t\t<!-- addopt [0..7];  exc [0/1]; anc [0/1]; sock [0/1]; -->");
      foreach (Structures.EventBagItem bagItem in (Collection<Structures.EventBagItem>) this.BagItemList)
        streamWriter.WriteLine("\t\t\t<Item cat=\"" + (object) bagItem.Group + "\" id=\"" + (object) bagItem.Index + "\" minlv=\"" + (object) bagItem.MinLevel + "\" maxlv=\"" + (object) bagItem.MaxLevel + "\" skill=\"" + (bagItem.Skill ? (object) "1" : (object) "0") + "\" luck=\"" + (bagItem.Luck ? (object) "1" : (object) "0") + "\" addopt=\"" + (object) bagItem.new_MaxOption + "\" exc=\"" + (bagItem.Excellent ? (object) "1" : (object) "0") + "\" anc=\"" + (bagItem.Ancient ? (object) "1" : (object) "0") + "\" sock=\"" + (bagItem.Socket ? (object) "1" : (object) "0") + "\"/>");
      streamWriter.WriteLine("\t\t</Items>");
      streamWriter.WriteLine("\t</ItemBag>");
      streamWriter.Flush();
      streamWriter.Close();
    }
  }
}
