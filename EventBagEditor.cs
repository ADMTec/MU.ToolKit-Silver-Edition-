// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.EventBagEditor
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
  public class EventBagEditor : Form
  {
    private Structures.EventBagDrop BagDrop = new Structures.EventBagDrop();
    private BindingList<Structures.EventBagItem> BagItemList = new BindingList<Structures.EventBagItem>();
    private BindingList<Structures.EventBagMap> BagMapList = new BindingList<Structures.EventBagMap>();
    private Button button_AddItem;
    private Button button_AddMap;
    private Button button_Item_Remove;
    private Button button_Item_Update;
    private Button button_Map_Update;
    private Button button_RemoveMap;
    private List<Structures.UniItem> C_Armors = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Axes = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Boots = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_BowsCrossBows = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Gloves = new List<Structures.UniItem>();
    private List<Structures.c_Groups> C_Groups = new List<Structures.c_Groups>();
    private List<Structures.UniItem> C_Helms = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_MacesScepters = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Others1 = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Others2 = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Pants = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Scrolls = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Shields = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Spears = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Staffs = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_Swords = new List<Structures.UniItem>();
    private List<Structures.UniItem> C_WingsSkillsSeedsOthers = new List<Structures.UniItem>();
    private CheckBox checkBox_Add_Exc;
    private CheckBox checkBox_Add_Luck;
    private CheckBox checkBox_Add_Option;
    private CheckBox checkBox_Add_Skill;
    private CheckBox checkBox_Added_Exc;
    private CheckBox checkBox_Added_Luck;
    private CheckBox checkBox_Added_Option;
    private CheckBox checkBox_Added_Skill;
    private CheckBox checkBox_Map_Drop;
    private ColorDialog colorDialog1;
    private ComboBox comboBox_Bag_ItemGroup;
    private ComboBox comboBox_Bag_ItemIndex;
    private IContainer components;
    private bool DontWork;
    private ToolStripMenuItem fileToolStripMenuItem;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private GroupBox groupBox5;
    private GroupBox groupBox6;
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
    private Label label16;
    private Label label17;
    private Label label18;
    private Label label2;
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
    private ListBox listBox_MapSelection;
    private ListBox listBox_SelectedMaps;
    private string[] MapName = new string[(int) byte.MaxValue];
    private MenuStrip menuStrip1;
    private ToolStripMenuItem newToolStripMenuItem;
    private NumericUpDown numericUpDown_Add_MaxLevel;
    private NumericUpDown numericUpDown_Add_MinLevel;
    private NumericUpDown numericUpDown_Added_MaxLevel;
    private NumericUpDown numericUpDown_Added_MinLevel;
    private NumericUpDown numericUpDown_BagDropRate;
    private NumericUpDown numericUpDown_BagLevel;
    private NumericUpDown numericUpDown_BagZen;
    private NumericUpDown numericUpDown_DropRate;
    private NumericUpDown numericUpDown_ExcDropRate;
    private NumericUpDown numericUpDown_Map_MaxMobLvl;
    private NumericUpDown numericUpDown_Map_MinMobLvl;
    private ToolStripMenuItem openToolStripMenuItem;
    private PictureBox pictureBox_Add_ItemPreview;
    private PictureBox pictureBox_Added_ItemPreview;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private Structures strct = new Structures();
    private TextBox textBox_EventName;

    public EventBagEditor() => this.InitializeComponent();

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
        Option = this.checkBox_Add_Option.Checked,
        Skill = this.checkBox_Add_Skill.Checked,
        Excellent = this.checkBox_Add_Exc.Checked
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

    private void button_AddMap_Click(object sender, EventArgs e)
    {
      Structures.EventBagMap eventBagMap1 = new Structures.EventBagMap();
      Structures.Map selectedItem = (Structures.Map) this.listBox_MapSelection.SelectedItem;
      eventBagMap1.Drop = this.checkBox_Map_Drop.Checked;
      eventBagMap1.ID = selectedItem.MapCode;
      eventBagMap1.MobMaxLvl = (int) this.numericUpDown_Map_MaxMobLvl.Value;
      eventBagMap1.MobMinLvl = (int) this.numericUpDown_Map_MinMobLvl.Value;
      eventBagMap1.Name = selectedItem.MapName;
      foreach (Structures.EventBagMap eventBagMap2 in this.listBox_SelectedMaps.Items)
      {
        if (eventBagMap2.ID == eventBagMap1.ID)
          return;
      }
      this.BagMapList.Add(eventBagMap1);
      this.listBox_SelectedMaps.SelectedIndex = -1;
      this.listBox_SelectedMaps.SelectedIndex = this.listBox_SelectedMaps.Items.Count - 1;
      if (!this.button_Map_Update.Enabled)
        this.button_Map_Update.Enabled = true;
      if (this.button_RemoveMap.Enabled)
        return;
      this.button_RemoveMap.Enabled = true;
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
        Option = this.checkBox_Added_Option.Checked,
        Skill = this.checkBox_Added_Skill.Checked
      };
      this.BagItemList[this.BagItemList.IndexOf(selectedItem)] = eventBagItem;
      this.DontWork = false;
    }

    private void button_Map_Update_Click(object sender, EventArgs e)
    {
      this.DontWork = true;
      Structures.EventBagMap selectedItem = (Structures.EventBagMap) this.listBox_SelectedMaps.SelectedItem;
      Structures.EventBagMap eventBagMap = selectedItem with
      {
        Drop = this.checkBox_Map_Drop.Checked,
        MobMaxLvl = (int) this.numericUpDown_Map_MaxMobLvl.Value,
        MobMinLvl = (int) this.numericUpDown_Map_MinMobLvl.Value
      };
      this.BagMapList[this.BagMapList.IndexOf(selectedItem)] = eventBagMap;
      this.DontWork = false;
    }

    private void button_RemoveMap_Click(object sender, EventArgs e)
    {
      if (this.listBox_SelectedMaps.SelectedIndex == -1)
        return;
      this.BagMapList.Remove((Structures.EventBagMap) this.listBox_SelectedMaps.SelectedItem);
      if (this.listBox_SelectedMaps.Items.Count >= 1)
        return;
      this.button_Map_Update.Enabled = false;
    }

    private void comboBox_Bag_ItemGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.comboBox_Bag_ItemGroup.SelectedIndex == -1)
        return;
      switch ((int) this.comboBox_Bag_ItemGroup.SelectedValue)
      {
        case 0:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Swords;
          break;
        case 1:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Axes;
          break;
        case 2:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_MacesScepters;
          break;
        case 3:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Spears;
          break;
        case 4:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_BowsCrossBows;
          break;
        case 5:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Staffs;
          break;
        case 6:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Shields;
          break;
        case 7:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Helms;
          break;
        case 8:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Armors;
          break;
        case 9:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Pants;
          break;
        case 10:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Gloves;
          break;
        case 11:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Boots;
          break;
        case 12:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_WingsSkillsSeedsOthers;
          break;
        case 13:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Others1;
          break;
        case 14:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Others2;
          break;
        case 15:
          this.comboBox_Bag_ItemIndex.DisplayMember = "Name";
          this.comboBox_Bag_ItemIndex.ValueMember = "Index";
          this.comboBox_Bag_ItemIndex.DataSource = (object) this.C_Scrolls;
          break;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void EventBagEditor_FormClosed(object sender, FormClosedEventArgs e) => Application.OpenForms["Form1"].WindowState = FormWindowState.Normal;

    private void EventBagEditor_Load(object sender, EventArgs e)
    {
      this.isEx700ItemList = ((Form1) Application.OpenForms[0]).isEx700ItemList ? 1 : 0;
      this.strct.initMapListBox(ref this.listBox_MapSelection, ref this.MapName);
      this.listBox_SelectedMaps.DataSource = (object) this.BagMapList;
      this.listBox_SelectedMaps.ValueMember = "ID";
      this.listBox_SelectedMaps.DisplayMember = "Name";
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
      this.comboBox_Bag_ItemGroup.DisplayMember = "GroupName";
      this.comboBox_Bag_ItemGroup.ValueMember = "Group";
      this.comboBox_Bag_ItemGroup.DataSource = (object) this.C_Groups;
      this.listBox_AddedItems.DataSource = (object) this.BagItemList;
      this.listBox_AddedItems.DisplayMember = "Name";
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
      this.label2 = new Label();
      this.groupBox1 = new GroupBox();
      this.groupBox2 = new GroupBox();
      this.button_Map_Update = new Button();
      this.label3 = new Label();
      this.numericUpDown_Map_MaxMobLvl = new NumericUpDown();
      this.label1 = new Label();
      this.numericUpDown_Map_MinMobLvl = new NumericUpDown();
      this.checkBox_Map_Drop = new CheckBox();
      this.button_RemoveMap = new Button();
      this.button_AddMap = new Button();
      this.listBox_SelectedMaps = new ListBox();
      this.listBox_MapSelection = new ListBox();
      this.colorDialog1 = new ColorDialog();
      this.groupBox3 = new GroupBox();
      this.label11 = new Label();
      this.numericUpDown_ExcDropRate = new NumericUpDown();
      this.label12 = new Label();
      this.label9 = new Label();
      this.groupBox4 = new GroupBox();
      this.numericUpDown_BagLevel = new NumericUpDown();
      this.label8 = new Label();
      this.numericUpDown_BagDropRate = new NumericUpDown();
      this.label7 = new Label();
      this.label6 = new Label();
      this.comboBox_Bag_ItemIndex = new ComboBox();
      this.comboBox_Bag_ItemGroup = new ComboBox();
      this.numericUpDown_DropRate = new NumericUpDown();
      this.label5 = new Label();
      this.label10 = new Label();
      this.numericUpDown_BagZen = new NumericUpDown();
      this.label4 = new Label();
      this.textBox_EventName = new TextBox();
      this.groupBox5 = new GroupBox();
      this.label_FileName = new Label();
      this.groupBox7 = new GroupBox();
      this.button_Item_Remove = new Button();
      this.button_Item_Update = new Button();
      this.label16 = new Label();
      this.checkBox_Added_Exc = new CheckBox();
      this.label_ItemCount = new Label();
      this.listBox_AddedItems = new ListBox();
      this.pictureBox_Added_ItemPreview = new PictureBox();
      this.checkBox_Added_Option = new CheckBox();
      this.numericUpDown_Added_MinLevel = new NumericUpDown();
      this.label13 = new Label();
      this.checkBox_Added_Luck = new CheckBox();
      this.numericUpDown_Added_MaxLevel = new NumericUpDown();
      this.label14 = new Label();
      this.checkBox_Added_Skill = new CheckBox();
      this.groupBox6 = new GroupBox();
      this.pictureBox_Add_ItemPreview = new PictureBox();
      this.checkBox_Add_Exc = new CheckBox();
      this.checkBox_Add_Luck = new CheckBox();
      this.checkBox_Add_Option = new CheckBox();
      this.checkBox_Add_Skill = new CheckBox();
      this.label17 = new Label();
      this.label18 = new Label();
      this.button_AddItem = new Button();
      this.numericUpDown_Add_MaxLevel = new NumericUpDown();
      this.numericUpDown_Add_MinLevel = new NumericUpDown();
      this.listBox_Add_Index = new ListBox();
      this.listBox_Add_Group = new ListBox();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.numericUpDown_Map_MaxMobLvl.BeginInit();
      this.numericUpDown_Map_MinMobLvl.BeginInit();
      this.groupBox3.SuspendLayout();
      this.numericUpDown_ExcDropRate.BeginInit();
      this.groupBox4.SuspendLayout();
      this.numericUpDown_BagLevel.BeginInit();
      this.numericUpDown_BagDropRate.BeginInit();
      this.numericUpDown_DropRate.BeginInit();
      this.numericUpDown_BagZen.BeginInit();
      this.groupBox5.SuspendLayout();
      this.groupBox7.SuspendLayout();
      ((ISupportInitialize) this.pictureBox_Added_ItemPreview).BeginInit();
      this.numericUpDown_Added_MinLevel.BeginInit();
      this.numericUpDown_Added_MaxLevel.BeginInit();
      this.groupBox6.SuspendLayout();
      ((ISupportInitialize) this.pictureBox_Add_ItemPreview).BeginInit();
      this.numericUpDown_Add_MaxLevel.BeginInit();
      this.numericUpDown_Add_MinLevel.BeginInit();
      this.SuspendLayout();
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.fileToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(555, 25);
      this.menuStrip1.TabIndex = 4;
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
      this.label2.AutoSize = true;
      this.label2.Location = new Point(12, 31);
      this.label2.Name = "label2";
      this.label2.Size = new Size(239, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "Bag Type: [3 Sections, 8 Columns] ONLY!";
      this.groupBox1.Controls.Add((Control) this.groupBox2);
      this.groupBox1.Controls.Add((Control) this.button_RemoveMap);
      this.groupBox1.Controls.Add((Control) this.button_AddMap);
      this.groupBox1.Controls.Add((Control) this.listBox_SelectedMaps);
      this.groupBox1.Controls.Add((Control) this.listBox_MapSelection);
      this.groupBox1.Location = new Point(12, 57);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(527, 117);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Drop Location";
      this.groupBox2.Controls.Add((Control) this.button_Map_Update);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Map_MaxMobLvl);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Map_MinMobLvl);
      this.groupBox2.Controls.Add((Control) this.checkBox_Map_Drop);
      this.groupBox2.Location = new Point(370, 18);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(147, 90);
      this.groupBox2.TabIndex = 10;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Selectd map options";
      this.button_Map_Update.Enabled = false;
      this.button_Map_Update.Location = new Point(64, 63);
      this.button_Map_Update.Name = "button_Map_Update";
      this.button_Map_Update.Size = new Size(77, 22);
      this.button_Map_Update.TabIndex = 7;
      this.button_Map_Update.Text = "Update";
      this.button_Map_Update.UseVisualStyleBackColor = true;
      this.button_Map_Update.Click += new EventHandler(this.button_Map_Update_Click);
      this.label3.AutoSize = true;
      this.label3.Location = new Point(3, 42);
      this.label3.Name = "label3";
      this.label3.Size = new Size(83, 12);
      this.label3.TabIndex = 4;
      this.label3.Text = "Max Mob Level";
      this.numericUpDown_Map_MaxMobLvl.Location = new Point(87, 39);
      this.numericUpDown_Map_MaxMobLvl.Maximum = new Decimal(new int[4]
      {
        9999999,
        0,
        0,
        0
      });
      this.numericUpDown_Map_MaxMobLvl.Name = "numericUpDown_Map_MaxMobLvl";
      this.numericUpDown_Map_MaxMobLvl.Size = new Size(54, 21);
      this.numericUpDown_Map_MaxMobLvl.TabIndex = 5;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(3, 18);
      this.label1.Name = "label1";
      this.label1.Size = new Size(83, 12);
      this.label1.TabIndex = 2;
      this.label1.Text = "Min Mob Level";
      this.numericUpDown_Map_MinMobLvl.Location = new Point(87, 15);
      this.numericUpDown_Map_MinMobLvl.Maximum = new Decimal(new int[4]
      {
        9999999,
        0,
        0,
        0
      });
      this.numericUpDown_Map_MinMobLvl.Name = "numericUpDown_Map_MinMobLvl";
      this.numericUpDown_Map_MinMobLvl.Size = new Size(54, 21);
      this.numericUpDown_Map_MinMobLvl.TabIndex = 4;
      this.checkBox_Map_Drop.AutoSize = true;
      this.checkBox_Map_Drop.Location = new Point(6, 65);
      this.checkBox_Map_Drop.Name = "checkBox_Map_Drop";
      this.checkBox_Map_Drop.Size = new Size(48, 16);
      this.checkBox_Map_Drop.TabIndex = 6;
      this.checkBox_Map_Drop.Text = "Drop";
      this.checkBox_Map_Drop.UseVisualStyleBackColor = true;
      this.button_RemoveMap.Enabled = false;
      this.button_RemoveMap.Location = new Point(151, 62);
      this.button_RemoveMap.Name = "button_RemoveMap";
      this.button_RemoveMap.Size = new Size(68, 43);
      this.button_RemoveMap.TabIndex = 2;
      this.button_RemoveMap.Text = "<- Remove";
      this.button_RemoveMap.UseVisualStyleBackColor = true;
      this.button_RemoveMap.Click += new EventHandler(this.button_RemoveMap_Click);
      this.button_AddMap.Location = new Point(151, 18);
      this.button_AddMap.Name = "button_AddMap";
      this.button_AddMap.Size = new Size(68, 39);
      this.button_AddMap.TabIndex = 1;
      this.button_AddMap.Text = "Add ->";
      this.button_AddMap.UseVisualStyleBackColor = true;
      this.button_AddMap.Click += new EventHandler(this.button_AddMap_Click);
      this.listBox_SelectedMaps.FormattingEnabled = true;
      this.listBox_SelectedMaps.ItemHeight = 12;
      this.listBox_SelectedMaps.Location = new Point(225, 18);
      this.listBox_SelectedMaps.Name = "listBox_SelectedMaps";
      this.listBox_SelectedMaps.Size = new Size(139, 88);
      this.listBox_SelectedMaps.TabIndex = 3;
      this.listBox_SelectedMaps.SelectedIndexChanged += new EventHandler(this.listBox_SelectedMaps_SelectedIndexChanged);
      this.listBox_MapSelection.FormattingEnabled = true;
      this.listBox_MapSelection.ItemHeight = 12;
      this.listBox_MapSelection.Location = new Point(6, 18);
      this.listBox_MapSelection.Name = "listBox_MapSelection";
      this.listBox_MapSelection.Size = new Size(139, 88);
      this.listBox_MapSelection.TabIndex = 0;
      this.groupBox3.Controls.Add((Control) this.label11);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_ExcDropRate);
      this.groupBox3.Controls.Add((Control) this.label12);
      this.groupBox3.Controls.Add((Control) this.label9);
      this.groupBox3.Controls.Add((Control) this.groupBox4);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_DropRate);
      this.groupBox3.Controls.Add((Control) this.label5);
      this.groupBox3.Controls.Add((Control) this.label10);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_BagZen);
      this.groupBox3.Controls.Add((Control) this.label4);
      this.groupBox3.Controls.Add((Control) this.textBox_EventName);
      this.groupBox3.Location = new Point(12, 180);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(527, 122);
      this.groupBox3.TabIndex = 6;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Drop Configs";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label11.Location = new Point(164, 95);
      this.label11.Name = "label11";
      this.label11.Size = new Size(23, 20);
      this.label11.TabIndex = 17;
      this.label11.Text = "%";
      this.numericUpDown_ExcDropRate.DecimalPlaces = 1;
      this.numericUpDown_ExcDropRate.Location = new Point(108, 95);
      this.numericUpDown_ExcDropRate.Name = "numericUpDown_ExcDropRate";
      this.numericUpDown_ExcDropRate.Size = new Size(50, 21);
      this.numericUpDown_ExcDropRate.TabIndex = 11;
      this.label12.AutoSize = true;
      this.label12.Location = new Point(6, 98);
      this.label12.Name = "label12";
      this.label12.Size = new Size(125, 12);
      this.label12.TabIndex = 15;
      this.label12.Text = "Excellent Drop Rate:";
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label9.Location = new Point(164, 71);
      this.label9.Name = "label9";
      this.label9.Size = new Size(23, 20);
      this.label9.TabIndex = 14;
      this.label9.Text = "%";
      this.groupBox4.Controls.Add((Control) this.numericUpDown_BagLevel);
      this.groupBox4.Controls.Add((Control) this.label8);
      this.groupBox4.Controls.Add((Control) this.numericUpDown_BagDropRate);
      this.groupBox4.Controls.Add((Control) this.label7);
      this.groupBox4.Controls.Add((Control) this.label6);
      this.groupBox4.Controls.Add((Control) this.comboBox_Bag_ItemIndex);
      this.groupBox4.Controls.Add((Control) this.comboBox_Bag_ItemGroup);
      this.groupBox4.Location = new Point(280, 18);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(237, 96);
      this.groupBox4.TabIndex = 5;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Bag Item";
      this.numericUpDown_BagLevel.Location = new Point(39, 67);
      this.numericUpDown_BagLevel.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_BagLevel.Name = "numericUpDown_BagLevel";
      this.numericUpDown_BagLevel.Size = new Size(53, 21);
      this.numericUpDown_BagLevel.TabIndex = 14;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label8.Location = new Point(206, 67);
      this.label8.Name = "label8";
      this.label8.Size = new Size(23, 20);
      this.label8.TabIndex = 11;
      this.label8.Text = "%";
      this.numericUpDown_BagDropRate.DecimalPlaces = 1;
      this.numericUpDown_BagDropRate.Location = new Point(155, 67);
      this.numericUpDown_BagDropRate.Name = "numericUpDown_BagDropRate";
      this.numericUpDown_BagDropRate.Size = new Size(49, 21);
      this.numericUpDown_BagDropRate.TabIndex = 15;
      this.label7.AutoSize = true;
      this.label7.Location = new Point(98, 70);
      this.label7.Name = "label7";
      this.label7.Size = new Size(65, 12);
      this.label7.TabIndex = 9;
      this.label7.Text = "Drop Rate:";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(3, 70);
      this.label6.Name = "label6";
      this.label6.Size = new Size(41, 12);
      this.label6.TabIndex = 6;
      this.label6.Text = "Level:";
      this.comboBox_Bag_ItemIndex.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.comboBox_Bag_ItemIndex.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Bag_ItemIndex.FormattingEnabled = true;
      this.comboBox_Bag_ItemIndex.Location = new Point(6, 42);
      this.comboBox_Bag_ItemIndex.Name = "comboBox_Bag_ItemIndex";
      this.comboBox_Bag_ItemIndex.Size = new Size(223, 20);
      this.comboBox_Bag_ItemIndex.TabIndex = 13;
      this.comboBox_Bag_ItemGroup.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Bag_ItemGroup.FormattingEnabled = true;
      this.comboBox_Bag_ItemGroup.Location = new Point(6, 18);
      this.comboBox_Bag_ItemGroup.Name = "comboBox_Bag_ItemGroup";
      this.comboBox_Bag_ItemGroup.Size = new Size(223, 20);
      this.comboBox_Bag_ItemGroup.TabIndex = 12;
      this.comboBox_Bag_ItemGroup.SelectedIndexChanged += new EventHandler(this.comboBox_Bag_ItemGroup_SelectedIndexChanged);
      this.numericUpDown_DropRate.DecimalPlaces = 1;
      this.numericUpDown_DropRate.Location = new Point(108, 71);
      this.numericUpDown_DropRate.Name = "numericUpDown_DropRate";
      this.numericUpDown_DropRate.Size = new Size(50, 21);
      this.numericUpDown_DropRate.TabIndex = 10;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(6, 54);
      this.label5.Name = "label5";
      this.label5.Size = new Size(29, 12);
      this.label5.TabIndex = 3;
      this.label5.Text = "Zen:";
      this.label10.AutoSize = true;
      this.label10.Location = new Point(6, 73);
      this.label10.Name = "label10";
      this.label10.Size = new Size(107, 12);
      this.label10.TabIndex = 12;
      this.label10.Text = "Normal Drop Rate:";
      this.numericUpDown_BagZen.Location = new Point(78, 47);
      this.numericUpDown_BagZen.Maximum = new Decimal(new int[4]
      {
        int.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_BagZen.Name = "numericUpDown_BagZen";
      this.numericUpDown_BagZen.Size = new Size(196, 21);
      this.numericUpDown_BagZen.TabIndex = 9;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(6, 26);
      this.label4.Name = "label4";
      this.label4.Size = new Size(71, 12);
      this.label4.TabIndex = 1;
      this.label4.Text = "Event Name:";
      this.textBox_EventName.Location = new Point(78, 23);
      this.textBox_EventName.Name = "textBox_EventName";
      this.textBox_EventName.Size = new Size(196, 21);
      this.textBox_EventName.TabIndex = 8;
      this.groupBox5.Controls.Add((Control) this.label_FileName);
      this.groupBox5.Controls.Add((Control) this.groupBox7);
      this.groupBox5.Controls.Add((Control) this.groupBox6);
      this.groupBox5.Location = new Point(12, 307);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(527, 362);
      this.groupBox5.TabIndex = 7;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Bag Items";
      this.label_FileName.ForeColor = Color.DarkGreen;
      this.label_FileName.Location = new Point(108, 14);
      this.label_FileName.Name = "label_FileName";
      this.label_FileName.Size = new Size(292, 14);
      this.label_FileName.TabIndex = 2;
      this.label_FileName.TextAlign = ContentAlignment.TopCenter;
      this.groupBox7.Controls.Add((Control) this.button_Item_Remove);
      this.groupBox7.Controls.Add((Control) this.button_Item_Update);
      this.groupBox7.Controls.Add((Control) this.label16);
      this.groupBox7.Controls.Add((Control) this.checkBox_Added_Exc);
      this.groupBox7.Controls.Add((Control) this.label_ItemCount);
      this.groupBox7.Controls.Add((Control) this.listBox_AddedItems);
      this.groupBox7.Controls.Add((Control) this.pictureBox_Added_ItemPreview);
      this.groupBox7.Controls.Add((Control) this.checkBox_Added_Option);
      this.groupBox7.Controls.Add((Control) this.numericUpDown_Added_MinLevel);
      this.groupBox7.Controls.Add((Control) this.label13);
      this.groupBox7.Controls.Add((Control) this.checkBox_Added_Luck);
      this.groupBox7.Controls.Add((Control) this.numericUpDown_Added_MaxLevel);
      this.groupBox7.Controls.Add((Control) this.label14);
      this.groupBox7.Controls.Add((Control) this.checkBox_Added_Skill);
      this.groupBox7.Location = new Point(9, 213);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(508, 139);
      this.groupBox7.TabIndex = 1;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Existing Items";
      this.button_Item_Remove.Enabled = false;
      this.button_Item_Remove.Location = new Point(6, 107);
      this.button_Item_Remove.Name = "button_Item_Remove";
      this.button_Item_Remove.Size = new Size(172, 27);
      this.button_Item_Remove.TabIndex = 26;
      this.button_Item_Remove.Text = "Remove";
      this.button_Item_Remove.UseVisualStyleBackColor = true;
      this.button_Item_Remove.Click += new EventHandler(this.button_Item_Remove_Click);
      this.button_Item_Update.Enabled = false;
      this.button_Item_Update.Location = new Point(310, 102);
      this.button_Item_Update.Name = "button_Item_Update";
      this.button_Item_Update.Size = new Size(192, 31);
      this.button_Item_Update.TabIndex = 33;
      this.button_Item_Update.Text = "Update";
      this.button_Item_Update.UseVisualStyleBackColor = true;
      this.button_Item_Update.Click += new EventHandler(this.button_Item_Update_Click);
      this.label16.AutoSize = true;
      this.label16.Location = new Point(145, 11);
      this.label16.Name = "label16";
      this.label16.Size = new Size(35, 12);
      this.label16.TabIndex = 22;
      this.label16.Text = "/ 150";
      this.checkBox_Added_Exc.AutoSize = true;
      this.checkBox_Added_Exc.Location = new Point(406, 81);
      this.checkBox_Added_Exc.Name = "checkBox_Added_Exc";
      this.checkBox_Added_Exc.Size = new Size(78, 16);
      this.checkBox_Added_Exc.TabIndex = 32;
      this.checkBox_Added_Exc.Text = "Excellent";
      this.checkBox_Added_Exc.UseVisualStyleBackColor = true;
      this.label_ItemCount.AutoSize = true;
      this.label_ItemCount.Location = new Point(123, 11);
      this.label_ItemCount.Name = "label_ItemCount";
      this.label_ItemCount.RightToLeft = RightToLeft.Yes;
      this.label_ItemCount.Size = new Size(11, 12);
      this.label_ItemCount.TabIndex = 21;
      this.label_ItemCount.Text = "0";
      this.label_ItemCount.TextAlign = ContentAlignment.MiddleLeft;
      this.listBox_AddedItems.FormattingEnabled = true;
      this.listBox_AddedItems.ItemHeight = 12;
      this.listBox_AddedItems.Location = new Point(6, 26);
      this.listBox_AddedItems.Name = "listBox_AddedItems";
      this.listBox_AddedItems.Size = new Size(172, 76);
      this.listBox_AddedItems.TabIndex = 25;
      this.listBox_AddedItems.SelectedIndexChanged += new EventHandler(this.listBox_AddedItems_SelectedIndexChanged);
      this.pictureBox_Added_ItemPreview.BackColor = Color.FromArgb(37, 47, 1);
      this.pictureBox_Added_ItemPreview.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_Added_ItemPreview.Location = new Point(184, 26);
      this.pictureBox_Added_ItemPreview.Name = "pictureBox_Added_ItemPreview";
      this.pictureBox_Added_ItemPreview.Size = new Size(117, 108);
      this.pictureBox_Added_ItemPreview.TabIndex = 12;
      this.pictureBox_Added_ItemPreview.TabStop = false;
      this.checkBox_Added_Option.AutoSize = true;
      this.checkBox_Added_Option.Location = new Point(316, 81);
      this.checkBox_Added_Option.Name = "checkBox_Added_Option";
      this.checkBox_Added_Option.Size = new Size(60, 16);
      this.checkBox_Added_Option.TabIndex = 31;
      this.checkBox_Added_Option.Text = "Option";
      this.checkBox_Added_Option.UseVisualStyleBackColor = true;
      this.numericUpDown_Added_MinLevel.Location = new Point(375, 26);
      this.numericUpDown_Added_MinLevel.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Added_MinLevel.Name = "numericUpDown_Added_MinLevel";
      this.numericUpDown_Added_MinLevel.Size = new Size(53, 21);
      this.numericUpDown_Added_MinLevel.TabIndex = 27;
      this.label13.AutoSize = true;
      this.label13.Location = new Point(313, 53);
      this.label13.Name = "label13";
      this.label13.Size = new Size(59, 12);
      this.label13.TabIndex = 6;
      this.label13.Text = "Max Level";
      this.checkBox_Added_Luck.AutoSize = true;
      this.checkBox_Added_Luck.Location = new Point(448, 53);
      this.checkBox_Added_Luck.Name = "checkBox_Added_Luck";
      this.checkBox_Added_Luck.Size = new Size(48, 16);
      this.checkBox_Added_Luck.TabIndex = 30;
      this.checkBox_Added_Luck.Text = "Luck";
      this.checkBox_Added_Luck.UseVisualStyleBackColor = true;
      this.numericUpDown_Added_MaxLevel.Location = new Point(375, 50);
      this.numericUpDown_Added_MaxLevel.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Added_MaxLevel.Name = "numericUpDown_Added_MaxLevel";
      this.numericUpDown_Added_MaxLevel.Size = new Size(53, 21);
      this.numericUpDown_Added_MaxLevel.TabIndex = 28;
      this.label14.AutoSize = true;
      this.label14.Location = new Point(313, 29);
      this.label14.Name = "label14";
      this.label14.Size = new Size(65, 12);
      this.label14.TabIndex = 5;
      this.label14.Text = "Min Level:";
      this.checkBox_Added_Skill.AutoSize = true;
      this.checkBox_Added_Skill.Location = new Point(448, 27);
      this.checkBox_Added_Skill.Name = "checkBox_Added_Skill";
      this.checkBox_Added_Skill.Size = new Size(54, 16);
      this.checkBox_Added_Skill.TabIndex = 29;
      this.checkBox_Added_Skill.Text = "Skill";
      this.checkBox_Added_Skill.UseVisualStyleBackColor = true;
      this.groupBox6.Controls.Add((Control) this.pictureBox_Add_ItemPreview);
      this.groupBox6.Controls.Add((Control) this.checkBox_Add_Exc);
      this.groupBox6.Controls.Add((Control) this.checkBox_Add_Luck);
      this.groupBox6.Controls.Add((Control) this.checkBox_Add_Option);
      this.groupBox6.Controls.Add((Control) this.checkBox_Add_Skill);
      this.groupBox6.Controls.Add((Control) this.label17);
      this.groupBox6.Controls.Add((Control) this.label18);
      this.groupBox6.Controls.Add((Control) this.button_AddItem);
      this.groupBox6.Controls.Add((Control) this.numericUpDown_Add_MaxLevel);
      this.groupBox6.Controls.Add((Control) this.numericUpDown_Add_MinLevel);
      this.groupBox6.Controls.Add((Control) this.listBox_Add_Index);
      this.groupBox6.Controls.Add((Control) this.listBox_Add_Group);
      this.groupBox6.Location = new Point(9, 28);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(508, 180);
      this.groupBox6.TabIndex = 0;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Item Selection";
      this.pictureBox_Add_ItemPreview.BackColor = Color.FromArgb(37, 47, 1);
      this.pictureBox_Add_ItemPreview.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_Add_ItemPreview.Location = new Point(381, 16);
      this.pictureBox_Add_ItemPreview.Name = "pictureBox_Add_ItemPreview";
      this.pictureBox_Add_ItemPreview.Size = new Size(119, 110);
      this.pictureBox_Add_ItemPreview.TabIndex = 29;
      this.pictureBox_Add_ItemPreview.TabStop = false;
      this.checkBox_Add_Exc.AutoSize = true;
      this.checkBox_Add_Exc.Location = new Point(306, 148);
      this.checkBox_Add_Exc.Name = "checkBox_Add_Exc";
      this.checkBox_Add_Exc.Size = new Size(78, 16);
      this.checkBox_Add_Exc.TabIndex = 23;
      this.checkBox_Add_Exc.Text = "Excellent";
      this.checkBox_Add_Exc.UseVisualStyleBackColor = true;
      this.checkBox_Add_Luck.AutoSize = true;
      this.checkBox_Add_Luck.Location = new Point(182, 148);
      this.checkBox_Add_Luck.Name = "checkBox_Add_Luck";
      this.checkBox_Add_Luck.Size = new Size(48, 16);
      this.checkBox_Add_Luck.TabIndex = 21;
      this.checkBox_Add_Luck.Text = "Luck";
      this.checkBox_Add_Luck.UseVisualStyleBackColor = true;
      this.checkBox_Add_Option.AutoSize = true;
      this.checkBox_Add_Option.Location = new Point(241, 148);
      this.checkBox_Add_Option.Name = "checkBox_Add_Option";
      this.checkBox_Add_Option.Size = new Size(60, 16);
      this.checkBox_Add_Option.TabIndex = 22;
      this.checkBox_Add_Option.Text = "Option";
      this.checkBox_Add_Option.UseVisualStyleBackColor = true;
      this.checkBox_Add_Skill.AutoSize = true;
      this.checkBox_Add_Skill.Location = new Point(131, 148);
      this.checkBox_Add_Skill.Name = "checkBox_Add_Skill";
      this.checkBox_Add_Skill.Size = new Size(54, 16);
      this.checkBox_Add_Skill.TabIndex = 20;
      this.checkBox_Add_Skill.Text = "Skill";
      this.checkBox_Add_Skill.UseVisualStyleBackColor = true;
      this.label17.AutoSize = true;
      this.label17.Location = new Point(6, 135);
      this.label17.Name = "label17";
      this.label17.Size = new Size(65, 12);
      this.label17.TabIndex = 23;
      this.label17.Text = "Min Level:";
      this.label18.AutoSize = true;
      this.label18.Location = new Point(6, 159);
      this.label18.Name = "label18";
      this.label18.Size = new Size(59, 12);
      this.label18.TabIndex = 24;
      this.label18.Text = "Max Level";
      this.button_AddItem.Location = new Point(381, 131);
      this.button_AddItem.Name = "button_AddItem";
      this.button_AddItem.Size = new Size(121, 43);
      this.button_AddItem.TabIndex = 24;
      this.button_AddItem.Text = "Add";
      this.button_AddItem.UseVisualStyleBackColor = true;
      this.button_AddItem.Click += new EventHandler(this.button_AddItem_Click);
      this.numericUpDown_Add_MaxLevel.Location = new Point(68, 156);
      this.numericUpDown_Add_MaxLevel.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Add_MaxLevel.Name = "numericUpDown_Add_MaxLevel";
      this.numericUpDown_Add_MaxLevel.Size = new Size(53, 21);
      this.numericUpDown_Add_MaxLevel.TabIndex = 19;
      this.numericUpDown_Add_MinLevel.Location = new Point(68, 132);
      this.numericUpDown_Add_MinLevel.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Add_MinLevel.Name = "numericUpDown_Add_MinLevel";
      this.numericUpDown_Add_MinLevel.Size = new Size(53, 21);
      this.numericUpDown_Add_MinLevel.TabIndex = 18;
      this.listBox_Add_Index.FormattingEnabled = true;
      this.listBox_Add_Index.ItemHeight = 12;
      this.listBox_Add_Index.Location = new Point(184, 16);
      this.listBox_Add_Index.Name = "listBox_Add_Index";
      this.listBox_Add_Index.Size = new Size(191, 112);
      this.listBox_Add_Index.TabIndex = 17;
      this.listBox_Add_Index.SelectedIndexChanged += new EventHandler(this.listBox_Add_Index_SelectedIndexChanged);
      this.listBox_Add_Group.FormattingEnabled = true;
      this.listBox_Add_Group.ItemHeight = 12;
      this.listBox_Add_Group.Location = new Point(6, 16);
      this.listBox_Add_Group.Name = "listBox_Add_Group";
      this.listBox_Add_Group.Size = new Size(172, 112);
      this.listBox_Add_Group.TabIndex = 16;
      this.listBox_Add_Group.SelectedIndexChanged += new EventHandler(this.listBox_Add_Group_SelectedIndexChanged);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(555, 680);
      this.Controls.Add((Control) this.groupBox5);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.menuStrip1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = nameof (EventBagEditor);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "EventBag Editor (TXT)";
      this.FormClosed += new FormClosedEventHandler(this.EventBagEditor_FormClosed);
      this.Load += new EventHandler(this.EventBagEditor_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.numericUpDown_Map_MaxMobLvl.EndInit();
      this.numericUpDown_Map_MinMobLvl.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.numericUpDown_ExcDropRate.EndInit();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.numericUpDown_BagLevel.EndInit();
      this.numericUpDown_BagDropRate.EndInit();
      this.numericUpDown_DropRate.EndInit();
      this.numericUpDown_BagZen.EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      ((ISupportInitialize) this.pictureBox_Added_ItemPreview).EndInit();
      this.numericUpDown_Added_MinLevel.EndInit();
      this.numericUpDown_Added_MaxLevel.EndInit();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      ((ISupportInitialize) this.pictureBox_Add_ItemPreview).EndInit();
      this.numericUpDown_Add_MaxLevel.EndInit();
      this.numericUpDown_Add_MinLevel.EndInit();
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
      this.checkBox_Added_Option.Checked = selectedItem.Option;
      this.checkBox_Added_Skill.Checked = selectedItem.Skill;
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

    private void listBox_SelectedMaps_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(this.listBox_SelectedMaps.SelectedIndex != -1 & !this.DontWork))
        return;
      Structures.EventBagMap selectedItem = (Structures.EventBagMap) this.listBox_SelectedMaps.SelectedItem;
      this.numericUpDown_Map_MaxMobLvl.Value = (Decimal) selectedItem.MobMaxLvl;
      this.numericUpDown_Map_MinMobLvl.Value = (Decimal) selectedItem.MobMinLvl;
      this.checkBox_Map_Drop.Checked = selectedItem.Drop;
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.button_Item_Update.Enabled = false;
      this.button_Item_Remove.Enabled = false;
      this.button_Map_Update.Enabled = false;
      this.button_RemoveMap.Enabled = false;
      this.BagMapList.Clear();
      this.BagDrop = new Structures.EventBagDrop();
      this.BagItemList.Clear();
      this.numericUpDown_Map_MinMobLvl.Value = 0M;
      this.numericUpDown_Map_MaxMobLvl.Value = 0M;
      this.numericUpDown_DropRate.Value = 0M;
      this.numericUpDown_ExcDropRate.Value = 0M;
      this.numericUpDown_BagDropRate.Value = 0M;
      this.numericUpDown_BagZen.Value = 0M;
      this.numericUpDown_Add_MinLevel.Value = 0M;
      this.numericUpDown_Add_MaxLevel.Value = 0M;
      this.numericUpDown_Added_MinLevel.Value = 0M;
      this.numericUpDown_Added_MaxLevel.Value = 0M;
      this.checkBox_Map_Drop.Checked = false;
      this.checkBox_Add_Skill.Checked = false;
      this.checkBox_Add_Luck.Checked = false;
      this.checkBox_Add_Option.Checked = false;
      this.checkBox_Add_Exc.Checked = false;
      this.checkBox_Added_Skill.Checked = false;
      this.checkBox_Added_Luck.Checked = false;
      this.checkBox_Added_Option.Checked = false;
      this.checkBox_Added_Exc.Checked = false;
      this.label_ItemCount.Text = "0";
      this.textBox_EventName.Text = "";
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the EventBag (txt) file to load";
      openFileDialog1.Filter = "TXT files (*.txt)|*.txt";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = openFileDialog2.FileName.Split('\\');
      this.label_FileName.Text = strArray[strArray.Length - 1];
      this.BagMapList.Clear();
      this.BagDrop = new Structures.EventBagDrop();
      this.BagItemList.Clear();
      this.label_ItemCount.Text = "0";
      this.strct.ReadEventBagFile(openFileDialog2.FileName, ref this.BagMapList, ref this.BagDrop, ref this.BagItemList, this.ItemName, this.MapName);
      if (this.listBox_SelectedMaps.Items.Count > 0)
      {
        this.listBox_SelectedMaps.SelectedIndex = -1;
        this.listBox_SelectedMaps.SelectedIndex = 0;
        this.button_Map_Update.Enabled = true;
        this.button_RemoveMap.Enabled = true;
      }
      if (this.listBox_AddedItems.Items.Count > 0)
      {
        this.listBox_AddedItems.SelectedIndex = -1;
        this.listBox_AddedItems.SelectedIndex = 0;
        this.button_Item_Update.Enabled = true;
        this.button_Item_Remove.Enabled = true;
      }
      double num = this.BagDrop.BagDropRate / 1000.0;
      this.textBox_EventName.Text = this.BagDrop.Name;
      this.numericUpDown_BagZen.Value = (Decimal) this.BagDrop.Zen;
      this.numericUpDown_DropRate.Value = (Decimal) this.BagDrop.ItemDropRate;
      this.numericUpDown_ExcDropRate.Value = (Decimal) this.BagDrop.ExcDropRate / 1000M * 100M;
      this.numericUpDown_BagLevel.Value = (Decimal) this.BagDrop.BagLevel;
      this.numericUpDown_BagDropRate.Value = (Decimal) (this.BagDrop.BagDropRate / 1000.0 * 100.0);
      this.comboBox_Bag_ItemGroup.SelectedValue = (object) this.BagDrop.BagGroup;
      this.comboBox_Bag_ItemIndex.SelectedValue = (object) this.BagDrop.BagIndex;
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Title = "Select a location to save the EventBag";
      saveFileDialog1.Filter = "TXT files (*.txt)|*.txt";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = saveFileDialog2.FileName.Split('\\');
      this.label_FileName.Text = strArray[strArray.Length - 1];
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName);
      streamWriter.WriteLine("//Created by MU.ToolKit coded by TopReal.IT");
      streamWriter.WriteLine();
      streamWriter.WriteLine("0");
      streamWriter.WriteLine("//\tMapID\tDrop\tMinMobLvl\tMaxMobLvl\tName");
      foreach (Structures.EventBagMap bagMap in (Collection<Structures.EventBagMap>) this.BagMapList)
        streamWriter.WriteLine("\t{0}\t{1}\t{2}\t\t{3}\t\t//{4}", (object) bagMap.ID, (object) Convert.ToInt16(bagMap.Drop), (object) bagMap.MobMinLvl, (object) bagMap.MobMaxLvl, (object) bagMap.Name);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      this.BagDrop.Name = this.textBox_EventName.Text;
      this.BagDrop.Zen = (int) this.numericUpDown_BagZen.Value;
      this.BagDrop.ItemDropRate = (double) Convert.ToInt32(this.numericUpDown_DropRate.Value);
      this.BagDrop.ExcDropRate = (double) Convert.ToInt32(this.numericUpDown_ExcDropRate.Value * 100M);
      this.BagDrop.BagGroup = (int) this.comboBox_Bag_ItemGroup.SelectedValue;
      this.BagDrop.BagIndex = (int) this.comboBox_Bag_ItemIndex.SelectedValue;
      this.BagDrop.BagLevel = (int) this.numericUpDown_BagLevel.Value;
      this.BagDrop.BagDropRate = (double) Convert.ToInt32(this.numericUpDown_BagDropRate.Value * 100M);
      streamWriter.WriteLine("1");
      streamWriter.WriteLine("//\tEventName\tZen\t\tEventItemGroup\tEventItemIndex\tEventItemLevel\tEventItemDR\tItemDR\tExItemDR");
      streamWriter.WriteLine("\t{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", (object) ("\"" + this.BagDrop.Name + "\""), (object) this.BagDrop.Zen, (object) this.BagDrop.BagGroup, (object) this.BagDrop.BagIndex, (object) this.BagDrop.BagLevel, (object) this.BagDrop.BagDropRate, (object) this.BagDrop.ItemDropRate, (object) this.BagDrop.ExcDropRate);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("2");
      streamWriter.WriteLine("//\tGroup\tIndex\tMinLvl\tMaxLvl\tSkill\tLuck\tOpt\tExc\tName");
      foreach (Structures.EventBagItem bagItem in (Collection<Structures.EventBagItem>) this.BagItemList)
        streamWriter.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t//{8}", (object) bagItem.Group, (object) bagItem.Index, (object) bagItem.MinLevel, (object) bagItem.MaxLevel, (object) Convert.ToInt16(bagItem.Skill), (object) Convert.ToInt16(bagItem.Luck), (object) Convert.ToInt16(bagItem.Option), (object) Convert.ToInt16(bagItem.Excellent), (object) bagItem.Name);
      streamWriter.WriteLine("end");
      streamWriter.Flush();
      streamWriter.Close();
    }
  }
}
