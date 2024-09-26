// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.CashShopEditor
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
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MU_ToolKit
{
  public class CashShopEditor : Form
  {
    public List<string> AddedCatName = new List<string>();
    public List<string> AddedItems = new List<string>();
    public List<string> AddedSubCatName = new List<string>();
    private ToolStripMenuItem addNewToolStripMenuItem;
    private ToolStripMenuItem addNewToolStripMenuItem1;
    private Button button_NewItem_Add;
    public short CatCount;
    private CheckBox checkBox_AddItem_FOItem;
    public CheckBox checkBox_NewItem_ExcOpt1;
    public CheckBox checkBox_NewItem_ExcOpt2;
    public CheckBox checkBox_NewItem_ExcOpt3;
    public CheckBox checkBox_NewItem_ExcOpt4;
    public CheckBox checkBox_NewItem_ExcOpt5;
    public CheckBox checkBox_NewItem_ExcOpt6;
    public CheckBox checkBox_NewItem_Luck;
    public CheckBox checkBox_NewItem_Skill;
    private ToolStripMenuItem clientFilesToolStripMenuItem;
    public ComboBox comboBox_Ancient;
    private ComboBox comboBox_NewItem_Coin;
    private ComboBox comboBox_NewItem_CountType;
    private IContainer components;
    public int currPage = 1;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem fileToolStripMenuItem;
    public Form form_ItemsAdd;
    private GroupBox groupBox_NewItem_ExcOpt;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox6;
    private GroupBox groupBox8;
    private GroupBox groupBox9;
    public List<Structures.IBSCategory> HeadCategories = new List<Structures.IBSCategory>();
    private ToolStripMenuItem headCategoriesToolStripMenuItem;
    public List<string> IGC_CashItemInfo_Indexes = new List<string>();
    public List<string> IGC_CashItemList_Indexes = new List<string>();
    public List<string> IGC_CashItemPackages_Indexes = new List<string>();
    public int isEx700ItemList = 1;
    public int isFirstHeadCat;
    public int isFirstSubCat;
    public bool isParentClosing;
    public int ItemPageCount;
    public BindingList<Structures.IGCCashItemInfo> ItemsInfo = new BindingList<Structures.IGCCashItemInfo>();
    public BindingList<Structures.IGCCashItemList> ItemsList = new BindingList<Structures.IGCCashItemList>();
    public BindingList<Structures.IGCCashItemPackages> ItemsPackage = new BindingList<Structures.IGCCashItemPackages>();
    public object[,] ItemsStrct = new object[3, 3];
    public List<Structures.IBSPackage> ItemsToAdd = new List<Structures.IBSPackage>();
    public Label label_CurrPage;
    private Label label_ItemName;
    private Label label_ItemPrice;
    private Label label_MaxPage;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    public TextBox LastClickedCatTB;
    public TextBox LastClickedSubCatTB;
    public int LastSelectedItemIndex;
    public Structures.CustomPictureBox LastSelectedPB;
    public ListBox listBox_NewItem_ItemGroup;
    public ListBox listBox_NewItem_ItemIndex;
    public ListBox listBox_NewItem_ItemLevel;
    public ListBox listBox_NewItem_ItemOption;
    public int MaxCategoryIndex = 10;
    public int MaxHeadCatIndex;
    public int MaxItemListGID;
    public int MaxPackageID;
    private MenuStrip menuStrip1;
    private NumericUpDown numericUpDown_NewItem_Count;
    public NumericUpDown numericUpDown_NewItem_Durability;
    private NumericUpDown numericUpDown_NewItem_Price;
    public NumericUpDown numericUpDown_NewItem_SocketCount;
    public int PackageMaxIndex;
    public List<Structures.IBSPackage> Packages = new List<Structures.IBSPackage>();
    private MyPanel panel_CatFirst;
    private MyPanel panel_Item;
    private Panel panel_ItemAdd;
    private MyPanel panel_ItemsPage1;
    private MyPanel panel_MainForm;
    private MyPanel panel_NextPage;
    private MyPanel panel_PrevPage;
    private MyPanel panel_SubCat1;
    private MyPanel panel_SubCatEnd;
    private MyPanel panel8;
    private MyPanel panel9;
    private PictureBox pictureBox_ItemImg;
    private PictureBox pictureBox_NewItem_ItemPreview;
    public int ProductMaxIndex1;
    public int ProductMaxIndex7;
    public BindingList<Structures.IBSProduct> Products = new BindingList<Structures.IBSProduct>();
    private RadioButton radioButton_NewItem_ExcArmor;
    private RadioButton radioButton_NewItem_ExcWeapon;
    private RadioButton radioButton_NewItem_ExcWings;
    private Random rand = new Random();
    private RichTextBox richTextBox_NewItem_Info;
    private ToolStripMenuItem saveToolStripMenuItem1;
    public BindingList<Structures.IGCCashItemInfo> Selected_iInfo = new BindingList<Structures.IGCCashItemInfo>();
    public BindingList<Structures.IGCCashItemList> Selected_iList = new BindingList<Structures.IGCCashItemList>();
    public BindingList<Structures.IGCCashItemPackages> Selected_iPack = new BindingList<Structures.IGCCashItemPackages>();
    public Structures.IBSPackage Selected_iPackage;
    public BindingList<Structures.IBSProduct> Selected_iProduct = new BindingList<Structures.IBSProduct>();
    public Structures.IBSCategory SelectedHeadCat = new Structures.IBSCategory();
    private TextBox selectedHeadTB = new TextBox();
    public Structures.IBSCategory SelectedSubCat = new Structures.IBSCategory();
    private TextBox selectedSubTB = new TextBox();
    private ToolStripMenuItem serverFilesToolStripMenuItem;
    public Structures strct = new Structures();
    public short SubCatCount;
    public List<Structures.IBSCategory> SubCategories = new List<Structures.IBSCategory>();
    private ToolStripMenuItem subCategoriesToolStripMenuItem;
    private ToolTip t1 = new ToolTip();
    private ToolTip t2 = new ToolTip();
    private TextBox textBox_Cat1;
    private TextBox textBox_NewItem_Name;
    private TextBox textBox_SubCat1;
    public int TraceNumber;

    public CashShopEditor() => this.InitializeComponent();

    private void AddHeadCat(Structures.IBSCategory cat)
    {
      if (this.CatCount >= (short) 6)
        return;
      Panel panel = (Panel) new MyPanel();
      TextBox textBox1 = new TextBox();
      textBox1.Location = new Point(this.textBox_Cat1.Location.X - 5, this.textBox_Cat1.Location.Y);
      textBox1.BackColor = this.textBox_Cat1.BackColor;
      textBox1.BorderStyle = this.textBox_Cat1.BorderStyle;
      textBox1.ForeColor = this.textBox_Cat1.ForeColor;
      textBox1.Font = this.textBox_Cat1.Font;
      textBox1.TextAlign = this.textBox_Cat1.TextAlign;
      textBox1.Name = "txtb_Cat_" + (object) cat.Seq + "_" + (object) cat.Index;
      textBox1.Text = cat.Name;
      TextBox textBox2 = textBox1;
      textBox2.MouseClick += new MouseEventHandler(this.nwTbHeadCat_MouseClick);
      textBox2.MouseDoubleClick += new MouseEventHandler(this.nwTbHeadCat_MouseDoubleClick);
      textBox2.KeyDown += new KeyEventHandler(this.nwTbHeadCat_KeyDown);
      textBox2.LostFocus += new EventHandler(this.nwTb_LostFocus);
      textBox2.ReadOnly = true;
      if (this.isFirstHeadCat == 0)
      {
        textBox2.ForeColor = Color.Gold;
        this.LastClickedCatTB = textBox2;
        this.isFirstHeadCat = 1;
      }
      panel.Name = "pnl_Cat_" + (object) cat.Seq + "_" + (object) cat.Index;
      panel.BackgroundImageLayout = ImageLayout.Stretch;
      panel.BackgroundImage = (Image) new Bitmap((Image) Resources.pnl_NewCat);
      panel.Location = new Point(this.panel_CatFirst.Size.Width * (int) this.CatCount + 40, 0);
      panel.Size = new Size(this.panel_CatFirst.Size.Width, this.panel_CatFirst.Size.Height);
      this.panel_MainForm.Controls.Add((Control) panel);
      this.AddedCatName.Add("pnl_Cat_" + (object) cat.Seq + "_" + (object) cat.Index);
      ++this.CatCount;
      panel.Controls.Add((Control) textBox2);
      panel.BringToFront();
    }

    private void AddItem(Structures.IBSPackage pack)
    {
      if (this.AddedItems.Count >= 10)
        return;
      pack.TraceNumber = this.TraceNumber;
      int num1 = pack.ItemID / 512;
      int num2 = pack.ItemID - 512 * num1;
      Panel panel1 = new Panel();
      panel1.BackColor = Color.Transparent;
      Panel panel2 = panel1;
      string firstNull = this.GetFirstNull(this.ItemsStrct, (short) 3, (short) 3);
      int int32_1 = Convert.ToInt32(firstNull.Split('x')[0]);
      int int32_2 = Convert.ToInt32(firstNull.Split('x')[1]);
      panel2.Name = "pnl_Itm_" + (object) int32_2 + "x" + (object) int32_1;
      if (this.AddedItems.Count < 3)
        panel2.Location = new Point(int32_2 * this.panel_Item.Size.Width + 5, int32_1 * this.panel_Item.Size.Height + 1);
      else if (this.AddedItems.Count < 6)
        panel2.Location = new Point(int32_2 * this.panel_Item.Size.Width - 3, int32_1 * this.panel_Item.Size.Height + 45);
      else
        panel2.Location = new Point(int32_2 * this.panel_Item.Size.Width + 10, int32_1 * this.panel_Item.Size.Height + 85);
      panel2.Size = this.panel_Item.Size;
      Label label1 = new Label();
      label1.Location = this.label_ItemName.Location;
      label1.Size = this.label_ItemName.Size;
      label1.TextAlign = ContentAlignment.MiddleCenter;
      label1.ForeColor = this.label_ItemName.ForeColor;
      label1.Text = pack.Name;
      label1.AutoSize = false;
      Label label2 = label1;
      Label label3 = new Label();
      label3.Location = this.label_ItemPrice.Location;
      label3.Size = this.label_ItemPrice.Size;
      label3.TextAlign = ContentAlignment.MiddleCenter;
      label3.ForeColor = this.label_ItemPrice.ForeColor;
      label3.Text = pack.Price.ToString() + " " + pack.CoinTxt1;
      Label label4 = label3;
      Structures.CustomPictureBox customPictureBox1 = new Structures.CustomPictureBox();
      customPictureBox1.Location = this.pictureBox_ItemImg.Location;
      customPictureBox1.Size = this.pictureBox_ItemImg.Size;
      customPictureBox1.BackgroundImageLayout = ImageLayout.Center;
      customPictureBox1.Name = panel2.Name + "_" + (object) pack.CatIndex + "@" + (object) pack.Seq + "@" + (object) pack.Index;
      Structures.CustomPictureBox customPictureBox2 = customPictureBox1;
      customPictureBox2.MouseClick += new MouseEventHandler(this.itmPic_MouseClick);
      customPictureBox2.BorderColor = Color.Transparent;
      try
      {
        customPictureBox2.BackgroundImage = (Image) Resources.ResourceManager.GetObject("_" + num1.ToString() + num2.ToString());
        if (customPictureBox2.BackgroundImage.Size.Width <= customPictureBox2.Size.Width)
        {
          if (customPictureBox2.BackgroundImage.Size.Height <= customPictureBox2.Size.Height)
            goto label_12;
        }
        customPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
      }
      catch
      {
        customPictureBox2.BackgroundImage = (Image) Resources.ResourceManager.GetObject("no_img");
      }
label_12:
      panel2.Controls.Add((Control) label2);
      panel2.Controls.Add((Control) customPictureBox2);
      panel2.Controls.Add((Control) label4);
      this.panel_ItemsPage1.Controls.Add((Control) panel2);
      this.ItemsStrct[int32_1, int32_2] = (object) 1;
      this.AddedItems.Add(panel2.Name + "_" + (object) pack.CatIndex + "@" + (object) pack.Seq + "@" + (object) pack.Index);
      ++this.TraceNumber;
    }

    private void AddSubCat(Structures.IBSCategory cat)
    {
      if (this.SubCatCount >= (short) 12)
        return;
      Panel panel = (Panel) new MyPanel();
      TextBox textBox1 = new TextBox();
      textBox1.Location = new Point(30, 17);
      textBox1.BackColor = this.textBox_SubCat1.BackColor;
      textBox1.BorderStyle = this.textBox_SubCat1.BorderStyle;
      textBox1.ForeColor = this.textBox_SubCat1.ForeColor;
      textBox1.Font = this.textBox_SubCat1.Font;
      textBox1.TextAlign = this.textBox_SubCat1.TextAlign;
      textBox1.Name = "txtb_SubCat_" + (object) cat.Seq + "_" + (object) cat.Index;
      textBox1.Text = cat.Name;
      TextBox textBox2 = textBox1;
      textBox2.MouseClick += new MouseEventHandler(this.nwTbSubCat_MouseClick);
      textBox2.MouseDoubleClick += new MouseEventHandler(this.nwTbSubCat_MouseDoubleClick);
      textBox2.KeyDown += new KeyEventHandler(this.nwTbSubCat_KeyDown);
      textBox2.ReadOnly = true;
      textBox2.LostFocus += new EventHandler(this.nwTb_LostFocus);
      if (this.isFirstSubCat == 0)
      {
        textBox2.ForeColor = Color.Gold;
        this.LastClickedSubCatTB = textBox2;
        this.isFirstSubCat = 1;
      }
      panel.Name = "pnl_SubCat_" + (object) cat.Seq + "_" + (object) cat.Index;
      panel.BackgroundImageLayout = ImageLayout.Stretch;
      panel.BackgroundImage = (Image) new Bitmap((Image) Resources.pnl_NewSubCat2);
      panel.Location = new Point(0, (Resources.pnl_NewSubCat2.Size.Height - 30) * (int) this.SubCatCount + this.panel_SubCat1.Size.Height - 10);
      panel.Size = new Size(Resources.pnl_NewSubCat2.Size.Width - 30, Resources.pnl_NewSubCat2.Size.Height - 30);
      this.AddedSubCatName.Add("pnl_SubCat_" + (object) cat.Seq + "_" + (object) cat.Index);
      ++this.SubCatCount;
      this.panel_SubCatEnd.Location = new Point(0, (Resources.pnl_NewSubCat2.Size.Height - 31) * (int) this.SubCatCount + this.panel_SubCat1.Size.Height);
      panel.BringToFront();
      this.panel_MainForm.Controls.Add((Control) panel);
      panel.Controls.Add((Control) textBox2);
    }

    private void addToolStripMenuItem_Cat_Click(object sender, EventArgs e)
    {
      if (this.CatCount >= (short) 6)
        return;
      if (this.HasChildren)
      {
        Form_CashShop_AddItems openForm = (Form_CashShop_AddItems) Application.OpenForms["Form_CashShop_AddItems"];
        if (openForm != null)
        {
          openForm.button_AddItemToDB.Enabled = false;
          openForm.button_NewItem_Add.Enabled = false;
          openForm.button_UpdateExistingItem.Enabled = false;
        }
      }
      ++this.MaxHeadCatIndex;
      Structures.IBSCategory cat = new Structures.IBSCategory()
      {
        Index = this.MaxHeadCatIndex,
        Name = "HeadCat_" + (object) ((int) this.CatCount + 1),
        Unk1 = 200,
        Unk2 = 201,
        Seq = Convert.ToInt16((int) this.CatCount + 1),
        IsHeadCat = true
      };
      cat.HeadCatIndex = cat.Index;
      this.HeadCategories.Add(cat);
      this.AddHeadCat(cat);
    }

    private void addToolStripMenuItem_SubCat_Click(object sender, EventArgs e)
    {
      if (!(this.CatCount > (short) 0 & this.SelectedHeadCat.Unk1 != (short) 0))
        return;
      ++this.MaxCategoryIndex;
      Structures.IBSCategory cat = new Structures.IBSCategory()
      {
        Index = this.MaxCategoryIndex,
        Name = "SubCat_" + (object) ((int) this.SubCatCount + 1),
        Unk1 = 200,
        Unk2 = 201,
        HeadCatIndex = this.SelectedHeadCat.Index,
        Seq = Convert.ToInt16((int) this.SubCatCount + 1),
        IsHeadCat = false
      };
      this.SubCategories.Add(cat);
      this.AddSubCat(cat);
      if (this.AddedSubCatName.Count != 1)
        return;
      this.SelectedSubCat = cat;
      if (this.button_NewItem_Add.Enabled)
        return;
      this.button_NewItem_Add.Enabled = true;
    }

    private void CashShopEditor_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.OpenForms["Form1"].WindowState = FormWindowState.Normal;
      this.isParentClosing = true;
      Application.OpenForms["Form_CashShop_AddItems"].Close();
    }

    private void CashShopEditor_Load(object sender, EventArgs e)
    {
      this.isEx700ItemList = ((Form1) Application.OpenForms[0]).isEx700ItemList ? 1 : 0;
      this.DoubleBuffered = true;
      this.ReadCSFiles();
      this.LoadHeadCategories();
      if (this.CatCount > (short) 0)
      {
        this.LoadSubCategories(this.HeadCategories[0].HeadCatIndex);
        this.ItemsToAdd = this.GetSubCatItems(this.SubCategories[0].Index);
        this.LoadItems(1);
        this.SelectedSubCat = this.SubCategories[0];
        this.SelectedHeadCat = this.HeadCategories[0];
      }
      this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
      Application.OpenForms["Form1"].WindowState = FormWindowState.Minimized;
      this.WindowState = FormWindowState.Normal;
      this.TopMost = true;
      this.TopMost = false;
      this.BringToFront();
      this.Focus();
      this.form_ItemsAdd = (Form) new Form_CashShop_AddItems();
      this.form_ItemsAdd.Show();
    }

    private void clientToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string str = "Saved Data\\CashShop Editor\\Client Files\\" + DateTime.Now.ToLocalTime().ToString().Replace('/', '.').Replace(':', '-').Replace(" ", " [") + "]";
      Directory.CreateDirectory(str);
      if (!this.GenerateClientFiles(str) || MessageBox.Show("Files saved successfully in\n\"" + str + "\"\n\nOpen containing folder?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(str);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private bool GenerateClientFiles(string FolderName)
    {
      StreamWriter streamWriter = new StreamWriter(FolderName + "\\IBSCategory.txt");
      try
      {
        streamWriter.AutoFlush = true;
        foreach (Structures.IBSCategory headCategory in this.HeadCategories)
        {
          string str = string.Empty + (object) headCategory.Index + "@" + headCategory.Name + "@" + (object) headCategory.Unk1 + "@" + (object) headCategory.Unk2 + "@" + (object) headCategory.HeadCatIndex + "@" + (object) headCategory.Seq + "@" + (object) Convert.ToInt16(headCategory.IsHeadCat);
          streamWriter.WriteLine(str);
        }
        foreach (Structures.IBSCategory subCategory in this.SubCategories)
        {
          string str = string.Empty + (object) subCategory.Index + "@" + subCategory.Name + "@" + (object) subCategory.Unk1 + "@" + (object) subCategory.Unk2 + "@" + (object) subCategory.HeadCatIndex + "@" + (object) subCategory.Seq + "@" + (object) Convert.ToInt16(subCategory.IsHeadCat);
          streamWriter.WriteLine(str);
        }
        streamWriter.Close();
        streamWriter = new StreamWriter(FolderName + "\\IBSPackage.txt");
        foreach (Structures.IBSPackage package in this.Packages)
        {
          string str = string.Empty + (object) package.CatIndex + "@" + (object) package.Seq + "@" + (object) package.Index + "@" + package.Name + "@" + (object) package.Unk1 + "@" + (object) package.Price + "@" + package.Info + "@" + package.Empty + "@" + (object) package.Unk2 + "@" + (object) package.Unk3 + "@" + package.Unk4 + "@" + package.Unk5 + "@" + (object) package.Unk6 + "@" + (object) package.RewardCount + "@" + package.CoinTxt1 + "@" + package.CoinTxt2 + "@" + (object) package.Unk7 + "@" + (object) package.Unk8 + "@" + (object) package.Unk9 + "@" + package.ProductRewardIndex1 + "@" + (object) package.ItemID + "@" + (object) package.Unk10 + "@" + (object) package.CheckBoxCount + "@" + package.ProductRewardIndexes7 + "@" + package.Unk11 + "@" + (object) package.ServerCatIndex + "@" + (object) package.Const669;
          streamWriter.WriteLine(str);
        }
        streamWriter.Close();
        streamWriter = new StreamWriter(FolderName + "\\IBSProduct.txt");
        foreach (Structures.IBSProduct product in (Collection<Structures.IBSProduct>) this.Products)
        {
          string str = string.Empty + (object) product.Index1 + "@" + product.Name + "@" + product.BuyTypeTxt1 + "@" + product.TypeCount + "@" + product.BuyTypeTxt2 + "@" + (object) product.Price + "@" + (object) product.Index7 + "@" + (object) product.Unk1 + "@" + (object) product.Unk2 + "@" + (object) product.Unk3 + "@" + (object) product.Unk4 + "@" + (object) product.Unk5 + "@" + (object) product.Unk6 + "@" + product.ItemID + "@" + product.Unk7 + "@" + product.Unk8 + "@" + product.Unk9;
          streamWriter.WriteLine(str);
        }
        streamWriter.Close();
        return true;
      }
      catch
      {
        streamWriter.Close();
        return false;
      }
    }

    private bool GenerateServerFiles(string FolderName)
    {
      StreamWriter streamWriter = new StreamWriter(FolderName + "\\IGCCashItemInfo.dat");
      try
      {
        streamWriter.AutoFlush = true;
        streamWriter.WriteLine("1");
        foreach (Structures.IGCCashItemInfo igcCashItemInfo in (Collection<Structures.IGCCashItemInfo>) this.ItemsInfo)
        {
          string str = string.Empty + (object) igcCashItemInfo.GID + "\t" + (object) igcCashItemInfo.ID + "\t" + (object) igcCashItemInfo.iGroup + "\t" + (object) igcCashItemInfo.iIndex + "\t" + (object) igcCashItemInfo.Level + "\t" + (object) igcCashItemInfo.Dur + "\t" + (object) igcCashItemInfo.Skill + "\t" + (object) igcCashItemInfo.Luck + "\t" + (object) igcCashItemInfo.Option + "\t" + (object) igcCashItemInfo.Exc + "\t" + (object) igcCashItemInfo.Ancient + "\t" + (object) igcCashItemInfo.Socket + "\t" + (object) igcCashItemInfo.Type + "\t" + (object) igcCashItemInfo.Period + "\t//" + igcCashItemInfo.Name;
          streamWriter.WriteLine(str);
        }
        streamWriter.WriteLine("end");
        streamWriter.Close();
        streamWriter = new StreamWriter(FolderName + "\\IGCCashItemList.dat");
        streamWriter.WriteLine("1");
        foreach (Structures.IGCCashItemList items in (Collection<Structures.IGCCashItemList>) this.ItemsList)
        {
          string str = string.Empty + (object) items.GUID + "\t" + (object) items.Index + "\t" + (object) items.SubIndex + "\t" + (object) items.iOpt + "\t" + (object) items.pID + "\t" + (object) items.cType + "\t" + (object) items.iPrice + "\t" + (object) items.iInfoGD + "\t" + (object) items.iInfoID + "\t" + (object) items.iCat + "\t" + (object) items.iGP + "\t" + (object) items.iSale + "\t" + (object) items.iRand + "\t//" + items.Name;
          streamWriter.WriteLine(str);
        }
        streamWriter.WriteLine("end");
        streamWriter.Close();
        streamWriter = new StreamWriter(FolderName + "\\IGCCashItemPackages.dat");
        streamWriter.WriteLine("1");
        foreach (Structures.IGCCashItemPackages cashItemPackages in (Collection<Structures.IGCCashItemPackages>) this.ItemsPackage)
        {
          string str = string.Empty + "\t" + (object) cashItemPackages.GUID + "\t" + (object) cashItemPackages.pID + "\t" + (object) cashItemPackages.iSeq + "\t" + (object) cashItemPackages.iGUID + "\t" + (object) cashItemPackages.iID + "\t//" + cashItemPackages.Name;
          streamWriter.WriteLine(str);
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

    private string GetFirstNull(object[,] theStrct, short sizeA, short sizeB)
    {
      for (int index1 = 0; index1 < (int) sizeA; ++index1)
      {
        for (int index2 = 0; index2 < (int) sizeB; ++index2)
        {
          if (theStrct[index1, index2] == null)
            return index1.ToString() + "x" + (object) index2;
        }
      }
      return (string) null;
    }

    public List<Structures.IBSPackage> GetSubCatItems(int SubCat)
    {
      List<Structures.IBSPackage> subCatItems = new List<Structures.IBSPackage>();
      foreach (Structures.IBSPackage package in this.Packages)
      {
        if ((int) package.CatIndex == SubCat)
          subCatItems.Add(package);
      }
      this.ItemPageCount = subCatItems.Count / 9 + 1;
      this.label_MaxPage.Text = this.ItemPageCount.ToString();
      return subCatItems;
    }

    public string GetUniqueString()
    {
      List<byte> byteList = new List<byte>();
      for (int index = 0; index < 36; ++index)
        byteList.Add((byte) this.rand.Next(0, (int) byte.MaxValue));
      return Convert.ToBase64String(byteList.ToArray());
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CashShopEditor));
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.saveToolStripMenuItem1 = new ToolStripMenuItem();
      this.serverFilesToolStripMenuItem = new ToolStripMenuItem();
      this.clientFilesToolStripMenuItem = new ToolStripMenuItem();
      this.editToolStripMenuItem = new ToolStripMenuItem();
      this.headCategoriesToolStripMenuItem = new ToolStripMenuItem();
      this.addNewToolStripMenuItem = new ToolStripMenuItem();
      this.subCategoriesToolStripMenuItem = new ToolStripMenuItem();
      this.addNewToolStripMenuItem1 = new ToolStripMenuItem();
      this.panel_ItemAdd = new Panel();
      this.groupBox2 = new GroupBox();
      this.comboBox_NewItem_CountType = new ComboBox();
      this.numericUpDown_NewItem_Count = new NumericUpDown();
      this.comboBox_NewItem_Coin = new ComboBox();
      this.numericUpDown_NewItem_Price = new NumericUpDown();
      this.textBox_NewItem_Name = new TextBox();
      this.label8 = new Label();
      this.richTextBox_NewItem_Info = new RichTextBox();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.groupBox1 = new GroupBox();
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
      this.panel_MainForm = new MyPanel();
      this.panel_SubCatEnd = new MyPanel();
      this.panel_CatFirst = new MyPanel();
      this.textBox_Cat1 = new TextBox();
      this.textBox_SubCat1 = new TextBox();
      this.label_MaxPage = new Label();
      this.panel_ItemsPage1 = new MyPanel();
      this.panel_Item = new MyPanel();
      this.label_ItemPrice = new Label();
      this.label_ItemName = new Label();
      this.pictureBox_ItemImg = new PictureBox();
      this.panel8 = new MyPanel();
      this.label_CurrPage = new Label();
      this.panel9 = new MyPanel();
      this.panel_NextPage = new MyPanel();
      this.panel_PrevPage = new MyPanel();
      this.panel_SubCat1 = new MyPanel();
      this.menuStrip1.SuspendLayout();
      this.panel_ItemAdd.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.numericUpDown_NewItem_Count.BeginInit();
      this.numericUpDown_NewItem_Price.BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox_NewItem_ExcOpt.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.numericUpDown_NewItem_SocketCount.BeginInit();
      this.groupBox6.SuspendLayout();
      this.numericUpDown_NewItem_Durability.BeginInit();
      ((ISupportInitialize) this.pictureBox_NewItem_ItemPreview).BeginInit();
      this.panel_MainForm.SuspendLayout();
      this.panel_CatFirst.SuspendLayout();
      this.panel_ItemsPage1.SuspendLayout();
      this.panel_Item.SuspendLayout();
      ((ISupportInitialize) this.pictureBox_ItemImg).BeginInit();
      this.SuspendLayout();
      this.menuStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.fileToolStripMenuItem,
        (ToolStripItem) this.editToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(694, 25);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.saveToolStripMenuItem1
      });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(39, 21);
      this.fileToolStripMenuItem.Text = "File";
      this.saveToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.serverFilesToolStripMenuItem,
        (ToolStripItem) this.clientFilesToolStripMenuItem
      });
      this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
      this.saveToolStripMenuItem1.Size = new Size(103, 22);
      this.saveToolStripMenuItem1.Text = "Save";
      this.serverFilesToolStripMenuItem.Name = "serverFilesToolStripMenuItem";
      this.serverFilesToolStripMenuItem.Size = new Size(142, 22);
      this.serverFilesToolStripMenuItem.Text = "Server Files";
      this.serverFilesToolStripMenuItem.Click += new EventHandler(this.serverToolStripMenuItem_Click);
      this.clientFilesToolStripMenuItem.Name = "clientFilesToolStripMenuItem";
      this.clientFilesToolStripMenuItem.Size = new Size(142, 22);
      this.clientFilesToolStripMenuItem.Text = "Client Files";
      this.clientFilesToolStripMenuItem.Click += new EventHandler(this.clientToolStripMenuItem_Click);
      this.editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.headCategoriesToolStripMenuItem,
        (ToolStripItem) this.subCategoriesToolStripMenuItem
      });
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new Size(42, 21);
      this.editToolStripMenuItem.Text = "Edit";
      this.headCategoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.addNewToolStripMenuItem
      });
      this.headCategoriesToolStripMenuItem.Name = "headCategoriesToolStripMenuItem";
      this.headCategoriesToolStripMenuItem.Size = new Size(174, 22);
      this.headCategoriesToolStripMenuItem.Text = "Head Categories";
      this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
      this.addNewToolStripMenuItem.Size = new Size(130, 22);
      this.addNewToolStripMenuItem.Text = "Add New";
      this.addNewToolStripMenuItem.Click += new EventHandler(this.addToolStripMenuItem_Cat_Click);
      this.subCategoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.addNewToolStripMenuItem1
      });
      this.subCategoriesToolStripMenuItem.Name = "subCategoriesToolStripMenuItem";
      this.subCategoriesToolStripMenuItem.Size = new Size(174, 22);
      this.subCategoriesToolStripMenuItem.Text = "Sub Categories";
      this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
      this.addNewToolStripMenuItem1.Size = new Size(130, 22);
      this.addNewToolStripMenuItem1.Text = "Add New";
      this.addNewToolStripMenuItem1.Click += new EventHandler(this.addToolStripMenuItem_SubCat_Click);
      this.panel_ItemAdd.BackgroundImage = (Image) Resources.panel_ItemAdd_BackgroundImage;
      this.panel_ItemAdd.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel_ItemAdd.Controls.Add((Control) this.groupBox2);
      this.panel_ItemAdd.Controls.Add((Control) this.groupBox1);
      this.panel_ItemAdd.Controls.Add((Control) this.button_NewItem_Add);
      this.panel_ItemAdd.Controls.Add((Control) this.pictureBox_NewItem_ItemPreview);
      this.panel_ItemAdd.Controls.Add((Control) this.listBox_NewItem_ItemIndex);
      this.panel_ItemAdd.Controls.Add((Control) this.listBox_NewItem_ItemGroup);
      this.panel_ItemAdd.Location = new Point(789, 25);
      this.panel_ItemAdd.Name = "panel_ItemAdd";
      this.panel_ItemAdd.Size = new Size(344, 666);
      this.panel_ItemAdd.TabIndex = 2;
      this.panel_ItemAdd.Visible = false;
      this.groupBox2.BackColor = Color.Transparent;
      this.groupBox2.Controls.Add((Control) this.comboBox_NewItem_CountType);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_NewItem_Count);
      this.groupBox2.Controls.Add((Control) this.comboBox_NewItem_Coin);
      this.groupBox2.Controls.Add((Control) this.numericUpDown_NewItem_Price);
      this.groupBox2.Controls.Add((Control) this.textBox_NewItem_Name);
      this.groupBox2.Controls.Add((Control) this.label8);
      this.groupBox2.Controls.Add((Control) this.richTextBox_NewItem_Info);
      this.groupBox2.Controls.Add((Control) this.label7);
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 177);
      this.groupBox2.ForeColor = Color.DarkGoldenrod;
      this.groupBox2.Location = new Point(20, 188);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(303, 145);
      this.groupBox2.TabIndex = 21;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Cash Shop Item Options";
      this.comboBox_NewItem_CountType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_NewItem_CountType.FormattingEnabled = true;
      this.comboBox_NewItem_CountType.Items.AddRange(new object[1]
      {
        (object) "Quantity"
      });
      this.comboBox_NewItem_CountType.Location = new Point(73, 117);
      this.comboBox_NewItem_CountType.Name = "comboBox_NewItem_CountType";
      this.comboBox_NewItem_CountType.Size = new Size(105, 21);
      this.comboBox_NewItem_CountType.TabIndex = 6;
      this.numericUpDown_NewItem_Count.Location = new Point(73, 94);
      this.numericUpDown_NewItem_Count.Name = "numericUpDown_NewItem_Count";
      this.numericUpDown_NewItem_Count.Size = new Size(105, 20);
      this.numericUpDown_NewItem_Count.TabIndex = 5;
      this.numericUpDown_NewItem_Count.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.comboBox_NewItem_Coin.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_NewItem_Coin.FormattingEnabled = true;
      this.comboBox_NewItem_Coin.Items.AddRange(new object[3]
      {
        (object) "W Coin (C)",
        (object) "W Coin (P)",
        (object) "Goblin Point"
      });
      this.comboBox_NewItem_Coin.Location = new Point(73, 69);
      this.comboBox_NewItem_Coin.Name = "comboBox_NewItem_Coin";
      this.comboBox_NewItem_Coin.Size = new Size(105, 21);
      this.comboBox_NewItem_Coin.TabIndex = 4;
      this.numericUpDown_NewItem_Price.Location = new Point(73, 46);
      this.numericUpDown_NewItem_Price.Maximum = new Decimal(new int[4]
      {
        2000000000,
        0,
        0,
        0
      });
      this.numericUpDown_NewItem_Price.Name = "numericUpDown_NewItem_Price";
      this.numericUpDown_NewItem_Price.Size = new Size(105, 20);
      this.numericUpDown_NewItem_Price.TabIndex = 3;
      this.textBox_NewItem_Name.Location = new Point(73, 21);
      this.textBox_NewItem_Name.Name = "textBox_NewItem_Name";
      this.textBox_NewItem_Name.Size = new Size(105, 20);
      this.textBox_NewItem_Name.TabIndex = 2;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(181, 15);
      this.label8.Name = "label8";
      this.label8.Size = new Size(113, 13);
      this.label8.TabIndex = 28;
      this.label8.Text = "Info:  # = New line";
      this.richTextBox_NewItem_Info.Location = new Point(184, 30);
      this.richTextBox_NewItem_Info.Name = "richTextBox_NewItem_Info";
      this.richTextBox_NewItem_Info.Size = new Size(110, 107);
      this.richTextBox_NewItem_Info.TabIndex = 7;
      this.richTextBox_NewItem_Info.Text = "";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(12, 72);
      this.label7.Name = "label7";
      this.label7.Size = new Size(36, 13);
      this.label7.TabIndex = 26;
      this.label7.Text = "Coin:";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(12, 120);
      this.label6.Name = "label6";
      this.label6.Size = new Size(55, 13);
      this.label6.TabIndex = 25;
      this.label6.Text = "Counter:";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(12, 24);
      this.label5.Name = "label5";
      this.label5.Size = new Size(43, 13);
      this.label5.TabIndex = 24;
      this.label5.Text = "Name:";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(12, 96);
      this.label2.Name = "label2";
      this.label2.Size = new Size(44, 13);
      this.label2.TabIndex = 23;
      this.label2.Text = "Count:";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 48);
      this.label1.Name = "label1";
      this.label1.Size = new Size(40, 13);
      this.label1.TabIndex = 22;
      this.label1.Text = "Price:";
      this.groupBox1.BackColor = Color.Transparent;
      this.groupBox1.Controls.Add((Control) this.groupBox_NewItem_ExcOpt);
      this.groupBox1.Controls.Add((Control) this.listBox_NewItem_ItemOption);
      this.groupBox1.Controls.Add((Control) this.checkBox_AddItem_FOItem);
      this.groupBox1.Controls.Add((Control) this.checkBox_NewItem_Luck);
      this.groupBox1.Controls.Add((Control) this.groupBox9);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.checkBox_NewItem_Skill);
      this.groupBox1.Controls.Add((Control) this.groupBox8);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.groupBox6);
      this.groupBox1.Controls.Add((Control) this.listBox_NewItem_ItemLevel);
      this.groupBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 177);
      this.groupBox1.ForeColor = Color.Goldenrod;
      this.groupBox1.Location = new Point(20, 339);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(303, 271);
      this.groupBox1.TabIndex = 20;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Item Properties";
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
      this.groupBox_NewItem_ExcOpt.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
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
      this.radioButton_NewItem_ExcWings.Size = new Size(55, 17);
      this.radioButton_NewItem_ExcWings.TabIndex = 13;
      this.radioButton_NewItem_ExcWings.Text = "Wings";
      this.radioButton_NewItem_ExcWings.UseVisualStyleBackColor = true;
      this.radioButton_NewItem_ExcArmor.AutoSize = true;
      this.radioButton_NewItem_ExcArmor.Location = new Point(83, 15);
      this.radioButton_NewItem_ExcArmor.Name = "radioButton_NewItem_ExcArmor";
      this.radioButton_NewItem_ExcArmor.Size = new Size(52, 17);
      this.radioButton_NewItem_ExcArmor.TabIndex = 12;
      this.radioButton_NewItem_ExcArmor.Text = "Armor";
      this.radioButton_NewItem_ExcArmor.UseVisualStyleBackColor = true;
      this.radioButton_NewItem_ExcWeapon.AutoSize = true;
      this.radioButton_NewItem_ExcWeapon.Location = new Point(11, 15);
      this.radioButton_NewItem_ExcWeapon.Name = "radioButton_NewItem_ExcWeapon";
      this.radioButton_NewItem_ExcWeapon.Size = new Size(66, 17);
      this.radioButton_NewItem_ExcWeapon.TabIndex = 11;
      this.radioButton_NewItem_ExcWeapon.Text = "Weapon";
      this.radioButton_NewItem_ExcWeapon.UseVisualStyleBackColor = true;
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
      this.listBox_NewItem_ItemOption.FormattingEnabled = true;
      this.listBox_NewItem_ItemOption.Location = new Point(52, 38);
      this.listBox_NewItem_ItemOption.Name = "listBox_NewItem_ItemOption";
      this.listBox_NewItem_ItemOption.Size = new Size(35, 134);
      this.listBox_NewItem_ItemOption.TabIndex = 9;
      this.checkBox_AddItem_FOItem.AutoSize = true;
      this.checkBox_AddItem_FOItem.BackColor = Color.Transparent;
      this.checkBox_AddItem_FOItem.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.checkBox_AddItem_FOItem.ForeColor = Color.LightSkyBlue;
      this.checkBox_AddItem_FOItem.Location = new Point(58, 184);
      this.checkBox_AddItem_FOItem.Name = "checkBox_AddItem_FOItem";
      this.checkBox_AddItem_FOItem.Size = new Size((int) sbyte.MaxValue, 17);
      this.checkBox_AddItem_FOItem.TabIndex = 10;
      this.checkBox_AddItem_FOItem.Text = "Exc FO+15+28+Luck";
      this.checkBox_AddItem_FOItem.UseVisualStyleBackColor = false;
      this.checkBox_NewItem_Luck.AutoSize = true;
      this.checkBox_NewItem_Luck.Location = new Point(240, 245);
      this.checkBox_NewItem_Luck.Name = "checkBox_NewItem_Luck";
      this.checkBox_NewItem_Luck.Size = new Size(54, 17);
      this.checkBox_NewItem_Luck.TabIndex = 24;
      this.checkBox_NewItem_Luck.Text = "Luck";
      this.checkBox_NewItem_Luck.UseVisualStyleBackColor = true;
      this.groupBox9.Controls.Add((Control) this.comboBox_Ancient);
      this.groupBox9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 177);
      this.groupBox9.ForeColor = Color.DarkCyan;
      this.groupBox9.Location = new Point(185, 171);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new Size(105, 46);
      this.groupBox9.TabIndex = 14;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Ancient ";
      this.comboBox_Ancient.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox_Ancient.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 177);
      this.comboBox_Ancient.ForeColor = SystemColors.ActiveCaptionText;
      this.comboBox_Ancient.FormattingEnabled = true;
      this.comboBox_Ancient.Location = new Point(6, 18);
      this.comboBox_Ancient.Name = "comboBox_Ancient";
      this.comboBox_Ancient.Size = new Size(94, 21);
      this.comboBox_Ancient.TabIndex = 20;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(6, 18);
      this.label3.Name = "label3";
      this.label3.Size = new Size(38, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Level";
      this.checkBox_NewItem_Skill.AutoSize = true;
      this.checkBox_NewItem_Skill.Location = new Point(240, 224);
      this.checkBox_NewItem_Skill.Name = "checkBox_NewItem_Skill";
      this.checkBox_NewItem_Skill.Size = new Size(50, 17);
      this.checkBox_NewItem_Skill.TabIndex = 23;
      this.checkBox_NewItem_Skill.Text = "Skill";
      this.checkBox_NewItem_Skill.UseVisualStyleBackColor = true;
      this.groupBox8.BackColor = Color.Transparent;
      this.groupBox8.Controls.Add((Control) this.numericUpDown_NewItem_SocketCount);
      this.groupBox8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.groupBox8.ForeColor = Color.BlueViolet;
      this.groupBox8.Location = new Point(58, 222);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new Size(95, 38);
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
      this.numericUpDown_NewItem_SocketCount.Size = new Size(45, 20);
      this.numericUpDown_NewItem_SocketCount.TabIndex = 21;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(44, 18);
      this.label4.Name = "label4";
      this.label4.Size = new Size(44, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Option";
      this.groupBox6.Controls.Add((Control) this.numericUpDown_NewItem_Durability);
      this.groupBox6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 177);
      this.groupBox6.ForeColor = Color.DarkKhaki;
      this.groupBox6.Location = new Point(157, 222);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(72, 38);
      this.groupBox6.TabIndex = 10;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Duration";
      this.numericUpDown_NewItem_Durability.Location = new Point(14, 14);
      this.numericUpDown_NewItem_Durability.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDown_NewItem_Durability.Name = "numericUpDown_NewItem_Durability";
      this.numericUpDown_NewItem_Durability.Size = new Size(45, 20);
      this.numericUpDown_NewItem_Durability.TabIndex = 22;
      this.numericUpDown_NewItem_Durability.Value = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.listBox_NewItem_ItemLevel.FormattingEnabled = true;
      this.listBox_NewItem_ItemLevel.Location = new Point(11, 38);
      this.listBox_NewItem_ItemLevel.Name = "listBox_NewItem_ItemLevel";
      this.listBox_NewItem_ItemLevel.Size = new Size(35, 186);
      this.listBox_NewItem_ItemLevel.TabIndex = 8;
      this.button_NewItem_Add.Location = new Point(20, 616);
      this.button_NewItem_Add.Name = "button_NewItem_Add";
      this.button_NewItem_Add.Size = new Size(303, 30);
      this.button_NewItem_Add.TabIndex = 25;
      this.button_NewItem_Add.Text = "Add";
      this.button_NewItem_Add.UseVisualStyleBackColor = true;
      this.pictureBox_NewItem_ItemPreview.BackColor = Color.Transparent;
      this.pictureBox_NewItem_ItemPreview.BorderStyle = BorderStyle.FixedSingle;
      this.pictureBox_NewItem_ItemPreview.Location = new Point(20, 104);
      this.pictureBox_NewItem_ItemPreview.Name = "pictureBox_NewItem_ItemPreview";
      this.pictureBox_NewItem_ItemPreview.Size = new Size(129, 79);
      this.pictureBox_NewItem_ItemPreview.TabIndex = 3;
      this.pictureBox_NewItem_ItemPreview.TabStop = false;
      this.listBox_NewItem_ItemIndex.FormattingEnabled = true;
      this.listBox_NewItem_ItemIndex.ItemHeight = 12;
      this.listBox_NewItem_ItemIndex.Location = new Point(155, 23);
      this.listBox_NewItem_ItemIndex.Name = "listBox_NewItem_ItemIndex";
      this.listBox_NewItem_ItemIndex.Size = new Size(168, 160);
      this.listBox_NewItem_ItemIndex.TabIndex = 1;
      this.listBox_NewItem_ItemGroup.FormattingEnabled = true;
      this.listBox_NewItem_ItemGroup.ItemHeight = 12;
      this.listBox_NewItem_ItemGroup.Location = new Point(20, 23);
      this.listBox_NewItem_ItemGroup.Name = "listBox_NewItem_ItemGroup";
      this.listBox_NewItem_ItemGroup.Size = new Size(129, 76);
      this.listBox_NewItem_ItemGroup.TabIndex = 0;
      this.panel_MainForm.BackgroundImage = (Image) Resources.panel_MainForm_BackgroundImage;
      this.panel_MainForm.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel_MainForm.Controls.Add((Control) this.panel_SubCatEnd);
      this.panel_MainForm.Controls.Add((Control) this.panel_CatFirst);
      this.panel_MainForm.Controls.Add((Control) this.textBox_SubCat1);
      this.panel_MainForm.Controls.Add((Control) this.label_MaxPage);
      this.panel_MainForm.Controls.Add((Control) this.panel_ItemsPage1);
      this.panel_MainForm.Controls.Add((Control) this.panel8);
      this.panel_MainForm.Controls.Add((Control) this.label_CurrPage);
      this.panel_MainForm.Controls.Add((Control) this.panel9);
      this.panel_MainForm.Controls.Add((Control) this.panel_NextPage);
      this.panel_MainForm.Controls.Add((Control) this.panel_PrevPage);
      this.panel_MainForm.Controls.Add((Control) this.panel_SubCat1);
      this.panel_MainForm.Location = new Point(0, 25);
      this.panel_MainForm.Name = "panel_MainForm";
      this.panel_MainForm.Size = new Size(694, 666);
      this.panel_MainForm.TabIndex = 0;
      this.panel_SubCatEnd.BackgroundImage = (Image) Resources.panel_SubCatEnd_BackgroundImage;
      this.panel_SubCatEnd.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel_SubCatEnd.Location = new Point(-5, 36);
      this.panel_SubCatEnd.Name = "panel_SubCatEnd";
      this.panel_SubCatEnd.Size = new Size(54, 73);
      this.panel_SubCatEnd.TabIndex = 2;
      this.panel_CatFirst.BackgroundImage = (Image) Resources.panel_CatFirst_BackgroundImage;
      this.panel_CatFirst.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel_CatFirst.Controls.Add((Control) this.textBox_Cat1);
      this.panel_CatFirst.Location = new Point(91, 0);
      this.panel_CatFirst.Name = "panel_CatFirst";
      this.panel_CatFirst.Size = new Size(119, 36);
      this.panel_CatFirst.TabIndex = 3;
      this.panel_CatFirst.Visible = false;
      this.textBox_Cat1.BackColor = Color.Black;
      this.textBox_Cat1.BorderStyle = BorderStyle.None;
      this.textBox_Cat1.Font = new Font("Arial Black", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 177);
      this.textBox_Cat1.ForeColor = Color.White;
      this.textBox_Cat1.Location = new Point(12, 6);
      this.textBox_Cat1.Name = "textBox_Cat1";
      this.textBox_Cat1.Size = new Size(91, 16);
      this.textBox_Cat1.TabIndex = 1;
      this.textBox_Cat1.TextAlign = HorizontalAlignment.Center;
      this.textBox_SubCat1.BackColor = Color.Black;
      this.textBox_SubCat1.BorderStyle = BorderStyle.None;
      this.textBox_SubCat1.Font = new Font("Arial Black", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 177);
      this.textBox_SubCat1.ForeColor = Color.White;
      this.textBox_SubCat1.Location = new Point(12, 142);
      this.textBox_SubCat1.Name = "textBox_SubCat1";
      this.textBox_SubCat1.Size = new Size(91, 16);
      this.textBox_SubCat1.TabIndex = 2;
      this.textBox_SubCat1.TextAlign = HorizontalAlignment.Center;
      this.textBox_SubCat1.Visible = false;
      this.label_MaxPage.AutoSize = true;
      this.label_MaxPage.BackColor = Color.Transparent;
      this.label_MaxPage.ForeColor = Color.White;
      this.label_MaxPage.Location = new Point(422, 627);
      this.label_MaxPage.Name = "label_MaxPage";
      this.label_MaxPage.Size = new Size(11, 12);
      this.label_MaxPage.TabIndex = 10;
      this.label_MaxPage.Text = "2";
      this.panel_ItemsPage1.BackgroundImage = (Image) Resources.panel_ItemsPage1_BackgroundImage;
      this.panel_ItemsPage1.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel_ItemsPage1.Controls.Add((Control) this.panel_Item);
      this.panel_ItemsPage1.Location = new Point(138, 44);
      this.panel_ItemsPage1.Name = "panel_ItemsPage1";
      this.panel_ItemsPage1.Size = new Size(537, 535);
      this.panel_ItemsPage1.TabIndex = 4;
      this.panel_Item.BackColor = Color.Transparent;
      this.panel_Item.Controls.Add((Control) this.label_ItemPrice);
      this.panel_Item.Controls.Add((Control) this.label_ItemName);
      this.panel_Item.Controls.Add((Control) this.pictureBox_ItemImg);
      this.panel_Item.Location = new Point(3, 5);
      this.panel_Item.Name = "panel_Item";
      this.panel_Item.Size = new Size(175, 151);
      this.panel_Item.TabIndex = 0;
      this.panel_Item.Visible = false;
      this.label_ItemPrice.ForeColor = Color.White;
      this.label_ItemPrice.Location = new Point(24, 126);
      this.label_ItemPrice.Name = "label_ItemPrice";
      this.label_ItemPrice.Size = new Size(128, 12);
      this.label_ItemPrice.TabIndex = 2;
      this.label_ItemPrice.Text = "label2";
      this.label_ItemName.ForeColor = Color.White;
      this.label_ItemName.Location = new Point(27, 13);
      this.label_ItemName.Name = "label_ItemName";
      this.label_ItemName.Size = new Size(117, 17);
      this.label_ItemName.TabIndex = 1;
      this.label_ItemName.Text = "label1";
      this.pictureBox_ItemImg.Location = new Point(13, 34);
      this.pictureBox_ItemImg.Name = "pictureBox_ItemImg";
      this.pictureBox_ItemImg.Size = new Size(145, 88);
      this.pictureBox_ItemImg.TabIndex = 0;
      this.pictureBox_ItemImg.TabStop = false;
      this.panel8.BackgroundImage = (Image) Resources.panel8_BackgroundImage;
      this.panel8.BackgroundImageLayout = ImageLayout.None;
      this.panel8.Location = new Point(682, 0);
      this.panel8.Name = "panel8";
      this.panel8.Size = new Size(12, 620);
      this.panel8.TabIndex = 0;
      this.label_CurrPage.AutoSize = true;
      this.label_CurrPage.BackColor = Color.Transparent;
      this.label_CurrPage.ForeColor = Color.White;
      this.label_CurrPage.Location = new Point(379, 627);
      this.label_CurrPage.Name = "label_CurrPage";
      this.label_CurrPage.Size = new Size(11, 12);
      this.label_CurrPage.TabIndex = 3;
      this.label_CurrPage.Text = "1";
      this.panel9.BackgroundImage = (Image) Resources.panel9_BackgroundImage;
      this.panel9.BackgroundImageLayout = ImageLayout.None;
      this.panel9.Location = new Point(0, 650);
      this.panel9.Name = "panel9";
      this.panel9.Size = new Size(647, 17);
      this.panel9.TabIndex = 9;
      this.panel_NextPage.BackColor = Color.Transparent;
      this.panel_NextPage.Location = new Point(444, 613);
      this.panel_NextPage.Name = "panel_NextPage";
      this.panel_NextPage.Size = new Size(35, 36);
      this.panel_NextPage.TabIndex = 6;
      this.panel_NextPage.Click += new EventHandler(this.panel_NextPage_Click);
      this.panel_PrevPage.BackColor = Color.Transparent;
      this.panel_PrevPage.Location = new Point(335, 616);
      this.panel_PrevPage.Name = "panel_PrevPage";
      this.panel_PrevPage.Size = new Size(35, 36);
      this.panel_PrevPage.TabIndex = 5;
      this.panel_PrevPage.Click += new EventHandler(this.panel_PrevPage_Click);
      this.panel_SubCat1.BackgroundImage = (Image) Resources.panel_SubCat1_BackgroundImage;
      this.panel_SubCat1.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel_SubCat1.Location = new Point(0, 0);
      this.panel_SubCat1.Name = "panel_SubCat1";
      this.panel_SubCat1.Size = new Size(69, 36);
      this.panel_SubCat1.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(694, 691);
      this.Controls.Add((Control) this.panel_ItemAdd);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.panel_MainForm);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (CashShopEditor);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "CashShop Editor";
      this.FormClosed += new FormClosedEventHandler(this.CashShopEditor_FormClosed);
      this.Load += new EventHandler(this.CashShopEditor_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panel_ItemAdd.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.numericUpDown_NewItem_Count.EndInit();
      this.numericUpDown_NewItem_Price.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox_NewItem_ExcOpt.ResumeLayout(false);
      this.groupBox_NewItem_ExcOpt.PerformLayout();
      this.groupBox9.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.numericUpDown_NewItem_SocketCount.EndInit();
      this.groupBox6.ResumeLayout(false);
      this.numericUpDown_NewItem_Durability.EndInit();
      ((ISupportInitialize) this.pictureBox_NewItem_ItemPreview).EndInit();
      this.panel_MainForm.ResumeLayout(false);
      this.panel_MainForm.PerformLayout();
      this.panel_CatFirst.ResumeLayout(false);
      this.panel_CatFirst.PerformLayout();
      this.panel_ItemsPage1.ResumeLayout(false);
      this.panel_Item.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox_ItemImg).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void itmPic_MouseClick(object sender, MouseEventArgs e)
    {
      Structures.CustomPictureBox customPictureBox = (Structures.CustomPictureBox) sender;
      string[] strArray1 = customPictureBox.Name.Split('_');
      if (e.Button == MouseButtons.Right)
      {
        if (MessageBox.Show("Are you sure you want to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        this.panel_ItemsPage1.Controls.RemoveByKey(strArray1[0] + "_" + strArray1[1] + "_" + strArray1[2]);
        foreach (string addedItem in this.AddedItems)
        {
          if (addedItem == customPictureBox.Name)
          {
            this.AddedItems.Remove(addedItem);
            this.RemoveItemPack(strArray1[3]);
            this.ItemsToAdd = this.GetSubCatItems(this.SelectedSubCat.Index);
            this.LoadItems(this.currPage);
            break;
          }
        }
      }
      else
      {
        if (e.Button != MouseButtons.Left)
          return;
        foreach (string addedItem in this.AddedItems)
        {
          if (addedItem == customPictureBox.Name)
          {
            string[] strArray2 = addedItem.Split('_')[3].Split('@');
            string empty = string.Empty;
            string str1 = strArray2[0];
            string str2 = strArray2[1];
            string str3 = strArray2[2];
            this.Selected_iInfo = new BindingList<Structures.IGCCashItemInfo>();
            this.Selected_iPack = new BindingList<Structures.IGCCashItemPackages>();
            this.Selected_iList = new BindingList<Structures.IGCCashItemList>();
            this.Selected_iPackage = new Structures.IBSPackage();
            this.Selected_iProduct = new BindingList<Structures.IBSProduct>();
            bool flag = false;
            foreach (Structures.IGCCashItemList items in (Collection<Structures.IGCCashItemList>) this.ItemsList)
            {
              if (items.Index.ToString() == str3 & items.iCat.ToString() == str1)
              {
                this.Selected_iList.Add(items);
                flag = true;
              }
            }
            if (!flag)
              break;
            if (this.Selected_iList[0].pID > 0)
            {
              foreach (Structures.IGCCashItemPackages cashItemPackages in (Collection<Structures.IGCCashItemPackages>) this.ItemsPackage)
              {
                if (cashItemPackages.pID == this.Selected_iList[0].pID)
                  this.Selected_iPack.Add(cashItemPackages);
              }
            }
            foreach (Structures.IGCCashItemInfo igcCashItemInfo in (Collection<Structures.IGCCashItemInfo>) this.ItemsInfo)
            {
              if (igcCashItemInfo.GID == this.Selected_iList[0].iInfoGD)
                this.Selected_iInfo.Add(igcCashItemInfo);
            }
            foreach (Structures.IBSProduct product in (Collection<Structures.IBSProduct>) this.Products)
            {
              if (this.Selected_iList[0].iInfoGD == product.Index1)
                this.Selected_iProduct.Add(product);
            }
            foreach (Structures.IBSPackage package in this.Packages)
            {
              if ((int) package.Index == this.Selected_iList[0].Index)
              {
                this.Selected_iPackage = package;
                break;
              }
            }
            ((Form_CashShop_AddItems) Application.OpenForms["Form_CashShop_AddItems"]).UpdateAddedItem();
            if (this.LastSelectedPB != null)
            {
              this.LastSelectedPB.BorderColor = Color.Transparent;
              this.LastSelectedPB.BorderStyle = BorderStyle.None;
            }
            customPictureBox.BorderStyle = BorderStyle.FixedSingle;
            customPictureBox.BorderColor = Color.Gold;
            this.LastSelectedPB = customPictureBox;
            break;
          }
        }
      }
    }

    private void LoadHeadCategories()
    {
      foreach (Structures.IBSCategory headCategory in this.HeadCategories)
        this.AddHeadCat(headCategory);
    }

    public void LoadItems(int Page)
    {
      for (int index = (Page - 1) * 9; index < (Page - 1) * 9 + 1; ++index)
      {
        try
        {
          this.RemoveAddedItems();
          this.ItemsStrct = new object[3, 3];
          this.AddedItems = new List<string>();
          this.AddItem(this.ItemsToAdd[index]);
          this.AddItem(this.ItemsToAdd[index + 1]);
          this.AddItem(this.ItemsToAdd[index + 2]);
          this.AddItem(this.ItemsToAdd[index + 3]);
          this.AddItem(this.ItemsToAdd[index + 4]);
          this.AddItem(this.ItemsToAdd[index + 5]);
          this.AddItem(this.ItemsToAdd[index + 6]);
          this.AddItem(this.ItemsToAdd[index + 7]);
          this.AddItem(this.ItemsToAdd[index + 8]);
        }
        catch
        {
        }
      }
    }

    private void LoadSubCategories(int HeadCatIndex)
    {
      this.isFirstSubCat = 0;
      this.RemoveAddedSubs();
      this.AddedSubCatName = new List<string>();
      this.AddedItems = new List<string>();
      this.LastClickedSubCatTB = (TextBox) null;
      this.SubCatCount = (short) 0;
      foreach (Structures.IBSCategory subCategory in this.SubCategories)
      {
        if (subCategory.HeadCatIndex == HeadCatIndex)
          this.AddSubCat(subCategory);
      }
    }

    private void nwTb_LostFocus(object sender, EventArgs e) => ((TextBoxBase) sender).ReadOnly = true;

    private void nwTbHeadCat_KeyDown(object sender, KeyEventArgs e)
    {
      TextBox textBox = (TextBox) sender;
      this.t1.Show("Press Enter to save new Category Name", (IWin32Window) textBox, 5000);
      if (e.KeyCode != Keys.Return)
        return;
      int index = this.HeadCategories.IndexOf(this.SelectedHeadCat);
      Structures.IBSCategory headCategory = this.HeadCategories[0];
      if (index != -1)
        headCategory = this.HeadCategories[index];
      headCategory.Name = textBox.Text;
      this.HeadCategories[index] = headCategory;
      this.SelectedHeadCat = headCategory;
      this.t1.Hide((IWin32Window) textBox);
    }

    private void nwTbHeadCat_MouseClick(object sender, MouseEventArgs e)
    {
      TextBox textBox = (TextBox) sender;
      textBox.ReadOnly = false;
      string[] strArray = textBox.Name.Split('_');
      short int16_1 = Convert.ToInt16(strArray[2]);
      short int16_2 = Convert.ToInt16(strArray[3]);
      foreach (Structures.IBSCategory headCategory in this.HeadCategories)
      {
        if ((int) int16_1 == (int) headCategory.Seq && (int) int16_2 == headCategory.Index)
        {
          this.LoadSubCategories(this.HeadCategories[this.HeadCategories.IndexOf(headCategory)].HeadCatIndex);
          this.ItemsToAdd = new List<Structures.IBSPackage>();
          foreach (Structures.IBSCategory subCategory in this.SubCategories)
          {
            if (headCategory.HeadCatIndex == subCategory.HeadCatIndex & subCategory.Seq == (short) 1)
            {
              this.ItemsToAdd = this.GetSubCatItems(subCategory.Index);
              this.currPage = 1;
              this.LoadItems(1);
              this.label_CurrPage.Text = "1";
              this.SelectedSubCat = subCategory;
              break;
            }
          }
          if (this.AddedSubCatName.Count == 0)
          {
            this.RemoveAddedItems();
            this.currPage = 1;
            this.label_CurrPage.Text = "1";
            this.label_MaxPage.Text = "1";
            this.ItemPageCount = 1;
            this.button_NewItem_Add.Enabled = false;
            this.panel_SubCatEnd.Location = new Point(0, Resources.pnl_NewSubCat2.Size.Height);
            if (this.HasChildren)
            {
              Form_CashShop_AddItems openForm = (Form_CashShop_AddItems) Application.OpenForms["Form_CashShop_AddItems"];
              if (openForm != null)
              {
                openForm.button_AddItemToDB.Enabled = false;
                openForm.button_NewItem_Add.Enabled = false;
                openForm.button_UpdateExistingItem.Enabled = false;
              }
            }
          }
          else
          {
            this.button_NewItem_Add.Enabled = true;
            if (this.HasChildren)
            {
              Form_CashShop_AddItems openForm = (Form_CashShop_AddItems) Application.OpenForms["Form_CashShop_AddItems"];
              if (openForm != null)
              {
                openForm.button_AddItemToDB.Enabled = true;
                openForm.button_NewItem_Add.Enabled = true;
                openForm.button_UpdateExistingItem.Enabled = true;
              }
            }
          }
          this.SelectedHeadCat = headCategory;
          break;
        }
      }
      textBox.ForeColor = Color.Gold;
      if (this.LastClickedCatTB != null & this.LastClickedCatTB.Name != textBox.Name)
        this.LastClickedCatTB.ForeColor = Color.White;
      this.LastClickedCatTB = textBox;
    }

    private void nwTbHeadCat_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to delete this Category?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      if (this.HasChildren)
      {
        Form_CashShop_AddItems openForm = (Form_CashShop_AddItems) Application.OpenForms["Form_CashShop_AddItems"];
        if (openForm != null)
        {
          openForm.button_AddItemToDB.Enabled = false;
          openForm.button_NewItem_Add.Enabled = false;
          openForm.button_UpdateExistingItem.Enabled = false;
        }
      }
      string[] strArray = ((Control) sender).Name.Split('_');
      short int16_1 = Convert.ToInt16(strArray[2]);
      short int16_2 = Convert.ToInt16(strArray[3]);
      List<Structures.IBSPackage> ibsPackageList = new List<Structures.IBSPackage>();
      List<string> stringList = new List<string>();
      List<Structures.IBSCategory> ibsCategoryList = new List<Structures.IBSCategory>();
      foreach (Structures.IBSCategory headCategory in this.HeadCategories)
      {
        if ((int) int16_1 == (int) headCategory.Seq & (int) int16_2 == headCategory.Index)
        {
          foreach (Structures.IBSCategory subCategory in this.SubCategories)
          {
            if (subCategory.HeadCatIndex == headCategory.Index)
            {
              List<Structures.IGCCashItemList> igcCashItemListList = new List<Structures.IGCCashItemList>();
              foreach (Structures.IBSPackage package in this.Packages)
              {
                if (subCategory.Index == (int) package.CatIndex)
                {
                  ibsPackageList.Add(package);
                  foreach (Structures.IGCCashItemList items in (Collection<Structures.IGCCashItemList>) this.ItemsList)
                  {
                    if (items.iCat == subCategory.Index && items.Index == (int) package.Index)
                    {
                      igcCashItemListList.Add(items);
                      if (items.TraceString != null && items.pID > 0)
                      {
                        List<Structures.IGCCashItemPackages> cashItemPackagesList = new List<Structures.IGCCashItemPackages>();
                        foreach (Structures.IGCCashItemPackages cashItemPackages in (Collection<Structures.IGCCashItemPackages>) this.ItemsPackage)
                        {
                          if (cashItemPackages.pID == items.pID)
                            cashItemPackagesList.Add(cashItemPackages);
                        }
                        for (int index = 0; index < cashItemPackagesList.Count; ++index)
                          this.ItemsPackage.Remove(cashItemPackagesList[index]);
                      }
                    }
                  }
                }
              }
              for (int index = 0; index < igcCashItemListList.Count; ++index)
                this.ItemsList.Remove(igcCashItemListList[index]);
              for (int index = 0; index < ibsPackageList.Count; ++index)
                this.Packages.Remove(ibsPackageList[index]);
              ibsCategoryList.Add(subCategory);
            }
          }
          for (int index = 0; index < ibsCategoryList.Count; ++index)
            this.SubCategories.Remove(ibsCategoryList[index]);
          this.panel_MainForm.Controls.RemoveByKey("pnl_Cat_" + (object) headCategory.Seq + "_" + (object) headCategory.Index);
          this.AddedCatName.Remove("pnl_Cat_" + (object) headCategory.Seq + "_" + (object) headCategory.Index);
          --this.CatCount;
          this.RemoveAddedItems();
          this.currPage = 1;
          this.ItemPageCount = 1;
          this.label_CurrPage.Text = "1";
          this.label_MaxPage.Text = "1";
          if (this.LastClickedCatTB != null)
            this.LastClickedCatTB.ForeColor = Color.White;
          this.RemoveAddedSubs();
          this.AddedSubCatName = new List<string>();
          this.AddedItems = new List<string>();
          this.LastClickedSubCatTB = (TextBox) null;
          this.SelectedSubCat = new Structures.IBSCategory();
          this.SelectedHeadCat = new Structures.IBSCategory();
          this.SubCatCount = (short) 0;
          this.panel_SubCatEnd.Location = new Point(0, this.panel_SubCat1.Location.Y + this.panel_SubCat1.Size.Height);
          this.RemoveAddedHeadCat();
          this.HeadCategories.Remove(headCategory);
          break;
        }
      }
      for (int index = 0; index < this.HeadCategories.Count; ++index)
      {
        Structures.IBSCategory headCategory = this.HeadCategories[index] with
        {
          Seq = (short) (index + 1)
        };
        this.HeadCategories[index] = headCategory;
      }
      this.LoadHeadCategories();
      this.button_NewItem_Add.Enabled = false;
    }

    private void nwTbSubCat_KeyDown(object sender, KeyEventArgs e)
    {
      TextBox textBox = (TextBox) sender;
      this.t2.Show("Press Enter to save new Category Name", (IWin32Window) textBox, 5000);
      if (e.KeyCode != Keys.Return)
        return;
      int index = this.SubCategories.IndexOf(this.SelectedSubCat);
      Structures.IBSCategory subCategory = this.SubCategories[index] with
      {
        Name = textBox.Text
      };
      this.SubCategories[index] = subCategory;
      this.SelectedSubCat = subCategory;
      this.t2.Hide((IWin32Window) textBox);
    }

    private void nwTbSubCat_MouseClick(object sender, MouseEventArgs e)
    {
      if (this.HasChildren)
      {
        Form_CashShop_AddItems openForm = (Form_CashShop_AddItems) Application.OpenForms["Form_CashShop_AddItems"];
        if (openForm != null)
        {
          openForm.button_AddItemToDB.Enabled = true;
          openForm.button_NewItem_Add.Enabled = true;
          openForm.button_UpdateExistingItem.Enabled = true;
        }
      }
      TextBox textBox = (TextBox) sender;
      textBox.ReadOnly = false;
      string[] strArray = textBox.Name.Split('_');
      short int16_1 = Convert.ToInt16(strArray[2]);
      short int16_2 = Convert.ToInt16(strArray[3]);
      this.ItemsToAdd = new List<Structures.IBSPackage>();
      foreach (Structures.IBSCategory subCategory in this.SubCategories)
      {
        if ((int) int16_1 == (int) subCategory.Seq & (int) int16_2 == subCategory.Index)
        {
          this.ItemsToAdd = this.GetSubCatItems(subCategory.Index);
          this.currPage = 1;
          this.LoadItems(1);
          this.label_CurrPage.Text = "1";
          this.SelectedSubCat = subCategory;
          break;
        }
      }
      textBox.ForeColor = Color.Gold;
      if (this.LastClickedSubCatTB != null & this.LastClickedSubCatTB.Name != textBox.Name)
        this.LastClickedSubCatTB.ForeColor = Color.White;
      this.LastClickedSubCatTB = textBox;
    }

    private void nwTbSubCat_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to delete this Category?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      if (this.HasChildren)
      {
        Form_CashShop_AddItems openForm = (Form_CashShop_AddItems) Application.OpenForms["Form_CashShop_AddItems"];
        if (openForm != null)
        {
          openForm.button_AddItemToDB.Enabled = false;
          openForm.button_NewItem_Add.Enabled = false;
          openForm.button_UpdateExistingItem.Enabled = false;
        }
      }
      string[] strArray = ((Control) sender).Name.Split('_');
      short int16_1 = Convert.ToInt16(strArray[2]);
      short int16_2 = Convert.ToInt16(strArray[3]);
      List<Structures.IBSPackage> ibsPackageList = new List<Structures.IBSPackage>();
      List<string> stringList = new List<string>();
      foreach (Structures.IBSCategory subCategory in this.SubCategories)
      {
        if ((int) int16_1 == (int) subCategory.Seq & (int) int16_2 == subCategory.Index)
        {
          List<Structures.IGCCashItemList> igcCashItemListList = new List<Structures.IGCCashItemList>();
          foreach (Structures.IBSPackage package in this.Packages)
          {
            if (subCategory.Index == (int) package.CatIndex)
            {
              ibsPackageList.Add(package);
              foreach (Structures.IGCCashItemList items in (Collection<Structures.IGCCashItemList>) this.ItemsList)
              {
                if (items.iCat == subCategory.Index && items.Index == (int) package.Index)
                {
                  igcCashItemListList.Add(items);
                  if (items.TraceString != null && items.pID > 0)
                  {
                    List<Structures.IGCCashItemPackages> cashItemPackagesList = new List<Structures.IGCCashItemPackages>();
                    foreach (Structures.IGCCashItemPackages cashItemPackages in (Collection<Structures.IGCCashItemPackages>) this.ItemsPackage)
                    {
                      if (cashItemPackages.pID == items.pID)
                        cashItemPackagesList.Add(cashItemPackages);
                    }
                    for (int index = 0; index < cashItemPackagesList.Count; ++index)
                      this.ItemsPackage.Remove(cashItemPackagesList[index]);
                  }
                }
              }
            }
          }
          for (int index = 0; index < igcCashItemListList.Count; ++index)
            this.ItemsList.Remove(igcCashItemListList[index]);
          for (int index = 0; index < ibsPackageList.Count; ++index)
            this.Packages.Remove(ibsPackageList[index]);
          this.panel_MainForm.Controls.RemoveByKey("pnl_SubCat_" + (object) subCategory.Seq + "_" + (object) subCategory.Index);
          this.AddedSubCatName.Remove("pnl_SubCat_" + (object) subCategory.Seq + "_" + (object) subCategory.Index);
          --this.SubCatCount;
          this.RemoveAddedItems();
          this.currPage = 1;
          this.ItemPageCount = 1;
          this.label_CurrPage.Text = "1";
          this.label_MaxPage.Text = "1";
          if (this.LastClickedSubCatTB != null)
            this.LastClickedSubCatTB.ForeColor = Color.White;
          this.SelectedSubCat = new Structures.IBSCategory();
          this.panel_SubCatEnd.Location = new Point(0, this.panel_SubCatEnd.Location.Y - Resources.pnl_NewSubCat2.Size.Height);
          this.SubCategories.Remove(subCategory);
          this.RemoveAddedSubs();
          this.LoadSubCategories(this.SelectedHeadCat.Index);
          break;
        }
      }
      this.button_NewItem_Add.Enabled = false;
    }

    private void panel_NextPage_Click(object sender, EventArgs e)
    {
      if (this.currPage + 1 > this.ItemPageCount)
        return;
      ++this.currPage;
      this.label_CurrPage.Text = this.currPage.ToString();
      this.LoadItems(this.currPage);
    }

    private void panel_PrevPage_Click(object sender, EventArgs e)
    {
      if (this.currPage - 1 == 0)
        return;
      --this.currPage;
      this.label_CurrPage.Text = this.currPage.ToString();
      this.LoadItems(this.currPage);
    }

    private void ReadCSFiles()
    {
      foreach (string readAllLine in File.ReadAllLines("Data\\IGCCashItemList.dat"))
      {
        if (!readAllLine.StartsWith("//") && readAllLine.Trim().Length != 0)
        {
          string[] strArray1 = readAllLine.Split('/');
          string str1 = readAllLine;
          if (strArray1.Length > 2)
          {
            string str2 = strArray1[2].Replace(" ", "$").Replace("\t", "$");
            str1 = strArray1[0] + "//" + str2;
          }
          string[] strArray2 = str1.Replace(" ", "\t").Split('\t');
          List<string> stringList = new List<string>();
          foreach (string str3 in strArray2)
          {
            if (str3.Length > 0)
              stringList.Add(str3);
          }
          string[] array = stringList.ToArray();
          if (array.Length >= 13)
          {
            Structures.IGCCashItemList igcCashItemList = new Structures.IGCCashItemList()
            {
              GUID = Convert.ToInt32(array[0]),
              Index = Convert.ToInt32(array[1]),
              SubIndex = Convert.ToInt32(array[2]),
              iOpt = Convert.ToInt32(array[3]),
              pID = Convert.ToInt32(array[4]),
              cType = Convert.ToInt32(array[5]),
              iPrice = Convert.ToInt32(array[6]),
              iInfoGD = Convert.ToInt32(array[7]),
              iInfoID = Convert.ToInt32(array[8]),
              iCat = Convert.ToInt32(array[9]),
              iGP = Convert.ToInt32(array[10]),
              iSale = Convert.ToInt32(array[11]),
              iRand = Convert.ToInt32(array[12]),
              TraceString = this.GetUniqueString()
            };
            if (array.Length > 13)
              igcCashItemList.Name = array[13].Trim('/').Replace("$", " ");
            if (igcCashItemList.GUID > this.MaxItemListGID)
              this.MaxItemListGID = igcCashItemList.GUID;
            this.IGC_CashItemList_Indexes.Add(igcCashItemList.Index.ToString());
            this.ItemsList.Add(igcCashItemList);
          }
        }
      }
      foreach (string readAllLine in File.ReadAllLines("Data\\IGCCashItemInfo.dat"))
      {
        if (!readAllLine.StartsWith("//") && readAllLine.Trim().Length != 0)
        {
          string[] strArray3 = readAllLine.Split('/');
          string str4 = readAllLine;
          if (strArray3.Length > 2)
          {
            string str5 = strArray3[2].Replace(" ", "$").Replace("\t", "$");
            str4 = strArray3[0] + "//" + str5;
          }
          string[] strArray4 = str4.Replace(" ", "\t").Split('\t');
          List<string> stringList = new List<string>();
          foreach (string str6 in strArray4)
          {
            if (str6.Length > 0)
              stringList.Add(str6);
          }
          string[] array = stringList.ToArray();
          if (array.Length >= 14)
          {
            Structures.IGCCashItemInfo igcCashItemInfo = new Structures.IGCCashItemInfo()
            {
              GID = Convert.ToInt32(array[0]),
              ID = Convert.ToInt32(array[1]),
              iGroup = Convert.ToInt32(array[2]),
              iIndex = Convert.ToInt32(array[3]),
              Level = Convert.ToInt32(array[4]),
              Dur = Convert.ToInt32(array[5]),
              Skill = Convert.ToInt32(array[6]),
              Luck = Convert.ToInt32(array[7]),
              Option = Convert.ToInt32(array[8]),
              Exc = Convert.ToInt32(array[9]),
              Ancient = Convert.ToInt32(array[10]),
              Socket = Convert.ToInt32(array[11]),
              Type = Convert.ToInt32(array[12]),
              Period = Convert.ToInt32(array[13]),
              TraceString = this.GetUniqueString()
            };
            if (array.Length > 14)
              igcCashItemInfo.Name = array[14].Trim('/').Replace("$", " ");
            this.IGC_CashItemInfo_Indexes.Add(igcCashItemInfo.GID.ToString() + (object) ',' + igcCashItemInfo.ID.ToString());
            this.ItemsInfo.Add(igcCashItemInfo);
          }
        }
      }
      foreach (string readAllLine in File.ReadAllLines("Data\\IGCCashItemPackages.dat"))
      {
        if (!readAllLine.StartsWith("//") && readAllLine.Trim().Length != 0)
        {
          string[] strArray5 = readAllLine.Split('/');
          string str7 = readAllLine;
          if (strArray5.Length > 2)
          {
            string str8 = strArray5[2].Replace(" ", "$").Replace("\t", "$");
            str7 = strArray5[0] + "//" + str8;
          }
          string[] strArray6 = str7.Replace(" ", "\t").Split('\t');
          List<string> stringList = new List<string>();
          foreach (string str9 in strArray6)
          {
            if (str9.Length > 0)
              stringList.Add(str9);
          }
          string[] array = stringList.ToArray();
          if (array.Length >= 5 && !array[0].StartsWith("//"))
          {
            Structures.IGCCashItemPackages cashItemPackages = new Structures.IGCCashItemPackages()
            {
              GUID = Convert.ToInt32(array[0]),
              pID = Convert.ToInt32(array[1]),
              iSeq = Convert.ToInt32(array[2]),
              iGUID = Convert.ToInt32(array[3]),
              iID = Convert.ToInt32(array[4]),
              TraceString = this.GetUniqueString()
            };
            if (array.Length > 5)
              cashItemPackages.Name = array[5].Trim('/').Replace("$", " ");
            this.IGC_CashItemPackages_Indexes.Add(cashItemPackages.GUID.ToString() + (object) ',' + cashItemPackages.iGUID.ToString());
            if (cashItemPackages.pID > this.MaxPackageID)
              this.MaxPackageID = cashItemPackages.pID + 1;
            this.ItemsPackage.Add(cashItemPackages);
          }
        }
      }
      foreach (string readAllLine in File.ReadAllLines("Data\\IBSCategory.txt"))
      {
        char[] chArray = new char[1]{ '@' };
        string[] strArray = readAllLine.Split(chArray);
        Structures.IBSCategory ibsCategory = new Structures.IBSCategory()
        {
          Index = (int) Convert.ToInt16(strArray[0]),
          Name = strArray[1],
          Unk1 = Convert.ToInt16(strArray[2]),
          Unk2 = Convert.ToInt16(strArray[3]),
          HeadCatIndex = (int) Convert.ToInt16(strArray[4]),
          Seq = Convert.ToInt16(strArray[5]),
          IsHeadCat = Convert.ToBoolean(Convert.ToInt16(strArray[6])),
          TraceString = this.GetUniqueString()
        };
        if (ibsCategory.IsHeadCat)
          this.HeadCategories.Add(ibsCategory);
        else
          this.SubCategories.Add(ibsCategory);
        if (ibsCategory.Index > this.MaxCategoryIndex)
          this.MaxCategoryIndex = ibsCategory.Index;
        if (ibsCategory.Index > this.MaxHeadCatIndex & ibsCategory.IsHeadCat)
          this.MaxHeadCatIndex = ibsCategory.Index;
      }
      foreach (string readAllLine in File.ReadAllLines("Data\\IBSPackage.txt"))
      {
        char[] chArray = new char[1]{ '@' };
        string[] strArray = readAllLine.Split(chArray);
        Structures.IBSPackage ibsPackage = new Structures.IBSPackage()
        {
          CatIndex = Convert.ToInt16(strArray[0]),
          Seq = Convert.ToInt16(strArray[1]),
          Index = Convert.ToInt16(strArray[2])
        };
        if (this.IGC_CashItemList_Indexes.Contains(ibsPackage.Index.ToString()))
        {
          ibsPackage.Name = strArray[3];
          ibsPackage.Unk1 = Convert.ToInt16(strArray[4]);
          ibsPackage.Price = Convert.ToInt32(strArray[5]);
          ibsPackage.Info = strArray[6];
          ibsPackage.Empty = strArray[7];
          ibsPackage.Unk2 = Convert.ToInt16(strArray[8]);
          ibsPackage.Unk3 = Convert.ToInt16(strArray[9]);
          ibsPackage.Unk4 = strArray[10];
          ibsPackage.Unk5 = strArray[11];
          ibsPackage.Unk6 = Convert.ToInt16(strArray[12]);
          ibsPackage.RewardCount = Convert.ToInt16(strArray[13]);
          ibsPackage.CoinTxt1 = strArray[14];
          ibsPackage.CoinTxt2 = strArray[15];
          ibsPackage.Unk7 = Convert.ToInt16(strArray[16]);
          ibsPackage.Unk8 = Convert.ToInt16(strArray[17]);
          ibsPackage.Unk9 = Convert.ToInt16(strArray[18]);
          ibsPackage.ProductRewardIndex1 = strArray[19];
          ibsPackage.ItemID = Convert.ToInt32(strArray[20]);
          ibsPackage.Unk10 = Convert.ToInt16(strArray[21]);
          ibsPackage.CheckBoxCount = Convert.ToInt16(strArray[22]);
          ibsPackage.ProductRewardIndexes7 = strArray[23];
          ibsPackage.Unk11 = strArray[24];
          ibsPackage.ServerCatIndex = Convert.ToInt32(strArray[25]);
          ibsPackage.Const669 = Convert.ToInt32(strArray[26]);
          ibsPackage.TraceString = this.GetUniqueString();
          this.Packages.Add(ibsPackage);
          if ((int) ibsPackage.Index > this.PackageMaxIndex)
            this.PackageMaxIndex = (int) ibsPackage.Index;
        }
      }
      List<string> stringList1 = new List<string>();
      foreach (string readAllLine in File.ReadAllLines("Data\\IBSProduct.txt"))
      {
        char[] chArray = new char[1]{ '@' };
        string[] strArray = readAllLine.Split(chArray);
        Structures.IBSProduct ibsProduct = new Structures.IBSProduct()
        {
          Index1 = Convert.ToInt32(strArray[0]),
          Name = strArray[1],
          BuyTypeTxt1 = strArray[2],
          TypeCount = strArray[3],
          BuyTypeTxt2 = strArray[4],
          Price = Convert.ToInt32(strArray[5]),
          Index7 = Convert.ToInt32(strArray[6]),
          Unk1 = Convert.ToInt16(strArray[7]),
          Unk2 = Convert.ToInt16(strArray[8]),
          Unk3 = Convert.ToInt16(strArray[9]),
          Unk4 = Convert.ToInt16(strArray[10]),
          Unk5 = Convert.ToInt16(strArray[11]),
          Unk6 = Convert.ToInt16(strArray[12]),
          ItemID = strArray[13],
          Unk7 = strArray[14],
          Unk8 = strArray[15],
          Unk9 = strArray[16],
          TraceString = this.GetUniqueString()
        };
        if (this.IGC_CashItemInfo_Indexes.Contains(ibsProduct.Index1.ToString() + (object) ',' + ibsProduct.Index7.ToString()) && !stringList1.Contains(ibsProduct.Index1.ToString() + "$" + (object) ibsProduct.Index7))
        {
          stringList1.Add(ibsProduct.Index1.ToString() + "$" + (object) ibsProduct.Index7);
          this.Products.Add(ibsProduct);
          if (ibsProduct.Index7 > this.ProductMaxIndex7)
            this.ProductMaxIndex7 = ibsProduct.Index7;
          if (ibsProduct.Index1 > this.ProductMaxIndex1)
            this.ProductMaxIndex1 = ibsProduct.Index1;
        }
      }
    }

    private void RemoveAddedHeadCat()
    {
      List<string> stringList = new List<string>();
      foreach (Control control in (ArrangedElementCollection) this.panel_MainForm.Controls)
      {
        if (control.Name.Contains("pnl_Cat_"))
          stringList.Add(control.Name);
      }
      foreach (string key in stringList)
        this.panel_MainForm.Controls.RemoveByKey(key);
      this.CatCount = (short) 0;
    }

    public void RemoveAddedItems()
    {
      List<string> stringList = new List<string>();
      foreach (Control control in (ArrangedElementCollection) this.panel_ItemsPage1.Controls)
      {
        if (control.Name != "panel_Item")
          stringList.Add(control.Name);
      }
      foreach (string key in stringList)
        this.panel_ItemsPage1.Controls.RemoveByKey(key);
    }

    private void RemoveAddedSubs()
    {
      List<string> stringList = new List<string>();
      foreach (Control control in (ArrangedElementCollection) this.panel_MainForm.Controls)
      {
        if (control.Name.Contains("pnl_SubCat") || control.Name.Contains("txtb_Cat_"))
          stringList.Add(control.Name);
      }
      foreach (string key in stringList)
        this.panel_MainForm.Controls.RemoveByKey(key);
      this.SubCatCount = (short) 0;
    }

    private void RemoveItemPack(string ValueToSearch)
    {
      string[] strArray = ValueToSearch.Split('@');
      short int16_1 = Convert.ToInt16(strArray[0]);
      short int16_2 = Convert.ToInt16(strArray[1]);
      short int16_3 = Convert.ToInt16(strArray[2]);
      List<Structures.IBSPackage> ibsPackageList = new List<Structures.IBSPackage>();
      List<Structures.IGCCashItemList> igcCashItemListList = new List<Structures.IGCCashItemList>();
      foreach (Structures.IBSPackage package in this.Packages)
      {
        if ((int) int16_1 == (int) package.CatIndex && (int) int16_2 == (int) package.Seq && (int) package.Index == (int) int16_3)
        {
          ibsPackageList.Add(package);
          using (IEnumerator<Structures.IGCCashItemList> enumerator = this.ItemsList.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              Structures.IGCCashItemList current = enumerator.Current;
              if (current.iCat == (int) int16_1 && current.Index == (int) package.Index)
              {
                igcCashItemListList.Add(current);
                if (current.TraceString != null && current.pID > 0)
                {
                  List<Structures.IGCCashItemPackages> cashItemPackagesList = new List<Structures.IGCCashItemPackages>();
                  foreach (Structures.IGCCashItemPackages cashItemPackages in (Collection<Structures.IGCCashItemPackages>) this.ItemsPackage)
                  {
                    if (cashItemPackages.pID == current.pID)
                      cashItemPackagesList.Add(cashItemPackages);
                  }
                  for (int index = 0; index < cashItemPackagesList.Count; ++index)
                    this.ItemsPackage.Remove(cashItemPackagesList[index]);
                }
              }
            }
            break;
          }
        }
      }
      for (int index = 0; index < igcCashItemListList.Count; ++index)
        this.ItemsList.Remove(igcCashItemListList[index]);
      for (int index = 0; index < ibsPackageList.Count; ++index)
        this.Packages.Remove(ibsPackageList[index]);
    }

    private void serverToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string str = "Saved Data\\CashShop Editor\\Server Files\\" + DateTime.Now.ToLocalTime().ToString().Replace('/', '.').Replace(':', '-').Replace(" ", " [") + "]";
      Directory.CreateDirectory(str);
      if (!this.GenerateServerFiles(str) || MessageBox.Show("Files saved successfully in\n\"" + str + "\"\n\nOpen containing folder?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(str);
    }

    public void UpdateSelectedItem(Structures.CustomPictureBox pnl)
    {
      foreach (string addedItem in this.AddedItems)
      {
        if (addedItem == pnl.Name)
        {
          string[] strArray = addedItem.Split('_')[3].Split('@');
          string empty = string.Empty;
          string str1 = strArray[0];
          string str2 = strArray[1];
          string str3 = strArray[2];
          this.Selected_iInfo = new BindingList<Structures.IGCCashItemInfo>();
          this.Selected_iPack = new BindingList<Structures.IGCCashItemPackages>();
          this.Selected_iList = new BindingList<Structures.IGCCashItemList>();
          this.Selected_iPackage = new Structures.IBSPackage();
          this.Selected_iProduct = new BindingList<Structures.IBSProduct>();
          bool flag = false;
          foreach (Structures.IGCCashItemList items in (Collection<Structures.IGCCashItemList>) this.ItemsList)
          {
            if (items.Index.ToString() == str3 & items.iCat.ToString() == str1)
            {
              this.Selected_iList.Add(items);
              flag = true;
            }
          }
          if (!flag)
            break;
          if (this.Selected_iList[0].pID > 0)
          {
            foreach (Structures.IGCCashItemPackages cashItemPackages in (Collection<Structures.IGCCashItemPackages>) this.ItemsPackage)
            {
              if (cashItemPackages.pID == this.Selected_iList[0].pID)
                this.Selected_iPack.Add(cashItemPackages);
            }
          }
          foreach (Structures.IGCCashItemInfo igcCashItemInfo in (Collection<Structures.IGCCashItemInfo>) this.ItemsInfo)
          {
            if (igcCashItemInfo.GID == this.Selected_iList[0].iInfoGD)
              this.Selected_iInfo.Add(igcCashItemInfo);
          }
          foreach (Structures.IBSProduct product in (Collection<Structures.IBSProduct>) this.Products)
          {
            if (this.Selected_iList[0].iInfoGD == product.Index1)
              this.Selected_iProduct.Add(product);
          }
          foreach (Structures.IBSPackage package in this.Packages)
          {
            if ((int) package.Index == this.Selected_iList[0].Index)
            {
              this.Selected_iPackage = package;
              break;
            }
          }
          ((Form_CashShop_AddItems) Application.OpenForms["Form_CashShop_AddItems"]).UpdateAddedItem();
          if (this.LastSelectedPB != null)
          {
            this.LastSelectedPB.BorderColor = Color.Transparent;
            this.LastSelectedPB.BorderStyle = BorderStyle.None;
          }
          pnl.BorderStyle = BorderStyle.FixedSingle;
          pnl.BorderColor = Color.Gold;
          this.LastSelectedPB = pnl;
          break;
        }
      }
    }
  }
}
