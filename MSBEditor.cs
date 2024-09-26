// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.MSBEditor
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MU_ToolKit
{
  public class MSBEditor : Form
  {
    private Button button_RemoveMobOnMap;
    private Button button_UpdateMonster;
    private CheckBox checkBox_HideMobs;
    private IContainer components;
    private ToolStripMenuItem fileToolStripMenuItem;
    private Graphics g;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private GroupBox groupBox5;
    private GroupBox groupBox6;
    private bool isWorking;
    private Label label_Dir;
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
    private Label label23;
    private Label label24;
    private Label label25;
    private Label label26;
    private Label label27;
    private Label label28;
    private Label label29;
    private Label label3;
    private Label label30;
    private Label label31;
    private Label label32;
    private Label label33;
    private Label label34;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Color LastBackColor = Color.Beige;
    private Color LastBorderColor = Color.Beige;
    private Structures.CustomPictureBox LastPicBox;
    private ListBox listBox_Map;
    private ListBox listBox_Mob;
    private ListBox listBox_MobsOnMap;
    private ListBox listBox2;
    private MenuStrip menuStrip1;
    private BindingList<Structures.MSB> MobsOnMap = new BindingList<Structures.MSB>();
    private BindingList<Structures.Monster> Monster = new BindingList<Structures.Monster>();
    private Dictionary<int, string> MonsterDic = new Dictionary<int, string>();
    private List<Structures.MSB> MonsterSetBase = new List<Structures.MSB>();
    private ToolStripMenuItem monsterSetBasetxtToolStripMenuItem_Save;
    private ToolStripMenuItem monstertxtToolStripMenuItem_Save;
    private int mouseDrag;
    private NumericUpDown numericUpDown_ARange;
    private NumericUpDown numericUpDown_ASpeed;
    private NumericUpDown numericUpDown_Attack;
    private NumericUpDown numericUpDown_Attrib;
    private NumericUpDown numericUpDown_AType;
    private NumericUpDown numericUpDown_Def;
    private NumericUpDown numericUpDown_Distance;
    private NumericUpDown numericUpDown_ElemDef;
    private NumericUpDown numericUpDown_Element;
    private NumericUpDown numericUpDown_HP;
    private NumericUpDown numericUpDown_ID;
    private NumericUpDown numericUpDown_ItemR;
    private NumericUpDown numericUpDown_Level;
    private NumericUpDown numericUpDown_MagicDef;
    private NumericUpDown numericUpDown_MaxDmg;
    private NumericUpDown numericUpDown_MaxElem;
    private NumericUpDown numericUpDown_MaxIS;
    private NumericUpDown numericUpDown_MinDmg;
    private NumericUpDown numericUpDown_MinElem;
    private NumericUpDown numericUpDown_MoneyR;
    private NumericUpDown numericUpDown_Move;
    private NumericUpDown numericUpDown_MoveSP;
    private NumericUpDown numericUpDown_MP;
    private NumericUpDown numericUpDown_Rate;
    private NumericUpDown numericUpDown_RegTime;
    private NumericUpDown numericUpDown_RFire;
    private NumericUpDown numericUpDown_RIce;
    private NumericUpDown numericUpDown_RPois;
    private NumericUpDown numericUpDown_RWind;
    private NumericUpDown numericUpDown_RWtr;
    private NumericUpDown numericUpDown_Success;
    private NumericUpDown numericUpDown_Total;
    private NumericUpDown numericUpDown_VRange;
    private Structures.CustomPictureBox PanelPreview;
    private PictureBox pictureBox_Map;
    private PictureBox pictureBox_MobPreview;
    private RadioButton radioButton_Dir_1;
    private RadioButton radioButton_Dir_2;
    private RadioButton radioButton_Dir_3;
    private RadioButton radioButton_Dir_4;
    private RadioButton radioButton_Dir_5;
    private RadioButton radioButton_Dir_6;
    private RadioButton radioButton_Dir_7;
    private RadioButton radioButton_Dir_8;
    private RadioButton radioButton_Dir_Negtive1;
    private RadioButton radioButton_Type_0;
    private RadioButton radioButton_Type_1;
    private RadioButton radioButton_Type_2;
    private RadioButton radioButton_Type_3;
    private RadioButton radioButton_Type_4;
    private Random rnd = new Random();
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private int SelectedDir = 1;
    private int SelectedMSBType = 2;
    private int StartX;
    private int StartY;
    private Structures strct = new Structures();
    private TextBox textBox_MobName;

    public MSBEditor() => this.InitializeComponent();

    private void AddMobToMap(Structures.MSB mMSB)
    {
      Structures.CustomPictureBox customPictureBox = new Structures.CustomPictureBox();
      Structures.CustomToolTip customToolTip = new Structures.CustomToolTip();
      customPictureBox.Location = new Point(mMSB.Y * 3, mMSB.X * 3);
      int num1 = mMSB.Y - mMSB.EndY;
      int num2 = mMSB.X - mMSB.EndX;
      if (num1 < 0)
        num1 *= -1;
      if (num2 < 0)
        num2 *= -1;
      switch (mMSB.Type)
      {
        case 0:
          customPictureBox.BackColor = Color.Yellow;
          customPictureBox.Size = new Size(3, 3);
          break;
        case 1:
          customPictureBox.Size = new Size(num1 * 3, num2 * 3);
          customPictureBox.BorderColor = Color.ForestGreen;
          customPictureBox.BackColor = Color.Transparent;
          break;
        case 2:
          customPictureBox.BackColor = Color.Red;
          customPictureBox.Size = new Size(3, 3);
          break;
        case 3:
          customPictureBox.Size = new Size(num1 * 3, num2 * 3);
          customPictureBox.BorderColor = Color.Maroon;
          customPictureBox.BackColor = Color.Transparent;
          break;
        case 4:
          customPictureBox.BackColor = Color.Cyan;
          customPictureBox.Size = new Size(3, 3);
          break;
      }
      customPictureBox.Parent = (Control) this.pictureBox_Map;
      customPictureBox.Name = mMSB.UniKey;
      customToolTip.SetToolTip((Control) customPictureBox, mMSB.ToolTipInfo);
      this.pictureBox_Map.Controls.Add((Control) customPictureBox);
      if (mMSB.Type == 3 || mMSB.Type == 1)
        customPictureBox.SendToBack();
      else
        customPictureBox.BringToFront();
      customPictureBox.MouseClick += new MouseEventHandler(this.p_MouseClick);
    }

    private void button_RemoveMobOnMap_Click(object sender, EventArgs e)
    {
      Structures.MSB selectedItem = (Structures.MSB) this.listBox_MobsOnMap.SelectedItem;
      this.MobsOnMap.Remove(selectedItem);
      this.MonsterSetBase.Remove(selectedItem);
      this.pictureBox_Map.Controls.RemoveByKey(selectedItem.UniKey);
    }

    private void button_UpdateMonster_Click(object sender, EventArgs e)
    {
      Structures.Monster selectedItem = (Structures.Monster) this.listBox_Mob.SelectedItem;
      Structures.Monster monster1 = new Structures.Monster();
      Structures.Monster monster2 = selectedItem with
      {
        Name = this.textBox_MobName.Text,
        ID = (int) this.numericUpDown_ID.Value,
        Rate = (int) this.numericUpDown_Rate.Value,
        Level = (int) this.numericUpDown_Level.Value,
        HP = (int) this.numericUpDown_HP.Value,
        MP = (int) this.numericUpDown_MP.Value,
        MinDmg = (int) this.numericUpDown_MinDmg.Value,
        MaxDmg = (int) this.numericUpDown_MaxDmg.Value,
        Def = (int) this.numericUpDown_Def.Value,
        MagDef = (int) this.numericUpDown_MagicDef.Value,
        AtkPower = (int) this.numericUpDown_Attack.Value,
        AtkSucRate = (int) this.numericUpDown_Success.Value,
        Move = (int) this.numericUpDown_Move.Value,
        AType = (int) this.numericUpDown_AType.Value,
        ARange = (int) this.numericUpDown_ARange.Value,
        VRange = (int) this.numericUpDown_VRange.Value,
        MovSP = (int) this.numericUpDown_MoveSP.Value,
        ASpeed = (int) this.numericUpDown_ASpeed.Value,
        RegTime = (int) this.numericUpDown_RegTime.Value,
        ItemR = (int) this.numericUpDown_ItemR.Value,
        MoneyR = (int) this.numericUpDown_MoneyR.Value,
        MaxIS = (int) this.numericUpDown_MaxIS.Value,
        Attrib = (int) this.numericUpDown_Attrib.Value,
        RWind = (int) this.numericUpDown_RWind.Value,
        RPois = (int) this.numericUpDown_RPois.Value,
        RIce = (int) this.numericUpDown_RIce.Value,
        RWtr = (int) this.numericUpDown_RWtr.Value,
        RFire = (int) this.numericUpDown_RFire.Value,
        Element = (int) this.numericUpDown_Element.Value,
        MinElem = (int) this.numericUpDown_MinElem.Value,
        MaxElem = (int) this.numericUpDown_MaxElem.Value,
        ElemDef = (int) this.numericUpDown_ElemDef.Value
      };
      this.Monster[this.Monster.IndexOf(selectedItem)] = monster2;
      this.MonsterDic[selectedItem.ID] = monster2.Name;
    }

    private void checkBox_HideMobs_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox_HideMobs.Checked)
      {
        foreach (Control control in (ArrangedElementCollection) this.pictureBox_Map.Controls)
          control.Visible = false;
      }
      else
      {
        foreach (Control control in (ArrangedElementCollection) this.pictureBox_Map.Controls)
          control.Visible = true;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void DisposedUnusedControls()
    {
      foreach (Control control in (ArrangedElementCollection) this.pictureBox_Map.Controls)
      {
        control.Visible = false;
        control.Hide();
      }
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

    private string GetUniqueKey() => this.rnd.Next(99999).ToString() + this.rnd.Next(99999).ToString() + this.rnd.Next(99999).ToString() + this.rnd.Next(99999).ToString();

    private void InitializeComponent()
    {
      this.listBox_Map = new ListBox();
      this.groupBox1 = new GroupBox();
      this.pictureBox_MobPreview = new PictureBox();
      this.groupBox5 = new GroupBox();
      this.radioButton_Type_4 = new RadioButton();
      this.radioButton_Type_3 = new RadioButton();
      this.radioButton_Type_2 = new RadioButton();
      this.radioButton_Type_0 = new RadioButton();
      this.radioButton_Type_1 = new RadioButton();
      this.label4 = new Label();
      this.label3 = new Label();
      this.numericUpDown_Total = new NumericUpDown();
      this.numericUpDown_Distance = new NumericUpDown();
      this.groupBox4 = new GroupBox();
      this.label_Dir = new Label();
      this.radioButton_Dir_Negtive1 = new RadioButton();
      this.radioButton_Dir_3 = new RadioButton();
      this.radioButton_Dir_1 = new RadioButton();
      this.radioButton_Dir_5 = new RadioButton();
      this.radioButton_Dir_7 = new RadioButton();
      this.radioButton_Dir_2 = new RadioButton();
      this.radioButton_Dir_8 = new RadioButton();
      this.radioButton_Dir_4 = new RadioButton();
      this.radioButton_Dir_6 = new RadioButton();
      this.listBox_Mob = new ListBox();
      this.groupBox2 = new GroupBox();
      this.numericUpDown_ElemDef = new NumericUpDown();
      this.label34 = new Label();
      this.numericUpDown_MaxElem = new NumericUpDown();
      this.numericUpDown_MinElem = new NumericUpDown();
      this.numericUpDown_Element = new NumericUpDown();
      this.label2 = new Label();
      this.label32 = new Label();
      this.label33 = new Label();
      this.numericUpDown_RFire = new NumericUpDown();
      this.numericUpDown_RWtr = new NumericUpDown();
      this.numericUpDown_RIce = new NumericUpDown();
      this.numericUpDown_RPois = new NumericUpDown();
      this.numericUpDown_RWind = new NumericUpDown();
      this.numericUpDown_Attrib = new NumericUpDown();
      this.numericUpDown_MaxIS = new NumericUpDown();
      this.numericUpDown_MoneyR = new NumericUpDown();
      this.numericUpDown_ItemR = new NumericUpDown();
      this.numericUpDown_RegTime = new NumericUpDown();
      this.numericUpDown_ASpeed = new NumericUpDown();
      this.numericUpDown_MoveSP = new NumericUpDown();
      this.numericUpDown_VRange = new NumericUpDown();
      this.numericUpDown_ARange = new NumericUpDown();
      this.numericUpDown_AType = new NumericUpDown();
      this.numericUpDown_Move = new NumericUpDown();
      this.numericUpDown_Success = new NumericUpDown();
      this.numericUpDown_Attack = new NumericUpDown();
      this.numericUpDown_MagicDef = new NumericUpDown();
      this.numericUpDown_MaxDmg = new NumericUpDown();
      this.numericUpDown_Def = new NumericUpDown();
      this.numericUpDown_MinDmg = new NumericUpDown();
      this.numericUpDown_HP = new NumericUpDown();
      this.numericUpDown_MP = new NumericUpDown();
      this.numericUpDown_Level = new NumericUpDown();
      this.numericUpDown_ID = new NumericUpDown();
      this.numericUpDown_Rate = new NumericUpDown();
      this.label28 = new Label();
      this.label29 = new Label();
      this.label30 = new Label();
      this.label1 = new Label();
      this.label31 = new Label();
      this.textBox_MobName = new TextBox();
      this.label20 = new Label();
      this.label21 = new Label();
      this.label22 = new Label();
      this.label23 = new Label();
      this.label24 = new Label();
      this.label25 = new Label();
      this.label26 = new Label();
      this.label27 = new Label();
      this.label19 = new Label();
      this.label18 = new Label();
      this.label17 = new Label();
      this.label16 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.label13 = new Label();
      this.label12 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.listBox2 = new ListBox();
      this.button_UpdateMonster = new Button();
      this.listBox_MobsOnMap = new ListBox();
      this.groupBox3 = new GroupBox();
      this.groupBox6 = new GroupBox();
      this.button_RemoveMobOnMap = new Button();
      this.pictureBox_Map = new PictureBox();
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new ToolStripMenuItem();
      this.monsterSetBasetxtToolStripMenuItem_Save = new ToolStripMenuItem();
      this.monstertxtToolStripMenuItem_Save = new ToolStripMenuItem();
      this.checkBox_HideMobs = new CheckBox();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox_MobPreview).BeginInit();
      this.groupBox5.SuspendLayout();
      this.numericUpDown_Total.BeginInit();
      this.numericUpDown_Distance.BeginInit();
      this.groupBox4.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.numericUpDown_ElemDef.BeginInit();
      this.numericUpDown_MaxElem.BeginInit();
      this.numericUpDown_MinElem.BeginInit();
      this.numericUpDown_Element.BeginInit();
      this.numericUpDown_RFire.BeginInit();
      this.numericUpDown_RWtr.BeginInit();
      this.numericUpDown_RIce.BeginInit();
      this.numericUpDown_RPois.BeginInit();
      this.numericUpDown_RWind.BeginInit();
      this.numericUpDown_Attrib.BeginInit();
      this.numericUpDown_MaxIS.BeginInit();
      this.numericUpDown_MoneyR.BeginInit();
      this.numericUpDown_ItemR.BeginInit();
      this.numericUpDown_RegTime.BeginInit();
      this.numericUpDown_ASpeed.BeginInit();
      this.numericUpDown_MoveSP.BeginInit();
      this.numericUpDown_VRange.BeginInit();
      this.numericUpDown_ARange.BeginInit();
      this.numericUpDown_AType.BeginInit();
      this.numericUpDown_Move.BeginInit();
      this.numericUpDown_Success.BeginInit();
      this.numericUpDown_Attack.BeginInit();
      this.numericUpDown_MagicDef.BeginInit();
      this.numericUpDown_MaxDmg.BeginInit();
      this.numericUpDown_Def.BeginInit();
      this.numericUpDown_MinDmg.BeginInit();
      this.numericUpDown_HP.BeginInit();
      this.numericUpDown_MP.BeginInit();
      this.numericUpDown_Level.BeginInit();
      this.numericUpDown_ID.BeginInit();
      this.numericUpDown_Rate.BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox6.SuspendLayout();
      ((ISupportInitialize) this.pictureBox_Map).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.listBox_Map.FormattingEnabled = true;
      this.listBox_Map.ItemHeight = 12;
      this.listBox_Map.Location = new Point(6, 17);
      this.listBox_Map.Name = "listBox_Map";
      this.listBox_Map.Size = new Size(137, 172);
      this.listBox_Map.TabIndex = 0;
      this.listBox_Map.SelectedIndexChanged += new EventHandler(this.listBox_Map_SelectedIndexChanged);
      this.groupBox1.Controls.Add((Control) this.pictureBox_MobPreview);
      this.groupBox1.Controls.Add((Control) this.groupBox5);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.numericUpDown_Total);
      this.groupBox1.Controls.Add((Control) this.numericUpDown_Distance);
      this.groupBox1.Controls.Add((Control) this.groupBox4);
      this.groupBox1.Controls.Add((Control) this.listBox_Mob);
      this.groupBox1.Controls.Add((Control) this.groupBox2);
      this.groupBox1.Location = new Point(12, 223);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(299, 519);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "New Mob Selection";
      this.pictureBox_MobPreview.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_MobPreview.Location = new Point(182, 18);
      this.pictureBox_MobPreview.Name = "pictureBox_MobPreview";
      this.pictureBox_MobPreview.Size = new Size(111, 88);
      this.pictureBox_MobPreview.TabIndex = 14;
      this.pictureBox_MobPreview.TabStop = false;
      this.groupBox5.Controls.Add((Control) this.radioButton_Type_4);
      this.groupBox5.Controls.Add((Control) this.radioButton_Type_3);
      this.groupBox5.Controls.Add((Control) this.radioButton_Type_2);
      this.groupBox5.Controls.Add((Control) this.radioButton_Type_0);
      this.groupBox5.Controls.Add((Control) this.radioButton_Type_1);
      this.groupBox5.Location = new Point(105, 441);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(188, 73);
      this.groupBox5.TabIndex = 9;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Mob Type";
      this.radioButton_Type_4.AutoSize = true;
      this.radioButton_Type_4.BackColor = Color.Cyan;
      this.radioButton_Type_4.Location = new Point(60, 52);
      this.radioButton_Type_4.Name = "radioButton_Type_4";
      this.radioButton_Type_4.Size = new Size(77, 16);
      this.radioButton_Type_4.TabIndex = 48;
      this.radioButton_Type_4.Text = "(4) Event";
      this.radioButton_Type_4.UseVisualStyleBackColor = false;
      this.radioButton_Type_4.CheckedChanged += new EventHandler(this.radioButton_Type_1_CheckedChanged);
      this.radioButton_Type_3.AutoSize = true;
      this.radioButton_Type_3.BackColor = Color.Maroon;
      this.radioButton_Type_3.Location = new Point(101, 33);
      this.radioButton_Type_3.Name = "radioButton_Type_3";
      this.radioButton_Type_3.Size = new Size(95, 16);
      this.radioButton_Type_3.TabIndex = 47;
      this.radioButton_Type_3.Text = "(3) Multiple";
      this.radioButton_Type_3.UseVisualStyleBackColor = false;
      this.radioButton_Type_3.CheckedChanged += new EventHandler(this.radioButton_Type_1_CheckedChanged);
      this.radioButton_Type_2.AutoSize = true;
      this.radioButton_Type_2.BackColor = Color.Red;
      this.radioButton_Type_2.Checked = true;
      this.radioButton_Type_2.Location = new Point(12, 33);
      this.radioButton_Type_2.Name = "radioButton_Type_2";
      this.radioButton_Type_2.Size = new Size(95, 16);
      this.radioButton_Type_2.TabIndex = 45;
      this.radioButton_Type_2.TabStop = true;
      this.radioButton_Type_2.Text = "(2) Standard";
      this.radioButton_Type_2.UseVisualStyleBackColor = false;
      this.radioButton_Type_2.CheckedChanged += new EventHandler(this.radioButton_Type_1_CheckedChanged);
      this.radioButton_Type_0.AutoSize = true;
      this.radioButton_Type_0.BackColor = Color.Yellow;
      this.radioButton_Type_0.Location = new Point(12, 15);
      this.radioButton_Type_0.Name = "radioButton_Type_0";
      this.radioButton_Type_0.Size = new Size(65, 16);
      this.radioButton_Type_0.TabIndex = 44;
      this.radioButton_Type_0.Text = "(0) NPC";
      this.radioButton_Type_0.UseVisualStyleBackColor = false;
      this.radioButton_Type_0.CheckedChanged += new EventHandler(this.radioButton_Type_1_CheckedChanged);
      this.radioButton_Type_1.AutoSize = true;
      this.radioButton_Type_1.BackColor = Color.ForestGreen;
      this.radioButton_Type_1.Location = new Point(101, 15);
      this.radioButton_Type_1.Name = "radioButton_Type_1";
      this.radioButton_Type_1.Size = new Size(95, 16);
      this.radioButton_Type_1.TabIndex = 46;
      this.radioButton_Type_1.Text = "(1) Multiple";
      this.radioButton_Type_1.UseVisualStyleBackColor = false;
      this.radioButton_Type_1.CheckedChanged += new EventHandler(this.radioButton_Type_1_CheckedChanged);
      this.label4.AutoSize = true;
      this.label4.Location = new Point(186, 423);
      this.label4.Name = "label4";
      this.label4.Size = new Size(59, 12);
      this.label4.TabIndex = 13;
      this.label4.Text = "Distance:";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(105, 423);
      this.label3.Name = "label3";
      this.label3.Size = new Size(41, 12);
      this.label3.TabIndex = 12;
      this.label3.Text = "Total:";
      this.numericUpDown_Total.Location = new Point(140, 421);
      this.numericUpDown_Total.Name = "numericUpDown_Total";
      this.numericUpDown_Total.Size = new Size(40, 21);
      this.numericUpDown_Total.TabIndex = 42;
      this.numericUpDown_Distance.Location = new Point(238, 420);
      this.numericUpDown_Distance.Name = "numericUpDown_Distance";
      this.numericUpDown_Distance.Size = new Size(55, 21);
      this.numericUpDown_Distance.TabIndex = 43;
      this.groupBox4.Controls.Add((Control) this.label_Dir);
      this.groupBox4.Controls.Add((Control) this.radioButton_Dir_Negtive1);
      this.groupBox4.Controls.Add((Control) this.radioButton_Dir_3);
      this.groupBox4.Controls.Add((Control) this.radioButton_Dir_1);
      this.groupBox4.Controls.Add((Control) this.radioButton_Dir_5);
      this.groupBox4.Controls.Add((Control) this.radioButton_Dir_7);
      this.groupBox4.Controls.Add((Control) this.radioButton_Dir_2);
      this.groupBox4.Controls.Add((Control) this.radioButton_Dir_8);
      this.groupBox4.Controls.Add((Control) this.radioButton_Dir_4);
      this.groupBox4.Controls.Add((Control) this.radioButton_Dir_6);
      this.groupBox4.Location = new Point(6, 423);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(93, 91);
      this.groupBox4.TabIndex = 9;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Direction";
      this.label_Dir.AutoSize = true;
      this.label_Dir.Location = new Point(75, 9);
      this.label_Dir.Name = "label_Dir";
      this.label_Dir.Size = new Size(11, 12);
      this.label_Dir.TabIndex = 9;
      this.label_Dir.Text = "1";
      this.radioButton_Dir_Negtive1.AutoSize = true;
      this.radioButton_Dir_Negtive1.Location = new Point(40, 43);
      this.radioButton_Dir_Negtive1.Name = "radioButton_Dir_Negtive1";
      this.radioButton_Dir_Negtive1.Size = new Size(14, 13);
      this.radioButton_Dir_Negtive1.TabIndex = 33;
      this.radioButton_Dir_Negtive1.UseVisualStyleBackColor = true;
      this.radioButton_Dir_Negtive1.CheckedChanged += new EventHandler(this.radioButton_Dir_Negtive1_CheckedChanged);
      this.radioButton_Dir_3.AutoSize = true;
      this.radioButton_Dir_3.Location = new Point(62, 63);
      this.radioButton_Dir_3.Name = "radioButton_Dir_3";
      this.radioButton_Dir_3.Size = new Size(14, 13);
      this.radioButton_Dir_3.TabIndex = 40;
      this.radioButton_Dir_3.UseVisualStyleBackColor = true;
      this.radioButton_Dir_3.CheckedChanged += new EventHandler(this.radioButton_Dir_Negtive1_CheckedChanged);
      this.radioButton_Dir_1.AutoSize = true;
      this.radioButton_Dir_1.Checked = true;
      this.radioButton_Dir_1.Location = new Point(16, 61);
      this.radioButton_Dir_1.Name = "radioButton_Dir_1";
      this.radioButton_Dir_1.Size = new Size(14, 13);
      this.radioButton_Dir_1.TabIndex = 34;
      this.radioButton_Dir_1.TabStop = true;
      this.radioButton_Dir_1.UseVisualStyleBackColor = true;
      this.radioButton_Dir_1.CheckedChanged += new EventHandler(this.radioButton_Dir_Negtive1_CheckedChanged);
      this.radioButton_Dir_5.AutoSize = true;
      this.radioButton_Dir_5.Location = new Point(61, 24);
      this.radioButton_Dir_5.Name = "radioButton_Dir_5";
      this.radioButton_Dir_5.Size = new Size(14, 13);
      this.radioButton_Dir_5.TabIndex = 38;
      this.radioButton_Dir_5.UseVisualStyleBackColor = true;
      this.radioButton_Dir_5.CheckedChanged += new EventHandler(this.radioButton_Dir_Negtive1_CheckedChanged);
      this.radioButton_Dir_7.AutoSize = true;
      this.radioButton_Dir_7.Location = new Point(18, 24);
      this.radioButton_Dir_7.Name = "radioButton_Dir_7";
      this.radioButton_Dir_7.Size = new Size(14, 13);
      this.radioButton_Dir_7.TabIndex = 36;
      this.radioButton_Dir_7.UseVisualStyleBackColor = true;
      this.radioButton_Dir_7.CheckedChanged += new EventHandler(this.radioButton_Dir_Negtive1_CheckedChanged);
      this.radioButton_Dir_2.AutoSize = true;
      this.radioButton_Dir_2.Location = new Point(40, 68);
      this.radioButton_Dir_2.Name = "radioButton_Dir_2";
      this.radioButton_Dir_2.Size = new Size(14, 13);
      this.radioButton_Dir_2.TabIndex = 41;
      this.radioButton_Dir_2.UseVisualStyleBackColor = true;
      this.radioButton_Dir_2.CheckedChanged += new EventHandler(this.radioButton_Dir_Negtive1_CheckedChanged);
      this.radioButton_Dir_8.AutoSize = true;
      this.radioButton_Dir_8.Location = new Point(8, 43);
      this.radioButton_Dir_8.Name = "radioButton_Dir_8";
      this.radioButton_Dir_8.Size = new Size(14, 13);
      this.radioButton_Dir_8.TabIndex = 35;
      this.radioButton_Dir_8.UseVisualStyleBackColor = true;
      this.radioButton_Dir_8.CheckedChanged += new EventHandler(this.radioButton_Dir_Negtive1_CheckedChanged);
      this.radioButton_Dir_4.AutoSize = true;
      this.radioButton_Dir_4.Location = new Point(70, 43);
      this.radioButton_Dir_4.Name = "radioButton_Dir_4";
      this.radioButton_Dir_4.Size = new Size(14, 13);
      this.radioButton_Dir_4.TabIndex = 39;
      this.radioButton_Dir_4.UseVisualStyleBackColor = true;
      this.radioButton_Dir_4.CheckedChanged += new EventHandler(this.radioButton_Dir_Negtive1_CheckedChanged);
      this.radioButton_Dir_6.AutoSize = true;
      this.radioButton_Dir_6.Location = new Point(39, 18);
      this.radioButton_Dir_6.Name = "radioButton_Dir_6";
      this.radioButton_Dir_6.Size = new Size(14, 13);
      this.radioButton_Dir_6.TabIndex = 37;
      this.radioButton_Dir_6.UseVisualStyleBackColor = true;
      this.radioButton_Dir_6.CheckedChanged += new EventHandler(this.radioButton_Dir_Negtive1_CheckedChanged);
      this.listBox_Mob.ColumnWidth = 140;
      this.listBox_Mob.FormattingEnabled = true;
      this.listBox_Mob.ItemHeight = 12;
      this.listBox_Mob.Location = new Point(6, 18);
      this.listBox_Mob.Name = "listBox_Mob";
      this.listBox_Mob.Size = new Size(171, 88);
      this.listBox_Mob.TabIndex = 3;
      this.listBox_Mob.SelectedIndexChanged += new EventHandler(this.listBox_Mob_SelectedIndexChanged);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_ElemDef);
      this.groupBox2.Controls.Add((Control) this.label34);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_MaxElem);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_MinElem);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Element);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.label32);
      this.groupBox2.Controls.Add((Control) this.label33);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_RFire);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_RWtr);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_RIce);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_RPois);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_RWind);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Attrib);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_MaxIS);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_MoneyR);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_ItemR);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_RegTime);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_ASpeed);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_MoveSP);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_VRange);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_ARange);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_AType);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Move);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Success);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Attack);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_MagicDef);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_MaxDmg);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Def);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_MinDmg);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_HP);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_MP);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Level);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_ID);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_Rate);
      this.groupBox2.Controls.Add((Control) this.label28);
      this.groupBox2.Controls.Add((Control) this.label29);
      this.groupBox2.Controls.Add((Control) this.label30);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Controls.Add((Control) this.label31);
      this.groupBox2.Controls.Add((Control) this.textBox_MobName);
      this.groupBox2.Controls.Add((Control) this.label20);
      this.groupBox2.Controls.Add((Control) this.label21);
      this.groupBox2.Controls.Add((Control) this.label22);
      this.groupBox2.Controls.Add((Control) this.label23);
      this.groupBox2.Controls.Add((Control) this.label24);
      this.groupBox2.Controls.Add((Control) this.label25);
      this.groupBox2.Controls.Add((Control) this.label26);
      this.groupBox2.Controls.Add((Control) this.label27);
      this.groupBox2.Controls.Add((Control) this.label19);
      this.groupBox2.Controls.Add((Control) this.label18);
      this.groupBox2.Controls.Add((Control) this.label17);
      this.groupBox2.Controls.Add((Control) this.label16);
      this.groupBox2.Controls.Add((Control) this.label15);
      this.groupBox2.Controls.Add((Control) this.label14);
      this.groupBox2.Controls.Add((Control) this.label13);
      this.groupBox2.Controls.Add((Control) this.label12);
      this.groupBox2.Controls.Add((Control) this.label11);
      this.groupBox2.Controls.Add((Control) this.label10);
      this.groupBox2.Controls.Add((Control) this.label9);
      this.groupBox2.Controls.Add((Control) this.label8);
      this.groupBox2.Controls.Add((Control) this.label7);
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Controls.Add((Control) this.listBox2);
      this.groupBox2.Controls.Add((Control) this.button_UpdateMonster);
      this.groupBox2.Location = new Point(6, 117);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(287, 300);
      this.groupBox2.TabIndex = 6;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Selected Mob Stats";
      this.numericUpDown_ElemDef.Location = new Point(46, 280);
      this.numericUpDown_ElemDef.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_ElemDef.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_ElemDef.Name = "numericUpDown_ElemDef";
      this.numericUpDown_ElemDef.Size = new Size(46, 21);
      this.numericUpDown_ElemDef.TabIndex = 72;
      this.label34.AutoSize = true;
      this.label34.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label34.Location = new Point(1, 283);
      this.label34.Name = "label34";
      this.label34.Size = new Size(41, 12);
      this.label34.TabIndex = 73;
      this.label34.Text = "ElemDef";
      this.numericUpDown_MaxElem.Location = new Point(229, 258);
      this.numericUpDown_MaxElem.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_MaxElem.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_MaxElem.Name = "numericUpDown_MaxElem";
      this.numericUpDown_MaxElem.Size = new Size(46, 21);
      this.numericUpDown_MaxElem.TabIndex = 68;
      this.numericUpDown_MinElem.Location = new Point(135, 258);
      this.numericUpDown_MinElem.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_MinElem.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_MinElem.Name = "numericUpDown_MinElem";
      this.numericUpDown_MinElem.Size = new Size(46, 21);
      this.numericUpDown_MinElem.TabIndex = 67;
      this.numericUpDown_Element.Location = new Point(46, 258);
      this.numericUpDown_Element.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_Element.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_Element.Name = "numericUpDown_Element";
      this.numericUpDown_Element.Size = new Size(46, 21);
      this.numericUpDown_Element.TabIndex = 66;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label2.Location = new Point(185, 262);
      this.label2.Name = "label2";
      this.label2.Size = new Size(45, 12);
      this.label2.TabIndex = 71;
      this.label2.Text = "MaxElem";
      this.label32.AutoSize = true;
      this.label32.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label32.Location = new Point(94, 262);
      this.label32.Name = "label32";
      this.label32.Size = new Size(42, 12);
      this.label32.TabIndex = 70;
      this.label32.Text = "MinElem";
      this.label33.AutoSize = true;
      this.label33.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label33.Location = new Point(3, 262);
      this.label33.Name = "label33";
      this.label33.Size = new Size(39, 12);
      this.label33.TabIndex = 69;
      this.label33.Text = "Element";
      this.numericUpDown_RFire.Location = new Point(229, 235);
      this.numericUpDown_RFire.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_RFire.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_RFire.Name = "numericUpDown_RFire";
      this.numericUpDown_RFire.Size = new Size(46, 21);
      this.numericUpDown_RFire.TabIndex = 31;
      this.numericUpDown_RWtr.Location = new Point(229, 211);
      this.numericUpDown_RWtr.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_RWtr.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_RWtr.Name = "numericUpDown_RWtr";
      this.numericUpDown_RWtr.Size = new Size(46, 21);
      this.numericUpDown_RWtr.TabIndex = 30;
      this.numericUpDown_RIce.Location = new Point(230, 187);
      this.numericUpDown_RIce.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_RIce.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_RIce.Name = "numericUpDown_RIce";
      this.numericUpDown_RIce.Size = new Size(46, 21);
      this.numericUpDown_RIce.TabIndex = 29;
      this.numericUpDown_RPois.Location = new Point(230, 163);
      this.numericUpDown_RPois.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_RPois.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_RPois.Name = "numericUpDown_RPois";
      this.numericUpDown_RPois.Size = new Size(46, 21);
      this.numericUpDown_RPois.TabIndex = 28;
      this.numericUpDown_RWind.Location = new Point(231, 139);
      this.numericUpDown_RWind.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_RWind.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_RWind.Name = "numericUpDown_RWind";
      this.numericUpDown_RWind.Size = new Size(46, 21);
      this.numericUpDown_RWind.TabIndex = 27;
      this.numericUpDown_Attrib.Location = new Point(231, 115);
      this.numericUpDown_Attrib.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_Attrib.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_Attrib.Name = "numericUpDown_Attrib";
      this.numericUpDown_Attrib.Size = new Size(46, 21);
      this.numericUpDown_Attrib.TabIndex = 26;
      this.numericUpDown_MaxIS.Location = new Point(232, 91);
      this.numericUpDown_MaxIS.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_MaxIS.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_MaxIS.Name = "numericUpDown_MaxIS";
      this.numericUpDown_MaxIS.Size = new Size(46, 21);
      this.numericUpDown_MaxIS.TabIndex = 25;
      this.numericUpDown_MoneyR.Location = new Point(231, 67);
      this.numericUpDown_MoneyR.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_MoneyR.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_MoneyR.Name = "numericUpDown_MoneyR";
      this.numericUpDown_MoneyR.Size = new Size(46, 21);
      this.numericUpDown_MoneyR.TabIndex = 24;
      this.numericUpDown_ItemR.Location = new Point(232, 43);
      this.numericUpDown_ItemR.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_ItemR.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_ItemR.Name = "numericUpDown_ItemR";
      this.numericUpDown_ItemR.Size = new Size(46, 21);
      this.numericUpDown_ItemR.TabIndex = 23;
      this.numericUpDown_RegTime.Location = new Point(135, 235);
      this.numericUpDown_RegTime.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_RegTime.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_RegTime.Name = "numericUpDown_RegTime";
      this.numericUpDown_RegTime.Size = new Size(46, 21);
      this.numericUpDown_RegTime.TabIndex = 22;
      this.numericUpDown_ASpeed.Location = new Point(135, 211);
      this.numericUpDown_ASpeed.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_ASpeed.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_ASpeed.Name = "numericUpDown_ASpeed";
      this.numericUpDown_ASpeed.Size = new Size(46, 21);
      this.numericUpDown_ASpeed.TabIndex = 21;
      this.numericUpDown_MoveSP.Location = new Point(136, 187);
      this.numericUpDown_MoveSP.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_MoveSP.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_MoveSP.Name = "numericUpDown_MoveSP";
      this.numericUpDown_MoveSP.Size = new Size(46, 21);
      this.numericUpDown_MoveSP.TabIndex = 20;
      this.numericUpDown_VRange.Location = new Point(136, 163);
      this.numericUpDown_VRange.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_VRange.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_VRange.Name = "numericUpDown_VRange";
      this.numericUpDown_VRange.Size = new Size(46, 21);
      this.numericUpDown_VRange.TabIndex = 19;
      this.numericUpDown_ARange.Location = new Point(137, 139);
      this.numericUpDown_ARange.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_ARange.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_ARange.Name = "numericUpDown_ARange";
      this.numericUpDown_ARange.Size = new Size(46, 21);
      this.numericUpDown_ARange.TabIndex = 18;
      this.numericUpDown_AType.Location = new Point(137, 115);
      this.numericUpDown_AType.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_AType.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_AType.Name = "numericUpDown_AType";
      this.numericUpDown_AType.Size = new Size(46, 21);
      this.numericUpDown_AType.TabIndex = 17;
      this.numericUpDown_Move.Location = new Point(138, 91);
      this.numericUpDown_Move.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_Move.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_Move.Name = "numericUpDown_Move";
      this.numericUpDown_Move.Size = new Size(46, 21);
      this.numericUpDown_Move.TabIndex = 16;
      this.numericUpDown_Success.Location = new Point(137, 67);
      this.numericUpDown_Success.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_Success.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_Success.Name = "numericUpDown_Success";
      this.numericUpDown_Success.Size = new Size(46, 21);
      this.numericUpDown_Success.TabIndex = 15;
      this.numericUpDown_Attack.Location = new Point(138, 43);
      this.numericUpDown_Attack.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_Attack.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_Attack.Name = "numericUpDown_Attack";
      this.numericUpDown_Attack.Size = new Size(46, 21);
      this.numericUpDown_Attack.TabIndex = 14;
      this.numericUpDown_MagicDef.Location = new Point(46, 235);
      this.numericUpDown_MagicDef.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_MagicDef.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_MagicDef.Name = "numericUpDown_MagicDef";
      this.numericUpDown_MagicDef.Size = new Size(46, 21);
      this.numericUpDown_MagicDef.TabIndex = 13;
      this.numericUpDown_MaxDmg.Location = new Point(46, 187);
      this.numericUpDown_MaxDmg.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_MaxDmg.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_MaxDmg.Name = "numericUpDown_MaxDmg";
      this.numericUpDown_MaxDmg.Size = new Size(46, 21);
      this.numericUpDown_MaxDmg.TabIndex = 11;
      this.numericUpDown_Def.Location = new Point(46, 211);
      this.numericUpDown_Def.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_Def.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_Def.Name = "numericUpDown_Def";
      this.numericUpDown_Def.Size = new Size(46, 21);
      this.numericUpDown_Def.TabIndex = 12;
      this.numericUpDown_MinDmg.Location = new Point(46, 163);
      this.numericUpDown_MinDmg.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_MinDmg.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_MinDmg.Name = "numericUpDown_MinDmg";
      this.numericUpDown_MinDmg.Size = new Size(46, 21);
      this.numericUpDown_MinDmg.TabIndex = 10;
      this.numericUpDown_HP.Location = new Point(46, 115);
      this.numericUpDown_HP.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_HP.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_HP.Name = "numericUpDown_HP";
      this.numericUpDown_HP.Size = new Size(46, 21);
      this.numericUpDown_HP.TabIndex = 8;
      this.numericUpDown_MP.Location = new Point(46, 139);
      this.numericUpDown_MP.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_MP.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_MP.Name = "numericUpDown_MP";
      this.numericUpDown_MP.Size = new Size(46, 21);
      this.numericUpDown_MP.TabIndex = 9;
      this.numericUpDown_Level.Location = new Point(46, 91);
      this.numericUpDown_Level.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_Level.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_Level.Name = "numericUpDown_Level";
      this.numericUpDown_Level.Size = new Size(46, 21);
      this.numericUpDown_Level.TabIndex = 7;
      this.numericUpDown_ID.Location = new Point(46, 43);
      this.numericUpDown_ID.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_ID.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_ID.Name = "numericUpDown_ID";
      this.numericUpDown_ID.Size = new Size(46, 21);
      this.numericUpDown_ID.TabIndex = 5;
      this.numericUpDown_Rate.Location = new Point(46, 67);
      this.numericUpDown_Rate.Maximum = new Decimal(new int[4]
      {
        1410065407,
        2,
        0,
        0
      });
      this.numericUpDown_Rate.Minimum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        int.MinValue
      });
      this.numericUpDown_Rate.Name = "numericUpDown_Rate";
      this.numericUpDown_Rate.Size = new Size(46, 21);
      this.numericUpDown_Rate.TabIndex = 6;
      this.label28.AutoSize = true;
      this.label28.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label28.Location = new Point(189, 237);
      this.label28.Name = "label28";
      this.label28.Size = new Size(28, 12);
      this.label28.TabIndex = 65;
      this.label28.Text = "RFire";
      this.label29.AutoSize = true;
      this.label29.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label29.Location = new Point(189, 213);
      this.label29.Name = "label29";
      this.label29.Size = new Size(27, 12);
      this.label29.TabIndex = 64;
      this.label29.Text = "RWtr";
      this.label30.AutoSize = true;
      this.label30.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label30.Location = new Point(189, 189);
      this.label30.Name = "label30";
      this.label30.Size = new Size(25, 12);
      this.label30.TabIndex = 63;
      this.label30.Text = "RIce";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(6, 21);
      this.label1.Name = "label1";
      this.label1.Size = new Size(29, 12);
      this.label1.TabIndex = 10;
      this.label1.Text = "Name";
      this.label31.AutoSize = true;
      this.label31.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label31.Location = new Point(189, 165);
      this.label31.Name = "label31";
      this.label31.Size = new Size(30, 12);
      this.label31.TabIndex = 62;
      this.label31.Text = "RPois";
      this.textBox_MobName.Location = new Point(46, 18);
      this.textBox_MobName.Name = "textBox_MobName";
      this.textBox_MobName.Size = new Size(232, 21);
      this.textBox_MobName.TabIndex = 4;
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label20.Location = new Point(189, 141);
      this.label20.Name = "label20";
      this.label20.Size = new Size(33, 12);
      this.label20.TabIndex = 57;
      this.label20.Text = "RWind";
      this.label21.AutoSize = true;
      this.label21.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label21.Location = new Point(189, 93);
      this.label21.Name = "label21";
      this.label21.Size = new Size(33, 12);
      this.label21.TabIndex = 56;
      this.label21.Text = "MaxIS";
      this.label22.AutoSize = true;
      this.label22.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label22.Location = new Point(189, 69);
      this.label22.Name = "label22";
      this.label22.Size = new Size(41, 12);
      this.label22.TabIndex = 55;
      this.label22.Text = "MoneyR";
      this.label23.AutoSize = true;
      this.label23.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label23.Location = new Point(189, 45);
      this.label23.Name = "label23";
      this.label23.Size = new Size(31, 12);
      this.label23.TabIndex = 54;
      this.label23.Text = "ItemR";
      this.label24.AutoSize = true;
      this.label24.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label24.Location = new Point(189, 117);
      this.label24.Name = "label24";
      this.label24.Size = new Size(28, 12);
      this.label24.TabIndex = 53;
      this.label24.Text = "Attrib";
      this.label25.AutoSize = true;
      this.label25.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label25.Location = new Point(94, 237);
      this.label25.Name = "label25";
      this.label25.Size = new Size(42, 12);
      this.label25.TabIndex = 52;
      this.label25.Text = "RegTime";
      this.label26.AutoSize = true;
      this.label26.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label26.Location = new Point(94, 213);
      this.label26.Name = "label26";
      this.label26.Size = new Size(41, 12);
      this.label26.TabIndex = 51;
      this.label26.Text = "A.Speed";
      this.label27.AutoSize = true;
      this.label27.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label27.Location = new Point(94, 193);
      this.label27.Name = "label27";
      this.label27.Size = new Size(37, 12);
      this.label27.TabIndex = 50;
      this.label27.Text = "MovSP";
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label19.Location = new Point(94, 165);
      this.label19.Name = "label19";
      this.label19.Size = new Size(42, 12);
      this.label19.TabIndex = 41;
      this.label19.Text = "V.Range";
      this.label18.AutoSize = true;
      this.label18.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label18.Location = new Point(94, 141);
      this.label18.Name = "label18";
      this.label18.Size = new Size(42, 12);
      this.label18.TabIndex = 40;
      this.label18.Text = "A.Range";
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label17.Location = new Point(94, 117);
      this.label17.Name = "label17";
      this.label17.Size = new Size(35, 12);
      this.label17.TabIndex = 39;
      this.label17.Text = "A.Type";
      this.label16.AutoSize = true;
      this.label16.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label16.Location = new Point(94, 93);
      this.label16.Name = "label16";
      this.label16.Size = new Size(30, 12);
      this.label16.TabIndex = 38;
      this.label16.Text = "Move";
      this.label15.AutoSize = true;
      this.label15.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label15.Location = new Point(93, 69);
      this.label15.Name = "label15";
      this.label15.Size = new Size(41, 12);
      this.label15.TabIndex = 37;
      this.label15.Text = "Success";
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label14.Location = new Point(93, 45);
      this.label14.Name = "label14";
      this.label14.Size = new Size(33, 12);
      this.label14.TabIndex = 36;
      this.label14.Text = "Attack";
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label13.Location = new Point(1, 237);
      this.label13.Name = "label13";
      this.label13.Size = new Size(39, 12);
      this.label13.TabIndex = 35;
      this.label13.Text = "MagDef";
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label12.Location = new Point(3, 213);
      this.label12.Name = "label12";
      this.label12.Size = new Size(20, 12);
      this.label12.TabIndex = 34;
      this.label12.Text = "Def";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label11.Location = new Point(3, 189);
      this.label11.Name = "label11";
      this.label11.Size = new Size(44, 12);
      this.label11.TabIndex = 33;
      this.label11.Text = "MaxDmg";
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label10.Location = new Point(3, 165);
      this.label10.Name = "label10";
      this.label10.Size = new Size(41, 12);
      this.label10.TabIndex = 32;
      this.label10.Text = "MinDmg";
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label9.Location = new Point(3, 141);
      this.label9.Name = "label9";
      this.label9.Size = new Size(20, 12);
      this.label9.TabIndex = 31;
      this.label9.Text = "MP";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label8.Location = new Point(3, 117);
      this.label8.Name = "label8";
      this.label8.Size = new Size(18, 12);
      this.label8.TabIndex = 30;
      this.label8.Text = "HP";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label7.Location = new Point(3, 93);
      this.label7.Name = "label7";
      this.label7.Size = new Size(28, 12);
      this.label7.TabIndex = 29;
      this.label7.Text = "Level";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label6.Location = new Point(3, 69);
      this.label6.Name = "label6";
      this.label6.Size = new Size(25, 12);
      this.label6.TabIndex = 28;
      this.label6.Text = "Rate";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 6.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.label5.Location = new Point(3, 45);
      this.label5.Name = "label5";
      this.label5.Size = new Size(15, 12);
      this.label5.TabIndex = 27;
      this.label5.Text = "ID";
      this.listBox2.FormattingEnabled = true;
      this.listBox2.ItemHeight = 12;
      this.listBox2.Location = new Point(0, -55);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new Size(287, 52);
      this.listBox2.TabIndex = 9;
      this.button_UpdateMonster.Location = new Point(101, 279);
      this.button_UpdateMonster.Name = "button_UpdateMonster";
      this.button_UpdateMonster.Size = new Size(182, 19);
      this.button_UpdateMonster.TabIndex = 32;
      this.button_UpdateMonster.Text = "Update Mob Stats";
      this.button_UpdateMonster.UseVisualStyleBackColor = true;
      this.button_UpdateMonster.Click += new EventHandler(this.button_UpdateMonster_Click);
      this.listBox_MobsOnMap.FormattingEnabled = true;
      this.listBox_MobsOnMap.ItemHeight = 12;
      this.listBox_MobsOnMap.Location = new Point(6, 18);
      this.listBox_MobsOnMap.Name = "listBox_MobsOnMap";
      this.listBox_MobsOnMap.Size = new Size(132, 112);
      this.listBox_MobsOnMap.TabIndex = 1;
      this.listBox_MobsOnMap.SelectedIndexChanged += new EventHandler(this.listBox_MobsOnMap_SelectedIndexChanged);
      this.groupBox3.Controls.Add((Control) this.groupBox6);
      this.groupBox3.Controls.Add((Control) this.listBox_Map);
      this.groupBox3.Location = new Point(12, 25);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(299, 193);
      this.groupBox3.TabIndex = 8;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Map Selection";
      this.groupBox6.Controls.Add((Control) this.button_RemoveMobOnMap);
      this.groupBox6.Controls.Add((Control) this.listBox_MobsOnMap);
      this.groupBox6.Location = new Point(149, 13);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(144, 172);
      this.groupBox6.TabIndex = 9;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Mobs on Selected Map";
      this.button_RemoveMobOnMap.Location = new Point(6, 135);
      this.button_RemoveMobOnMap.Name = "button_RemoveMobOnMap";
      this.button_RemoveMobOnMap.Size = new Size(132, 29);
      this.button_RemoveMobOnMap.TabIndex = 2;
      this.button_RemoveMobOnMap.Text = "Remove";
      this.button_RemoveMobOnMap.UseVisualStyleBackColor = true;
      this.button_RemoveMobOnMap.Click += new EventHandler(this.button_RemoveMobOnMap_Click);
      this.pictureBox_Map.BackgroundImageLayout = ImageLayout.Stretch;
      this.pictureBox_Map.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_Map.Cursor = Cursors.Cross;
      this.pictureBox_Map.Location = new Point(323, 39);
      this.pictureBox_Map.Name = "pictureBox_Map";
      this.pictureBox_Map.Size = new Size(765, 706);
      this.pictureBox_Map.TabIndex = 1;
      this.pictureBox_Map.TabStop = false;
      this.pictureBox_Map.MouseClick += new MouseEventHandler(this.pictureBox_Map_MouseClick);
      this.pictureBox_Map.MouseDown += new MouseEventHandler(this.pictureBox_Map_MouseDown);
      this.pictureBox_Map.MouseMove += new MouseEventHandler(this.pictureBox_Map_MouseMove);
      this.pictureBox_Map.MouseUp += new MouseEventHandler(this.pictureBox_Map_MouseUp);
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.fileToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1091, 25);
      this.menuStrip1.TabIndex = 9;
      this.menuStrip1.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.saveAsToolStripMenuItem
      });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(39, 21);
      this.fileToolStripMenuItem.Text = "File";
      this.saveAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.monsterSetBasetxtToolStripMenuItem_Save,
        (ToolStripItem) this.monstertxtToolStripMenuItem_Save
      });
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new Size(129, 22);
      this.saveAsToolStripMenuItem.Text = "Save (As)";
      this.monsterSetBasetxtToolStripMenuItem_Save.Name = "monsterSetBasetxtToolStripMenuItem_Save";
      this.monsterSetBasetxtToolStripMenuItem_Save.Size = new Size(188, 22);
      this.monsterSetBasetxtToolStripMenuItem_Save.Text = "MonsterSetBase.txt";
      this.monsterSetBasetxtToolStripMenuItem_Save.Click += new EventHandler(this.monsterSetBasetxtToolStripMenuItem_Save_Click);
      this.monstertxtToolStripMenuItem_Save.Name = "monstertxtToolStripMenuItem_Save";
      this.monstertxtToolStripMenuItem_Save.Size = new Size(188, 22);
      this.monstertxtToolStripMenuItem_Save.Text = "Monster.txt";
      this.monstertxtToolStripMenuItem_Save.Click += new EventHandler(this.monstertxtToolStripMenuItem_Save_Click);
      this.checkBox_HideMobs.AutoSize = true;
      this.checkBox_HideMobs.Location = new Point(323, 25);
      this.checkBox_HideMobs.Name = "checkBox_HideMobs";
      this.checkBox_HideMobs.Size = new Size(78, 16);
      this.checkBox_HideMobs.TabIndex = 10;
      this.checkBox_HideMobs.Text = "Hide Mobs";
      this.checkBox_HideMobs.UseVisualStyleBackColor = true;
      this.checkBox_HideMobs.CheckedChanged += new EventHandler(this.checkBox_HideMobs_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new Size(1091, 747);
      this.Controls.Add((Control) this.pictureBox_Map);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.checkBox_HideMobs);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = nameof (MSBEditor);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Monster & MonsterSetBase Editor";
      this.FormClosed += new FormClosedEventHandler(this.MSBEditor_FormClosed);
      this.Load += new EventHandler(this.MSBEditor_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.pictureBox_MobPreview).EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.numericUpDown_Total.EndInit();
      this.numericUpDown_Distance.EndInit();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.numericUpDown_ElemDef.EndInit();
      this.numericUpDown_MaxElem.EndInit();
      this.numericUpDown_MinElem.EndInit();
      this.numericUpDown_Element.EndInit();
      this.numericUpDown_RFire.EndInit();
      this.numericUpDown_RWtr.EndInit();
      this.numericUpDown_RIce.EndInit();
      this.numericUpDown_RPois.EndInit();
      this.numericUpDown_RWind.EndInit();
      this.numericUpDown_Attrib.EndInit();
      this.numericUpDown_MaxIS.EndInit();
      this.numericUpDown_MoneyR.EndInit();
      this.numericUpDown_ItemR.EndInit();
      this.numericUpDown_RegTime.EndInit();
      this.numericUpDown_ASpeed.EndInit();
      this.numericUpDown_MoveSP.EndInit();
      this.numericUpDown_VRange.EndInit();
      this.numericUpDown_ARange.EndInit();
      this.numericUpDown_AType.EndInit();
      this.numericUpDown_Move.EndInit();
      this.numericUpDown_Success.EndInit();
      this.numericUpDown_Attack.EndInit();
      this.numericUpDown_MagicDef.EndInit();
      this.numericUpDown_MaxDmg.EndInit();
      this.numericUpDown_Def.EndInit();
      this.numericUpDown_MinDmg.EndInit();
      this.numericUpDown_HP.EndInit();
      this.numericUpDown_MP.EndInit();
      this.numericUpDown_Level.EndInit();
      this.numericUpDown_ID.EndInit();
      this.numericUpDown_Rate.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox6.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox_Map).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void listBox_Map_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(!this.isWorking & this.listBox_Map.SelectedIndex != -1))
        return;
      this.DisposedUnusedControls();
      this.LastPicBox = (Structures.CustomPictureBox) null;
      this.isWorking = true;
      this.pictureBox_Map.Controls.Clear();
      this.pictureBox_Map.BackgroundImage = (Image) Resources.ResourceManager.GetObject(((Structures.Map) this.listBox_Map.SelectedItem).MapName.Replace(' ', '_').Replace('-', '_'));
      this.MobsOnMap = new BindingList<Structures.MSB>();
      foreach (Structures.MSB mMSB in this.MonsterSetBase)
      {
        if (mMSB.MapID == (int) this.listBox_Map.SelectedValue)
        {
          this.MobsOnMap.Add(mMSB);
          this.AddMobToMap(mMSB);
        }
      }
      this.listBox_MobsOnMap.DataBindings.Clear();
      this.listBox_MobsOnMap.DataSource = (object) null;
      this.listBox_MobsOnMap.DisplayMember = "MobName";
      this.listBox_MobsOnMap.ValueMember = "MobID";
      this.listBox_MobsOnMap.DataSource = (object) this.MobsOnMap;
      this.isWorking = false;
      if (this.listBox_MobsOnMap.Items.Count > 0)
      {
        this.listBox_MobsOnMap.SelectedIndex = -1;
        this.listBox_MobsOnMap.SelectedIndex = 0;
      }
      this.checkBox_HideMobs.Checked = false;
    }

    private void listBox_Mob_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.listBox_Mob.SelectedItem == null)
        return;
      Structures.Monster selectedItem = (Structures.Monster) this.listBox_Mob.SelectedItem;
      this.textBox_MobName.Text = selectedItem.Name;
      this.numericUpDown_ID.Value = (Decimal) selectedItem.ID;
      this.numericUpDown_Rate.Value = (Decimal) selectedItem.Rate;
      this.numericUpDown_Level.Value = (Decimal) selectedItem.Level;
      this.numericUpDown_HP.Value = (Decimal) selectedItem.HP;
      this.numericUpDown_MP.Value = (Decimal) selectedItem.MP;
      this.numericUpDown_MinDmg.Value = (Decimal) selectedItem.MinDmg;
      this.numericUpDown_MaxDmg.Value = (Decimal) selectedItem.MaxDmg;
      this.numericUpDown_Def.Value = (Decimal) selectedItem.Def;
      this.numericUpDown_MagicDef.Value = (Decimal) selectedItem.MagDef;
      this.numericUpDown_Attack.Value = (Decimal) selectedItem.AtkPower;
      this.numericUpDown_Success.Value = (Decimal) selectedItem.AtkSucRate;
      this.numericUpDown_Move.Value = (Decimal) selectedItem.Move;
      this.numericUpDown_AType.Value = (Decimal) selectedItem.AType;
      this.numericUpDown_ARange.Value = (Decimal) selectedItem.ARange;
      this.numericUpDown_VRange.Value = (Decimal) selectedItem.VRange;
      this.numericUpDown_MoveSP.Value = (Decimal) selectedItem.MovSP;
      this.numericUpDown_ASpeed.Value = (Decimal) selectedItem.ASpeed;
      this.numericUpDown_RegTime.Value = (Decimal) selectedItem.RegTime;
      this.numericUpDown_ItemR.Value = (Decimal) selectedItem.ItemR;
      this.numericUpDown_MoneyR.Value = (Decimal) selectedItem.MoneyR;
      this.numericUpDown_MaxIS.Value = (Decimal) selectedItem.MaxIS;
      this.numericUpDown_Attrib.Value = (Decimal) selectedItem.Attrib;
      this.numericUpDown_RWind.Value = (Decimal) selectedItem.RWind;
      this.numericUpDown_RPois.Value = (Decimal) selectedItem.RPois;
      this.numericUpDown_RIce.Value = (Decimal) selectedItem.RIce;
      this.numericUpDown_RWtr.Value = (Decimal) selectedItem.RWtr;
      this.numericUpDown_RFire.Value = (Decimal) selectedItem.RFire;
      this.numericUpDown_Element.Value = (Decimal) selectedItem.Element;
      this.numericUpDown_MaxElem.Value = (Decimal) selectedItem.MaxElem;
      this.numericUpDown_MinElem.Value = (Decimal) selectedItem.MinElem;
      this.numericUpDown_ElemDef.Value = (Decimal) selectedItem.ElemDef;
    }

    private void listBox_MobsOnMap_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(!this.isWorking & this.listBox_MobsOnMap.SelectedIndex != -1))
        return;
      if (this.LastPicBox != null)
      {
        if (this.LastPicBox.BackColor != Color.Transparent)
        {
          this.LastPicBox.Size = new Size(3, 3);
          this.LastPicBox.BorderColor = Color.Transparent;
          this.LastPicBox.BackColor = this.LastBackColor;
        }
        else
          this.LastPicBox.BorderColor = this.LastBorderColor;
        if (this.LastPicBox.MSBType == 3 || this.LastPicBox.MSBType == 1)
          this.LastPicBox.SendToBack();
      }
      Structures.MSB selectedItem = (Structures.MSB) this.listBox_MobsOnMap.SelectedItem;
      Structures.CustomPictureBox control = (Structures.CustomPictureBox) this.pictureBox_Map.Controls[this.pictureBox_Map.Controls.IndexOfKey(selectedItem.UniKey)];
      this.listBox_Mob.SelectedValue = (object) selectedItem.MobID;
      this.LastBackColor = control.BackColor;
      this.LastBorderColor = control.BorderColor;
      if (control.BorderColor != Color.Transparent)
      {
        control.BorderColor = Color.GhostWhite;
      }
      else
      {
        control.BackColor = Color.GhostWhite;
        control.Size = new Size(9, 9);
      }
      control.BringToFront();
      this.LastPicBox = control;
      this.LastPicBox.MSBType = selectedItem.Type;
      this.pictureBox_Map.Invalidate();
    }

    private void monsterSetBasetxtToolStripMenuItem_Save_Click(object sender, EventArgs e)
    {
      string str = "Saved Data\\MonsterSetBase Editor\\MonsterSetBase\\" + DateTime.Now.ToLocalTime().ToString().Replace('/', '.').Replace(':', '-').Replace(" ", " [") + "]";
      Directory.CreateDirectory(str);
      string fName = str + "\\MonsterSetBase.txt";
      if (!this.SaveMonsterSetBaseFile(fName) || MessageBox.Show("File saved successfully in\n\"" + fName + "\"\n\nOpen containing folder?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(str);
    }

    private void monstertxtToolStripMenuItem_Save_Click(object sender, EventArgs e)
    {
      string str = "Saved Data\\MonsterSetBase Editor\\Monster\\" + DateTime.Now.ToLocalTime().ToString().Replace('/', '.').Replace(':', '-').Replace(" ", " [") + "]";
      Directory.CreateDirectory(str);
      string fName = str + "\\Monster.txt";
      if (!this.SaveMonsterFile(fName) || MessageBox.Show("File saved successfully in\n\"" + fName + "\"\n\nOpen containing folder?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(str);
    }

    private void MSBEditor_FormClosed(object sender, FormClosedEventArgs e) => Application.OpenForms["Form1"].WindowState = FormWindowState.Normal;

    private void MSBEditor_Load(object sender, EventArgs e)
    {
      if (Screen.PrimaryScreen.Bounds.Size.Height < this.Size.Height || Screen.PrimaryScreen.Bounds.Size.Width < this.Size.Width)
      {
        this.Size = new Size(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);
        this.Location = new Point(0, 0);
      }
      this.g = this.pictureBox_Map.CreateGraphics();
      this.isWorking = true;
      this.strct.initMapListBox(ref this.listBox_Map);
      this.isWorking = false;
      this.ReadMonsterFile("Data\\MSB\\Monster.txt");
      this.ReadMSBFile("Data\\MSB\\MonsterSetBase.txt");
      if (this.listBox_Map.Items.Count > 0)
      {
        this.listBox_Map.SelectedIndex = -1;
        this.listBox_Map.SelectedIndex = 0;
      }
      if (this.listBox_MobsOnMap.Items.Count > 0)
      {
        this.listBox_MobsOnMap.SelectedIndex = -1;
        this.listBox_MobsOnMap.SelectedIndex = 0;
      }
      Application.OpenForms["Form1"].WindowState = FormWindowState.Minimized;
      this.WindowState = FormWindowState.Normal;
      this.TopMost = true;
      this.TopMost = false;
      this.BringToFront();
      this.Focus();
      this.Focus();
    }

    private void p_MouseClick(object sender, MouseEventArgs e)
    {
      PictureBox pictureBox = (PictureBox) sender;
      if (e.Button != MouseButtons.Left)
        return;
      foreach (Structures.MSB mobsOn in (Collection<Structures.MSB>) this.MobsOnMap)
      {
        if (mobsOn.UniKey == pictureBox.Name)
        {
          this.listBox_MobsOnMap.SelectedItem = (object) mobsOn;
          break;
        }
      }
    }

    private void pictureBox_Map_MouseClick(object sender, MouseEventArgs e)
    {
      if (this.SelectedMSBType == 1 || this.SelectedMSBType == 3)
        return;
      Structures.Monster selectedItem = (Structures.Monster) this.listBox_Mob.SelectedItem;
      Structures.MSB mMSB = new Structures.MSB()
      {
        Dis = (int) this.numericUpDown_Distance.Value,
        MapID = (int) this.listBox_Map.SelectedValue,
        MobID = selectedItem.ID,
        MobName = selectedItem.Name,
        Type = this.SelectedMSBType,
        UniKey = this.GetUniqueKey(),
        Y = e.Location.X / 3,
        X = e.Location.Y / 3
      };
      mMSB.FileDesc = "//" + mMSB.MobName;
      mMSB.ToolTipInfo = "\bName:\t\t" + mMSB.MobName + "\nID:\t\t" + (object) mMSB.MobID + "\nSpot Type:\t";
      // ISSUE: explicit reference operation
      (^ref mMSB).ToolTipInfo += mMSB.Type == 0 ? "(0) NPC" : (mMSB.Type == 1 ? "(1) Multiple" : (mMSB.Type == 2 ? "(2) Standard" : (mMSB.Type == 3 ? "(3) Multiple" : (mMSB.Type == 4 ? "(4) Event" : "NULL"))));
      ref Structures.MSB local = ref mMSB;
      local.ToolTipInfo = local.ToolTipInfo + "\nSpawn Radius:\t" + (object) mMSB.Dis;
      switch (this.SelectedMSBType)
      {
        case 0:
        case 2:
          mMSB.Dir = this.SelectedDir;
          mMSB.ToolTipInfo = mMSB.ToolTipInfo + "\nDirection:\t" + (object) mMSB.Dir;
          break;
        case 4:
          mMSB.Total = (int) this.numericUpDown_Total.Value;
          mMSB.ToolTipInfo = mMSB.ToolTipInfo + "\nTotal Mobs:\t" + (object) mMSB.Total;
          break;
      }
      mMSB.ToolTipInfo = mMSB.ToolTipInfo + "\nX:\t" + (object) mMSB.X;
      mMSB.ToolTipInfo = mMSB.ToolTipInfo + "\tY:\t" + (object) mMSB.Y;
      this.MonsterSetBase.Add(mMSB);
      this.AddMobToMap(mMSB);
      this.MobsOnMap.Add(mMSB);
    }

    private void pictureBox_Map_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.SelectedMSBType != 1 && this.SelectedMSBType != 3)
        return;
      this.mouseDrag = 1;
      this.StartY = e.Location.X / 3;
      this.StartX = e.Location.Y / 3;
      this.PanelPreview = new Structures.CustomPictureBox();
      this.PanelPreview.Size = new Size(0, 0);
      this.PanelPreview.Location = e.Location;
      this.PanelPreview.BackColor = Color.Transparent;
      this.PanelPreview.BorderColor = Color.GhostWhite;
      this.pictureBox_Map.Controls.Add((Control) this.PanelPreview);
    }

    private void pictureBox_Map_MouseMove(object sender, MouseEventArgs e)
    {
      if (((this.SelectedMSBType == 1 ? 1 : (this.SelectedMSBType == 3 ? 1 : 0)) & (this.mouseDrag == 1 ? 1 : 0)) == 0 || !(this.PanelPreview.Location.X < e.Location.X & this.PanelPreview.Location.Y < e.Location.Y))
        return;
      this.PanelPreview.Size = new Size(e.Location.X - this.PanelPreview.Location.X, e.Location.Y - this.PanelPreview.Location.Y);
      this.pictureBox_Map.Invalidate();
    }

    private void pictureBox_Map_MouseUp(object sender, MouseEventArgs e)
    {
      this.mouseDrag = 0;
      if (this.SelectedMSBType != 1 && this.SelectedMSBType != 3)
        return;
      this.pictureBox_Map.Controls.Remove((Control) this.PanelPreview);
      this.PanelPreview = new Structures.CustomPictureBox();
      Structures.Monster selectedItem = (Structures.Monster) this.listBox_Mob.SelectedItem;
      Structures.MSB mMSB = new Structures.MSB()
      {
        Dis = (int) this.numericUpDown_Distance.Value,
        MapID = (int) this.listBox_Map.SelectedValue,
        MobID = selectedItem.ID,
        MobName = selectedItem.Name,
        Type = this.SelectedMSBType,
        UniKey = this.GetUniqueKey(),
        EndY = e.Location.X / 3,
        EndX = e.Location.Y / 3,
        X = this.StartX,
        Y = this.StartY,
        Dir = this.SelectedDir,
        Total = (int) this.numericUpDown_Total.Value
      };
      mMSB.FileDesc = "//" + mMSB.MobName;
      mMSB.ToolTipInfo = "\bName:\t\t" + mMSB.MobName + "\nID:\t\t" + (object) mMSB.MobID + "\nDirection:\t" + (object) mMSB.Dir + "\nSpot Type:\t";
      // ISSUE: explicit reference operation
      (^ref mMSB).ToolTipInfo += mMSB.Type == 0 ? "(0) NPC" : (mMSB.Type == 1 ? "(1) Multiple" : (mMSB.Type == 2 ? "(2) Standard" : (mMSB.Type == 3 ? "(3) Multiple" : (mMSB.Type == 4 ? "(4) Event" : "NULL"))));
      ref Structures.MSB local1 = ref mMSB;
      local1.ToolTipInfo = local1.ToolTipInfo + "\nSpawn Radius:\t" + (object) mMSB.Dis;
      ref Structures.MSB local2 = ref mMSB;
      local2.ToolTipInfo = local2.ToolTipInfo + "\nTotal Mobs:\t" + (object) mMSB.Total;
      ref Structures.MSB local3 = ref mMSB;
      local3.ToolTipInfo = local3.ToolTipInfo + "\nStart X:\t" + (object) mMSB.X;
      ref Structures.MSB local4 = ref mMSB;
      local4.ToolTipInfo = local4.ToolTipInfo + "\tStart Y:\t" + (object) mMSB.Y;
      ref Structures.MSB local5 = ref mMSB;
      local5.ToolTipInfo = local5.ToolTipInfo + "\nEnd X:\t" + (object) mMSB.EndX;
      ref Structures.MSB local6 = ref mMSB;
      local6.ToolTipInfo = local6.ToolTipInfo + "\tEnd Y:\t" + (object) mMSB.EndY;
      this.MonsterSetBase.Add(mMSB);
      this.AddMobToMap(mMSB);
      this.MobsOnMap.Add(mMSB);
    }

    private void radioButton_Dir_Negtive1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioButton_Dir_1.Checked)
      {
        this.label_Dir.Text = "1";
        this.SelectedDir = 1;
      }
      else if (this.radioButton_Dir_2.Checked)
      {
        this.label_Dir.Text = "2";
        this.SelectedDir = 2;
      }
      else if (this.radioButton_Dir_3.Checked)
      {
        this.label_Dir.Text = "3";
        this.SelectedDir = 3;
      }
      else if (this.radioButton_Dir_4.Checked)
      {
        this.label_Dir.Text = "4";
        this.SelectedDir = 4;
      }
      else if (this.radioButton_Dir_5.Checked)
      {
        this.label_Dir.Text = "5";
        this.SelectedDir = 5;
      }
      else if (this.radioButton_Dir_6.Checked)
      {
        this.label_Dir.Text = "6";
        this.SelectedDir = 6;
      }
      else if (this.radioButton_Dir_7.Checked)
      {
        this.label_Dir.Text = "7";
        this.SelectedDir = 7;
      }
      else if (this.radioButton_Dir_8.Checked)
      {
        this.label_Dir.Text = "8";
        this.SelectedDir = 8;
      }
      else
      {
        if (!this.radioButton_Dir_Negtive1.Checked)
          return;
        this.label_Dir.Text = "-1";
        this.SelectedDir = -1;
      }
    }

    private void radioButton_Type_1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioButton_Type_0.Checked)
        this.SelectedMSBType = 0;
      else if (this.radioButton_Type_1.Checked)
        this.SelectedMSBType = 1;
      else if (this.radioButton_Type_2.Checked)
        this.SelectedMSBType = 2;
      else if (this.radioButton_Type_3.Checked)
      {
        this.SelectedMSBType = 3;
      }
      else
      {
        if (!this.radioButton_Type_4.Checked)
          return;
        this.SelectedMSBType = 4;
      }
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
            this.MonsterDic.Add(monster.ID, monster.Name);
            this.Monster.Add(monster);
          }
        }
      }
      this.listBox_Mob.DataBindings.Clear();
      this.listBox_Mob.DataSource = (object) null;
      this.listBox_Mob.ValueMember = "ID";
      this.listBox_Mob.DisplayMember = "Name";
      this.listBox_Mob.DataSource = (object) this.Monster;
    }

    private void ReadMSBFile(string fName)
    {
      try
      {
        string[] strArray = File.ReadAllLines(fName);
        int num = 0;
        foreach (string str in strArray)
        {
          if (!str.StartsWith("end") & !str.StartsWith("//") & str.Length != 0)
          {
            string[] source = str.Split('/');
            string line = source[0].Replace(" ", "\t");
            if (line.Length == 1 || line.Replace("\t", string.Empty).Length == 1)
            {
              num = Convert.ToInt32(line);
            }
            else
            {
              string empty = string.Empty;
              if (((IEnumerable<string>) source).Contains<string>("//"))
                empty = source[2];
              string[] trimmedSplitString = this.GetTrimmedSplitString(line);
              if (trimmedSplitString != null)
              {
                Structures.MSB msb = new Structures.MSB();
                switch (num)
                {
                  case 0:
                  case 2:
                    msb.Type = 0;
                    msb.MobID = Convert.ToInt32(trimmedSplitString[0]);
                    msb.MapID = Convert.ToInt32(trimmedSplitString[1]);
                    msb.Dis = Convert.ToInt32(trimmedSplitString[2]);
                    msb.X = Convert.ToInt32(trimmedSplitString[3]);
                    msb.Y = Convert.ToInt32(trimmedSplitString[4]);
                    msb.Dir = Convert.ToInt32(trimmedSplitString[5]);
                    break;
                  case 1:
                  case 3:
                    msb.Type = 1;
                    msb.MobID = Convert.ToInt32(trimmedSplitString[0]);
                    msb.MapID = Convert.ToInt32(trimmedSplitString[1]);
                    msb.Dis = Convert.ToInt32(trimmedSplitString[2]);
                    msb.X = Convert.ToInt32(trimmedSplitString[3]);
                    msb.Y = Convert.ToInt32(trimmedSplitString[4]);
                    msb.EndX = Convert.ToInt32(trimmedSplitString[5]);
                    msb.EndY = Convert.ToInt32(trimmedSplitString[6]);
                    msb.Dir = Convert.ToInt32(trimmedSplitString[7]);
                    msb.Total = Convert.ToInt32(trimmedSplitString[8]);
                    break;
                  case 4:
                    msb.Type = 0;
                    msb.MobID = Convert.ToInt32(trimmedSplitString[0]);
                    msb.MapID = Convert.ToInt32(trimmedSplitString[1]);
                    msb.Dis = Convert.ToInt32(trimmedSplitString[2]);
                    msb.X = Convert.ToInt32(trimmedSplitString[3]);
                    msb.Y = Convert.ToInt32(trimmedSplitString[4]);
                    msb.Total = Convert.ToInt32(trimmedSplitString[5]);
                    break;
                }
                msb.FileDesc = empty;
                if (this.MonsterDic.ContainsKey(msb.MobID))
                  msb.MobName = this.MonsterDic[msb.MobID];
                msb.UniKey = this.GetUniqueKey();
                msb.ToolTipInfo = "\bName:\t\t" + msb.MobName + "\nID:\t\t" + (object) msb.MobID + "\nDirection:\t" + (object) msb.Dir + "\nSpot Type:\t";
                msb.ToolTipInfo += msb.Type == 0 ? "(0) NPC" : (msb.Type == 1 ? "(1) Multiple" : (msb.Type == 2 ? "(2) Standard" : (msb.Type == 3 ? "(3) Multiple" : (msb.Type == 4 ? "(4) Event" : "NULL"))));
                msb.ToolTipInfo = msb.ToolTipInfo + "\nSpawn Radius:\t" + (object) msb.Dis;
                msb.ToolTipInfo = msb.ToolTipInfo + "\nTotal Mobs:\t" + (object) msb.Total;
                msb.ToolTipInfo = msb.ToolTipInfo + "\nStart X:\t" + (object) msb.X;
                msb.ToolTipInfo = msb.ToolTipInfo + "\tStart Y:\t" + (object) msb.Y;
                msb.ToolTipInfo = msb.ToolTipInfo + "\nEnd X:\t" + (object) msb.EndX;
                msb.ToolTipInfo = msb.ToolTipInfo + "\tEnd Y:\t" + (object) msb.EndY;
                this.MonsterSetBase.Add(msb);
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.StackTrace.Split(':')[2], "MonsterSetBase.txt Read Error");
      }
    }

    private bool SaveMonsterFile(string fName)
    {
      StreamWriter streamWriter = new StreamWriter(fName);
      try
      {
        streamWriter.AutoFlush = true;
        streamWriter.WriteLine("//Generated by MU.ToolKit coded by TopReal.IT");
        streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
        streamWriter.WriteLine("//No.\tRate\tName\t\t\tLVL\tHP\tMP\tMinDmg\tMaxDmg\tDef\tMagDef\tAttack \tSuccess\tMove\tA.Type\tA.Range\tV.Range\tMovSP\tA.Speed\tRegTime\tAttrib\tItemR\tMoneyR\tMaxIS\tRWind\tRPois\tRIce\tRWtr\tRFire\tEl\tElMin\tElMax\tElDef");
        streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
        int a = 1;
        foreach (Structures.Monster monster in (Collection<Structures.Monster>) this.Monster)
        {
          int result = 0;
          Math.DivRem(a, 20, out result);
          if (result == 0)
          {
            streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
            streamWriter.WriteLine("//No.\tRate\tName\t\t\tLVL\tHP\tMP\tMinDmg\tMaxDmg\tDef\tMagDef\tAttack \tSuccess\tMove\tA.Type\tA.Range\tV.Range\tMovSP\tA.Speed\tRegTime\tAttrib\tItemR\tMoneyR\tMaxIS\tRWind\tRPois\tRIce\tRWtr\tRFire\tEl\tElMin\tElMax\tElDef");
            streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
          }
          streamWriter.WriteLine("{0}\t{1}\t{2}\t\t\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}\t{18}\t{19}\t{20}\t{21}\t{22}\t{23}\t{24}\t{25}\t{26}\t{27}\t{28}\t{29}\t{30}\t{31}", (object) monster.ID.ToString(), (object) monster.Rate.ToString(), (object) ("\"" + monster.Name + "\"".ToString()), (object) monster.Level.ToString(), (object) monster.HP.ToString(), (object) monster.MP.ToString(), (object) monster.MinDmg.ToString(), (object) monster.MaxDmg.ToString(), (object) monster.Def.ToString(), (object) monster.MagDef.ToString(), (object) monster.AtkPower.ToString(), (object) monster.AtkSucRate.ToString(), (object) monster.Move.ToString(), (object) monster.AType.ToString(), (object) monster.ARange.ToString(), (object) monster.VRange.ToString(), (object) monster.MovSP.ToString(), (object) monster.ASpeed.ToString(), (object) monster.RegTime.ToString(), (object) monster.Attrib.ToString(), (object) monster.ItemR.ToString(), (object) monster.MoneyR.ToString(), (object) monster.MaxIS.ToString(), (object) monster.RWind.ToString(), (object) monster.RPois.ToString(), (object) monster.RIce.ToString(), (object) monster.RWtr.ToString(), (object) monster.RFire, (object) monster.Element.ToString(), (object) monster.MinElem.ToString(), (object) monster.MaxElem.ToString(), (object) monster.ElemDef.ToString());
          ++a;
        }
        streamWriter.WriteLine("end");
        streamWriter.Close();
        return true;
      }
      catch
      {
        streamWriter.Close();
        return false;
      }
    }

    private bool SaveMonsterSetBaseFile(string fName)
    {
      StreamWriter streamWriter = new StreamWriter(fName);
      try
      {
        streamWriter.AutoFlush = true;
        streamWriter.WriteLine("//Generated by MU.ToolKit coded by TopReal.IT");
        this.MonsterSetBase.Sort();
        int mapId = this.MonsterSetBase[0].MapID;
        streamWriter.WriteLine();
        streamWriter.WriteLine("// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        streamWriter.WriteLine("// =========== MapID: {0}", (object) mapId);
        streamWriter.WriteLine("// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        streamWriter.WriteLine();
        streamWriter.WriteLine("0");
        streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
        streamWriter.WriteLine("//Mob\tMap\tDis\tX\tY\tDir\tName");
        streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
        int num = 0;
        foreach (Structures.MSB msb in this.MonsterSetBase)
        {
          if (msb.MapID != mapId)
          {
            streamWriter.WriteLine();
            streamWriter.WriteLine("// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            streamWriter.WriteLine("// =========== MapID: {0}", (object) msb.MapID);
            streamWriter.WriteLine("// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            streamWriter.WriteLine();
          }
          if (msb.Type == num)
          {
            switch (msb.Type)
            {
              case 0:
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t//{6}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.Dir, (object) msb.MobName);
                break;
              case 1:
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t//{9}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.EndX, (object) msb.EndY, (object) msb.Dir, (object) msb.Total, (object) msb.MobName);
                break;
              case 2:
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t//{6}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.Dir, (object) msb.MobName);
                break;
              case 3:
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t//{9}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.EndX, (object) msb.EndY, (object) msb.Dir, (object) msb.Total, (object) msb.MobName);
                break;
              case 4:
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t//{6}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.Total, (object) msb.MobName);
                break;
            }
          }
          else
          {
            switch (msb.Type)
            {
              case 0:
                streamWriter.WriteLine("end");
                streamWriter.WriteLine();
                streamWriter.WriteLine("0");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("//Mob\tMap\tDis\tX\tY\tDir\tName");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t//{6}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.Dir, (object) msb.MobName);
                break;
              case 1:
                streamWriter.WriteLine("end");
                streamWriter.WriteLine();
                streamWriter.WriteLine("1");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("//Mob\tMap\tDis\tsX\tsY\teX\teY\tDir\tTotal\tName");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t//{9}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.EndX, (object) msb.EndY, (object) msb.Dir, (object) msb.Total, (object) msb.MobName);
                break;
              case 2:
                streamWriter.WriteLine("end");
                streamWriter.WriteLine();
                streamWriter.WriteLine("2");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("//Mob\tMap\tDis\tX\tY\tDir\tName");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t//{6}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.Dir, (object) msb.MobName);
                break;
              case 3:
                streamWriter.WriteLine("end");
                streamWriter.WriteLine();
                streamWriter.WriteLine("3");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("//Mob\tMap\tDis\tsX\tsY\teX\teY\tDir\tTotal\tName");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t//{9}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.EndX, (object) msb.EndY, (object) msb.Dir, (object) msb.Total, (object) msb.MobName);
                break;
              case 4:
                streamWriter.WriteLine("end");
                streamWriter.WriteLine();
                streamWriter.WriteLine("4");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("//Mob\tMap\tDis\tX\tY\tTotal\tName");
                streamWriter.WriteLine("// ==========================================================================================================================================================================================================================================");
                streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t//{6}", (object) msb.MobID, (object) msb.MapID, (object) msb.Dis, (object) msb.X, (object) msb.Y, (object) msb.Total, (object) msb.MobName);
                break;
            }
          }
          num = msb.Type;
          mapId = msb.MapID;
        }
        streamWriter.WriteLine("end");
        streamWriter.Close();
        return true;
      }
      catch
      {
        streamWriter.Close();
        return false;
      }
    }
  }
}
