// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.Form_CashShop_AddItems
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class Form_CashShop_AddItems : Form
  {
    public Button button_AddItemToDB;
    public Button button_NewItem_Add;
    private Button button_PackageItem_AddToList;
    private Button button_PackageItem_RemoveFromList;
    public Button button_UpdateExistingItem;
    private Button buttonClearAll_Multi;
    private List<Structures.c_AncientData> c_AncientDatas = new List<Structures.c_AncientData>();
    private List<Structures.c_AncientData> c_AncientDatas_M1 = new List<Structures.c_AncientData>();
    private List<Structures.c_AncientData> c_AncientDatas_M2 = new List<Structures.c_AncientData>();
    private List<Structures.c_AncientData> c_AncientDatas_M3 = new List<Structures.c_AncientData>();
    private List<Structures.c_AncientData> c_AncientDatas_M4 = new List<Structures.c_AncientData>();
    private List<Structures.c_AncientData> c_AncientDatas_M5 = new List<Structures.c_AncientData>();
    private List<Structures.c_AncientData> c_AncientDatas_M6 = new List<Structures.c_AncientData>();
    private List<Structures.c_LevelData> c_LevelDatas = new List<Structures.c_LevelData>();
    private List<Structures.c_LevelData> c_LevelDatas_M1 = new List<Structures.c_LevelData>();
    private List<Structures.c_LevelData> c_LevelDatas_M2 = new List<Structures.c_LevelData>();
    private List<Structures.c_LevelData> c_LevelDatas_M3 = new List<Structures.c_LevelData>();
    private List<Structures.c_LevelData> c_LevelDatas_M4 = new List<Structures.c_LevelData>();
    private List<Structures.c_LevelData> c_LevelDatas_M5 = new List<Structures.c_LevelData>();
    private List<Structures.c_LevelData> c_LevelDatas_M6 = new List<Structures.c_LevelData>();
    private List<Structures.c_OptionData> c_OptionDatas = new List<Structures.c_OptionData>();
    private List<Structures.c_OptionData> c_OptionDatas_M1 = new List<Structures.c_OptionData>();
    private List<Structures.c_OptionData> c_OptionDatas_M2 = new List<Structures.c_OptionData>();
    private List<Structures.c_OptionData> c_OptionDatas_M3 = new List<Structures.c_OptionData>();
    private List<Structures.c_OptionData> c_OptionDatas_M4 = new List<Structures.c_OptionData>();
    private List<Structures.c_OptionData> c_OptionDatas_M5 = new List<Structures.c_OptionData>();
    private List<Structures.c_OptionData> c_OptionDatas_M6 = new List<Structures.c_OptionData>();
    private CheckBox checkBox_AddItem_FOItem;
    public CheckBox checkBox_ExcOption1_Multi_1;
    public CheckBox checkBox_ExcOption1_Multi_2;
    public CheckBox checkBox_ExcOption1_Multi_3;
    public CheckBox checkBox_ExcOption1_Multi_4;
    public CheckBox checkBox_ExcOption1_Multi_5;
    public CheckBox checkBox_ExcOption1_Multi_6;
    public CheckBox checkBox_ExcOption2_Multi_1;
    public CheckBox checkBox_ExcOption2_Multi_2;
    public CheckBox checkBox_ExcOption2_Multi_3;
    public CheckBox checkBox_ExcOption2_Multi_4;
    public CheckBox checkBox_ExcOption2_Multi_5;
    public CheckBox checkBox_ExcOption2_Multi_6;
    public CheckBox checkBox_ExcOption3_Multi_1;
    public CheckBox checkBox_ExcOption3_Multi_2;
    public CheckBox checkBox_ExcOption3_Multi_3;
    public CheckBox checkBox_ExcOption3_Multi_4;
    public CheckBox checkBox_ExcOption3_Multi_5;
    public CheckBox checkBox_ExcOption3_Multi_6;
    public CheckBox checkBox_ExcOption4_Multi_1;
    public CheckBox checkBox_ExcOption4_Multi_2;
    public CheckBox checkBox_ExcOption4_Multi_3;
    public CheckBox checkBox_ExcOption4_Multi_4;
    public CheckBox checkBox_ExcOption4_Multi_5;
    public CheckBox checkBox_ExcOption4_Multi_6;
    public CheckBox checkBox_ExcOption5_Multi_1;
    public CheckBox checkBox_ExcOption5_Multi_2;
    public CheckBox checkBox_ExcOption5_Multi_3;
    public CheckBox checkBox_ExcOption5_Multi_4;
    public CheckBox checkBox_ExcOption5_Multi_5;
    public CheckBox checkBox_ExcOption5_Multi_6;
    public CheckBox checkBox_ExcOption6_Multi_1;
    public CheckBox checkBox_ExcOption6_Multi_2;
    public CheckBox checkBox_ExcOption6_Multi_3;
    public CheckBox checkBox_ExcOption6_Multi_4;
    public CheckBox checkBox_ExcOption6_Multi_5;
    public CheckBox checkBox_ExcOption6_Multi_6;
    private CheckBox checkBox_isMulti_1;
    private CheckBox checkBox_isMulti_2;
    private CheckBox checkBox_isMulti_3;
    private CheckBox checkBox_isMulti_4;
    private CheckBox checkBox_isMulti_5;
    private CheckBox checkBox_isMulti_6;
    public CheckBox checkBox_Luck_Multi_1;
    public CheckBox checkBox_Luck_Multi_2;
    public CheckBox checkBox_Luck_Multi_3;
    public CheckBox checkBox_Luck_Multi_4;
    public CheckBox checkBox_Luck_Multi_5;
    public CheckBox checkBox_Luck_Multi_6;
    private CheckBox checkBox_MultiItem;
    public CheckBox checkBox_NewItem_ExcOpt1;
    public CheckBox checkBox_NewItem_ExcOpt2;
    public CheckBox checkBox_NewItem_ExcOpt3;
    public CheckBox checkBox_NewItem_ExcOpt4;
    public CheckBox checkBox_NewItem_ExcOpt5;
    public CheckBox checkBox_NewItem_ExcOpt6;
    public CheckBox checkBox_NewItem_Luck;
    public CheckBox checkBox_NewItem_Skill;
    private CheckBox checkBox_PackageItem;
    public CheckBox checkBox_Skill_Multi_1;
    public CheckBox checkBox_Skill_Multi_2;
    public CheckBox checkBox_Skill_Multi_3;
    public CheckBox checkBox_Skill_Multi_4;
    public CheckBox checkBox_Skill_Multi_5;
    public CheckBox checkBox_Skill_Multi_6;
    public ComboBox comboBox_Ancient;
    public ComboBox comboBox_Ancient_Multi_1;
    public ComboBox comboBox_Ancient_Multi_2;
    public ComboBox comboBox_Ancient_Multi_3;
    public ComboBox comboBox_Ancient_Multi_4;
    public ComboBox comboBox_Ancient_Multi_5;
    public ComboBox comboBox_Ancient_Multi_6;
    private ComboBox comboBox_NewItem_Coin;
    private ComboBox comboBox_NewItem_CountType;
    private ComboBox comboBox_PackageItem_ItemsDatabase;
    private IContainer components;
    private bool DontWork;
    private bool FirstRun = true;
    private CashShopEditor frm_Parent;
    private GroupBox groupBox_1;
    private GroupBox groupBox_2;
    private GroupBox groupBox_3;
    private GroupBox groupBox_4;
    private GroupBox groupBox_5;
    private GroupBox groupBox_6;
    private GroupBox groupBox_ItemProperties;
    private GroupBox groupBox_MultiItem;
    private GroupBox groupBox_NewItem_ExcOpt;
    private GroupBox groupBox_PackageItem;
    private GroupBox groupBox2;
    private GroupBox groupBox6;
    private GroupBox groupBox8;
    private GroupBox groupBox9;
    private int isEx700ItemList = 1;
    private bool isItemSelected;
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
    private Label label35;
    private Label label36;
    private Label label37;
    private Label label38;
    private Label label39;
    private Label label4;
    private Label label40;
    private Label label41;
    private Label label42;
    private Label label43;
    private Label label44;
    private Label label45;
    private Label label46;
    private Label label47;
    private Label label48;
    private Label label49;
    private Label label5;
    private Label label50;
    private Label label51;
    private Label label52;
    private Label label53;
    private Label label54;
    private Label label55;
    private Label label56;
    private Label label57;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    public ListBox listBox_Level_Multi_1;
    public ListBox listBox_Level_Multi_2;
    public ListBox listBox_Level_Multi_3;
    public ListBox listBox_Level_Multi_4;
    public ListBox listBox_Level_Multi_5;
    public ListBox listBox_Level_Multi_6;
    public ListBox listBox_NewItem_ItemGroup;
    public ListBox listBox_NewItem_ItemIndex;
    public ListBox listBox_NewItem_ItemLevel;
    public ListBox listBox_NewItem_ItemOption;
    public ListBox listBox_Option_Multi_1;
    public ListBox listBox_Option_Multi_2;
    public ListBox listBox_Option_Multi_3;
    public ListBox listBox_Option_Multi_4;
    public ListBox listBox_Option_Multi_5;
    public ListBox listBox_Option_Multi_6;
    private ListBox listBox_PackageItem_AddedItems;
    private NumericUpDown numericUpDown_Count_Multi_1;
    private NumericUpDown numericUpDown_Count_Multi_2;
    private NumericUpDown numericUpDown_Count_Multi_3;
    private NumericUpDown numericUpDown_Count_Multi_4;
    private NumericUpDown numericUpDown_Count_Multi_5;
    private NumericUpDown numericUpDown_Count_Multi_6;
    public NumericUpDown numericUpDown_Durability_Multi_1;
    public NumericUpDown numericUpDown_Durability_Multi_2;
    public NumericUpDown numericUpDown_Durability_Multi_3;
    public NumericUpDown numericUpDown_Durability_Multi_4;
    public NumericUpDown numericUpDown_Durability_Multi_5;
    public NumericUpDown numericUpDown_Durability_Multi_6;
    private NumericUpDown numericUpDown_NewItem_Count;
    public NumericUpDown numericUpDown_NewItem_Durability;
    private NumericUpDown numericUpDown_NewItem_Price;
    public NumericUpDown numericUpDown_NewItem_SocketCount;
    private NumericUpDown numericUpDown_Price_Multi_1;
    private NumericUpDown numericUpDown_Price_Multi_2;
    private NumericUpDown numericUpDown_Price_Multi_3;
    private NumericUpDown numericUpDown_Price_Multi_4;
    private NumericUpDown numericUpDown_Price_Multi_5;
    private NumericUpDown numericUpDown_Price_Multi_6;
    public NumericUpDown numericUpDown_Sockets_Multi_1;
    public NumericUpDown numericUpDown_Sockets_Multi_2;
    public NumericUpDown numericUpDown_Sockets_Multi_3;
    public NumericUpDown numericUpDown_Sockets_Multi_4;
    public NumericUpDown numericUpDown_Sockets_Multi_5;
    public NumericUpDown numericUpDown_Sockets_Multi_6;
    private BindingList<Structures.IGCCashItemInfo> PackageItems = new BindingList<Structures.IGCCashItemInfo>();
    private Panel panel_ItemAdd;
    private PictureBox pictureBox_NewItem_ItemPreview;
    private RadioButton radioButton_Armor_Multi_1;
    private RadioButton radioButton_Armor_Multi_2;
    private RadioButton radioButton_Armor_Multi_3;
    private RadioButton radioButton_Armor_Multi_4;
    private RadioButton radioButton_Armor_Multi_5;
    private RadioButton radioButton_Armor_Multi_6;
    private RadioButton radioButton_NewItem_ExcArmor;
    private RadioButton radioButton_NewItem_ExcWeapon;
    private RadioButton radioButton_NewItem_ExcWings;
    private RadioButton radioButton_Weapon_Multi_1;
    private RadioButton radioButton_Weapon_Multi_2;
    private RadioButton radioButton_Weapon_Multi_3;
    private RadioButton radioButton_Weapon_Multi_4;
    private RadioButton radioButton_Weapon_Multi_5;
    private RadioButton radioButton_Weapon_Multi_6;
    private RadioButton radioButton_Wings_Multi_1;
    private RadioButton radioButton_Wings_Multi_2;
    private RadioButton radioButton_Wings_Multi_3;
    private RadioButton radioButton_Wings_Multi_4;
    private RadioButton radioButton_Wings_Multi_5;
    private RadioButton radioButton_Wings_Multi_6;
    private RichTextBox richTextBox_NewItem_Info;
    private TabControl tabControl1;
    private TabPage tabPage_MultiOption_1;
    private TabPage tabPage_MultiOption_2;
    private TabPage tabPage_MultiOption_3;
    private TabPage tabPage_MultiOption_4;
    private TabPage tabPage_MultiOption_5;
    private TabPage tabPage_MultiOption_6;
    private TextBox textBox_Info;
    private TextBox textBox_Name_Multi_1;
    private TextBox textBox_Name_Multi_2;
    private TextBox textBox_Name_Multi_3;
    private TextBox textBox_Name_Multi_4;
    private TextBox textBox_Name_Multi_5;
    private TextBox textBox_Name_Multi_6;
    private TextBox textBox_NewItem_Name;

    public Form_CashShop_AddItems() => this.InitializeComponent();

    private void button_AddItemToDB_Click(object sender, EventArgs e)
    {
      if (this.checkBox_MultiItem.Checked || this.checkBox_PackageItem.Checked)
      {
        this.textBox_Info.Text = "[ERROR] Only Single Items can be added to Items Database!";
      }
      else
      {
        this.textBox_Info.Text = "";
        ++this.frm_Parent.TraceNumber;
        ++this.frm_Parent.ProductMaxIndex1;
        ++this.frm_Parent.ProductMaxIndex7;
        List<int> intList = new List<int>();
        List<string> stringList1 = new List<string>();
        List<string> stringList2 = new List<string>();
        Structures.IBSProduct ibsProduct = new Structures.IBSProduct()
        {
          Index1 = this.frm_Parent.ProductMaxIndex1
        };
        int index1 = ibsProduct.Index1;
        ibsProduct.Name = this.textBox_NewItem_Name.Text;
        ibsProduct.BuyTypeTxt1 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "Quantity" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "Quantity" : "Duration")));
        int int32 = Convert.ToInt32(this.numericUpDown_NewItem_Count.Value);
        TimeSpan timeSpan = new TimeSpan();
        TimeSpan ts = TimeSpan.FromMinutes((double) int32);
        timeSpan.Add(ts);
        string str1 = "[" + (ts.TotalDays >= 1.0 ? Convert.ToInt32(ts.TotalDays).ToString() + " Day(s)" : (ts.TotalHours >= 1.0 ? Convert.ToInt32(ts.TotalHours).ToString() + " Hour(s)" : Convert.ToInt32(ts.TotalMinutes).ToString() + " Minute(s)"));
        if (str1.Contains("Day(s)"))
          str1 = str1 + (ts.Hours >= 1 ? ", " + Convert.ToInt32(ts.Hours).ToString() + " Hour(s)" : "") + (ts.Minutes >= 1 ? ", " + Convert.ToInt32(ts.Minutes).ToString() + " Minute(s)" : "");
        else if (str1.Contains("Hour(s)"))
          str1 += ts.Minutes >= 1 ? ", " + Convert.ToInt32(ts.Minutes).ToString() + " Minute(s)" : "";
        string str2 = str1 + "]";
        ibsProduct.TypeCount = int32.ToString();
        ibsProduct.BuyTypeTxt2 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "EA" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? str2 : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? str2 : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "NA" : "Days")));
        ibsProduct.Price = (int) this.numericUpDown_NewItem_Price.Value;
        ibsProduct.Index7 = this.frm_Parent.ProductMaxIndex7;
        intList.Add(ibsProduct.Index7);
        ibsProduct.TraceNumber = this.frm_Parent.TraceNumber;
        ibsProduct.ItemID = Convert.ToString((int) this.listBox_NewItem_ItemGroup.SelectedValue * 512 + (int) this.listBox_NewItem_ItemIndex.SelectedValue);
        ibsProduct.Unk1 = (short) 142;
        ibsProduct.Unk2 = (short) 145;
        ibsProduct.Unk3 = (short) 1;
        ibsProduct.Unk4 = (short) 144;
        ibsProduct.Unk5 = (short) 673;
        ibsProduct.Unk6 = (short) 518;
        ibsProduct.Unk7 = this.comboBox_NewItem_CountType.SelectedIndex == 1 || this.comboBox_NewItem_CountType.SelectedIndex == 2 || this.comboBox_NewItem_CountType.SelectedIndex == 4 ? "10" : "7";
        ibsProduct.Unk8 = "138";
        ibsProduct.Unk9 = "680";
        ibsProduct.TraceString = this.frm_Parent.GetUniqueString();
        this.frm_Parent.Products.Add(ibsProduct);
        Structures.IGCCashItemInfo igcCashItemInfo = new Structures.IGCCashItemInfo()
        {
          iGroup = (int) this.listBox_NewItem_ItemGroup.SelectedValue,
          iIndex = (int) this.listBox_NewItem_ItemIndex.SelectedValue,
          Level = (int) this.listBox_NewItem_ItemLevel.SelectedValue,
          Dur = (int) this.numericUpDown_NewItem_Durability.Value,
          Skill = this.checkBox_NewItem_Skill.Checked ? 1 : 0,
          Luck = this.checkBox_NewItem_Luck.Checked ? 1 : 0,
          Option = (int) this.listBox_NewItem_ItemOption.SelectedValue,
          TraceNumber = this.frm_Parent.TraceNumber
        };
        int num1 = 0;
        int num2 = this.checkBox_NewItem_ExcOpt1.Checked ? num1 + 1 : num1;
        int num3 = this.checkBox_NewItem_ExcOpt2.Checked ? num2 + 2 : num2;
        int num4 = this.checkBox_NewItem_ExcOpt3.Checked ? num3 + 4 : num3;
        int num5 = this.checkBox_NewItem_ExcOpt4.Checked ? num4 + 8 : num4;
        int num6 = this.checkBox_NewItem_ExcOpt5.Checked ? num5 + 16 : num5;
        int num7 = this.checkBox_NewItem_ExcOpt6.Checked ? num6 + 32 : num6;
        igcCashItemInfo.Exc = num7;
        igcCashItemInfo.Ancient = (int) this.comboBox_Ancient.SelectedValue;
        igcCashItemInfo.Socket = (int) this.numericUpDown_NewItem_SocketCount.Value;
        igcCashItemInfo.Type = this.comboBox_NewItem_CountType.SelectedIndex;
        igcCashItemInfo.Period = igcCashItemInfo.Type == 0 || igcCashItemInfo.Type == 3 ? 0 : Convert.ToInt32(this.numericUpDown_NewItem_Count.Value);
        igcCashItemInfo.Name = this.textBox_NewItem_Name.Text;
        igcCashItemInfo.TraceString = this.frm_Parent.GetUniqueString();
        igcCashItemInfo.GID = index1;
        igcCashItemInfo.ID = intList[0];
        this.frm_Parent.ItemsInfo.Add(igcCashItemInfo);
        this.comboBox_PackageItem_ItemsDatabase.SelectedItem = (object) igcCashItemInfo;
        this.textBox_Info.Text = "[INFO] Item added successfully to Database.";
      }
    }

    private void button_NewItem_Add_Click(object sender, EventArgs e)
    {
      if (this.listBox_NewItem_ItemIndex.SelectedIndex == -1)
      {
        this.textBox_Info.Text = "[ERROR] Item index not selected!";
      }
      else
      {
        this.textBox_Info.Text = "";
        ++this.frm_Parent.TraceNumber;
        ++this.frm_Parent.ProductMaxIndex1;
        ++this.frm_Parent.MaxItemListGID;
        ++this.frm_Parent.PackageMaxIndex;
        ++this.frm_Parent.ProductMaxIndex7;
        int num1 = 0;
        List<int> intList = new List<int>();
        List<string> stringList1 = new List<string>();
        List<string> stringList2 = new List<string>();
        if (this.frm_Parent.currPage != this.frm_Parent.ItemPageCount)
        {
          this.frm_Parent.currPage = this.frm_Parent.ItemPageCount;
          this.frm_Parent.label_CurrPage.Text = this.frm_Parent.currPage.ToString();
        }
        int num2;
        if (!this.checkBox_PackageItem.Checked && !this.checkBox_MultiItem.Checked)
        {
          Structures.IBSProduct ibsProduct = new Structures.IBSProduct()
          {
            Index1 = this.frm_Parent.ProductMaxIndex1
          };
          num1 = ibsProduct.Index1;
          ibsProduct.Name = this.textBox_NewItem_Name.Text;
          ibsProduct.BuyTypeTxt1 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "Quantity" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "Quantity" : "Duration")));
          int int32 = Convert.ToInt32(this.numericUpDown_NewItem_Count.Value);
          TimeSpan timeSpan = new TimeSpan();
          TimeSpan ts = TimeSpan.FromMinutes((double) int32);
          timeSpan.Add(ts);
          string str1;
          if (ts.TotalDays < 1.0)
          {
            if (ts.TotalHours < 1.0)
            {
              num2 = Convert.ToInt32(ts.TotalMinutes);
              str1 = num2.ToString() + " Minute(s)";
            }
            else
            {
              num2 = Convert.ToInt32(ts.TotalHours);
              str1 = num2.ToString() + " Hour(s)";
            }
          }
          else
          {
            num2 = Convert.ToInt32(ts.TotalDays);
            str1 = num2.ToString() + " Day(s)";
          }
          string str2 = "[" + str1;
          if (str2.Contains("Day(s)"))
          {
            string str3 = str2;
            string str4;
            if (ts.Hours < 1)
            {
              str4 = "";
            }
            else
            {
              num2 = Convert.ToInt32(ts.Hours);
              str4 = ", " + num2.ToString() + " Hour(s)";
            }
            string str5 = str3 + str4;
            string str6;
            if (ts.Minutes < 1)
            {
              str6 = "";
            }
            else
            {
              num2 = Convert.ToInt32(ts.Minutes);
              str6 = ", " + num2.ToString() + " Minute(s)";
            }
            str2 = str5 + str6;
          }
          else if (str2.Contains("Hour(s)"))
          {
            string str7 = str2;
            string str8;
            if (ts.Minutes < 1)
            {
              str8 = "";
            }
            else
            {
              num2 = Convert.ToInt32(ts.Minutes);
              str8 = ", " + num2.ToString() + " Minute(s)";
            }
            str2 = str7 + str8;
          }
          string str9 = str2 + "]";
          ibsProduct.TypeCount = int32.ToString();
          ibsProduct.BuyTypeTxt2 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "EA" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? str9 : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? str9 : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "NA" : "Days")));
          ibsProduct.Price = (int) this.numericUpDown_NewItem_Price.Value;
          ibsProduct.Index7 = this.frm_Parent.ProductMaxIndex7;
          intList.Add(ibsProduct.Index7);
          ibsProduct.TraceNumber = this.frm_Parent.TraceNumber;
          ibsProduct.ItemID = Convert.ToString((int) this.listBox_NewItem_ItemGroup.SelectedValue * 512 + (int) this.listBox_NewItem_ItemIndex.SelectedValue);
          ibsProduct.Unk1 = (short) 142;
          ibsProduct.Unk2 = (short) 145;
          ibsProduct.Unk3 = (short) 1;
          ibsProduct.Unk4 = (short) 144;
          ibsProduct.Unk5 = (short) 673;
          ibsProduct.Unk6 = (short) 518;
          ibsProduct.Unk7 = this.comboBox_NewItem_CountType.SelectedIndex == 1 || this.comboBox_NewItem_CountType.SelectedIndex == 2 || this.comboBox_NewItem_CountType.SelectedIndex == 4 ? "10" : "7";
          ibsProduct.Unk8 = "138";
          ibsProduct.Unk9 = "680";
          ibsProduct.TraceString = this.frm_Parent.GetUniqueString();
          this.frm_Parent.Products.Add(ibsProduct);
          ++this.frm_Parent.ProductMaxIndex7;
        }
        else if (this.checkBox_MultiItem.Checked && this.checkBox_MultiItem.Enabled)
        {
          for (int index = 1; index < 7; ++index)
          {
            CheckBox control1 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_isMulti_" + (object) index];
            TextBox control2 = (TextBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["textBox_Name_Multi_" + (object) index];
            NumericUpDown control3 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Count_Multi_" + (object) index];
            NumericUpDown control4 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Price_Multi_" + (object) index];
            if (control1.Checked)
            {
              Structures.IBSProduct ibsProduct = new Structures.IBSProduct()
              {
                Index1 = this.frm_Parent.ProductMaxIndex1
              };
              num1 = ibsProduct.Index1;
              ibsProduct.Name = control2.Text;
              ibsProduct.BuyTypeTxt1 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "Quantity" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "Quantity" : "Duration")));
              int int32 = Convert.ToInt32(control3.Value);
              TimeSpan timeSpan = new TimeSpan();
              TimeSpan ts = TimeSpan.FromMinutes((double) int32);
              timeSpan.Add(ts);
              string str10;
              if (ts.TotalDays < 1.0)
              {
                if (ts.TotalHours < 1.0)
                {
                  num2 = Convert.ToInt32(ts.TotalMinutes);
                  str10 = num2.ToString() + " Minute(s)";
                }
                else
                {
                  num2 = Convert.ToInt32(ts.TotalHours);
                  str10 = num2.ToString() + " Hour(s)";
                }
              }
              else
              {
                num2 = Convert.ToInt32(ts.TotalDays);
                str10 = num2.ToString() + " Day(s)";
              }
              string str11 = "[" + str10;
              if (str11.Contains("Day(s)"))
              {
                string str12 = str11;
                string str13;
                if (ts.Hours < 1)
                {
                  str13 = "";
                }
                else
                {
                  num2 = Convert.ToInt32(ts.Hours);
                  str13 = ", " + num2.ToString() + " Hour(s)";
                }
                string str14 = str12 + str13;
                string str15;
                if (ts.Minutes < 1)
                {
                  str15 = "";
                }
                else
                {
                  num2 = Convert.ToInt32(ts.Minutes);
                  str15 = ", " + num2.ToString() + " Minute(s)";
                }
                str11 = str14 + str15;
              }
              else if (str11.Contains("Hour(s)"))
              {
                string str16 = str11;
                string str17;
                if (ts.Minutes < 1)
                {
                  str17 = "";
                }
                else
                {
                  num2 = Convert.ToInt32(ts.Minutes);
                  str17 = ", " + num2.ToString() + " Minute(s)";
                }
                str11 = str16 + str17;
              }
              string str18 = str11 + "]";
              ibsProduct.TypeCount = int32.ToString();
              ibsProduct.BuyTypeTxt2 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "EA" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? str18 : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? str18 : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "NA" : "Days")));
              ibsProduct.Price = (int) control4.Value;
              stringList2.Add(ibsProduct.Price.ToString());
              ibsProduct.Index7 = this.frm_Parent.ProductMaxIndex7;
              intList.Add(ibsProduct.Index7);
              ibsProduct.TraceNumber = this.frm_Parent.TraceNumber;
              ibsProduct.ItemID = Convert.ToString((int) this.listBox_NewItem_ItemGroup.SelectedValue * 512 + (int) this.listBox_NewItem_ItemIndex.SelectedValue);
              ibsProduct.Unk1 = (short) 142;
              ibsProduct.Unk2 = (short) 145;
              ibsProduct.Unk3 = (short) 1;
              ibsProduct.Unk4 = (short) 144;
              ibsProduct.Unk5 = (short) 673;
              ibsProduct.Unk6 = (short) 518;
              ibsProduct.Unk7 = this.comboBox_NewItem_CountType.SelectedIndex == 1 || this.comboBox_NewItem_CountType.SelectedIndex == 2 || this.comboBox_NewItem_CountType.SelectedIndex == 4 ? "10" : "7";
              ibsProduct.Unk8 = "138";
              ibsProduct.Unk9 = "680";
              ibsProduct.TraceString = this.frm_Parent.GetUniqueString();
              this.frm_Parent.Products.Add(ibsProduct);
              ++this.frm_Parent.ProductMaxIndex7;
            }
          }
        }
        Structures.IBSPackage ibsPackage = new Structures.IBSPackage()
        {
          CatIndex = (short) this.frm_Parent.SelectedSubCat.Index,
          Seq = Convert.ToInt16(this.frm_Parent.AddedItems.Count + 1),
          Index = Convert.ToInt16(this.frm_Parent.PackageMaxIndex),
          Name = this.textBox_NewItem_Name.Text,
          Price = (int) this.numericUpDown_NewItem_Price.Value,
          Info = this.richTextBox_NewItem_Info.Text.Replace("\n", "#"),
          Unk3 = Convert.ToInt16(this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 185 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 184 : 185))
        } with
        {
          RewardCount = !this.checkBox_PackageItem.Checked ? (short) 1 : Convert.ToInt16(this.PackageItems.Count),
          CoinTxt1 = this.comboBox_NewItem_Coin.Text,
          CoinTxt2 = this.comboBox_NewItem_Coin.Text
        };
        if (this.checkBox_PackageItem.Checked)
        {
          foreach (Structures.IGCCashItemInfo packageItem in (Collection<Structures.IGCCashItemInfo>) this.PackageItems)
          {
            ref Structures.IBSPackage local1 = ref ibsPackage;
            string productRewardIndex1 = ibsPackage.ProductRewardIndex1;
            num2 = packageItem.GID;
            string str19 = num2.ToString();
            // ISSUE: variable of a boxed type
            __Boxed<char> local2 = (ValueType) '|';
            string str20 = productRewardIndex1 + str19 + (object) local2;
            local1.ProductRewardIndex1 = str20;
          }
        }
        else
          ibsPackage.ProductRewardIndex1 = num1.ToString() + (object) '|';
        if (this.checkBox_PackageItem.Checked)
          ibsPackage.ProductRewardIndexes7 = "";
        else if (this.checkBox_MultiItem.Checked)
        {
          foreach (int num3 in intList)
            ibsPackage.ProductRewardIndexes7 = ibsPackage.ProductRewardIndexes7 + num3.ToString() + (object) '|';
        }
        else
        {
          ref Structures.IBSPackage local = ref ibsPackage;
          num2 = intList[0];
          string str = num2.ToString() + (object) '|';
          local.ProductRewardIndexes7 = str;
        }
        ibsPackage.ItemID = (int) this.listBox_NewItem_ItemGroup.SelectedValue * 512 + (int) this.listBox_NewItem_ItemIndex.SelectedValue;
        ibsPackage.CheckBoxCount = !this.checkBox_MultiItem.Checked ? (short) 1 : Convert.ToInt16(intList.Count);
        ibsPackage.ServerCatIndex = this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 508 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 509 : 0);
        ibsPackage.TraceNumber = this.frm_Parent.TraceNumber;
        ibsPackage.Unk10 = Convert.ToInt16(this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 2 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 3 : 5));
        ibsPackage.Unk1 = (short) 170;
        ibsPackage.Unk2 = (short) 182;
        ibsPackage.Unk4 = "0";
        ibsPackage.Unk5 = "0";
        ibsPackage.Unk6 = (short) 177;
        ibsPackage.Unk7 = (short) 181;
        ibsPackage.Unk8 = (short) 200;
        ibsPackage.Unk9 = (short) 0;
        ibsPackage.Unk11 = "0";
        ibsPackage.Const669 = 669;
        ibsPackage.TraceString = this.frm_Parent.GetUniqueString();
        this.frm_Parent.Packages.Add(ibsPackage);
        if (!this.checkBox_PackageItem.Checked && !this.checkBox_MultiItem.Checked)
        {
          Structures.IGCCashItemInfo igcCashItemInfo = new Structures.IGCCashItemInfo()
          {
            iGroup = (int) this.listBox_NewItem_ItemGroup.SelectedValue,
            iIndex = (int) this.listBox_NewItem_ItemIndex.SelectedValue,
            Level = (int) this.listBox_NewItem_ItemLevel.SelectedValue,
            Dur = (int) this.numericUpDown_NewItem_Durability.Value,
            Skill = this.checkBox_NewItem_Skill.Checked ? 1 : 0,
            Luck = this.checkBox_NewItem_Luck.Checked ? 1 : 0,
            Option = (int) this.listBox_NewItem_ItemOption.SelectedValue,
            TraceNumber = this.frm_Parent.TraceNumber
          };
          int num4 = 0;
          int num5 = this.checkBox_NewItem_ExcOpt1.Checked ? num4 + 1 : num4;
          int num6 = this.checkBox_NewItem_ExcOpt2.Checked ? num5 + 2 : num5;
          int num7 = this.checkBox_NewItem_ExcOpt3.Checked ? num6 + 4 : num6;
          int num8 = this.checkBox_NewItem_ExcOpt4.Checked ? num7 + 8 : num7;
          int num9 = this.checkBox_NewItem_ExcOpt5.Checked ? num8 + 16 : num8;
          int num10 = this.checkBox_NewItem_ExcOpt6.Checked ? num9 + 32 : num9;
          igcCashItemInfo.Exc = num10;
          igcCashItemInfo.Ancient = (int) this.comboBox_Ancient.SelectedValue;
          igcCashItemInfo.Socket = (int) this.numericUpDown_NewItem_SocketCount.Value;
          igcCashItemInfo.Type = this.comboBox_NewItem_CountType.SelectedIndex;
          igcCashItemInfo.Period = igcCashItemInfo.Type == 0 || igcCashItemInfo.Type == 3 ? 0 : Convert.ToInt32(this.numericUpDown_NewItem_Count.Value);
          igcCashItemInfo.Name = this.textBox_NewItem_Name.Text;
          igcCashItemInfo.TraceString = this.frm_Parent.GetUniqueString();
          igcCashItemInfo.GID = num1;
          igcCashItemInfo.ID = intList[0];
          this.frm_Parent.ItemsInfo.Add(igcCashItemInfo);
        }
        else if (this.checkBox_MultiItem.Checked && this.checkBox_MultiItem.Enabled)
        {
          for (int index = 1; index < 7; ++index)
          {
            CheckBox control5 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_isMulti_" + (object) index];
            TextBox control6 = (TextBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["textBox_Name_Multi_" + (object) index];
            NumericUpDown control7 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Count_Multi_" + (object) index];
            NumericUpDown control8 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Price_Multi_" + (object) index];
            ListBox control9 = (ListBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["listBox_Level_Multi_" + (object) index];
            ListBox control10 = (ListBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["listBox_Option_Multi_" + (object) index];
            ComboBox control11 = (ComboBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["comboBox_Ancient_Multi_" + (object) index];
            CheckBox control12 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption1_Multi_" + (object) index];
            CheckBox control13 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption2_Multi_" + (object) index];
            CheckBox control14 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption3_Multi_" + (object) index];
            CheckBox control15 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption4_Multi_" + (object) index];
            CheckBox control16 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption5_Multi_" + (object) index];
            CheckBox control17 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption6_Multi_" + (object) index];
            NumericUpDown control18 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Sockets_Multi_" + (object) index];
            NumericUpDown control19 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Durability_Multi_" + (object) index];
            CheckBox control20 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_Luck_Multi_" + (object) index];
            CheckBox control21 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_Skill_Multi_" + (object) index];
            if (control5.Checked)
            {
              Structures.IGCCashItemInfo igcCashItemInfo = new Structures.IGCCashItemInfo()
              {
                iGroup = (int) this.listBox_NewItem_ItemGroup.SelectedValue,
                iIndex = (int) this.listBox_NewItem_ItemIndex.SelectedValue,
                Level = (int) control9.SelectedValue,
                Dur = (int) control19.Value,
                Skill = control21.Checked ? 1 : 0,
                Luck = control20.Checked ? 1 : 0,
                Option = (int) control10.SelectedValue,
                TraceNumber = this.frm_Parent.TraceNumber
              };
              int num11 = 0;
              int num12 = control12.Checked ? num11 + 1 : num11;
              int num13 = control13.Checked ? num12 + 2 : num12;
              int num14 = control14.Checked ? num13 + 4 : num13;
              int num15 = control15.Checked ? num14 + 8 : num14;
              int num16 = control16.Checked ? num15 + 16 : num15;
              int num17 = control17.Checked ? num16 + 32 : num16;
              igcCashItemInfo.Exc = num17;
              igcCashItemInfo.Ancient = (int) control11.SelectedValue;
              igcCashItemInfo.Socket = (int) control18.Value;
              igcCashItemInfo.Type = this.comboBox_NewItem_CountType.SelectedIndex;
              igcCashItemInfo.Period = igcCashItemInfo.Type == 0 || igcCashItemInfo.Type == 3 ? 0 : Convert.ToInt32(control7.Value);
              igcCashItemInfo.Name = control6.Text;
              stringList1.Add(igcCashItemInfo.Name);
              igcCashItemInfo.TraceString = this.frm_Parent.GetUniqueString();
              igcCashItemInfo.GID = num1;
              igcCashItemInfo.ID = intList[index - 1];
              this.frm_Parent.ItemsInfo.Add(igcCashItemInfo);
            }
          }
        }
        if (!this.checkBox_PackageItem.Checked && !this.checkBox_MultiItem.Checked)
          this.frm_Parent.ItemsList.Add(new Structures.IGCCashItemList()
          {
            GUID = this.frm_Parent.MaxItemListGID,
            Index = (int) ibsPackage.Index,
            SubIndex = ibsPackage.ServerCatIndex,
            iOpt = 0,
            pID = 0,
            cType = this.comboBox_NewItem_Coin.SelectedIndex,
            iPrice = (int) this.numericUpDown_NewItem_Price.Value,
            iInfoGD = Convert.ToInt32(ibsPackage.ProductRewardIndex1.Replace("|", string.Empty)),
            iInfoID = Convert.ToInt32(ibsPackage.ProductRewardIndexes7.Replace("|", string.Empty)),
            iCat = (int) ibsPackage.CatIndex,
            iGP = 0,
            iSale = 1,
            iRand = 0,
            Name = this.textBox_NewItem_Name.Text,
            TraceNumber = this.frm_Parent.TraceNumber,
            TraceString = this.frm_Parent.GetUniqueString()
          });
        else if (this.checkBox_MultiItem.Checked && this.checkBox_MultiItem.Enabled)
        {
          Structures.IGCCashItemList igcCashItemList = new Structures.IGCCashItemList()
          {
            Index = (int) ibsPackage.Index,
            SubIndex = ibsPackage.ServerCatIndex,
            pID = 0,
            cType = this.comboBox_NewItem_Coin.SelectedIndex,
            iInfoGD = Convert.ToInt32(ibsPackage.ProductRewardIndex1.Replace("|", string.Empty)),
            iCat = (int) ibsPackage.CatIndex,
            iGP = 0,
            iSale = 1,
            iRand = 0,
            TraceNumber = this.frm_Parent.TraceNumber
          };
          string[] strArray = ibsPackage.ProductRewardIndexes7.Split('|');
          for (int index = 0; index < strArray.Length - 1; ++index)
          {
            igcCashItemList.Name = stringList1[index];
            igcCashItemList.GUID = this.frm_Parent.MaxItemListGID;
            igcCashItemList.iPrice = Convert.ToInt32(stringList2[index]);
            igcCashItemList.iInfoID = Convert.ToInt32(strArray[index]);
            igcCashItemList.iOpt = igcCashItemList.iInfoID;
            igcCashItemList.TraceString = this.frm_Parent.GetUniqueString();
            this.frm_Parent.ItemsList.Add(igcCashItemList);
            ++this.frm_Parent.MaxItemListGID;
          }
        }
        else if (this.checkBox_PackageItem.Checked)
        {
          ++this.frm_Parent.MaxPackageID;
          this.frm_Parent.ItemsList.Add(new Structures.IGCCashItemList()
          {
            GUID = this.frm_Parent.MaxItemListGID,
            Index = (int) ibsPackage.Index,
            SubIndex = ibsPackage.ServerCatIndex,
            iOpt = 0,
            pID = this.frm_Parent.MaxPackageID,
            cType = this.comboBox_NewItem_Coin.SelectedIndex,
            iPrice = (int) this.numericUpDown_NewItem_Price.Value,
            iInfoGD = 0,
            iInfoID = 0,
            iCat = (int) ibsPackage.CatIndex,
            iGP = 0,
            iSale = 1,
            iRand = 0,
            Name = this.textBox_NewItem_Name.Text,
            TraceNumber = this.frm_Parent.TraceNumber,
            TraceString = this.frm_Parent.GetUniqueString()
          });
        }
        if (this.checkBox_PackageItem.Checked)
        {
          int num18 = 0;
          foreach (Structures.IGCCashItemInfo igcCashItemInfo in this.listBox_PackageItem_AddedItems.Items)
          {
            Structures.IGCCashItemPackages cashItemPackages = new Structures.IGCCashItemPackages()
            {
              pID = this.frm_Parent.MaxPackageID,
              GUID = num18,
              iSeq = num18,
              iGUID = igcCashItemInfo.GID,
              iID = igcCashItemInfo.ID,
              Name = igcCashItemInfo.Name,
              PackName = this.textBox_NewItem_Name.Text
            };
            this.frm_Parent.IGC_CashItemPackages_Indexes.Add(cashItemPackages.GUID.ToString() + (object) ',' + cashItemPackages.iGUID.ToString());
            this.frm_Parent.ItemsPackage.Add(cashItemPackages);
            ++num18;
          }
        }
        this.frm_Parent.ItemsToAdd = this.frm_Parent.GetSubCatItems(this.frm_Parent.SelectedSubCat.Index);
        this.frm_Parent.LoadItems(this.frm_Parent.currPage);
        this.textBox_Info.Text = "[INFO] Item Added Successfully.";
      }
    }

    private void button_PackageItem_AddToList_Click(object sender, EventArgs e) => this.PackageItems.Add((Structures.IGCCashItemInfo) this.comboBox_PackageItem_ItemsDatabase.SelectedItem);

    private void button_PackageItem_RemoveFromList_Click(object sender, EventArgs e)
    {
      if (this.listBox_PackageItem_AddedItems.SelectedIndex == -1)
        return;
      this.PackageItems.Remove((Structures.IGCCashItemInfo) this.listBox_PackageItem_AddedItems.SelectedItem);
    }

    private void button_UpdateExistingItem_Click(object sender, EventArgs e)
    {
      if (!this.isItemSelected)
      {
        this.textBox_Info.Text = "[ERROR] No item selected!";
      }
      else
      {
        this.textBox_Info.Text = "";
        BindingList<Structures.IGCCashItemList> selectedIList = this.frm_Parent.Selected_iList;
        BindingList<Structures.IGCCashItemInfo> selectedIInfo = this.frm_Parent.Selected_iInfo;
        BindingList<Structures.IGCCashItemPackages> selectedIPack = this.frm_Parent.Selected_iPack;
        Structures.IBSPackage selectedIPackage = this.frm_Parent.Selected_iPackage;
        BindingList<Structures.IBSProduct> selectedIProduct = this.frm_Parent.Selected_iProduct;
        if (selectedIList[0].pID == 0 && this.checkBox_PackageItem.Checked || selectedIList[0].pID > 0 && !this.checkBox_PackageItem.Checked || selectedIList[0].iOpt == 0 && this.checkBox_MultiItem.Checked || selectedIList[0].iOpt > 0 && !this.checkBox_MultiItem.Checked)
        {
          this.textBox_Info.Text = "[ERROR] Cannot convert Non-Package or MultiItem Item to Singel Item Type and vice versa!";
        }
        else
        {
          int num1 = 0;
          for (int index = 1; index < 7; ++index)
            num1 = ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_isMulti_" + (object) index]).Checked ? num1 + 1 : num1;
          if (this.checkBox_MultiItem.Checked && num1 < 2)
          {
            this.textBox_Info.Text = "[ERROR] Multi item must have at least 2 Options !";
          }
          else
          {
            if (selectedIList.Count != 1)
            {
              List<int> intList = new List<int>();
              List<string> stringList1 = new List<string>();
              List<string> stringList2 = new List<string>();
              for (int index = 1; index < 7; ++index)
              {
                CheckBox control1 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_isMulti_" + (object) index];
                TextBox control2 = (TextBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["textBox_Name_Multi_" + (object) index];
                NumericUpDown control3 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Count_Multi_" + (object) index];
                NumericUpDown control4 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Price_Multi_" + (object) index];
                if (control1.Checked)
                {
                  if (index <= selectedIProduct.Count)
                  {
                    Structures.IBSProduct ibsProduct = selectedIProduct[index - 1] with
                    {
                      Name = control2.Text
                    };
                    intList.Add(ibsProduct.Index7);
                    ibsProduct.BuyTypeTxt1 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "Quantity" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "Quantity" : "Duration")));
                    int int32 = Convert.ToInt32(control3.Value);
                    TimeSpan timeSpan = new TimeSpan();
                    TimeSpan ts = TimeSpan.FromMinutes((double) int32);
                    timeSpan.Add(ts);
                    string str1 = "[" + (ts.TotalDays >= 1.0 ? Convert.ToInt32(ts.TotalDays).ToString() + " Day(s)" : (ts.TotalHours >= 1.0 ? Convert.ToInt32(ts.TotalHours).ToString() + " Hour(s)" : Convert.ToInt32(ts.TotalMinutes).ToString() + " Minute(s)"));
                    if (str1.Contains("Day(s)"))
                      str1 = str1 + (ts.Hours >= 1 ? ", " + Convert.ToInt32(ts.Hours).ToString() + " Hour(s)" : "") + (ts.Minutes >= 1 ? ", " + Convert.ToInt32(ts.Minutes).ToString() + " Minute(s)" : "");
                    else if (str1.Contains("Hour(s)"))
                      str1 += ts.Minutes >= 1 ? ", " + Convert.ToInt32(ts.Minutes).ToString() + " Minute(s)" : "";
                    string str2 = str1 + "]";
                    ibsProduct.TypeCount = int32.ToString();
                    ibsProduct.BuyTypeTxt2 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "EA" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? str2 : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? str2 : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "NA" : "Days")));
                    ibsProduct.Price = (int) control4.Value;
                    stringList2.Add(ibsProduct.Price.ToString());
                    this.frm_Parent.Products[this.frm_Parent.Products.IndexOf(selectedIProduct[index - 1])] = ibsProduct;
                    selectedIProduct[index - 1] = ibsProduct;
                  }
                  else
                  {
                    Structures.IBSProduct ibsProduct1 = selectedIProduct[0];
                    ++this.frm_Parent.ProductMaxIndex7;
                    Structures.IBSProduct ibsProduct2 = new Structures.IBSProduct()
                    {
                      Index1 = ibsProduct1.Index1,
                      Name = control2.Text,
                      BuyTypeTxt1 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "Quantity" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "Quantity" : "Duration")))
                    };
                    int int32 = Convert.ToInt32(control3.Value);
                    TimeSpan timeSpan = new TimeSpan();
                    TimeSpan ts = TimeSpan.FromMinutes((double) int32);
                    timeSpan.Add(ts);
                    string str3 = "[" + (ts.TotalDays >= 1.0 ? Convert.ToInt32(ts.TotalDays).ToString() + " Day(s)" : (ts.TotalHours >= 1.0 ? Convert.ToInt32(ts.TotalHours).ToString() + " Hour(s)" : Convert.ToInt32(ts.TotalMinutes).ToString() + " Minute(s)"));
                    if (str3.Contains("Day(s)"))
                      str3 = str3 + (ts.Hours >= 1 ? ", " + Convert.ToInt32(ts.Hours).ToString() + " Hour(s)" : "") + (ts.Minutes >= 1 ? ", " + Convert.ToInt32(ts.Minutes).ToString() + " Minute(s)" : "");
                    else if (str3.Contains("Hour(s)"))
                      str3 += ts.Minutes >= 1 ? ", " + Convert.ToInt32(ts.Minutes).ToString() + " Minute(s)" : "";
                    string str4 = str3 + "]";
                    ibsProduct2.TypeCount = int32.ToString();
                    ibsProduct2.BuyTypeTxt2 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "EA" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? str4 : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? str4 : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "NA" : "Days")));
                    ibsProduct2.Price = (int) control4.Value;
                    stringList2.Add(ibsProduct2.Price.ToString());
                    ibsProduct2.Index7 = this.frm_Parent.ProductMaxIndex7;
                    intList.Add(ibsProduct2.Index7);
                    ibsProduct2.TraceNumber = ibsProduct1.TraceNumber;
                    ibsProduct2.ItemID = ibsProduct1.ItemID;
                    ibsProduct2.Unk1 = (short) 142;
                    ibsProduct2.Unk2 = (short) 145;
                    ibsProduct2.Unk3 = (short) 1;
                    ibsProduct2.Unk4 = (short) 144;
                    ibsProduct2.Unk5 = (short) 673;
                    ibsProduct2.Unk6 = (short) 518;
                    ibsProduct2.Unk7 = this.comboBox_NewItem_CountType.SelectedIndex == 1 || this.comboBox_NewItem_CountType.SelectedIndex == 2 || this.comboBox_NewItem_CountType.SelectedIndex == 4 ? "10" : "7";
                    ibsProduct2.Unk8 = "138";
                    ibsProduct2.Unk9 = "680";
                    ibsProduct2.TraceString = this.frm_Parent.GetUniqueString();
                    this.frm_Parent.Products.Add(ibsProduct2);
                    selectedIProduct.Add(ibsProduct2);
                  }
                }
                else
                {
                  try
                  {
                    this.frm_Parent.Products.Remove(selectedIProduct[index - 1]);
                  }
                  catch
                  {
                  }
                }
              }
              Structures.IBSPackage ibsPackage = selectedIPackage with
              {
                Name = this.textBox_NewItem_Name.Text,
                Price = (int) this.numericUpDown_NewItem_Price.Value,
                Info = this.richTextBox_NewItem_Info.Text.Replace("\n", "#"),
                Unk3 = Convert.ToInt16(this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 185 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 184 : 185)),
                RewardCount = 1,
                CoinTxt1 = this.comboBox_NewItem_Coin.Text,
                CoinTxt2 = this.comboBox_NewItem_Coin.Text,
                ProductRewardIndexes7 = ""
              };
              foreach (int num2 in intList)
                ibsPackage.ProductRewardIndexes7 = ibsPackage.ProductRewardIndexes7 + num2.ToString() + (object) '|';
              ibsPackage.CheckBoxCount = Convert.ToInt16(intList.Count);
              ibsPackage.Unk10 = Convert.ToInt16(this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 2 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 3 : 5));
              this.frm_Parent.Packages[this.frm_Parent.Packages.IndexOf(selectedIPackage)] = ibsPackage;
              for (int index = 1; index < 7; ++index)
              {
                CheckBox control5 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_isMulti_" + (object) index];
                TextBox control6 = (TextBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["textBox_Name_Multi_" + (object) index];
                NumericUpDown control7 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Count_Multi_" + (object) index];
                NumericUpDown control8 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Price_Multi_" + (object) index];
                ListBox control9 = (ListBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["listBox_Level_Multi_" + (object) index];
                ListBox control10 = (ListBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["listBox_Option_Multi_" + (object) index];
                ComboBox control11 = (ComboBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["comboBox_Ancient_Multi_" + (object) index];
                CheckBox control12 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption1_Multi_" + (object) index];
                CheckBox control13 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption2_Multi_" + (object) index];
                CheckBox control14 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption3_Multi_" + (object) index];
                CheckBox control15 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption4_Multi_" + (object) index];
                CheckBox control16 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption5_Multi_" + (object) index];
                CheckBox control17 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption6_Multi_" + (object) index];
                NumericUpDown control18 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Sockets_Multi_" + (object) index];
                NumericUpDown control19 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Durability_Multi_" + (object) index];
                CheckBox control20 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_Luck_Multi_" + (object) index];
                CheckBox control21 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_Skill_Multi_" + (object) index];
                if (control5.Checked)
                {
                  if (index <= selectedIInfo.Count)
                  {
                    Structures.IGCCashItemInfo igcCashItemInfo = selectedIInfo[index - 1] with
                    {
                      Level = (int) control9.SelectedValue,
                      Dur = (int) control19.Value,
                      Skill = control21.Checked ? 1 : 0,
                      Luck = control20.Checked ? 1 : 0,
                      Option = (int) control10.SelectedValue
                    };
                    int num3 = 0;
                    int num4 = control12.Checked ? num3 + 1 : num3;
                    int num5 = control13.Checked ? num4 + 2 : num4;
                    int num6 = control14.Checked ? num5 + 4 : num5;
                    int num7 = control15.Checked ? num6 + 8 : num6;
                    int num8 = control16.Checked ? num7 + 16 : num7;
                    int num9 = control17.Checked ? num8 + 32 : num8;
                    igcCashItemInfo.Exc = num9;
                    igcCashItemInfo.Ancient = (int) control11.SelectedValue;
                    igcCashItemInfo.Socket = (int) control18.Value;
                    igcCashItemInfo.Type = this.comboBox_NewItem_CountType.SelectedIndex;
                    igcCashItemInfo.Period = igcCashItemInfo.Type == 0 || igcCashItemInfo.Type == 3 ? 0 : Convert.ToInt32(control7.Value);
                    igcCashItemInfo.Name = control6.Text;
                    stringList1.Add(igcCashItemInfo.Name);
                    this.frm_Parent.ItemsInfo[this.frm_Parent.ItemsInfo.IndexOf(selectedIInfo[index - 1])] = igcCashItemInfo;
                  }
                  else
                  {
                    Structures.IGCCashItemInfo igcCashItemInfo1 = selectedIInfo[0];
                    Structures.IGCCashItemInfo igcCashItemInfo2 = new Structures.IGCCashItemInfo()
                    {
                      iGroup = igcCashItemInfo1.iGroup,
                      iIndex = igcCashItemInfo1.iIndex,
                      Level = (int) control9.SelectedValue,
                      Dur = (int) control19.Value,
                      Skill = control21.Checked ? 1 : 0,
                      Luck = control20.Checked ? 1 : 0,
                      Option = (int) control10.SelectedValue,
                      TraceNumber = igcCashItemInfo1.TraceNumber
                    };
                    int num10 = 0;
                    int num11 = control12.Checked ? num10 + 1 : num10;
                    int num12 = control13.Checked ? num11 + 2 : num11;
                    int num13 = control14.Checked ? num12 + 4 : num12;
                    int num14 = control15.Checked ? num13 + 8 : num13;
                    int num15 = control16.Checked ? num14 + 16 : num14;
                    int num16 = control17.Checked ? num15 + 32 : num15;
                    igcCashItemInfo2.Exc = num16;
                    igcCashItemInfo2.Ancient = (int) control11.SelectedValue;
                    igcCashItemInfo2.Socket = (int) control18.Value;
                    igcCashItemInfo2.Type = this.comboBox_NewItem_CountType.SelectedIndex;
                    igcCashItemInfo2.Period = igcCashItemInfo2.Type == 0 || igcCashItemInfo2.Type == 3 ? 0 : Convert.ToInt32(control7.Value);
                    igcCashItemInfo2.Name = control6.Text;
                    stringList1.Add(igcCashItemInfo2.Name);
                    igcCashItemInfo2.TraceString = this.frm_Parent.GetUniqueString();
                    igcCashItemInfo2.GID = igcCashItemInfo1.GID;
                    igcCashItemInfo2.ID = intList[index - 1];
                    this.frm_Parent.ItemsInfo.Add(igcCashItemInfo2);
                  }
                }
                else
                {
                  try
                  {
                    this.frm_Parent.ItemsInfo.Remove(selectedIInfo[index - 1]);
                  }
                  catch
                  {
                  }
                }
              }
              Structures.IGCCashItemList igcCashItemList1 = selectedIList[0];
              foreach (Structures.IGCCashItemList igcCashItemList2 in (Collection<Structures.IGCCashItemList>) selectedIList)
                this.frm_Parent.ItemsList.Remove(igcCashItemList2);
              Structures.IGCCashItemList igcCashItemList3 = new Structures.IGCCashItemList()
              {
                Index = (int) ibsPackage.Index,
                SubIndex = ibsPackage.ServerCatIndex,
                pID = 0,
                cType = this.comboBox_NewItem_Coin.SelectedIndex,
                iInfoGD = Convert.ToInt32(ibsPackage.ProductRewardIndex1.Replace("|", string.Empty)),
                iCat = (int) ibsPackage.CatIndex,
                iGP = 0,
                iSale = 1,
                iRand = 0,
                TraceNumber = ibsPackage.TraceNumber
              };
              ++this.frm_Parent.MaxItemListGID;
              string[] strArray = ibsPackage.ProductRewardIndexes7.Split('|');
              for (int index = 0; index < strArray.Length - 1; ++index)
              {
                igcCashItemList3.Name = stringList1[index];
                igcCashItemList3.GUID = this.frm_Parent.MaxItemListGID;
                igcCashItemList3.iPrice = Convert.ToInt32(stringList2[index]);
                igcCashItemList3.iInfoID = Convert.ToInt32(strArray[index]);
                igcCashItemList3.iOpt = igcCashItemList3.iInfoID;
                igcCashItemList3.TraceString = this.frm_Parent.GetUniqueString();
                this.frm_Parent.ItemsList.Add(igcCashItemList3);
                ++this.frm_Parent.MaxItemListGID;
              }
            }
            else if (selectedIList[0].pID != 0)
            {
              for (int index = 0; index < this.frm_Parent.Packages.Count; ++index)
              {
                if (selectedIPackage.TraceString == this.frm_Parent.Packages[index].TraceString)
                {
                  Structures.IBSPackage package = this.frm_Parent.Packages[index] with
                  {
                    Name = this.textBox_NewItem_Name.Text,
                    Price = (int) this.numericUpDown_NewItem_Price.Value,
                    Info = this.richTextBox_NewItem_Info.Text.Replace("\n", "#"),
                    Unk3 = Convert.ToInt16(this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 185 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 184 : 185)),
                    RewardCount = !this.checkBox_PackageItem.Checked ? (short) 1 : Convert.ToInt16(this.PackageItems.Count),
                    CoinTxt1 = this.comboBox_NewItem_Coin.Text,
                    CoinTxt2 = this.comboBox_NewItem_Coin.Text,
                    ProductRewardIndex1 = ""
                  };
                  foreach (Structures.IGCCashItemInfo packageItem in (Collection<Structures.IGCCashItemInfo>) this.PackageItems)
                    package.ProductRewardIndex1 = package.ProductRewardIndex1 + packageItem.GID.ToString() + (object) '|';
                  package.Unk10 = Convert.ToInt16(this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 2 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 3 : 5));
                  this.frm_Parent.Packages[index] = package;
                  break;
                }
              }
              for (int index1 = 0; index1 < selectedIList.Count; ++index1)
              {
                for (int index2 = 0; index2 < this.frm_Parent.ItemsList.Count; ++index2)
                {
                  if (selectedIList[index1].TraceString == this.frm_Parent.ItemsList[index2].TraceString)
                  {
                    Structures.IGCCashItemList items = this.frm_Parent.ItemsList[index2] with
                    {
                      cType = this.comboBox_NewItem_Coin.SelectedIndex,
                      iPrice = (int) this.numericUpDown_NewItem_Price.Value,
                      Name = this.textBox_NewItem_Name.Text
                    };
                    this.frm_Parent.ItemsList[index2] = items;
                    break;
                  }
                }
              }
              foreach (Structures.IGCCashItemPackages cashItemPackages in (Collection<Structures.IGCCashItemPackages>) selectedIPack)
              {
                this.frm_Parent.ItemsPackage.Remove(cashItemPackages);
                List<string> itemPackagesIndexes = this.frm_Parent.IGC_CashItemPackages_Indexes;
                int num17 = cashItemPackages.GUID;
                string str5 = num17.ToString();
                // ISSUE: variable of a boxed type
                __Boxed<char> local = (ValueType) ',';
                num17 = cashItemPackages.iGUID;
                string str6 = num17.ToString();
                string str7 = str5 + (object) local + str6;
                itemPackagesIndexes.Remove(str7);
              }
              int num18 = 0;
              foreach (Structures.IGCCashItemInfo igcCashItemInfo in this.listBox_PackageItem_AddedItems.Items)
              {
                Structures.IGCCashItemPackages cashItemPackages = new Structures.IGCCashItemPackages()
                {
                  pID = selectedIList[0].pID,
                  GUID = num18,
                  iSeq = num18,
                  iGUID = igcCashItemInfo.GID,
                  iID = igcCashItemInfo.ID,
                  Name = igcCashItemInfo.Name,
                  PackName = this.textBox_NewItem_Name.Text,
                  TraceString = igcCashItemInfo.TraceString
                };
                this.frm_Parent.IGC_CashItemPackages_Indexes.Add(cashItemPackages.GUID.ToString() + (object) ',' + cashItemPackages.iGUID.ToString());
                this.frm_Parent.ItemsPackage.Add(cashItemPackages);
                ++num18;
              }
            }
            else
            {
              for (int index3 = 0; index3 < selectedIList.Count; ++index3)
              {
                for (int index4 = 0; index4 < this.frm_Parent.ItemsList.Count; ++index4)
                {
                  if (selectedIList[index3].TraceString == this.frm_Parent.ItemsList[index4].TraceString)
                  {
                    Structures.IGCCashItemList items = this.frm_Parent.ItemsList[index4] with
                    {
                      Name = this.textBox_NewItem_Name.Text,
                      iPrice = Convert.ToInt32(this.numericUpDown_NewItem_Price.Value),
                      cType = this.comboBox_NewItem_Coin.SelectedIndex
                    };
                    this.frm_Parent.ItemsList[index4] = items;
                    if (index3 + 1 == selectedIList.Count)
                      break;
                  }
                }
              }
              for (int index5 = 0; index5 < selectedIInfo.Count; ++index5)
              {
                for (int index6 = 0; index6 < this.frm_Parent.ItemsInfo.Count; ++index6)
                {
                  if (selectedIInfo[index5].TraceString == this.frm_Parent.ItemsInfo[index6].TraceString)
                  {
                    Structures.IGCCashItemInfo igcCashItemInfo = this.frm_Parent.ItemsInfo[index6] with
                    {
                      Level = (int) this.listBox_NewItem_ItemLevel.SelectedValue,
                      Dur = (int) this.numericUpDown_NewItem_Durability.Value,
                      Skill = this.checkBox_NewItem_Skill.Checked ? 1 : 0,
                      Luck = this.checkBox_NewItem_Luck.Checked ? 1 : 0,
                      Option = (int) this.listBox_NewItem_ItemOption.SelectedValue,
                      TraceNumber = this.frm_Parent.TraceNumber
                    };
                    int num19 = 0;
                    int num20 = this.checkBox_NewItem_ExcOpt1.Checked ? num19 + 1 : num19;
                    int num21 = this.checkBox_NewItem_ExcOpt2.Checked ? num20 + 2 : num20;
                    int num22 = this.checkBox_NewItem_ExcOpt3.Checked ? num21 + 4 : num21;
                    int num23 = this.checkBox_NewItem_ExcOpt4.Checked ? num22 + 8 : num22;
                    int num24 = this.checkBox_NewItem_ExcOpt5.Checked ? num23 + 16 : num23;
                    int num25 = this.checkBox_NewItem_ExcOpt6.Checked ? num24 + 32 : num24;
                    igcCashItemInfo.Exc = num25;
                    igcCashItemInfo.Ancient = (int) this.comboBox_Ancient.SelectedValue;
                    igcCashItemInfo.Socket = (int) this.numericUpDown_NewItem_SocketCount.Value;
                    igcCashItemInfo.Name = this.textBox_NewItem_Name.Text;
                    this.frm_Parent.ItemsInfo[index6] = igcCashItemInfo;
                    if (index5 + 1 == selectedIInfo.Count)
                      break;
                  }
                }
              }
              for (int index7 = 0; index7 < this.frm_Parent.Products.Count; ++index7)
              {
                if (this.frm_Parent.Products[index7].Index1 == selectedIProduct[0].Index1 && this.frm_Parent.Products[index7].Index7 == selectedIProduct[0].Index7)
                {
                  for (int index8 = 0; index8 < selectedIProduct.Count; ++index8)
                  {
                    if (this.frm_Parent.Products[index7].Index1 == selectedIProduct[index8].Index1 && this.frm_Parent.Products[index7].Index7 == selectedIProduct[index8].Index7)
                    {
                      Structures.IBSProduct ibsProduct = selectedIProduct[index8] with
                      {
                        Name = this.textBox_NewItem_Name.Text,
                        BuyTypeTxt1 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "Quantity" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? "Duration" : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "Quantity" : "Duration")))
                      };
                      int int32 = Convert.ToInt32(this.numericUpDown_NewItem_Count.Value);
                      TimeSpan timeSpan = new TimeSpan();
                      TimeSpan ts = TimeSpan.FromMinutes((double) int32);
                      timeSpan.Add(ts);
                      string str8 = "[" + (ts.TotalDays >= 1.0 ? Convert.ToInt32(ts.TotalDays).ToString() + " Day(s)" : (ts.TotalHours >= 1.0 ? Convert.ToInt32(ts.TotalHours).ToString() + " Hour(s)" : Convert.ToInt32(ts.TotalMinutes).ToString() + " Minute(s)"));
                      if (str8.Contains("Day(s)"))
                        str8 = str8 + (ts.Hours >= 1 ? ", " + Convert.ToInt32(ts.Hours).ToString() + " Hour(s)" : "") + (ts.Minutes >= 1 ? ", " + Convert.ToInt32(ts.Minutes).ToString() + " Minute(s)" : "");
                      else if (str8.Contains("Hour(s)"))
                        str8 += ts.Minutes >= 1 ? ", " + Convert.ToInt32(ts.Minutes).ToString() + " Minute(s)" : "";
                      string str9 = str8 + "]";
                      ibsProduct.TypeCount = int32.ToString();
                      ibsProduct.BuyTypeTxt2 = this.comboBox_NewItem_CountType.SelectedIndex == 0 ? "EA" : (this.comboBox_NewItem_CountType.SelectedIndex == 1 ? str9 : (this.comboBox_NewItem_CountType.SelectedIndex == 2 ? str9 : (this.comboBox_NewItem_CountType.SelectedIndex == 3 ? "NA" : "Days")));
                      ibsProduct.Price = (int) this.numericUpDown_NewItem_Price.Value;
                      this.frm_Parent.Products[this.frm_Parent.Products.IndexOf(selectedIProduct[index8])] = ibsProduct;
                    }
                  }
                  break;
                }
              }
              for (int index = 0; index < this.frm_Parent.Packages.Count; ++index)
              {
                if (selectedIPackage.TraceString == this.frm_Parent.Packages[index].TraceString)
                {
                  Structures.IBSPackage package = this.frm_Parent.Packages[index] with
                  {
                    Name = this.textBox_NewItem_Name.Text,
                    Price = (int) this.numericUpDown_NewItem_Price.Value,
                    Info = this.richTextBox_NewItem_Info.Text.Replace("\n", "#"),
                    Unk3 = Convert.ToInt16(this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 185 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 184 : 185)),
                    CoinTxt1 = this.comboBox_NewItem_Coin.Text,
                    CoinTxt2 = this.comboBox_NewItem_Coin.Text,
                    ServerCatIndex = this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 508 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 509 : 0),
                    Unk10 = Convert.ToInt16(this.comboBox_NewItem_Coin.SelectedIndex == 0 ? 2 : (this.comboBox_NewItem_Coin.SelectedIndex == 1 ? 3 : 5))
                  };
                  this.frm_Parent.Packages[index] = package;
                  break;
                }
              }
            }
            this.frm_Parent.UpdateSelectedItem(this.frm_Parent.LastSelectedPB);
            this.textBox_Info.Text = "[INFO] Selected item Updated successfully.";
          }
        }
      }
    }

    private void buttonClearAll_Multi_Click(object sender, EventArgs e)
    {
      for (int index = 1; index <= 6; ++index)
      {
        ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_isMulti_" + (object) index]).Checked = false;
        ((TextBoxBase) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["textBox_Name_Multi_" + (object) index]).Clear();
        NumericUpDown control1 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Count_Multi_" + (object) index];
        control1.Value = control1.Minimum;
        NumericUpDown control2 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Price_Multi_" + (object) index];
        control2.Value = control2.Minimum;
        ((ListControl) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["listBox_Level_Multi_" + (object) index]).SelectedIndex = 0;
        ((ListControl) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["listBox_Option_Multi_" + (object) index]).SelectedIndex = 0;
        ((ListControl) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["comboBox_Ancient_Multi_" + (object) index]).SelectedIndex = 0;
        ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption1_Multi_" + (object) index]).Checked = false;
        ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption2_Multi_" + (object) index]).Checked = false;
        ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption3_Multi_" + (object) index]).Checked = false;
        ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption4_Multi_" + (object) index]).Checked = false;
        ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption5_Multi_" + (object) index]).Checked = false;
        ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption6_Multi_" + (object) index]).Checked = false;
        NumericUpDown control3 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Sockets_Multi_" + (object) index];
        control3.Value = control3.Minimum;
        NumericUpDown control4 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Durability_Multi_" + (object) index];
        control4.Value = control4.Maximum;
        ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_Luck_Multi_" + (object) index]).Checked = false;
        ((CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_Skill_Multi_" + (object) index]).Checked = false;
      }
    }

    private void checkBox_AddItem_FOItem_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox_AddItem_FOItem.Checked)
      {
        this.checkBox_NewItem_ExcOpt1.Checked = true;
        this.checkBox_NewItem_ExcOpt2.Checked = true;
        this.checkBox_NewItem_ExcOpt3.Checked = true;
        this.checkBox_NewItem_ExcOpt4.Checked = true;
        this.checkBox_NewItem_ExcOpt5.Checked = true;
        this.checkBox_NewItem_ExcOpt6.Checked = true;
        this.listBox_NewItem_ItemLevel.SelectedIndex = 15;
        this.listBox_NewItem_ItemOption.SelectedIndex = 7;
        this.checkBox_NewItem_Luck.Checked = true;
      }
      else
      {
        this.checkBox_NewItem_ExcOpt1.Checked = false;
        this.checkBox_NewItem_ExcOpt2.Checked = false;
        this.checkBox_NewItem_ExcOpt3.Checked = false;
        this.checkBox_NewItem_ExcOpt4.Checked = false;
        this.checkBox_NewItem_ExcOpt5.Checked = false;
        this.checkBox_NewItem_ExcOpt6.Checked = false;
        this.listBox_NewItem_ItemLevel.SelectedIndex = 0;
        this.listBox_NewItem_ItemOption.SelectedIndex = 0;
        this.checkBox_NewItem_Luck.Checked = false;
      }
    }

    private void checkBox_MultiItem_CheckedChanged(object sender, EventArgs e)
    {
      this.groupBox_MultiItem.Enabled = this.checkBox_MultiItem.Checked;
      if (!this.checkBox_MultiItem.Checked)
        return;
      this.checkBox_PackageItem.Checked = false;
    }

    private void checkBox_PackageItem_CheckedChanged(object sender, EventArgs e)
    {
      this.groupBox_PackageItem.Enabled = this.checkBox_PackageItem.Checked;
      if (this.checkBox_PackageItem.Checked)
      {
        this.checkBox_MultiItem.Checked = false;
        this.numericUpDown_NewItem_Count.Enabled = false;
        this.numericUpDown_NewItem_Count.Value = 1M;
        this.comboBox_NewItem_CountType.Enabled = false;
        this.groupBox_ItemProperties.Enabled = false;
        this.comboBox_NewItem_CountType.SelectedIndex = 0;
      }
      else
      {
        this.numericUpDown_NewItem_Count.Enabled = true;
        this.comboBox_NewItem_CountType.Enabled = true;
        this.groupBox_ItemProperties.Enabled = true;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void Form_CashShop_AddItems_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.frm_Parent.isParentClosing || e.CloseReason != CloseReason.UserClosing)
        return;
      e.Cancel = true;
    }

    private void Form_CashShop_AddItems_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Modifiers != Keys.Control)
        return;
      if (e.KeyCode == Keys.S)
        this.button_UpdateExistingItem.PerformClick();
      else if (e.KeyCode == Keys.D)
      {
        this.button_AddItemToDB.PerformClick();
      }
      else
      {
        if (e.KeyCode != Keys.F)
          return;
        this.button_NewItem_Add.PerformClick();
      }
    }

    private void Form_CashShop_AddItems_Load(object sender, EventArgs e)
    {
      this.TopMost = false;
      this.frm_Parent = (CashShopEditor) Application.OpenForms["CashShopEditor"];
      this.isEx700ItemList = ((Form1) Application.OpenForms[0]).isEx700ItemList ? 1 : 0;
      string[,] strArray = (string[,]) null;
      if (this.isEx700ItemList == 1)
        this.frm_Parent.strct.ReadItemList("Data\\ItemListSettings_ex700.ini", true, ref this.L_Groups, ref this.L_Swords, ref this.L_Axes, ref this.L_MacesScepters, ref this.L_Spears, ref this.L_BowsCrossBows, ref this.L_Staffs, ref this.L_Shields, ref this.L_Helms, ref this.L_Armors, ref this.L_Pants, ref this.L_Gloves, ref this.L_Boots, ref this.L_WingsSkillsSeedsOthers, ref this.L_Others1, ref this.L_Others2, ref this.L_Scrolls, ref strArray, ref strArray);
      else
        this.frm_Parent.strct.ReadItemList("Data\\ItemListSettings.ini", false, ref this.L_Groups, ref this.L_Swords, ref this.L_Axes, ref this.L_MacesScepters, ref this.L_Spears, ref this.L_BowsCrossBows, ref this.L_Staffs, ref this.L_Shields, ref this.L_Helms, ref this.L_Armors, ref this.L_Pants, ref this.L_Gloves, ref this.L_Boots, ref this.L_WingsSkillsSeedsOthers, ref this.L_Others1, ref this.L_Others2, ref this.L_Scrolls, ref strArray, ref strArray);
      this.listBox_NewItem_ItemGroup.DisplayMember = "GroupName";
      this.listBox_NewItem_ItemGroup.ValueMember = "Group";
      this.listBox_NewItem_ItemGroup.DataSource = (object) this.L_Groups;
      this.Setc_LevelData(ref this.listBox_NewItem_ItemLevel);
      this.Setc_OptionData(ref this.listBox_NewItem_ItemOption);
      this.comboBox_NewItem_Coin.SelectedIndex = 0;
      this.comboBox_NewItem_CountType.SelectedIndex = 0;
      this.Setc_LevelData(ref this.listBox_Level_Multi_1, ref this.c_LevelDatas_M1);
      this.Setc_LevelData(ref this.listBox_Level_Multi_2, ref this.c_LevelDatas_M2);
      this.Setc_LevelData(ref this.listBox_Level_Multi_3, ref this.c_LevelDatas_M3);
      this.Setc_LevelData(ref this.listBox_Level_Multi_4, ref this.c_LevelDatas_M4);
      this.Setc_LevelData(ref this.listBox_Level_Multi_5, ref this.c_LevelDatas_M5);
      this.Setc_LevelData(ref this.listBox_Level_Multi_6, ref this.c_LevelDatas_M6);
      this.Setc_OptionData(ref this.listBox_Option_Multi_1, ref this.c_OptionDatas_M1);
      this.Setc_OptionData(ref this.listBox_Option_Multi_2, ref this.c_OptionDatas_M2);
      this.Setc_OptionData(ref this.listBox_Option_Multi_3, ref this.c_OptionDatas_M3);
      this.Setc_OptionData(ref this.listBox_Option_Multi_4, ref this.c_OptionDatas_M4);
      this.Setc_OptionData(ref this.listBox_Option_Multi_5, ref this.c_OptionDatas_M5);
      this.Setc_OptionData(ref this.listBox_Option_Multi_6, ref this.c_OptionDatas_M6);
      this.Setc_AncientData(ref this.comboBox_Ancient, ref this.c_AncientDatas);
      this.Setc_AncientData(ref this.comboBox_Ancient_Multi_1, ref this.c_AncientDatas_M1);
      this.Setc_AncientData(ref this.comboBox_Ancient_Multi_2, ref this.c_AncientDatas_M2);
      this.Setc_AncientData(ref this.comboBox_Ancient_Multi_3, ref this.c_AncientDatas_M3);
      this.Setc_AncientData(ref this.comboBox_Ancient_Multi_4, ref this.c_AncientDatas_M4);
      this.Setc_AncientData(ref this.comboBox_Ancient_Multi_5, ref this.c_AncientDatas_M5);
      this.Setc_AncientData(ref this.comboBox_Ancient_Multi_6, ref this.c_AncientDatas_M6);
      this.comboBox_PackageItem_ItemsDatabase.DataSource = (object) this.frm_Parent.ItemsInfo;
      this.comboBox_PackageItem_ItemsDatabase.ValueMember = "Name";
      this.comboBox_PackageItem_ItemsDatabase.DisplayMember = "Name";
      this.listBox_PackageItem_AddedItems.DataSource = (object) this.PackageItems;
      this.listBox_PackageItem_AddedItems.DisplayMember = "Name";
      this.listBox_PackageItem_AddedItems.ValueMember = "Name";
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form_CashShop_AddItems));
      this.panel_ItemAdd = new Panel();
      this.button_UpdateExistingItem = new Button();
      this.button_AddItemToDB = new Button();
      this.groupBox2 = new GroupBox();
      this.label8 = new Label();
      this.groupBox_PackageItem = new GroupBox();
      this.comboBox_PackageItem_ItemsDatabase = new ComboBox();
      this.button_PackageItem_RemoveFromList = new Button();
      this.button_PackageItem_AddToList = new Button();
      this.label27 = new Label();
      this.listBox_PackageItem_AddedItems = new ListBox();
      this.checkBox_PackageItem = new CheckBox();
      this.checkBox_MultiItem = new CheckBox();
      this.groupBox_MultiItem = new GroupBox();
      this.buttonClearAll_Multi = new Button();
      this.tabControl1 = new TabControl();
      this.tabPage_MultiOption_1 = new TabPage();
      this.numericUpDown_Durability_Multi_1 = new NumericUpDown();
      this.numericUpDown_Sockets_Multi_1 = new NumericUpDown();
      this.label41 = new Label();
      this.comboBox_Ancient_Multi_1 = new ComboBox();
      this.label39 = new Label();
      this.checkBox_Luck_Multi_1 = new CheckBox();
      this.groupBox_1 = new GroupBox();
      this.radioButton_Wings_Multi_1 = new RadioButton();
      this.radioButton_Armor_Multi_1 = new RadioButton();
      this.radioButton_Weapon_Multi_1 = new RadioButton();
      this.checkBox_ExcOption6_Multi_1 = new CheckBox();
      this.checkBox_ExcOption5_Multi_1 = new CheckBox();
      this.checkBox_ExcOption4_Multi_1 = new CheckBox();
      this.checkBox_ExcOption3_Multi_1 = new CheckBox();
      this.checkBox_ExcOption2_Multi_1 = new CheckBox();
      this.checkBox_ExcOption1_Multi_1 = new CheckBox();
      this.checkBox_Skill_Multi_1 = new CheckBox();
      this.listBox_Option_Multi_1 = new ListBox();
      this.textBox_Name_Multi_1 = new TextBox();
      this.label15 = new Label();
      this.label11 = new Label();
      this.label10 = new Label();
      this.label12 = new Label();
      this.numericUpDown_Price_Multi_1 = new NumericUpDown();
      this.listBox_Level_Multi_1 = new ListBox();
      this.label9 = new Label();
      this.checkBox_isMulti_1 = new CheckBox();
      this.numericUpDown_Count_Multi_1 = new NumericUpDown();
      this.label42 = new Label();
      this.tabPage_MultiOption_2 = new TabPage();
      this.numericUpDown_Durability_Multi_2 = new NumericUpDown();
      this.numericUpDown_Sockets_Multi_2 = new NumericUpDown();
      this.comboBox_Ancient_Multi_2 = new ComboBox();
      this.label43 = new Label();
      this.label44 = new Label();
      this.label45 = new Label();
      this.checkBox_Luck_Multi_2 = new CheckBox();
      this.groupBox_2 = new GroupBox();
      this.radioButton_Wings_Multi_2 = new RadioButton();
      this.radioButton_Armor_Multi_2 = new RadioButton();
      this.radioButton_Weapon_Multi_2 = new RadioButton();
      this.checkBox_ExcOption6_Multi_2 = new CheckBox();
      this.checkBox_ExcOption5_Multi_2 = new CheckBox();
      this.checkBox_ExcOption4_Multi_2 = new CheckBox();
      this.checkBox_ExcOption3_Multi_2 = new CheckBox();
      this.checkBox_ExcOption2_Multi_2 = new CheckBox();
      this.checkBox_ExcOption1_Multi_2 = new CheckBox();
      this.checkBox_Skill_Multi_2 = new CheckBox();
      this.listBox_Option_Multi_2 = new ListBox();
      this.textBox_Name_Multi_2 = new TextBox();
      this.label13 = new Label();
      this.label14 = new Label();
      this.label16 = new Label();
      this.label17 = new Label();
      this.numericUpDown_Price_Multi_2 = new NumericUpDown();
      this.listBox_Level_Multi_2 = new ListBox();
      this.label18 = new Label();
      this.checkBox_isMulti_2 = new CheckBox();
      this.numericUpDown_Count_Multi_2 = new NumericUpDown();
      this.tabPage_MultiOption_3 = new TabPage();
      this.label48 = new Label();
      this.numericUpDown_Durability_Multi_3 = new NumericUpDown();
      this.numericUpDown_Sockets_Multi_3 = new NumericUpDown();
      this.comboBox_Ancient_Multi_3 = new ComboBox();
      this.checkBox_Luck_Multi_3 = new CheckBox();
      this.groupBox_3 = new GroupBox();
      this.radioButton_Wings_Multi_3 = new RadioButton();
      this.radioButton_Armor_Multi_3 = new RadioButton();
      this.radioButton_Weapon_Multi_3 = new RadioButton();
      this.checkBox_ExcOption6_Multi_3 = new CheckBox();
      this.checkBox_ExcOption5_Multi_3 = new CheckBox();
      this.checkBox_ExcOption4_Multi_3 = new CheckBox();
      this.checkBox_ExcOption3_Multi_3 = new CheckBox();
      this.checkBox_ExcOption2_Multi_3 = new CheckBox();
      this.checkBox_ExcOption1_Multi_3 = new CheckBox();
      this.checkBox_Skill_Multi_3 = new CheckBox();
      this.listBox_Option_Multi_3 = new ListBox();
      this.textBox_Name_Multi_3 = new TextBox();
      this.label19 = new Label();
      this.label20 = new Label();
      this.label23 = new Label();
      this.numericUpDown_Price_Multi_3 = new NumericUpDown();
      this.listBox_Level_Multi_3 = new ListBox();
      this.label40 = new Label();
      this.checkBox_isMulti_3 = new CheckBox();
      this.numericUpDown_Count_Multi_3 = new NumericUpDown();
      this.label21 = new Label();
      this.label46 = new Label();
      this.label47 = new Label();
      this.tabPage_MultiOption_4 = new TabPage();
      this.label51 = new Label();
      this.numericUpDown_Durability_Multi_4 = new NumericUpDown();
      this.numericUpDown_Sockets_Multi_4 = new NumericUpDown();
      this.comboBox_Ancient_Multi_4 = new ComboBox();
      this.checkBox_Luck_Multi_4 = new CheckBox();
      this.groupBox_4 = new GroupBox();
      this.radioButton_Wings_Multi_4 = new RadioButton();
      this.radioButton_Armor_Multi_4 = new RadioButton();
      this.radioButton_Weapon_Multi_4 = new RadioButton();
      this.checkBox_ExcOption6_Multi_4 = new CheckBox();
      this.checkBox_ExcOption5_Multi_4 = new CheckBox();
      this.checkBox_ExcOption4_Multi_4 = new CheckBox();
      this.checkBox_ExcOption3_Multi_4 = new CheckBox();
      this.checkBox_ExcOption2_Multi_4 = new CheckBox();
      this.checkBox_ExcOption1_Multi_4 = new CheckBox();
      this.checkBox_Skill_Multi_4 = new CheckBox();
      this.listBox_Option_Multi_4 = new ListBox();
      this.textBox_Name_Multi_4 = new TextBox();
      this.label22 = new Label();
      this.label24 = new Label();
      this.label25 = new Label();
      this.label26 = new Label();
      this.numericUpDown_Price_Multi_4 = new NumericUpDown();
      this.listBox_Level_Multi_4 = new ListBox();
      this.label28 = new Label();
      this.checkBox_isMulti_4 = new CheckBox();
      this.numericUpDown_Count_Multi_4 = new NumericUpDown();
      this.label50 = new Label();
      this.label49 = new Label();
      this.tabPage_MultiOption_5 = new TabPage();
      this.numericUpDown_Durability_Multi_5 = new NumericUpDown();
      this.label52 = new Label();
      this.numericUpDown_Sockets_Multi_5 = new NumericUpDown();
      this.comboBox_Ancient_Multi_5 = new ComboBox();
      this.checkBox_Luck_Multi_5 = new CheckBox();
      this.groupBox_5 = new GroupBox();
      this.radioButton_Wings_Multi_5 = new RadioButton();
      this.radioButton_Armor_Multi_5 = new RadioButton();
      this.radioButton_Weapon_Multi_5 = new RadioButton();
      this.checkBox_ExcOption6_Multi_5 = new CheckBox();
      this.checkBox_ExcOption5_Multi_5 = new CheckBox();
      this.checkBox_ExcOption4_Multi_5 = new CheckBox();
      this.checkBox_ExcOption3_Multi_5 = new CheckBox();
      this.checkBox_ExcOption2_Multi_5 = new CheckBox();
      this.checkBox_ExcOption1_Multi_5 = new CheckBox();
      this.checkBox_Skill_Multi_5 = new CheckBox();
      this.listBox_Option_Multi_5 = new ListBox();
      this.textBox_Name_Multi_5 = new TextBox();
      this.label29 = new Label();
      this.label30 = new Label();
      this.label31 = new Label();
      this.label32 = new Label();
      this.numericUpDown_Price_Multi_5 = new NumericUpDown();
      this.listBox_Level_Multi_5 = new ListBox();
      this.label33 = new Label();
      this.checkBox_isMulti_5 = new CheckBox();
      this.numericUpDown_Count_Multi_5 = new NumericUpDown();
      this.label54 = new Label();
      this.label53 = new Label();
      this.tabPage_MultiOption_6 = new TabPage();
      this.numericUpDown_Durability_Multi_6 = new NumericUpDown();
      this.label55 = new Label();
      this.numericUpDown_Sockets_Multi_6 = new NumericUpDown();
      this.comboBox_Ancient_Multi_6 = new ComboBox();
      this.checkBox_Luck_Multi_6 = new CheckBox();
      this.groupBox_6 = new GroupBox();
      this.radioButton_Wings_Multi_6 = new RadioButton();
      this.radioButton_Armor_Multi_6 = new RadioButton();
      this.radioButton_Weapon_Multi_6 = new RadioButton();
      this.checkBox_ExcOption6_Multi_6 = new CheckBox();
      this.checkBox_ExcOption5_Multi_6 = new CheckBox();
      this.checkBox_ExcOption4_Multi_6 = new CheckBox();
      this.checkBox_ExcOption3_Multi_6 = new CheckBox();
      this.checkBox_ExcOption2_Multi_6 = new CheckBox();
      this.checkBox_ExcOption1_Multi_6 = new CheckBox();
      this.checkBox_Skill_Multi_6 = new CheckBox();
      this.listBox_Option_Multi_6 = new ListBox();
      this.textBox_Name_Multi_6 = new TextBox();
      this.label34 = new Label();
      this.label35 = new Label();
      this.label36 = new Label();
      this.label37 = new Label();
      this.numericUpDown_Price_Multi_6 = new NumericUpDown();
      this.listBox_Level_Multi_6 = new ListBox();
      this.label38 = new Label();
      this.checkBox_isMulti_6 = new CheckBox();
      this.numericUpDown_Count_Multi_6 = new NumericUpDown();
      this.label57 = new Label();
      this.label56 = new Label();
      this.comboBox_NewItem_CountType = new ComboBox();
      this.numericUpDown_NewItem_Count = new NumericUpDown();
      this.comboBox_NewItem_Coin = new ComboBox();
      this.numericUpDown_NewItem_Price = new NumericUpDown();
      this.textBox_NewItem_Name = new TextBox();
      this.richTextBox_NewItem_Info = new RichTextBox();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.groupBox_ItemProperties = new GroupBox();
      this.groupBox_NewItem_ExcOpt = new GroupBox();
      this.radioButton_NewItem_ExcWings = new RadioButton();
      this.radioButton_NewItem_ExcArmor = new RadioButton();
      this.radioButton_NewItem_ExcWeapon = new RadioButton();
      this.checkBox_NewItem_ExcOpt6 = new CheckBox();
      this.checkBox_NewItem_ExcOpt5 = new CheckBox();
      this.checkBox_NewItem_ExcOpt4 = new CheckBox();
      this.checkBox_NewItem_ExcOpt3 = new CheckBox();
      this.checkBox_NewItem_ExcOpt2 = new CheckBox();
      this.checkBox_NewItem_ExcOpt1 = new CheckBox();
      this.listBox_NewItem_ItemOption = new ListBox();
      this.checkBox_AddItem_FOItem = new CheckBox();
      this.checkBox_NewItem_Luck = new CheckBox();
      this.groupBox9 = new GroupBox();
      this.comboBox_Ancient = new ComboBox();
      this.label3 = new Label();
      this.checkBox_NewItem_Skill = new CheckBox();
      this.groupBox8 = new GroupBox();
      this.numericUpDown_NewItem_SocketCount = new NumericUpDown();
      this.label4 = new Label();
      this.groupBox6 = new GroupBox();
      this.numericUpDown_NewItem_Durability = new NumericUpDown();
      this.listBox_NewItem_ItemLevel = new ListBox();
      this.button_NewItem_Add = new Button();
      this.pictureBox_NewItem_ItemPreview = new PictureBox();
      this.listBox_NewItem_ItemIndex = new ListBox();
      this.listBox_NewItem_ItemGroup = new ListBox();
      this.textBox_Info = new TextBox();
      this.panel_ItemAdd.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox_PackageItem.SuspendLayout();
      this.groupBox_MultiItem.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage_MultiOption_1.SuspendLayout();
      this.numericUpDown_Durability_Multi_1.BeginInit();
      this.numericUpDown_Sockets_Multi_1.BeginInit();
      this.groupBox_1.SuspendLayout();
      this.numericUpDown_Price_Multi_1.BeginInit();
      this.numericUpDown_Count_Multi_1.BeginInit();
      this.tabPage_MultiOption_2.SuspendLayout();
      this.numericUpDown_Durability_Multi_2.BeginInit();
      this.numericUpDown_Sockets_Multi_2.BeginInit();
      this.groupBox_2.SuspendLayout();
      this.numericUpDown_Price_Multi_2.BeginInit();
      this.numericUpDown_Count_Multi_2.BeginInit();
      this.tabPage_MultiOption_3.SuspendLayout();
      this.numericUpDown_Durability_Multi_3.BeginInit();
      this.numericUpDown_Sockets_Multi_3.BeginInit();
      this.groupBox_3.SuspendLayout();
      this.numericUpDown_Price_Multi_3.BeginInit();
      this.numericUpDown_Count_Multi_3.BeginInit();
      this.tabPage_MultiOption_4.SuspendLayout();
      this.numericUpDown_Durability_Multi_4.BeginInit();
      this.numericUpDown_Sockets_Multi_4.BeginInit();
      this.groupBox_4.SuspendLayout();
      this.numericUpDown_Price_Multi_4.BeginInit();
      this.numericUpDown_Count_Multi_4.BeginInit();
      this.tabPage_MultiOption_5.SuspendLayout();
      this.numericUpDown_Durability_Multi_5.BeginInit();
      this.numericUpDown_Sockets_Multi_5.BeginInit();
      this.groupBox_5.SuspendLayout();
      this.numericUpDown_Price_Multi_5.BeginInit();
      this.numericUpDown_Count_Multi_5.BeginInit();
      this.tabPage_MultiOption_6.SuspendLayout();
      this.numericUpDown_Durability_Multi_6.BeginInit();
      this.numericUpDown_Sockets_Multi_6.BeginInit();
      this.groupBox_6.SuspendLayout();
      this.numericUpDown_Price_Multi_6.BeginInit();
      this.numericUpDown_Count_Multi_6.BeginInit();
      this.numericUpDown_NewItem_Count.BeginInit();
      this.numericUpDown_NewItem_Price.BeginInit();
      this.groupBox_ItemProperties.SuspendLayout();
      this.groupBox_NewItem_ExcOpt.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.numericUpDown_NewItem_SocketCount.BeginInit();
      this.groupBox6.SuspendLayout();
      this.numericUpDown_NewItem_Durability.BeginInit();
      ((ISupportInitialize) this.pictureBox_NewItem_ItemPreview).BeginInit();
      this.SuspendLayout();
      this.panel_ItemAdd.BackgroundImage = (Image) Resources.panel_ItemAdd_BackgroundImage;
      this.panel_ItemAdd.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel_ItemAdd.Controls.Add((Control) this.button_UpdateExistingItem);
      this.panel_ItemAdd.Controls.Add((Control) this.button_AddItemToDB);
      this.panel_ItemAdd.Controls.Add((Control) this.groupBox2);
      this.panel_ItemAdd.Controls.Add((Control) this.groupBox_ItemProperties);
      this.panel_ItemAdd.Controls.Add((Control) this.button_NewItem_Add);
      this.panel_ItemAdd.Controls.Add((Control) this.pictureBox_NewItem_ItemPreview);
      this.panel_ItemAdd.Controls.Add((Control) this.listBox_NewItem_ItemIndex);
      this.panel_ItemAdd.Controls.Add((Control) this.listBox_NewItem_ItemGroup);
      this.panel_ItemAdd.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.panel_ItemAdd.Location = new Point(0, 0);
      this.panel_ItemAdd.Name = "panel_ItemAdd";
      this.panel_ItemAdd.Size = new Size(911, 478);
      this.panel_ItemAdd.TabIndex = 3;
      this.button_UpdateExistingItem.ForeColor = Color.Black;
      this.button_UpdateExistingItem.Location = new Point(329, 427);
      this.button_UpdateExistingItem.Name = "button_UpdateExistingItem";
      this.button_UpdateExistingItem.Size = new Size(178, 32);
      this.button_UpdateExistingItem.TabIndex = 27;
      this.button_UpdateExistingItem.Text = "[Update] Selected Item\r\nCtrl + S";
      this.button_UpdateExistingItem.UseVisualStyleBackColor = true;
      this.button_UpdateExistingItem.Click += new EventHandler(this.button_UpdateExistingItem_Click);
      this.button_AddItemToDB.ForeColor = Color.Black;
      this.button_AddItemToDB.Location = new Point(510, 427);
      this.button_AddItemToDB.Name = "button_AddItemToDB";
      this.button_AddItemToDB.Size = new Size(187, 32);
      this.button_AddItemToDB.TabIndex = 26;
      this.button_AddItemToDB.Text = "Add to [Item's Database]\r\nCtrl + D";
      this.button_AddItemToDB.UseVisualStyleBackColor = true;
      this.button_AddItemToDB.Click += new EventHandler(this.button_AddItemToDB_Click);
      this.groupBox2.BackColor = Color.Transparent;
      this.groupBox2.Controls.Add((Control) this.label8);
      this.groupBox2.Controls.Add((Control) this.groupBox_PackageItem);
      this.groupBox2.Controls.Add((Control) this.checkBox_PackageItem);
      this.groupBox2.Controls.Add((Control) this.checkBox_MultiItem);
      this.groupBox2.Controls.Add((Control) this.groupBox_MultiItem);
      this.groupBox2.Controls.Add((Control) this.comboBox_NewItem_CountType);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_NewItem_Count);
      this.groupBox2.Controls.Add((Control) this.comboBox_NewItem_Coin);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_NewItem_Price);
      this.groupBox2.Controls.Add((Control) this.textBox_NewItem_Name);
      this.groupBox2.Controls.Add((Control) this.richTextBox_NewItem_Info);
      this.groupBox2.Controls.Add((Control) this.label7);
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox2.ForeColor = Color.DarkGoldenrod;
      this.groupBox2.Location = new Point(329, 23);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(559, 399);
      this.groupBox2.TabIndex = 21;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Cash Shop Item Options";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(12, 50);
      this.label8.Name = "label8";
      this.label8.Size = new Size(31, 13);
      this.label8.TabIndex = 50;
      this.label8.Text = "Info:";
      this.groupBox_PackageItem.Controls.Add((Control) this.comboBox_PackageItem_ItemsDatabase);
      this.groupBox_PackageItem.Controls.Add((Control) this.button_PackageItem_RemoveFromList);
      this.groupBox_PackageItem.Controls.Add((Control) this.button_PackageItem_AddToList);
      this.groupBox_PackageItem.Controls.Add((Control) this.label27);
      this.groupBox_PackageItem.Controls.Add((Control) this.listBox_PackageItem_AddedItems);
      this.groupBox_PackageItem.Enabled = false;
      this.groupBox_PackageItem.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_PackageItem.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.groupBox_PackageItem.Location = new Point(300, 36);
      this.groupBox_PackageItem.Name = "groupBox_PackageItem";
      this.groupBox_PackageItem.Size = new Size(243, 159);
      this.groupBox_PackageItem.TabIndex = 32;
      this.groupBox_PackageItem.TabStop = false;
      this.groupBox_PackageItem.Text = "Package Item Options";
      this.comboBox_PackageItem_ItemsDatabase.DropDownHeight = 105;
      this.comboBox_PackageItem_ItemsDatabase.DropDownWidth = (int) byte.MaxValue;
      this.comboBox_PackageItem_ItemsDatabase.FormattingEnabled = true;
      this.comboBox_PackageItem_ItemsDatabase.IntegralHeight = false;
      this.comboBox_PackageItem_ItemsDatabase.Location = new Point(58, 18);
      this.comboBox_PackageItem_ItemsDatabase.Name = "comboBox_PackageItem_ItemsDatabase";
      this.comboBox_PackageItem_ItemsDatabase.Size = new Size(115, 21);
      this.comboBox_PackageItem_ItemsDatabase.TabIndex = 0;
      this.button_PackageItem_RemoveFromList.ForeColor = SystemColors.ControlText;
      this.button_PackageItem_RemoveFromList.Location = new Point(7, 134);
      this.button_PackageItem_RemoveFromList.Name = "button_PackageItem_RemoveFromList";
      this.button_PackageItem_RemoveFromList.Size = new Size(230, 18);
      this.button_PackageItem_RemoveFromList.TabIndex = 4;
      this.button_PackageItem_RemoveFromList.Text = "Remove";
      this.button_PackageItem_RemoveFromList.UseVisualStyleBackColor = true;
      this.button_PackageItem_RemoveFromList.Click += new EventHandler(this.button_PackageItem_RemoveFromList_Click);
      this.button_PackageItem_AddToList.ForeColor = SystemColors.ControlText;
      this.button_PackageItem_AddToList.Location = new Point(179, 18);
      this.button_PackageItem_AddToList.Name = "button_PackageItem_AddToList";
      this.button_PackageItem_AddToList.Size = new Size(58, 19);
      this.button_PackageItem_AddToList.TabIndex = 3;
      this.button_PackageItem_AddToList.Text = "Add";
      this.button_PackageItem_AddToList.UseVisualStyleBackColor = true;
      this.button_PackageItem_AddToList.Click += new EventHandler(this.button_PackageItem_AddToList_Click);
      this.label27.AutoSize = true;
      this.label27.ForeColor = Color.White;
      this.label27.Location = new Point(6, 21);
      this.label27.Name = "label27";
      this.label27.Size = new Size(50, 13);
      this.label27.TabIndex = 2;
      this.label27.Text = "Item DB:";
      this.listBox_PackageItem_AddedItems.FormattingEnabled = true;
      this.listBox_PackageItem_AddedItems.HorizontalScrollbar = true;
      this.listBox_PackageItem_AddedItems.Location = new Point(7, 41);
      this.listBox_PackageItem_AddedItems.Name = "listBox_PackageItem_AddedItems";
      this.listBox_PackageItem_AddedItems.Size = new Size(230, 82);
      this.listBox_PackageItem_AddedItems.TabIndex = 1;
      this.checkBox_PackageItem.AutoSize = true;
      this.checkBox_PackageItem.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_PackageItem.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.checkBox_PackageItem.Location = new Point(300, 17);
      this.checkBox_PackageItem.Name = "checkBox_PackageItem";
      this.checkBox_PackageItem.Size = new Size(93, 17);
      this.checkBox_PackageItem.TabIndex = 31;
      this.checkBox_PackageItem.Text = "Package Item";
      this.checkBox_PackageItem.UseVisualStyleBackColor = true;
      this.checkBox_PackageItem.CheckedChanged += new EventHandler(this.checkBox_PackageItem_CheckedChanged);
      this.checkBox_MultiItem.AutoSize = true;
      this.checkBox_MultiItem.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_MultiItem.ForeColor = Color.PaleGreen;
      this.checkBox_MultiItem.Location = new Point(15, 172);
      this.checkBox_MultiItem.Name = "checkBox_MultiItem";
      this.checkBox_MultiItem.Size = new Size(78, 17);
      this.checkBox_MultiItem.TabIndex = 30;
      this.checkBox_MultiItem.Text = "Multi Item";
      this.checkBox_MultiItem.UseVisualStyleBackColor = true;
      this.checkBox_MultiItem.CheckedChanged += new EventHandler(this.checkBox_MultiItem_CheckedChanged);
      this.groupBox_MultiItem.Controls.Add((Control) this.buttonClearAll_Multi);
      this.groupBox_MultiItem.Controls.Add((Control) this.tabControl1);
      this.groupBox_MultiItem.Enabled = false;
      this.groupBox_MultiItem.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_MultiItem.ForeColor = Color.PaleGreen;
      this.groupBox_MultiItem.Location = new Point(15, 193);
      this.groupBox_MultiItem.Name = "groupBox_MultiItem";
      this.groupBox_MultiItem.Size = new Size(528, 199);
      this.groupBox_MultiItem.TabIndex = 29;
      this.groupBox_MultiItem.TabStop = false;
      this.groupBox_MultiItem.Text = "Multi Item Options";
      this.buttonClearAll_Multi.BackColor = Color.Transparent;
      this.buttonClearAll_Multi.ForeColor = Color.Black;
      this.buttonClearAll_Multi.Location = new Point(413, 13);
      this.buttonClearAll_Multi.Name = "buttonClearAll_Multi";
      this.buttonClearAll_Multi.Size = new Size(110, 19);
      this.buttonClearAll_Multi.TabIndex = 49;
      this.buttonClearAll_Multi.Text = "Clear All Options";
      this.buttonClearAll_Multi.UseVisualStyleBackColor = false;
      this.buttonClearAll_Multi.Click += new EventHandler(this.buttonClearAll_Multi_Click);
      this.tabControl1.Controls.Add((Control) this.tabPage_MultiOption_1);
      this.tabControl1.Controls.Add((Control) this.tabPage_MultiOption_2);
      this.tabControl1.Controls.Add((Control) this.tabPage_MultiOption_3);
      this.tabControl1.Controls.Add((Control) this.tabPage_MultiOption_4);
      this.tabControl1.Controls.Add((Control) this.tabPage_MultiOption_5);
      this.tabControl1.Controls.Add((Control) this.tabPage_MultiOption_6);
      this.tabControl1.Location = new Point(6, 13);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(516, 181);
      this.tabControl1.TabIndex = 28;
      this.tabPage_MultiOption_1.Controls.Add((Control) this.numericUpDown_Durability_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.numericUpDown_Sockets_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.label41);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.comboBox_Ancient_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.label39);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.checkBox_Luck_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.groupBox_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.checkBox_Skill_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.listBox_Option_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.textBox_Name_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.label15);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.label11);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.label10);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.label12);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.numericUpDown_Price_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.listBox_Level_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.label9);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.checkBox_isMulti_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.numericUpDown_Count_Multi_1);
      this.tabPage_MultiOption_1.Controls.Add((Control) this.label42);
      this.tabPage_MultiOption_1.Location = new Point(4, 22);
      this.tabPage_MultiOption_1.Name = "tabPage_MultiOption_1";
      this.tabPage_MultiOption_1.Padding = new Padding(3);
      this.tabPage_MultiOption_1.Size = new Size(508, 155);
      this.tabPage_MultiOption_1.TabIndex = 0;
      this.tabPage_MultiOption_1.Text = "Option 1";
      this.tabPage_MultiOption_1.UseVisualStyleBackColor = true;
      this.numericUpDown_Durability_Multi_1.Location = new Point(160, 130);
      this.numericUpDown_Durability_Multi_1.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Durability_Multi_1.Name = "numericUpDown_Durability_Multi_1";
      this.numericUpDown_Durability_Multi_1.Size = new Size(45, 22);
      this.numericUpDown_Durability_Multi_1.TabIndex = 22;
      this.numericUpDown_Durability_Multi_1.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_1.Location = new Point(50, 129);
      this.numericUpDown_Sockets_Multi_1.Maximum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_1.Name = "numericUpDown_Sockets_Multi_1";
      this.numericUpDown_Sockets_Multi_1.Size = new Size(45, 22);
      this.numericUpDown_Sockets_Multi_1.TabIndex = 21;
      this.label41.AutoSize = true;
      this.label41.ForeColor = Color.Black;
      this.label41.Location = new Point(2, 134);
      this.label41.Name = "label41";
      this.label41.Size = new Size(49, 13);
      this.label41.TabIndex = 47;
      this.label41.Text = "Sockets:";
      this.comboBox_Ancient_Multi_1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Ancient_Multi_1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.comboBox_Ancient_Multi_1.ForeColor = SystemColors.ActiveCaptionText;
      this.comboBox_Ancient_Multi_1.FormattingEnabled = true;
      this.comboBox_Ancient_Multi_1.Location = new Point(50, 104);
      this.comboBox_Ancient_Multi_1.Name = "comboBox_Ancient_Multi_1";
      this.comboBox_Ancient_Multi_1.Size = new Size(100, 21);
      this.comboBox_Ancient_Multi_1.TabIndex = 20;
      this.label39.AutoSize = true;
      this.label39.ForeColor = Color.Black;
      this.label39.Location = new Point(1, 107);
      this.label39.Name = "label39";
      this.label39.Size = new Size(49, 13);
      this.label39.TabIndex = 46;
      this.label39.Text = "Ancient:";
      this.checkBox_Luck_Multi_1.AutoSize = true;
      this.checkBox_Luck_Multi_1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Luck_Multi_1.ForeColor = Color.Black;
      this.checkBox_Luck_Multi_1.Location = new Point(156, 56);
      this.checkBox_Luck_Multi_1.Name = "checkBox_Luck_Multi_1";
      this.checkBox_Luck_Multi_1.Size = new Size(49, 17);
      this.checkBox_Luck_Multi_1.TabIndex = 45;
      this.checkBox_Luck_Multi_1.Text = "Luck";
      this.checkBox_Luck_Multi_1.UseVisualStyleBackColor = true;
      this.groupBox_1.BackColor = Color.Transparent;
      this.groupBox_1.Controls.Add((Control) this.radioButton_Wings_Multi_1);
      this.groupBox_1.Controls.Add((Control) this.radioButton_Armor_Multi_1);
      this.groupBox_1.Controls.Add((Control) this.radioButton_Weapon_Multi_1);
      this.groupBox_1.Controls.Add((Control) this.checkBox_ExcOption6_Multi_1);
      this.groupBox_1.Controls.Add((Control) this.checkBox_ExcOption5_Multi_1);
      this.groupBox_1.Controls.Add((Control) this.checkBox_ExcOption4_Multi_1);
      this.groupBox_1.Controls.Add((Control) this.checkBox_ExcOption3_Multi_1);
      this.groupBox_1.Controls.Add((Control) this.checkBox_ExcOption2_Multi_1);
      this.groupBox_1.Controls.Add((Control) this.checkBox_ExcOption1_Multi_1);
      this.groupBox_1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_1.ForeColor = Color.Black;
      this.groupBox_1.Location = new Point(302, 6);
      this.groupBox_1.Name = "groupBox_1";
      this.groupBox_1.Size = new Size(200, 148);
      this.groupBox_1.TabIndex = 41;
      this.groupBox_1.TabStop = false;
      this.groupBox_1.Text = "Excellent Options";
      this.radioButton_Wings_Multi_1.AutoSize = true;
      this.radioButton_Wings_Multi_1.Location = new Point(141, 15);
      this.radioButton_Wings_Multi_1.Name = "radioButton_Wings_Multi_1";
      this.radioButton_Wings_Multi_1.Size = new Size(58, 17);
      this.radioButton_Wings_Multi_1.TabIndex = 13;
      this.radioButton_Wings_Multi_1.Text = "Wings";
      this.radioButton_Wings_Multi_1.UseVisualStyleBackColor = true;
      this.radioButton_Wings_Multi_1.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWings_CheckedChanged);
      this.radioButton_Armor_Multi_1.AutoSize = true;
      this.radioButton_Armor_Multi_1.Location = new Point(83, 15);
      this.radioButton_Armor_Multi_1.Name = "radioButton_Armor_Multi_1";
      this.radioButton_Armor_Multi_1.Size = new Size(56, 17);
      this.radioButton_Armor_Multi_1.TabIndex = 12;
      this.radioButton_Armor_Multi_1.Text = "Armor";
      this.radioButton_Armor_Multi_1.UseVisualStyleBackColor = true;
      this.radioButton_Armor_Multi_1.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcArmor_CheckedChanged);
      this.radioButton_Weapon_Multi_1.AutoSize = true;
      this.radioButton_Weapon_Multi_1.Location = new Point(11, 15);
      this.radioButton_Weapon_Multi_1.Name = "radioButton_Weapon_Multi_1";
      this.radioButton_Weapon_Multi_1.Size = new Size(69, 17);
      this.radioButton_Weapon_Multi_1.TabIndex = 11;
      this.radioButton_Weapon_Multi_1.Text = "Weapon";
      this.radioButton_Weapon_Multi_1.UseVisualStyleBackColor = true;
      this.radioButton_Weapon_Multi_1.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWeapon_CheckedChanged);
      this.checkBox_ExcOption6_Multi_1.AutoSize = true;
      this.checkBox_ExcOption6_Multi_1.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption6_Multi_1.ForeColor = Color.Black;
      this.checkBox_ExcOption6_Multi_1.Location = new Point(6, 128);
      this.checkBox_ExcOption6_Multi_1.Name = "checkBox_ExcOption6_Multi_1";
      this.checkBox_ExcOption6_Multi_1.Size = new Size(77, 17);
      this.checkBox_ExcOption6_Multi_1.TabIndex = 19;
      this.checkBox_ExcOption6_Multi_1.Text = "checkBox6";
      this.checkBox_ExcOption6_Multi_1.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption5_Multi_1.AutoSize = true;
      this.checkBox_ExcOption5_Multi_1.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption5_Multi_1.ForeColor = Color.Black;
      this.checkBox_ExcOption5_Multi_1.Location = new Point(6, 110);
      this.checkBox_ExcOption5_Multi_1.Name = "checkBox_ExcOption5_Multi_1";
      this.checkBox_ExcOption5_Multi_1.Size = new Size(77, 17);
      this.checkBox_ExcOption5_Multi_1.TabIndex = 18;
      this.checkBox_ExcOption5_Multi_1.Text = "checkBox5";
      this.checkBox_ExcOption5_Multi_1.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption4_Multi_1.AutoSize = true;
      this.checkBox_ExcOption4_Multi_1.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption4_Multi_1.ForeColor = Color.Black;
      this.checkBox_ExcOption4_Multi_1.Location = new Point(6, 91);
      this.checkBox_ExcOption4_Multi_1.Name = "checkBox_ExcOption4_Multi_1";
      this.checkBox_ExcOption4_Multi_1.Size = new Size(77, 17);
      this.checkBox_ExcOption4_Multi_1.TabIndex = 17;
      this.checkBox_ExcOption4_Multi_1.Text = "checkBox4";
      this.checkBox_ExcOption4_Multi_1.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption3_Multi_1.AutoSize = true;
      this.checkBox_ExcOption3_Multi_1.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption3_Multi_1.ForeColor = Color.Black;
      this.checkBox_ExcOption3_Multi_1.Location = new Point(6, 73);
      this.checkBox_ExcOption3_Multi_1.Name = "checkBox_ExcOption3_Multi_1";
      this.checkBox_ExcOption3_Multi_1.Size = new Size(77, 17);
      this.checkBox_ExcOption3_Multi_1.TabIndex = 16;
      this.checkBox_ExcOption3_Multi_1.Text = "checkBox3";
      this.checkBox_ExcOption3_Multi_1.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption2_Multi_1.AutoSize = true;
      this.checkBox_ExcOption2_Multi_1.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption2_Multi_1.ForeColor = Color.Black;
      this.checkBox_ExcOption2_Multi_1.Location = new Point(6, 54);
      this.checkBox_ExcOption2_Multi_1.Name = "checkBox_ExcOption2_Multi_1";
      this.checkBox_ExcOption2_Multi_1.Size = new Size(77, 17);
      this.checkBox_ExcOption2_Multi_1.TabIndex = 15;
      this.checkBox_ExcOption2_Multi_1.Text = "checkBox2";
      this.checkBox_ExcOption2_Multi_1.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption1_Multi_1.AutoSize = true;
      this.checkBox_ExcOption1_Multi_1.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption1_Multi_1.ForeColor = Color.Black;
      this.checkBox_ExcOption1_Multi_1.Location = new Point(6, 36);
      this.checkBox_ExcOption1_Multi_1.Name = "checkBox_ExcOption1_Multi_1";
      this.checkBox_ExcOption1_Multi_1.Size = new Size(77, 17);
      this.checkBox_ExcOption1_Multi_1.TabIndex = 14;
      this.checkBox_ExcOption1_Multi_1.Text = "checkBox1";
      this.checkBox_ExcOption1_Multi_1.UseVisualStyleBackColor = true;
      this.checkBox_Skill_Multi_1.AutoSize = true;
      this.checkBox_Skill_Multi_1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Skill_Multi_1.ForeColor = Color.Black;
      this.checkBox_Skill_Multi_1.Location = new Point(156, 76);
      this.checkBox_Skill_Multi_1.Name = "checkBox_Skill_Multi_1";
      this.checkBox_Skill_Multi_1.Size = new Size(47, 17);
      this.checkBox_Skill_Multi_1.TabIndex = 44;
      this.checkBox_Skill_Multi_1.Text = "Skill";
      this.checkBox_Skill_Multi_1.UseVisualStyleBackColor = true;
      this.listBox_Option_Multi_1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Option_Multi_1.ForeColor = Color.Black;
      this.listBox_Option_Multi_1.FormattingEnabled = true;
      this.listBox_Option_Multi_1.Location = new Point(261, 30);
      this.listBox_Option_Multi_1.Name = "listBox_Option_Multi_1";
      this.listBox_Option_Multi_1.Size = new Size(35, 121);
      this.listBox_Option_Multi_1.TabIndex = 39;
      this.textBox_Name_Multi_1.ForeColor = Color.Black;
      this.textBox_Name_Multi_1.Location = new Point(50, 30);
      this.textBox_Name_Multi_1.Name = "textBox_Name_Multi_1";
      this.textBox_Name_Multi_1.Size = new Size(151, 22);
      this.textBox_Name_Multi_1.TabIndex = 35;
      this.label15.AutoSize = true;
      this.label15.ForeColor = Color.Black;
      this.label15.Location = new Point(4, 35);
      this.label15.Name = "label15";
      this.label15.Size = new Size(36, 13);
      this.label15.TabIndex = 34;
      this.label15.Text = "Name";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.Black;
      this.label11.Location = new Point(204, 9);
      this.label11.Name = "label11";
      this.label11.Size = new Size(32, 13);
      this.label11.TabIndex = 36;
      this.label11.Text = "Level";
      this.label10.AutoSize = true;
      this.label10.ForeColor = Color.Black;
      this.label10.Location = new Point(4, 81);
      this.label10.Name = "label10";
      this.label10.Size = new Size(31, 13);
      this.label10.TabIndex = 33;
      this.label10.Text = "Price";
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.ForeColor = Color.Black;
      this.label12.Location = new Point(258, 9);
      this.label12.Name = "label12";
      this.label12.Size = new Size(44, 13);
      this.label12.TabIndex = 37;
      this.label12.Text = "Option";
      this.numericUpDown_Price_Multi_1.ForeColor = Color.Black;
      this.numericUpDown_Price_Multi_1.Location = new Point(50, 78);
      this.numericUpDown_Price_Multi_1.Maximum = new Decimal(new int[4]
      {
        2000000000,
        0,
        0,
        0
      });
      this.numericUpDown_Price_Multi_1.Name = "numericUpDown_Price_Multi_1";
      this.numericUpDown_Price_Multi_1.Size = new Size(100, 22);
      this.numericUpDown_Price_Multi_1.TabIndex = 32;
      this.listBox_Level_Multi_1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Level_Multi_1.ForeColor = Color.Black;
      this.listBox_Level_Multi_1.FormattingEnabled = true;
      this.listBox_Level_Multi_1.Location = new Point(207, 30);
      this.listBox_Level_Multi_1.Name = "listBox_Level_Multi_1";
      this.listBox_Level_Multi_1.Size = new Size(48, 121);
      this.listBox_Level_Multi_1.TabIndex = 38;
      this.label9.AutoSize = true;
      this.label9.ForeColor = Color.Black;
      this.label9.Location = new Point(4, 57);
      this.label9.Name = "label9";
      this.label9.Size = new Size(39, 13);
      this.label9.TabIndex = 31;
      this.label9.Text = "Count";
      this.checkBox_isMulti_1.AutoSize = true;
      this.checkBox_isMulti_1.ForeColor = Color.Black;
      this.checkBox_isMulti_1.Location = new Point(4, 9);
      this.checkBox_isMulti_1.Name = "checkBox_isMulti_1";
      this.checkBox_isMulti_1.Size = new Size(68, 17);
      this.checkBox_isMulti_1.TabIndex = 29;
      this.checkBox_isMulti_1.Text = "Enabled";
      this.checkBox_isMulti_1.UseVisualStyleBackColor = true;
      this.numericUpDown_Count_Multi_1.ForeColor = Color.Black;
      this.numericUpDown_Count_Multi_1.Location = new Point(50, 54);
      this.numericUpDown_Count_Multi_1.Maximum = new Decimal(new int[4]
      {
        999999,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_1.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_1.Name = "numericUpDown_Count_Multi_1";
      this.numericUpDown_Count_Multi_1.Size = new Size(100, 22);
      this.numericUpDown_Count_Multi_1.TabIndex = 30;
      this.numericUpDown_Count_Multi_1.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label42.AutoSize = true;
      this.label42.ForeColor = Color.Black;
      this.label42.Location = new Point(102, 133);
      this.label42.Name = "label42";
      this.label42.Size = new Size(60, 13);
      this.label42.TabIndex = 48;
      this.label42.Text = "Durability:";
      this.tabPage_MultiOption_2.Controls.Add((Control) this.numericUpDown_Durability_Multi_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.numericUpDown_Sockets_Multi_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.comboBox_Ancient_Multi_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.label43);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.label44);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.label45);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.checkBox_Luck_Multi_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.groupBox_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.checkBox_Skill_Multi_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.listBox_Option_Multi_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.textBox_Name_Multi_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.label13);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.label14);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.label16);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.label17);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.numericUpDown_Price_Multi_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.listBox_Level_Multi_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.label18);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.checkBox_isMulti_2);
      this.tabPage_MultiOption_2.Controls.Add((Control) this.numericUpDown_Count_Multi_2);
      this.tabPage_MultiOption_2.Location = new Point(4, 22);
      this.tabPage_MultiOption_2.Name = "tabPage_MultiOption_2";
      this.tabPage_MultiOption_2.Padding = new Padding(3);
      this.tabPage_MultiOption_2.Size = new Size(508, 155);
      this.tabPage_MultiOption_2.TabIndex = 1;
      this.tabPage_MultiOption_2.Text = "Option 2";
      this.tabPage_MultiOption_2.UseVisualStyleBackColor = true;
      this.numericUpDown_Durability_Multi_2.Location = new Point(160, 130);
      this.numericUpDown_Durability_Multi_2.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Durability_Multi_2.Name = "numericUpDown_Durability_Multi_2";
      this.numericUpDown_Durability_Multi_2.Size = new Size(45, 22);
      this.numericUpDown_Durability_Multi_2.TabIndex = 22;
      this.numericUpDown_Durability_Multi_2.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_2.Location = new Point(50, 129);
      this.numericUpDown_Sockets_Multi_2.Maximum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_2.Name = "numericUpDown_Sockets_Multi_2";
      this.numericUpDown_Sockets_Multi_2.Size = new Size(45, 22);
      this.numericUpDown_Sockets_Multi_2.TabIndex = 21;
      this.comboBox_Ancient_Multi_2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Ancient_Multi_2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.comboBox_Ancient_Multi_2.ForeColor = SystemColors.ActiveCaptionText;
      this.comboBox_Ancient_Multi_2.FormattingEnabled = true;
      this.comboBox_Ancient_Multi_2.Location = new Point(50, 104);
      this.comboBox_Ancient_Multi_2.Name = "comboBox_Ancient_Multi_2";
      this.comboBox_Ancient_Multi_2.Size = new Size(100, 21);
      this.comboBox_Ancient_Multi_2.TabIndex = 20;
      this.label43.AutoSize = true;
      this.label43.ForeColor = Color.Black;
      this.label43.Location = new Point(102, 133);
      this.label43.Name = "label43";
      this.label43.Size = new Size(60, 13);
      this.label43.TabIndex = 65;
      this.label43.Text = "Durability:";
      this.label44.AutoSize = true;
      this.label44.ForeColor = Color.Black;
      this.label44.Location = new Point(2, 134);
      this.label44.Name = "label44";
      this.label44.Size = new Size(49, 13);
      this.label44.TabIndex = 64;
      this.label44.Text = "Sockets:";
      this.label45.AutoSize = true;
      this.label45.ForeColor = Color.Black;
      this.label45.Location = new Point(1, 107);
      this.label45.Name = "label45";
      this.label45.Size = new Size(49, 13);
      this.label45.TabIndex = 63;
      this.label45.Text = "Ancient:";
      this.checkBox_Luck_Multi_2.AutoSize = true;
      this.checkBox_Luck_Multi_2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Luck_Multi_2.ForeColor = Color.Black;
      this.checkBox_Luck_Multi_2.Location = new Point(156, 56);
      this.checkBox_Luck_Multi_2.Name = "checkBox_Luck_Multi_2";
      this.checkBox_Luck_Multi_2.Size = new Size(49, 17);
      this.checkBox_Luck_Multi_2.TabIndex = 62;
      this.checkBox_Luck_Multi_2.Text = "Luck";
      this.checkBox_Luck_Multi_2.UseVisualStyleBackColor = true;
      this.groupBox_2.BackColor = Color.Transparent;
      this.groupBox_2.Controls.Add((Control) this.radioButton_Wings_Multi_2);
      this.groupBox_2.Controls.Add((Control) this.radioButton_Armor_Multi_2);
      this.groupBox_2.Controls.Add((Control) this.radioButton_Weapon_Multi_2);
      this.groupBox_2.Controls.Add((Control) this.checkBox_ExcOption6_Multi_2);
      this.groupBox_2.Controls.Add((Control) this.checkBox_ExcOption5_Multi_2);
      this.groupBox_2.Controls.Add((Control) this.checkBox_ExcOption4_Multi_2);
      this.groupBox_2.Controls.Add((Control) this.checkBox_ExcOption3_Multi_2);
      this.groupBox_2.Controls.Add((Control) this.checkBox_ExcOption2_Multi_2);
      this.groupBox_2.Controls.Add((Control) this.checkBox_ExcOption1_Multi_2);
      this.groupBox_2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_2.ForeColor = Color.Black;
      this.groupBox_2.Location = new Point(302, 6);
      this.groupBox_2.Name = "groupBox_2";
      this.groupBox_2.Size = new Size(200, 148);
      this.groupBox_2.TabIndex = 58;
      this.groupBox_2.TabStop = false;
      this.groupBox_2.Text = "Excellent Options";
      this.radioButton_Wings_Multi_2.AutoSize = true;
      this.radioButton_Wings_Multi_2.Location = new Point(141, 15);
      this.radioButton_Wings_Multi_2.Name = "radioButton_Wings_Multi_2";
      this.radioButton_Wings_Multi_2.Size = new Size(58, 17);
      this.radioButton_Wings_Multi_2.TabIndex = 13;
      this.radioButton_Wings_Multi_2.Text = "Wings";
      this.radioButton_Wings_Multi_2.UseVisualStyleBackColor = true;
      this.radioButton_Wings_Multi_2.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWings_CheckedChanged);
      this.radioButton_Armor_Multi_2.AutoSize = true;
      this.radioButton_Armor_Multi_2.Location = new Point(83, 15);
      this.radioButton_Armor_Multi_2.Name = "radioButton_Armor_Multi_2";
      this.radioButton_Armor_Multi_2.Size = new Size(56, 17);
      this.radioButton_Armor_Multi_2.TabIndex = 12;
      this.radioButton_Armor_Multi_2.Text = "Armor";
      this.radioButton_Armor_Multi_2.UseVisualStyleBackColor = true;
      this.radioButton_Armor_Multi_2.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcArmor_CheckedChanged);
      this.radioButton_Weapon_Multi_2.AutoSize = true;
      this.radioButton_Weapon_Multi_2.Location = new Point(11, 15);
      this.radioButton_Weapon_Multi_2.Name = "radioButton_Weapon_Multi_2";
      this.radioButton_Weapon_Multi_2.Size = new Size(69, 17);
      this.radioButton_Weapon_Multi_2.TabIndex = 11;
      this.radioButton_Weapon_Multi_2.Text = "Weapon";
      this.radioButton_Weapon_Multi_2.UseVisualStyleBackColor = true;
      this.radioButton_Weapon_Multi_2.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWeapon_CheckedChanged);
      this.checkBox_ExcOption6_Multi_2.AutoSize = true;
      this.checkBox_ExcOption6_Multi_2.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption6_Multi_2.ForeColor = Color.Black;
      this.checkBox_ExcOption6_Multi_2.Location = new Point(6, 128);
      this.checkBox_ExcOption6_Multi_2.Name = "checkBox_ExcOption6_Multi_2";
      this.checkBox_ExcOption6_Multi_2.Size = new Size(77, 17);
      this.checkBox_ExcOption6_Multi_2.TabIndex = 19;
      this.checkBox_ExcOption6_Multi_2.Text = "checkBox6";
      this.checkBox_ExcOption6_Multi_2.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption5_Multi_2.AutoSize = true;
      this.checkBox_ExcOption5_Multi_2.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption5_Multi_2.ForeColor = Color.Black;
      this.checkBox_ExcOption5_Multi_2.Location = new Point(6, 110);
      this.checkBox_ExcOption5_Multi_2.Name = "checkBox_ExcOption5_Multi_2";
      this.checkBox_ExcOption5_Multi_2.Size = new Size(77, 17);
      this.checkBox_ExcOption5_Multi_2.TabIndex = 18;
      this.checkBox_ExcOption5_Multi_2.Text = "checkBox5";
      this.checkBox_ExcOption5_Multi_2.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption4_Multi_2.AutoSize = true;
      this.checkBox_ExcOption4_Multi_2.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption4_Multi_2.ForeColor = Color.Black;
      this.checkBox_ExcOption4_Multi_2.Location = new Point(6, 91);
      this.checkBox_ExcOption4_Multi_2.Name = "checkBox_ExcOption4_Multi_2";
      this.checkBox_ExcOption4_Multi_2.Size = new Size(77, 17);
      this.checkBox_ExcOption4_Multi_2.TabIndex = 17;
      this.checkBox_ExcOption4_Multi_2.Text = "checkBox4";
      this.checkBox_ExcOption4_Multi_2.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption3_Multi_2.AutoSize = true;
      this.checkBox_ExcOption3_Multi_2.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption3_Multi_2.ForeColor = Color.Black;
      this.checkBox_ExcOption3_Multi_2.Location = new Point(6, 73);
      this.checkBox_ExcOption3_Multi_2.Name = "checkBox_ExcOption3_Multi_2";
      this.checkBox_ExcOption3_Multi_2.Size = new Size(77, 17);
      this.checkBox_ExcOption3_Multi_2.TabIndex = 16;
      this.checkBox_ExcOption3_Multi_2.Text = "checkBox3";
      this.checkBox_ExcOption3_Multi_2.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption2_Multi_2.AutoSize = true;
      this.checkBox_ExcOption2_Multi_2.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption2_Multi_2.ForeColor = Color.Black;
      this.checkBox_ExcOption2_Multi_2.Location = new Point(6, 54);
      this.checkBox_ExcOption2_Multi_2.Name = "checkBox_ExcOption2_Multi_2";
      this.checkBox_ExcOption2_Multi_2.Size = new Size(77, 17);
      this.checkBox_ExcOption2_Multi_2.TabIndex = 15;
      this.checkBox_ExcOption2_Multi_2.Text = "checkBox2";
      this.checkBox_ExcOption2_Multi_2.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption1_Multi_2.AutoSize = true;
      this.checkBox_ExcOption1_Multi_2.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption1_Multi_2.ForeColor = Color.Black;
      this.checkBox_ExcOption1_Multi_2.Location = new Point(6, 36);
      this.checkBox_ExcOption1_Multi_2.Name = "checkBox_ExcOption1_Multi_2";
      this.checkBox_ExcOption1_Multi_2.Size = new Size(77, 17);
      this.checkBox_ExcOption1_Multi_2.TabIndex = 14;
      this.checkBox_ExcOption1_Multi_2.Text = "checkBox1";
      this.checkBox_ExcOption1_Multi_2.UseVisualStyleBackColor = true;
      this.checkBox_Skill_Multi_2.AutoSize = true;
      this.checkBox_Skill_Multi_2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Skill_Multi_2.ForeColor = Color.Black;
      this.checkBox_Skill_Multi_2.Location = new Point(156, 76);
      this.checkBox_Skill_Multi_2.Name = "checkBox_Skill_Multi_2";
      this.checkBox_Skill_Multi_2.Size = new Size(47, 17);
      this.checkBox_Skill_Multi_2.TabIndex = 61;
      this.checkBox_Skill_Multi_2.Text = "Skill";
      this.checkBox_Skill_Multi_2.UseVisualStyleBackColor = true;
      this.listBox_Option_Multi_2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Option_Multi_2.ForeColor = Color.Black;
      this.listBox_Option_Multi_2.FormattingEnabled = true;
      this.listBox_Option_Multi_2.Location = new Point(261, 30);
      this.listBox_Option_Multi_2.Name = "listBox_Option_Multi_2";
      this.listBox_Option_Multi_2.Size = new Size(35, 121);
      this.listBox_Option_Multi_2.TabIndex = 56;
      this.textBox_Name_Multi_2.ForeColor = Color.Black;
      this.textBox_Name_Multi_2.Location = new Point(50, 30);
      this.textBox_Name_Multi_2.Name = "textBox_Name_Multi_2";
      this.textBox_Name_Multi_2.Size = new Size(151, 22);
      this.textBox_Name_Multi_2.TabIndex = 52;
      this.label13.AutoSize = true;
      this.label13.ForeColor = Color.Black;
      this.label13.Location = new Point(4, 35);
      this.label13.Name = "label13";
      this.label13.Size = new Size(36, 13);
      this.label13.TabIndex = 51;
      this.label13.Text = "Name";
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label14.ForeColor = Color.Black;
      this.label14.Location = new Point(204, 9);
      this.label14.Name = "label14";
      this.label14.Size = new Size(32, 13);
      this.label14.TabIndex = 53;
      this.label14.Text = "Level";
      this.label16.AutoSize = true;
      this.label16.ForeColor = Color.Black;
      this.label16.Location = new Point(4, 81);
      this.label16.Name = "label16";
      this.label16.Size = new Size(31, 13);
      this.label16.TabIndex = 50;
      this.label16.Text = "Price";
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label17.ForeColor = Color.Black;
      this.label17.Location = new Point(258, 9);
      this.label17.Name = "label17";
      this.label17.Size = new Size(44, 13);
      this.label17.TabIndex = 54;
      this.label17.Text = "Option";
      this.numericUpDown_Price_Multi_2.ForeColor = Color.Black;
      this.numericUpDown_Price_Multi_2.Location = new Point(50, 78);
      this.numericUpDown_Price_Multi_2.Maximum = new Decimal(new int[4]
      {
        2000000000,
        0,
        0,
        0
      });
      this.numericUpDown_Price_Multi_2.Name = "numericUpDown_Price_Multi_2";
      this.numericUpDown_Price_Multi_2.Size = new Size(100, 22);
      this.numericUpDown_Price_Multi_2.TabIndex = 49;
      this.listBox_Level_Multi_2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Level_Multi_2.ForeColor = Color.Black;
      this.listBox_Level_Multi_2.FormattingEnabled = true;
      this.listBox_Level_Multi_2.Location = new Point(207, 30);
      this.listBox_Level_Multi_2.Name = "listBox_Level_Multi_2";
      this.listBox_Level_Multi_2.Size = new Size(48, 121);
      this.listBox_Level_Multi_2.TabIndex = 55;
      this.label18.AutoSize = true;
      this.label18.ForeColor = Color.Black;
      this.label18.Location = new Point(4, 57);
      this.label18.Name = "label18";
      this.label18.Size = new Size(39, 13);
      this.label18.TabIndex = 48;
      this.label18.Text = "Count";
      this.checkBox_isMulti_2.AutoSize = true;
      this.checkBox_isMulti_2.ForeColor = Color.Black;
      this.checkBox_isMulti_2.Location = new Point(4, 9);
      this.checkBox_isMulti_2.Name = "checkBox_isMulti_2";
      this.checkBox_isMulti_2.Size = new Size(68, 17);
      this.checkBox_isMulti_2.TabIndex = 46;
      this.checkBox_isMulti_2.Text = "Enabled";
      this.checkBox_isMulti_2.UseVisualStyleBackColor = true;
      this.numericUpDown_Count_Multi_2.ForeColor = Color.Black;
      this.numericUpDown_Count_Multi_2.Location = new Point(50, 54);
      this.numericUpDown_Count_Multi_2.Maximum = new Decimal(new int[4]
      {
        999999,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_2.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_2.Name = "numericUpDown_Count_Multi_2";
      this.numericUpDown_Count_Multi_2.Size = new Size(100, 22);
      this.numericUpDown_Count_Multi_2.TabIndex = 47;
      this.numericUpDown_Count_Multi_2.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.tabPage_MultiOption_3.Controls.Add((Control) this.label48);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.numericUpDown_Durability_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.numericUpDown_Sockets_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.comboBox_Ancient_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.checkBox_Luck_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.groupBox_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.checkBox_Skill_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.listBox_Option_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.textBox_Name_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.label19);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.label20);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.label23);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.numericUpDown_Price_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.listBox_Level_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.label40);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.checkBox_isMulti_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.numericUpDown_Count_Multi_3);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.label21);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.label46);
      this.tabPage_MultiOption_3.Controls.Add((Control) this.label47);
      this.tabPage_MultiOption_3.Location = new Point(4, 22);
      this.tabPage_MultiOption_3.Name = "tabPage_MultiOption_3";
      this.tabPage_MultiOption_3.Padding = new Padding(3);
      this.tabPage_MultiOption_3.Size = new Size(508, 155);
      this.tabPage_MultiOption_3.TabIndex = 2;
      this.tabPage_MultiOption_3.Text = "Option 3";
      this.tabPage_MultiOption_3.UseVisualStyleBackColor = true;
      this.label48.AutoSize = true;
      this.label48.ForeColor = Color.Black;
      this.label48.Location = new Point(1, 107);
      this.label48.Name = "label48";
      this.label48.Size = new Size(49, 13);
      this.label48.TabIndex = 63;
      this.label48.Text = "Ancient:";
      this.numericUpDown_Durability_Multi_3.Location = new Point(160, 130);
      this.numericUpDown_Durability_Multi_3.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Durability_Multi_3.Name = "numericUpDown_Durability_Multi_3";
      this.numericUpDown_Durability_Multi_3.Size = new Size(45, 22);
      this.numericUpDown_Durability_Multi_3.TabIndex = 22;
      this.numericUpDown_Durability_Multi_3.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_3.Location = new Point(50, 129);
      this.numericUpDown_Sockets_Multi_3.Maximum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_3.Name = "numericUpDown_Sockets_Multi_3";
      this.numericUpDown_Sockets_Multi_3.Size = new Size(45, 22);
      this.numericUpDown_Sockets_Multi_3.TabIndex = 21;
      this.comboBox_Ancient_Multi_3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Ancient_Multi_3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.comboBox_Ancient_Multi_3.ForeColor = SystemColors.ActiveCaptionText;
      this.comboBox_Ancient_Multi_3.FormattingEnabled = true;
      this.comboBox_Ancient_Multi_3.Location = new Point(50, 104);
      this.comboBox_Ancient_Multi_3.Name = "comboBox_Ancient_Multi_3";
      this.comboBox_Ancient_Multi_3.Size = new Size(100, 21);
      this.comboBox_Ancient_Multi_3.TabIndex = 20;
      this.checkBox_Luck_Multi_3.AutoSize = true;
      this.checkBox_Luck_Multi_3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Luck_Multi_3.ForeColor = Color.Black;
      this.checkBox_Luck_Multi_3.Location = new Point(156, 56);
      this.checkBox_Luck_Multi_3.Name = "checkBox_Luck_Multi_3";
      this.checkBox_Luck_Multi_3.Size = new Size(49, 17);
      this.checkBox_Luck_Multi_3.TabIndex = 62;
      this.checkBox_Luck_Multi_3.Text = "Luck";
      this.checkBox_Luck_Multi_3.UseVisualStyleBackColor = true;
      this.groupBox_3.BackColor = Color.Transparent;
      this.groupBox_3.Controls.Add((Control) this.radioButton_Wings_Multi_3);
      this.groupBox_3.Controls.Add((Control) this.radioButton_Armor_Multi_3);
      this.groupBox_3.Controls.Add((Control) this.radioButton_Weapon_Multi_3);
      this.groupBox_3.Controls.Add((Control) this.checkBox_ExcOption6_Multi_3);
      this.groupBox_3.Controls.Add((Control) this.checkBox_ExcOption5_Multi_3);
      this.groupBox_3.Controls.Add((Control) this.checkBox_ExcOption4_Multi_3);
      this.groupBox_3.Controls.Add((Control) this.checkBox_ExcOption3_Multi_3);
      this.groupBox_3.Controls.Add((Control) this.checkBox_ExcOption2_Multi_3);
      this.groupBox_3.Controls.Add((Control) this.checkBox_ExcOption1_Multi_3);
      this.groupBox_3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_3.ForeColor = Color.Black;
      this.groupBox_3.Location = new Point(302, 6);
      this.groupBox_3.Name = "groupBox_3";
      this.groupBox_3.Size = new Size(200, 148);
      this.groupBox_3.TabIndex = 58;
      this.groupBox_3.TabStop = false;
      this.groupBox_3.Text = "Excellent Options";
      this.radioButton_Wings_Multi_3.AutoSize = true;
      this.radioButton_Wings_Multi_3.Location = new Point(141, 15);
      this.radioButton_Wings_Multi_3.Name = "radioButton_Wings_Multi_3";
      this.radioButton_Wings_Multi_3.Size = new Size(58, 17);
      this.radioButton_Wings_Multi_3.TabIndex = 13;
      this.radioButton_Wings_Multi_3.Text = "Wings";
      this.radioButton_Wings_Multi_3.UseVisualStyleBackColor = true;
      this.radioButton_Wings_Multi_3.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWings_CheckedChanged);
      this.radioButton_Armor_Multi_3.AutoSize = true;
      this.radioButton_Armor_Multi_3.Location = new Point(83, 15);
      this.radioButton_Armor_Multi_3.Name = "radioButton_Armor_Multi_3";
      this.radioButton_Armor_Multi_3.Size = new Size(56, 17);
      this.radioButton_Armor_Multi_3.TabIndex = 12;
      this.radioButton_Armor_Multi_3.Text = "Armor";
      this.radioButton_Armor_Multi_3.UseVisualStyleBackColor = true;
      this.radioButton_Armor_Multi_3.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcArmor_CheckedChanged);
      this.radioButton_Weapon_Multi_3.AutoSize = true;
      this.radioButton_Weapon_Multi_3.Location = new Point(11, 15);
      this.radioButton_Weapon_Multi_3.Name = "radioButton_Weapon_Multi_3";
      this.radioButton_Weapon_Multi_3.Size = new Size(69, 17);
      this.radioButton_Weapon_Multi_3.TabIndex = 11;
      this.radioButton_Weapon_Multi_3.Text = "Weapon";
      this.radioButton_Weapon_Multi_3.UseVisualStyleBackColor = true;
      this.radioButton_Weapon_Multi_3.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWeapon_CheckedChanged);
      this.checkBox_ExcOption6_Multi_3.AutoSize = true;
      this.checkBox_ExcOption6_Multi_3.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption6_Multi_3.ForeColor = Color.Black;
      this.checkBox_ExcOption6_Multi_3.Location = new Point(6, 128);
      this.checkBox_ExcOption6_Multi_3.Name = "checkBox_ExcOption6_Multi_3";
      this.checkBox_ExcOption6_Multi_3.Size = new Size(77, 17);
      this.checkBox_ExcOption6_Multi_3.TabIndex = 19;
      this.checkBox_ExcOption6_Multi_3.Text = "checkBox6";
      this.checkBox_ExcOption6_Multi_3.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption5_Multi_3.AutoSize = true;
      this.checkBox_ExcOption5_Multi_3.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption5_Multi_3.ForeColor = Color.Black;
      this.checkBox_ExcOption5_Multi_3.Location = new Point(6, 110);
      this.checkBox_ExcOption5_Multi_3.Name = "checkBox_ExcOption5_Multi_3";
      this.checkBox_ExcOption5_Multi_3.Size = new Size(77, 17);
      this.checkBox_ExcOption5_Multi_3.TabIndex = 18;
      this.checkBox_ExcOption5_Multi_3.Text = "checkBox5";
      this.checkBox_ExcOption5_Multi_3.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption4_Multi_3.AutoSize = true;
      this.checkBox_ExcOption4_Multi_3.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption4_Multi_3.ForeColor = Color.Black;
      this.checkBox_ExcOption4_Multi_3.Location = new Point(6, 91);
      this.checkBox_ExcOption4_Multi_3.Name = "checkBox_ExcOption4_Multi_3";
      this.checkBox_ExcOption4_Multi_3.Size = new Size(77, 17);
      this.checkBox_ExcOption4_Multi_3.TabIndex = 17;
      this.checkBox_ExcOption4_Multi_3.Text = "checkBox4";
      this.checkBox_ExcOption4_Multi_3.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption3_Multi_3.AutoSize = true;
      this.checkBox_ExcOption3_Multi_3.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption3_Multi_3.ForeColor = Color.Black;
      this.checkBox_ExcOption3_Multi_3.Location = new Point(6, 73);
      this.checkBox_ExcOption3_Multi_3.Name = "checkBox_ExcOption3_Multi_3";
      this.checkBox_ExcOption3_Multi_3.Size = new Size(77, 17);
      this.checkBox_ExcOption3_Multi_3.TabIndex = 16;
      this.checkBox_ExcOption3_Multi_3.Text = "checkBox3";
      this.checkBox_ExcOption3_Multi_3.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption2_Multi_3.AutoSize = true;
      this.checkBox_ExcOption2_Multi_3.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption2_Multi_3.ForeColor = Color.Black;
      this.checkBox_ExcOption2_Multi_3.Location = new Point(6, 54);
      this.checkBox_ExcOption2_Multi_3.Name = "checkBox_ExcOption2_Multi_3";
      this.checkBox_ExcOption2_Multi_3.Size = new Size(77, 17);
      this.checkBox_ExcOption2_Multi_3.TabIndex = 15;
      this.checkBox_ExcOption2_Multi_3.Text = "checkBox2";
      this.checkBox_ExcOption2_Multi_3.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption1_Multi_3.AutoSize = true;
      this.checkBox_ExcOption1_Multi_3.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption1_Multi_3.ForeColor = Color.Black;
      this.checkBox_ExcOption1_Multi_3.Location = new Point(6, 36);
      this.checkBox_ExcOption1_Multi_3.Name = "checkBox_ExcOption1_Multi_3";
      this.checkBox_ExcOption1_Multi_3.Size = new Size(77, 17);
      this.checkBox_ExcOption1_Multi_3.TabIndex = 14;
      this.checkBox_ExcOption1_Multi_3.Text = "checkBox1";
      this.checkBox_ExcOption1_Multi_3.UseVisualStyleBackColor = true;
      this.checkBox_Skill_Multi_3.AutoSize = true;
      this.checkBox_Skill_Multi_3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Skill_Multi_3.ForeColor = Color.Black;
      this.checkBox_Skill_Multi_3.Location = new Point(156, 76);
      this.checkBox_Skill_Multi_3.Name = "checkBox_Skill_Multi_3";
      this.checkBox_Skill_Multi_3.Size = new Size(47, 17);
      this.checkBox_Skill_Multi_3.TabIndex = 61;
      this.checkBox_Skill_Multi_3.Text = "Skill";
      this.checkBox_Skill_Multi_3.UseVisualStyleBackColor = true;
      this.listBox_Option_Multi_3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Option_Multi_3.ForeColor = Color.Black;
      this.listBox_Option_Multi_3.FormattingEnabled = true;
      this.listBox_Option_Multi_3.Location = new Point(261, 30);
      this.listBox_Option_Multi_3.Name = "listBox_Option_Multi_3";
      this.listBox_Option_Multi_3.Size = new Size(35, 121);
      this.listBox_Option_Multi_3.TabIndex = 56;
      this.textBox_Name_Multi_3.ForeColor = Color.Black;
      this.textBox_Name_Multi_3.Location = new Point(50, 30);
      this.textBox_Name_Multi_3.Name = "textBox_Name_Multi_3";
      this.textBox_Name_Multi_3.Size = new Size(151, 22);
      this.textBox_Name_Multi_3.TabIndex = 52;
      this.label19.AutoSize = true;
      this.label19.ForeColor = Color.Black;
      this.label19.Location = new Point(4, 35);
      this.label19.Name = "label19";
      this.label19.Size = new Size(36, 13);
      this.label19.TabIndex = 51;
      this.label19.Text = "Name";
      this.label20.AutoSize = true;
      this.label20.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label20.ForeColor = Color.Black;
      this.label20.Location = new Point(204, 9);
      this.label20.Name = "label20";
      this.label20.Size = new Size(32, 13);
      this.label20.TabIndex = 53;
      this.label20.Text = "Level";
      this.label23.AutoSize = true;
      this.label23.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = Color.Black;
      this.label23.Location = new Point(258, 9);
      this.label23.Name = "label23";
      this.label23.Size = new Size(44, 13);
      this.label23.TabIndex = 54;
      this.label23.Text = "Option";
      this.numericUpDown_Price_Multi_3.ForeColor = Color.Black;
      this.numericUpDown_Price_Multi_3.Location = new Point(50, 78);
      this.numericUpDown_Price_Multi_3.Maximum = new Decimal(new int[4]
      {
        2000000000,
        0,
        0,
        0
      });
      this.numericUpDown_Price_Multi_3.Name = "numericUpDown_Price_Multi_3";
      this.numericUpDown_Price_Multi_3.Size = new Size(100, 22);
      this.numericUpDown_Price_Multi_3.TabIndex = 49;
      this.listBox_Level_Multi_3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Level_Multi_3.ForeColor = Color.Black;
      this.listBox_Level_Multi_3.FormattingEnabled = true;
      this.listBox_Level_Multi_3.Location = new Point(207, 30);
      this.listBox_Level_Multi_3.Name = "listBox_Level_Multi_3";
      this.listBox_Level_Multi_3.Size = new Size(48, 121);
      this.listBox_Level_Multi_3.TabIndex = 55;
      this.label40.AutoSize = true;
      this.label40.ForeColor = Color.Black;
      this.label40.Location = new Point(4, 57);
      this.label40.Name = "label40";
      this.label40.Size = new Size(39, 13);
      this.label40.TabIndex = 48;
      this.label40.Text = "Count";
      this.checkBox_isMulti_3.AutoSize = true;
      this.checkBox_isMulti_3.ForeColor = Color.Black;
      this.checkBox_isMulti_3.Location = new Point(4, 9);
      this.checkBox_isMulti_3.Name = "checkBox_isMulti_3";
      this.checkBox_isMulti_3.Size = new Size(68, 17);
      this.checkBox_isMulti_3.TabIndex = 46;
      this.checkBox_isMulti_3.Text = "Enabled";
      this.checkBox_isMulti_3.UseVisualStyleBackColor = true;
      this.numericUpDown_Count_Multi_3.ForeColor = Color.Black;
      this.numericUpDown_Count_Multi_3.Location = new Point(50, 54);
      this.numericUpDown_Count_Multi_3.Maximum = new Decimal(new int[4]
      {
        999999,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_3.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_3.Name = "numericUpDown_Count_Multi_3";
      this.numericUpDown_Count_Multi_3.Size = new Size(100, 22);
      this.numericUpDown_Count_Multi_3.TabIndex = 47;
      this.numericUpDown_Count_Multi_3.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label21.AutoSize = true;
      this.label21.ForeColor = Color.Black;
      this.label21.Location = new Point(4, 81);
      this.label21.Name = "label21";
      this.label21.Size = new Size(31, 13);
      this.label21.TabIndex = 33;
      this.label21.Text = "Price";
      this.label46.AutoSize = true;
      this.label46.ForeColor = Color.Black;
      this.label46.Location = new Point(102, 133);
      this.label46.Name = "label46";
      this.label46.Size = new Size(60, 13);
      this.label46.TabIndex = 65;
      this.label46.Text = "Durability:";
      this.label47.AutoSize = true;
      this.label47.ForeColor = Color.Black;
      this.label47.Location = new Point(2, 134);
      this.label47.Name = "label47";
      this.label47.Size = new Size(49, 13);
      this.label47.TabIndex = 64;
      this.label47.Text = "Sockets:";
      this.tabPage_MultiOption_4.Controls.Add((Control) this.label51);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.numericUpDown_Durability_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.numericUpDown_Sockets_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.comboBox_Ancient_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.checkBox_Luck_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.groupBox_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.checkBox_Skill_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.listBox_Option_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.textBox_Name_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.label22);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.label24);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.label25);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.label26);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.numericUpDown_Price_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.listBox_Level_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.label28);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.checkBox_isMulti_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.numericUpDown_Count_Multi_4);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.label50);
      this.tabPage_MultiOption_4.Controls.Add((Control) this.label49);
      this.tabPage_MultiOption_4.Location = new Point(4, 22);
      this.tabPage_MultiOption_4.Name = "tabPage_MultiOption_4";
      this.tabPage_MultiOption_4.Padding = new Padding(3);
      this.tabPage_MultiOption_4.Size = new Size(508, 155);
      this.tabPage_MultiOption_4.TabIndex = 3;
      this.tabPage_MultiOption_4.Text = "Option 4";
      this.tabPage_MultiOption_4.UseVisualStyleBackColor = true;
      this.label51.AutoSize = true;
      this.label51.ForeColor = Color.Black;
      this.label51.Location = new Point(1, 107);
      this.label51.Name = "label51";
      this.label51.Size = new Size(49, 13);
      this.label51.TabIndex = 66;
      this.label51.Text = "Ancient:";
      this.numericUpDown_Durability_Multi_4.Location = new Point(160, 130);
      this.numericUpDown_Durability_Multi_4.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Durability_Multi_4.Name = "numericUpDown_Durability_Multi_4";
      this.numericUpDown_Durability_Multi_4.Size = new Size(45, 22);
      this.numericUpDown_Durability_Multi_4.TabIndex = 22;
      this.numericUpDown_Durability_Multi_4.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_4.Location = new Point(50, 129);
      this.numericUpDown_Sockets_Multi_4.Maximum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_4.Name = "numericUpDown_Sockets_Multi_4";
      this.numericUpDown_Sockets_Multi_4.Size = new Size(45, 22);
      this.numericUpDown_Sockets_Multi_4.TabIndex = 21;
      this.comboBox_Ancient_Multi_4.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Ancient_Multi_4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.comboBox_Ancient_Multi_4.ForeColor = SystemColors.ActiveCaptionText;
      this.comboBox_Ancient_Multi_4.FormattingEnabled = true;
      this.comboBox_Ancient_Multi_4.Location = new Point(50, 104);
      this.comboBox_Ancient_Multi_4.Name = "comboBox_Ancient_Multi_4";
      this.comboBox_Ancient_Multi_4.Size = new Size(100, 21);
      this.comboBox_Ancient_Multi_4.TabIndex = 20;
      this.checkBox_Luck_Multi_4.AutoSize = true;
      this.checkBox_Luck_Multi_4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Luck_Multi_4.ForeColor = Color.Black;
      this.checkBox_Luck_Multi_4.Location = new Point(156, 56);
      this.checkBox_Luck_Multi_4.Name = "checkBox_Luck_Multi_4";
      this.checkBox_Luck_Multi_4.Size = new Size(49, 17);
      this.checkBox_Luck_Multi_4.TabIndex = 62;
      this.checkBox_Luck_Multi_4.Text = "Luck";
      this.checkBox_Luck_Multi_4.UseVisualStyleBackColor = true;
      this.groupBox_4.BackColor = Color.Transparent;
      this.groupBox_4.Controls.Add((Control) this.radioButton_Wings_Multi_4);
      this.groupBox_4.Controls.Add((Control) this.radioButton_Armor_Multi_4);
      this.groupBox_4.Controls.Add((Control) this.radioButton_Weapon_Multi_4);
      this.groupBox_4.Controls.Add((Control) this.checkBox_ExcOption6_Multi_4);
      this.groupBox_4.Controls.Add((Control) this.checkBox_ExcOption5_Multi_4);
      this.groupBox_4.Controls.Add((Control) this.checkBox_ExcOption4_Multi_4);
      this.groupBox_4.Controls.Add((Control) this.checkBox_ExcOption3_Multi_4);
      this.groupBox_4.Controls.Add((Control) this.checkBox_ExcOption2_Multi_4);
      this.groupBox_4.Controls.Add((Control) this.checkBox_ExcOption1_Multi_4);
      this.groupBox_4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_4.ForeColor = Color.Black;
      this.groupBox_4.Location = new Point(302, 6);
      this.groupBox_4.Name = "groupBox_4";
      this.groupBox_4.Size = new Size(200, 148);
      this.groupBox_4.TabIndex = 58;
      this.groupBox_4.TabStop = false;
      this.groupBox_4.Text = "Excellent Options";
      this.radioButton_Wings_Multi_4.AutoSize = true;
      this.radioButton_Wings_Multi_4.Location = new Point(141, 15);
      this.radioButton_Wings_Multi_4.Name = "radioButton_Wings_Multi_4";
      this.radioButton_Wings_Multi_4.Size = new Size(58, 17);
      this.radioButton_Wings_Multi_4.TabIndex = 13;
      this.radioButton_Wings_Multi_4.Text = "Wings";
      this.radioButton_Wings_Multi_4.UseVisualStyleBackColor = true;
      this.radioButton_Wings_Multi_4.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWings_CheckedChanged);
      this.radioButton_Armor_Multi_4.AutoSize = true;
      this.radioButton_Armor_Multi_4.Location = new Point(83, 15);
      this.radioButton_Armor_Multi_4.Name = "radioButton_Armor_Multi_4";
      this.radioButton_Armor_Multi_4.Size = new Size(56, 17);
      this.radioButton_Armor_Multi_4.TabIndex = 12;
      this.radioButton_Armor_Multi_4.Text = "Armor";
      this.radioButton_Armor_Multi_4.UseVisualStyleBackColor = true;
      this.radioButton_Armor_Multi_4.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcArmor_CheckedChanged);
      this.radioButton_Weapon_Multi_4.AutoSize = true;
      this.radioButton_Weapon_Multi_4.Location = new Point(11, 15);
      this.radioButton_Weapon_Multi_4.Name = "radioButton_Weapon_Multi_4";
      this.radioButton_Weapon_Multi_4.Size = new Size(69, 17);
      this.radioButton_Weapon_Multi_4.TabIndex = 11;
      this.radioButton_Weapon_Multi_4.Text = "Weapon";
      this.radioButton_Weapon_Multi_4.UseVisualStyleBackColor = true;
      this.radioButton_Weapon_Multi_4.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWeapon_CheckedChanged);
      this.checkBox_ExcOption6_Multi_4.AutoSize = true;
      this.checkBox_ExcOption6_Multi_4.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption6_Multi_4.ForeColor = Color.Black;
      this.checkBox_ExcOption6_Multi_4.Location = new Point(6, 128);
      this.checkBox_ExcOption6_Multi_4.Name = "checkBox_ExcOption6_Multi_4";
      this.checkBox_ExcOption6_Multi_4.Size = new Size(77, 17);
      this.checkBox_ExcOption6_Multi_4.TabIndex = 19;
      this.checkBox_ExcOption6_Multi_4.Text = "checkBox6";
      this.checkBox_ExcOption6_Multi_4.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption5_Multi_4.AutoSize = true;
      this.checkBox_ExcOption5_Multi_4.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption5_Multi_4.ForeColor = Color.Black;
      this.checkBox_ExcOption5_Multi_4.Location = new Point(6, 110);
      this.checkBox_ExcOption5_Multi_4.Name = "checkBox_ExcOption5_Multi_4";
      this.checkBox_ExcOption5_Multi_4.Size = new Size(77, 17);
      this.checkBox_ExcOption5_Multi_4.TabIndex = 18;
      this.checkBox_ExcOption5_Multi_4.Text = "checkBox5";
      this.checkBox_ExcOption5_Multi_4.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption4_Multi_4.AutoSize = true;
      this.checkBox_ExcOption4_Multi_4.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption4_Multi_4.ForeColor = Color.Black;
      this.checkBox_ExcOption4_Multi_4.Location = new Point(6, 91);
      this.checkBox_ExcOption4_Multi_4.Name = "checkBox_ExcOption4_Multi_4";
      this.checkBox_ExcOption4_Multi_4.Size = new Size(77, 17);
      this.checkBox_ExcOption4_Multi_4.TabIndex = 17;
      this.checkBox_ExcOption4_Multi_4.Text = "checkBox4";
      this.checkBox_ExcOption4_Multi_4.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption3_Multi_4.AutoSize = true;
      this.checkBox_ExcOption3_Multi_4.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption3_Multi_4.ForeColor = Color.Black;
      this.checkBox_ExcOption3_Multi_4.Location = new Point(6, 73);
      this.checkBox_ExcOption3_Multi_4.Name = "checkBox_ExcOption3_Multi_4";
      this.checkBox_ExcOption3_Multi_4.Size = new Size(77, 17);
      this.checkBox_ExcOption3_Multi_4.TabIndex = 16;
      this.checkBox_ExcOption3_Multi_4.Text = "checkBox3";
      this.checkBox_ExcOption3_Multi_4.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption2_Multi_4.AutoSize = true;
      this.checkBox_ExcOption2_Multi_4.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption2_Multi_4.ForeColor = Color.Black;
      this.checkBox_ExcOption2_Multi_4.Location = new Point(6, 54);
      this.checkBox_ExcOption2_Multi_4.Name = "checkBox_ExcOption2_Multi_4";
      this.checkBox_ExcOption2_Multi_4.Size = new Size(77, 17);
      this.checkBox_ExcOption2_Multi_4.TabIndex = 15;
      this.checkBox_ExcOption2_Multi_4.Text = "checkBox2";
      this.checkBox_ExcOption2_Multi_4.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption1_Multi_4.AutoSize = true;
      this.checkBox_ExcOption1_Multi_4.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption1_Multi_4.ForeColor = Color.Black;
      this.checkBox_ExcOption1_Multi_4.Location = new Point(6, 36);
      this.checkBox_ExcOption1_Multi_4.Name = "checkBox_ExcOption1_Multi_4";
      this.checkBox_ExcOption1_Multi_4.Size = new Size(77, 17);
      this.checkBox_ExcOption1_Multi_4.TabIndex = 14;
      this.checkBox_ExcOption1_Multi_4.Text = "checkBox1";
      this.checkBox_ExcOption1_Multi_4.UseVisualStyleBackColor = true;
      this.checkBox_Skill_Multi_4.AutoSize = true;
      this.checkBox_Skill_Multi_4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Skill_Multi_4.ForeColor = Color.Black;
      this.checkBox_Skill_Multi_4.Location = new Point(156, 76);
      this.checkBox_Skill_Multi_4.Name = "checkBox_Skill_Multi_4";
      this.checkBox_Skill_Multi_4.Size = new Size(47, 17);
      this.checkBox_Skill_Multi_4.TabIndex = 61;
      this.checkBox_Skill_Multi_4.Text = "Skill";
      this.checkBox_Skill_Multi_4.UseVisualStyleBackColor = true;
      this.listBox_Option_Multi_4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Option_Multi_4.ForeColor = Color.Black;
      this.listBox_Option_Multi_4.FormattingEnabled = true;
      this.listBox_Option_Multi_4.Location = new Point(261, 30);
      this.listBox_Option_Multi_4.Name = "listBox_Option_Multi_4";
      this.listBox_Option_Multi_4.Size = new Size(35, 121);
      this.listBox_Option_Multi_4.TabIndex = 56;
      this.textBox_Name_Multi_4.ForeColor = Color.Black;
      this.textBox_Name_Multi_4.Location = new Point(50, 30);
      this.textBox_Name_Multi_4.Name = "textBox_Name_Multi_4";
      this.textBox_Name_Multi_4.Size = new Size(151, 22);
      this.textBox_Name_Multi_4.TabIndex = 52;
      this.label22.AutoSize = true;
      this.label22.ForeColor = Color.Black;
      this.label22.Location = new Point(4, 35);
      this.label22.Name = "label22";
      this.label22.Size = new Size(36, 13);
      this.label22.TabIndex = 51;
      this.label22.Text = "Name";
      this.label24.AutoSize = true;
      this.label24.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label24.ForeColor = Color.Black;
      this.label24.Location = new Point(204, 9);
      this.label24.Name = "label24";
      this.label24.Size = new Size(32, 13);
      this.label24.TabIndex = 53;
      this.label24.Text = "Level";
      this.label25.AutoSize = true;
      this.label25.ForeColor = Color.Black;
      this.label25.Location = new Point(4, 81);
      this.label25.Name = "label25";
      this.label25.Size = new Size(31, 13);
      this.label25.TabIndex = 50;
      this.label25.Text = "Price";
      this.label26.AutoSize = true;
      this.label26.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = Color.Black;
      this.label26.Location = new Point(258, 9);
      this.label26.Name = "label26";
      this.label26.Size = new Size(44, 13);
      this.label26.TabIndex = 54;
      this.label26.Text = "Option";
      this.numericUpDown_Price_Multi_4.ForeColor = Color.Black;
      this.numericUpDown_Price_Multi_4.Location = new Point(50, 78);
      this.numericUpDown_Price_Multi_4.Maximum = new Decimal(new int[4]
      {
        2000000000,
        0,
        0,
        0
      });
      this.numericUpDown_Price_Multi_4.Name = "numericUpDown_Price_Multi_4";
      this.numericUpDown_Price_Multi_4.Size = new Size(100, 22);
      this.numericUpDown_Price_Multi_4.TabIndex = 49;
      this.listBox_Level_Multi_4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Level_Multi_4.ForeColor = Color.Black;
      this.listBox_Level_Multi_4.FormattingEnabled = true;
      this.listBox_Level_Multi_4.Location = new Point(207, 30);
      this.listBox_Level_Multi_4.Name = "listBox_Level_Multi_4";
      this.listBox_Level_Multi_4.Size = new Size(48, 121);
      this.listBox_Level_Multi_4.TabIndex = 55;
      this.label28.AutoSize = true;
      this.label28.ForeColor = Color.Black;
      this.label28.Location = new Point(4, 57);
      this.label28.Name = "label28";
      this.label28.Size = new Size(39, 13);
      this.label28.TabIndex = 48;
      this.label28.Text = "Count";
      this.checkBox_isMulti_4.AutoSize = true;
      this.checkBox_isMulti_4.ForeColor = Color.Black;
      this.checkBox_isMulti_4.Location = new Point(4, 9);
      this.checkBox_isMulti_4.Name = "checkBox_isMulti_4";
      this.checkBox_isMulti_4.Size = new Size(68, 17);
      this.checkBox_isMulti_4.TabIndex = 46;
      this.checkBox_isMulti_4.Text = "Enabled";
      this.checkBox_isMulti_4.UseVisualStyleBackColor = true;
      this.numericUpDown_Count_Multi_4.ForeColor = Color.Black;
      this.numericUpDown_Count_Multi_4.Location = new Point(50, 54);
      this.numericUpDown_Count_Multi_4.Maximum = new Decimal(new int[4]
      {
        999999,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_4.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_4.Name = "numericUpDown_Count_Multi_4";
      this.numericUpDown_Count_Multi_4.Size = new Size(100, 22);
      this.numericUpDown_Count_Multi_4.TabIndex = 47;
      this.numericUpDown_Count_Multi_4.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label50.AutoSize = true;
      this.label50.ForeColor = Color.Black;
      this.label50.Location = new Point(2, 134);
      this.label50.Name = "label50";
      this.label50.Size = new Size(49, 13);
      this.label50.TabIndex = 67;
      this.label50.Text = "Sockets:";
      this.label49.AutoSize = true;
      this.label49.ForeColor = Color.Black;
      this.label49.Location = new Point(102, 133);
      this.label49.Name = "label49";
      this.label49.Size = new Size(60, 13);
      this.label49.TabIndex = 68;
      this.label49.Text = "Durability:";
      this.tabPage_MultiOption_5.Controls.Add((Control) this.numericUpDown_Durability_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.label52);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.numericUpDown_Sockets_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.comboBox_Ancient_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.checkBox_Luck_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.groupBox_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.checkBox_Skill_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.listBox_Option_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.textBox_Name_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.label29);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.label30);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.label31);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.label32);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.numericUpDown_Price_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.listBox_Level_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.label33);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.checkBox_isMulti_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.numericUpDown_Count_Multi_5);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.label54);
      this.tabPage_MultiOption_5.Controls.Add((Control) this.label53);
      this.tabPage_MultiOption_5.Location = new Point(4, 22);
      this.tabPage_MultiOption_5.Name = "tabPage_MultiOption_5";
      this.tabPage_MultiOption_5.Padding = new Padding(3);
      this.tabPage_MultiOption_5.Size = new Size(508, 155);
      this.tabPage_MultiOption_5.TabIndex = 4;
      this.tabPage_MultiOption_5.Text = "Option 5";
      this.tabPage_MultiOption_5.UseVisualStyleBackColor = true;
      this.numericUpDown_Durability_Multi_5.Location = new Point(160, 130);
      this.numericUpDown_Durability_Multi_5.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Durability_Multi_5.Name = "numericUpDown_Durability_Multi_5";
      this.numericUpDown_Durability_Multi_5.Size = new Size(45, 22);
      this.numericUpDown_Durability_Multi_5.TabIndex = 22;
      this.numericUpDown_Durability_Multi_5.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.label52.AutoSize = true;
      this.label52.ForeColor = Color.Black;
      this.label52.Location = new Point(102, 133);
      this.label52.Name = "label52";
      this.label52.Size = new Size(60, 13);
      this.label52.TabIndex = 68;
      this.label52.Text = "Durability:";
      this.numericUpDown_Sockets_Multi_5.Location = new Point(50, 129);
      this.numericUpDown_Sockets_Multi_5.Maximum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_5.Name = "numericUpDown_Sockets_Multi_5";
      this.numericUpDown_Sockets_Multi_5.Size = new Size(45, 22);
      this.numericUpDown_Sockets_Multi_5.TabIndex = 21;
      this.comboBox_Ancient_Multi_5.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Ancient_Multi_5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.comboBox_Ancient_Multi_5.ForeColor = SystemColors.ActiveCaptionText;
      this.comboBox_Ancient_Multi_5.FormattingEnabled = true;
      this.comboBox_Ancient_Multi_5.Location = new Point(50, 104);
      this.comboBox_Ancient_Multi_5.Name = "comboBox_Ancient_Multi_5";
      this.comboBox_Ancient_Multi_5.Size = new Size(100, 21);
      this.comboBox_Ancient_Multi_5.TabIndex = 20;
      this.checkBox_Luck_Multi_5.AutoSize = true;
      this.checkBox_Luck_Multi_5.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Luck_Multi_5.ForeColor = Color.Black;
      this.checkBox_Luck_Multi_5.Location = new Point(156, 56);
      this.checkBox_Luck_Multi_5.Name = "checkBox_Luck_Multi_5";
      this.checkBox_Luck_Multi_5.Size = new Size(49, 17);
      this.checkBox_Luck_Multi_5.TabIndex = 62;
      this.checkBox_Luck_Multi_5.Text = "Luck";
      this.checkBox_Luck_Multi_5.UseVisualStyleBackColor = true;
      this.groupBox_5.BackColor = Color.Transparent;
      this.groupBox_5.Controls.Add((Control) this.radioButton_Wings_Multi_5);
      this.groupBox_5.Controls.Add((Control) this.radioButton_Armor_Multi_5);
      this.groupBox_5.Controls.Add((Control) this.radioButton_Weapon_Multi_5);
      this.groupBox_5.Controls.Add((Control) this.checkBox_ExcOption6_Multi_5);
      this.groupBox_5.Controls.Add((Control) this.checkBox_ExcOption5_Multi_5);
      this.groupBox_5.Controls.Add((Control) this.checkBox_ExcOption4_Multi_5);
      this.groupBox_5.Controls.Add((Control) this.checkBox_ExcOption3_Multi_5);
      this.groupBox_5.Controls.Add((Control) this.checkBox_ExcOption2_Multi_5);
      this.groupBox_5.Controls.Add((Control) this.checkBox_ExcOption1_Multi_5);
      this.groupBox_5.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_5.ForeColor = Color.Black;
      this.groupBox_5.Location = new Point(302, 6);
      this.groupBox_5.Name = "groupBox_5";
      this.groupBox_5.Size = new Size(200, 148);
      this.groupBox_5.TabIndex = 58;
      this.groupBox_5.TabStop = false;
      this.groupBox_5.Text = "Excellent Options";
      this.radioButton_Wings_Multi_5.AutoSize = true;
      this.radioButton_Wings_Multi_5.Location = new Point(141, 15);
      this.radioButton_Wings_Multi_5.Name = "radioButton_Wings_Multi_5";
      this.radioButton_Wings_Multi_5.Size = new Size(58, 17);
      this.radioButton_Wings_Multi_5.TabIndex = 13;
      this.radioButton_Wings_Multi_5.Text = "Wings";
      this.radioButton_Wings_Multi_5.UseVisualStyleBackColor = true;
      this.radioButton_Wings_Multi_5.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWings_CheckedChanged);
      this.radioButton_Armor_Multi_5.AutoSize = true;
      this.radioButton_Armor_Multi_5.Location = new Point(83, 15);
      this.radioButton_Armor_Multi_5.Name = "radioButton_Armor_Multi_5";
      this.radioButton_Armor_Multi_5.Size = new Size(56, 17);
      this.radioButton_Armor_Multi_5.TabIndex = 12;
      this.radioButton_Armor_Multi_5.Text = "Armor";
      this.radioButton_Armor_Multi_5.UseVisualStyleBackColor = true;
      this.radioButton_Armor_Multi_5.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcArmor_CheckedChanged);
      this.radioButton_Weapon_Multi_5.AutoSize = true;
      this.radioButton_Weapon_Multi_5.Location = new Point(11, 15);
      this.radioButton_Weapon_Multi_5.Name = "radioButton_Weapon_Multi_5";
      this.radioButton_Weapon_Multi_5.Size = new Size(69, 17);
      this.radioButton_Weapon_Multi_5.TabIndex = 11;
      this.radioButton_Weapon_Multi_5.Text = "Weapon";
      this.radioButton_Weapon_Multi_5.UseVisualStyleBackColor = true;
      this.radioButton_Weapon_Multi_5.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWeapon_CheckedChanged);
      this.checkBox_ExcOption6_Multi_5.AutoSize = true;
      this.checkBox_ExcOption6_Multi_5.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption6_Multi_5.ForeColor = Color.Black;
      this.checkBox_ExcOption6_Multi_5.Location = new Point(6, 128);
      this.checkBox_ExcOption6_Multi_5.Name = "checkBox_ExcOption6_Multi_5";
      this.checkBox_ExcOption6_Multi_5.Size = new Size(77, 17);
      this.checkBox_ExcOption6_Multi_5.TabIndex = 19;
      this.checkBox_ExcOption6_Multi_5.Text = "checkBox6";
      this.checkBox_ExcOption6_Multi_5.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption5_Multi_5.AutoSize = true;
      this.checkBox_ExcOption5_Multi_5.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption5_Multi_5.ForeColor = Color.Black;
      this.checkBox_ExcOption5_Multi_5.Location = new Point(6, 110);
      this.checkBox_ExcOption5_Multi_5.Name = "checkBox_ExcOption5_Multi_5";
      this.checkBox_ExcOption5_Multi_5.Size = new Size(77, 17);
      this.checkBox_ExcOption5_Multi_5.TabIndex = 18;
      this.checkBox_ExcOption5_Multi_5.Text = "checkBox5";
      this.checkBox_ExcOption5_Multi_5.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption4_Multi_5.AutoSize = true;
      this.checkBox_ExcOption4_Multi_5.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption4_Multi_5.ForeColor = Color.Black;
      this.checkBox_ExcOption4_Multi_5.Location = new Point(6, 91);
      this.checkBox_ExcOption4_Multi_5.Name = "checkBox_ExcOption4_Multi_5";
      this.checkBox_ExcOption4_Multi_5.Size = new Size(77, 17);
      this.checkBox_ExcOption4_Multi_5.TabIndex = 17;
      this.checkBox_ExcOption4_Multi_5.Text = "checkBox4";
      this.checkBox_ExcOption4_Multi_5.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption3_Multi_5.AutoSize = true;
      this.checkBox_ExcOption3_Multi_5.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption3_Multi_5.ForeColor = Color.Black;
      this.checkBox_ExcOption3_Multi_5.Location = new Point(6, 73);
      this.checkBox_ExcOption3_Multi_5.Name = "checkBox_ExcOption3_Multi_5";
      this.checkBox_ExcOption3_Multi_5.Size = new Size(77, 17);
      this.checkBox_ExcOption3_Multi_5.TabIndex = 16;
      this.checkBox_ExcOption3_Multi_5.Text = "checkBox3";
      this.checkBox_ExcOption3_Multi_5.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption2_Multi_5.AutoSize = true;
      this.checkBox_ExcOption2_Multi_5.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption2_Multi_5.ForeColor = Color.Black;
      this.checkBox_ExcOption2_Multi_5.Location = new Point(6, 54);
      this.checkBox_ExcOption2_Multi_5.Name = "checkBox_ExcOption2_Multi_5";
      this.checkBox_ExcOption2_Multi_5.Size = new Size(77, 17);
      this.checkBox_ExcOption2_Multi_5.TabIndex = 15;
      this.checkBox_ExcOption2_Multi_5.Text = "checkBox2";
      this.checkBox_ExcOption2_Multi_5.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption1_Multi_5.AutoSize = true;
      this.checkBox_ExcOption1_Multi_5.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption1_Multi_5.ForeColor = Color.Black;
      this.checkBox_ExcOption1_Multi_5.Location = new Point(6, 36);
      this.checkBox_ExcOption1_Multi_5.Name = "checkBox_ExcOption1_Multi_5";
      this.checkBox_ExcOption1_Multi_5.Size = new Size(77, 17);
      this.checkBox_ExcOption1_Multi_5.TabIndex = 14;
      this.checkBox_ExcOption1_Multi_5.Text = "checkBox1";
      this.checkBox_ExcOption1_Multi_5.UseVisualStyleBackColor = true;
      this.checkBox_Skill_Multi_5.AutoSize = true;
      this.checkBox_Skill_Multi_5.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Skill_Multi_5.ForeColor = Color.Black;
      this.checkBox_Skill_Multi_5.Location = new Point(156, 76);
      this.checkBox_Skill_Multi_5.Name = "checkBox_Skill_Multi_5";
      this.checkBox_Skill_Multi_5.Size = new Size(47, 17);
      this.checkBox_Skill_Multi_5.TabIndex = 61;
      this.checkBox_Skill_Multi_5.Text = "Skill";
      this.checkBox_Skill_Multi_5.UseVisualStyleBackColor = true;
      this.listBox_Option_Multi_5.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Option_Multi_5.ForeColor = Color.Black;
      this.listBox_Option_Multi_5.FormattingEnabled = true;
      this.listBox_Option_Multi_5.Location = new Point(261, 30);
      this.listBox_Option_Multi_5.Name = "listBox_Option_Multi_5";
      this.listBox_Option_Multi_5.Size = new Size(35, 121);
      this.listBox_Option_Multi_5.TabIndex = 56;
      this.textBox_Name_Multi_5.ForeColor = Color.Black;
      this.textBox_Name_Multi_5.Location = new Point(50, 30);
      this.textBox_Name_Multi_5.Name = "textBox_Name_Multi_5";
      this.textBox_Name_Multi_5.Size = new Size(151, 22);
      this.textBox_Name_Multi_5.TabIndex = 52;
      this.label29.AutoSize = true;
      this.label29.ForeColor = Color.Black;
      this.label29.Location = new Point(4, 35);
      this.label29.Name = "label29";
      this.label29.Size = new Size(36, 13);
      this.label29.TabIndex = 51;
      this.label29.Text = "Name";
      this.label30.AutoSize = true;
      this.label30.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label30.ForeColor = Color.Black;
      this.label30.Location = new Point(204, 9);
      this.label30.Name = "label30";
      this.label30.Size = new Size(32, 13);
      this.label30.TabIndex = 53;
      this.label30.Text = "Level";
      this.label31.AutoSize = true;
      this.label31.ForeColor = Color.Black;
      this.label31.Location = new Point(4, 81);
      this.label31.Name = "label31";
      this.label31.Size = new Size(31, 13);
      this.label31.TabIndex = 50;
      this.label31.Text = "Price";
      this.label32.AutoSize = true;
      this.label32.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label32.ForeColor = Color.Black;
      this.label32.Location = new Point(258, 9);
      this.label32.Name = "label32";
      this.label32.Size = new Size(44, 13);
      this.label32.TabIndex = 54;
      this.label32.Text = "Option";
      this.numericUpDown_Price_Multi_5.ForeColor = Color.Black;
      this.numericUpDown_Price_Multi_5.Location = new Point(50, 78);
      this.numericUpDown_Price_Multi_5.Maximum = new Decimal(new int[4]
      {
        2000000000,
        0,
        0,
        0
      });
      this.numericUpDown_Price_Multi_5.Name = "numericUpDown_Price_Multi_5";
      this.numericUpDown_Price_Multi_5.Size = new Size(100, 22);
      this.numericUpDown_Price_Multi_5.TabIndex = 49;
      this.listBox_Level_Multi_5.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Level_Multi_5.ForeColor = Color.Black;
      this.listBox_Level_Multi_5.FormattingEnabled = true;
      this.listBox_Level_Multi_5.Location = new Point(207, 30);
      this.listBox_Level_Multi_5.Name = "listBox_Level_Multi_5";
      this.listBox_Level_Multi_5.Size = new Size(48, 121);
      this.listBox_Level_Multi_5.TabIndex = 55;
      this.label33.AutoSize = true;
      this.label33.ForeColor = Color.Black;
      this.label33.Location = new Point(4, 57);
      this.label33.Name = "label33";
      this.label33.Size = new Size(39, 13);
      this.label33.TabIndex = 48;
      this.label33.Text = "Count";
      this.checkBox_isMulti_5.AutoSize = true;
      this.checkBox_isMulti_5.ForeColor = Color.Black;
      this.checkBox_isMulti_5.Location = new Point(4, 9);
      this.checkBox_isMulti_5.Name = "checkBox_isMulti_5";
      this.checkBox_isMulti_5.Size = new Size(68, 17);
      this.checkBox_isMulti_5.TabIndex = 46;
      this.checkBox_isMulti_5.Text = "Enabled";
      this.checkBox_isMulti_5.UseVisualStyleBackColor = true;
      this.numericUpDown_Count_Multi_5.ForeColor = Color.Black;
      this.numericUpDown_Count_Multi_5.Location = new Point(50, 54);
      this.numericUpDown_Count_Multi_5.Maximum = new Decimal(new int[4]
      {
        999999,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_5.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_5.Name = "numericUpDown_Count_Multi_5";
      this.numericUpDown_Count_Multi_5.Size = new Size(100, 22);
      this.numericUpDown_Count_Multi_5.TabIndex = 47;
      this.numericUpDown_Count_Multi_5.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label54.AutoSize = true;
      this.label54.ForeColor = Color.Black;
      this.label54.Location = new Point(1, 107);
      this.label54.Name = "label54";
      this.label54.Size = new Size(49, 13);
      this.label54.TabIndex = 66;
      this.label54.Text = "Ancient:";
      this.label53.AutoSize = true;
      this.label53.ForeColor = Color.Black;
      this.label53.Location = new Point(2, 134);
      this.label53.Name = "label53";
      this.label53.Size = new Size(49, 13);
      this.label53.TabIndex = 67;
      this.label53.Text = "Sockets:";
      this.tabPage_MultiOption_6.Controls.Add((Control) this.numericUpDown_Durability_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.label55);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.numericUpDown_Sockets_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.comboBox_Ancient_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.checkBox_Luck_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.groupBox_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.checkBox_Skill_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.listBox_Option_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.textBox_Name_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.label34);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.label35);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.label36);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.label37);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.numericUpDown_Price_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.listBox_Level_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.label38);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.checkBox_isMulti_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.numericUpDown_Count_Multi_6);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.label57);
      this.tabPage_MultiOption_6.Controls.Add((Control) this.label56);
      this.tabPage_MultiOption_6.Location = new Point(4, 22);
      this.tabPage_MultiOption_6.Name = "tabPage_MultiOption_6";
      this.tabPage_MultiOption_6.Padding = new Padding(3);
      this.tabPage_MultiOption_6.Size = new Size(508, 155);
      this.tabPage_MultiOption_6.TabIndex = 5;
      this.tabPage_MultiOption_6.Text = "Option 6";
      this.tabPage_MultiOption_6.UseVisualStyleBackColor = true;
      this.numericUpDown_Durability_Multi_6.Location = new Point(160, 130);
      this.numericUpDown_Durability_Multi_6.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Durability_Multi_6.Name = "numericUpDown_Durability_Multi_6";
      this.numericUpDown_Durability_Multi_6.Size = new Size(45, 22);
      this.numericUpDown_Durability_Multi_6.TabIndex = 22;
      this.numericUpDown_Durability_Multi_6.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.label55.AutoSize = true;
      this.label55.ForeColor = Color.Black;
      this.label55.Location = new Point(102, 133);
      this.label55.Name = "label55";
      this.label55.Size = new Size(60, 13);
      this.label55.TabIndex = 68;
      this.label55.Text = "Durability:";
      this.numericUpDown_Sockets_Multi_6.Location = new Point(50, 129);
      this.numericUpDown_Sockets_Multi_6.Maximum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.numericUpDown_Sockets_Multi_6.Name = "numericUpDown_Sockets_Multi_6";
      this.numericUpDown_Sockets_Multi_6.Size = new Size(45, 22);
      this.numericUpDown_Sockets_Multi_6.TabIndex = 21;
      this.comboBox_Ancient_Multi_6.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Ancient_Multi_6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.comboBox_Ancient_Multi_6.ForeColor = SystemColors.ActiveCaptionText;
      this.comboBox_Ancient_Multi_6.FormattingEnabled = true;
      this.comboBox_Ancient_Multi_6.Location = new Point(50, 104);
      this.comboBox_Ancient_Multi_6.Name = "comboBox_Ancient_Multi_6";
      this.comboBox_Ancient_Multi_6.Size = new Size(100, 21);
      this.comboBox_Ancient_Multi_6.TabIndex = 20;
      this.checkBox_Luck_Multi_6.AutoSize = true;
      this.checkBox_Luck_Multi_6.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Luck_Multi_6.ForeColor = Color.Black;
      this.checkBox_Luck_Multi_6.Location = new Point(156, 56);
      this.checkBox_Luck_Multi_6.Name = "checkBox_Luck_Multi_6";
      this.checkBox_Luck_Multi_6.Size = new Size(49, 17);
      this.checkBox_Luck_Multi_6.TabIndex = 62;
      this.checkBox_Luck_Multi_6.Text = "Luck";
      this.checkBox_Luck_Multi_6.UseVisualStyleBackColor = true;
      this.groupBox_6.BackColor = Color.Transparent;
      this.groupBox_6.Controls.Add((Control) this.radioButton_Wings_Multi_6);
      this.groupBox_6.Controls.Add((Control) this.radioButton_Armor_Multi_6);
      this.groupBox_6.Controls.Add((Control) this.radioButton_Weapon_Multi_6);
      this.groupBox_6.Controls.Add((Control) this.checkBox_ExcOption6_Multi_6);
      this.groupBox_6.Controls.Add((Control) this.checkBox_ExcOption5_Multi_6);
      this.groupBox_6.Controls.Add((Control) this.checkBox_ExcOption4_Multi_6);
      this.groupBox_6.Controls.Add((Control) this.checkBox_ExcOption3_Multi_6);
      this.groupBox_6.Controls.Add((Control) this.checkBox_ExcOption2_Multi_6);
      this.groupBox_6.Controls.Add((Control) this.checkBox_ExcOption1_Multi_6);
      this.groupBox_6.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_6.ForeColor = Color.Black;
      this.groupBox_6.Location = new Point(302, 6);
      this.groupBox_6.Name = "groupBox_6";
      this.groupBox_6.Size = new Size(200, 148);
      this.groupBox_6.TabIndex = 58;
      this.groupBox_6.TabStop = false;
      this.groupBox_6.Text = "Excellent Options";
      this.radioButton_Wings_Multi_6.AutoSize = true;
      this.radioButton_Wings_Multi_6.Location = new Point(141, 15);
      this.radioButton_Wings_Multi_6.Name = "radioButton_Wings_Multi_6";
      this.radioButton_Wings_Multi_6.Size = new Size(58, 17);
      this.radioButton_Wings_Multi_6.TabIndex = 13;
      this.radioButton_Wings_Multi_6.Text = "Wings";
      this.radioButton_Wings_Multi_6.UseVisualStyleBackColor = true;
      this.radioButton_Wings_Multi_6.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWings_CheckedChanged);
      this.radioButton_Armor_Multi_6.AutoSize = true;
      this.radioButton_Armor_Multi_6.Location = new Point(83, 15);
      this.radioButton_Armor_Multi_6.Name = "radioButton_Armor_Multi_6";
      this.radioButton_Armor_Multi_6.Size = new Size(56, 17);
      this.radioButton_Armor_Multi_6.TabIndex = 12;
      this.radioButton_Armor_Multi_6.Text = "Armor";
      this.radioButton_Armor_Multi_6.UseVisualStyleBackColor = true;
      this.radioButton_Armor_Multi_6.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcArmor_CheckedChanged);
      this.radioButton_Weapon_Multi_6.AutoSize = true;
      this.radioButton_Weapon_Multi_6.Location = new Point(11, 15);
      this.radioButton_Weapon_Multi_6.Name = "radioButton_Weapon_Multi_6";
      this.radioButton_Weapon_Multi_6.Size = new Size(69, 17);
      this.radioButton_Weapon_Multi_6.TabIndex = 11;
      this.radioButton_Weapon_Multi_6.Text = "Weapon";
      this.radioButton_Weapon_Multi_6.UseVisualStyleBackColor = true;
      this.radioButton_Weapon_Multi_6.CheckedChanged += new EventHandler(this.radioButton_Multi_ExcWeapon_CheckedChanged);
      this.checkBox_ExcOption6_Multi_6.AutoSize = true;
      this.checkBox_ExcOption6_Multi_6.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption6_Multi_6.ForeColor = Color.Black;
      this.checkBox_ExcOption6_Multi_6.Location = new Point(6, 128);
      this.checkBox_ExcOption6_Multi_6.Name = "checkBox_ExcOption6_Multi_6";
      this.checkBox_ExcOption6_Multi_6.Size = new Size(77, 17);
      this.checkBox_ExcOption6_Multi_6.TabIndex = 19;
      this.checkBox_ExcOption6_Multi_6.Text = "checkBox6";
      this.checkBox_ExcOption6_Multi_6.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption5_Multi_6.AutoSize = true;
      this.checkBox_ExcOption5_Multi_6.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption5_Multi_6.ForeColor = Color.Black;
      this.checkBox_ExcOption5_Multi_6.Location = new Point(6, 110);
      this.checkBox_ExcOption5_Multi_6.Name = "checkBox_ExcOption5_Multi_6";
      this.checkBox_ExcOption5_Multi_6.Size = new Size(77, 17);
      this.checkBox_ExcOption5_Multi_6.TabIndex = 18;
      this.checkBox_ExcOption5_Multi_6.Text = "checkBox5";
      this.checkBox_ExcOption5_Multi_6.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption4_Multi_6.AutoSize = true;
      this.checkBox_ExcOption4_Multi_6.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption4_Multi_6.ForeColor = Color.Black;
      this.checkBox_ExcOption4_Multi_6.Location = new Point(6, 91);
      this.checkBox_ExcOption4_Multi_6.Name = "checkBox_ExcOption4_Multi_6";
      this.checkBox_ExcOption4_Multi_6.Size = new Size(77, 17);
      this.checkBox_ExcOption4_Multi_6.TabIndex = 17;
      this.checkBox_ExcOption4_Multi_6.Text = "checkBox4";
      this.checkBox_ExcOption4_Multi_6.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption3_Multi_6.AutoSize = true;
      this.checkBox_ExcOption3_Multi_6.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption3_Multi_6.ForeColor = Color.Black;
      this.checkBox_ExcOption3_Multi_6.Location = new Point(6, 73);
      this.checkBox_ExcOption3_Multi_6.Name = "checkBox_ExcOption3_Multi_6";
      this.checkBox_ExcOption3_Multi_6.Size = new Size(77, 17);
      this.checkBox_ExcOption3_Multi_6.TabIndex = 16;
      this.checkBox_ExcOption3_Multi_6.Text = "checkBox3";
      this.checkBox_ExcOption3_Multi_6.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption2_Multi_6.AutoSize = true;
      this.checkBox_ExcOption2_Multi_6.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption2_Multi_6.ForeColor = Color.Black;
      this.checkBox_ExcOption2_Multi_6.Location = new Point(6, 54);
      this.checkBox_ExcOption2_Multi_6.Name = "checkBox_ExcOption2_Multi_6";
      this.checkBox_ExcOption2_Multi_6.Size = new Size(77, 17);
      this.checkBox_ExcOption2_Multi_6.TabIndex = 15;
      this.checkBox_ExcOption2_Multi_6.Text = "checkBox2";
      this.checkBox_ExcOption2_Multi_6.UseVisualStyleBackColor = true;
      this.checkBox_ExcOption1_Multi_6.AutoSize = true;
      this.checkBox_ExcOption1_Multi_6.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOption1_Multi_6.ForeColor = Color.Black;
      this.checkBox_ExcOption1_Multi_6.Location = new Point(6, 36);
      this.checkBox_ExcOption1_Multi_6.Name = "checkBox_ExcOption1_Multi_6";
      this.checkBox_ExcOption1_Multi_6.Size = new Size(77, 17);
      this.checkBox_ExcOption1_Multi_6.TabIndex = 14;
      this.checkBox_ExcOption1_Multi_6.Text = "checkBox1";
      this.checkBox_ExcOption1_Multi_6.UseVisualStyleBackColor = true;
      this.checkBox_Skill_Multi_6.AutoSize = true;
      this.checkBox_Skill_Multi_6.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_Skill_Multi_6.ForeColor = Color.Black;
      this.checkBox_Skill_Multi_6.Location = new Point(156, 76);
      this.checkBox_Skill_Multi_6.Name = "checkBox_Skill_Multi_6";
      this.checkBox_Skill_Multi_6.Size = new Size(47, 17);
      this.checkBox_Skill_Multi_6.TabIndex = 61;
      this.checkBox_Skill_Multi_6.Text = "Skill";
      this.checkBox_Skill_Multi_6.UseVisualStyleBackColor = true;
      this.listBox_Option_Multi_6.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Option_Multi_6.ForeColor = Color.Black;
      this.listBox_Option_Multi_6.FormattingEnabled = true;
      this.listBox_Option_Multi_6.Location = new Point(261, 30);
      this.listBox_Option_Multi_6.Name = "listBox_Option_Multi_6";
      this.listBox_Option_Multi_6.Size = new Size(35, 121);
      this.listBox_Option_Multi_6.TabIndex = 56;
      this.textBox_Name_Multi_6.ForeColor = Color.Black;
      this.textBox_Name_Multi_6.Location = new Point(50, 30);
      this.textBox_Name_Multi_6.Name = "textBox_Name_Multi_6";
      this.textBox_Name_Multi_6.Size = new Size(151, 22);
      this.textBox_Name_Multi_6.TabIndex = 52;
      this.label34.AutoSize = true;
      this.label34.ForeColor = Color.Black;
      this.label34.Location = new Point(4, 35);
      this.label34.Name = "label34";
      this.label34.Size = new Size(36, 13);
      this.label34.TabIndex = 51;
      this.label34.Text = "Name";
      this.label35.AutoSize = true;
      this.label35.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label35.ForeColor = Color.Black;
      this.label35.Location = new Point(204, 9);
      this.label35.Name = "label35";
      this.label35.Size = new Size(32, 13);
      this.label35.TabIndex = 53;
      this.label35.Text = "Level";
      this.label36.AutoSize = true;
      this.label36.ForeColor = Color.Black;
      this.label36.Location = new Point(4, 81);
      this.label36.Name = "label36";
      this.label36.Size = new Size(31, 13);
      this.label36.TabIndex = 50;
      this.label36.Text = "Price";
      this.label37.AutoSize = true;
      this.label37.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label37.ForeColor = Color.Black;
      this.label37.Location = new Point(258, 9);
      this.label37.Name = "label37";
      this.label37.Size = new Size(44, 13);
      this.label37.TabIndex = 54;
      this.label37.Text = "Option";
      this.numericUpDown_Price_Multi_6.ForeColor = Color.Black;
      this.numericUpDown_Price_Multi_6.Location = new Point(50, 78);
      this.numericUpDown_Price_Multi_6.Maximum = new Decimal(new int[4]
      {
        2000000000,
        0,
        0,
        0
      });
      this.numericUpDown_Price_Multi_6.Name = "numericUpDown_Price_Multi_6";
      this.numericUpDown_Price_Multi_6.Size = new Size(100, 22);
      this.numericUpDown_Price_Multi_6.TabIndex = 49;
      this.listBox_Level_Multi_6.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_Level_Multi_6.ForeColor = Color.Black;
      this.listBox_Level_Multi_6.FormattingEnabled = true;
      this.listBox_Level_Multi_6.Location = new Point(207, 30);
      this.listBox_Level_Multi_6.Name = "listBox_Level_Multi_6";
      this.listBox_Level_Multi_6.Size = new Size(48, 121);
      this.listBox_Level_Multi_6.TabIndex = 55;
      this.label38.AutoSize = true;
      this.label38.ForeColor = Color.Black;
      this.label38.Location = new Point(4, 57);
      this.label38.Name = "label38";
      this.label38.Size = new Size(39, 13);
      this.label38.TabIndex = 48;
      this.label38.Text = "Count";
      this.checkBox_isMulti_6.AutoSize = true;
      this.checkBox_isMulti_6.ForeColor = Color.Black;
      this.checkBox_isMulti_6.Location = new Point(4, 9);
      this.checkBox_isMulti_6.Name = "checkBox_isMulti_6";
      this.checkBox_isMulti_6.Size = new Size(68, 17);
      this.checkBox_isMulti_6.TabIndex = 46;
      this.checkBox_isMulti_6.Text = "Enabled";
      this.checkBox_isMulti_6.UseVisualStyleBackColor = true;
      this.numericUpDown_Count_Multi_6.ForeColor = Color.Black;
      this.numericUpDown_Count_Multi_6.Location = new Point(50, 54);
      this.numericUpDown_Count_Multi_6.Maximum = new Decimal(new int[4]
      {
        999999,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_6.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown_Count_Multi_6.Name = "numericUpDown_Count_Multi_6";
      this.numericUpDown_Count_Multi_6.Size = new Size(100, 22);
      this.numericUpDown_Count_Multi_6.TabIndex = 47;
      this.numericUpDown_Count_Multi_6.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label57.AutoSize = true;
      this.label57.ForeColor = Color.Black;
      this.label57.Location = new Point(1, 107);
      this.label57.Name = "label57";
      this.label57.Size = new Size(49, 13);
      this.label57.TabIndex = 66;
      this.label57.Text = "Ancient:";
      this.label56.AutoSize = true;
      this.label56.ForeColor = Color.Black;
      this.label56.Location = new Point(2, 134);
      this.label56.Name = "label56";
      this.label56.Size = new Size(49, 13);
      this.label56.TabIndex = 67;
      this.label56.Text = "Sockets:";
      this.comboBox_NewItem_CountType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_NewItem_CountType.DropDownWidth = (int) byte.MaxValue;
      this.comboBox_NewItem_CountType.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_NewItem_CountType.FormattingEnabled = true;
      this.comboBox_NewItem_CountType.Items.AddRange(new object[5]
      {
        (object) "Normal (Quantity)",
        (object) "Expiration Seal/Scroll (Minutes)",
        (object) "Expiration Pet/Item (Minutes)",
        (object) "Character Card",
        (object) "VIP Card (Days)"
      });
      this.comboBox_NewItem_CountType.Location = new Point(171, 120);
      this.comboBox_NewItem_CountType.Name = "comboBox_NewItem_CountType";
      this.comboBox_NewItem_CountType.Size = new Size(123, 21);
      this.comboBox_NewItem_CountType.TabIndex = 6;
      this.numericUpDown_NewItem_Count.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_NewItem_Count.Location = new Point(57, 120);
      this.numericUpDown_NewItem_Count.Maximum = new Decimal(new int[4]
      {
        99999,
        0,
        0,
        0
      });
      this.numericUpDown_NewItem_Count.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDown_NewItem_Count.Name = "numericUpDown_NewItem_Count";
      this.numericUpDown_NewItem_Count.Size = new Size(73, 22);
      this.numericUpDown_NewItem_Count.TabIndex = 5;
      this.numericUpDown_NewItem_Count.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.comboBox_NewItem_Coin.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_NewItem_Coin.DropDownWidth = (int) byte.MaxValue;
      this.comboBox_NewItem_Coin.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.comboBox_NewItem_Coin.FormattingEnabled = true;
      this.comboBox_NewItem_Coin.Items.AddRange(new object[3]
      {
        (object) "W Coin (C)",
        (object) "W Coin (P)",
        (object) "Goblin Point"
      });
      this.comboBox_NewItem_Coin.Location = new Point(57, 146);
      this.comboBox_NewItem_Coin.Name = "comboBox_NewItem_Coin";
      this.comboBox_NewItem_Coin.Size = new Size(98, 21);
      this.comboBox_NewItem_Coin.TabIndex = 4;
      this.numericUpDown_NewItem_Price.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.numericUpDown_NewItem_Price.Location = new Point(201, 145);
      this.numericUpDown_NewItem_Price.Maximum = new Decimal(new int[4]
      {
        2000000000,
        0,
        0,
        0
      });
      this.numericUpDown_NewItem_Price.Name = "numericUpDown_NewItem_Price";
      this.numericUpDown_NewItem_Price.Size = new Size(93, 22);
      this.numericUpDown_NewItem_Price.TabIndex = 3;
      this.textBox_NewItem_Name.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.textBox_NewItem_Name.Location = new Point(57, 21);
      this.textBox_NewItem_Name.Name = "textBox_NewItem_Name";
      this.textBox_NewItem_Name.Size = new Size(237, 22);
      this.textBox_NewItem_Name.TabIndex = 2;
      this.richTextBox_NewItem_Info.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.richTextBox_NewItem_Info.Location = new Point(57, 47);
      this.richTextBox_NewItem_Info.Name = "richTextBox_NewItem_Info";
      this.richTextBox_NewItem_Info.Size = new Size(237, 68);
      this.richTextBox_NewItem_Info.TabIndex = 7;
      this.richTextBox_NewItem_Info.Text = "";
      this.richTextBox_NewItem_Info.WordWrap = false;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(12, 148);
      this.label7.Name = "label7";
      this.label7.Size = new Size(34, 13);
      this.label7.TabIndex = 26;
      this.label7.Text = "Coin:";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(136, 123);
      this.label6.Name = "label6";
      this.label6.Size = new Size(33, 13);
      this.label6.TabIndex = 25;
      this.label6.Text = "Type:";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(12, 24);
      this.label5.Name = "label5";
      this.label5.Size = new Size(39, 13);
      this.label5.TabIndex = 24;
      this.label5.Text = "Name:";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(12, 123);
      this.label2.Name = "label2";
      this.label2.Size = new Size(42, 13);
      this.label2.TabIndex = 23;
      this.label2.Text = "Count:";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(161, 148);
      this.label1.Name = "label1";
      this.label1.Size = new Size(34, 13);
      this.label1.TabIndex = 22;
      this.label1.Text = "Price:";
      this.groupBox_ItemProperties.BackColor = Color.Transparent;
      this.groupBox_ItemProperties.Controls.Add((Control) this.groupBox_NewItem_ExcOpt);
      this.groupBox_ItemProperties.Controls.Add((Control) this.listBox_NewItem_ItemOption);
      this.groupBox_ItemProperties.Controls.Add((Control) this.checkBox_AddItem_FOItem);
      this.groupBox_ItemProperties.Controls.Add((Control) this.checkBox_NewItem_Luck);
      this.groupBox_ItemProperties.Controls.Add((Control) this.groupBox9);
      this.groupBox_ItemProperties.Controls.Add((Control) this.label3);
      this.groupBox_ItemProperties.Controls.Add((Control) this.checkBox_NewItem_Skill);
      this.groupBox_ItemProperties.Controls.Add((Control) this.groupBox8);
      this.groupBox_ItemProperties.Controls.Add((Control) this.label4);
      this.groupBox_ItemProperties.Controls.Add((Control) this.groupBox6);
      this.groupBox_ItemProperties.Controls.Add((Control) this.listBox_NewItem_ItemLevel);
      this.groupBox_ItemProperties.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.groupBox_ItemProperties.ForeColor = Color.Turquoise;
      this.groupBox_ItemProperties.Location = new Point(20, 188);
      this.groupBox_ItemProperties.Name = "groupBox_ItemProperties";
      this.groupBox_ItemProperties.Size = new Size(303, 271);
      this.groupBox_ItemProperties.TabIndex = 20;
      this.groupBox_ItemProperties.TabStop = false;
      this.groupBox_ItemProperties.Text = "Item Properties (Single item ONLY!)";
      this.groupBox_NewItem_ExcOpt.BackColor = Color.Transparent;
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.radioButton_NewItem_ExcWings);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.radioButton_NewItem_ExcArmor);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.radioButton_NewItem_ExcWeapon);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_NewItem_ExcOpt6);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_NewItem_ExcOpt5);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_NewItem_ExcOpt4);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_NewItem_ExcOpt3);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_NewItem_ExcOpt2);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_NewItem_ExcOpt1);
      this.groupBox_NewItem_ExcOpt.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox_NewItem_ExcOpt.ForeColor = Color.LawnGreen;
      this.groupBox_NewItem_ExcOpt.Location = new Point(94, 18);
      this.groupBox_NewItem_ExcOpt.Name = "groupBox_NewItem_ExcOpt";
      this.groupBox_NewItem_ExcOpt.Size = new Size(200, 148);
      this.groupBox_NewItem_ExcOpt.TabIndex = 17;
      this.groupBox_NewItem_ExcOpt.TabStop = false;
      this.groupBox_NewItem_ExcOpt.Text = "Excellent Options";
      this.radioButton_NewItem_ExcWings.AutoSize = true;
      this.radioButton_NewItem_ExcWings.Location = new Point(141, 15);
      this.radioButton_NewItem_ExcWings.Name = "radioButton_NewItem_ExcWings";
      this.radioButton_NewItem_ExcWings.Size = new Size(58, 17);
      this.radioButton_NewItem_ExcWings.TabIndex = 13;
      this.radioButton_NewItem_ExcWings.Text = "Wings";
      this.radioButton_NewItem_ExcWings.UseVisualStyleBackColor = true;
      this.radioButton_NewItem_ExcWings.CheckedChanged += new EventHandler(this.radioButton_ExcWings_CheckedChanged);
      this.radioButton_NewItem_ExcArmor.AutoSize = true;
      this.radioButton_NewItem_ExcArmor.Location = new Point(83, 15);
      this.radioButton_NewItem_ExcArmor.Name = "radioButton_NewItem_ExcArmor";
      this.radioButton_NewItem_ExcArmor.Size = new Size(56, 17);
      this.radioButton_NewItem_ExcArmor.TabIndex = 12;
      this.radioButton_NewItem_ExcArmor.Text = "Armor";
      this.radioButton_NewItem_ExcArmor.UseVisualStyleBackColor = true;
      this.radioButton_NewItem_ExcArmor.CheckedChanged += new EventHandler(this.radioButton_ExcArmor_CheckedChanged);
      this.radioButton_NewItem_ExcWeapon.AutoSize = true;
      this.radioButton_NewItem_ExcWeapon.Location = new Point(11, 15);
      this.radioButton_NewItem_ExcWeapon.Name = "radioButton_NewItem_ExcWeapon";
      this.radioButton_NewItem_ExcWeapon.Size = new Size(69, 17);
      this.radioButton_NewItem_ExcWeapon.TabIndex = 11;
      this.radioButton_NewItem_ExcWeapon.Text = "Weapon";
      this.radioButton_NewItem_ExcWeapon.UseVisualStyleBackColor = true;
      this.radioButton_NewItem_ExcWeapon.CheckedChanged += new EventHandler(this.radioButton_ExcWeapon_CheckedChanged);
      this.checkBox_NewItem_ExcOpt6.AutoSize = true;
      this.checkBox_NewItem_ExcOpt6.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_NewItem_ExcOpt6.ForeColor = Color.LawnGreen;
      this.checkBox_NewItem_ExcOpt6.Location = new Point(6, 128);
      this.checkBox_NewItem_ExcOpt6.Name = "checkBox_NewItem_ExcOpt6";
      this.checkBox_NewItem_ExcOpt6.Size = new Size(77, 17);
      this.checkBox_NewItem_ExcOpt6.TabIndex = 19;
      this.checkBox_NewItem_ExcOpt6.Text = "checkBox6";
      this.checkBox_NewItem_ExcOpt6.UseVisualStyleBackColor = true;
      this.checkBox_NewItem_ExcOpt5.AutoSize = true;
      this.checkBox_NewItem_ExcOpt5.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_NewItem_ExcOpt5.ForeColor = Color.LawnGreen;
      this.checkBox_NewItem_ExcOpt5.Location = new Point(6, 110);
      this.checkBox_NewItem_ExcOpt5.Name = "checkBox_NewItem_ExcOpt5";
      this.checkBox_NewItem_ExcOpt5.Size = new Size(77, 17);
      this.checkBox_NewItem_ExcOpt5.TabIndex = 18;
      this.checkBox_NewItem_ExcOpt5.Text = "checkBox5";
      this.checkBox_NewItem_ExcOpt5.UseVisualStyleBackColor = true;
      this.checkBox_NewItem_ExcOpt4.AutoSize = true;
      this.checkBox_NewItem_ExcOpt4.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_NewItem_ExcOpt4.ForeColor = Color.LawnGreen;
      this.checkBox_NewItem_ExcOpt4.Location = new Point(6, 91);
      this.checkBox_NewItem_ExcOpt4.Name = "checkBox_NewItem_ExcOpt4";
      this.checkBox_NewItem_ExcOpt4.Size = new Size(77, 17);
      this.checkBox_NewItem_ExcOpt4.TabIndex = 17;
      this.checkBox_NewItem_ExcOpt4.Text = "checkBox4";
      this.checkBox_NewItem_ExcOpt4.UseVisualStyleBackColor = true;
      this.checkBox_NewItem_ExcOpt3.AutoSize = true;
      this.checkBox_NewItem_ExcOpt3.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_NewItem_ExcOpt3.ForeColor = Color.LawnGreen;
      this.checkBox_NewItem_ExcOpt3.Location = new Point(6, 73);
      this.checkBox_NewItem_ExcOpt3.Name = "checkBox_NewItem_ExcOpt3";
      this.checkBox_NewItem_ExcOpt3.Size = new Size(77, 17);
      this.checkBox_NewItem_ExcOpt3.TabIndex = 16;
      this.checkBox_NewItem_ExcOpt3.Text = "checkBox3";
      this.checkBox_NewItem_ExcOpt3.UseVisualStyleBackColor = true;
      this.checkBox_NewItem_ExcOpt2.AutoSize = true;
      this.checkBox_NewItem_ExcOpt2.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_NewItem_ExcOpt2.ForeColor = Color.LawnGreen;
      this.checkBox_NewItem_ExcOpt2.Location = new Point(6, 54);
      this.checkBox_NewItem_ExcOpt2.Name = "checkBox_NewItem_ExcOpt2";
      this.checkBox_NewItem_ExcOpt2.Size = new Size(77, 17);
      this.checkBox_NewItem_ExcOpt2.TabIndex = 15;
      this.checkBox_NewItem_ExcOpt2.Text = "checkBox2";
      this.checkBox_NewItem_ExcOpt2.UseVisualStyleBackColor = true;
      this.checkBox_NewItem_ExcOpt1.AutoSize = true;
      this.checkBox_NewItem_ExcOpt1.Font = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_NewItem_ExcOpt1.ForeColor = Color.LawnGreen;
      this.checkBox_NewItem_ExcOpt1.Location = new Point(6, 36);
      this.checkBox_NewItem_ExcOpt1.Name = "checkBox_NewItem_ExcOpt1";
      this.checkBox_NewItem_ExcOpt1.Size = new Size(77, 17);
      this.checkBox_NewItem_ExcOpt1.TabIndex = 14;
      this.checkBox_NewItem_ExcOpt1.Text = "checkBox1";
      this.checkBox_NewItem_ExcOpt1.UseVisualStyleBackColor = true;
      this.listBox_NewItem_ItemOption.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_NewItem_ItemOption.FormattingEnabled = true;
      this.listBox_NewItem_ItemOption.Location = new Point(52, 38);
      this.listBox_NewItem_ItemOption.Name = "listBox_NewItem_ItemOption";
      this.listBox_NewItem_ItemOption.Size = new Size(35, 134);
      this.listBox_NewItem_ItemOption.TabIndex = 9;
      this.checkBox_AddItem_FOItem.AutoSize = true;
      this.checkBox_AddItem_FOItem.BackColor = Color.Transparent;
      this.checkBox_AddItem_FOItem.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_AddItem_FOItem.ForeColor = Color.LightSkyBlue;
      this.checkBox_AddItem_FOItem.Location = new Point(53, 184);
      this.checkBox_AddItem_FOItem.Name = "checkBox_AddItem_FOItem";
      this.checkBox_AddItem_FOItem.Size = new Size(131, 17);
      this.checkBox_AddItem_FOItem.TabIndex = 10;
      this.checkBox_AddItem_FOItem.Text = "Exc FO+15+28+Luck";
      this.checkBox_AddItem_FOItem.UseVisualStyleBackColor = false;
      this.checkBox_AddItem_FOItem.CheckedChanged += new EventHandler(this.checkBox_AddItem_FOItem_CheckedChanged);
      this.checkBox_NewItem_Luck.AutoSize = true;
      this.checkBox_NewItem_Luck.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_NewItem_Luck.ForeColor = Color.Turquoise;
      this.checkBox_NewItem_Luck.Location = new Point(240, 245);
      this.checkBox_NewItem_Luck.Name = "checkBox_NewItem_Luck";
      this.checkBox_NewItem_Luck.Size = new Size(49, 17);
      this.checkBox_NewItem_Luck.TabIndex = 24;
      this.checkBox_NewItem_Luck.Text = "Luck";
      this.checkBox_NewItem_Luck.UseVisualStyleBackColor = true;
      this.groupBox9.Controls.Add((Control) this.comboBox_Ancient);
      this.groupBox9.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox9.ForeColor = Color.SpringGreen;
      this.groupBox9.Location = new Point(185, 171);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new Size(105, 46);
      this.groupBox9.TabIndex = 14;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Ancient ";
      this.comboBox_Ancient.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Ancient.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.comboBox_Ancient.ForeColor = SystemColors.ActiveCaptionText;
      this.comboBox_Ancient.FormattingEnabled = true;
      this.comboBox_Ancient.Location = new Point(6, 18);
      this.comboBox_Ancient.Name = "comboBox_Ancient";
      this.comboBox_Ancient.Size = new Size(94, 21);
      this.comboBox_Ancient.TabIndex = 20;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.Turquoise;
      this.label3.Location = new Point(8, 18);
      this.label3.Name = "label3";
      this.label3.Size = new Size(32, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Level";
      this.checkBox_NewItem_Skill.AutoSize = true;
      this.checkBox_NewItem_Skill.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.checkBox_NewItem_Skill.ForeColor = Color.Turquoise;
      this.checkBox_NewItem_Skill.Location = new Point(240, 224);
      this.checkBox_NewItem_Skill.Name = "checkBox_NewItem_Skill";
      this.checkBox_NewItem_Skill.Size = new Size(47, 17);
      this.checkBox_NewItem_Skill.TabIndex = 23;
      this.checkBox_NewItem_Skill.Text = "Skill";
      this.checkBox_NewItem_Skill.UseVisualStyleBackColor = true;
      this.groupBox8.BackColor = Color.Transparent;
      this.groupBox8.Controls.Add((Control) this.numericUpDown_NewItem_SocketCount);
      this.groupBox8.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox8.ForeColor = Color.BlueViolet;
      this.groupBox8.Location = new Point(58, 222);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new Size(95, 43);
      this.groupBox8.TabIndex = 12;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Empty Sockets";
      this.numericUpDown_NewItem_SocketCount.Location = new Point(25, 16);
      this.numericUpDown_NewItem_SocketCount.Maximum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.numericUpDown_NewItem_SocketCount.Name = "numericUpDown_NewItem_SocketCount";
      this.numericUpDown_NewItem_SocketCount.Size = new Size(45, 22);
      this.numericUpDown_NewItem_SocketCount.TabIndex = 21;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.Turquoise;
      this.label4.Location = new Point(49, 18);
      this.label4.Name = "label4";
      this.label4.Size = new Size(44, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Option";
      this.groupBox6.Controls.Add((Control) this.numericUpDown_NewItem_Durability);
      this.groupBox6.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.groupBox6.ForeColor = Color.DarkKhaki;
      this.groupBox6.Location = new Point(157, 222);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(72, 43);
      this.groupBox6.TabIndex = 10;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Duration";
      this.numericUpDown_NewItem_Durability.Location = new Point(14, 16);
      this.numericUpDown_NewItem_Durability.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_NewItem_Durability.Name = "numericUpDown_NewItem_Durability";
      this.numericUpDown_NewItem_Durability.Size = new Size(45, 22);
      this.numericUpDown_NewItem_Durability.TabIndex = 22;
      this.numericUpDown_NewItem_Durability.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.listBox_NewItem_ItemLevel.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.listBox_NewItem_ItemLevel.FormattingEnabled = true;
      this.listBox_NewItem_ItemLevel.Location = new Point(11, 38);
      this.listBox_NewItem_ItemLevel.Name = "listBox_NewItem_ItemLevel";
      this.listBox_NewItem_ItemLevel.Size = new Size(35, 186);
      this.listBox_NewItem_ItemLevel.TabIndex = 8;
      this.button_NewItem_Add.Location = new Point(700, 427);
      this.button_NewItem_Add.Name = "button_NewItem_Add";
      this.button_NewItem_Add.Size = new Size(190, 32);
      this.button_NewItem_Add.TabIndex = 25;
      this.button_NewItem_Add.Text = "Add to [Shop]\r\nCtrl + F";
      this.button_NewItem_Add.UseVisualStyleBackColor = true;
      this.button_NewItem_Add.Click += new EventHandler(this.button_NewItem_Add_Click);
      this.pictureBox_NewItem_ItemPreview.BackColor = Color.Transparent;
      this.pictureBox_NewItem_ItemPreview.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_NewItem_ItemPreview.Location = new Point(20, 104);
      this.pictureBox_NewItem_ItemPreview.Name = "pictureBox_NewItem_ItemPreview";
      this.pictureBox_NewItem_ItemPreview.Size = new Size(129, 79);
      this.pictureBox_NewItem_ItemPreview.TabIndex = 3;
      this.pictureBox_NewItem_ItemPreview.TabStop = false;
      this.listBox_NewItem_ItemIndex.FormattingEnabled = true;
      this.listBox_NewItem_ItemIndex.Location = new Point(155, 23);
      this.listBox_NewItem_ItemIndex.Name = "listBox_NewItem_ItemIndex";
      this.listBox_NewItem_ItemIndex.Size = new Size(168, 160);
      this.listBox_NewItem_ItemIndex.TabIndex = 1;
      this.listBox_NewItem_ItemIndex.SelectedIndexChanged += new EventHandler(this.listBox_NewItem_ItemIndex_SelectedIndexChanged);
      this.listBox_NewItem_ItemGroup.FormattingEnabled = true;
      this.listBox_NewItem_ItemGroup.Location = new Point(20, 23);
      this.listBox_NewItem_ItemGroup.Name = "listBox_NewItem_ItemGroup";
      this.listBox_NewItem_ItemGroup.Size = new Size(129, 69);
      this.listBox_NewItem_ItemGroup.TabIndex = 0;
      this.listBox_NewItem_ItemGroup.SelectedIndexChanged += new EventHandler(this.listBox_NewItem_ItemGroup_SelectedIndexChanged);
      this.textBox_Info.BackColor = Color.DimGray;
      this.textBox_Info.ForeColor = SystemColors.Info;
      this.textBox_Info.Location = new Point(-2, 476);
      this.textBox_Info.Name = "textBox_Info";
      this.textBox_Info.ReadOnly = true;
      this.textBox_Info.Size = new Size(915, 21);
      this.textBox_Info.TabIndex = 4;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(911, 493);
      this.Controls.Add((Control) this.panel_ItemAdd);
      this.Controls.Add((Control) this.textBox_Info);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = nameof (Form_CashShop_AddItems);
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "Cash Shop Item Adder";
      this.FormClosing += new FormClosingEventHandler(this.Form_CashShop_AddItems_FormClosing);
      this.Load += new EventHandler(this.Form_CashShop_AddItems_Load);
      this.KeyDown += new KeyEventHandler(this.Form_CashShop_AddItems_KeyDown);
      this.panel_ItemAdd.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox_PackageItem.ResumeLayout(false);
      this.groupBox_PackageItem.PerformLayout();
      this.groupBox_MultiItem.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage_MultiOption_1.ResumeLayout(false);
      this.tabPage_MultiOption_1.PerformLayout();
      this.numericUpDown_Durability_Multi_1.EndInit();
      this.numericUpDown_Sockets_Multi_1.EndInit();
      this.groupBox_1.ResumeLayout(false);
      this.groupBox_1.PerformLayout();
      this.numericUpDown_Price_Multi_1.EndInit();
      this.numericUpDown_Count_Multi_1.EndInit();
      this.tabPage_MultiOption_2.ResumeLayout(false);
      this.tabPage_MultiOption_2.PerformLayout();
      this.numericUpDown_Durability_Multi_2.EndInit();
      this.numericUpDown_Sockets_Multi_2.EndInit();
      this.groupBox_2.ResumeLayout(false);
      this.groupBox_2.PerformLayout();
      this.numericUpDown_Price_Multi_2.EndInit();
      this.numericUpDown_Count_Multi_2.EndInit();
      this.tabPage_MultiOption_3.ResumeLayout(false);
      this.tabPage_MultiOption_3.PerformLayout();
      this.numericUpDown_Durability_Multi_3.EndInit();
      this.numericUpDown_Sockets_Multi_3.EndInit();
      this.groupBox_3.ResumeLayout(false);
      this.groupBox_3.PerformLayout();
      this.numericUpDown_Price_Multi_3.EndInit();
      this.numericUpDown_Count_Multi_3.EndInit();
      this.tabPage_MultiOption_4.ResumeLayout(false);
      this.tabPage_MultiOption_4.PerformLayout();
      this.numericUpDown_Durability_Multi_4.EndInit();
      this.numericUpDown_Sockets_Multi_4.EndInit();
      this.groupBox_4.ResumeLayout(false);
      this.groupBox_4.PerformLayout();
      this.numericUpDown_Price_Multi_4.EndInit();
      this.numericUpDown_Count_Multi_4.EndInit();
      this.tabPage_MultiOption_5.ResumeLayout(false);
      this.tabPage_MultiOption_5.PerformLayout();
      this.numericUpDown_Durability_Multi_5.EndInit();
      this.numericUpDown_Sockets_Multi_5.EndInit();
      this.groupBox_5.ResumeLayout(false);
      this.groupBox_5.PerformLayout();
      this.numericUpDown_Price_Multi_5.EndInit();
      this.numericUpDown_Count_Multi_5.EndInit();
      this.tabPage_MultiOption_6.ResumeLayout(false);
      this.tabPage_MultiOption_6.PerformLayout();
      this.numericUpDown_Durability_Multi_6.EndInit();
      this.numericUpDown_Sockets_Multi_6.EndInit();
      this.groupBox_6.ResumeLayout(false);
      this.groupBox_6.PerformLayout();
      this.numericUpDown_Price_Multi_6.EndInit();
      this.numericUpDown_Count_Multi_6.EndInit();
      this.numericUpDown_NewItem_Count.EndInit();
      this.numericUpDown_NewItem_Price.EndInit();
      this.groupBox_ItemProperties.ResumeLayout(false);
      this.groupBox_ItemProperties.PerformLayout();
      this.groupBox_NewItem_ExcOpt.ResumeLayout(false);
      this.groupBox_NewItem_ExcOpt.PerformLayout();
      this.groupBox9.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.numericUpDown_NewItem_SocketCount.EndInit();
      this.groupBox6.ResumeLayout(false);
      this.numericUpDown_NewItem_Durability.EndInit();
      ((ISupportInitialize) this.pictureBox_NewItem_ItemPreview).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void listBox_NewItem_ItemGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.PopulateItemIndex(this.listBox_NewItem_ItemIndex, this.listBox_NewItem_ItemGroup);
      if (this.frm_Parent.LastSelectedItemIndex <= this.listBox_NewItem_ItemIndex.Items.Count - 1)
      {
        this.listBox_NewItem_ItemIndex.SelectedIndex = -1;
        this.listBox_NewItem_ItemIndex.SelectedIndex = this.frm_Parent.LastSelectedItemIndex;
      }
      else
      {
        this.listBox_NewItem_ItemIndex.SelectedIndex = -1;
        this.listBox_NewItem_ItemIndex.SelectedIndex = 0;
      }
      if (this.FirstRun)
      {
        this.listBox_NewItem_ItemIndex.SelectedIndex = -1;
        this.listBox_NewItem_ItemIndex.SelectedIndex = 0;
        this.FirstRun = false;
      }
      switch (this.listBox_NewItem_ItemGroup.SelectedIndex)
      {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
          this.radioButton_NewItem_ExcWeapon.Checked = true;
          this.radioButton_Weapon_Multi_1.Checked = true;
          this.radioButton_Weapon_Multi_2.Checked = true;
          this.radioButton_Weapon_Multi_3.Checked = true;
          this.radioButton_Weapon_Multi_4.Checked = true;
          this.radioButton_Weapon_Multi_5.Checked = true;
          this.radioButton_Weapon_Multi_6.Checked = true;
          break;
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
          this.radioButton_NewItem_ExcArmor.Checked = true;
          this.radioButton_Armor_Multi_1.Checked = true;
          this.radioButton_Armor_Multi_2.Checked = true;
          this.radioButton_Armor_Multi_3.Checked = true;
          this.radioButton_Armor_Multi_4.Checked = true;
          this.radioButton_Armor_Multi_5.Checked = true;
          this.radioButton_Armor_Multi_6.Checked = true;
          break;
        case 12:
          this.radioButton_NewItem_ExcWings.Checked = true;
          this.radioButton_Wings_Multi_1.Checked = true;
          this.radioButton_Wings_Multi_2.Checked = true;
          this.radioButton_Wings_Multi_3.Checked = true;
          this.radioButton_Wings_Multi_4.Checked = true;
          this.radioButton_Wings_Multi_5.Checked = true;
          this.radioButton_Wings_Multi_6.Checked = true;
          break;
      }
    }

    private void listBox_NewItem_ItemIndex_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.listBox_NewItem_ItemIndex.SelectedIndex == -1 || this.DontWork)
        return;
      this.frm_Parent.LastSelectedItemIndex = this.listBox_NewItem_ItemIndex.SelectedIndex;
      try
      {
        this.textBox_NewItem_Name.Text = this.listBox_NewItem_ItemIndex.Text.Trim();
        this.pictureBox_NewItem_ItemPreview.BackgroundImage = (Image) Resources.ResourceManager.GetObject("_" + this.listBox_NewItem_ItemGroup.SelectedValue + this.listBox_NewItem_ItemIndex.SelectedValue);
        if (this.pictureBox_NewItem_ItemPreview.BackgroundImage.Size.Width > this.pictureBox_NewItem_ItemPreview.Size.Width || this.pictureBox_NewItem_ItemPreview.BackgroundImage.Size.Height > this.pictureBox_NewItem_ItemPreview.Size.Height)
          this.pictureBox_NewItem_ItemPreview.BackgroundImageLayout = ImageLayout.Zoom;
        else
          this.pictureBox_NewItem_ItemPreview.BackgroundImageLayout = ImageLayout.Center;
      }
      catch
      {
        this.pictureBox_NewItem_ItemPreview.BackgroundImage = (Image) Resources.ResourceManager.GetObject("no_img");
      }
    }

    public void PopulateItemIndex(ListBox ItemIndex, ListBox ItemGroup)
    {
      this.DontWork = true;
      switch (ItemGroup.SelectedIndex)
      {
        case 0:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Swords;
          break;
        case 1:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Axes;
          break;
        case 2:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_MacesScepters;
          break;
        case 3:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Spears;
          break;
        case 4:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_BowsCrossBows;
          break;
        case 5:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Staffs;
          break;
        case 6:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Shields;
          break;
        case 7:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Helms;
          break;
        case 8:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Armors;
          break;
        case 9:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Pants;
          break;
        case 10:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Gloves;
          break;
        case 11:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Boots;
          break;
        case 12:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_WingsSkillsSeedsOthers;
          break;
        case 13:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Others1;
          break;
        case 14:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Others2;
          break;
        case 15:
          ItemIndex.DisplayMember = "Name";
          ItemIndex.ValueMember = "Index";
          ItemIndex.DataSource = (object) this.L_Scrolls;
          break;
      }
      this.DontWork = false;
    }

    private void radioButton_ExcArmor_CheckedChanged(object sender, EventArgs e)
    {
      this.checkBox_NewItem_ExcOpt1.Text = "Zen Drop +30%";
      this.checkBox_NewItem_ExcOpt2.Text = "Def Success Rate +10%";
      this.checkBox_NewItem_ExcOpt3.Text = "Reflect +5%";
      this.checkBox_NewItem_ExcOpt4.Text = "Damage Decrease +4%";
      this.checkBox_NewItem_ExcOpt5.Text = "Mana +4%";
      this.checkBox_NewItem_ExcOpt6.Text = "HP +4%";
    }

    private void radioButton_ExcWeapon_CheckedChanged(object sender, EventArgs e)
    {
      this.checkBox_NewItem_ExcOpt1.Text = "Mob Kill +mana/8";
      this.checkBox_NewItem_ExcOpt2.Text = "Mob Kill +life/8";
      this.checkBox_NewItem_ExcOpt3.Text = "Attack(Wizardy) Speed +7";
      this.checkBox_NewItem_ExcOpt4.Text = "Damage +2%";
      this.checkBox_NewItem_ExcOpt5.Text = "Damage +level/20";
      this.checkBox_NewItem_ExcOpt6.Text = "Exc Damage Rate +10%";
    }

    private void radioButton_ExcWings_CheckedChanged(object sender, EventArgs e)
    {
      this.checkBox_NewItem_ExcOpt1.Text = "Ignor Def +5% / HP +125";
      this.checkBox_NewItem_ExcOpt2.Text = "Return Attack +5% / Mana +125";
      this.checkBox_NewItem_ExcOpt3.Text = "Life Recovery +5% /Ignor Def +3%";
      this.checkBox_NewItem_ExcOpt4.Text = "Mana Recovery +5% / AG +50";
      this.checkBox_NewItem_ExcOpt5.Text = "--- / Attack(Wiz) Speed+5";
      this.checkBox_NewItem_ExcOpt6.Text = "---";
    }

    private void radioButton_Multi_ExcArmor_CheckedChanged(object sender, EventArgs e)
    {
      string[] strArray = ((Control) sender).Name.Split('_');
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption1_Multi_" + strArray[strArray.Length - 1]].Text = "Zen Drop +30%";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption2_Multi_" + strArray[strArray.Length - 1]].Text = "Def Success Rate +10%";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption3_Multi_" + strArray[strArray.Length - 1]].Text = "Reflect +5%";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption4_Multi_" + strArray[strArray.Length - 1]].Text = "Damage Decrease +4%";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption5_Multi_" + strArray[strArray.Length - 1]].Text = "Mana +4%";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption6_Multi_" + strArray[strArray.Length - 1]].Text = "HP +4%";
    }

    private void radioButton_Multi_ExcWeapon_CheckedChanged(object sender, EventArgs e)
    {
      string[] strArray = ((Control) sender).Name.Split('_');
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption1_Multi_" + strArray[strArray.Length - 1]].Text = "Mob Kill +mana/8";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption2_Multi_" + strArray[strArray.Length - 1]].Text = "Mob Kill +life/8";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption3_Multi_" + strArray[strArray.Length - 1]].Text = "Attack(Wizardy) Speed +7";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption4_Multi_" + strArray[strArray.Length - 1]].Text = "Damage +2%";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption5_Multi_" + strArray[strArray.Length - 1]].Text = "Damage +level/20";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption6_Multi_" + strArray[strArray.Length - 1]].Text = "Exc Damage Rate +10%";
    }

    private void radioButton_Multi_ExcWings_CheckedChanged(object sender, EventArgs e)
    {
      string[] strArray = ((Control) sender).Name.Split('_');
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption1_Multi_" + strArray[strArray.Length - 1]].Text = "Ignor Def +5% / HP +125";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption2_Multi_" + strArray[strArray.Length - 1]].Text = "Return Attack +5% / Mana +125";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption3_Multi_" + strArray[strArray.Length - 1]].Text = "Life Recovery +5% /Ignor Def +3%";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption4_Multi_" + strArray[strArray.Length - 1]].Text = "Mana Recovery +5% / AG +50";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption5_Multi_" + strArray[strArray.Length - 1]].Text = "--- / Attack(Wiz) Speed+5";
      this.tabControl1.Controls["tabPage_MultiOption_" + strArray[strArray.Length - 1]].Controls["groupBox_" + strArray[strArray.Length - 1]].Controls["checkBox_ExcOption6_Multi_" + strArray[strArray.Length - 1]].Text = "---";
    }

    public void Setc_AncientData(ref ComboBox cb, ref List<Structures.c_AncientData> list)
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
      cb.DataSource = (object) list;
      cb.ValueMember = "ID";
      cb.DisplayMember = "Name";
    }

    public void Setc_LevelData(ref ListBox lb)
    {
      this.c_LevelDatas.Add(new Structures.c_LevelData(0, "+0"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(1, "+1"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(2, "+2"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(3, "+3"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(4, "+4"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(5, "+5"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(6, "+6"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(7, "+7"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(8, "+8"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(9, "+9"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(10, "+10"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(11, "+11"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(12, "+12"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(13, "+13"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(14, "+14"));
      this.c_LevelDatas.Add(new Structures.c_LevelData(15, "+15"));
      lb.DataSource = (object) this.c_LevelDatas;
      lb.ValueMember = "ID";
      lb.DisplayMember = "Name";
    }

    public void Setc_LevelData(ref ListBox lb, ref List<Structures.c_LevelData> c_LevelDatas)
    {
      c_LevelDatas.Add(new Structures.c_LevelData(0, "+0"));
      c_LevelDatas.Add(new Structures.c_LevelData(1, "+1"));
      c_LevelDatas.Add(new Structures.c_LevelData(2, "+2"));
      c_LevelDatas.Add(new Structures.c_LevelData(3, "+3"));
      c_LevelDatas.Add(new Structures.c_LevelData(4, "+4"));
      c_LevelDatas.Add(new Structures.c_LevelData(5, "+5"));
      c_LevelDatas.Add(new Structures.c_LevelData(6, "+6"));
      c_LevelDatas.Add(new Structures.c_LevelData(7, "+7"));
      c_LevelDatas.Add(new Structures.c_LevelData(8, "+8"));
      c_LevelDatas.Add(new Structures.c_LevelData(9, "+9"));
      c_LevelDatas.Add(new Structures.c_LevelData(10, "+10"));
      c_LevelDatas.Add(new Structures.c_LevelData(11, "+11"));
      c_LevelDatas.Add(new Structures.c_LevelData(12, "+12"));
      c_LevelDatas.Add(new Structures.c_LevelData(13, "+13"));
      c_LevelDatas.Add(new Structures.c_LevelData(14, "+14"));
      c_LevelDatas.Add(new Structures.c_LevelData(15, "+15"));
      lb.DataSource = (object) c_LevelDatas;
      lb.ValueMember = "ID";
      lb.DisplayMember = "Name";
    }

    public void Setc_OptionData(ref ListBox lb)
    {
      Structures.c_OptionData cOptionData = new Structures.c_OptionData()
      {
        ID = 0,
        Name = "+0"
      };
      this.c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 1;
      cOptionData.Name = "+4";
      this.c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 2;
      cOptionData.Name = "+8";
      this.c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 3;
      cOptionData.Name = "+12";
      this.c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 4;
      cOptionData.Name = "+16";
      this.c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 5;
      cOptionData.Name = "+20";
      this.c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 6;
      cOptionData.Name = "+24";
      this.c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 7;
      cOptionData.Name = "+28";
      this.c_OptionDatas.Add(cOptionData);
      lb.DataSource = (object) this.c_OptionDatas;
      lb.DisplayMember = "Name";
      lb.ValueMember = "ID";
    }

    public void Setc_OptionData(ref ListBox lb, ref List<Structures.c_OptionData> c_OptionDatas)
    {
      Structures.c_OptionData cOptionData = new Structures.c_OptionData()
      {
        ID = 0,
        Name = "+0"
      };
      c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 1;
      cOptionData.Name = "+4";
      c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 2;
      cOptionData.Name = "+8";
      c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 3;
      cOptionData.Name = "+12";
      c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 4;
      cOptionData.Name = "+16";
      c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 5;
      cOptionData.Name = "+20";
      c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 6;
      cOptionData.Name = "+24";
      c_OptionDatas.Add(cOptionData);
      cOptionData.ID = 7;
      cOptionData.Name = "+28";
      c_OptionDatas.Add(cOptionData);
      lb.DataSource = (object) c_OptionDatas;
      lb.DisplayMember = "Name";
      lb.ValueMember = "ID";
    }

    public void UpdateAddedItem()
    {
      BindingList<Structures.IGCCashItemList> selectedIList = this.frm_Parent.Selected_iList;
      BindingList<Structures.IGCCashItemInfo> selectedIInfo = this.frm_Parent.Selected_iInfo;
      BindingList<Structures.IGCCashItemPackages> selectedIPack = this.frm_Parent.Selected_iPack;
      Structures.IBSPackage selectedIPackage = this.frm_Parent.Selected_iPackage;
      BindingList<Structures.IBSProduct> selectedIProduct = this.frm_Parent.Selected_iProduct;
      this.checkBox_PackageItem.Enabled = true;
      this.checkBox_MultiItem.Enabled = true;
      this.groupBox_ItemProperties.Enabled = true;
      this.textBox_NewItem_Name.Text = selectedIPackage.Name;
      this.numericUpDown_NewItem_Price.Value = (Decimal) selectedIList[0].iPrice;
      this.comboBox_NewItem_Coin.SelectedIndex = selectedIList[0].cType;
      this.richTextBox_NewItem_Info.Text = selectedIPackage.Info.Replace("#", "\n");
      if (selectedIInfo.Count > 0)
      {
        this.numericUpDown_NewItem_Count.Value = (Decimal) (selectedIInfo[0].Period > 0 ? selectedIInfo[0].Period : 1);
        this.comboBox_NewItem_CountType.SelectedIndex = selectedIInfo[0].Type;
        this.listBox_NewItem_ItemLevel.SelectedValue = (object) selectedIInfo[0].Level;
        this.listBox_NewItem_ItemOption.SelectedValue = (object) selectedIInfo[0].Option;
        this.comboBox_Ancient.SelectedIndex = selectedIInfo[0].Ancient == 5 ? 1 : (selectedIInfo[0].Ancient == 10 ? 2 : 0);
        this.checkBox_NewItem_Skill.Checked = Convert.ToBoolean(selectedIInfo[0].Skill);
        this.checkBox_NewItem_Luck.Checked = Convert.ToBoolean(selectedIInfo[0].Luck);
        this.numericUpDown_NewItem_SocketCount.Value = (Decimal) selectedIInfo[0].Socket;
        this.numericUpDown_NewItem_Durability.Value = (Decimal) selectedIInfo[0].Dur;
        this.checkBox_NewItem_ExcOpt1.Checked = Convert.ToBoolean(selectedIInfo[0].Exc & 1);
        this.checkBox_NewItem_ExcOpt2.Checked = Convert.ToBoolean(selectedIInfo[0].Exc >> 1 & 1);
        this.checkBox_NewItem_ExcOpt3.Checked = Convert.ToBoolean(selectedIInfo[0].Exc >> 2 & 1);
        this.checkBox_NewItem_ExcOpt4.Checked = Convert.ToBoolean(selectedIInfo[0].Exc >> 3 & 1);
        this.checkBox_NewItem_ExcOpt5.Checked = Convert.ToBoolean(selectedIInfo[0].Exc >> 4 & 1);
        this.checkBox_NewItem_ExcOpt6.Checked = Convert.ToBoolean(selectedIInfo[0].Exc >> 5 & 1);
      }
      if (selectedIList[0].pID > 0)
      {
        this.PackageItems.Clear();
        this.checkBox_PackageItem.Checked = true;
        foreach (Structures.IGCCashItemPackages cashItemPackages in (Collection<Structures.IGCCashItemPackages>) selectedIPack)
        {
          for (int index = 0; index < this.frm_Parent.ItemsInfo.Count; ++index)
          {
            if (this.frm_Parent.ItemsInfo[index].GID == cashItemPackages.iGUID && this.frm_Parent.ItemsInfo[index].ID == cashItemPackages.iID)
            {
              this.PackageItems.Add(this.frm_Parent.ItemsInfo[index]);
              break;
            }
          }
        }
      }
      else
      {
        this.PackageItems.Clear();
        this.checkBox_PackageItem.Checked = false;
      }
      if (selectedIPackage.CheckBoxCount > (short) 1)
      {
        this.checkBox_MultiItem.Checked = true;
        for (int index = 1; index <= (int) selectedIPackage.CheckBoxCount && index < 7; ++index)
        {
          CheckBox control1 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_isMulti_" + (object) index];
          TextBox control2 = (TextBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["textBox_Name_Multi_" + (object) index];
          NumericUpDown control3 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Count_Multi_" + (object) index];
          NumericUpDown control4 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Price_Multi_" + (object) index];
          ListBox control5 = (ListBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["listBox_Level_Multi_" + (object) index];
          ListBox control6 = (ListBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["listBox_Option_Multi_" + (object) index];
          ComboBox control7 = (ComboBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["comboBox_Ancient_Multi_" + (object) index];
          CheckBox control8 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption1_Multi_" + (object) index];
          CheckBox control9 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption2_Multi_" + (object) index];
          CheckBox control10 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption3_Multi_" + (object) index];
          CheckBox control11 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption4_Multi_" + (object) index];
          CheckBox control12 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption5_Multi_" + (object) index];
          CheckBox control13 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["groupBox_" + (object) index].Controls["checkBox_ExcOption6_Multi_" + (object) index];
          NumericUpDown control14 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Sockets_Multi_" + (object) index];
          NumericUpDown control15 = (NumericUpDown) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["numericUpDown_Durability_Multi_" + (object) index];
          CheckBox control16 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_Luck_Multi_" + (object) index];
          CheckBox control17 = (CheckBox) this.tabControl1.Controls["tabPage_MultiOption_" + (object) index].Controls["checkBox_Skill_Multi_" + (object) index];
          control1.Checked = true;
          Structures.IGCCashItemInfo igcCashItemInfo = selectedIInfo[index - 1];
          control2.Text = igcCashItemInfo.Name;
          control3.Value = (Decimal) (selectedIInfo[index - 1].Period > 0 ? selectedIInfo[index - 1].Period : 1);
          control4.Value = (Decimal) selectedIList[index - 1].iPrice;
          control5.SelectedValue = (object) selectedIInfo[index - 1].Level;
          control6.SelectedValue = (object) selectedIInfo[index - 1].Option;
          control7.SelectedValue = (object) selectedIInfo[index - 1].Ancient;
          control8.Checked = Convert.ToBoolean(selectedIInfo[index - 1].Exc & 1);
          control9.Checked = Convert.ToBoolean(selectedIInfo[index - 1].Exc >> 1 & 1);
          control10.Checked = Convert.ToBoolean(selectedIInfo[index - 1].Exc >> 2 & 1);
          control11.Checked = Convert.ToBoolean(selectedIInfo[index - 1].Exc >> 3 & 1);
          control12.Checked = Convert.ToBoolean(selectedIInfo[index - 1].Exc >> 4 & 1);
          control13.Checked = Convert.ToBoolean(selectedIInfo[index - 1].Exc >> 5 & 1);
          control14.Value = (Decimal) selectedIInfo[index - 1].Socket;
          control15.Value = (Decimal) selectedIInfo[index - 1].Dur;
          control16.Checked = Convert.ToBoolean(selectedIInfo[index - 1].Luck);
          control17.Checked = Convert.ToBoolean(selectedIInfo[index - 1].Skill);
        }
      }
      else
      {
        this.checkBox_MultiItem.Checked = false;
        this.buttonClearAll_Multi.PerformClick();
      }
      int num1 = selectedIPackage.ItemID / 512;
      int num2 = selectedIPackage.ItemID - num1 * 512;
      this.listBox_NewItem_ItemGroup.SelectedValue = (object) num1;
      this.listBox_NewItem_ItemIndex.SelectedValue = (object) num2;
      this.isItemSelected = true;
    }
  }
}
