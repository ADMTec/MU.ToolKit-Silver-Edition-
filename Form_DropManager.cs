// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.Form_DropManager
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
using System.Linq;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class Form_DropManager : Form
  {
    private Button button_Existing_RemoveSelected;
    private Button button_Existing_UpdateSelected;
    private Button button_New_Add;
    private BindingList<Structures.c_AncientData> c_AncientDatas_Existing = new BindingList<Structures.c_AncientData>();
    private BindingList<Structures.c_AncientData> c_AncientDatas_New = new BindingList<Structures.c_AncientData>();
    private List<Structures.c_OptionData> c_OptionDatas_Existing = new List<Structures.c_OptionData>();
    private List<Structures.c_OptionData> c_OptionDatas_New = new List<Structures.c_OptionData>();
    public CheckBox checkBox_Existing_ExcOpt1;
    public CheckBox checkBox_Existing_ExcOpt2;
    public CheckBox checkBox_Existing_ExcOpt3;
    public CheckBox checkBox_Existing_ExcOpt4;
    public CheckBox checkBox_Existing_ExcOpt5;
    public CheckBox checkBox_Existing_ExcOpt6;
    private CheckBox checkBox_Existing_Luck;
    private CheckBox checkBox_Existing_RandomExc;
    private CheckBox checkBox_Existing_Skill;
    public CheckBox checkBox_New_ExcOpt1;
    public CheckBox checkBox_New_ExcOpt2;
    public CheckBox checkBox_New_ExcOpt3;
    public CheckBox checkBox_New_ExcOpt4;
    public CheckBox checkBox_New_ExcOpt5;
    public CheckBox checkBox_New_ExcOpt6;
    private CheckBox checkBox_New_Luck;
    private CheckBox checkBox_New_RandomExc;
    private CheckBox checkBox_New_Skill;
    private ComboBox comboBox_Existing_Ancient;
    private ComboBox comboBox_Existing_Map;
    private ComboBox comboBox_Existing_Mob;
    private ComboBox comboBox_Existing_Opt;
    private ComboBox comboBox_New_Ancient;
    private ComboBox comboBox_New_Map;
    private ComboBox comboBox_New_Mob;
    private ComboBox comboBox_New_Opt;
    private IContainer components;
    private bool DontWork;
    private ToolStripMenuItem fileToolStripMenuItem;
    private string[,] GetItemName = new string[16, 512];
    private GroupBox groupBox_NewItem_ExcOpt;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private GroupBox groupBox5;
    private GroupBox groupBox6;
    private GroupBox groupBox7;
    private BindingList<Structures.IGCDropManagerFile> Items = new BindingList<Structures.IGCDropManagerFile>();
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
    private Label label21;
    private Label label22;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private int LastSelectedItemIndex;
    private ListBox listBox_DropItems;
    private ListBox listBox_New_iGroup;
    private ListBox listBox_New_iIndex;
    private MenuStrip menuStrip1;
    private List<Structures.Map> mMapList_Existing = new List<Structures.Map>();
    private List<Structures.Map> mMapList_New = new List<Structures.Map>();
    private BindingList<Structures.Monster> Monster_Existing = new BindingList<Structures.Monster>();
    private BindingList<Structures.Monster> Monster_New = new BindingList<Structures.Monster>();
    private Dictionary<int, string> MonsterDic = new Dictionary<int, string>();
    private ToolStripMenuItem newToolStripMenuItem;
    private NumericUpDown numericUpDown_Existing_DropRate;
    private NumericUpDown numericUpDown_Existing_Durability;
    private NumericUpDown numericUpDown_Existing_ItemMaxLv;
    private NumericUpDown numericUpDown_Existing_ItemMinLv;
    private NumericUpDown numericUpDown_Existing_MobMaxLv;
    private NumericUpDown numericUpDown_Existing_MobMinLv;
    private NumericUpDown numericUpDown_New_DropRate;
    private NumericUpDown numericUpDown_New_Durability;
    private NumericUpDown numericUpDown_New_ItemMaxLv;
    private NumericUpDown numericUpDown_New_ItemMinLv;
    private NumericUpDown numericUpDown_New_MobMaxLv;
    private NumericUpDown numericUpDown_New_MobMinLv;
    private ToolStripMenuItem openToolStripMenuItem;
    private PictureBox pictureBox_New_iPicture;
    private RadioButton radioButton_Existing_ExcArmor;
    private RadioButton radioButton_Existing_ExcWeapon;
    private RadioButton radioButton_Existing_ExcWings;
    private RadioButton radioButton_New_ExcArmor;
    private RadioButton radioButton_New_ExcWeapon;
    private RadioButton radioButton_New_ExcWings;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private Structures strc = new Structures();

    public Form_DropManager() => this.InitializeComponent();

    private void button_Existing_RemoveSelected_Click(object sender, EventArgs e)
    {
      if (this.listBox_DropItems.SelectedIndex == -1)
        return;
      this.Items.Remove((Structures.IGCDropManagerFile) this.listBox_DropItems.SelectedItem);
    }

    private void button_Existing_UpdateSelected_Click(object sender, EventArgs e)
    {
      if (this.listBox_DropItems.SelectedIndex == -1)
        return;
      Structures.IGCDropManagerFile igcDropManagerFile = new Structures.IGCDropManagerFile();
      Structures.IGCDropManagerFile selectedItem = (Structures.IGCDropManagerFile) this.listBox_DropItems.SelectedItem with
      {
        Ancient = this.comboBox_Existing_Ancient.SelectedValue.ToString(),
        DropRate = Convert.ToUInt32(this.numericUpDown_Existing_DropRate.Value * 100M).ToString(),
        Durability = this.numericUpDown_Existing_Durability.Value.ToString(),
        Exc = this.checkBox_Existing_RandomExc.Checked ? "-1" : this.GetExcVal(this.checkBox_Existing_ExcOpt1, this.checkBox_Existing_ExcOpt2, this.checkBox_Existing_ExcOpt3, this.checkBox_Existing_ExcOpt4, this.checkBox_Existing_ExcOpt5, this.checkBox_Existing_ExcOpt6),
        Luck = Convert.ToInt16(this.checkBox_Existing_Luck.Checked).ToString(),
        MapID = this.comboBox_Existing_Map.SelectedValue.ToString(),
        MaxLvl = this.numericUpDown_Existing_ItemMaxLv.Value.ToString(),
        MaxMobLvl = this.numericUpDown_Existing_MobMaxLv.Value.ToString(),
        MinLvl = this.numericUpDown_Existing_ItemMinLv.Value.ToString(),
        MinMobLvl = this.numericUpDown_Existing_MobMinLv.Value.ToString(),
        MobID = this.comboBox_Existing_Mob.SelectedValue.ToString(),
        Opt = this.comboBox_Existing_Opt.SelectedValue.ToString(),
        Skill = Convert.ToInt16(this.checkBox_Existing_Skill.Checked).ToString()
      };
      this.Items[this.Items.IndexOf((Structures.IGCDropManagerFile) this.listBox_DropItems.SelectedItem)] = selectedItem;
    }

    private void button_New_Add_Click(object sender, EventArgs e)
    {
      if (this.listBox_New_iGroup.SelectedIndex == -1 || this.listBox_New_iIndex.SelectedIndex == -1)
        return;
      Structures.IGCDropManagerFile igcDropManagerFile = new Structures.IGCDropManagerFile()
      {
        Ancient = this.comboBox_New_Ancient.SelectedValue.ToString(),
        DropRate = Convert.ToUInt32(this.numericUpDown_New_DropRate.Value * 100M).ToString(),
        Durability = this.numericUpDown_New_Durability.Value.ToString(),
        Exc = this.checkBox_New_RandomExc.Checked ? "-1" : this.GetExcVal(this.checkBox_New_ExcOpt1, this.checkBox_New_ExcOpt2, this.checkBox_New_ExcOpt3, this.checkBox_New_ExcOpt4, this.checkBox_New_ExcOpt5, this.checkBox_New_ExcOpt6),
        Luck = Convert.ToInt16(this.checkBox_New_Luck.Checked).ToString(),
        MapID = this.comboBox_New_Map.SelectedValue.ToString(),
        MaxLvl = this.numericUpDown_New_ItemMaxLv.Value.ToString(),
        MaxMobLvl = this.numericUpDown_New_MobMaxLv.Value.ToString(),
        MinLvl = this.numericUpDown_New_ItemMinLv.Value.ToString(),
        MinMobLvl = this.numericUpDown_New_MobMinLv.Value.ToString(),
        MobID = this.comboBox_New_Mob.SelectedValue.ToString(),
        Opt = this.comboBox_New_Opt.SelectedValue.ToString(),
        Skill = Convert.ToInt16(this.checkBox_New_Skill.Checked).ToString(),
        iGroup = this.listBox_New_iGroup.SelectedValue.ToString(),
        iIndex = this.listBox_New_iIndex.SelectedValue.ToString()
      };
      short int16 = Convert.ToInt16(igcDropManagerFile.iGroup);
      igcDropManagerFile.Name = this.GetItemName[(int) int16, (int) Convert.ToInt16(igcDropManagerFile.iIndex)];
      this.Items.Add(igcDropManagerFile);
      this.listBox_DropItems.SelectedIndex = this.Items.Count - 1;
    }

    private void comboBox_VerifyValidItem(object sender, EventArgs e)
    {
      ComboBox comboBox = (ComboBox) sender;
      if (comboBox.SelectedItem != null)
        return;
      comboBox.SelectedIndex = 0;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void Form_DropManager_FormClosed(object sender, FormClosedEventArgs e) => Application.OpenForms["Form1"].WindowState = FormWindowState.Normal;

    private void Form_DropManager_Load(object sender, EventArgs e)
    {
      int num = ((Form1) Application.OpenForms[0]).isEx700ItemList ? 1 : 0;
      string[,] ItemSize = (string[,]) null;
      if (num == 1)
        this.strc.ReadItemList("Data\\ItemListSettings_ex700.ini", true, ref this.L_Groups, ref this.L_Swords, ref this.L_Axes, ref this.L_MacesScepters, ref this.L_Spears, ref this.L_BowsCrossBows, ref this.L_Staffs, ref this.L_Shields, ref this.L_Helms, ref this.L_Armors, ref this.L_Pants, ref this.L_Gloves, ref this.L_Boots, ref this.L_WingsSkillsSeedsOthers, ref this.L_Others1, ref this.L_Others2, ref this.L_Scrolls, ref this.GetItemName, ref ItemSize);
      else
        this.strc.ReadItemList("Data\\ItemListSettings.ini", false, ref this.L_Groups, ref this.L_Swords, ref this.L_Axes, ref this.L_MacesScepters, ref this.L_Spears, ref this.L_BowsCrossBows, ref this.L_Staffs, ref this.L_Shields, ref this.L_Helms, ref this.L_Armors, ref this.L_Pants, ref this.L_Gloves, ref this.L_Boots, ref this.L_WingsSkillsSeedsOthers, ref this.L_Others1, ref this.L_Others2, ref this.L_Scrolls, ref this.GetItemName, ref ItemSize);
      this.strc.Setc_OptionData(ref this.c_OptionDatas_Existing);
      this.c_OptionDatas_New = new List<Structures.c_OptionData>((IEnumerable<Structures.c_OptionData>) this.c_OptionDatas_Existing);
      this.comboBox_Existing_Opt.DataSource = (object) this.c_OptionDatas_Existing;
      this.comboBox_Existing_Opt.DisplayMember = "Name";
      this.comboBox_Existing_Opt.ValueMember = "ID";
      this.comboBox_New_Opt.DataSource = (object) this.c_OptionDatas_New;
      this.comboBox_New_Opt.DisplayMember = "Name";
      this.comboBox_New_Opt.ValueMember = "ID";
      this.Setc_AncientData(ref this.c_AncientDatas_Existing);
      this.c_AncientDatas_New = new BindingList<Structures.c_AncientData>((IList<Structures.c_AncientData>) this.c_AncientDatas_Existing);
      this.comboBox_New_Ancient.DataSource = (object) this.c_AncientDatas_New;
      this.comboBox_New_Ancient.ValueMember = "ID";
      this.comboBox_New_Ancient.DisplayMember = "Name";
      this.comboBox_Existing_Ancient.DataSource = (object) this.c_AncientDatas_Existing;
      this.comboBox_Existing_Ancient.ValueMember = "ID";
      this.comboBox_Existing_Ancient.DisplayMember = "Name";
      this.listBox_DropItems.DataSource = (object) this.Items;
      this.listBox_DropItems.DisplayMember = "Name";
      this.listBox_DropItems.ValueMember = "Name";
      Structures.Map map = new Structures.Map()
      {
        MapCode = -1,
        MapName = "[All Maps]"
      };
      this.mMapList_Existing.Add(map);
      this.mMapList_New.Add(map);
      this.strc.initMapList(ref this.comboBox_Existing_Map, ref this.mMapList_Existing);
      this.strc.initMapList(ref this.comboBox_New_Map, ref this.mMapList_New);
      Structures.Monster monster = new Structures.Monster()
      {
        ID = -1,
        Name = "[All Mobs]"
      };
      this.Monster_Existing.Add(monster);
      this.Monster_New.Add(monster);
      this.ReadMonsterFile("Data\\MSB\\Monster.txt");
      this.comboBox_Existing_Ancient.SelectedIndex = 0;
      this.comboBox_Existing_Opt.SelectedIndex = 0;
      this.radioButton_Existing_ExcWeapon.Checked = true;
      this.comboBox_New_Ancient.SelectedIndex = 0;
      this.comboBox_New_Opt.SelectedIndex = 0;
      this.radioButton_New_ExcWeapon.Checked = true;
      this.listBox_New_iGroup.DisplayMember = "GroupName";
      this.listBox_New_iGroup.ValueMember = "Group";
      this.listBox_New_iGroup.DataSource = (object) this.L_Groups;
      Application.OpenForms["Form1"].WindowState = FormWindowState.Minimized;
      this.WindowState = FormWindowState.Normal;
      this.TopMost = true;
      this.TopMost = false;
      this.BringToFront();
      this.Focus();
    }

    private string GetExcVal(
      CheckBox cb1,
      CheckBox cb2,
      CheckBox cb3,
      CheckBox cb4,
      CheckBox cb5,
      CheckBox cb6)
    {
      int num1 = 0;
      int num2 = cb1.Checked ? num1 + 1 : num1;
      int num3 = cb2.Checked ? num2 + 2 : num2;
      int num4 = cb3.Checked ? num3 + 4 : num3;
      int num5 = cb4.Checked ? num4 + 8 : num4;
      int num6 = cb5.Checked ? num5 + 16 : num5;
      return (cb6.Checked ? num6 + 32 : num6).ToString();
    }

    private string[] GetTrimmedSplitString(string line)
    {
      if (line.Contains<char>('"'))
      {
        string[] strArray = line.Split('"');
        string str1 = strArray[0];
        string str2 = strArray[1];
        string str3 = strArray[2];
        line = str1 + "\"" + str2.Replace(" ", "$") + "\"" + str3;
      }
      string[] strArray1 = line.Replace(" ", "\t").Split('\t');
      List<string> stringList = new List<string>();
      for (int index = 0; index < strArray1.Length; ++index)
      {
        if (strArray1[index].Length != 0)
          stringList.Add(strArray1[index]);
      }
      if (stringList.Count == 0)
        return (string[]) null;
      string[] trimmedSplitString = new string[stringList.Count];
      for (int index = 0; index < stringList.Count; ++index)
        trimmedSplitString[index] = stringList[index];
      return trimmedSplitString;
    }

    private void InitializeComponent()
    {
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.newToolStripMenuItem = new ToolStripMenuItem();
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new ToolStripMenuItem();
      this.groupBox1 = new GroupBox();
      this.pictureBox_New_iPicture = new PictureBox();
      this.groupBox7 = new GroupBox();
      this.label17 = new Label();
      this.numericUpDown_New_MobMaxLv = new NumericUpDown();
      this.label18 = new Label();
      this.label19 = new Label();
      this.numericUpDown_New_MobMinLv = new NumericUpDown();
      this.comboBox_New_Map = new ComboBox();
      this.comboBox_New_Mob = new ComboBox();
      this.label20 = new Label();
      this.numericUpDown_New_DropRate = new NumericUpDown();
      this.groupBox5 = new GroupBox();
      this.label12 = new Label();
      this.label13 = new Label();
      this.numericUpDown_New_ItemMinLv = new NumericUpDown();
      this.numericUpDown_New_ItemMaxLv = new NumericUpDown();
      this.checkBox_New_Skill = new CheckBox();
      this.numericUpDown_New_Durability = new NumericUpDown();
      this.checkBox_New_Luck = new CheckBox();
      this.label14 = new Label();
      this.label15 = new Label();
      this.groupBox6 = new GroupBox();
      this.checkBox_New_RandomExc = new CheckBox();
      this.radioButton_New_ExcWings = new RadioButton();
      this.radioButton_New_ExcArmor = new RadioButton();
      this.radioButton_New_ExcWeapon = new RadioButton();
      this.checkBox_New_ExcOpt6 = new CheckBox();
      this.checkBox_New_ExcOpt5 = new CheckBox();
      this.checkBox_New_ExcOpt4 = new CheckBox();
      this.checkBox_New_ExcOpt3 = new CheckBox();
      this.checkBox_New_ExcOpt2 = new CheckBox();
      this.checkBox_New_ExcOpt1 = new CheckBox();
      this.comboBox_New_Opt = new ComboBox();
      this.comboBox_New_Ancient = new ComboBox();
      this.label16 = new Label();
      this.label21 = new Label();
      this.listBox_New_iIndex = new ListBox();
      this.label22 = new Label();
      this.listBox_New_iGroup = new ListBox();
      this.groupBox2 = new GroupBox();
      this.button_Existing_RemoveSelected = new Button();
      this.button_Existing_UpdateSelected = new Button();
      this.groupBox4 = new GroupBox();
      this.label9 = new Label();
      this.numericUpDown_Existing_MobMaxLv = new NumericUpDown();
      this.label8 = new Label();
      this.label6 = new Label();
      this.numericUpDown_Existing_MobMinLv = new NumericUpDown();
      this.comboBox_Existing_Map = new ComboBox();
      this.comboBox_Existing_Mob = new ComboBox();
      this.label7 = new Label();
      this.numericUpDown_Existing_DropRate = new NumericUpDown();
      this.label10 = new Label();
      this.groupBox3 = new GroupBox();
      this.label1 = new Label();
      this.label2 = new Label();
      this.numericUpDown_Existing_ItemMinLv = new NumericUpDown();
      this.numericUpDown_Existing_ItemMaxLv = new NumericUpDown();
      this.checkBox_Existing_Skill = new CheckBox();
      this.numericUpDown_Existing_Durability = new NumericUpDown();
      this.checkBox_Existing_Luck = new CheckBox();
      this.label5 = new Label();
      this.label3 = new Label();
      this.groupBox_NewItem_ExcOpt = new GroupBox();
      this.checkBox_Existing_RandomExc = new CheckBox();
      this.radioButton_Existing_ExcWings = new RadioButton();
      this.radioButton_Existing_ExcArmor = new RadioButton();
      this.radioButton_Existing_ExcWeapon = new RadioButton();
      this.checkBox_Existing_ExcOpt6 = new CheckBox();
      this.checkBox_Existing_ExcOpt5 = new CheckBox();
      this.checkBox_Existing_ExcOpt4 = new CheckBox();
      this.checkBox_Existing_ExcOpt3 = new CheckBox();
      this.checkBox_Existing_ExcOpt2 = new CheckBox();
      this.checkBox_Existing_ExcOpt1 = new CheckBox();
      this.comboBox_Existing_Opt = new ComboBox();
      this.comboBox_Existing_Ancient = new ComboBox();
      this.label4 = new Label();
      this.listBox_DropItems = new ListBox();
      this.label11 = new Label();
      this.button_New_Add = new Button();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox_New_iPicture).BeginInit();
      this.groupBox7.SuspendLayout();
      this.numericUpDown_New_MobMaxLv.BeginInit();
      this.numericUpDown_New_MobMinLv.BeginInit();
      this.numericUpDown_New_DropRate.BeginInit();
      this.groupBox5.SuspendLayout();
      this.numericUpDown_New_ItemMinLv.BeginInit();
      this.numericUpDown_New_ItemMaxLv.BeginInit();
      this.numericUpDown_New_Durability.BeginInit();
      this.groupBox6.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.numericUpDown_Existing_MobMaxLv.BeginInit();
      this.numericUpDown_Existing_MobMinLv.BeginInit();
      this.numericUpDown_Existing_DropRate.BeginInit();
      this.groupBox3.SuspendLayout();
      this.numericUpDown_Existing_ItemMinLv.BeginInit();
      this.numericUpDown_Existing_ItemMaxLv.BeginInit();
      this.numericUpDown_Existing_Durability.BeginInit();
      this.groupBox_NewItem_ExcOpt.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.fileToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(845, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.newToolStripMenuItem,
        (ToolStripItem) this.openToolStripMenuItem,
        (ToolStripItem) this.saveAsToolStripMenuItem
      });
      this.fileToolStripMenuItem.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new Size(122, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new EventHandler(this.newToolStripMenuItem_Click);
      this.openToolStripMenuItem.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new Size(122, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);
      this.saveAsToolStripMenuItem.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new Size(122, 22);
      this.saveAsToolStripMenuItem.Text = "Save (As)";
      this.saveAsToolStripMenuItem.Click += new EventHandler(this.saveAsToolStripMenuItem_Click);
      this.groupBox1.Controls.Add((Control) this.pictureBox_New_iPicture);
      this.groupBox1.Controls.Add((Control) this.groupBox7);
      this.groupBox1.Controls.Add((Control) this.numericUpDown_New_DropRate);
      this.groupBox1.Controls.Add((Control) this.groupBox5);
      this.groupBox1.Controls.Add((Control) this.label21);
      this.groupBox1.Controls.Add((Control) this.listBox_New_iIndex);
      this.groupBox1.Controls.Add((Control) this.label22);
      this.groupBox1.Controls.Add((Control) this.listBox_New_iGroup);
      this.groupBox1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox1.Location = new Point(12, 234);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(819, 210);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Add new Entry";
      this.pictureBox_New_iPicture.BackColor = Color.Black;
      this.pictureBox_New_iPicture.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_New_iPicture.Location = new Point(6, 126);
      this.pictureBox_New_iPicture.Name = "pictureBox_New_iPicture";
      this.pictureBox_New_iPicture.Size = new Size(128, 78);
      this.pictureBox_New_iPicture.TabIndex = 34;
      this.pictureBox_New_iPicture.TabStop = false;
      this.groupBox7.Controls.Add((Control) this.label17);
      this.groupBox7.Controls.Add((Control) this.numericUpDown_New_MobMaxLv);
      this.groupBox7.Controls.Add((Control) this.label18);
      this.groupBox7.Controls.Add((Control) this.label19);
      this.groupBox7.Controls.Add((Control) this.numericUpDown_New_MobMinLv);
      this.groupBox7.Controls.Add((Control) this.comboBox_New_Map);
      this.groupBox7.Controls.Add((Control) this.comboBox_New_Mob);
      this.groupBox7.Controls.Add((Control) this.label20);
      this.groupBox7.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox7.Location = new Point(654, 19);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new Size(159, 122);
      this.groupBox7.TabIndex = 30;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Drop Options";
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.Location = new Point(26, 97);
      this.label17.Name = "label17";
      this.label17.Size = new Size(62, 15);
      this.label17.TabIndex = 26;
      this.label17.Text = "Max Level:";
      this.numericUpDown_New_MobMaxLv.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_New_MobMaxLv.Location = new Point(93, 95);
      this.numericUpDown_New_MobMaxLv.Maximum = new Decimal(new int[4]
      {
        150,
        0,
        0,
        0
      });
      this.numericUpDown_New_MobMaxLv.Name = "numericUpDown_New_MobMaxLv";
      this.numericUpDown_New_MobMaxLv.Size = new Size(45, 23);
      this.numericUpDown_New_MobMaxLv.TabIndex = 27;
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label18.Location = new Point(26, 71);
      this.label18.Name = "label18";
      this.label18.Size = new Size(61, 15);
      this.label18.TabIndex = 22;
      this.label18.Text = "Min Level:";
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label19.Location = new Point(6, 21);
      this.label19.Name = "label19";
      this.label19.Size = new Size(34, 15);
      this.label19.TabIndex = 22;
      this.label19.Text = "Map:";
      this.numericUpDown_New_MobMinLv.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_New_MobMinLv.Location = new Point(93, 68);
      this.numericUpDown_New_MobMinLv.Name = "numericUpDown_New_MobMinLv";
      this.numericUpDown_New_MobMinLv.Size = new Size(45, 23);
      this.numericUpDown_New_MobMinLv.TabIndex = 23;
      this.comboBox_New_Map.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_New_Map.FormattingEnabled = true;
      this.comboBox_New_Map.Location = new Point(46, 17);
      this.comboBox_New_Map.Name = "comboBox_New_Map";
      this.comboBox_New_Map.Size = new Size(107, 23);
      this.comboBox_New_Map.TabIndex = 23;
      this.comboBox_New_Map.Leave += new EventHandler(this.comboBox_VerifyValidItem);
      this.comboBox_New_Mob.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_New_Mob.FormattingEnabled = true;
      this.comboBox_New_Mob.Location = new Point(46, 42);
      this.comboBox_New_Mob.Name = "comboBox_New_Mob";
      this.comboBox_New_Mob.Size = new Size(107, 23);
      this.comboBox_New_Mob.TabIndex = 25;
      this.comboBox_New_Mob.Leave += new EventHandler(this.comboBox_VerifyValidItem);
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.Location = new Point(6, 46);
      this.label20.Name = "label20";
      this.label20.Size = new Size(35, 15);
      this.label20.TabIndex = 24;
      this.label20.Text = "Mob:";
      this.numericUpDown_New_DropRate.DecimalPlaces = 2;
      this.numericUpDown_New_DropRate.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_New_DropRate.Location = new Point(727, 147);
      this.numericUpDown_New_DropRate.Name = "numericUpDown_New_DropRate";
      this.numericUpDown_New_DropRate.Size = new Size(50, 23);
      this.numericUpDown_New_DropRate.TabIndex = 31;
      this.numericUpDown_New_DropRate.UpDownAlign = LeftRightAlignment.Left;
      this.groupBox5.Controls.Add((Control) this.label12);
      this.groupBox5.Controls.Add((Control) this.label13);
      this.groupBox5.Controls.Add((Control) this.numericUpDown_New_ItemMinLv);
      this.groupBox5.Controls.Add((Control) this.numericUpDown_New_ItemMaxLv);
      this.groupBox5.Controls.Add((Control) this.checkBox_New_Skill);
      this.groupBox5.Controls.Add((Control) this.numericUpDown_New_Durability);
      this.groupBox5.Controls.Add((Control) this.checkBox_New_Luck);
      this.groupBox5.Controls.Add((Control) this.label14);
      this.groupBox5.Controls.Add((Control) this.label15);
      this.groupBox5.Controls.Add((Control) this.groupBox6);
      this.groupBox5.Controls.Add((Control) this.comboBox_New_Opt);
      this.groupBox5.Controls.Add((Control) this.comboBox_New_Ancient);
      this.groupBox5.Controls.Add((Control) this.label16);
      this.groupBox5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox5.Location = new Point(303, 18);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(345, 180);
      this.groupBox5.TabIndex = 27;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Item Options";
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(6, 18);
      this.label12.Name = "label12";
      this.label12.Size = new Size(61, 15);
      this.label12.TabIndex = 1;
      this.label12.Text = "Min Level:";
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.Location = new Point(6, 42);
      this.label13.Name = "label13";
      this.label13.Size = new Size(62, 15);
      this.label13.TabIndex = 2;
      this.label13.Text = "Max Level:";
      this.numericUpDown_New_ItemMinLv.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_New_ItemMinLv.Location = new Point(71, 17);
      this.numericUpDown_New_ItemMinLv.Name = "numericUpDown_New_ItemMinLv";
      this.numericUpDown_New_ItemMinLv.Size = new Size(58, 23);
      this.numericUpDown_New_ItemMinLv.TabIndex = 3;
      this.numericUpDown_New_ItemMaxLv.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_New_ItemMaxLv.Location = new Point(71, 41);
      this.numericUpDown_New_ItemMaxLv.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown_New_ItemMaxLv.Name = "numericUpDown_New_ItemMaxLv";
      this.numericUpDown_New_ItemMaxLv.Size = new Size(58, 23);
      this.numericUpDown_New_ItemMaxLv.TabIndex = 4;
      this.checkBox_New_Skill.AutoSize = true;
      this.checkBox_New_Skill.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_New_Skill.Location = new Point(17, 142);
      this.checkBox_New_Skill.Name = "checkBox_New_Skill";
      this.checkBox_New_Skill.Size = new Size(47, 19);
      this.checkBox_New_Skill.TabIndex = 5;
      this.checkBox_New_Skill.Text = "Skill";
      this.checkBox_New_Skill.UseVisualStyleBackColor = true;
      this.numericUpDown_New_Durability.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_New_Durability.Location = new Point(73, 114);
      this.numericUpDown_New_Durability.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_New_Durability.Name = "numericUpDown_New_Durability";
      this.numericUpDown_New_Durability.Size = new Size(56, 23);
      this.numericUpDown_New_Durability.TabIndex = 21;
      this.numericUpDown_New_Durability.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.checkBox_New_Luck.AutoSize = true;
      this.checkBox_New_Luck.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_New_Luck.Location = new Point(76, 142);
      this.checkBox_New_Luck.Name = "checkBox_New_Luck";
      this.checkBox_New_Luck.Size = new Size(51, 19);
      this.checkBox_New_Luck.TabIndex = 6;
      this.checkBox_New_Luck.Text = "Luck";
      this.checkBox_New_Luck.UseVisualStyleBackColor = true;
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.Location = new Point(6, 117);
      this.label14.Name = "label14";
      this.label14.Size = new Size(61, 15);
      this.label14.TabIndex = 20;
      this.label14.Text = "Durability:";
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label15.Location = new Point(6, 67);
      this.label15.Name = "label15";
      this.label15.Size = new Size(47, 15);
      this.label15.TabIndex = 7;
      this.label15.Text = "Option:";
      this.groupBox6.BackColor = Color.Transparent;
      this.groupBox6.Controls.Add((Control) this.checkBox_New_RandomExc);
      this.groupBox6.Controls.Add((Control) this.radioButton_New_ExcWings);
      this.groupBox6.Controls.Add((Control) this.radioButton_New_ExcArmor);
      this.groupBox6.Controls.Add((Control) this.radioButton_New_ExcWeapon);
      this.groupBox6.Controls.Add((Control) this.checkBox_New_ExcOpt6);
      this.groupBox6.Controls.Add((Control) this.checkBox_New_ExcOpt5);
      this.groupBox6.Controls.Add((Control) this.checkBox_New_ExcOpt4);
      this.groupBox6.Controls.Add((Control) this.checkBox_New_ExcOpt3);
      this.groupBox6.Controls.Add((Control) this.checkBox_New_ExcOpt2);
      this.groupBox6.Controls.Add((Control) this.checkBox_New_ExcOpt1);
      this.groupBox6.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox6.ForeColor = SystemColors.ControlText;
      this.groupBox6.Location = new Point(135, 19);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(204, 151);
      this.groupBox6.TabIndex = 19;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Excellent Options     ";
      this.checkBox_New_RandomExc.AutoSize = true;
      this.checkBox_New_RandomExc.BackColor = SystemColors.Control;
      this.checkBox_New_RandomExc.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_New_RandomExc.Location = new Point(107, 0);
      this.checkBox_New_RandomExc.Name = "checkBox_New_RandomExc";
      this.checkBox_New_RandomExc.Size = new Size(71, 19);
      this.checkBox_New_RandomExc.TabIndex = 21;
      this.checkBox_New_RandomExc.Text = "Random";
      this.checkBox_New_RandomExc.UseVisualStyleBackColor = false;
      this.radioButton_New_ExcWings.AutoSize = true;
      this.radioButton_New_ExcWings.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radioButton_New_ExcWings.Location = new Point(136, 18);
      this.radioButton_New_ExcWings.Name = "radioButton_New_ExcWings";
      this.radioButton_New_ExcWings.Size = new Size(58, 19);
      this.radioButton_New_ExcWings.TabIndex = 14;
      this.radioButton_New_ExcWings.Text = "Wings";
      this.radioButton_New_ExcWings.UseVisualStyleBackColor = true;
      this.radioButton_New_ExcWings.CheckedChanged += new EventHandler(this.radioButton_New_ExcWings_CheckedChanged);
      this.radioButton_New_ExcArmor.AutoSize = true;
      this.radioButton_New_ExcArmor.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radioButton_New_ExcArmor.Location = new Point(78, 18);
      this.radioButton_New_ExcArmor.Name = "radioButton_New_ExcArmor";
      this.radioButton_New_ExcArmor.Size = new Size(59, 19);
      this.radioButton_New_ExcArmor.TabIndex = 13;
      this.radioButton_New_ExcArmor.Text = "Armor";
      this.radioButton_New_ExcArmor.UseVisualStyleBackColor = true;
      this.radioButton_New_ExcArmor.CheckedChanged += new EventHandler(this.radioButton_New_ExcArmor_CheckedChanged);
      this.radioButton_New_ExcWeapon.AutoSize = true;
      this.radioButton_New_ExcWeapon.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radioButton_New_ExcWeapon.Location = new Point(6, 18);
      this.radioButton_New_ExcWeapon.Name = "radioButton_New_ExcWeapon";
      this.radioButton_New_ExcWeapon.Size = new Size(69, 19);
      this.radioButton_New_ExcWeapon.TabIndex = 12;
      this.radioButton_New_ExcWeapon.Text = "Weapon";
      this.radioButton_New_ExcWeapon.UseVisualStyleBackColor = true;
      this.radioButton_New_ExcWeapon.CheckedChanged += new EventHandler(this.radioButton_New_ExcWeapon_CheckedChanged);
      this.checkBox_New_ExcOpt6.AutoSize = true;
      this.checkBox_New_ExcOpt6.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_New_ExcOpt6.ForeColor = SystemColors.ControlText;
      this.checkBox_New_ExcOpt6.Location = new Point(6, 133);
      this.checkBox_New_ExcOpt6.Name = "checkBox_New_ExcOpt6";
      this.checkBox_New_ExcOpt6.Size = new Size(82, 19);
      this.checkBox_New_ExcOpt6.TabIndex = 20;
      this.checkBox_New_ExcOpt6.Text = "checkBox6";
      this.checkBox_New_ExcOpt6.UseVisualStyleBackColor = true;
      this.checkBox_New_ExcOpt5.AutoSize = true;
      this.checkBox_New_ExcOpt5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_New_ExcOpt5.ForeColor = SystemColors.ControlText;
      this.checkBox_New_ExcOpt5.Location = new Point(6, 115);
      this.checkBox_New_ExcOpt5.Name = "checkBox_New_ExcOpt5";
      this.checkBox_New_ExcOpt5.Size = new Size(82, 19);
      this.checkBox_New_ExcOpt5.TabIndex = 19;
      this.checkBox_New_ExcOpt5.Text = "checkBox5";
      this.checkBox_New_ExcOpt5.UseVisualStyleBackColor = true;
      this.checkBox_New_ExcOpt4.AutoSize = true;
      this.checkBox_New_ExcOpt4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_New_ExcOpt4.ForeColor = SystemColors.ControlText;
      this.checkBox_New_ExcOpt4.Location = new Point(6, 97);
      this.checkBox_New_ExcOpt4.Name = "checkBox_New_ExcOpt4";
      this.checkBox_New_ExcOpt4.Size = new Size(82, 19);
      this.checkBox_New_ExcOpt4.TabIndex = 18;
      this.checkBox_New_ExcOpt4.Text = "checkBox4";
      this.checkBox_New_ExcOpt4.UseVisualStyleBackColor = true;
      this.checkBox_New_ExcOpt3.AutoSize = true;
      this.checkBox_New_ExcOpt3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_New_ExcOpt3.ForeColor = SystemColors.ControlText;
      this.checkBox_New_ExcOpt3.Location = new Point(6, 78);
      this.checkBox_New_ExcOpt3.Name = "checkBox_New_ExcOpt3";
      this.checkBox_New_ExcOpt3.Size = new Size(82, 19);
      this.checkBox_New_ExcOpt3.TabIndex = 17;
      this.checkBox_New_ExcOpt3.Text = "checkBox3";
      this.checkBox_New_ExcOpt3.UseVisualStyleBackColor = true;
      this.checkBox_New_ExcOpt2.AutoSize = true;
      this.checkBox_New_ExcOpt2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_New_ExcOpt2.ForeColor = SystemColors.ControlText;
      this.checkBox_New_ExcOpt2.Location = new Point(6, 60);
      this.checkBox_New_ExcOpt2.Name = "checkBox_New_ExcOpt2";
      this.checkBox_New_ExcOpt2.Size = new Size(82, 19);
      this.checkBox_New_ExcOpt2.TabIndex = 16;
      this.checkBox_New_ExcOpt2.Text = "checkBox2";
      this.checkBox_New_ExcOpt2.UseVisualStyleBackColor = true;
      this.checkBox_New_ExcOpt1.AutoSize = true;
      this.checkBox_New_ExcOpt1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_New_ExcOpt1.ForeColor = SystemColors.ControlText;
      this.checkBox_New_ExcOpt1.Location = new Point(6, 42);
      this.checkBox_New_ExcOpt1.Name = "checkBox_New_ExcOpt1";
      this.checkBox_New_ExcOpt1.Size = new Size(82, 19);
      this.checkBox_New_ExcOpt1.TabIndex = 15;
      this.checkBox_New_ExcOpt1.Text = "checkBox1";
      this.checkBox_New_ExcOpt1.UseVisualStyleBackColor = true;
      this.comboBox_New_Opt.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_New_Opt.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_New_Opt.FormattingEnabled = true;
      this.comboBox_New_Opt.Location = new Point(64, 65);
      this.comboBox_New_Opt.Name = "comboBox_New_Opt";
      this.comboBox_New_Opt.Size = new Size(65, 23);
      this.comboBox_New_Opt.TabIndex = 8;
      this.comboBox_New_Ancient.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_New_Ancient.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_New_Ancient.FormattingEnabled = true;
      this.comboBox_New_Ancient.Location = new Point(64, 90);
      this.comboBox_New_Ancient.Name = "comboBox_New_Ancient";
      this.comboBox_New_Ancient.Size = new Size(65, 23);
      this.comboBox_New_Ancient.TabIndex = 10;
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label16.Location = new Point(6, 92);
      this.label16.Name = "label16";
      this.label16.Size = new Size(51, 15);
      this.label16.TabIndex = 9;
      this.label16.Text = "Ancient:";
      this.label21.AutoSize = true;
      this.label21.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label21.Location = new Point(659, 150);
      this.label21.Name = "label21";
      this.label21.Size = new Size(62, 15);
      this.label21.TabIndex = 32;
      this.label21.Text = "Drop Rate:";
      this.listBox_New_iIndex.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_New_iIndex.FormattingEnabled = true;
      this.listBox_New_iIndex.ItemHeight = 15;
      this.listBox_New_iIndex.Location = new Point(140, 20);
      this.listBox_New_iIndex.Name = "listBox_New_iIndex";
      this.listBox_New_iIndex.Size = new Size(156, 184);
      this.listBox_New_iIndex.TabIndex = 32;
      this.listBox_New_iIndex.SelectedIndexChanged += new EventHandler(this.listBox_New_iIndex_SelectedIndexChanged);
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label22.Location = new Point(775, 148);
      this.label22.Name = "label22";
      this.label22.Size = new Size(21, 20);
      this.label22.TabIndex = 33;
      this.label22.Text = "%";
      this.listBox_New_iGroup.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_New_iGroup.FormattingEnabled = true;
      this.listBox_New_iGroup.ItemHeight = 15;
      this.listBox_New_iGroup.Location = new Point(6, 20);
      this.listBox_New_iGroup.Name = "listBox_New_iGroup";
      this.listBox_New_iGroup.Size = new Size(128, 94);
      this.listBox_New_iGroup.TabIndex = 31;
      this.listBox_New_iGroup.SelectedIndexChanged += new EventHandler(this.listBox_New_iGroup_SelectedIndexChanged);
      this.groupBox2.Controls.Add((Control) this.button_Existing_RemoveSelected);
      this.groupBox2.Controls.Add((Control) this.button_Existing_UpdateSelected);
      this.groupBox2.Controls.Add((Control) this.groupBox4);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Existing_DropRate);
      this.groupBox2.Controls.Add((Control) this.label10);
      this.groupBox2.Controls.Add((Control) this.groupBox3);
      this.groupBox2.Controls.Add((Control) this.listBox_DropItems);
      this.groupBox2.Controls.Add((Control) this.label11);
      this.groupBox2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox2.Location = new Point(12, 35);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(819, 194);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Existing Entries";
      this.button_Existing_RemoveSelected.Location = new Point(6, 163);
      this.button_Existing_RemoveSelected.Name = "button_Existing_RemoveSelected";
      this.button_Existing_RemoveSelected.Size = new Size(203, 21);
      this.button_Existing_RemoveSelected.TabIndex = 31;
      this.button_Existing_RemoveSelected.Text = "Remove Selected";
      this.button_Existing_RemoveSelected.UseVisualStyleBackColor = true;
      this.button_Existing_RemoveSelected.Click += new EventHandler(this.button_Existing_RemoveSelected_Click);
      this.button_Existing_UpdateSelected.Location = new Point(566, 149);
      this.button_Existing_UpdateSelected.Name = "button_Existing_UpdateSelected";
      this.button_Existing_UpdateSelected.Size = new Size(247, 39);
      this.button_Existing_UpdateSelected.TabIndex = 30;
      this.button_Existing_UpdateSelected.Text = "Update Selected Entry";
      this.button_Existing_UpdateSelected.UseVisualStyleBackColor = true;
      this.button_Existing_UpdateSelected.Click += new EventHandler(this.button_Existing_UpdateSelected_Click);
      this.groupBox4.Controls.Add((Control) this.label9);
      this.groupBox4.Controls.Add((Control) this.numericUpDown_Existing_MobMaxLv);
      this.groupBox4.Controls.Add((Control) this.label8);
      this.groupBox4.Controls.Add((Control) this.label6);
      this.groupBox4.Controls.Add((Control) this.numericUpDown_Existing_MobMinLv);
      this.groupBox4.Controls.Add((Control) this.comboBox_Existing_Map);
      this.groupBox4.Controls.Add((Control) this.comboBox_Existing_Mob);
      this.groupBox4.Controls.Add((Control) this.label7);
      this.groupBox4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox4.Location = new Point(566, 18);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(247, 98);
      this.groupBox4.TabIndex = 27;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Drop Options";
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(125, 71);
      this.label9.Name = "label9";
      this.label9.Size = new Size(62, 15);
      this.label9.TabIndex = 26;
      this.label9.Text = "Max Level:";
      this.numericUpDown_Existing_MobMaxLv.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_Existing_MobMaxLv.Location = new Point(196, 68);
      this.numericUpDown_Existing_MobMaxLv.Maximum = new Decimal(new int[4]
      {
        150,
        0,
        0,
        0
      });
      this.numericUpDown_Existing_MobMaxLv.Name = "numericUpDown_Existing_MobMaxLv";
      this.numericUpDown_Existing_MobMaxLv.Size = new Size(45, 23);
      this.numericUpDown_Existing_MobMaxLv.TabIndex = 27;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(6, 71);
      this.label8.Name = "label8";
      this.label8.Size = new Size(61, 15);
      this.label8.TabIndex = 22;
      this.label8.Text = "Min Level:";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(6, 21);
      this.label6.Name = "label6";
      this.label6.Size = new Size(34, 15);
      this.label6.TabIndex = 22;
      this.label6.Text = "Map:";
      this.numericUpDown_Existing_MobMinLv.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_Existing_MobMinLv.Location = new Point(73, 68);
      this.numericUpDown_Existing_MobMinLv.Name = "numericUpDown_Existing_MobMinLv";
      this.numericUpDown_Existing_MobMinLv.Size = new Size(45, 23);
      this.numericUpDown_Existing_MobMinLv.TabIndex = 23;
      this.comboBox_Existing_Map.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      this.comboBox_Existing_Map.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.comboBox_Existing_Map.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_Existing_Map.FormattingEnabled = true;
      this.comboBox_Existing_Map.Location = new Point(46, 17);
      this.comboBox_Existing_Map.Name = "comboBox_Existing_Map";
      this.comboBox_Existing_Map.Size = new Size(195, 23);
      this.comboBox_Existing_Map.TabIndex = 23;
      this.comboBox_Existing_Map.Leave += new EventHandler(this.comboBox_VerifyValidItem);
      this.comboBox_Existing_Mob.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      this.comboBox_Existing_Mob.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.comboBox_Existing_Mob.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_Existing_Mob.FormattingEnabled = true;
      this.comboBox_Existing_Mob.Location = new Point(46, 42);
      this.comboBox_Existing_Mob.Name = "comboBox_Existing_Mob";
      this.comboBox_Existing_Mob.Size = new Size(195, 23);
      this.comboBox_Existing_Mob.TabIndex = 25;
      this.comboBox_Existing_Mob.Leave += new EventHandler(this.comboBox_VerifyValidItem);
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(6, 46);
      this.label7.Name = "label7";
      this.label7.Size = new Size(35, 15);
      this.label7.TabIndex = 24;
      this.label7.Text = "Mob:";
      this.numericUpDown_Existing_DropRate.DecimalPlaces = 2;
      this.numericUpDown_Existing_DropRate.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_Existing_DropRate.Location = new Point(706, 122);
      this.numericUpDown_Existing_DropRate.Name = "numericUpDown_Existing_DropRate";
      this.numericUpDown_Existing_DropRate.Size = new Size(50, 23);
      this.numericUpDown_Existing_DropRate.TabIndex = 28;
      this.numericUpDown_Existing_DropRate.UpDownAlign = LeftRightAlignment.Left;
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.Location = new Point(611, 126);
      this.label10.Name = "label10";
      this.label10.Size = new Size(89, 15);
      this.label10.TabIndex = 28;
      this.label10.Text = "Item Drop Rate:";
      this.groupBox3.Controls.Add((Control) this.label1);
      this.groupBox3.Controls.Add((Control) this.label2);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_Existing_ItemMinLv);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_Existing_ItemMaxLv);
      this.groupBox3.Controls.Add((Control) this.checkBox_Existing_Skill);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_Existing_Durability);
      this.groupBox3.Controls.Add((Control) this.checkBox_Existing_Luck);
      this.groupBox3.Controls.Add((Control) this.label5);
      this.groupBox3.Controls.Add((Control) this.label3);
      this.groupBox3.Controls.Add((Control) this.groupBox_NewItem_ExcOpt);
      this.groupBox3.Controls.Add((Control) this.comboBox_Existing_Opt);
      this.groupBox3.Controls.Add((Control) this.comboBox_Existing_Ancient);
      this.groupBox3.Controls.Add((Control) this.label4);
      this.groupBox3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox3.Location = new Point(215, 18);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(345, 170);
      this.groupBox3.TabIndex = 26;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Item Options";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(6, 18);
      this.label1.Name = "label1";
      this.label1.Size = new Size(61, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Min Level:";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(6, 42);
      this.label2.Name = "label2";
      this.label2.Size = new Size(62, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "Max Level:";
      this.numericUpDown_Existing_ItemMinLv.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_Existing_ItemMinLv.Location = new Point(71, 17);
      this.numericUpDown_Existing_ItemMinLv.Name = "numericUpDown_Existing_ItemMinLv";
      this.numericUpDown_Existing_ItemMinLv.Size = new Size(58, 23);
      this.numericUpDown_Existing_ItemMinLv.TabIndex = 3;
      this.numericUpDown_Existing_ItemMaxLv.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_Existing_ItemMaxLv.Location = new Point(71, 41);
      this.numericUpDown_Existing_ItemMaxLv.Maximum = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.numericUpDown_Existing_ItemMaxLv.Name = "numericUpDown_Existing_ItemMaxLv";
      this.numericUpDown_Existing_ItemMaxLv.Size = new Size(58, 23);
      this.numericUpDown_Existing_ItemMaxLv.TabIndex = 4;
      this.checkBox_Existing_Skill.AutoSize = true;
      this.checkBox_Existing_Skill.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Existing_Skill.Location = new Point(17, 142);
      this.checkBox_Existing_Skill.Name = "checkBox_Existing_Skill";
      this.checkBox_Existing_Skill.Size = new Size(47, 19);
      this.checkBox_Existing_Skill.TabIndex = 5;
      this.checkBox_Existing_Skill.Text = "Skill";
      this.checkBox_Existing_Skill.UseVisualStyleBackColor = true;
      this.numericUpDown_Existing_Durability.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_Existing_Durability.Location = new Point(73, 114);
      this.numericUpDown_Existing_Durability.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Existing_Durability.Name = "numericUpDown_Existing_Durability";
      this.numericUpDown_Existing_Durability.Size = new Size(56, 23);
      this.numericUpDown_Existing_Durability.TabIndex = 21;
      this.numericUpDown_Existing_Durability.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.checkBox_Existing_Luck.AutoSize = true;
      this.checkBox_Existing_Luck.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Existing_Luck.Location = new Point(76, 142);
      this.checkBox_Existing_Luck.Name = "checkBox_Existing_Luck";
      this.checkBox_Existing_Luck.Size = new Size(51, 19);
      this.checkBox_Existing_Luck.TabIndex = 6;
      this.checkBox_Existing_Luck.Text = "Luck";
      this.checkBox_Existing_Luck.UseVisualStyleBackColor = true;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(6, 117);
      this.label5.Name = "label5";
      this.label5.Size = new Size(61, 15);
      this.label5.TabIndex = 20;
      this.label5.Text = "Durability:";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(6, 67);
      this.label3.Name = "label3";
      this.label3.Size = new Size(47, 15);
      this.label3.TabIndex = 7;
      this.label3.Text = "Option:";
      this.groupBox_NewItem_ExcOpt.BackColor = Color.Transparent;
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_Existing_RandomExc);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.radioButton_Existing_ExcWings);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.radioButton_Existing_ExcArmor);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.radioButton_Existing_ExcWeapon);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_Existing_ExcOpt6);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_Existing_ExcOpt5);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_Existing_ExcOpt4);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_Existing_ExcOpt3);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_Existing_ExcOpt2);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_Existing_ExcOpt1);
      this.groupBox_NewItem_ExcOpt.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_NewItem_ExcOpt.ForeColor = SystemColors.ControlText;
      this.groupBox_NewItem_ExcOpt.Location = new Point(135, 11);
      this.groupBox_NewItem_ExcOpt.Name = "groupBox_NewItem_ExcOpt";
      this.groupBox_NewItem_ExcOpt.Size = new Size(204, 151);
      this.groupBox_NewItem_ExcOpt.TabIndex = 19;
      this.groupBox_NewItem_ExcOpt.TabStop = false;
      this.groupBox_NewItem_ExcOpt.Text = "Excellent Options     ";
      this.checkBox_Existing_RandomExc.AutoSize = true;
      this.checkBox_Existing_RandomExc.BackColor = SystemColors.Control;
      this.checkBox_Existing_RandomExc.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Existing_RandomExc.Location = new Point(107, 0);
      this.checkBox_Existing_RandomExc.Name = "checkBox_Existing_RandomExc";
      this.checkBox_Existing_RandomExc.Size = new Size(71, 19);
      this.checkBox_Existing_RandomExc.TabIndex = 21;
      this.checkBox_Existing_RandomExc.Text = "Random";
      this.checkBox_Existing_RandomExc.UseVisualStyleBackColor = false;
      this.radioButton_Existing_ExcWings.AutoSize = true;
      this.radioButton_Existing_ExcWings.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radioButton_Existing_ExcWings.Location = new Point(136, 18);
      this.radioButton_Existing_ExcWings.Name = "radioButton_Existing_ExcWings";
      this.radioButton_Existing_ExcWings.Size = new Size(58, 19);
      this.radioButton_Existing_ExcWings.TabIndex = 14;
      this.radioButton_Existing_ExcWings.Text = "Wings";
      this.radioButton_Existing_ExcWings.UseVisualStyleBackColor = true;
      this.radioButton_Existing_ExcWings.CheckedChanged += new EventHandler(this.radioButton_Existing_ExcWings_CheckedChanged);
      this.radioButton_Existing_ExcArmor.AutoSize = true;
      this.radioButton_Existing_ExcArmor.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radioButton_Existing_ExcArmor.Location = new Point(78, 18);
      this.radioButton_Existing_ExcArmor.Name = "radioButton_Existing_ExcArmor";
      this.radioButton_Existing_ExcArmor.Size = new Size(59, 19);
      this.radioButton_Existing_ExcArmor.TabIndex = 13;
      this.radioButton_Existing_ExcArmor.Text = "Armor";
      this.radioButton_Existing_ExcArmor.UseVisualStyleBackColor = true;
      this.radioButton_Existing_ExcArmor.CheckedChanged += new EventHandler(this.radioButton_Existing_ExcArmor_CheckedChanged);
      this.radioButton_Existing_ExcWeapon.AutoSize = true;
      this.radioButton_Existing_ExcWeapon.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radioButton_Existing_ExcWeapon.Location = new Point(6, 18);
      this.radioButton_Existing_ExcWeapon.Name = "radioButton_Existing_ExcWeapon";
      this.radioButton_Existing_ExcWeapon.Size = new Size(69, 19);
      this.radioButton_Existing_ExcWeapon.TabIndex = 12;
      this.radioButton_Existing_ExcWeapon.Text = "Weapon";
      this.radioButton_Existing_ExcWeapon.UseVisualStyleBackColor = true;
      this.radioButton_Existing_ExcWeapon.CheckedChanged += new EventHandler(this.radioButton_Existing_ExcWeapon_CheckedChanged);
      this.checkBox_Existing_ExcOpt6.AutoSize = true;
      this.checkBox_Existing_ExcOpt6.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Existing_ExcOpt6.ForeColor = SystemColors.ControlText;
      this.checkBox_Existing_ExcOpt6.Location = new Point(6, 133);
      this.checkBox_Existing_ExcOpt6.Name = "checkBox_Existing_ExcOpt6";
      this.checkBox_Existing_ExcOpt6.Size = new Size(82, 19);
      this.checkBox_Existing_ExcOpt6.TabIndex = 20;
      this.checkBox_Existing_ExcOpt6.Text = "checkBox6";
      this.checkBox_Existing_ExcOpt6.UseVisualStyleBackColor = true;
      this.checkBox_Existing_ExcOpt5.AutoSize = true;
      this.checkBox_Existing_ExcOpt5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Existing_ExcOpt5.ForeColor = SystemColors.ControlText;
      this.checkBox_Existing_ExcOpt5.Location = new Point(6, 115);
      this.checkBox_Existing_ExcOpt5.Name = "checkBox_Existing_ExcOpt5";
      this.checkBox_Existing_ExcOpt5.Size = new Size(82, 19);
      this.checkBox_Existing_ExcOpt5.TabIndex = 19;
      this.checkBox_Existing_ExcOpt5.Text = "checkBox5";
      this.checkBox_Existing_ExcOpt5.UseVisualStyleBackColor = true;
      this.checkBox_Existing_ExcOpt4.AutoSize = true;
      this.checkBox_Existing_ExcOpt4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Existing_ExcOpt4.ForeColor = SystemColors.ControlText;
      this.checkBox_Existing_ExcOpt4.Location = new Point(6, 97);
      this.checkBox_Existing_ExcOpt4.Name = "checkBox_Existing_ExcOpt4";
      this.checkBox_Existing_ExcOpt4.Size = new Size(82, 19);
      this.checkBox_Existing_ExcOpt4.TabIndex = 18;
      this.checkBox_Existing_ExcOpt4.Text = "checkBox4";
      this.checkBox_Existing_ExcOpt4.UseVisualStyleBackColor = true;
      this.checkBox_Existing_ExcOpt3.AutoSize = true;
      this.checkBox_Existing_ExcOpt3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Existing_ExcOpt3.ForeColor = SystemColors.ControlText;
      this.checkBox_Existing_ExcOpt3.Location = new Point(6, 78);
      this.checkBox_Existing_ExcOpt3.Name = "checkBox_Existing_ExcOpt3";
      this.checkBox_Existing_ExcOpt3.Size = new Size(82, 19);
      this.checkBox_Existing_ExcOpt3.TabIndex = 17;
      this.checkBox_Existing_ExcOpt3.Text = "checkBox3";
      this.checkBox_Existing_ExcOpt3.UseVisualStyleBackColor = true;
      this.checkBox_Existing_ExcOpt2.AutoSize = true;
      this.checkBox_Existing_ExcOpt2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Existing_ExcOpt2.ForeColor = SystemColors.ControlText;
      this.checkBox_Existing_ExcOpt2.Location = new Point(6, 60);
      this.checkBox_Existing_ExcOpt2.Name = "checkBox_Existing_ExcOpt2";
      this.checkBox_Existing_ExcOpt2.Size = new Size(82, 19);
      this.checkBox_Existing_ExcOpt2.TabIndex = 16;
      this.checkBox_Existing_ExcOpt2.Text = "checkBox2";
      this.checkBox_Existing_ExcOpt2.UseVisualStyleBackColor = true;
      this.checkBox_Existing_ExcOpt1.AutoSize = true;
      this.checkBox_Existing_ExcOpt1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Existing_ExcOpt1.ForeColor = SystemColors.ControlText;
      this.checkBox_Existing_ExcOpt1.Location = new Point(6, 42);
      this.checkBox_Existing_ExcOpt1.Name = "checkBox_Existing_ExcOpt1";
      this.checkBox_Existing_ExcOpt1.Size = new Size(82, 19);
      this.checkBox_Existing_ExcOpt1.TabIndex = 15;
      this.checkBox_Existing_ExcOpt1.Text = "checkBox1";
      this.checkBox_Existing_ExcOpt1.UseVisualStyleBackColor = true;
      this.comboBox_Existing_Opt.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Existing_Opt.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_Existing_Opt.FormattingEnabled = true;
      this.comboBox_Existing_Opt.Location = new Point(64, 65);
      this.comboBox_Existing_Opt.Name = "comboBox_Existing_Opt";
      this.comboBox_Existing_Opt.Size = new Size(65, 23);
      this.comboBox_Existing_Opt.TabIndex = 8;
      this.comboBox_Existing_Ancient.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Existing_Ancient.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_Existing_Ancient.FormattingEnabled = true;
      this.comboBox_Existing_Ancient.Location = new Point(64, 90);
      this.comboBox_Existing_Ancient.Name = "comboBox_Existing_Ancient";
      this.comboBox_Existing_Ancient.Size = new Size(65, 23);
      this.comboBox_Existing_Ancient.TabIndex = 10;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(6, 92);
      this.label4.Name = "label4";
      this.label4.Size = new Size(51, 15);
      this.label4.TabIndex = 9;
      this.label4.Text = "Ancient:";
      this.listBox_DropItems.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_DropItems.FormattingEnabled = true;
      this.listBox_DropItems.ItemHeight = 15;
      this.listBox_DropItems.Location = new Point(6, 18);
      this.listBox_DropItems.Name = "listBox_DropItems";
      this.listBox_DropItems.Size = new Size(203, 139);
      this.listBox_DropItems.TabIndex = 0;
      this.listBox_DropItems.SelectedIndexChanged += new EventHandler(this.listBox_DropItems_SelectedIndexChanged);
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.Location = new Point(754, 122);
      this.label11.Name = "label11";
      this.label11.Size = new Size(21, 20);
      this.label11.TabIndex = 29;
      this.label11.Text = "%";
      this.button_New_Add.Location = new Point(666, 408);
      this.button_New_Add.Name = "button_New_Add";
      this.button_New_Add.Size = new Size(159, 30);
      this.button_New_Add.TabIndex = 31;
      this.button_New_Add.Text = "Add";
      this.button_New_Add.UseVisualStyleBackColor = true;
      this.button_New_Add.Click += new EventHandler(this.button_New_Add_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(845, 456);
      this.Controls.Add((Control) this.button_New_Add);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.menuStrip1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = nameof (Form_DropManager);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "MU DropManager Editor";
      this.FormClosed += new FormClosedEventHandler(this.Form_DropManager_FormClosed);
      this.Load += new EventHandler(this.Form_DropManager_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.pictureBox_New_iPicture).EndInit();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.numericUpDown_New_MobMaxLv.EndInit();
      this.numericUpDown_New_MobMinLv.EndInit();
      this.numericUpDown_New_DropRate.EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.numericUpDown_New_ItemMinLv.EndInit();
      this.numericUpDown_New_ItemMaxLv.EndInit();
      this.numericUpDown_New_Durability.EndInit();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.numericUpDown_Existing_MobMaxLv.EndInit();
      this.numericUpDown_Existing_MobMinLv.EndInit();
      this.numericUpDown_Existing_DropRate.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.numericUpDown_Existing_ItemMinLv.EndInit();
      this.numericUpDown_Existing_ItemMaxLv.EndInit();
      this.numericUpDown_Existing_Durability.EndInit();
      this.groupBox_NewItem_ExcOpt.ResumeLayout(false);
      this.groupBox_NewItem_ExcOpt.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void listBox_DropItems_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox listBox = (ListBox) sender;
      if (listBox.SelectedIndex == -1)
        return;
      Structures.IGCDropManagerFile selectedItem = (Structures.IGCDropManagerFile) listBox.SelectedItem;
      this.numericUpDown_Existing_ItemMinLv.Value = (Decimal) Convert.ToUInt16(selectedItem.MinLvl);
      this.numericUpDown_Existing_ItemMaxLv.Value = (Decimal) Convert.ToUInt16(selectedItem.MaxLvl);
      this.comboBox_Existing_Opt.SelectedValue = (object) Convert.ToInt32(selectedItem.Opt);
      this.comboBox_Existing_Ancient.SelectedValue = (object) Convert.ToInt32(selectedItem.Ancient);
      this.numericUpDown_Existing_Durability.Value = (Decimal) Convert.ToUInt16(selectedItem.Durability);
      this.checkBox_Existing_Skill.Checked = selectedItem.Skill == "1";
      this.checkBox_Existing_Luck.Checked = selectedItem.Luck == "1";
      this.checkBox_Existing_RandomExc.Checked = selectedItem.Exc == "-1";
      if (!this.checkBox_Existing_RandomExc.Checked)
      {
        this.checkBox_Existing_ExcOpt1.Checked = ((int) Convert.ToUInt16(selectedItem.Exc) & 1) == 1;
        this.checkBox_Existing_ExcOpt2.Checked = ((int) Convert.ToUInt16(selectedItem.Exc) >> 1 & 1) == 1;
        this.checkBox_Existing_ExcOpt3.Checked = ((int) Convert.ToUInt16(selectedItem.Exc) >> 2 & 1) == 1;
        this.checkBox_Existing_ExcOpt4.Checked = ((int) Convert.ToUInt16(selectedItem.Exc) >> 3 & 1) == 1;
        this.checkBox_Existing_ExcOpt5.Checked = ((int) Convert.ToUInt16(selectedItem.Exc) >> 4 & 1) == 1;
        this.checkBox_Existing_ExcOpt6.Checked = ((int) Convert.ToUInt16(selectedItem.Exc) >> 5 & 1) == 1;
      }
      else
      {
        this.checkBox_Existing_ExcOpt1.Checked = false;
        this.checkBox_Existing_ExcOpt2.Checked = false;
        this.checkBox_Existing_ExcOpt3.Checked = false;
        this.checkBox_Existing_ExcOpt4.Checked = false;
        this.checkBox_Existing_ExcOpt5.Checked = false;
        this.checkBox_Existing_ExcOpt6.Checked = false;
      }
      this.comboBox_Existing_Map.SelectedValue = (object) Convert.ToInt32(selectedItem.MapID);
      this.comboBox_Existing_Mob.SelectedValue = (object) Convert.ToInt32(selectedItem.MobID);
      this.numericUpDown_Existing_MobMinLv.Value = (Decimal) Convert.ToUInt16(selectedItem.MinMobLvl);
      this.numericUpDown_Existing_MobMaxLv.Value = (Decimal) Convert.ToUInt16(selectedItem.MaxMobLvl);
      this.numericUpDown_Existing_DropRate.Value = Convert.ToDecimal(selectedItem.DropRate) / 100M;
    }

    private void listBox_New_iGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.listBox_New_iGroup.SelectedIndex == -1)
        return;
      this.DontWork = true;
      switch ((int) this.listBox_New_iGroup.SelectedValue)
      {
        case 0:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Swords;
          break;
        case 1:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Axes;
          break;
        case 2:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_MacesScepters;
          break;
        case 3:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Spears;
          break;
        case 4:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_BowsCrossBows;
          break;
        case 5:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Staffs;
          break;
        case 6:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Shields;
          break;
        case 7:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Helms;
          break;
        case 8:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Armors;
          break;
        case 9:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Pants;
          break;
        case 10:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Gloves;
          break;
        case 11:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Boots;
          break;
        case 12:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_WingsSkillsSeedsOthers;
          break;
        case 13:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Others1;
          break;
        case 14:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Others2;
          break;
        case 15:
          this.listBox_New_iIndex.DisplayMember = "Name";
          this.listBox_New_iIndex.ValueMember = "Index";
          this.listBox_New_iIndex.DataSource = (object) this.L_Scrolls;
          break;
      }
      this.listBox_New_iIndex.SelectedIndex = -1;
      this.DontWork = false;
      if (this.LastSelectedItemIndex <= this.listBox_New_iIndex.Items.Count - 1)
        this.listBox_New_iIndex.SelectedIndex = this.LastSelectedItemIndex;
      else
        this.listBox_New_iIndex.SelectedIndex = 0;
    }

    private void listBox_New_iIndex_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(this.listBox_New_iIndex.SelectedIndex != -1 & !this.DontWork))
        return;
      this.LastSelectedItemIndex = this.listBox_New_iIndex.SelectedIndex;
      try
      {
        this.pictureBox_New_iPicture.BackgroundImage = (Image) Resources.ResourceManager.GetObject("_" + this.listBox_New_iGroup.SelectedValue + this.listBox_New_iIndex.SelectedValue);
        if (this.pictureBox_New_iPicture.BackgroundImage.Size.Width > this.pictureBox_New_iPicture.Size.Width || this.pictureBox_New_iPicture.BackgroundImage.Size.Height > this.pictureBox_New_iPicture.Size.Height)
          this.pictureBox_New_iPicture.BackgroundImageLayout = ImageLayout.Zoom;
        else
          this.pictureBox_New_iPicture.BackgroundImageLayout = ImageLayout.Center;
      }
      catch
      {
        this.pictureBox_New_iPicture.BackgroundImage = (Image) Resources.ResourceManager.GetObject("no_img");
      }
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e) => this.Items = new BindingList<Structures.IGCDropManagerFile>();

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      foreach (string readAllLine in File.ReadAllLines(openFileDialog.FileName))
      {
        if (readAllLine.Trim(' ', '\t').Length > 2)
        {
          if (!readAllLine.Trim(' ', '\t').StartsWith("end"))
          {
            if (!readAllLine.Trim(' ', '\t').StartsWith("//"))
            {
              string[] strArray = this.strc.FixLine(readAllLine);
              if (strArray.Length >= 15)
              {
                Structures.IGCDropManagerFile igcDropManagerFile = new Structures.IGCDropManagerFile()
                {
                  iGroup = strArray[0],
                  iIndex = strArray[1],
                  MinLvl = strArray[2],
                  MaxLvl = strArray[3],
                  Skill = strArray[4],
                  Luck = strArray[5],
                  Opt = strArray[6],
                  Exc = strArray[7],
                  Ancient = strArray[8],
                  MapID = strArray[9],
                  MobID = strArray[10],
                  MinMobLvl = strArray[11],
                  MaxMobLvl = strArray[12],
                  Durability = strArray[13],
                  DropRate = strArray[14]
                };
                ushort uint16 = Convert.ToUInt16(igcDropManagerFile.iGroup);
                igcDropManagerFile.Name = this.GetItemName[(int) uint16, (int) Convert.ToUInt16(igcDropManagerFile.iIndex)];
                this.Items.Add(igcDropManagerFile);
              }
            }
          }
        }
      }
      if (this.Items.Count < 1)
        return;
      this.listBox_DropItems.SelectedIndex = -1;
      this.listBox_DropItems.SelectedIndex = 0;
    }

    private void radioButton_Existing_ExcArmor_CheckedChanged(object sender, EventArgs e)
    {
      this.checkBox_Existing_ExcOpt1.Text = "Zen Drop +30%";
      this.checkBox_Existing_ExcOpt2.Text = "Def Success Rate +10%";
      this.checkBox_Existing_ExcOpt3.Text = "Reflect +5%";
      this.checkBox_Existing_ExcOpt4.Text = "Damage Decrease +4%";
      this.checkBox_Existing_ExcOpt5.Text = "Mana +4%";
      this.checkBox_Existing_ExcOpt6.Text = "HP +4%";
    }

    private void radioButton_Existing_ExcWeapon_CheckedChanged(object sender, EventArgs e)
    {
      this.checkBox_Existing_ExcOpt1.Text = "Mob Kill +mana/8";
      this.checkBox_Existing_ExcOpt2.Text = "Mob Kill +life/8";
      this.checkBox_Existing_ExcOpt3.Text = "Attack(Wizardy) Speed +7";
      this.checkBox_Existing_ExcOpt4.Text = "Damage +2%";
      this.checkBox_Existing_ExcOpt5.Text = "Damage +level/20";
      this.checkBox_Existing_ExcOpt6.Text = "Exc Damage Rate +10%";
    }

    private void radioButton_Existing_ExcWings_CheckedChanged(object sender, EventArgs e)
    {
      this.checkBox_Existing_ExcOpt1.Text = "Ignor Def +5% / HP +125";
      this.checkBox_Existing_ExcOpt2.Text = "Return Attack +5% / Mana +125";
      this.checkBox_Existing_ExcOpt3.Text = "Life Recovery +5% /Ignor Def +3%";
      this.checkBox_Existing_ExcOpt4.Text = "Mana Recovery +5% / AG +50";
      this.checkBox_Existing_ExcOpt5.Text = "--- / Attack(Wiz) Speed+5";
      this.checkBox_Existing_ExcOpt6.Text = "---";
    }

    private void radioButton_New_ExcArmor_CheckedChanged(object sender, EventArgs e)
    {
      this.checkBox_New_ExcOpt1.Text = "Zen Drop +30%";
      this.checkBox_New_ExcOpt2.Text = "Def Success Rate +10%";
      this.checkBox_New_ExcOpt3.Text = "Reflect +5%";
      this.checkBox_New_ExcOpt4.Text = "Damage Decrease +4%";
      this.checkBox_New_ExcOpt5.Text = "Mana +4%";
      this.checkBox_New_ExcOpt6.Text = "HP +4%";
    }

    private void radioButton_New_ExcWeapon_CheckedChanged(object sender, EventArgs e)
    {
      this.checkBox_New_ExcOpt1.Text = "Mob Kill +mana/8";
      this.checkBox_New_ExcOpt2.Text = "Mob Kill +life/8";
      this.checkBox_New_ExcOpt3.Text = "Attack(Wizardy) Speed +7";
      this.checkBox_New_ExcOpt4.Text = "Damage +2%";
      this.checkBox_New_ExcOpt5.Text = "Damage +level/20";
      this.checkBox_New_ExcOpt6.Text = "Exc Damage Rate +10%";
    }

    private void radioButton_New_ExcWings_CheckedChanged(object sender, EventArgs e)
    {
      this.checkBox_New_ExcOpt1.Text = "Ignor Def +5% / HP +125";
      this.checkBox_New_ExcOpt2.Text = "Return Attack +5% / Mana +125";
      this.checkBox_New_ExcOpt3.Text = "Life Recovery +5% /Ignor Def +3%";
      this.checkBox_New_ExcOpt4.Text = "Mana Recovery +5% / AG +50";
      this.checkBox_New_ExcOpt5.Text = "--- / Attack(Wiz) Speed+5";
      this.checkBox_New_ExcOpt6.Text = "---";
    }

    private void ReadMonsterFile(string fName)
    {
      foreach (string readAllLine in File.ReadAllLines(fName))
      {
        if (!readAllLine.StartsWith("//") & !readAllLine.StartsWith("end"))
        {
          string[] trimmedSplitString = this.GetTrimmedSplitString(readAllLine.Split('/')[0]);
          if (trimmedSplitString != null)
          {
            if (trimmedSplitString.Length != 28 && trimmedSplitString.Length != 32)
            {
              int num = (int) MessageBox.Show("Bad length.\nLine: " + readAllLine, "Monster.txt Read Error");
              return;
            }
            Structures.Monster monster = new Structures.Monster()
            {
              ID = Convert.ToInt32(trimmedSplitString[0]),
              Rate = Convert.ToInt32(trimmedSplitString[1]),
              Name = trimmedSplitString[2].Replace("\"", "").Replace("$", " "),
              Level = Convert.ToInt32(trimmedSplitString[3]),
              HP = Convert.ToInt32(trimmedSplitString[4]),
              MP = Convert.ToInt32(trimmedSplitString[5]),
              MinDmg = Convert.ToInt32(trimmedSplitString[6]),
              MaxDmg = Convert.ToInt32(trimmedSplitString[7]),
              Def = Convert.ToInt32(trimmedSplitString[8]),
              MagDef = Convert.ToInt32(trimmedSplitString[9]),
              AtkPower = Convert.ToInt32(trimmedSplitString[10]),
              AtkSucRate = Convert.ToInt32(trimmedSplitString[11]),
              Move = Convert.ToInt32(trimmedSplitString[12]),
              AType = Convert.ToInt32(trimmedSplitString[13]),
              ARange = Convert.ToInt32(trimmedSplitString[14]),
              VRange = Convert.ToInt32(trimmedSplitString[15]),
              MovSP = Convert.ToInt32(trimmedSplitString[16]),
              ASpeed = Convert.ToInt32(trimmedSplitString[17]),
              RegTime = Convert.ToInt32(trimmedSplitString[18]),
              Attrib = Convert.ToInt32(trimmedSplitString[19]),
              ItemR = Convert.ToInt32(trimmedSplitString[20]),
              MoneyR = Convert.ToInt32(trimmedSplitString[21]),
              MaxIS = Convert.ToInt32(trimmedSplitString[22]),
              RWind = Convert.ToInt32(trimmedSplitString[23]),
              RPois = Convert.ToInt32(trimmedSplitString[24]),
              RIce = Convert.ToInt32(trimmedSplitString[25]),
              RWtr = Convert.ToInt32(trimmedSplitString[26]),
              RFire = Convert.ToInt32(trimmedSplitString[27])
            };
            if (trimmedSplitString.Length == 32)
            {
              monster.Element = Convert.ToInt32(trimmedSplitString[28]);
              monster.MinElem = Convert.ToInt32(trimmedSplitString[29]);
              monster.MaxElem = Convert.ToInt32(trimmedSplitString[30]);
              monster.ElemDef = Convert.ToInt32(trimmedSplitString[31]);
            }
            this.Monster_Existing.Add(monster);
            this.Monster_New.Add(monster);
          }
        }
      }
      this.comboBox_Existing_Mob.ValueMember = "ID";
      this.comboBox_Existing_Mob.DisplayMember = "Name";
      this.comboBox_Existing_Mob.DataSource = (object) this.Monster_Existing;
      this.comboBox_New_Mob.ValueMember = "ID";
      this.comboBox_New_Mob.DisplayMember = "Name";
      this.comboBox_New_Mob.DataSource = (object) this.Monster_New;
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Filter = "DAT files (*.dat)|*.dat";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.SaveFile(saveFileDialog2.FileName);
    }

    private void SaveFile(string fileName)
    {
      StreamWriter streamWriter = new StreamWriter(fileName);
      streamWriter.WriteLine("/////////////////////////////////////////////////////////////////////////////");
      streamWriter.WriteLine("//MU DropManager file generated by MU.ToolKit");
      streamWriter.WriteLine("//Coded by © TopReal.IT");
      streamWriter.WriteLine("/////////////////////////////////////////////////////////////////////////////");
      streamWriter.WriteLine("//\tiGroup\tiIndex\tiMinLv\tiMaxLv\tiSkill\tiLuck\tiOpt\tiExc\tiAncient\tMapID\tMobID\tMobMinLv\tMobMaxLv\tiDur\tiDropRate");
      streamWriter.WriteLine("///////////////////////////");
      streamWriter.WriteLine("0");
      foreach (Structures.IGCDropManagerFile igcDropManagerFile in (Collection<Structures.IGCDropManagerFile>) this.Items)
        streamWriter.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t\t{12}\t\t{13}\t{14}\t//{15}", (object) igcDropManagerFile.iGroup, (object) igcDropManagerFile.iIndex, (object) igcDropManagerFile.MinLvl, (object) igcDropManagerFile.MaxLvl, (object) igcDropManagerFile.Skill, (object) igcDropManagerFile.Luck, (object) igcDropManagerFile.Opt, (object) igcDropManagerFile.Exc, (object) igcDropManagerFile.Ancient, (object) igcDropManagerFile.MapID, (object) igcDropManagerFile.MobID, (object) igcDropManagerFile.MinMobLvl, (object) igcDropManagerFile.MaxMobLvl, (object) igcDropManagerFile.Durability, (object) igcDropManagerFile.DropRate, (object) igcDropManagerFile.Name);
      streamWriter.WriteLine("end");
      streamWriter.Flush();
      streamWriter.Close();
    }

    public void Setc_AncientData(ref BindingList<Structures.c_AncientData> list)
    {
      Structures.c_AncientData cAncientData1 = new Structures.c_AncientData()
      {
        ID = 0,
        Name = "None"
      };
      list.Add(cAncientData1);
      Structures.c_AncientData cAncientData2 = new Structures.c_AncientData()
      {
        ID = 5,
        Name = "Level 1"
      };
      list.Add(cAncientData2);
      Structures.c_AncientData cAncientData3 = new Structures.c_AncientData()
      {
        ID = 10,
        Name = "Level 2"
      };
      list.Add(cAncientData3);
    }
  }
}
