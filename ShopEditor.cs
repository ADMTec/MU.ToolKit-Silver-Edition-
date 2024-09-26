// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.ShopEditor
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MU_ToolKit
{
  public class ShopEditor : Form
  {
    private Button button_Add;
    private Button button_Update;
    private List<Structures.c_LevelData> c_LevelDatas = new List<Structures.c_LevelData>();
    private List<Structures.c_OptionData> c_OptionDatas = new List<Structures.c_OptionData>();
    private CheckBox checkBox_DurLock;
    public CheckBox checkBox_ExcOpt1;
    public CheckBox checkBox_ExcOpt2;
    public CheckBox checkBox_ExcOpt3;
    public CheckBox checkBox_ExcOpt4;
    public CheckBox checkBox_ExcOpt5;
    public CheckBox checkBox_ExcOpt6;
    private CheckBox checkBox_FO;
    private CheckBox checkBox_Luck;
    private CheckBox checkBox_Skill;
    private IContainer components;
    private bool DontWork;
    private ToolStripMenuItem fileToolStripMenuItem;
    private GroupBox groupBox_NewItem_ExcOpt;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox5;
    private int isEx700ItemList;
    private string[,] ItemName = new string[16, 513];
    private string[,] ItemSize = new string[16, 513];
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
    private Label label_Size;
    private int LastSelectedItemIndex;
    private Structures.CustomPictureBox LastSelectetItem = new Structures.CustomPictureBox();
    private ListBox listBox_Group;
    private ListBox listBox_Index;
    private ListBox listBox_Level;
    private ListBox listBox_Option;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem newToolStripMenuItem;
    private NumericUpDown numericUpDown_Durability;
    private bool[,] OccupiedBoxes = new bool[16, 9];
    private int OldDurValue;
    private ToolStripMenuItem openToolStripMenuItem;
    private PictureBox pictureBox_Init_1x1;
    private PictureBox pictureBox_ItemPreview;
    private PictureBox pictureBox_ShopPreview;
    private RadioButton radioButton_Ancient_Level1;
    private RadioButton radioButton_Ancient_Level2;
    private RadioButton radioButton_Ancient_None;
    private RadioButton radioButton_ExcArmor;
    private RadioButton radioButton_ExcWeapon;
    private RadioButton radioButton_ExcWings;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private Structures.ShopItem SelectedSI = new Structures.ShopItem();
    private Structures.ShopItem[,] ShopItems = new Structures.ShopItem[16, 9];
    private Structures strct = new Structures();

    public ShopEditor() => this.InitializeComponent();

    private bool AddItemPicture(string toolTip, ref string uniqName, ref Structures.ShopItem sI)
    {
      Structures.UniItem selectedItem = (Structures.UniItem) this.listBox_Index.SelectedItem;
      int acceptedX = 0;
      int acceptedY = 0;
      if (!this.GetFirstFreeBox(selectedItem.X, selectedItem.Y, ref acceptedX, ref acceptedY))
        return false;
      Structures.CustomPictureBox customPictureBox = new Structures.CustomPictureBox();
      new Structures.CustomToolTip()
      {
        sizeX = 350,
        sizeY = 210
      }.SetToolTip((Control) customPictureBox, toolTip);
      customPictureBox.Size = new Size(selectedItem.X * 27, selectedItem.Y * 27);
      PictureBox control = (PictureBox) this.pictureBox_ShopPreview.Controls["pictureBox_" + (object) acceptedY + "x" + (object) acceptedX];
      customPictureBox.Location = new Point(control.Location.X, control.Location.Y);
      customPictureBox.BackColor = Color.Transparent;
      customPictureBox.Parent = (Control) this.pictureBox_ShopPreview;
      customPictureBox.Name = "pictureBox_Item_" + (object) acceptedY + "x" + (object) acceptedX + "_" + (object) selectedItem.Y + "x" + (object) selectedItem.X;
      uniqName = "Item_" + (object) acceptedY + "x" + (object) acceptedX + "_" + (object) selectedItem.Y + "x" + (object) selectedItem.X;
      sI.ShopLocX = acceptedX;
      sI.ShopLocY = acceptedY;
      try
      {
        customPictureBox.BackgroundImage = (Image) Resources.ResourceManager.GetObject("_" + (object) selectedItem.Group + (object) selectedItem.Index);
        if (customPictureBox.BackgroundImage.Size.Width > customPictureBox.Size.Width || customPictureBox.BackgroundImage.Size.Height > customPictureBox.Size.Height)
          customPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
        else
          customPictureBox.BackgroundImageLayout = ImageLayout.Center;
      }
      catch
      {
        customPictureBox.BackgroundImage = (Image) Resources.ResourceManager.GetObject("no_img");
      }
      customPictureBox.MouseClick += new MouseEventHandler(this.pb_MouseClick);
      customPictureBox.BorderColor = Color.Gold;
      this.LastSelectetItem.BorderColor = Color.Transparent;
      this.LastSelectetItem = customPictureBox;
      this.pictureBox_ShopPreview.Controls.Add((Control) customPictureBox);
      customPictureBox.BringToFront();
      this.pictureBox_ShopPreview.Invalidate();
      this.ChangeOccupid(acceptedX, acceptedY, selectedItem.X, selectedItem.Y, true);
      this.button_Update.Enabled = true;
      return true;
    }

    private bool AddItemPicture(
      string toolTip,
      ref string uniqName,
      Structures.UniItem uniqItm,
      ref Structures.ShopItem sI)
    {
      Structures.UniItem uniItem = uniqItm;
      int acceptedX = 0;
      int acceptedY = 0;
      if (!this.GetFirstFreeBox(uniItem.X, uniItem.Y, ref acceptedX, ref acceptedY))
        return false;
      Structures.CustomPictureBox customPictureBox = new Structures.CustomPictureBox();
      new Structures.CustomToolTip()
      {
        sizeX = 350,
        sizeY = 210
      }.SetToolTip((Control) customPictureBox, toolTip);
      customPictureBox.Size = new Size(uniItem.X * 27, uniItem.Y * 27);
      PictureBox control = (PictureBox) this.pictureBox_ShopPreview.Controls["pictureBox_" + (object) acceptedY + "x" + (object) acceptedX];
      customPictureBox.Location = new Point(control.Location.X, control.Location.Y);
      customPictureBox.BackColor = Color.Transparent;
      customPictureBox.Parent = (Control) this.pictureBox_ShopPreview;
      customPictureBox.Name = "pictureBox_Item_" + (object) acceptedY + "x" + (object) acceptedX + "_" + (object) uniItem.Y + "x" + (object) uniItem.X;
      uniqName = "Item_" + (object) acceptedY + "x" + (object) acceptedX + "_" + (object) uniItem.Y + "x" + (object) uniItem.X;
      sI.ShopLocX = acceptedX;
      sI.ShopLocY = acceptedY;
      try
      {
        customPictureBox.BackgroundImage = (Image) Resources.ResourceManager.GetObject("_" + (object) uniItem.Group + (object) uniItem.Index);
        if (customPictureBox.BackgroundImage.Size.Width > customPictureBox.Size.Width || customPictureBox.BackgroundImage.Size.Height > customPictureBox.Size.Height)
          customPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
        else
          customPictureBox.BackgroundImageLayout = ImageLayout.Center;
      }
      catch
      {
        customPictureBox.BackgroundImage = (Image) Resources.ResourceManager.GetObject("no_img");
      }
      customPictureBox.MouseClick += new MouseEventHandler(this.pb_MouseClick);
      customPictureBox.BorderColor = Color.Gold;
      this.LastSelectetItem.BorderColor = Color.Transparent;
      this.LastSelectetItem = customPictureBox;
      this.pictureBox_ShopPreview.Controls.Add((Control) customPictureBox);
      customPictureBox.BringToFront();
      this.pictureBox_ShopPreview.Invalidate();
      this.ChangeOccupid(acceptedX, acceptedY, uniItem.X, uniItem.Y, true);
      this.button_Update.Enabled = true;
      return true;
    }

    private void AddPreviewBoxes(int x, int y)
    {
      int y1 = 19;
      for (int index1 = 1; index1 <= y; ++index1)
      {
        int x1 = 17;
        for (int index2 = 1; index2 <= x; ++index2)
        {
          PictureBox pictureBox1 = new PictureBox();
          pictureBox1.Name = "pictureBox_" + (object) index1 + nameof (x) + (object) index2;
          pictureBox1.Location = new Point(x1, y1);
          pictureBox1.Size = new Size(27, 27);
          pictureBox1.BackgroundImage = (Image) Resources.Untitled_3;
          PictureBox pictureBox2 = pictureBox1;
          this.pictureBox_ShopPreview.Controls.Add((Control) pictureBox2);
          pictureBox2.Invalidate();
          x1 += 26;
        }
        y1 += 26;
      }
      this.pictureBox_ShopPreview.Visible = true;
      this.pictureBox_ShopPreview.Invalidate();
    }

    private void button_Add_Click(object sender, EventArgs e)
    {
      string empty = string.Empty;
      Structures.ShopItem sI = new Structures.ShopItem()
      {
        Group = Convert.ToInt32(this.listBox_Group.SelectedValue),
        Index = Convert.ToInt32(this.listBox_Index.SelectedValue),
        Level = Convert.ToByte(this.listBox_Level.SelectedValue),
        Option = Convert.ToByte(this.listBox_Option.SelectedValue),
        Skill = this.checkBox_Skill.Checked,
        Luck = this.checkBox_Luck.Checked,
        Durablity = Convert.ToByte(this.numericUpDown_Durability.Value),
        Ancient = this.radioButton_Ancient_Level1.Checked ? Convert.ToByte(5) : (this.radioButton_Ancient_Level2.Checked ? Convert.ToByte(10) : Convert.ToByte(0)),
        Excellent = this.GetExcVal()
      };
      string toolTip = string.Empty + (sI.Excellent > (byte) 0 ? "Excellent " : "") + (sI.Ancient > (byte) 0 ? "Ancient " : "") + this.listBox_Index.Text + "+" + (object) sI.Level + this.listBox_Option.Text + (sI.Skill ? "+Skill" : "") + (sI.Luck ? (object) "+Luck" : (object) "") + "\n\nDurability: " + (object) sI.Durablity + (sI.Ancient > (byte) 0 ? (sI.Ancient == (byte) 5 ? "\n\nAncinet: Level 1" : (sI.Ancient == (byte) 10 ? "\n\nAncinet: Level 2" : "")) : "");
      if (sI.Excellent > (byte) 0)
        toolTip = toolTip + "\n\nExcellent Options:\n" + (this.checkBox_ExcOpt1.Checked ? this.checkBox_ExcOpt1.Text + "\n" : "") + (this.checkBox_ExcOpt2.Checked ? this.checkBox_ExcOpt2.Text + "\n" : "") + (this.checkBox_ExcOpt3.Checked ? this.checkBox_ExcOpt3.Text + "\n" : "") + (this.checkBox_ExcOpt4.Checked ? this.checkBox_ExcOpt4.Text + "\n" : "") + (this.checkBox_ExcOpt5.Checked ? this.checkBox_ExcOpt5.Text + "\n" : "") + (this.checkBox_ExcOpt6.Checked ? this.checkBox_ExcOpt6.Text : "");
      if (!this.AddItemPicture(toolTip, ref empty, ref sI))
        return;
      sI.UniqName = empty;
      this.SelectedSI = sI;
      this.ShopItems[sI.ShopLocY, sI.ShopLocX] = sI;
    }

    private void button_Update_Click(object sender, EventArgs e)
    {
      Structures.ShopItem shopItem = new Structures.ShopItem();
      Structures.ShopItem selectedSi = this.SelectedSI with
      {
        Level = Convert.ToByte(this.listBox_Level.SelectedValue),
        Option = Convert.ToByte(this.listBox_Option.SelectedValue),
        Skill = this.checkBox_Skill.Checked,
        Luck = this.checkBox_Luck.Checked,
        Durablity = Convert.ToByte(this.numericUpDown_Durability.Value),
        Ancient = this.radioButton_Ancient_Level1.Checked ? Convert.ToByte(5) : (this.radioButton_Ancient_Level2.Checked ? Convert.ToByte(10) : Convert.ToByte(0)),
        Excellent = this.GetExcVal()
      };
      string caption = string.Empty + (selectedSi.Excellent > (byte) 0 ? "Excellent " : "") + (selectedSi.Ancient > (byte) 0 ? "Ancient " : "") + this.listBox_Index.Text + "+" + (object) selectedSi.Level + this.listBox_Option.Text + (selectedSi.Skill ? "+Skill" : "") + (selectedSi.Luck ? (object) "+Luck" : (object) "") + "\n\nDurability: " + (object) selectedSi.Durablity + (selectedSi.Ancient > (byte) 0 ? (selectedSi.Ancient == (byte) 5 ? "\n\nAncinet: Level 1" : (selectedSi.Ancient == (byte) 10 ? "\n\nAncinet: Level 2" : "")) : "");
      if (selectedSi.Excellent > (byte) 0)
        caption = caption + "\n\nExcellent Options:\n" + (this.checkBox_ExcOpt1.Checked ? this.checkBox_ExcOpt1.Text + "\n" : "") + (this.checkBox_ExcOpt2.Checked ? this.checkBox_ExcOpt2.Text + "\n" : "") + (this.checkBox_ExcOpt3.Checked ? this.checkBox_ExcOpt3.Text + "\n" : "") + (this.checkBox_ExcOpt4.Checked ? this.checkBox_ExcOpt4.Text + "\n" : "") + (this.checkBox_ExcOpt5.Checked ? this.checkBox_ExcOpt5.Text + "\n" : "") + (this.checkBox_ExcOpt6.Checked ? this.checkBox_ExcOpt6.Text : "");
      this.LastSelectetItem.Controls.Clear();
      new Structures.CustomToolTip()
      {
        sizeX = 350,
        sizeY = 210
      }.SetToolTip((Control) this.LastSelectetItem, caption);
      this.ShopItems[this.SelectedSI.ShopLocY, this.SelectedSI.ShopLocX] = selectedSi;
    }

    private void ChangeOccupid(int startX, int startY, int LengthX, int LengthY, bool state)
    {
      for (int index1 = 0; index1 < LengthY; ++index1)
      {
        for (int index2 = 0; index2 < LengthX; ++index2)
          this.OccupiedBoxes[index1 + startY, index2 + startX] = state;
      }
    }

    private void checkBox_FO_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.checkBox_FO.Checked)
        return;
      this.checkBox_ExcOpt1.Checked = true;
      this.checkBox_ExcOpt2.Checked = true;
      this.checkBox_ExcOpt3.Checked = true;
      this.checkBox_ExcOpt4.Checked = true;
      this.checkBox_ExcOpt5.Checked = true;
      this.checkBox_ExcOpt6.Checked = true;
      this.listBox_Level.SelectedIndex = 15;
      this.listBox_Option.SelectedValue = (object) 7;
      this.checkBox_Luck.Checked = true;
      this.checkBox_FO.Checked = false;
    }

    private void ClearShopItemsPreview()
    {
      List<string> stringList = new List<string>();
      foreach (Control control in (ArrangedElementCollection) this.pictureBox_ShopPreview.Controls)
      {
        if (control.Name.StartsWith("pictureBox_Item_"))
          stringList.Add(control.Name);
      }
      foreach (string key in stringList)
        this.pictureBox_ShopPreview.Controls.RemoveByKey(key);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private byte GetExcVal()
    {
      int num1 = 0;
      int num2 = this.checkBox_ExcOpt1.Checked ? num1 + 1 : num1;
      int num3 = this.checkBox_ExcOpt2.Checked ? num2 + 2 : num2;
      int num4 = this.checkBox_ExcOpt3.Checked ? num3 + 4 : num3;
      int num5 = this.checkBox_ExcOpt4.Checked ? num4 + 8 : num4;
      int num6 = this.checkBox_ExcOpt5.Checked ? num5 + 16 : num5;
      return Convert.ToByte(this.checkBox_ExcOpt6.Checked ? num6 + 32 : num6);
    }

    private bool GetFirstFreeBox(int neededX, int neededY, ref int acceptedX, ref int acceptedY)
    {
      for (int index1 = 1; index1 <= 15; ++index1)
      {
        for (int index2 = 1; index2 <= 8; ++index2)
        {
          if (!this.OccupiedBoxes[index1, index2])
          {
            bool flag = false;
            for (int index3 = 0; index3 < neededY; ++index3)
            {
              for (int index4 = 0; index4 < neededX; ++index4)
              {
                if (!flag)
                {
                  if (index1 + index3 <= 15 & index2 + index4 <= 8)
                  {
                    if (this.OccupiedBoxes[index1 + index3, index2 + index4])
                      flag = true;
                  }
                  else
                    flag = true;
                }
              }
            }
            if (!flag)
            {
              acceptedX = index2;
              acceptedY = index1;
              return true;
            }
          }
        }
      }
      return false;
    }

    private void InitializeComponent()
    {
      this.pictureBox_Init_1x1 = new PictureBox();
      this.pictureBox_ShopPreview = new PictureBox();
      this.listBox_Group = new ListBox();
      this.listBox_Index = new ListBox();
      this.listBox_Level = new ListBox();
      this.listBox_Option = new ListBox();
      this.groupBox1 = new GroupBox();
      this.groupBox2 = new GroupBox();
      this.groupBox3 = new GroupBox();
      this.checkBox_DurLock = new CheckBox();
      this.numericUpDown_Durability = new NumericUpDown();
      this.checkBox_Luck = new CheckBox();
      this.checkBox_Skill = new CheckBox();
      this.groupBox5 = new GroupBox();
      this.radioButton_Ancient_Level2 = new RadioButton();
      this.radioButton_Ancient_Level1 = new RadioButton();
      this.radioButton_Ancient_None = new RadioButton();
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.newToolStripMenuItem = new ToolStripMenuItem();
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new ToolStripMenuItem();
      this.pictureBox_ItemPreview = new PictureBox();
      this.button_Add = new Button();
      this.groupBox_NewItem_ExcOpt = new GroupBox();
      this.radioButton_ExcWings = new RadioButton();
      this.radioButton_ExcArmor = new RadioButton();
      this.radioButton_ExcWeapon = new RadioButton();
      this.checkBox_ExcOpt6 = new CheckBox();
      this.checkBox_ExcOpt5 = new CheckBox();
      this.checkBox_ExcOpt4 = new CheckBox();
      this.checkBox_ExcOpt3 = new CheckBox();
      this.checkBox_ExcOpt2 = new CheckBox();
      this.checkBox_ExcOpt1 = new CheckBox();
      this.label_Size = new Label();
      this.button_Update = new Button();
      this.checkBox_FO = new CheckBox();
      this.label_FileName = new Label();
      ((ISupportInitialize) this.pictureBox_Init_1x1).BeginInit();
      ((ISupportInitialize) this.pictureBox_ShopPreview).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.numericUpDown_Durability.BeginInit();
      this.groupBox5.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox_ItemPreview).BeginInit();
      this.groupBox_NewItem_ExcOpt.SuspendLayout();
      this.SuspendLayout();
      this.pictureBox_Init_1x1.BackColor = Color.Transparent;
      this.pictureBox_Init_1x1.BackgroundImage = (Image) Resources.Untitled_3;
      this.pictureBox_Init_1x1.Enabled = false;
      this.pictureBox_Init_1x1.Location = new Point(412, 49);
      this.pictureBox_Init_1x1.Name = "pictureBox_Init_1x1";
      this.pictureBox_Init_1x1.Size = new Size(27, 25);
      this.pictureBox_Init_1x1.TabIndex = 1;
      this.pictureBox_Init_1x1.TabStop = false;
      this.pictureBox_Init_1x1.Visible = false;
      this.pictureBox_ShopPreview.BackgroundImage = (Image) Resources.Untitled_2;
      this.pictureBox_ShopPreview.ErrorImage = (Image) null;
      this.pictureBox_ShopPreview.Image = (Image) Resources.Untitled_21;
      this.pictureBox_ShopPreview.Location = new Point(395, 31);
      this.pictureBox_ShopPreview.Name = "pictureBox_ShopPreview";
      this.pictureBox_ShopPreview.Size = new Size(244, 392);
      this.pictureBox_ShopPreview.TabIndex = 0;
      this.pictureBox_ShopPreview.TabStop = false;
      this.pictureBox_ShopPreview.Visible = false;
      this.listBox_Group.FormattingEnabled = true;
      this.listBox_Group.ItemHeight = 12;
      this.listBox_Group.Location = new Point(12, 31);
      this.listBox_Group.Name = "listBox_Group";
      this.listBox_Group.Size = new Size(158, 136);
      this.listBox_Group.TabIndex = 0;
      this.listBox_Group.SelectedIndexChanged += new EventHandler(this.listBox_Group_SelectedIndexChanged);
      this.listBox_Index.FormattingEnabled = true;
      this.listBox_Index.ItemHeight = 12;
      this.listBox_Index.Location = new Point(176, 31);
      this.listBox_Index.Name = "listBox_Index";
      this.listBox_Index.Size = new Size(213, 136);
      this.listBox_Index.TabIndex = 1;
      this.listBox_Index.SelectedIndexChanged += new EventHandler(this.listBox_Index_SelectedIndexChanged);
      this.listBox_Level.FormattingEnabled = true;
      this.listBox_Level.ItemHeight = 12;
      this.listBox_Level.Location = new Point(7, 14);
      this.listBox_Level.Name = "listBox_Level";
      this.listBox_Level.Size = new Size(41, 196);
      this.listBox_Level.TabIndex = 2;
      this.listBox_Option.FormattingEnabled = true;
      this.listBox_Option.ItemHeight = 12;
      this.listBox_Option.Location = new Point(5, 14);
      this.listBox_Option.Name = "listBox_Option";
      this.listBox_Option.Size = new Size(44, 100);
      this.listBox_Option.TabIndex = 3;
      this.groupBox1.Controls.Add((Control) this.listBox_Level);
      this.groupBox1.Location = new Point(12, 173);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(55, 215);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Level";
      this.groupBox2.Controls.Add((Control) this.listBox_Option);
      this.groupBox2.Location = new Point(73, 173);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(54, 120);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Option";
      this.groupBox3.Controls.Add((Control) this.checkBox_DurLock);
      this.groupBox3.Controls.Add((Control) this.numericUpDown_Durability);
      this.groupBox3.Location = new Point(73, 297);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(106, 42);
      this.groupBox3.TabIndex = 8;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Durability";
      this.checkBox_DurLock.AutoSize = true;
      this.checkBox_DurLock.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_DurLock.Location = new Point(54, 19);
      this.checkBox_DurLock.Name = "checkBox_DurLock";
      this.checkBox_DurLock.Size = new Size(50, 17);
      this.checkBox_DurLock.TabIndex = 5;
      this.checkBox_DurLock.Text = "Lock";
      this.checkBox_DurLock.UseVisualStyleBackColor = true;
      this.numericUpDown_Durability.Location = new Point(6, 18);
      this.numericUpDown_Durability.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Durability.Name = "numericUpDown_Durability";
      this.numericUpDown_Durability.Size = new Size(44, 21);
      this.numericUpDown_Durability.TabIndex = 4;
      this.numericUpDown_Durability.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_Durability.ValueChanged += new EventHandler(this.numericUpDown_Durability_ValueChanged);
      this.checkBox_Luck.AutoSize = true;
      this.checkBox_Luck.Location = new Point(73, 344);
      this.checkBox_Luck.Name = "checkBox_Luck";
      this.checkBox_Luck.Size = new Size(48, 16);
      this.checkBox_Luck.TabIndex = 6;
      this.checkBox_Luck.Text = "Luck";
      this.checkBox_Luck.UseVisualStyleBackColor = true;
      this.checkBox_Skill.AutoSize = true;
      this.checkBox_Skill.Location = new Point(73, 366);
      this.checkBox_Skill.Name = "checkBox_Skill";
      this.checkBox_Skill.Size = new Size(54, 16);
      this.checkBox_Skill.TabIndex = 7;
      this.checkBox_Skill.Text = "Skill";
      this.checkBox_Skill.UseVisualStyleBackColor = true;
      this.groupBox5.Controls.Add((Control) this.radioButton_Ancient_Level2);
      this.groupBox5.Controls.Add((Control) this.radioButton_Ancient_Level1);
      this.groupBox5.Controls.Add((Control) this.radioButton_Ancient_None);
      this.groupBox5.Location = new Point(133, 173);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(130, 63);
      this.groupBox5.TabIndex = 12;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Anceint Option";
      this.radioButton_Ancient_Level2.AutoSize = true;
      this.radioButton_Ancient_Level2.Location = new Point(67, 39);
      this.radioButton_Ancient_Level2.Name = "radioButton_Ancient_Level2";
      this.radioButton_Ancient_Level2.Size = new Size(65, 16);
      this.radioButton_Ancient_Level2.TabIndex = 10;
      this.radioButton_Ancient_Level2.Text = "Level 2";
      this.radioButton_Ancient_Level2.UseVisualStyleBackColor = true;
      this.radioButton_Ancient_Level1.AutoSize = true;
      this.radioButton_Ancient_Level1.Location = new Point(6, 39);
      this.radioButton_Ancient_Level1.Name = "radioButton_Ancient_Level1";
      this.radioButton_Ancient_Level1.Size = new Size(65, 16);
      this.radioButton_Ancient_Level1.TabIndex = 9;
      this.radioButton_Ancient_Level1.Text = "Level 1";
      this.radioButton_Ancient_Level1.UseVisualStyleBackColor = true;
      this.radioButton_Ancient_None.AutoSize = true;
      this.radioButton_Ancient_None.Checked = true;
      this.radioButton_Ancient_None.Location = new Point(6, 18);
      this.radioButton_Ancient_None.Name = "radioButton_Ancient_None";
      this.radioButton_Ancient_None.Size = new Size(47, 16);
      this.radioButton_Ancient_None.TabIndex = 8;
      this.radioButton_Ancient_None.TabStop = true;
      this.radioButton_Ancient_None.Text = "None";
      this.radioButton_Ancient_None.UseVisualStyleBackColor = true;
      this.menuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.fileToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(652, 25);
      this.menuStrip1.TabIndex = 13;
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
      this.pictureBox_ItemPreview.BackColor = Color.FromArgb(37, 47, 1);
      this.pictureBox_ItemPreview.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_ItemPreview.Location = new Point(269, 173);
      this.pictureBox_ItemPreview.Name = "pictureBox_ItemPreview";
      this.pictureBox_ItemPreview.Size = new Size(120, 94);
      this.pictureBox_ItemPreview.TabIndex = 14;
      this.pictureBox_ItemPreview.TabStop = false;
      this.button_Add.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.button_Add.Location = new Point(96, 393);
      this.button_Add.Name = "button_Add";
      this.button_Add.Size = new Size(83, 30);
      this.button_Add.TabIndex = 22;
      this.button_Add.Text = "Add Item";
      this.button_Add.UseVisualStyleBackColor = true;
      this.button_Add.Click += new EventHandler(this.button_Add_Click);
      this.groupBox_NewItem_ExcOpt.BackColor = Color.Transparent;
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.radioButton_ExcWings);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.radioButton_ExcArmor);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.radioButton_ExcWeapon);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_ExcOpt6);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_ExcOpt5);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_ExcOpt4);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_ExcOpt3);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_ExcOpt2);
      this.groupBox_NewItem_ExcOpt.Controls.Add((Control) this.checkBox_ExcOpt1);
      this.groupBox_NewItem_ExcOpt.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.groupBox_NewItem_ExcOpt.ForeColor = SystemColors.ControlText;
      this.groupBox_NewItem_ExcOpt.Location = new Point(185, 272);
      this.groupBox_NewItem_ExcOpt.Name = "groupBox_NewItem_ExcOpt";
      this.groupBox_NewItem_ExcOpt.Size = new Size(204, 151);
      this.groupBox_NewItem_ExcOpt.TabIndex = 18;
      this.groupBox_NewItem_ExcOpt.TabStop = false;
      this.groupBox_NewItem_ExcOpt.Text = "Excellent Options";
      this.radioButton_ExcWings.AutoSize = true;
      this.radioButton_ExcWings.Location = new Point(136, 18);
      this.radioButton_ExcWings.Name = "radioButton_ExcWings";
      this.radioButton_ExcWings.Size = new Size(55, 17);
      this.radioButton_ExcWings.TabIndex = 14;
      this.radioButton_ExcWings.Text = "Wings";
      this.radioButton_ExcWings.UseVisualStyleBackColor = true;
      this.radioButton_ExcWings.CheckedChanged += new EventHandler(this.radioButton_Exc_CheckedChanged);
      this.radioButton_ExcArmor.AutoSize = true;
      this.radioButton_ExcArmor.Location = new Point(78, 18);
      this.radioButton_ExcArmor.Name = "radioButton_ExcArmor";
      this.radioButton_ExcArmor.Size = new Size(52, 17);
      this.radioButton_ExcArmor.TabIndex = 13;
      this.radioButton_ExcArmor.Text = "Armor";
      this.radioButton_ExcArmor.UseVisualStyleBackColor = true;
      this.radioButton_ExcArmor.CheckedChanged += new EventHandler(this.radioButton_Exc_CheckedChanged);
      this.radioButton_ExcWeapon.AutoSize = true;
      this.radioButton_ExcWeapon.Location = new Point(6, 18);
      this.radioButton_ExcWeapon.Name = "radioButton_ExcWeapon";
      this.radioButton_ExcWeapon.Size = new Size(66, 17);
      this.radioButton_ExcWeapon.TabIndex = 12;
      this.radioButton_ExcWeapon.Text = "Weapon";
      this.radioButton_ExcWeapon.UseVisualStyleBackColor = true;
      this.radioButton_ExcWeapon.CheckedChanged += new EventHandler(this.radioButton_Exc_CheckedChanged);
      this.checkBox_ExcOpt6.AutoSize = true;
      this.checkBox_ExcOpt6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOpt6.ForeColor = SystemColors.ControlText;
      this.checkBox_ExcOpt6.Location = new Point(6, 133);
      this.checkBox_ExcOpt6.Name = "checkBox_ExcOpt6";
      this.checkBox_ExcOpt6.Size = new Size(80, 17);
      this.checkBox_ExcOpt6.TabIndex = 20;
      this.checkBox_ExcOpt6.Text = "checkBox6";
      this.checkBox_ExcOpt6.UseVisualStyleBackColor = true;
      this.checkBox_ExcOpt5.AutoSize = true;
      this.checkBox_ExcOpt5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOpt5.ForeColor = SystemColors.ControlText;
      this.checkBox_ExcOpt5.Location = new Point(6, 115);
      this.checkBox_ExcOpt5.Name = "checkBox_ExcOpt5";
      this.checkBox_ExcOpt5.Size = new Size(80, 17);
      this.checkBox_ExcOpt5.TabIndex = 19;
      this.checkBox_ExcOpt5.Text = "checkBox5";
      this.checkBox_ExcOpt5.UseVisualStyleBackColor = true;
      this.checkBox_ExcOpt4.AutoSize = true;
      this.checkBox_ExcOpt4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOpt4.ForeColor = SystemColors.ControlText;
      this.checkBox_ExcOpt4.Location = new Point(6, 97);
      this.checkBox_ExcOpt4.Name = "checkBox_ExcOpt4";
      this.checkBox_ExcOpt4.Size = new Size(80, 17);
      this.checkBox_ExcOpt4.TabIndex = 18;
      this.checkBox_ExcOpt4.Text = "checkBox4";
      this.checkBox_ExcOpt4.UseVisualStyleBackColor = true;
      this.checkBox_ExcOpt3.AutoSize = true;
      this.checkBox_ExcOpt3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOpt3.ForeColor = SystemColors.ControlText;
      this.checkBox_ExcOpt3.Location = new Point(6, 78);
      this.checkBox_ExcOpt3.Name = "checkBox_ExcOpt3";
      this.checkBox_ExcOpt3.Size = new Size(80, 17);
      this.checkBox_ExcOpt3.TabIndex = 17;
      this.checkBox_ExcOpt3.Text = "checkBox3";
      this.checkBox_ExcOpt3.UseVisualStyleBackColor = true;
      this.checkBox_ExcOpt2.AutoSize = true;
      this.checkBox_ExcOpt2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOpt2.ForeColor = SystemColors.ControlText;
      this.checkBox_ExcOpt2.Location = new Point(6, 60);
      this.checkBox_ExcOpt2.Name = "checkBox_ExcOpt2";
      this.checkBox_ExcOpt2.Size = new Size(80, 17);
      this.checkBox_ExcOpt2.TabIndex = 16;
      this.checkBox_ExcOpt2.Text = "checkBox2";
      this.checkBox_ExcOpt2.UseVisualStyleBackColor = true;
      this.checkBox_ExcOpt1.AutoSize = true;
      this.checkBox_ExcOpt1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_ExcOpt1.ForeColor = SystemColors.ControlText;
      this.checkBox_ExcOpt1.Location = new Point(6, 42);
      this.checkBox_ExcOpt1.Name = "checkBox_ExcOpt1";
      this.checkBox_ExcOpt1.Size = new Size(80, 17);
      this.checkBox_ExcOpt1.TabIndex = 15;
      this.checkBox_ExcOpt1.Text = "checkBox1";
      this.checkBox_ExcOpt1.UseVisualStyleBackColor = true;
      this.label_Size.AutoSize = true;
      this.label_Size.BorderStyle = BorderStyle.FixedSingle;
      this.label_Size.Location = new Point(363, 253);
      this.label_Size.Name = "label_Size";
      this.label_Size.Size = new Size(25, 14);
      this.label_Size.TabIndex = 19;
      this.label_Size.Text = "1x1";
      this.button_Update.Enabled = false;
      this.button_Update.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.button_Update.Location = new Point(12, 393);
      this.button_Update.Name = "button_Update";
      this.button_Update.Size = new Size(78, 30);
      this.button_Update.TabIndex = 21;
      this.button_Update.Text = "Update Item";
      this.button_Update.UseVisualStyleBackColor = true;
      this.button_Update.Click += new EventHandler(this.button_Update_Click);
      this.checkBox_FO.AutoSize = true;
      this.checkBox_FO.Location = new Point(133, 239);
      this.checkBox_FO.Name = "checkBox_FO";
      this.checkBox_FO.Size = new Size(90, 28);
      this.checkBox_FO.TabIndex = 11;
      this.checkBox_FO.Text = "FO \r\n+15+28+Luck";
      this.checkBox_FO.UseVisualStyleBackColor = true;
      this.checkBox_FO.CheckedChanged += new EventHandler(this.checkBox_FO_CheckedChanged);
      this.label_FileName.BackColor = Color.Black;
      this.label_FileName.ForeColor = Color.White;
      this.label_FileName.Location = new Point(412, 32);
      this.label_FileName.Name = "label_FileName";
      this.label_FileName.Size = new Size(208, 15);
      this.label_FileName.TabIndex = 23;
      this.label_FileName.TextAlign = ContentAlignment.TopCenter;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(652, 434);
      this.Controls.Add((Control) this.label_FileName);
      this.Controls.Add((Control) this.checkBox_FO);
      this.Controls.Add((Control) this.button_Update);
      this.Controls.Add((Control) this.label_Size);
      this.Controls.Add((Control) this.groupBox_NewItem_ExcOpt);
      this.Controls.Add((Control) this.button_Add);
      this.Controls.Add((Control) this.pictureBox_ItemPreview);
      this.Controls.Add((Control) this.groupBox5);
      this.Controls.Add((Control) this.checkBox_Skill);
      this.Controls.Add((Control) this.checkBox_Luck);
      this.Controls.Add((Control) this.groupBox3);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.listBox_Index);
      this.Controls.Add((Control) this.listBox_Group);
      this.Controls.Add((Control) this.pictureBox_Init_1x1);
      this.Controls.Add((Control) this.pictureBox_ShopPreview);
      this.Controls.Add((Control) this.menuStrip1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = nameof (ShopEditor);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Shop Editor";
      this.FormClosed += new FormClosedEventHandler(this.ShopEditor_FormClosed);
      this.Load += new EventHandler(this.ShopEditor_Load);
      ((ISupportInitialize) this.pictureBox_Init_1x1).EndInit();
      ((ISupportInitialize) this.pictureBox_ShopPreview).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.numericUpDown_Durability.EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((ISupportInitialize) this.pictureBox_ItemPreview).EndInit();
      this.groupBox_NewItem_ExcOpt.ResumeLayout(false);
      this.groupBox_NewItem_ExcOpt.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void listBox_Group_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.listBox_Group.SelectedIndex == -1)
        return;
      this.DontWork = true;
      switch ((int) this.listBox_Group.SelectedValue)
      {
        case 0:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Swords;
          break;
        case 1:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Axes;
          break;
        case 2:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_MacesScepters;
          break;
        case 3:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Spears;
          break;
        case 4:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_BowsCrossBows;
          break;
        case 5:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Staffs;
          break;
        case 6:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Shields;
          break;
        case 7:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Helms;
          break;
        case 8:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Armors;
          break;
        case 9:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Pants;
          break;
        case 10:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Gloves;
          break;
        case 11:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Boots;
          break;
        case 12:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_WingsSkillsSeedsOthers;
          break;
        case 13:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Others1;
          break;
        case 14:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Others2;
          break;
        case 15:
          this.listBox_Index.DisplayMember = "Name";
          this.listBox_Index.ValueMember = "Index";
          this.listBox_Index.DataSource = (object) this.L_Scrolls;
          break;
      }
      this.listBox_Index.SelectedIndex = -1;
      this.DontWork = false;
      if (this.LastSelectedItemIndex > this.listBox_Index.Items.Count - 1)
        return;
      this.listBox_Index.SelectedIndex = this.LastSelectedItemIndex;
    }

    private void listBox_Index_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!(this.listBox_Index.SelectedIndex != -1 & !this.DontWork))
        return;
      this.LastSelectedItemIndex = this.listBox_Index.SelectedIndex;
      try
      {
        this.pictureBox_ItemPreview.BackgroundImage = (Image) Resources.ResourceManager.GetObject("_" + this.listBox_Group.SelectedValue + this.listBox_Index.SelectedValue);
        if (this.pictureBox_ItemPreview.BackgroundImage.Size.Width > this.pictureBox_ItemPreview.Size.Width || this.pictureBox_ItemPreview.BackgroundImage.Size.Height > this.pictureBox_ItemPreview.Size.Height)
          this.pictureBox_ItemPreview.BackgroundImageLayout = ImageLayout.Zoom;
        else
          this.pictureBox_ItemPreview.BackgroundImageLayout = ImageLayout.Center;
      }
      catch
      {
        this.pictureBox_ItemPreview.BackgroundImage = (Image) Resources.ResourceManager.GetObject("no_img");
      }
      Structures.UniItem selectedItem = (Structures.UniItem) this.listBox_Index.SelectedItem;
      this.label_Size.Text = selectedItem.X.ToString() + "x" + (object) selectedItem.Y;
      this.checkBox_Skill.Checked = selectedItem.Skill != 0 && this.checkBox_Skill.Checked;
      this.listBox_Option.SelectedIndex = selectedItem.Option == 0 ? 0 : this.listBox_Option.SelectedIndex;
      this.radioButton_Ancient_None.Checked = selectedItem.Ancient == 0 || this.radioButton_Ancient_None.Checked;
      this.numericUpDown_Durability.Value = selectedItem.Durability == 0 ? 0M : this.numericUpDown_Durability.Value;
      switch (selectedItem.Slot)
      {
        case -1:
        case 8:
        case 236:
          this.checkBox_ExcOpt1.Checked = false;
          this.checkBox_ExcOpt2.Checked = false;
          this.checkBox_ExcOpt3.Checked = false;
          this.checkBox_ExcOpt4.Checked = false;
          this.checkBox_ExcOpt5.Checked = false;
          this.checkBox_ExcOpt6.Checked = false;
          break;
        case 0:
        case 9:
          this.radioButton_ExcWeapon.Checked = true;
          break;
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
        case 10:
          if (selectedItem.Group > 5)
          {
            this.radioButton_ExcArmor.Checked = true;
            break;
          }
          this.radioButton_ExcWeapon.Checked = true;
          break;
        case 7:
          this.radioButton_ExcWings.Checked = true;
          break;
      }
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ShopItems = new Structures.ShopItem[16, 9];
      this.SelectedSI = new Structures.ShopItem();
      this.LastSelectetItem = new Structures.CustomPictureBox();
      this.ChangeOccupid(1, 1, 8, 15, false);
      this.ClearShopItemsPreview();
      this.button_Update.Enabled = false;
    }

    private void numericUpDown_Durability_ValueChanged(object sender, EventArgs e)
    {
      if (!this.numericUpDown_Durability.Focused)
      {
        if (this.checkBox_DurLock.Checked)
          this.numericUpDown_Durability.Value = (Decimal) this.OldDurValue;
        else
          this.OldDurValue = (int) this.numericUpDown_Durability.Value;
      }
      else
        this.OldDurValue = (int) this.numericUpDown_Durability.Value;
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Filter = "Text files (*.txt)|*.txt";
      openFileDialog1.Title = "Select a Text Shop file to Load";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray1 = openFileDialog2.FileName.Split('.');
      if (strArray1[strArray1.Length - 1] == "txt")
      {
        string[] strArray2 = openFileDialog2.FileName.Split('\\');
        this.label_FileName.Text = strArray2[strArray2.Length - 1];
        this.ShopItems = new Structures.ShopItem[16, 9];
        this.SelectedSI = new Structures.ShopItem();
        this.LastSelectetItem = new Structures.CustomPictureBox();
        this.ChangeOccupid(1, 1, 8, 15, false);
        this.ClearShopItemsPreview();
        this.ReadShopFile(openFileDialog2.FileName);
      }
      else
      {
        int num = (int) MessageBox.Show("Invalid file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private unsafe void pb_MouseClick(object sender, MouseEventArgs e)
    {
      Structures.CustomPictureBox customPictureBox = (Structures.CustomPictureBox) sender;
      string[] strArray1 = customPictureBox.Name.Split('_');
      string[] strArray2 = strArray1[strArray1.Length - 2].Split('x');
      string[] strArray3 = strArray1[strArray1.Length - 1].Split('x');
      int int16_1 = (int) Convert.ToInt16(strArray2[1]);
      int int16_2 = (int) Convert.ToInt16(strArray2[0]);
      int int16_3 = (int) Convert.ToInt16(strArray3[1]);
      int int16_4 = (int) Convert.ToInt16(strArray3[0]);
      string str = "Item_" + (object) int16_2 + "x" + (object) int16_1 + "_" + (object) int16_4 + "x" + (object) int16_3;
      if (e.Button != MouseButtons.Right)
      {
        if (e.Button != MouseButtons.Left || this.LastSelectetItem == customPictureBox)
          return;
        customPictureBox.BorderColor = Color.Gold;
        this.LastSelectetItem.BorderColor = Color.Transparent;
        this.LastSelectetItem = customPictureBox;
        this.pictureBox_ShopPreview.Invalidate();
        Structures.ShopItem[,] shopItems = this.ShopItems;
        int upperBound1 = shopItems.GetUpperBound(0);
        int upperBound2 = shopItems.GetUpperBound(1);
        for (int lowerBound1 = shopItems.GetLowerBound(0); lowerBound1 <= upperBound1; ++lowerBound1)
        {
          for (int lowerBound2 = shopItems.GetLowerBound(1); lowerBound2 <= upperBound2; ++lowerBound2)
          {
            Structures.ShopItem shopItem = shopItems[lowerBound1, lowerBound2];
            if (str == shopItem.UniqName)
            {
              this.SelectedSI = shopItem;
              break;
            }
          }
        }
        this.listBox_Group.SelectedValue = (object) this.SelectedSI.Group;
        this.listBox_Index.SelectedValue = (object) this.SelectedSI.Index;
        this.listBox_Level.SelectedIndex = (int) this.SelectedSI.Level;
        this.listBox_Option.SelectedIndex = (int) this.SelectedSI.Option;
        this.checkBox_Luck.Checked = this.SelectedSI.Luck;
        this.checkBox_Skill.Checked = this.SelectedSI.Skill;
        this.numericUpDown_Durability.Value = (Decimal) this.SelectedSI.Durablity;
        if (this.SelectedSI.Ancient == (byte) 5)
          this.radioButton_Ancient_Level1.Checked = true;
        else if (this.SelectedSI.Ancient == (byte) 10)
          this.radioButton_Ancient_Level2.Checked = true;
        else
          this.radioButton_Ancient_None.Checked = true;
        this.checkBox_ExcOpt1.Checked = ((int) this.SelectedSI.Excellent & 1) == 1;
        this.checkBox_ExcOpt2.Checked = ((int) this.SelectedSI.Excellent >> 1 & 1) == 1;
        this.checkBox_ExcOpt3.Checked = ((int) this.SelectedSI.Excellent >> 2 & 1) == 1;
        this.checkBox_ExcOpt4.Checked = ((int) this.SelectedSI.Excellent >> 3 & 1) == 1;
        this.checkBox_ExcOpt5.Checked = ((int) this.SelectedSI.Excellent >> 4 & 1) == 1;
        this.checkBox_ExcOpt6.Checked = ((int) this.SelectedSI.Excellent >> 5 & 1) == 1;
        this.button_Update.Enabled = true;
      }
      else
      {
        if (MessageBox.Show("    Are you sure you want to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
          return;
        Structures.ShopItem[,] shopItems = this.ShopItems;
        int upperBound3 = shopItems.GetUpperBound(0);
        int upperBound4 = shopItems.GetUpperBound(1);
        for (int lowerBound3 = shopItems.GetLowerBound(0); lowerBound3 <= upperBound3; ++lowerBound3)
        {
          for (int lowerBound4 = shopItems.GetLowerBound(1); lowerBound4 <= upperBound4; ++lowerBound4)
          {
            Structures.ShopItem shopItem = shopItems[lowerBound3, lowerBound4];
            if (str == shopItem.UniqName)
            {
              *(Structures.ShopItem*) ref this.ShopItems.Address(shopItem.ShopLocY, shopItem.ShopLocX) = new Structures.ShopItem();
              break;
            }
          }
        }
        this.pictureBox_ShopPreview.Controls.RemoveByKey("pictureBox_Item_" + (object) int16_2 + "x" + (object) int16_1 + "_" + (object) int16_4 + "x" + (object) int16_3);
        this.ChangeOccupid(int16_1, int16_2, int16_3, int16_4, false);
        this.button_Update.Enabled = false;
      }
    }

    private void radioButton_Exc_CheckedChanged(object sender, EventArgs e)
    {
      if (this.radioButton_ExcArmor.Checked)
      {
        this.checkBox_ExcOpt1.Text = "Zen Drop +30%";
        this.checkBox_ExcOpt2.Text = "Def Success Rate +10%";
        this.checkBox_ExcOpt3.Text = "Reflect +5%";
        this.checkBox_ExcOpt4.Text = "Damage Decrease +4%";
        this.checkBox_ExcOpt5.Text = "Mana +4%";
        this.checkBox_ExcOpt6.Text = "HP +4%";
      }
      else if (this.radioButton_ExcWeapon.Checked)
      {
        this.checkBox_ExcOpt1.Text = "Mob Kill +mana/8";
        this.checkBox_ExcOpt2.Text = "Mob Kill +life/8";
        this.checkBox_ExcOpt3.Text = "Attack(Wizardy) Speed +7";
        this.checkBox_ExcOpt4.Text = "Damage +2%";
        this.checkBox_ExcOpt5.Text = "Damage +level/20";
        this.checkBox_ExcOpt6.Text = "Exc Damage Rate +10%";
      }
      else
      {
        if (!this.radioButton_ExcWings.Checked)
          return;
        this.checkBox_ExcOpt1.Text = "Ignor Def +5% / HP +125";
        this.checkBox_ExcOpt2.Text = "Return Attack +5% / Mana +125";
        this.checkBox_ExcOpt3.Text = "Life Recovery +5% /Ignor Def +3%";
        this.checkBox_ExcOpt4.Text = "Mana Recovery +5% / AG +50";
        this.checkBox_ExcOpt5.Text = "--- / Attack(Wiz) Speed+5";
        this.checkBox_ExcOpt6.Text = "---";
      }
    }

    private void ReadShopFile(string fName)
    {
      foreach (string readAllLine in File.ReadAllLines(fName))
      {
        if (!readAllLine.ToLower().Replace("\t", "").Trim().StartsWith("end") & !readAllLine.ToUpper().Replace("\t", "").Trim().StartsWith("/") & readAllLine.ToUpper().Replace("\t", "").Trim().Length > 0)
        {
          string[] strArray = readAllLine.Replace(" ", "\t").Split('\t');
          List<string> stringList = new List<string>();
          for (int index = 0; index < strArray.Length; ++index)
          {
            if (strArray[index].Trim().Length != 0)
              stringList.Add(strArray[index]);
          }
          string[] array = stringList.ToArray();
          if (array.Length < 9)
          {
            int num = (int) MessageBox.Show("\tInvalid line", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          }
          try
          {
            Structures.ShopItem sI = new Structures.ShopItem()
            {
              Group = Convert.ToInt32(array[0]),
              Index = Convert.ToInt32(array[1]),
              Level = Convert.ToByte(array[2]),
              Durablity = Convert.ToByte(array[3]),
              Skill = Convert.ToBoolean(Convert.ToByte(array[4])),
              Luck = Convert.ToBoolean(Convert.ToByte(array[5])),
              Option = Convert.ToByte(array[6]),
              Excellent = Convert.ToByte(array[7]),
              Ancient = Convert.ToByte(array[8])
            };
            string empty = string.Empty;
            string toolTip = string.Empty + (sI.Excellent > (byte) 0 ? "Excellent " : "") + (sI.Ancient > (byte) 0 ? "Ancient " : "") + this.ItemName[sI.Group, sI.Index] + "+" + (object) sI.Level + "+" + (sI.Option == (byte) 1 ? (object) "4" : (sI.Option == (byte) 2 ? (object) "8" : (sI.Option == (byte) 3 ? (object) "12" : (sI.Option == (byte) 4 ? (object) "16" : (sI.Option == (byte) 5 ? (object) "20" : (sI.Option == (byte) 6 ? (object) "24" : (sI.Option == (byte) 7 ? (object) "28" : (object) "0"))))))) + (sI.Skill ? "+Skill" : "") + (sI.Luck ? (object) "+Luck" : (object) "") + "\n\nDurability: " + (object) sI.Durablity + (sI.Ancient > (byte) 0 ? (sI.Ancient == (byte) 5 ? "\n\nAncinet: Level 1" : (sI.Ancient == (byte) 10 ? "\n\nAncinet: Level 2" : "")) : "");
            if (sI.Excellent > (byte) 0)
              toolTip = toolTip + "\n\nExcellent Option: " + (object) sI.Excellent;
            Structures.UniItem uniqItm = new Structures.UniItem()
            {
              Group = sI.Group,
              Index = sI.Index
            };
            uniqItm.X = (int) Convert.ToInt16(this.ItemSize[uniqItm.Group, uniqItm.Index].Split('x')[0]);
            uniqItm.Y = (int) Convert.ToInt16(this.ItemSize[uniqItm.Group, uniqItm.Index].Split('x')[1]);
            if (this.AddItemPicture(toolTip, ref empty, uniqItm, ref sI))
            {
              sI.UniqName = empty;
              this.SelectedSI = sI;
              this.ShopItems[sI.ShopLocY, sI.ShopLocX] = sI;
            }
          }
          catch
          {
            int num = (int) MessageBox.Show("\tInvalid line", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          }
        }
      }
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Title = "Select a Location to save the Shop file";
      saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray1 = saveFileDialog2.FileName.Split('\\');
      this.label_FileName.Text = strArray1[strArray1.Length - 1];
      string[] strArray2 = saveFileDialog2.FileName.Split('\\');
      string str1 = strArray2[strArray2.Length - 1].Split('.')[0];
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName)
      {
        AutoFlush = true
      };
      streamWriter.WriteLine("/////////////////////////////////////////////////////////////////////////////");
      streamWriter.WriteLine("//Shop file created by MU.ToolKit [Shop Editor]");
      streamWriter.WriteLine("//coded by © TopReal.IT");
      streamWriter.WriteLine("///////////////////////////");
      streamWriter.WriteLine("//Shop: {0}", (object) str1);
      streamWriter.WriteLine("/////////////////////////////////////////////////////////////////////////////");
      streamWriter.WriteLine("//Group\tIndex\tLevel\tDur\tSkill\tLuck\tOpt\tExeOpt\tAncOpt\tInfo");
      streamWriter.WriteLine("/////////////////////////////////////////////////////////////////////////////");
      streamWriter.WriteLine("//");
      for (int index1 = 1; index1 < 16; ++index1)
      {
        for (int index2 = 1; index2 < 9; ++index2)
        {
          if (this.ShopItems[index1, index2].UniqName != null)
          {
            Structures.ShopItem shopItem = this.ShopItems[index1, index2];
            string str2 = string.Empty + (shopItem.Excellent > (byte) 0 ? "Excellent " : "") + (shopItem.Ancient > (byte) 0 ? "Ancient " : "");
            streamWriter.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t//{9}", (object) shopItem.Group, (object) shopItem.Index, (object) shopItem.Level, (object) shopItem.Durablity, (object) Convert.ToInt16(shopItem.Skill), (object) Convert.ToInt16(shopItem.Luck), (object) shopItem.Option, (object) shopItem.Excellent, (object) shopItem.Ancient, (object) (str2 + this.ItemName[shopItem.Group, shopItem.Index]));
          }
        }
      }
      streamWriter.WriteLine("end");
      streamWriter.Close();
    }

    private void ShopEditor_FormClosed(object sender, FormClosedEventArgs e) => Application.OpenForms["Form1"].WindowState = FormWindowState.Normal;

    private void ShopEditor_Load(object sender, EventArgs e)
    {
      this.isEx700ItemList = ((Form1) Application.OpenForms[0]).isEx700ItemList ? 1 : 0;
      this.AddPreviewBoxes(8, 15);
      if (this.isEx700ItemList == 1)
        this.strct.ReadItemList("Data\\ItemListSettings_ex700.ini", true, ref this.L_Groups, ref this.L_Swords, ref this.L_Axes, ref this.L_MacesScepters, ref this.L_Spears, ref this.L_BowsCrossBows, ref this.L_Staffs, ref this.L_Shields, ref this.L_Helms, ref this.L_Armors, ref this.L_Pants, ref this.L_Gloves, ref this.L_Boots, ref this.L_WingsSkillsSeedsOthers, ref this.L_Others1, ref this.L_Others2, ref this.L_Scrolls, ref this.ItemName, ref this.ItemSize);
      else
        this.strct.ReadItemList("Data\\ItemListSettings.ini", false, ref this.L_Groups, ref this.L_Swords, ref this.L_Axes, ref this.L_MacesScepters, ref this.L_Spears, ref this.L_BowsCrossBows, ref this.L_Staffs, ref this.L_Shields, ref this.L_Helms, ref this.L_Armors, ref this.L_Pants, ref this.L_Gloves, ref this.L_Boots, ref this.L_WingsSkillsSeedsOthers, ref this.L_Others1, ref this.L_Others2, ref this.L_Scrolls, ref this.ItemName, ref this.ItemSize);
      this.listBox_Group.DisplayMember = "GroupName";
      this.listBox_Group.ValueMember = "Group";
      this.listBox_Group.DataSource = (object) this.L_Groups;
      this.strct.Setc_LevelData(ref this.c_LevelDatas);
      this.listBox_Level.DataSource = (object) this.c_LevelDatas;
      this.listBox_Level.ValueMember = "ID";
      this.listBox_Level.DisplayMember = "Name";
      this.strct.Setc_OptionData(ref this.c_OptionDatas);
      this.listBox_Option.DataSource = (object) this.c_OptionDatas;
      this.listBox_Option.DisplayMember = "Name";
      this.listBox_Option.ValueMember = "ID";
      this.radioButton_ExcWeapon.Checked = true;
      Application.OpenForms["Form1"].WindowState = FormWindowState.Minimized;
      this.WindowState = FormWindowState.Normal;
      this.TopMost = true;
      this.TopMost = false;
      this.BringToFront();
      this.Focus();
    }
  }
}
