// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.Form1
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MU_ToolKit
{
  public class Form1 : Form
  {
    private ToolStripMenuItem aboutToolStripMenuItem;
    private BackgroundWorker backgroundWorker;
    private ToolStripMenuItem cashShopToolStripMenuItem;
    private ToolStripMenuItem clientToolStripMenuItem;
    private IContainer components;
    private ToolStripMenuItem computeIGCCRCToolStripMenuItem;
    private ToolStripMenuItem configToolStripMenuItem;
    private byte[] endBytes = new byte[4];
    private ToolStripMenuItem eventBagToolStripMenuItem;
    private ToolStripMenuItem ex700ItemList_ToolStripMenuItem_ON;
    private ToolStripMenuItem ex700ToolStripMenuItem_NpcNameEx700BMD;
    private ToolStripMenuItem ex700ToolStripMenuItem_NpcNameEx700PlusBMD;
    private ToolStripMenuItem ex700ToolStripMenuItem_ServerListBMD;
    private ToolStripMenuItem filterbmdToolStripMenuItem_Load;
    private DataGridView Filterdgv;
    private ToolStripMenuItem filterNamebmdToolStripMenuItem_Load;
    private DataGridView FilterNamedgv;
    private object[,] fStruct;
    private ToolStripMenuItem gatebmdToolStripMenuItem_Load;
    private DataGridView Gatedgv;
    private ToolStripMenuItem glowbmdToolStripMenuItem_Load;
    private DataGridView Glowdgv;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem iGCDropManagerEditorToolStripMenuItem;
    public bool isEx700ItemList = true;
    public bool isIGCCustomBMD;
    private bool isLeaveOpenItemAdder;
    private bool isNewRow;
    private bool isPasteFromCP;
    private ToolStripMenuItem itemAddOptionbmdToolStripMenuItem;
    private ToolStripMenuItem ItemEx700PlusToolStripMenuItem_Load;
    private ToolStripMenuItem ItemEx700ToolStripMenuItem_Load;
    private ToolStripMenuItem itemListSettingsTypeToolStripMenuItem;
    private ToolStripMenuItem itemSetOptionbmdToolStripMenuItem;
    private DataGridView ItemSetOptiondgv;
    private ToolStripMenuItem itemSetTypebmdToolStripMenuItem;
    private DataGridView ItemToolTipTextdgv;
    private ToolStripMenuItem itemToolTipTextToolStripMenuItem_Load;
    private ToolStripMenuItem itemToolTipToolStripMenuItem;
    private ToolStripMenuItem jewelOfHarmonySmeltbmdToolStripMenuItem;
    private TabPage LastSelectedItemGroup;
    private MenuStrip menuStrip1;
    private DataGridView Minimapdgv;
    private ToolStripMenuItem minimapWorldXbmdToolStripMenuItem_Load;
    private DataGridView Mixdgv;
    private ToolStripMenuItem mixToolStripMenuItem_Load;
    private int Model_sBlockSize = 100;
    private int Model_sSize;
    private int Monster_sBlockSize = 59;
    private int Monster_sSize;
    private ToolStripMenuItem monsterbmdToolStripMenuItem_Load;
    private DataGridView Monsterdgv;
    private ToolStripMenuItem monsterSetBaseToolStripMenuItem;
    private ToolStripMenuItem moveReqbmdEx700ToolStripMenuItem_Load;
    private DataGridView MRdgv;
    private byte[] newFile = new byte[0];
    private ToolStripMenuItem npcNamebmsdToolStripMenuItem;
    private DataGridView NPCNdgv;
    private DataGridView NPCNPlusdgv;
    private Panel panel1;
    private string PasteValue = string.Empty;
    private ProgressBar progressBar_Loading;
    private string s_LoadedFile = "";
    private ToolStripMenuItem s6e3ItemList_ToolStripMenuItem_ON;
    private SaveFileDialog saveFileDialog1;
    private int sBlockSize;
    private ToolStripMenuItem season8Episode1ToolStripMenuItem;
    private ToolStripMenuItem serverListbmdEx700ToolStripMenuItem;
    private DataGridView ServerListEx700dgv;
    private DataGridView ServerListS6E3dgv;
    private ToolStripMenuItem serverToolStripMenuItem;
    private ToolStripMenuItem shopToolStripMenuItem;
    private DataGridView Skill_ExS8E1dgv;
    private DataGridView Skill_S6E3dgv;
    private ToolStripMenuItem skillbmdToolStripMenuItem_ExS8E1_Load;
    private ToolStripMenuItem skillbmdToolStripMenuItem_Load;
    private ToolStripMenuItem skillbmdToolStripMenuItem_S6E3_Load;
    private ToolStripMenuItem slidebmdToolStripMenuItem_Load;
    private DataGridView Slidedgv;
    public int sSize;
    private byte[] startBytes = new byte[4];
    private StatusStrip statusStrip1;
    private byte[] T_fStruct;
    public TabControl tc_Items = new TabControl();
    private ToolStripMenuItem textbmdToolStripMenuItem_Load;
    private DataGridView TEXTdgv;
    private ToolStripMenuItem textOldToolStripMenuItem;
    private ToolStrip toolStrip_RowOptions;
    private ToolStrip toolStrip1;
    private ToolStripButton toolStripButton_AddRow;
    private ToolStripButton toolStripButton_BmdItemAdder;
    private ToolStripButton toolStripButton_Export;
    private ToolStripButton toolStripButton_Open;
    private ToolStripButton toolStripButton_RemoveSelectedRow;
    private ToolStripButton toolStripButton_Save;
    private ToolStripButton toolStripButton_SaveTXT;
    private ToolStripButton toolStripButton_Search;
    private ToolStripLabel toolStripLabel_FileName1;
    private ToolStripLabel toolStripLabel_FileName2;
    private ToolStripMenuItem ToolStripMenuItem_ItemS6E3_Load;
    private ToolStripMenuItem toolStripMenuItem_ItemToolTipBMD;
    private ToolStripMenuItem ToolStripMenuItem_ServerList_S6E3;
    private ToolStripProgressBar toolStripProgressBar_Save;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private string UpdatePath = "https://dl.dropbox.com/u/108778685/ToolKitUpdate.txt";
    public DataGridView workingDGV;
    private ToolStripMenuItem xMLNewToolStripMenuItem;

    public Form1() => this.InitializeComponent();

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new Form_About().ShowDialog();
    }

    public void AddColumnsToComboBox(ref ComboBox cb)
    {
      cb.Items.Clear();
      foreach (DataGridViewColumn column in (BaseCollection) this.workingDGV.Columns)
        cb.Items.Add((object) column.Name);
    }

    private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      Form1.SendArgs sendArgs1 = new Form1.SendArgs();
      Form1.SendArgs sendArgs2 = (Form1.SendArgs) e.Argument;
      switch (sendArgs2.fileType)
      {
        case "ItemToolTip":
          this.ItemToolTipEnc(sendArgs2.filePath);
          break;
        case "ItemSetType":
          this.ItemSetTypeEnc(sendArgs2.filePath);
          break;
        case "ItemSetOption":
          this.ItemSetOptionEnc(sendArgs2.filePath);
          break;
        case "ItemAddOption":
          this.ItemAddOptionEnc(sendArgs2.filePath);
          break;
        case "ItemToolTipText":
          this.ItemToolTipTextEnc(sendArgs2.filePath);
          break;
        case "JewelOfHarmonySmelt":
          this.JewelOfHarmonySmeltEnc(sendArgs2.filePath);
          break;
        case "MoveReq":
          this.MoveReqEnc(sendArgs2.filePath);
          break;
        case "NpcName":
          this.NpcNameEnc(sendArgs2.filePath);
          break;
        case "NpcNameEx700Plus":
          this.NpcNameEx700PlusEnc(sendArgs2.filePath);
          break;
        case "Slide":
          this.SlideEnc(sendArgs2.filePath);
          break;
        case "Skill_ExS8E1":
          this.Skill_ExS8E1Enc(sendArgs2.filePath);
          break;
        case "Skill_S6E3":
          this.Skill_S6E3Enc(sendArgs2.filePath);
          break;
        case "Mix":
          this.MixEnc(sendArgs2.filePath);
          break;
        case "ItemEx700":
          this.ItemEx700Enc(sendArgs2.filePath);
          break;
        case "Item_S6E3":
          this.Item_S6E3Enc(sendArgs2.filePath);
          break;
        case "ItemEx700Plus":
          this.ItemEx700PlusEnc(sendArgs2.filePath);
          break;
        case "ItemSeason8Episode1":
          this.ItemSeason8Episode1Enc(sendArgs2.filePath);
          break;
        case "ServerListEx700":
          this.ServerListEx700Enc(sendArgs2.filePath);
          break;
        case "ServerListS6E3":
          this.ServerListS6E3Enc(sendArgs2.filePath);
          break;
        case "Monster":
          this.MonsterEnc(sendArgs2.filePath);
          break;
        case "Glow":
          this.GlowEnc(sendArgs2.filePath);
          break;
        case "Text":
          this.TEXTEnc(sendArgs2.filePath);
          break;
        case "Filter":
          this.FilterEnc(sendArgs2.filePath);
          break;
        case "FilterName":
          this.FilterNameEnc(sendArgs2.filePath);
          break;
        case "Minimap":
          this.MinimapEnc(sendArgs2.filePath);
          break;
        case "Gate":
          this.GateEnc(sendArgs2.filePath);
          break;
      }
    }

    private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      this.toolStripProgressBar_Save.Increment(1);
      this.toolStripProgressBar_Save.Invalidate();
    }

    private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) => this.toolStripProgressBar_Save.Visible = false;

    private byte[] CalcCRC(byte[] Buffer, uint MagicNum, uint SkipStartLength)
    {
      uint val = MagicNum * 512U;
      uint[] numArray = new uint[9]
      {
        uint.MaxValue,
        (uint) int.MaxValue,
        1073741823U,
        536870911U,
        268435455U,
        134217727U,
        67108863U,
        33554431U,
        16777215U
      };
      if (SkipStartLength > 0U)
      {
        byte[] destinationArray = new byte[(long) Buffer.Length - (long) SkipStartLength];
        Array.Copy((Array) Buffer, (long) SkipStartLength, (Array) destinationArray, 0L, (long) destinationArray.Length);
        Buffer = destinationArray;
      }
      for (int StartIndex = 0; StartIndex <= Buffer.Length - 8; StartIndex += 4)
      {
        uint tempBuffer = this.GetTempBuffer(Buffer, StartIndex, 4);
        if (((ulong) (StartIndex / 4) + (ulong) MagicNum) % 2UL == 1UL)
          val += tempBuffer;
        else
          val ^= tempBuffer;
        if (StartIndex % 16 == 0)
          val ^= MagicNum + val >> StartIndex / 4 % 8 + 1 & numArray[StartIndex / 4 % 8 + 1];
      }
      List<byte> byteList = new List<byte>();
      for (uint index = 0; index < 4U; ++index)
      {
        byte num = this.CalcModulo(val);
        byteList.Add(num);
        val >>= 8;
      }
      return byteList.ToArray();
    }

    private byte CalcModulo(uint val)
    {
      uint num = val % 256U;
      if (num < 0U)
        num += 256U;
      return Convert.ToByte(num);
    }

    private void computeIGCCRCToolStripMenuItem_Click(object sender, EventArgs e) => new FormCRC().Show();

    private void CreateItemTabCategories(string FileType)
    {
      this.tc_Items = new TabControl();
      this.panel1.SizeChanged += new EventHandler(this.panel1_SizeChanged);
      this.tc_Items.SelectedIndexChanged += new EventHandler(this.tc_Items_SelectedIndexChanged);
      this.tc_Items.Location = new Point(0, 0);
      this.tc_Items.Size = this.panel1.Size;
      this.tc_Items.TabPages.Add(FileType + "_group_0", "Swords");
      this.tc_Items.TabPages.Add(FileType + "_group_1", "Axes");
      this.tc_Items.TabPages.Add(FileType + "_group_2", "Maces/Scapters");
      this.tc_Items.TabPages.Add(FileType + "_group_3", "Spears");
      this.tc_Items.TabPages.Add(FileType + "_group_4", "Bows/Crosswobs");
      this.tc_Items.TabPages.Add(FileType + "_group_5", "Staffs/Sticks");
      this.tc_Items.TabPages.Add(FileType + "_group_6", "Shields");
      this.tc_Items.TabPages.Add(FileType + "_group_7", "Helms");
      this.tc_Items.TabPages.Add(FileType + "_group_8", "Armors");
      this.tc_Items.TabPages.Add(FileType + "_group_9", "Pants");
      this.tc_Items.TabPages.Add(FileType + "_group_10", "Gloves");
      this.tc_Items.TabPages.Add(FileType + "_group_11", "Boots");
      this.tc_Items.TabPages.Add(FileType + "_group_12", "Wings/Other");
      this.tc_Items.TabPages.Add(FileType + "_group_13", "Misc 1");
      this.tc_Items.TabPages.Add(FileType + "_group_14", "Misc 2");
      this.tc_Items.TabPages.Add(FileType + "_group_15", "Scrolls");
      this.panel1.Controls.Add((Control) this.tc_Items);
    }

    private void cSToolStripMenuItem_Click(object sender, EventArgs e) => new CashShopEditor().Show();

    private void DecBlock(ref byte[] Buffer, int size)
    {
      byte[] numArray = new byte[3]
      {
        (byte) 252,
        (byte) 207,
        (byte) 171
      };
      for (int index = 0; index < size; ++index)
        Buffer[index] = (byte) ((uint) Buffer[index] ^ (uint) numArray[index % 3]);
    }

    private void DecIGCBlock(ref byte[] Buffer)
    {
      byte[] numArray = new byte[256]
      {
        (byte) 13,
        (byte) 217,
        (byte) 70,
        (byte) 112,
        (byte) 209,
        (byte) 160,
        (byte) 74,
        (byte) 56,
        (byte) 23,
        (byte) 212,
        (byte) 132,
        (byte) 211,
        (byte) 184,
        (byte) 65,
        (byte) 8,
        (byte) 97,
        (byte) 170,
        (byte) 85,
        (byte) 87,
        (byte) 33,
        (byte) 148,
        (byte) 46,
        (byte) 13,
        (byte) 122,
        (byte) 144,
        (byte) 249,
        (byte) 116,
        (byte) 241,
        (byte) 122,
        (byte) 162,
        (byte) 97,
        (byte) 214,
        (byte) 170,
        (byte) 19,
        (byte) 101,
        (byte) 200,
        (byte) 220,
        (byte) 19,
        (byte) 242,
        (byte) 171,
        (byte) 152,
        (byte) 246,
        (byte) 121,
        (byte) 219,
        (byte) 109,
        (byte) 59,
        (byte) 20,
        (byte) 41,
        (byte) 73,
        (byte) 67,
        (byte) 13,
        (byte) 49,
        (byte) 213,
        (byte) 20,
        (byte) 98,
        (byte) 54,
        (byte) 138,
        (byte) 125,
        (byte) 205,
        (byte) 118,
        (byte) 198,
        (byte) 39,
        (byte) 71,
        (byte) 246,
        (byte) 170,
        (byte) 86,
        (byte) 246,
        (byte) 107,
        (byte) 251,
        (byte) 250,
        (byte) 196,
        (byte) 206,
        (byte) 189,
        (byte) 206,
        (byte) 85,
        (byte) 149,
        (byte) 214,
        (byte) 200,
        (byte) 35,
        (byte) 176,
        (byte) 91,
        (byte) 193,
        (byte) 9,
        (byte) 26,
        (byte) 157,
        (byte) 232,
        (byte) 144,
        (byte) 189,
        (byte) 80,
        (byte) 10,
        (byte) 124,
        (byte) 178,
        (byte) 233,
        (byte) 171,
        (byte) 168,
        (byte) 30,
        (byte) 191,
        (byte) 229,
        (byte) 75,
        (byte) 142,
        (byte) 212,
        (byte) 188,
        (byte) 24,
        (byte) 144,
        (byte) 184,
        (byte) 123,
        (byte) 49,
        (byte) 33,
        (byte) 123,
        (byte) 145,
        (byte) 170,
        (byte) 107,
        (byte) 216,
        (byte) 58,
        (byte) 55,
        (byte) 172,
        (byte) 130,
        (byte) 124,
        (byte) 128,
        (byte) 207,
        (byte) 63,
        (byte) 26,
        (byte) 125,
        (byte) 228,
        (byte) 119,
        (byte) 122,
        (byte) 104,
        (byte) 53,
        (byte) 184,
        (byte) 167,
        (byte) 209,
        (byte) 189,
        (byte) 148,
        (byte) 203,
        (byte) 32,
        (byte) 5,
        (byte) 61,
        (byte) 107,
        (byte) 164,
        (byte) 105,
        (byte) 232,
        (byte) 242,
        (byte) 160,
        (byte) 27,
        (byte) 126,
        (byte) 206,
        (byte) 164,
        (byte) 163,
        byte.MaxValue,
        (byte) 15,
        (byte) 90,
        (byte) 158,
        (byte) 81,
        (byte) 113,
        (byte) 67,
        (byte) 189,
        (byte) 15,
        (byte) 140,
        (byte) 53,
        (byte) 103,
        (byte) 186,
        (byte) 182,
        (byte) 178,
        (byte) 167,
        (byte) 27,
        (byte) 138,
        (byte) 138,
        (byte) 155,
        (byte) 170,
        (byte) 203,
        (byte) 225,
        (byte) 114,
        (byte) 192,
        (byte) 110,
        (byte) 150,
        (byte) 202,
        (byte) 82,
        (byte) 69,
        (byte) 229,
        (byte) 34,
        (byte) 196,
        (byte) 241,
        (byte) 90,
        (byte) 116,
        (byte) 248,
        (byte) 67,
        (byte) 11,
        (byte) 13,
        (byte) 185,
        (byte) 0,
        (byte) 27,
        (byte) 66,
        (byte) 240,
        (byte) 205,
        (byte) 209,
        (byte) 86,
        (byte) 67,
        (byte) 25,
        (byte) 118,
        (byte) 48,
        (byte) 35,
        (byte) 168,
        (byte) 92,
        (byte) 35,
        (byte) 90,
        (byte) 250,
        (byte) 248,
        (byte) 154,
        (byte) 235,
        (byte) 160,
        (byte) 224,
        (byte) 117,
        (byte) 17,
        (byte) 202,
        (byte) 82,
        (byte) 40,
        (byte) 229,
        (byte) 246,
        (byte) 249,
        (byte) 222,
        (byte) 130,
        (byte) 153,
        (byte) 149,
        (byte) 101,
        (byte) 10,
        (byte) 200,
        (byte) 117,
        (byte) 251,
        (byte) 101,
        (byte) 177,
        (byte) 101,
        (byte) 6,
        (byte) 254,
        (byte) 6,
        (byte) 94,
        (byte) 177,
        (byte) 8,
        (byte) 73,
        (byte) 239,
        (byte) 15,
        (byte) 165,
        (byte) 147,
        (byte) 126,
        (byte) 199,
        (byte) 131,
        (byte) 198,
        (byte) 192,
        (byte) 78,
        (byte) 99,
        (byte) 111,
        (byte) 0,
        (byte) 44,
        (byte) 97,
        (byte) 169,
        (byte) 229,
        (byte) 137
      };
      for (int index = 0; index < Buffer.Length; ++index)
        Buffer[index] = (byte) ((uint) Buffer[index] ^ (uint) numArray[index % 256]);
    }

    private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      this.isNewRow = true;
      DataGridView dataGridView = (DataGridView) sender;
      for (int columnIndex = 0; columnIndex < dataGridView.ColumnCount; ++columnIndex)
        dataGridView[columnIndex, e.RowIndex].Value = (object) 0;
      this.isNewRow = false;
    }

    private void dgvPasteEvent_KeyDown(object sender, KeyEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      if (e.Control && e.KeyCode == Keys.F)
        this.toolStripButton_Search.PerformClick();
      else if (e.Control && e.KeyCode == Keys.C)
      {
        string text = Convert.ToString(dataGridView.GetClipboardContent().GetText());
        if (text.Length <= 0)
          return;
        Clipboard.SetText(text);
        e.Handled = true;
      }
      else
      {
        if (!e.Control || e.KeyCode != Keys.V)
          return;
        this.isPasteFromCP = true;
        string[] strArray = Clipboard.GetText().Replace('\r', ' ').Trim().Split('\n');
        int rowIndex1 = dataGridView.CurrentCell.RowIndex;
        int length1 = strArray.Length;
        int columnIndex1 = dataGridView.CurrentCell.ColumnIndex;
        int length2 = strArray[0].Split('\t').Length;
        int cellCount = dataGridView.GetCellCount(DataGridViewElementStates.Selected);
        List<int> intList1 = new List<int>();
        List<int> intList2 = new List<int>();
        for (int index = 0; index < cellCount; ++index)
        {
          int rowIndex2 = dataGridView.SelectedCells[index].RowIndex;
          if (!intList1.Contains(rowIndex2))
            intList1.Add(rowIndex2);
          int columnIndex2 = dataGridView.SelectedCells[index].ColumnIndex;
          if (!intList2.Contains(columnIndex2))
            intList2.Add(columnIndex2);
        }
        if (dataGridView.SelectedRows.Count == 0)
        {
          intList1.Reverse();
          intList2.Reverse();
        }
        int num = 0;
        if (dataGridView.Columns[0].ReadOnly & dataGridView.Columns[intList2[intList2.Count - 1]].Name == "Group")
        {
          List<int> intList3;
          (intList3 = intList2)[0] = intList3[0] + 1;
          num = 0;
        }
        if (dataGridView.AllowUserToAddRows & dataGridView.Rows.Count - 1 == dataGridView.SelectedCells[0].RowIndex)
        {
          for (int index = 0; index < length1; ++index)
            dataGridView.Rows.Add();
        }
        for (int index1 = 0; index1 < length1; ++index1)
        {
          List<string> list = ((IEnumerable<string>) strArray[index1].Split('\t')).ToList<string>();
          if (list[0] == "")
            list.Remove(list[0]);
          string[] array = list.ToArray();
          int length3 = array.Length;
          int columnIndex3 = dataGridView.CurrentCell.ColumnIndex;
          for (int index2 = 0; index2 < length3; ++index2)
          {
            this.PasteValue = array[index2];
            try
            {
              dataGridView[intList2[0] + index2, intList1[0] + index1].Value = (object) array[index2 + num];
            }
            catch
            {
              continue;
            }
            ++columnIndex3;
          }
          ++rowIndex1;
        }
        this.isPasteFromCP = false;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void DisposeGrid(TabPage tp)
    {
      if (tp.Controls.Count == 0)
        return;
      try
      {
        tp.Controls[0].Dispose();
      }
      catch
      {
        this.DisposeGrid(tp);
      }
    }

    private void EncBlock(ref byte[] Buffer, int size)
    {
      byte[] numArray = new byte[3]
      {
        (byte) 252,
        (byte) 207,
        (byte) 171
      };
      for (int index = 0; index < size; ++index)
        Buffer[index] = (byte) ((uint) Buffer[index] ^ (uint) numArray[index % 3]);
    }

    private void EncBlock(ref byte[] Buffer, int size, int offset)
    {
      byte[] numArray = new byte[3]
      {
        (byte) 252,
        (byte) 207,
        (byte) 171
      };
      for (int index = offset; index < size; ++index)
        Buffer[index] = (byte) ((uint) Buffer[index] ^ (uint) numArray[index % 3]);
    }

    private void EncIGCBlock(ref byte[] bArray)
    {
      byte[] numArray = new byte[256]
      {
        (byte) 13,
        (byte) 217,
        (byte) 70,
        (byte) 112,
        (byte) 209,
        (byte) 160,
        (byte) 74,
        (byte) 56,
        (byte) 23,
        (byte) 212,
        (byte) 132,
        (byte) 211,
        (byte) 184,
        (byte) 65,
        (byte) 8,
        (byte) 97,
        (byte) 170,
        (byte) 85,
        (byte) 87,
        (byte) 33,
        (byte) 148,
        (byte) 46,
        (byte) 13,
        (byte) 122,
        (byte) 144,
        (byte) 249,
        (byte) 116,
        (byte) 241,
        (byte) 122,
        (byte) 162,
        (byte) 97,
        (byte) 214,
        (byte) 170,
        (byte) 19,
        (byte) 101,
        (byte) 200,
        (byte) 220,
        (byte) 19,
        (byte) 242,
        (byte) 171,
        (byte) 152,
        (byte) 246,
        (byte) 121,
        (byte) 219,
        (byte) 109,
        (byte) 59,
        (byte) 20,
        (byte) 41,
        (byte) 73,
        (byte) 67,
        (byte) 13,
        (byte) 49,
        (byte) 213,
        (byte) 20,
        (byte) 98,
        (byte) 54,
        (byte) 138,
        (byte) 125,
        (byte) 205,
        (byte) 118,
        (byte) 198,
        (byte) 39,
        (byte) 71,
        (byte) 246,
        (byte) 170,
        (byte) 86,
        (byte) 246,
        (byte) 107,
        (byte) 251,
        (byte) 250,
        (byte) 196,
        (byte) 206,
        (byte) 189,
        (byte) 206,
        (byte) 85,
        (byte) 149,
        (byte) 214,
        (byte) 200,
        (byte) 35,
        (byte) 176,
        (byte) 91,
        (byte) 193,
        (byte) 9,
        (byte) 26,
        (byte) 157,
        (byte) 232,
        (byte) 144,
        (byte) 189,
        (byte) 80,
        (byte) 10,
        (byte) 124,
        (byte) 178,
        (byte) 233,
        (byte) 171,
        (byte) 168,
        (byte) 30,
        (byte) 191,
        (byte) 229,
        (byte) 75,
        (byte) 142,
        (byte) 212,
        (byte) 188,
        (byte) 24,
        (byte) 144,
        (byte) 184,
        (byte) 123,
        (byte) 49,
        (byte) 33,
        (byte) 123,
        (byte) 145,
        (byte) 170,
        (byte) 107,
        (byte) 216,
        (byte) 58,
        (byte) 55,
        (byte) 172,
        (byte) 130,
        (byte) 124,
        (byte) 128,
        (byte) 207,
        (byte) 63,
        (byte) 26,
        (byte) 125,
        (byte) 228,
        (byte) 119,
        (byte) 122,
        (byte) 104,
        (byte) 53,
        (byte) 184,
        (byte) 167,
        (byte) 209,
        (byte) 189,
        (byte) 148,
        (byte) 203,
        (byte) 32,
        (byte) 5,
        (byte) 61,
        (byte) 107,
        (byte) 164,
        (byte) 105,
        (byte) 232,
        (byte) 242,
        (byte) 160,
        (byte) 27,
        (byte) 126,
        (byte) 206,
        (byte) 164,
        (byte) 163,
        byte.MaxValue,
        (byte) 15,
        (byte) 90,
        (byte) 158,
        (byte) 81,
        (byte) 113,
        (byte) 67,
        (byte) 189,
        (byte) 15,
        (byte) 140,
        (byte) 53,
        (byte) 103,
        (byte) 186,
        (byte) 182,
        (byte) 178,
        (byte) 167,
        (byte) 27,
        (byte) 138,
        (byte) 138,
        (byte) 155,
        (byte) 170,
        (byte) 203,
        (byte) 225,
        (byte) 114,
        (byte) 192,
        (byte) 110,
        (byte) 150,
        (byte) 202,
        (byte) 82,
        (byte) 69,
        (byte) 229,
        (byte) 34,
        (byte) 196,
        (byte) 241,
        (byte) 90,
        (byte) 116,
        (byte) 248,
        (byte) 67,
        (byte) 11,
        (byte) 13,
        (byte) 185,
        (byte) 0,
        (byte) 27,
        (byte) 66,
        (byte) 240,
        (byte) 205,
        (byte) 209,
        (byte) 86,
        (byte) 67,
        (byte) 25,
        (byte) 118,
        (byte) 48,
        (byte) 35,
        (byte) 168,
        (byte) 92,
        (byte) 35,
        (byte) 90,
        (byte) 250,
        (byte) 248,
        (byte) 154,
        (byte) 235,
        (byte) 160,
        (byte) 224,
        (byte) 117,
        (byte) 17,
        (byte) 202,
        (byte) 82,
        (byte) 40,
        (byte) 229,
        (byte) 246,
        (byte) 249,
        (byte) 222,
        (byte) 130,
        (byte) 153,
        (byte) 149,
        (byte) 101,
        (byte) 10,
        (byte) 200,
        (byte) 117,
        (byte) 251,
        (byte) 101,
        (byte) 177,
        (byte) 101,
        (byte) 6,
        (byte) 254,
        (byte) 6,
        (byte) 94,
        (byte) 177,
        (byte) 8,
        (byte) 73,
        (byte) 239,
        (byte) 15,
        (byte) 165,
        (byte) 147,
        (byte) 126,
        (byte) 199,
        (byte) 131,
        (byte) 198,
        (byte) 192,
        (byte) 78,
        (byte) 99,
        (byte) 111,
        (byte) 0,
        (byte) 44,
        (byte) 97,
        (byte) 169,
        (byte) 229,
        (byte) 137
      };
      for (int index = 0; index < bArray.Length; ++index)
        bArray[index] = (byte) ((uint) bArray[index] ^ (uint) numArray[index % 256]);
    }

    private void eventBagToolStripMenuItem_Click(object sender, EventArgs e) => new EventBagEditor().Show();

    private void ex700ItemList_ToolStripMenuItem_ON_Click(object sender, EventArgs e)
    {
      this.isEx700ItemList = true;
      this.ex700ItemList_ToolStripMenuItem_ON.Font = new Font(this.ex700ItemList_ToolStripMenuItem_ON.Font, FontStyle.Bold);
      this.s6e3ItemList_ToolStripMenuItem_ON.Font = new Font(this.s6e3ItemList_ToolStripMenuItem_ON.Font, FontStyle.Regular);
    }

    private void Filter_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Filter.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Filter";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Filterbw_DoWork(object sender, DoWorkEventArgs e) => this.Filterdgv = this.FilterDec(((Form1.SendArgs) e.Argument).filePath);

    private void Filterbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.panel1.Controls.Add((Control) this.Filterdgv);
      this.progressBar_Loading.Visible = false;
      this.Filterdgv.Disposed += new EventHandler(this.Filterdgv_Disposed);
      this.Filterdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.Filterdgv.CellValueChanged += new DataGridViewCellEventHandler(this.Filterdgv_CellValueChanged);
      this.workingDGV = this.Filterdgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView FilterDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeFilterGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray = new byte[fileStream.Length];
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        this.endBytes = new byte[4];
        Array.Copy((Array) numArray, numArray.Length - 4, (Array) this.endBytes, 0, this.endBytes.Length);
        this.sBlockSize = 20;
        this.sSize = (numArray.Length - 4) / this.sBlockSize;
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray, rowIndex * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, Buffer.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(Buffer).Replace("\0", string.Empty);
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void Filterdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      if (dataGridView.EditingControl != null)
      {
        if (dataGridView.EditingControl.Text.Length > 20)
        {
          int num = (int) MessageBox.Show("Maximum 20 Chars allowed.", "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          dataGridView.EditingControl.Text = dataGridView.EditingControl.Text.Remove(20);
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) dataGridView.EditingControl.Text;
        }
      }
      else if (this.isPasteFromCP && this.PasteValue.Length > 20)
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) this.PasteValue.Remove(20);
      this.Filterdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
    }

    private void Filterdgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void FilterEnc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        byte[] Buffer = new byte[this.sBlockSize];
        string empty = string.Empty;
        if (row.Cells[0].Value != null)
          empty = row.Cells[0].Value.ToString();
        byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(empty);
        Array.Copy((Array) bytes, 0, (Array) Buffer, 0, bytes.Length);
        this.EncBlock(ref Buffer, Buffer.Length);
        for (int index = 0; index < Buffer.Length; ++index)
          byteList.Add(Buffer[index]);
        this.backgroundWorker.ReportProgress(this.workingDGV.Rows.IndexOf(row));
      }
      for (int index = 0; index < this.endBytes.Length; ++index)
        byteList.Add(this.endBytes[index]);
      this.newFile = new byte[0];
      byte[] sourceArray = this.CalcCRC(byteList.ToArray(), 15997U, 0U);
      this.newFile = byteList.ToArray();
      Array.Copy((Array) sourceArray, 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void FilterName_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the FilterName.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "FilterName";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void FilterNamebw_DoWork(object sender, DoWorkEventArgs e) => this.FilterNamedgv = this.FilterNameDec(((Form1.SendArgs) e.Argument).filePath);

    private void FilterNamebw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.panel1.Controls.Add((Control) this.FilterNamedgv);
      this.progressBar_Loading.Visible = false;
      this.FilterNamedgv.Disposed += new EventHandler(this.FilterNamedgv_Disposed);
      this.FilterNamedgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.FilterNamedgv.CellValueChanged += new DataGridViewCellEventHandler(this.FilterNamedgv_CellValueChanged);
      this.workingDGV = this.FilterNamedgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView FilterNameDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeFilterNameGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray = new byte[fileStream.Length];
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        this.endBytes = new byte[4];
        Array.Copy((Array) numArray, numArray.Length - 4, (Array) this.endBytes, 0, this.endBytes.Length);
        this.sBlockSize = 20;
        this.sSize = (numArray.Length - 4) / this.sBlockSize;
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray, rowIndex * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, Buffer.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(Buffer).Replace("\0", string.Empty);
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void FilterNamedgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      if (dataGridView.EditingControl != null)
      {
        if (dataGridView.EditingControl.Text.Length > 20)
        {
          int num = (int) MessageBox.Show("Maximum 20 Chars allowed.", "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          dataGridView.EditingControl.Text = dataGridView.EditingControl.Text.Remove(20);
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) dataGridView.EditingControl.Text;
        }
      }
      else if (this.isPasteFromCP && this.PasteValue.Length > 20)
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) this.PasteValue.Remove(20);
      dataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
    }

    private void FilterNamedgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void FilterNameEnc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        byte[] Buffer = new byte[this.sBlockSize];
        string empty = string.Empty;
        if (row.Cells[0].Value != null)
          empty = row.Cells[0].Value.ToString();
        byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(empty);
        Array.Copy((Array) bytes, 0, (Array) Buffer, 0, bytes.Length);
        this.EncBlock(ref Buffer, Buffer.Length);
        for (int index = 0; index < Buffer.Length; ++index)
          byteList.Add(Buffer[index]);
        this.backgroundWorker.ReportProgress(this.workingDGV.Rows.IndexOf(row));
      }
      for (int index = 0; index < this.endBytes.Length; ++index)
        byteList.Add(this.endBytes[index]);
      this.newFile = new byte[0];
      byte[] sourceArray = this.CalcCRC(byteList.ToArray(), 11201U, 0U);
      this.newFile = byteList.ToArray();
      Array.Copy((Array) sourceArray, 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    public void FindNextValue(string ColName, string theVal)
    {
      for (int rowIndex = this.workingDGV.CurrentRow.Index + 1; rowIndex < this.workingDGV.Rows.Count; ++rowIndex)
      {
        if (this.workingDGV[ColName, rowIndex].Value != null && this.workingDGV[ColName, rowIndex].Value.ToString().ToUpper().Contains(theVal.ToUpper()))
        {
          this.workingDGV.CurrentCell = this.workingDGV[ColName, rowIndex];
          break;
        }
      }
    }

    public void FindPreviousValue(string ColName, string theVal)
    {
      for (int rowIndex = this.workingDGV.CurrentRow.Index - 1; rowIndex > -1; --rowIndex)
      {
        if (this.workingDGV[ColName, rowIndex].Value != null && this.workingDGV[ColName, rowIndex].Value.ToString().ToUpper().Contains(theVal.ToUpper()))
        {
          this.workingDGV.CurrentCell = this.workingDGV[ColName, rowIndex];
          break;
        }
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      string path = "Data\\Config.ini";
      if (System.IO.File.Exists(path))
        System.IO.File.Delete(path);
      StreamWriter streamWriter = new StreamWriter(path);
      streamWriter.WriteLine("{0}={1}", (object) "isEx700ItemList", this.isEx700ItemList ? (object) "1" : (object) "0");
      streamWriter.Flush();
      streamWriter.Close();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (!(e.Control & e.KeyCode == Keys.F) || !this.toolStripButton_Search.Enabled)
        return;
      this.toolStripButton_Search.PerformClick();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      try
      {
        this.Text = this.Text + " v" + this.ProductVersion;
        string path = "Data\\Config.ini";
        if (!System.IO.File.Exists(path))
          return;
        foreach (string readAllLine in System.IO.File.ReadAllLines(path))
        {
          char[] chArray = new char[1]{ '=' };
          string[] strArray = readAllLine.Split(chArray);
          strArray[0] = strArray[0].Trim(' ');
          strArray[1] = strArray[1].Trim(' ');
          switch (strArray[0])
          {
            case "isEx700ItemList":
              this.isEx700ItemList = Convert.ToBoolean(Convert.ToUInt16(strArray[1]));
              if (this.isEx700ItemList)
              {
                this.ex700ItemList_ToolStripMenuItem_ON.PerformClick();
                break;
              }
              this.s6e3ItemList_ToolStripMenuItem_ON.PerformClick();
              break;
          }
        }
      }
      catch
      {
        Environment.Exit(0);
      }
    }

    private void Form1_SizeChanged(object sender, EventArgs e) => this.panel1.Size = new Size(this.Size.Width - 16, this.Size.Height - 111);

    private void Gate_DAT_Export()
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Title = "Select a location and file Name for the generated GateSettings.dat";
      saveFileDialog1.FileName = "GateSettings.dat";
      saveFileDialog1.Filter = "DAT files (*.dat)|*.dat|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName)
      {
        AutoFlush = true
      };
      streamWriter.WriteLine("//Generated by MU.ToolKit coded by TopReal.IT");
      streamWriter.WriteLine("//------------------------------------------------------------------------");
      streamWriter.WriteLine("////\tGate\tFlag\tMap\tX1\tY1\tX2\tY2\tTarget\tDir\tMinLevel");
      streamWriter.WriteLine("//------------------------------------------------------------------------");
      streamWriter.WriteLine();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "0")
          streamWriter.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}", (object) row.Index, (object) row.Cells[0].Value.ToString(), (object) row.Cells[1].Value.ToString(), (object) row.Cells[2].Value.ToString(), (object) row.Cells[3].Value.ToString(), (object) row.Cells[4].Value.ToString(), (object) row.Cells[5].Value.ToString(), (object) row.Cells[6].Value.ToString(), (object) row.Cells[7].Value.ToString(), (object) row.Cells[9].Value.ToString());
      }
      streamWriter.Close();
      if (MessageBox.Show("File generated succesfully.\nOpen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(saveFileDialog2.FileName);
    }

    private void Gate_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Gate.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Gate";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Gatebw_DoWork(object sender, DoWorkEventArgs e) => this.Gatedgv = this.GateDec(((Form1.SendArgs) e.Argument).filePath);

    private void Gatebw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.Gatedgv);
      this.progressBar_Loading.Visible = false;
      this.Gatedgv.CellValueChanged += new DataGridViewCellEventHandler(this.Gatedgv_CellValueChanged);
      this.Gatedgv.Disposed += new EventHandler(this.Gatedgv_Disposed);
      this.Gatedgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.Gatedgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView GateDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      this.initializeGateGrid(dgv);
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        this.sBlockSize = 14;
        byte[] numArray = new byte[fileStream.Length];
        this.sSize = (int) fileStream.Length / this.sBlockSize;
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray, rowIndex * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, Buffer.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) Buffer[0];
          dgv[1, rowIndex].Value = (object) Buffer[1];
          dgv[2, rowIndex].Value = (object) Buffer[2];
          dgv[3, rowIndex].Value = (object) Buffer[3];
          dgv[4, rowIndex].Value = (object) Buffer[4];
          dgv[5, rowIndex].Value = (object) Buffer[5];
          dgv[6, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, 6);
          dgv[7, rowIndex].Value = (object) Buffer[8];
          dgv[8, rowIndex].Value = (object) Buffer[9];
          dgv[9, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, 10);
          dgv[10, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, 12);
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void Gatedgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => ((DataGridView) sender)[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void Gatedgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void GateEnc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        if (row.Cells[0].Value != null)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[0].Value.ToString())), 0, (Array) Buffer, 0, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[1].Value.ToString())), 0, (Array) Buffer, 1, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[2].Value.ToString())), 0, (Array) Buffer, 2, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[3].Value.ToString())), 0, (Array) Buffer, 3, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[4].Value.ToString())), 0, (Array) Buffer, 4, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[5].Value.ToString())), 0, (Array) Buffer, 5, 1);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt16(row.Cells[6].Value.ToString())), 0, (Array) Buffer, 6, 2);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[7].Value.ToString())), 0, (Array) Buffer, 8, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[8].Value.ToString())), 0, (Array) Buffer, 9, 1);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt16(row.Cells[9].Value.ToString())), 0, (Array) Buffer, 10, 2);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt16(row.Cells[10].Value.ToString())), 0, (Array) Buffer, 12, 2);
          this.EncBlock(ref Buffer, this.sBlockSize);
          for (int index = 0; index < Buffer.Length; ++index)
            byteList.Add(Buffer[index]);
          this.backgroundWorker.ReportProgress(row.Index);
        }
      }
      this.newFile = byteList.ToArray();
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private uint GetTempBuffer(byte[] Buffer, int StartIndex, int Length)
    {
      uint tempBuffer = 0;
      byte[] destinationArray = new byte[Length];
      Array.Copy((Array) Buffer, StartIndex, (Array) destinationArray, 0, Length);
      for (uint y = 0; (long) y < (long) Length; ++y)
        tempBuffer += (uint) destinationArray[(IntPtr) y] * Convert.ToUInt32(Math.Pow(256.0, (double) y));
      return tempBuffer;
    }

    private void Glow_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Glow.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.Glowdgv.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Glow";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Glowbw_DoWork(object sender, DoWorkEventArgs e) => this.Glowdgv = this.GlowDec(((Form1.SendArgs) e.Argument).filePath);

    private void Glowbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.Glowdgv);
      this.progressBar_Loading.Visible = false;
      this.Glowdgv.CellValueChanged += new DataGridViewCellEventHandler(this.Glowdgv_CellValueChanged);
      this.Glowdgv.Disposed += new EventHandler(this.Glowdgv_Disposed);
      this.Glowdgv.CellMouseClick += new DataGridViewCellMouseEventHandler(this.Glowdgv_CellMouseClick);
      this.Glowdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.Glowdgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView GlowDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeGlowGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray = new byte[fileStream.Length];
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        this.sBlockSize = 16;
        this.sSize = numArray.Length / this.sBlockSize;
        this.fStruct = new object[this.sSize, this.sBlockSize];
        byte[] destinationArray = new byte[this.sBlockSize];
        int rowIndex = 0;
        for (int index = 0; index < this.sSize; ++index)
        {
          Array.Copy((Array) numArray, index * this.sBlockSize, (Array) destinationArray, 0, this.sBlockSize);
          if (destinationArray[2] != (byte) 0)
          {
            dgv.Rows.Add();
            int uint16 = (int) BitConverter.ToUInt16(destinationArray, 0);
            dgv["Item Group", rowIndex].Value = (object) (uint16 / 512);
            dgv["Item Index", rowIndex].Value = (object) (uint16 - 512 * (uint16 / 512));
            dgv["R Color", rowIndex].Value = (object) (float) ((double) BitConverter.ToSingle(destinationArray, 4) * (double) byte.MaxValue);
            dgv["G Color", rowIndex].Value = (object) (float) ((double) BitConverter.ToSingle(destinationArray, 8) * (double) byte.MaxValue);
            dgv["B Color", rowIndex].Value = (object) (float) ((double) BitConverter.ToSingle(destinationArray, 12) * (double) byte.MaxValue);
            ++rowIndex;
          }
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void Glowdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.ColumnIndex != 2 && e.ColumnIndex != 3 && e.ColumnIndex != 4)
        return;
      ColorDialog colorDialog = new ColorDialog()
      {
        Color = Color.FromArgb(Convert.ToInt32(this.Glowdgv[2, e.RowIndex].Value), Convert.ToInt32(this.Glowdgv[3, e.RowIndex].Value), Convert.ToInt32(this.Glowdgv[4, e.RowIndex].Value))
      };
      if (colorDialog.ShowDialog() != DialogResult.OK)
        return;
      this.Glowdgv[2, e.RowIndex].Value = (object) colorDialog.Color.R;
      this.Glowdgv[3, e.RowIndex].Value = (object) colorDialog.Color.G;
      this.Glowdgv[4, e.RowIndex].Value = (object) colorDialog.Color.B;
    }

    private void Glowdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (this.Glowdgv.EditingControl != null)
      {
        if (this.Glowdgv.EditingControl.Text == "")
          this.Glowdgv.EditingControl.Text = "0";
      }
      else if (this.PasteValue == "")
        this.PasteValue = "0";
      switch (e.ColumnIndex)
      {
        case 0:
          if (Convert.ToUInt32(this.Glowdgv.EditingControl.Text) > 15U)
          {
            int num = (int) MessageBox.Show("Maximum 15 !", "Error");
            this.Glowdgv.EditingControl.Text = "15";
            this.Glowdgv[e.ColumnIndex, e.RowIndex].Value = (object) 15;
            break;
          }
          break;
        case 1:
          if (Convert.ToUInt32(this.Glowdgv.EditingControl.Text) > 512U)
          {
            int num = (int) MessageBox.Show("Maximum 512 !", "Error");
            this.Glowdgv.EditingControl.Text = "512";
            this.Glowdgv[e.ColumnIndex, e.RowIndex].Value = (object) 512;
            break;
          }
          break;
      }
      this.Glowdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
    }

    private void Glowdgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void GlowEnc(string filePath)
    {
      byte[] bytes1 = new byte[this.sSize * this.sBlockSize];
      foreach (DataGridViewRow row in (IEnumerable) this.Glowdgv.Rows)
      {
        if (row.Cells[0].Value != null)
        {
          int num1 = Convert.ToInt32(row.Cells[0].Value) * 512 + Convert.ToInt32(row.Cells[1].Value);
          float num2 = (float) Convert.ToInt32(row.Cells[2].Value) / (float) byte.MaxValue;
          float num3 = (float) Convert.ToInt32(row.Cells[3].Value) / (float) byte.MaxValue;
          float num4 = (float) Convert.ToInt32(row.Cells[4].Value) / (float) byte.MaxValue;
          byte[] bytes2 = BitConverter.GetBytes(num1);
          for (int index = 0; index < bytes2.Length - 2; ++index)
            bytes1[num1 * this.sBlockSize + index] = bytes2[index];
          bytes1[num1 * this.sBlockSize + 2] = (byte) 1;
          bytes1[num1 * this.sBlockSize + 3] = (byte) 0;
          byte[] bytes3 = BitConverter.GetBytes(num2);
          for (int index = 0; index < bytes3.Length; ++index)
            bytes1[num1 * this.sBlockSize + 4 + index] = bytes3[index];
          byte[] bytes4 = BitConverter.GetBytes(num3);
          for (int index = 0; index < bytes4.Length; ++index)
            bytes1[num1 * this.sBlockSize + 8 + index] = bytes4[index];
          byte[] bytes5 = BitConverter.GetBytes(num4);
          for (int index = 0; index < bytes5.Length; ++index)
            bytes1[num1 * this.sBlockSize + 12 + index] = bytes5[index];
          this.backgroundWorker.ReportProgress(1);
        }
      }
      System.IO.File.WriteAllBytes(filePath, bytes1);
    }

    private void IAObw_DoWork(object sender, DoWorkEventArgs e) => this.ItemAddOptionDec(((Form1.SendArgs) e.Argument).filePath);

    private void IAObw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_BmdItemAdder.Enabled = true;
      this.isLeaveOpenItemAdder = true;
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.progressBar_Loading.Visible = false;
      this.tc_Items.SelectedIndex = -1;
      this.tc_Items.SelectedIndex = 0;
    }

    private void IAOdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      byte num = Convert.ToByte(dataGridView[0, e.RowIndex].Value);
      int rowIndex = e.RowIndex;
      if (e.ColumnIndex == 0)
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) num;
      else if (e.ColumnIndex == 1)
      {
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) rowIndex;
      }
      else
      {
        if (dataGridView.EditingControl != null)
        {
          if (dataGridView.EditingControl.Text == "")
            dataGridView.EditingControl.Text = "0";
        }
        else if (this.PasteValue == "")
          this.PasteValue = "0";
        string empty = string.Empty;
        string str = !this.isPasteFromCP ? (dataGridView.EditingControl == null ? dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() : dataGridView.EditingControl.Text) : this.PasteValue;
        switch (e.ColumnIndex)
        {
          case 2:
            Array.Copy((Array) BitConverter.GetBytes(Convert.ToInt16(str)), 0, (Array) this.T_fStruct, ((int) num * 512 + rowIndex) * this.sBlockSize, 2);
            break;
          case 3:
            Array.Copy((Array) BitConverter.GetBytes(Convert.ToInt16(str)), 0, (Array) this.T_fStruct, ((int) num * 512 + rowIndex) * this.sBlockSize + 2, 2);
            break;
          case 4:
            Array.Copy((Array) BitConverter.GetBytes(Convert.ToInt16(str)), 0, (Array) this.T_fStruct, ((int) num * 512 + rowIndex) * this.sBlockSize + 4, 2);
            break;
          case 5:
            Array.Copy((Array) BitConverter.GetBytes(Convert.ToInt16(str)), 0, (Array) this.T_fStruct, ((int) num * 512 + rowIndex) * this.sBlockSize + 6, 2);
            break;
          case 6:
            Array.Copy((Array) BitConverter.GetBytes(Convert.ToInt32(str)), 0, (Array) this.T_fStruct, ((int) num * 512 + rowIndex) * this.sBlockSize + 8, 4);
            break;
          case 7:
            Array.Copy((Array) BitConverter.GetBytes(Convert.ToInt32(str)), 0, (Array) this.T_fStruct, ((int) num * 512 + rowIndex) * this.sBlockSize + 12, 4);
            break;
        }
        dataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
      }
    }

    private void IAOdgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] != null)
        Application.OpenForms["Form_Search"].Close();
      if (this.isLeaveOpenItemAdder)
        return;
      if (Application.OpenForms["Form_BmdItemAddercs"] != null)
        Application.OpenForms["Form_BmdItemAddercs"].Close();
      this.toolStripButton_BmdItemAdder.Enabled = false;
    }

    private void iGCDropManagerEditorToolStripMenuItem_Click(object sender, EventArgs e) => new Form_DropManager().Show();

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.statusStrip1 = new StatusStrip();
      this.toolStripStatusLabel1 = new ToolStripStatusLabel();
      this.menuStrip1 = new MenuStrip();
      this.clientToolStripMenuItem = new ToolStripMenuItem();
      this.itemToolTipToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripMenuItem_ItemS6E3_Load = new ToolStripMenuItem();
      this.ItemEx700ToolStripMenuItem_Load = new ToolStripMenuItem();
      this.ItemEx700PlusToolStripMenuItem_Load = new ToolStripMenuItem();
      this.season8Episode1ToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItem_ItemToolTipBMD = new ToolStripMenuItem();
      this.itemToolTipTextToolStripMenuItem_Load = new ToolStripMenuItem();
      this.itemSetTypebmdToolStripMenuItem = new ToolStripMenuItem();
      this.itemSetOptionbmdToolStripMenuItem = new ToolStripMenuItem();
      this.itemAddOptionbmdToolStripMenuItem = new ToolStripMenuItem();
      this.jewelOfHarmonySmeltbmdToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.skillbmdToolStripMenuItem_Load = new ToolStripMenuItem();
      this.skillbmdToolStripMenuItem_S6E3_Load = new ToolStripMenuItem();
      this.skillbmdToolStripMenuItem_ExS8E1_Load = new ToolStripMenuItem();
      this.slidebmdToolStripMenuItem_Load = new ToolStripMenuItem();
      this.serverListbmdEx700ToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripMenuItem_ServerList_S6E3 = new ToolStripMenuItem();
      this.ex700ToolStripMenuItem_ServerListBMD = new ToolStripMenuItem();
      this.textbmdToolStripMenuItem_Load = new ToolStripMenuItem();
      this.gatebmdToolStripMenuItem_Load = new ToolStripMenuItem();
      this.moveReqbmdEx700ToolStripMenuItem_Load = new ToolStripMenuItem();
      this.minimapWorldXbmdToolStripMenuItem_Load = new ToolStripMenuItem();
      this.mixToolStripMenuItem_Load = new ToolStripMenuItem();
      this.npcNamebmsdToolStripMenuItem = new ToolStripMenuItem();
      this.ex700ToolStripMenuItem_NpcNameEx700BMD = new ToolStripMenuItem();
      this.ex700ToolStripMenuItem_NpcNameEx700PlusBMD = new ToolStripMenuItem();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.filterbmdToolStripMenuItem_Load = new ToolStripMenuItem();
      this.filterNamebmdToolStripMenuItem_Load = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.monsterbmdToolStripMenuItem_Load = new ToolStripMenuItem();
      this.glowbmdToolStripMenuItem_Load = new ToolStripMenuItem();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.computeIGCCRCToolStripMenuItem = new ToolStripMenuItem();
      this.serverToolStripMenuItem = new ToolStripMenuItem();
      this.monsterSetBaseToolStripMenuItem = new ToolStripMenuItem();
      this.shopToolStripMenuItem = new ToolStripMenuItem();
      this.eventBagToolStripMenuItem = new ToolStripMenuItem();
      this.textOldToolStripMenuItem = new ToolStripMenuItem();
      this.xMLNewToolStripMenuItem = new ToolStripMenuItem();
      this.cashShopToolStripMenuItem = new ToolStripMenuItem();
      this.iGCDropManagerEditorToolStripMenuItem = new ToolStripMenuItem();
      this.configToolStripMenuItem = new ToolStripMenuItem();
      this.itemListSettingsTypeToolStripMenuItem = new ToolStripMenuItem();
      this.ex700ItemList_ToolStripMenuItem_ON = new ToolStripMenuItem();
      this.s6e3ItemList_ToolStripMenuItem_ON = new ToolStripMenuItem();
      this.helpToolStripMenuItem = new ToolStripMenuItem();
      this.aboutToolStripMenuItem = new ToolStripMenuItem();
      this.backgroundWorker = new BackgroundWorker();
      this.panel1 = new Panel();
      this.progressBar_Loading = new ProgressBar();
      this.saveFileDialog1 = new SaveFileDialog();
      this.toolStrip_RowOptions = new ToolStrip();
      this.toolStripLabel_FileName1 = new ToolStripLabel();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.toolStripButton_AddRow = new ToolStripButton();
      this.toolStripButton_RemoveSelectedRow = new ToolStripButton();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.toolStripButton_Search = new ToolStripButton();
      this.toolStripButton_BmdItemAdder = new ToolStripButton();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.toolStripButton_Open = new ToolStripButton();
      this.toolStripButton_Save = new ToolStripButton();
      this.toolStripButton_Export = new ToolStripButton();
      this.toolStripButton_SaveTXT = new ToolStripButton();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.toolStripProgressBar_Save = new ToolStripProgressBar();
      this.toolStrip1 = new ToolStrip();
      this.toolStripLabel_FileName2 = new ToolStripLabel();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.toolStrip_RowOptions.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      this.statusStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripStatusLabel1
      });
      this.statusStrip1.Location = new Point(0, 450);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new Size(1010, 22);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      this.toolStripStatusLabel1.AutoSize = false;
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new Size(131, 17);
      this.toolStripStatusLabel1.Text = "Coded by TopReal.IT";
      this.menuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.clientToolStripMenuItem,
        (ToolStripItem) this.serverToolStripMenuItem,
        (ToolStripItem) this.configToolStripMenuItem,
        (ToolStripItem) this.helpToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(1010, 25);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      this.clientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[25]
      {
        (ToolStripItem) this.itemToolTipToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItem_ItemToolTipBMD,
        (ToolStripItem) this.itemToolTipTextToolStripMenuItem_Load,
        (ToolStripItem) this.itemSetTypebmdToolStripMenuItem,
        (ToolStripItem) this.itemSetOptionbmdToolStripMenuItem,
        (ToolStripItem) this.itemAddOptionbmdToolStripMenuItem,
        (ToolStripItem) this.jewelOfHarmonySmeltbmdToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.skillbmdToolStripMenuItem_Load,
        (ToolStripItem) this.slidebmdToolStripMenuItem_Load,
        (ToolStripItem) this.serverListbmdEx700ToolStripMenuItem,
        (ToolStripItem) this.textbmdToolStripMenuItem_Load,
        (ToolStripItem) this.gatebmdToolStripMenuItem_Load,
        (ToolStripItem) this.moveReqbmdEx700ToolStripMenuItem_Load,
        (ToolStripItem) this.minimapWorldXbmdToolStripMenuItem_Load,
        (ToolStripItem) this.mixToolStripMenuItem_Load,
        (ToolStripItem) this.npcNamebmsdToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.filterbmdToolStripMenuItem_Load,
        (ToolStripItem) this.filterNamebmdToolStripMenuItem_Load,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.monsterbmdToolStripMenuItem_Load,
        (ToolStripItem) this.glowbmdToolStripMenuItem_Load,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.computeIGCCRCToolStripMenuItem
      });
      this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
      this.clientToolStripMenuItem.Size = new Size(88, 21);
      this.clientToolStripMenuItem.Text = "Client Tools";
      this.itemToolTipToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.ToolStripMenuItem_ItemS6E3_Load,
        (ToolStripItem) this.ItemEx700ToolStripMenuItem_Load,
        (ToolStripItem) this.ItemEx700PlusToolStripMenuItem_Load,
        (ToolStripItem) this.season8Episode1ToolStripMenuItem
      });
      this.itemToolTipToolStripMenuItem.Name = "itemToolTipToolStripMenuItem";
      this.itemToolTipToolStripMenuItem.Size = new Size(236, 22);
      this.itemToolTipToolStripMenuItem.Text = "Item.bmd";
      this.ToolStripMenuItem_ItemS6E3_Load.Name = "ToolStripMenuItem_ItemS6E3_Load";
      this.ToolStripMenuItem_ItemS6E3_Load.Size = new Size(191, 22);
      this.ToolStripMenuItem_ItemS6E3_Load.Text = "Season 6 Episode 3";
      this.ToolStripMenuItem_ItemS6E3_Load.Click += new EventHandler(this.loadToolStripMenuItem_Item_S6E3_Click);
      this.ItemEx700ToolStripMenuItem_Load.Name = "ItemEx700ToolStripMenuItem_Load";
      this.ItemEx700ToolStripMenuItem_Load.Size = new Size(191, 22);
      this.ItemEx700ToolStripMenuItem_Load.Text = "Ex700";
      this.ItemEx700ToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_ItemEx700_Click);
      this.ItemEx700PlusToolStripMenuItem_Load.Name = "ItemEx700PlusToolStripMenuItem_Load";
      this.ItemEx700PlusToolStripMenuItem_Load.Size = new Size(191, 22);
      this.ItemEx700PlusToolStripMenuItem_Load.Text = "Ex700 Plus";
      this.ItemEx700PlusToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_ItemEx700Plus_Click);
      this.season8Episode1ToolStripMenuItem.Name = "season8Episode1ToolStripMenuItem";
      this.season8Episode1ToolStripMenuItem.Size = new Size(191, 22);
      this.season8Episode1ToolStripMenuItem.Text = "Season 8 Episode 1";
      this.season8Episode1ToolStripMenuItem.Click += new EventHandler(this.loadToolStripMenuItem_ItemSeason8Episode1_Click);
      this.toolStripMenuItem_ItemToolTipBMD.Name = "toolStripMenuItem_ItemToolTipBMD";
      this.toolStripMenuItem_ItemToolTipBMD.Size = new Size(236, 22);
      this.toolStripMenuItem_ItemToolTipBMD.Text = "ItemToolTip.bmd";
      this.toolStripMenuItem_ItemToolTipBMD.Click += new EventHandler(this.loadToolStripMenuItem_ITT_Click);
      this.itemToolTipTextToolStripMenuItem_Load.Name = "itemToolTipTextToolStripMenuItem_Load";
      this.itemToolTipTextToolStripMenuItem_Load.Size = new Size(236, 22);
      this.itemToolTipTextToolStripMenuItem_Load.Text = "ItemToolTipText.bmd";
      this.itemToolTipTextToolStripMenuItem_Load.Click += new EventHandler(this.itemToolTipTextToolStripMenuItem_Load_Click);
      this.itemSetTypebmdToolStripMenuItem.Name = "itemSetTypebmdToolStripMenuItem";
      this.itemSetTypebmdToolStripMenuItem.Size = new Size(236, 22);
      this.itemSetTypebmdToolStripMenuItem.Text = "ItemSetType.bmd";
      this.itemSetTypebmdToolStripMenuItem.Click += new EventHandler(this.loadToolStripMenuItem_IST_Click);
      this.itemSetOptionbmdToolStripMenuItem.Name = "itemSetOptionbmdToolStripMenuItem";
      this.itemSetOptionbmdToolStripMenuItem.Size = new Size(236, 22);
      this.itemSetOptionbmdToolStripMenuItem.Text = "ItemSetOption.bmd";
      this.itemSetOptionbmdToolStripMenuItem.Click += new EventHandler(this.loadToolStripMenuItem_ISO_Click);
      this.itemAddOptionbmdToolStripMenuItem.Name = "itemAddOptionbmdToolStripMenuItem";
      this.itemAddOptionbmdToolStripMenuItem.Size = new Size(236, 22);
      this.itemAddOptionbmdToolStripMenuItem.Text = "ItemAddOption.bmd";
      this.itemAddOptionbmdToolStripMenuItem.Click += new EventHandler(this.loadToolStripMenuItem_IAO_Click);
      this.jewelOfHarmonySmeltbmdToolStripMenuItem.Name = "jewelOfHarmonySmeltbmdToolStripMenuItem";
      this.jewelOfHarmonySmeltbmdToolStripMenuItem.Size = new Size(236, 22);
      this.jewelOfHarmonySmeltbmdToolStripMenuItem.Text = "JewelOfHarmonySmelt.bmd";
      this.jewelOfHarmonySmeltbmdToolStripMenuItem.Click += new EventHandler(this.loadToolStripMenuItem_JOHS_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(233, 6);
      this.skillbmdToolStripMenuItem_Load.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.skillbmdToolStripMenuItem_S6E3_Load,
        (ToolStripItem) this.skillbmdToolStripMenuItem_ExS8E1_Load
      });
      this.skillbmdToolStripMenuItem_Load.Name = "skillbmdToolStripMenuItem_Load";
      this.skillbmdToolStripMenuItem_Load.Size = new Size(236, 22);
      this.skillbmdToolStripMenuItem_Load.Text = "Skill.bmd";
      this.skillbmdToolStripMenuItem_S6E3_Load.Name = "skillbmdToolStripMenuItem_S6E3_Load";
      this.skillbmdToolStripMenuItem_S6E3_Load.Size = new Size(191, 22);
      this.skillbmdToolStripMenuItem_S6E3_Load.Text = "Season 6 Episode 3";
      this.skillbmdToolStripMenuItem_S6E3_Load.Click += new EventHandler(this.loadToolStripMenuItem_Skill_S6E3BMD_Click);
      this.skillbmdToolStripMenuItem_ExS8E1_Load.Name = "skillbmdToolStripMenuItem_ExS8E1_Load";
      this.skillbmdToolStripMenuItem_ExS8E1_Load.Size = new Size(191, 22);
      this.skillbmdToolStripMenuItem_ExS8E1_Load.Text = "Ex700-2 / S8E1";
      this.skillbmdToolStripMenuItem_ExS8E1_Load.Click += new EventHandler(this.loadToolStripMenuItem_Skill_ExS8E1BMD_Click);
      this.slidebmdToolStripMenuItem_Load.Name = "slidebmdToolStripMenuItem_Load";
      this.slidebmdToolStripMenuItem_Load.Size = new Size(236, 22);
      this.slidebmdToolStripMenuItem_Load.Text = "Slide.bmd";
      this.slidebmdToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_SlideBMD_Click);
      this.serverListbmdEx700ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ToolStripMenuItem_ServerList_S6E3,
        (ToolStripItem) this.ex700ToolStripMenuItem_ServerListBMD
      });
      this.serverListbmdEx700ToolStripMenuItem.Name = "serverListbmdEx700ToolStripMenuItem";
      this.serverListbmdEx700ToolStripMenuItem.Size = new Size(236, 22);
      this.serverListbmdEx700ToolStripMenuItem.Text = "ServerList.bmd";
      this.ToolStripMenuItem_ServerList_S6E3.Name = "ToolStripMenuItem_ServerList_S6E3";
      this.ToolStripMenuItem_ServerList_S6E3.Size = new Size(225, 22);
      this.ToolStripMenuItem_ServerList_S6E3.Text = "Season 6 Episode 3";
      this.ToolStripMenuItem_ServerList_S6E3.Click += new EventHandler(this.loadToolStripMenuItem_SererListS6E3_Click);
      this.ex700ToolStripMenuItem_ServerListBMD.Name = "ex700ToolStripMenuItem_ServerListBMD";
      this.ex700ToolStripMenuItem_ServerListBMD.Size = new Size(225, 22);
      this.ex700ToolStripMenuItem_ServerListBMD.Text = "Ex700 / Ex700 Plus / S8E1";
      this.ex700ToolStripMenuItem_ServerListBMD.Click += new EventHandler(this.loadToolStripMenuItem_SererListEx700_Click);
      this.textbmdToolStripMenuItem_Load.Name = "textbmdToolStripMenuItem_Load";
      this.textbmdToolStripMenuItem_Load.Size = new Size(236, 22);
      this.textbmdToolStripMenuItem_Load.Text = "Text.bmd";
      this.textbmdToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_TextBMD_Click);
      this.gatebmdToolStripMenuItem_Load.Name = "gatebmdToolStripMenuItem_Load";
      this.gatebmdToolStripMenuItem_Load.Size = new Size(236, 22);
      this.gatebmdToolStripMenuItem_Load.Text = "Gate.bmd";
      this.gatebmdToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_Gate_Click);
      this.moveReqbmdEx700ToolStripMenuItem_Load.Name = "moveReqbmdEx700ToolStripMenuItem_Load";
      this.moveReqbmdEx700ToolStripMenuItem_Load.Size = new Size(236, 22);
      this.moveReqbmdEx700ToolStripMenuItem_Load.Text = "MoveReq[.bmd/.dat]";
      this.moveReqbmdEx700ToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_MR_Click);
      this.minimapWorldXbmdToolStripMenuItem_Load.Name = "minimapWorldXbmdToolStripMenuItem_Load";
      this.minimapWorldXbmdToolStripMenuItem_Load.Size = new Size(236, 22);
      this.minimapWorldXbmdToolStripMenuItem_Load.Text = "Minimap_WorldX.bmd";
      this.minimapWorldXbmdToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_Minimap_Click);
      this.mixToolStripMenuItem_Load.Name = "mixToolStripMenuItem_Load";
      this.mixToolStripMenuItem_Load.Size = new Size(236, 22);
      this.mixToolStripMenuItem_Load.Text = "Mix.bmd";
      this.mixToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_MixBMD_Click);
      this.npcNamebmsdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ex700ToolStripMenuItem_NpcNameEx700BMD,
        (ToolStripItem) this.ex700ToolStripMenuItem_NpcNameEx700PlusBMD
      });
      this.npcNamebmsdToolStripMenuItem.Name = "npcNamebmsdToolStripMenuItem";
      this.npcNamebmsdToolStripMenuItem.Size = new Size(236, 22);
      this.npcNamebmsdToolStripMenuItem.Text = "NpcName.bmd";
      this.ex700ToolStripMenuItem_NpcNameEx700BMD.Name = "ex700ToolStripMenuItem_NpcNameEx700BMD";
      this.ex700ToolStripMenuItem_NpcNameEx700BMD.Size = new Size(178, 22);
      this.ex700ToolStripMenuItem_NpcNameEx700BMD.Text = "Ex700";
      this.ex700ToolStripMenuItem_NpcNameEx700BMD.Click += new EventHandler(this.loadToolStripMenuItem_NpcName700_Click);
      this.ex700ToolStripMenuItem_NpcNameEx700PlusBMD.Name = "ex700ToolStripMenuItem_NpcNameEx700PlusBMD";
      this.ex700ToolStripMenuItem_NpcNameEx700PlusBMD.Size = new Size(178, 22);
      this.ex700ToolStripMenuItem_NpcNameEx700PlusBMD.Text = "Ex700 Plus / S8E1";
      this.ex700ToolStripMenuItem_NpcNameEx700PlusBMD.Click += new EventHandler(this.loadToolStripMenuItem_NpcNameEx700Plus_Click);
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(233, 6);
      this.filterbmdToolStripMenuItem_Load.Name = "filterbmdToolStripMenuItem_Load";
      this.filterbmdToolStripMenuItem_Load.Size = new Size(236, 22);
      this.filterbmdToolStripMenuItem_Load.Text = "Filter.bmd";
      this.filterbmdToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_FilterBMD_Click);
      this.filterNamebmdToolStripMenuItem_Load.Name = "filterNamebmdToolStripMenuItem_Load";
      this.filterNamebmdToolStripMenuItem_Load.Size = new Size(236, 22);
      this.filterNamebmdToolStripMenuItem_Load.Text = "FilterName.bmd";
      this.filterNamebmdToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_FilterNameBMD_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(233, 6);
      this.monsterbmdToolStripMenuItem_Load.Name = "monsterbmdToolStripMenuItem_Load";
      this.monsterbmdToolStripMenuItem_Load.Size = new Size(236, 22);
      this.monsterbmdToolStripMenuItem_Load.Text = "Monster.bmd";
      this.monsterbmdToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_Monster_Click);
      this.glowbmdToolStripMenuItem_Load.Name = "glowbmdToolStripMenuItem_Load";
      this.glowbmdToolStripMenuItem_Load.Size = new Size(236, 22);
      this.glowbmdToolStripMenuItem_Load.Text = "Glow.bmd";
      this.glowbmdToolStripMenuItem_Load.Click += new EventHandler(this.loadToolStripMenuItem_Glow_Click);
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new Size(233, 6);
      this.computeIGCCRCToolStripMenuItem.Name = "computeIGCCRCToolStripMenuItem";
      this.computeIGCCRCToolStripMenuItem.Size = new Size(236, 22);
      this.computeIGCCRCToolStripMenuItem.Text = "Compute MU CRC";
      this.computeIGCCRCToolStripMenuItem.Click += new EventHandler(this.computeIGCCRCToolStripMenuItem_Click);
      this.serverToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.monsterSetBaseToolStripMenuItem,
        (ToolStripItem) this.shopToolStripMenuItem,
        (ToolStripItem) this.eventBagToolStripMenuItem,
        (ToolStripItem) this.cashShopToolStripMenuItem,
        (ToolStripItem) this.iGCDropManagerEditorToolStripMenuItem
      });
      this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
      this.serverToolStripMenuItem.Size = new Size(93, 21);
      this.serverToolStripMenuItem.Text = "Server Tools";
      this.monsterSetBaseToolStripMenuItem.Name = "monsterSetBaseToolStripMenuItem";
      this.monsterSetBaseToolStripMenuItem.Size = new Size(266, 22);
      this.monsterSetBaseToolStripMenuItem.Text = "Monster, MonsterSetBase Editor";
      this.monsterSetBaseToolStripMenuItem.Click += new EventHandler(this.monsterSetBaseToolStripMenuItem_Click);
      this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
      this.shopToolStripMenuItem.Size = new Size(266, 22);
      this.shopToolStripMenuItem.Text = "Shop Editor";
      this.shopToolStripMenuItem.Click += new EventHandler(this.shopToolStripMenuItem_Click);
      this.eventBagToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.textOldToolStripMenuItem,
        (ToolStripItem) this.xMLNewToolStripMenuItem
      });
      this.eventBagToolStripMenuItem.Name = "eventBagToolStripMenuItem";
      this.eventBagToolStripMenuItem.Size = new Size(266, 22);
      this.eventBagToolStripMenuItem.Text = "EventBag Editor";
      this.textOldToolStripMenuItem.Name = "textOldToolStripMenuItem";
      this.textOldToolStripMenuItem.Size = new Size(140, 22);
      this.textOldToolStripMenuItem.Text = "Text (Old)";
      this.textOldToolStripMenuItem.Click += new EventHandler(this.eventBagToolStripMenuItem_Click);
      this.xMLNewToolStripMenuItem.Name = "xMLNewToolStripMenuItem";
      this.xMLNewToolStripMenuItem.Size = new Size(140, 22);
      this.xMLNewToolStripMenuItem.Text = "XML (New)";
      this.xMLNewToolStripMenuItem.Click += new EventHandler(this.xMLNewToolStripMenuItem_Click);
      this.cashShopToolStripMenuItem.Name = "cashShopToolStripMenuItem";
      this.cashShopToolStripMenuItem.Size = new Size(266, 22);
      this.cashShopToolStripMenuItem.Text = "CashShop Editor";
      this.cashShopToolStripMenuItem.Click += new EventHandler(this.cSToolStripMenuItem_Click);
      this.iGCDropManagerEditorToolStripMenuItem.Name = "iGCDropManagerEditorToolStripMenuItem";
      this.iGCDropManagerEditorToolStripMenuItem.Size = new Size(266, 22);
      this.iGCDropManagerEditorToolStripMenuItem.Text = "MU DropManager Editor";
      this.iGCDropManagerEditorToolStripMenuItem.Click += new EventHandler(this.iGCDropManagerEditorToolStripMenuItem_Click);
      this.configToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.itemListSettingsTypeToolStripMenuItem
      });
      this.configToolStripMenuItem.Name = "configToolStripMenuItem";
      this.configToolStripMenuItem.Size = new Size(64, 21);
      this.configToolStripMenuItem.Text = "Configs";
      this.itemListSettingsTypeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ex700ItemList_ToolStripMenuItem_ON,
        (ToolStripItem) this.s6e3ItemList_ToolStripMenuItem_ON
      });
      this.itemListSettingsTypeToolStripMenuItem.Name = "itemListSettingsTypeToolStripMenuItem";
      this.itemListSettingsTypeToolStripMenuItem.Size = new Size(199, 22);
      this.itemListSettingsTypeToolStripMenuItem.Text = "ItemListSettings Type";
      this.ex700ItemList_ToolStripMenuItem_ON.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.ex700ItemList_ToolStripMenuItem_ON.Name = "ex700ItemList_ToolStripMenuItem_ON";
      this.ex700ItemList_ToolStripMenuItem_ON.Size = new Size(230, 22);
      this.ex700ItemList_ToolStripMenuItem_ON.Text = "New - Ex700 and Upwards";
      this.ex700ItemList_ToolStripMenuItem_ON.Click += new EventHandler(this.ex700ItemList_ToolStripMenuItem_ON_Click);
      this.s6e3ItemList_ToolStripMenuItem_ON.Name = "s6e3ItemList_ToolStripMenuItem_ON";
      this.s6e3ItemList_ToolStripMenuItem_ON.Size = new Size(230, 22);
      this.s6e3ItemList_ToolStripMenuItem_ON.Text = "Old - s6e3 and Backwards";
      this.s6e3ItemList_ToolStripMenuItem_ON.Click += new EventHandler(this.s6e3ItemList_ToolStripMenuItem_ON_Click);
      this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.aboutToolStripMenuItem
      });
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new Size(47, 21);
      this.helpToolStripMenuItem.Text = "Help";
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new Size(152, 22);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
      this.backgroundWorker.WorkerReportsProgress = true;
      this.backgroundWorker.DoWork += new DoWorkEventHandler(this.backgroundWorker_DoWork);
      this.backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
      this.backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
      this.panel1.Controls.Add((Control) this.progressBar_Loading);
      this.panel1.Location = new Point(0, 75);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1009, 378);
      this.panel1.TabIndex = 3;
      this.progressBar_Loading.Location = new Point(341, 231);
      this.progressBar_Loading.MarqueeAnimationSpeed = 30;
      this.progressBar_Loading.Name = "progressBar_Loading";
      this.progressBar_Loading.Size = new Size(348, 37);
      this.progressBar_Loading.Style = ProgressBarStyle.Marquee;
      this.progressBar_Loading.TabIndex = 0;
      this.progressBar_Loading.Value = 100;
      this.progressBar_Loading.Visible = false;
      this.toolStrip_RowOptions.Enabled = false;
      this.toolStrip_RowOptions.GripStyle = ToolStripGripStyle.Hidden;
      this.toolStrip_RowOptions.Items.AddRange(new ToolStripItem[14]
      {
        (ToolStripItem) this.toolStripLabel_FileName1,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.toolStripButton_AddRow,
        (ToolStripItem) this.toolStripButton_RemoveSelectedRow,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.toolStripButton_Search,
        (ToolStripItem) this.toolStripButton_BmdItemAdder,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripButton_Open,
        (ToolStripItem) this.toolStripButton_Save,
        (ToolStripItem) this.toolStripButton_Export,
        (ToolStripItem) this.toolStripButton_SaveTXT,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripProgressBar_Save
      });
      this.toolStrip_RowOptions.Location = new Point(0, 25);
      this.toolStrip_RowOptions.Name = "toolStrip_RowOptions";
      this.toolStrip_RowOptions.Size = new Size(1010, 32);
      this.toolStrip_RowOptions.TabIndex = 11;
      this.toolStrip_RowOptions.Text = "toolStrip1";
      this.toolStripLabel_FileName1.ForeColor = Color.Red;
      this.toolStripLabel_FileName1.Name = "toolStripLabel_FileName1";
      this.toolStripLabel_FileName1.Padding = new Padding(10, 0, 0, 0);
      this.toolStripLabel_FileName1.Size = new Size(10, 29);
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new Size(6, 32);
      this.toolStripButton_AddRow.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton_AddRow.Image = (Image) Resources.toolStripButton_AddRow_Image;
      this.toolStripButton_AddRow.ImageScaling = ToolStripItemImageScaling.None;
      this.toolStripButton_AddRow.ImageTransparentColor = Color.Magenta;
      this.toolStripButton_AddRow.Name = "toolStripButton_AddRow";
      this.toolStripButton_AddRow.Padding = new Padding(10, 0, 0, 0);
      this.toolStripButton_AddRow.Size = new Size(39, 29);
      this.toolStripButton_AddRow.Text = "Add New Row";
      this.toolStripButton_AddRow.Click += new EventHandler(this.toolStripButton_AddRow_Click);
      this.toolStripButton_RemoveSelectedRow.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton_RemoveSelectedRow.Image = (Image) Resources.toolStripButton_RemoveSelectedRow_Image;
      this.toolStripButton_RemoveSelectedRow.ImageScaling = ToolStripItemImageScaling.None;
      this.toolStripButton_RemoveSelectedRow.ImageTransparentColor = Color.Magenta;
      this.toolStripButton_RemoveSelectedRow.Name = "toolStripButton_RemoveSelectedRow";
      this.toolStripButton_RemoveSelectedRow.Padding = new Padding(10, 0, 0, 0);
      this.toolStripButton_RemoveSelectedRow.Size = new Size(39, 29);
      this.toolStripButton_RemoveSelectedRow.Text = "Remove Selected Row";
      this.toolStripButton_RemoveSelectedRow.Click += new EventHandler(this.toolStripButton_RemoveSelectedRow_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Padding = new Padding(10, 0, 0, 0);
      this.toolStripSeparator5.Size = new Size(6, 32);
      this.toolStripButton_Search.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton_Search.Image = (Image) Resources.toolStripButton_Search_Image;
      this.toolStripButton_Search.ImageScaling = ToolStripItemImageScaling.None;
      this.toolStripButton_Search.ImageTransparentColor = Color.Magenta;
      this.toolStripButton_Search.Name = "toolStripButton_Search";
      this.toolStripButton_Search.Padding = new Padding(10, 0, 0, 0);
      this.toolStripButton_Search.Size = new Size(39, 29);
      this.toolStripButton_Search.Text = "Find";
      this.toolStripButton_Search.ToolTipText = "Find [Ctrl + F]";
      this.toolStripButton_Search.Click += new EventHandler(this.toolStripButton_Search_Click);
      this.toolStripButton_BmdItemAdder.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton_BmdItemAdder.Image = (Image) Resources.toolStripButton_BmdItemAdder_Image;
      this.toolStripButton_BmdItemAdder.ImageScaling = ToolStripItemImageScaling.None;
      this.toolStripButton_BmdItemAdder.ImageTransparentColor = Color.Magenta;
      this.toolStripButton_BmdItemAdder.Name = "toolStripButton_BmdItemAdder";
      this.toolStripButton_BmdItemAdder.Padding = new Padding(10, 0, 0, 0);
      this.toolStripButton_BmdItemAdder.Size = new Size(39, 29);
      this.toolStripButton_BmdItemAdder.Text = "Item Adder";
      this.toolStripButton_BmdItemAdder.ToolTipText = "Item Adder";
      this.toolStripButton_BmdItemAdder.Click += new EventHandler(this.toolStripButton_BmdItemAdder_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Padding = new Padding(10, 0, 0, 0);
      this.toolStripSeparator2.Size = new Size(6, 32);
      this.toolStripButton_Open.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton_Open.Image = (Image) Resources.toolStripButton_Open_Image;
      this.toolStripButton_Open.ImageScaling = ToolStripItemImageScaling.None;
      this.toolStripButton_Open.ImageTransparentColor = Color.Magenta;
      this.toolStripButton_Open.Name = "toolStripButton_Open";
      this.toolStripButton_Open.Padding = new Padding(10, 0, 0, 0);
      this.toolStripButton_Open.Size = new Size(39, 29);
      this.toolStripButton_Open.Text = "Open (Same BMD type)";
      this.toolStripButton_Open.Click += new EventHandler(this.toolStripButton_Open_Click);
      this.toolStripButton_Save.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton_Save.Image = (Image) Resources.toolStripButton_Save_Image;
      this.toolStripButton_Save.ImageScaling = ToolStripItemImageScaling.None;
      this.toolStripButton_Save.ImageTransparentColor = Color.Magenta;
      this.toolStripButton_Save.Name = "toolStripButton_Save";
      this.toolStripButton_Save.Padding = new Padding(10, 0, 0, 0);
      this.toolStripButton_Save.Size = new Size(39, 29);
      this.toolStripButton_Save.Text = "Save as BMD";
      this.toolStripButton_Save.Click += new EventHandler(this.toolStripButton_Save_Click);
      this.toolStripButton_Export.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton_Export.Image = (Image) Resources.toolStripButton_Export_Image;
      this.toolStripButton_Export.ImageScaling = ToolStripItemImageScaling.None;
      this.toolStripButton_Export.ImageTransparentColor = Color.Magenta;
      this.toolStripButton_Export.Name = "toolStripButton_Export";
      this.toolStripButton_Export.Padding = new Padding(10, 0, 0, 0);
      this.toolStripButton_Export.Size = new Size(38, 29);
      this.toolStripButton_Export.Text = "Export to Server";
      this.toolStripButton_Export.Click += new EventHandler(this.toolStripButton_Export_Click);
      this.toolStripButton_SaveTXT.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton_SaveTXT.Image = (Image) Resources.toolStripButton_SaveTXT_Image;
      this.toolStripButton_SaveTXT.ImageScaling = ToolStripItemImageScaling.None;
      this.toolStripButton_SaveTXT.ImageTransparentColor = Color.Magenta;
      this.toolStripButton_SaveTXT.Name = "toolStripButton_SaveTXT";
      this.toolStripButton_SaveTXT.Padding = new Padding(10, 0, 0, 0);
      this.toolStripButton_SaveTXT.Size = new Size(39, 29);
      this.toolStripButton_SaveTXT.Text = "Save as tabbed Text file";
      this.toolStripButton_SaveTXT.Click += new EventHandler(this.toolStripButton_SaveTXT_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Padding = new Padding(10, 0, 0, 0);
      this.toolStripSeparator1.Size = new Size(6, 32);
      this.toolStripProgressBar_Save.Name = "toolStripProgressBar_Save";
      this.toolStripProgressBar_Save.Padding = new Padding(10, 0, 0, 0);
      this.toolStripProgressBar_Save.Size = new Size(100, 29);
      this.toolStripProgressBar_Save.Visible = false;
      this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripLabel_FileName2
      });
      this.toolStrip1.Location = new Point(0, 57);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(1010, 25);
      this.toolStrip1.TabIndex = 12;
      this.toolStrip1.Text = "toolStrip1";
      this.toolStripLabel_FileName2.ForeColor = Color.Green;
      this.toolStripLabel_FileName2.Name = "toolStripLabel_FileName2";
      this.toolStripLabel_FileName2.Padding = new Padding(10, 0, 0, 0);
      this.toolStripLabel_FileName2.Size = new Size(10, 22);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1010, 472);
      this.Controls.Add((Control) this.toolStrip1);
      this.Controls.Add((Control) this.toolStrip_RowOptions);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.statusStrip1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip1;
      this.Name = nameof (Form1);
      this.Text = "MU.ToolKit [Silver Edition]";
      this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new EventHandler(this.Form1_Load);
      this.SizeChanged += new EventHandler(this.Form1_SizeChanged);
      this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.toolStrip_RowOptions.ResumeLayout(false);
      this.toolStrip_RowOptions.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void initializeFilterGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Text", "Text");
      dgv.Columns["Text"].ValueType = typeof (string);
      dgv.Columns["Text"].ToolTipText = "Unlimited Length";
      dgv.Columns["Text"].Width = 512;
      dgv.Columns["Text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeFilterNameGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Text", "Text");
      dgv.Columns["Text"].ValueType = typeof (string);
      dgv.Columns["Text"].ToolTipText = "Maximum 20 Characters";
      dgv.Columns["Text"].Width = 512;
      dgv.Columns["Text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeGateGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Type", "Type");
      dgv.Columns["Type"].ValueType = typeof (byte);
      dgv.Columns["Type"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Map ID", "Map ID");
      dgv.Columns["Map ID"].ValueType = typeof (byte);
      dgv.Columns["Map ID"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("X 1", "X 1");
      dgv.Columns["X 1"].ValueType = typeof (byte);
      dgv.Columns["X 1"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns["X 1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["X 1"].Width = 50;
      dgv.Columns.Add("Y 1", "Y 1");
      dgv.Columns["Y 1"].ValueType = typeof (byte);
      dgv.Columns["Y 1"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns["Y 1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Y 1"].Width = 50;
      dgv.Columns.Add("X 2", "X 2");
      dgv.Columns["X 2"].ValueType = typeof (byte);
      dgv.Columns["X 2"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns["X 2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["X 2"].Width = 50;
      dgv.Columns.Add("Y 2", "Y 2");
      dgv.Columns["Y 2"].ValueType = typeof (byte);
      dgv.Columns["Y 2"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns["Y 2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Y 2"].Width = 50;
      dgv.Columns.Add("Target", "Target");
      dgv.Columns["Target"].ValueType = typeof (ushort);
      dgv.Columns["Target"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Direction", "Direction");
      dgv.Columns["Direction"].ValueType = typeof (byte);
      dgv.Columns["Direction"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Unk_1", "Unk_1");
      dgv.Columns["Unk_1"].ValueType = typeof (byte);
      dgv.Columns["Unk_1"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Minimum Level", "Minimum Level");
      dgv.Columns["Minimum Level"].ValueType = typeof (ushort);
      dgv.Columns["Minimum Level"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Maximum Level", "Maximum Level");
      dgv.Columns["Maximum Level"].ValueType = typeof (ushort);
      dgv.Columns["Maximum Level"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeGlowGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.Columns.Add("Item Group", "Item Group");
      dgv.Columns["Item Group"].ValueType = typeof (uint);
      dgv.Columns["Item Group"].ToolTipText = "0 <= Value(Numbers) <= 15";
      dgv.Columns.Add("Item Index", "Item Index");
      dgv.Columns["Item Index"].ValueType = typeof (uint);
      dgv.Columns["Item Index"].ToolTipText = "0 <= Value(Numbers) <= 512";
      dgv.Columns.Add("R Color", "R Color");
      dgv.Columns["R Color"].ValueType = typeof (byte);
      dgv.Columns["R Color"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("G Color", "G Color");
      dgv.Columns["G Color"].ValueType = typeof (byte);
      dgv.Columns["G Color"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("B Color", "B Color");
      dgv.Columns["B Color"].ValueType = typeof (byte);
      dgv.Columns["B Color"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
    }

    public void initializeIAOGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Group", "Group");
      dgv.Columns["Group"].ReadOnly = true;
      dgv.Columns["Group"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Index", "Index");
      dgv.Columns["Index"].ReadOnly = true;
      dgv.Columns["Index"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("v1", "v1");
      dgv.Columns["v1"].ValueType = typeof (short);
      dgv.Columns["v1"].ToolTipText = short.MinValue.ToString() + " <= Value(Numbers) <= " + short.MaxValue.ToString();
      dgv.Columns.Add("v2", "v2");
      dgv.Columns["v2"].ValueType = typeof (short);
      dgv.Columns["v2"].ToolTipText = short.MinValue.ToString() + " <= Value(Numbers) <= " + short.MaxValue.ToString();
      dgv.Columns.Add("v3", "v3");
      dgv.Columns["v3"].ValueType = typeof (short);
      dgv.Columns["v3"].ToolTipText = short.MinValue.ToString() + " <= Value(Numbers) <= " + short.MaxValue.ToString();
      dgv.Columns.Add("v4", "v4");
      dgv.Columns["v4"].ValueType = typeof (short);
      dgv.Columns["v4"].ToolTipText = short.MinValue.ToString() + " <= Value(Numbers) <= " + short.MaxValue.ToString();
      dgv.Columns.Add("v5", "v5");
      dgv.Columns["v5"].ValueType = typeof (int);
      dgv.Columns["v5"].ToolTipText = int.MinValue.ToString() + " <= Value(Numbers) <= " + int.MaxValue.ToString();
      dgv.Columns.Add("v6", "v6");
      dgv.Columns["v6"].ValueType = typeof (int);
      dgv.Columns["v6"].ToolTipText = int.MinValue.ToString() + " <= Value(Numbers) <= " + int.MaxValue.ToString();
    }

    public void initializeISTGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Group", "Group");
      dgv.Columns["Group"].ReadOnly = true;
      dgv.Columns["Group"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Index", "Index");
      dgv.Columns["Index"].ReadOnly = true;
      dgv.Columns["Index"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("v1", "v1");
      dgv.Columns["v1"].ValueType = typeof (byte);
      dgv.Columns["v1"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("v2", "v2");
      dgv.Columns["v2"].ValueType = typeof (byte);
      dgv.Columns["v2"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("v3", "v3");
      dgv.Columns["v3"].ValueType = typeof (byte);
      dgv.Columns["v3"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("v4", "v4");
      dgv.Columns["v4"].ValueType = typeof (byte);
      dgv.Columns["v4"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
    }

    public void initializeItem_S6E3Grid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Group", "Group");
      dgv.Columns["Group"].ValueType = typeof (ushort);
      dgv.Columns["Group"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Group"].ReadOnly = true;
      dgv.Columns["Group"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Index", "Index");
      dgv.Columns["Index"].ValueType = typeof (ushort);
      dgv.Columns["Index"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Index"].ReadOnly = true;
      dgv.Columns["Index"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 30";
      dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Name"].Width = 300;
      dgv.Columns.Add("Two Hands", "Two Hands");
      dgv.Columns["Two Hands"].ValueType = typeof (byte);
      dgv.Columns["Two Hands"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Level", "Level");
      dgv.Columns["Level"].ValueType = typeof (ushort);
      dgv.Columns["Level"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Slot", "Slot");
      dgv.Columns["Slot"].ValueType = typeof (ushort);
      dgv.Columns["Slot"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Skill", "Skill");
      dgv.Columns["Skill"].ValueType = typeof (ushort);
      dgv.Columns["Skill"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("X", "X");
      dgv.Columns["X"].ValueType = typeof (byte);
      dgv.Columns["X"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Y", "Y");
      dgv.Columns["Y"].ValueType = typeof (byte);
      dgv.Columns["Y"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Min Dmg", "Min Dmg");
      dgv.Columns["Min Dmg"].ValueType = typeof (byte);
      dgv.Columns["Min Dmg"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Max Dmg", "Max Dmg");
      dgv.Columns["Max Dmg"].ValueType = typeof (byte);
      dgv.Columns["Max Dmg"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Def Rate", "Def Rate");
      dgv.Columns["Def Rate"].ValueType = typeof (byte);
      dgv.Columns["Def Rate"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Defense", "Defense");
      dgv.Columns["Defense"].ValueType = typeof (byte);
      dgv.Columns["Defense"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Unk_1", "Unk_1");
      dgv.Columns["Unk_1"].ValueType = typeof (byte);
      dgv.Columns["Unk_1"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("AtkSpeed", "AtkSpeed");
      dgv.Columns["AtkSpeed"].ValueType = typeof (byte);
      dgv.Columns["AtkSpeed"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Unk_2", "Unk_2");
      dgv.Columns["Unk_2"].ValueType = typeof (byte);
      dgv.Columns["Unk_2"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Durability", "Durability");
      dgv.Columns["Durability"].ValueType = typeof (byte);
      dgv.Columns["Durability"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("MagicDur", "MagicDur");
      dgv.Columns["MagicDur"].ValueType = typeof (byte);
      dgv.Columns["MagicDur"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("MagicPwr", "MagicPwr");
      dgv.Columns["MagicPwr"].ValueType = typeof (byte);
      dgv.Columns["MagicPwr"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("ReqStr", "ReqStr");
      dgv.Columns["ReqStr"].ValueType = typeof (ushort);
      dgv.Columns["ReqStr"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqDex", "ReqDex");
      dgv.Columns["ReqDex"].ValueType = typeof (ushort);
      dgv.Columns["ReqDex"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqEne", "ReqEne");
      dgv.Columns["ReqEne"].ValueType = typeof (ushort);
      dgv.Columns["ReqEne"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqVit", "ReqVit");
      dgv.Columns["ReqVit"].ValueType = typeof (ushort);
      dgv.Columns["ReqVit"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqLea", "ReqLea");
      dgv.Columns["ReqLea"].ValueType = typeof (ushort);
      dgv.Columns["ReqLea"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqLvl", "ReqLvl");
      dgv.Columns["ReqLvl"].ValueType = typeof (ushort);
      dgv.Columns["ReqLvl"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ItemValue", "ItemValue");
      dgv.Columns["ItemValue"].ValueType = typeof (byte);
      dgv.Columns["ItemValue"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Unk_4", "Unk_4");
      dgv.Columns["Unk_4"].ValueType = typeof (byte);
      dgv.Columns["Unk_4"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Zen", "Zen");
      dgv.Columns["Zen"].ValueType = typeof (uint);
      dgv.Columns["Zen"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Type", "Type");
      dgv.Columns["Type"].ValueType = typeof (byte);
      dgv.Columns["Type"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("DW/SM/GM", "DW/SM/GM");
      dgv.Columns["DW/SM/GM"].ValueType = typeof (byte);
      dgv.Columns["DW/SM/GM"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("DK/BK/BM", "DK/BK/BM");
      dgv.Columns["DK/BK/BM"].ValueType = typeof (byte);
      dgv.Columns["DK/BK/BM"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Elf/ME/HE", "Elf/ME/HE");
      dgv.Columns["Elf/ME/HE"].ValueType = typeof (byte);
      byte num = 0;
      byte maxValue1 = byte.MaxValue;
      dgv.Columns["Elf/ME/HE"].ToolTipText = maxValue1.ToString() + " <= Value(Numbers) <= " + maxValue1.ToString();
      dgv.Columns.Add("MG/DM", "MG/DM");
      dgv.Columns["MG/DM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue2 = byte.MaxValue;
      dgv.Columns["MG/DM"].ToolTipText = maxValue2.ToString() + " <= Value(Numbers) <= " + maxValue2.ToString();
      dgv.Columns.Add("DL/LE", "DL/LE");
      dgv.Columns["DL/LE"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue3 = byte.MaxValue;
      dgv.Columns["DL/LE"].ToolTipText = maxValue3.ToString() + " <= Value(Numbers) <= " + maxValue3.ToString();
      dgv.Columns.Add("SUM/BS/DM", "SUM/BS/DM");
      dgv.Columns["SUM/BS/DM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue4 = byte.MaxValue;
      dgv.Columns["SUM/BS/DM"].ToolTipText = maxValue4.ToString() + " <= Value(Numbers) <= " + maxValue4.ToString();
      dgv.Columns.Add("RF/FM", "RF/FM");
      dgv.Columns["RF/FM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue5 = byte.MaxValue;
      dgv.Columns["RF/FM"].ToolTipText = maxValue5.ToString() + " <= Value(Numbers) <= " + maxValue5.ToString();
      dgv.Columns.Add("Ice Attribute", "Ice Attribute");
      dgv.Columns["Ice Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue6 = byte.MaxValue;
      dgv.Columns["Ice Attribute"].ToolTipText = maxValue6.ToString() + " <= Value(Numbers) <= " + maxValue6.ToString();
      dgv.Columns.Add("Poison Attribute", "Poison Attribute");
      dgv.Columns["Poison Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue7 = byte.MaxValue;
      dgv.Columns["Poison Attribute"].ToolTipText = maxValue7.ToString() + " <= Value(Numbers) <= " + maxValue7.ToString();
      dgv.Columns.Add("Lightning Attribute", "Lightning Attribute");
      dgv.Columns["Lightning Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue8 = byte.MaxValue;
      dgv.Columns["Lightning Attribute"].ToolTipText = maxValue8.ToString() + " <= Value(Numbers) <= " + maxValue8.ToString();
      dgv.Columns.Add("Fire Attribute", "Fire Attribute");
      dgv.Columns["Fire Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue9 = byte.MaxValue;
      dgv.Columns["Fire Attribute"].ToolTipText = maxValue9.ToString() + " <= Value(Numbers) <= " + maxValue9.ToString();
      dgv.Columns.Add("Earth Attribute", "Earth Attribute");
      dgv.Columns["Earth Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue10 = byte.MaxValue;
      dgv.Columns["Earth Attribute"].ToolTipText = maxValue10.ToString() + " <= Value(Numbers) <= " + maxValue10.ToString();
      dgv.Columns.Add("Wind Attribute", "Wind Attribute");
      dgv.Columns["Wind Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue11 = byte.MaxValue;
      dgv.Columns["Wind Attribute"].ToolTipText = maxValue11.ToString() + " <= Value(Numbers) <= " + maxValue11.ToString();
      dgv.Columns.Add("Water Attribute", "Water Attribute");
      dgv.Columns["Water Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue12 = byte.MaxValue;
      dgv.Columns["Water Attribute"].ToolTipText = maxValue12.ToString() + " <= Value(Numbers) <= " + maxValue12.ToString();
      dgv.Columns.Add("Unk_6", "Unk_6");
      dgv.Columns["Unk_6"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue13 = byte.MaxValue;
      dgv.Columns["Unk_6"].ToolTipText = maxValue13.ToString() + " <= Value(Numbers) <= " + maxValue13.ToString();
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    public void initializeItemEx700Grid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Unk_1", "Unk_1");
      dgv.Columns["Unk_1"].ValueType = typeof (ushort);
      dgv.Columns["Unk_1"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Unk_2", "Unk_2");
      dgv.Columns["Unk_2"].ValueType = typeof (ushort);
      dgv.Columns["Unk_2"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Unk_3", "Unk_3");
      dgv.Columns["Unk_3"].ValueType = typeof (byte);
      dgv.Columns["Unk_3"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Unk_4", "Unk_4");
      dgv.Columns["Unk_4"].ValueType = typeof (byte);
      dgv.Columns["Unk_4"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Group", "Group");
      dgv.Columns["Group"].ValueType = typeof (ushort);
      dgv.Columns["Group"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Group"].ReadOnly = true;
      dgv.Columns["Group"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Index", "Index");
      dgv.Columns["Index"].ValueType = typeof (ushort);
      dgv.Columns["Index"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Index"].ReadOnly = true;
      dgv.Columns["Index"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Model Folder", "Model Folder");
      dgv.Columns["Model Folder"].ValueType = typeof (string);
      dgv.Columns["Model Folder"].ToolTipText = "0 <= Value(Chars) <= 260";
      dgv.Columns["Model Folder"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Model Folder"].Width = 150;
      dgv.Columns.Add("Model Name", "Model Name");
      dgv.Columns["Model Name"].ValueType = typeof (string);
      dgv.Columns["Model Name"].ToolTipText = "0 <= Value(Chars) <= 260";
      dgv.Columns["Model Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Model Name"].Width = 150;
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 30";
      dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Name"].Width = 300;
      dgv.Columns.Add("Type", "Type");
      dgv.Columns["Type"].ValueType = typeof (byte);
      dgv.Columns["Type"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Two Hands", "Two Hands");
      dgv.Columns["Two Hands"].ValueType = typeof (byte);
      dgv.Columns["Two Hands"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Level", "Level");
      dgv.Columns["Level"].ValueType = typeof (ushort);
      dgv.Columns["Level"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Slot", "Slot");
      dgv.Columns["Slot"].ValueType = typeof (ushort);
      dgv.Columns["Slot"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Skill", "Skill");
      dgv.Columns["Skill"].ValueType = typeof (ushort);
      dgv.Columns["Skill"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("X", "X");
      dgv.Columns["X"].ValueType = typeof (byte);
      dgv.Columns["X"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Y", "Y");
      dgv.Columns["Y"].ValueType = typeof (byte);
      dgv.Columns["Y"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Min Dmg", "Min Dmg");
      dgv.Columns["Min Dmg"].ValueType = typeof (byte);
      dgv.Columns["Min Dmg"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Max Dmg", "Max Dmg");
      dgv.Columns["Max Dmg"].ValueType = typeof (byte);
      dgv.Columns["Max Dmg"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Def Rate", "Def Rate");
      dgv.Columns["Def Rate"].ValueType = typeof (byte);
      dgv.Columns["Def Rate"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Defense", "Defense");
      dgv.Columns["Defense"].ValueType = typeof (ushort);
      dgv.Columns["Defense"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("AtkSpeed", "AtkSpeed");
      dgv.Columns["AtkSpeed"].ValueType = typeof (byte);
      dgv.Columns["AtkSpeed"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("WalkSpeed", "WalkSpeed");
      dgv.Columns["WalkSpeed"].ValueType = typeof (byte);
      dgv.Columns["WalkSpeed"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Durability", "Durability");
      dgv.Columns["Durability"].ValueType = typeof (byte);
      dgv.Columns["Durability"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("MagicDur", "MagicDur");
      dgv.Columns["MagicDur"].ValueType = typeof (byte);
      dgv.Columns["MagicDur"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("MagicPwr", "MagicPwr");
      dgv.Columns["MagicPwr"].ValueType = typeof (byte);
      dgv.Columns["MagicPwr"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("ReqStr", "ReqStr");
      dgv.Columns["ReqStr"].ValueType = typeof (ushort);
      dgv.Columns["ReqStr"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqDex", "ReqDex");
      dgv.Columns["ReqDex"].ValueType = typeof (ushort);
      dgv.Columns["ReqDex"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqEne", "ReqEne");
      dgv.Columns["ReqEne"].ValueType = typeof (ushort);
      dgv.Columns["ReqEne"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqVit", "ReqVit");
      dgv.Columns["ReqVit"].ValueType = typeof (ushort);
      dgv.Columns["ReqVit"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqLea", "ReqLea");
      dgv.Columns["ReqLea"].ValueType = typeof (ushort);
      dgv.Columns["ReqLea"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqLvl", "ReqLvl");
      dgv.Columns["ReqLvl"].ValueType = typeof (ushort);
      dgv.Columns["ReqLvl"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ItemValue", "ItemValue");
      dgv.Columns["ItemValue"].ValueType = typeof (ushort);
      dgv.Columns["ItemValue"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Zen", "Zen");
      dgv.Columns["Zen"].ValueType = typeof (uint);
      dgv.Columns["Zen"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("SetOption", "SetOption");
      dgv.Columns["SetOption"].ValueType = typeof (byte);
      byte num = 0;
      byte maxValue1 = byte.MaxValue;
      dgv.Columns["SetOption"].ToolTipText = maxValue1.ToString() + " <= Value(Numbers) <= " + maxValue1.ToString();
      dgv.Columns.Add("DW/SM/GM", "DW/SM/GM");
      dgv.Columns["DW/SM/GM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue2 = byte.MaxValue;
      dgv.Columns["DW/SM/GM"].ToolTipText = maxValue2.ToString() + " <= Value(Numbers) <= " + maxValue2.ToString();
      dgv.Columns.Add("DK/BK/BM", "DK/BK/BM");
      dgv.Columns["DK/BK/BM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue3 = byte.MaxValue;
      dgv.Columns["DK/BK/BM"].ToolTipText = maxValue3.ToString() + " <= Value(Numbers) <= " + maxValue3.ToString();
      dgv.Columns.Add("Elf/ME/HE", "Elf/ME/HE");
      dgv.Columns["Elf/ME/HE"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue4 = byte.MaxValue;
      dgv.Columns["Elf/ME/HE"].ToolTipText = maxValue4.ToString() + " <= Value(Numbers) <= " + maxValue4.ToString();
      dgv.Columns.Add("MG/DM", "MG/DM");
      dgv.Columns["MG/DM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue5 = byte.MaxValue;
      dgv.Columns["MG/DM"].ToolTipText = maxValue5.ToString() + " <= Value(Numbers) <= " + maxValue5.ToString();
      dgv.Columns.Add("DL/LE", "DL/LE");
      dgv.Columns["DL/LE"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue6 = byte.MaxValue;
      dgv.Columns["DL/LE"].ToolTipText = maxValue6.ToString() + " <= Value(Numbers) <= " + maxValue6.ToString();
      dgv.Columns.Add("SUM/BS/DM", "SUM/BS/DM");
      dgv.Columns["SUM/BS/DM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue7 = byte.MaxValue;
      dgv.Columns["SUM/BS/DM"].ToolTipText = maxValue7.ToString() + " <= Value(Numbers) <= " + maxValue7.ToString();
      dgv.Columns.Add("RF/FM", "RF/FM");
      dgv.Columns["RF/FM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue8 = byte.MaxValue;
      dgv.Columns["RF/FM"].ToolTipText = maxValue8.ToString() + " <= Value(Numbers) <= " + maxValue8.ToString();
      dgv.Columns.Add("Ice Attribute", "Ice Attribute");
      dgv.Columns["Ice Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue9 = byte.MaxValue;
      dgv.Columns["Ice Attribute"].ToolTipText = maxValue9.ToString() + " <= Value(Numbers) <= " + maxValue9.ToString();
      dgv.Columns.Add("Poison Attribute", "Poison Attribute");
      dgv.Columns["Poison Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue10 = byte.MaxValue;
      dgv.Columns["Poison Attribute"].ToolTipText = maxValue10.ToString() + " <= Value(Numbers) <= " + maxValue10.ToString();
      dgv.Columns.Add("Lightning Attribute", "Lightning Attribute");
      dgv.Columns["Lightning Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue11 = byte.MaxValue;
      dgv.Columns["Lightning Attribute"].ToolTipText = maxValue11.ToString() + " <= Value(Numbers) <= " + maxValue11.ToString();
      dgv.Columns.Add("Fire Attribute", "Fire Attribute");
      dgv.Columns["Fire Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue12 = byte.MaxValue;
      dgv.Columns["Fire Attribute"].ToolTipText = maxValue12.ToString() + " <= Value(Numbers) <= " + maxValue12.ToString();
      dgv.Columns.Add("Earth Attribute", "Earth Attribute");
      dgv.Columns["Earth Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue13 = byte.MaxValue;
      dgv.Columns["Earth Attribute"].ToolTipText = maxValue13.ToString() + " <= Value(Numbers) <= " + maxValue13.ToString();
      dgv.Columns.Add("Wind Attribute", "Wind Attribute");
      dgv.Columns["Wind Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue14 = byte.MaxValue;
      dgv.Columns["Wind Attribute"].ToolTipText = maxValue14.ToString() + " <= Value(Numbers) <= " + maxValue14.ToString();
      dgv.Columns.Add("Water Attribute", "Water Attribute");
      dgv.Columns["Water Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue15 = byte.MaxValue;
      dgv.Columns["Water Attribute"].ToolTipText = maxValue15.ToString() + " <= Value(Numbers) <= " + maxValue15.ToString();
      dgv.Columns.Add("Unk_5", "Unk_5");
      dgv.Columns["Unk_5"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue16 = byte.MaxValue;
      dgv.Columns["Unk_5"].ToolTipText = maxValue16.ToString() + " <= Value(Numbers) <= " + maxValue16.ToString();
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    public void initializeItemEx700PlusGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Unk_1", "Unk_1");
      dgv.Columns["Unk_1"].ValueType = typeof (ushort);
      dgv.Columns["Unk_1"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Unk_2", "Unk_2");
      dgv.Columns["Unk_2"].ValueType = typeof (ushort);
      dgv.Columns["Unk_2"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Unk_3", "Unk_3");
      dgv.Columns["Unk_3"].ValueType = typeof (byte);
      dgv.Columns["Unk_3"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Unk_4", "Unk_4");
      dgv.Columns["Unk_4"].ValueType = typeof (byte);
      dgv.Columns["Unk_4"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Group", "Group");
      dgv.Columns["Group"].ValueType = typeof (ushort);
      dgv.Columns["Group"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Group"].ReadOnly = true;
      dgv.Columns["Group"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Index", "Index");
      dgv.Columns["Index"].ValueType = typeof (ushort);
      dgv.Columns["Index"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Index"].ReadOnly = true;
      dgv.Columns["Index"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Model Folder", "Model Folder");
      dgv.Columns["Model Folder"].ValueType = typeof (string);
      dgv.Columns["Model Folder"].ToolTipText = "0 <= Value(Chars) <= 260";
      dgv.Columns["Model Folder"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Model Folder"].Width = 150;
      dgv.Columns.Add("Model Name", "Model Name");
      dgv.Columns["Model Name"].ValueType = typeof (string);
      dgv.Columns["Model Name"].ToolTipText = "0 <= Value(Chars) <= 260";
      dgv.Columns["Model Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Model Name"].Width = 150;
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 30";
      dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Name"].Width = 300;
      dgv.Columns.Add("Type", "Type");
      dgv.Columns["Type"].ValueType = typeof (byte);
      dgv.Columns["Type"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Two Hands", "Two Hands");
      dgv.Columns["Two Hands"].ValueType = typeof (byte);
      dgv.Columns["Two Hands"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Level", "Level");
      dgv.Columns["Level"].ValueType = typeof (ushort);
      dgv.Columns["Level"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Slot", "Slot");
      dgv.Columns["Slot"].ValueType = typeof (ushort);
      dgv.Columns["Slot"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Skill", "Skill");
      dgv.Columns["Skill"].ValueType = typeof (ushort);
      dgv.Columns["Skill"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("X", "X");
      dgv.Columns["X"].ValueType = typeof (byte);
      dgv.Columns["X"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Y", "Y");
      dgv.Columns["Y"].ValueType = typeof (byte);
      dgv.Columns["Y"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Min Dmg", "Min Dmg");
      dgv.Columns["Min Dmg"].ValueType = typeof (byte);
      dgv.Columns["Min Dmg"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Max Dmg", "Max Dmg");
      dgv.Columns["Max Dmg"].ValueType = typeof (byte);
      dgv.Columns["Max Dmg"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Def Rate", "Def Rate");
      dgv.Columns["Def Rate"].ValueType = typeof (byte);
      dgv.Columns["Def Rate"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Defense", "Defense");
      dgv.Columns["Defense"].ValueType = typeof (ushort);
      dgv.Columns["Defense"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("AtkSpeed", "AtkSpeed");
      dgv.Columns["AtkSpeed"].ValueType = typeof (byte);
      dgv.Columns["AtkSpeed"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("WalkSpeed", "WalkSpeed");
      dgv.Columns["WalkSpeed"].ValueType = typeof (byte);
      dgv.Columns["WalkSpeed"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Durability", "Durability");
      dgv.Columns["Durability"].ValueType = typeof (byte);
      dgv.Columns["Durability"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("MagicDur", "MagicDur");
      dgv.Columns["MagicDur"].ValueType = typeof (byte);
      dgv.Columns["MagicDur"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("MagicPwr", "MagicPwr");
      dgv.Columns["MagicPwr"].ValueType = typeof (byte);
      dgv.Columns["MagicPwr"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("ReqStr", "ReqStr");
      dgv.Columns["ReqStr"].ValueType = typeof (ushort);
      dgv.Columns["ReqStr"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqDex", "ReqDex");
      dgv.Columns["ReqDex"].ValueType = typeof (ushort);
      dgv.Columns["ReqDex"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqEne", "ReqEne");
      dgv.Columns["ReqEne"].ValueType = typeof (ushort);
      dgv.Columns["ReqEne"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqVit", "ReqVit");
      dgv.Columns["ReqVit"].ValueType = typeof (ushort);
      dgv.Columns["ReqVit"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqLea", "ReqLea");
      dgv.Columns["ReqLea"].ValueType = typeof (ushort);
      dgv.Columns["ReqLea"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqLvl", "ReqLvl");
      dgv.Columns["ReqLvl"].ValueType = typeof (ushort);
      dgv.Columns["ReqLvl"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ItemValue", "ItemValue");
      dgv.Columns["ItemValue"].ValueType = typeof (ushort);
      dgv.Columns["ItemValue"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Zen", "Zen");
      dgv.Columns["Zen"].ValueType = typeof (uint);
      dgv.Columns["Zen"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("SetOption", "SetOption");
      dgv.Columns["SetOption"].ValueType = typeof (byte);
      byte num = 0;
      byte maxValue1 = byte.MaxValue;
      dgv.Columns["SetOption"].ToolTipText = maxValue1.ToString() + " <= Value(Numbers) <= " + maxValue1.ToString();
      dgv.Columns.Add("DW/SM/GM", "DW/SM/GM");
      dgv.Columns["DW/SM/GM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue2 = byte.MaxValue;
      dgv.Columns["DW/SM/GM"].ToolTipText = maxValue2.ToString() + " <= Value(Numbers) <= " + maxValue2.ToString();
      dgv.Columns.Add("DK/BK/BM", "DK/BK/BM");
      dgv.Columns["DK/BK/BM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue3 = byte.MaxValue;
      dgv.Columns["DK/BK/BM"].ToolTipText = maxValue3.ToString() + " <= Value(Numbers) <= " + maxValue3.ToString();
      dgv.Columns.Add("Elf/ME/HE", "Elf/ME/HE");
      dgv.Columns["Elf/ME/HE"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue4 = byte.MaxValue;
      dgv.Columns["Elf/ME/HE"].ToolTipText = maxValue4.ToString() + " <= Value(Numbers) <= " + maxValue4.ToString();
      dgv.Columns.Add("MG/DM", "MG/DM");
      dgv.Columns["MG/DM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue5 = byte.MaxValue;
      dgv.Columns["MG/DM"].ToolTipText = maxValue5.ToString() + " <= Value(Numbers) <= " + maxValue5.ToString();
      dgv.Columns.Add("DL/LE", "DL/LE");
      dgv.Columns["DL/LE"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue6 = byte.MaxValue;
      dgv.Columns["DL/LE"].ToolTipText = maxValue6.ToString() + " <= Value(Numbers) <= " + maxValue6.ToString();
      dgv.Columns.Add("SUM/BS/DM", "SUM/BS/DM");
      dgv.Columns["SUM/BS/DM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue7 = byte.MaxValue;
      dgv.Columns["SUM/BS/DM"].ToolTipText = maxValue7.ToString() + " <= Value(Numbers) <= " + maxValue7.ToString();
      dgv.Columns.Add("RF/FM", "RF/FM");
      dgv.Columns["RF/FM"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue8 = byte.MaxValue;
      dgv.Columns["RF/FM"].ToolTipText = maxValue8.ToString() + " <= Value(Numbers) <= " + maxValue8.ToString();
      dgv.Columns.Add("Ice Attribute", "Ice Attribute");
      dgv.Columns["Ice Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue9 = byte.MaxValue;
      dgv.Columns["Ice Attribute"].ToolTipText = maxValue9.ToString() + " <= Value(Numbers) <= " + maxValue9.ToString();
      dgv.Columns.Add("Poison Attribute", "Poison Attribute");
      dgv.Columns["Poison Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue10 = byte.MaxValue;
      dgv.Columns["Poison Attribute"].ToolTipText = maxValue10.ToString() + " <= Value(Numbers) <= " + maxValue10.ToString();
      dgv.Columns.Add("Lightning Attribute", "Lightning Attribute");
      dgv.Columns["Lightning Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue11 = byte.MaxValue;
      dgv.Columns["Lightning Attribute"].ToolTipText = maxValue11.ToString() + " <= Value(Numbers) <= " + maxValue11.ToString();
      dgv.Columns.Add("Fire Attribute", "Fire Attribute");
      dgv.Columns["Fire Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue12 = byte.MaxValue;
      dgv.Columns["Fire Attribute"].ToolTipText = maxValue12.ToString() + " <= Value(Numbers) <= " + maxValue12.ToString();
      dgv.Columns.Add("Earth Attribute", "Earth Attribute");
      dgv.Columns["Earth Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue13 = byte.MaxValue;
      dgv.Columns["Earth Attribute"].ToolTipText = maxValue13.ToString() + " <= Value(Numbers) <= " + maxValue13.ToString();
      dgv.Columns.Add("Wind Attribute", "Wind Attribute");
      dgv.Columns["Wind Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue14 = byte.MaxValue;
      dgv.Columns["Wind Attribute"].ToolTipText = maxValue14.ToString() + " <= Value(Numbers) <= " + maxValue14.ToString();
      dgv.Columns.Add("Water Attribute", "Water Attribute");
      dgv.Columns["Water Attribute"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue15 = byte.MaxValue;
      dgv.Columns["Water Attribute"].ToolTipText = maxValue15.ToString() + " <= Value(Numbers) <= " + maxValue15.ToString();
      dgv.Columns.Add("Unk_5", "Unk_5");
      dgv.Columns["Unk_5"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue16 = byte.MaxValue;
      dgv.Columns["Unk_5"].ToolTipText = maxValue16.ToString() + " <= Value(Numbers) <= " + maxValue16.ToString();
      dgv.Columns.Add("Unk_6", "Unk_6");
      dgv.Columns["Unk_6"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue17 = byte.MaxValue;
      dgv.Columns["Unk_6"].ToolTipText = maxValue17.ToString() + " <= Value(Numbers) <= " + maxValue17.ToString();
      dgv.Columns.Add("Unk_7", "Unk_7");
      dgv.Columns["Unk_7"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue18 = byte.MaxValue;
      dgv.Columns["Unk_7"].ToolTipText = maxValue18.ToString() + " <= Value(Numbers) <= " + maxValue18.ToString();
      dgv.Columns.Add("Unk_8", "Unk_8");
      dgv.Columns["Unk_8"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue19 = byte.MaxValue;
      dgv.Columns["Unk_8"].ToolTipText = maxValue19.ToString() + " <= Value(Numbers) <= " + maxValue19.ToString();
      dgv.Columns.Add("Unk_9", "Unk_9");
      dgv.Columns["Unk_9"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue20 = byte.MaxValue;
      dgv.Columns["Unk_9"].ToolTipText = maxValue20.ToString() + " <= Value(Numbers) <= " + maxValue20.ToString();
      dgv.Columns.Add("Unk_10", "Unk_10");
      dgv.Columns["Unk_10"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue21 = byte.MaxValue;
      dgv.Columns["Unk_10"].ToolTipText = maxValue21.ToString() + " <= Value(Numbers) <= " + maxValue21.ToString();
      dgv.Columns.Add("Unk_11", "Unk_11");
      dgv.Columns["Unk_11"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue22 = byte.MaxValue;
      dgv.Columns["Unk_11"].ToolTipText = maxValue22.ToString() + " <= Value(Numbers) <= " + maxValue22.ToString();
      dgv.Columns.Add("Unk_12", "Unk_12");
      dgv.Columns["Unk_12"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue23 = byte.MaxValue;
      dgv.Columns["Unk_12"].ToolTipText = maxValue23.ToString() + " <= Value(Numbers) <= " + maxValue23.ToString();
      dgv.Columns.Add("Unk_13", "Unk_13");
      dgv.Columns["Unk_13"].ValueType = typeof (byte);
      num = (byte) 0;
      byte maxValue24 = byte.MaxValue;
      dgv.Columns["Unk_13"].ToolTipText = maxValue24.ToString() + " <= Value(Numbers) <= " + maxValue24.ToString();
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    public void initializeItemSeason8Episode1Grid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Unk_1", "Unk_1");
      dgv.Columns["Unk_1"].ValueType = typeof (ushort);
      dgv.Columns["Unk_1"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Unk_2", "Unk_2");
      dgv.Columns["Unk_2"].ValueType = typeof (ushort);
      dgv.Columns["Unk_2"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Unk_3", "Unk_3");
      dgv.Columns["Unk_3"].ValueType = typeof (byte);
      dgv.Columns["Unk_3"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Unk_4", "Unk_4");
      dgv.Columns["Unk_4"].ValueType = typeof (byte);
      dgv.Columns["Unk_4"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Group", "Group");
      dgv.Columns["Group"].ValueType = typeof (ushort);
      dgv.Columns["Group"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Group"].ReadOnly = true;
      dgv.Columns["Group"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Index", "Index");
      dgv.Columns["Index"].ValueType = typeof (ushort);
      dgv.Columns["Index"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Index"].ReadOnly = true;
      dgv.Columns["Index"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Model Folder", "Model Folder");
      dgv.Columns["Model Folder"].ValueType = typeof (string);
      dgv.Columns["Model Folder"].ToolTipText = "0 <= Value(Chars) <= 260";
      dgv.Columns["Model Folder"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Model Folder"].Width = 150;
      dgv.Columns.Add("Model Name", "Model Name");
      dgv.Columns["Model Name"].ValueType = typeof (string);
      dgv.Columns["Model Name"].ToolTipText = "0 <= Value(Chars) <= 260";
      dgv.Columns["Model Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Model Name"].Width = 150;
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 30";
      dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Name"].Width = 300;
      dgv.Columns.Add("Type", "Type");
      dgv.Columns["Type"].ValueType = typeof (byte);
      dgv.Columns["Type"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Two Hands", "Two Hands");
      dgv.Columns["Two Hands"].ValueType = typeof (byte);
      dgv.Columns["Two Hands"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Level", "Level");
      dgv.Columns["Level"].ValueType = typeof (ushort);
      dgv.Columns["Level"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Slot", "Slot");
      dgv.Columns["Slot"].ValueType = typeof (ushort);
      dgv.Columns["Slot"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Skill", "Skill");
      dgv.Columns["Skill"].ValueType = typeof (ushort);
      dgv.Columns["Skill"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("X", "X");
      dgv.Columns["X"].ValueType = typeof (byte);
      dgv.Columns["X"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Y", "Y");
      dgv.Columns["Y"].ValueType = typeof (byte);
      dgv.Columns["Y"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Min Dmg", "Min Dmg");
      dgv.Columns["Min Dmg"].ValueType = typeof (byte);
      dgv.Columns["Min Dmg"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Max Dmg", "Max Dmg");
      dgv.Columns["Max Dmg"].ValueType = typeof (byte);
      dgv.Columns["Max Dmg"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Def Rate", "Def Rate");
      dgv.Columns["Def Rate"].ValueType = typeof (byte);
      dgv.Columns["Def Rate"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Defense", "Defense");
      dgv.Columns["Defense"].ValueType = typeof (ushort);
      dgv.Columns["Defense"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("AtkSpeed", "AtkSpeed");
      dgv.Columns["AtkSpeed"].ValueType = typeof (byte);
      dgv.Columns["AtkSpeed"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("WalkSpeed", "WalkSpeed");
      dgv.Columns["WalkSpeed"].ValueType = typeof (byte);
      dgv.Columns["WalkSpeed"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("Durability", "Durability");
      dgv.Columns["Durability"].ValueType = typeof (byte);
      dgv.Columns["Durability"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("MagicDur", "MagicDur");
      dgv.Columns["MagicDur"].ValueType = typeof (byte);
      dgv.Columns["MagicDur"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("MagicPwr", "MagicPwr");
      dgv.Columns["MagicPwr"].ValueType = typeof (byte);
      dgv.Columns["MagicPwr"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("ReqStr", "ReqStr");
      dgv.Columns["ReqStr"].ValueType = typeof (ushort);
      dgv.Columns["ReqStr"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqDex", "ReqDex");
      dgv.Columns["ReqDex"].ValueType = typeof (ushort);
      dgv.Columns["ReqDex"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqEne", "ReqEne");
      dgv.Columns["ReqEne"].ValueType = typeof (ushort);
      dgv.Columns["ReqEne"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqVit", "ReqVit");
      dgv.Columns["ReqVit"].ValueType = typeof (ushort);
      dgv.Columns["ReqVit"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqLea", "ReqLea");
      dgv.Columns["ReqLea"].ValueType = typeof (ushort);
      dgv.Columns["ReqLea"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ReqLvl", "ReqLvl");
      dgv.Columns["ReqLvl"].ValueType = typeof (ushort);
      dgv.Columns["ReqLvl"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("ItemValue", "ItemValue");
      dgv.Columns["ItemValue"].ValueType = typeof (ushort);
      dgv.Columns["ItemValue"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Zen", "Zen");
      dgv.Columns["Zen"].ValueType = typeof (uint);
      uint maxValue1 = uint.MaxValue;
      dgv.Columns["Zen"].ToolTipText = maxValue1.ToString() + " <= Value(Numbers) <= " + maxValue1.ToString();
      dgv.Columns.Add("SetOption", "SetOption");
      dgv.Columns["SetOption"].ValueType = typeof (byte);
      byte num1 = 0;
      byte maxValue2 = byte.MaxValue;
      dgv.Columns["SetOption"].ToolTipText = maxValue2.ToString() + " <= Value(Numbers) <= " + maxValue2.ToString();
      dgv.Columns.Add("DW/SM/GM", "DW/SM/GM");
      dgv.Columns["DW/SM/GM"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue3 = byte.MaxValue;
      dgv.Columns["DW/SM/GM"].ToolTipText = maxValue3.ToString() + " <= Value(Numbers) <= " + maxValue3.ToString();
      dgv.Columns.Add("DK/BK/BM", "DK/BK/BM");
      dgv.Columns["DK/BK/BM"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue4 = byte.MaxValue;
      dgv.Columns["DK/BK/BM"].ToolTipText = maxValue4.ToString() + " <= Value(Numbers) <= " + maxValue4.ToString();
      dgv.Columns.Add("Elf/ME/HE", "Elf/ME/HE");
      dgv.Columns["Elf/ME/HE"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue5 = byte.MaxValue;
      dgv.Columns["Elf/ME/HE"].ToolTipText = maxValue5.ToString() + " <= Value(Numbers) <= " + maxValue5.ToString();
      dgv.Columns.Add("MG/DM", "MG/DM");
      dgv.Columns["MG/DM"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue6 = byte.MaxValue;
      dgv.Columns["MG/DM"].ToolTipText = maxValue6.ToString() + " <= Value(Numbers) <= " + maxValue6.ToString();
      dgv.Columns.Add("DL/LE", "DL/LE");
      dgv.Columns["DL/LE"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue7 = byte.MaxValue;
      dgv.Columns["DL/LE"].ToolTipText = maxValue7.ToString() + " <= Value(Numbers) <= " + maxValue7.ToString();
      dgv.Columns.Add("SUM/BS/DM", "SUM/BS/DM");
      dgv.Columns["SUM/BS/DM"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue8 = byte.MaxValue;
      dgv.Columns["SUM/BS/DM"].ToolTipText = maxValue8.ToString() + " <= Value(Numbers) <= " + maxValue8.ToString();
      dgv.Columns.Add("RF/FM", "RF/FM");
      dgv.Columns["RF/FM"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue9 = byte.MaxValue;
      dgv.Columns["RF/FM"].ToolTipText = maxValue9.ToString() + " <= Value(Numbers) <= " + maxValue9.ToString();
      dgv.Columns.Add("Ice Attribute", "Ice Attribute");
      dgv.Columns["Ice Attribute"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue10 = byte.MaxValue;
      dgv.Columns["Ice Attribute"].ToolTipText = maxValue10.ToString() + " <= Value(Numbers) <= " + maxValue10.ToString();
      dgv.Columns.Add("Poison Attribute", "Poison Attribute");
      dgv.Columns["Poison Attribute"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue11 = byte.MaxValue;
      dgv.Columns["Poison Attribute"].ToolTipText = maxValue11.ToString() + " <= Value(Numbers) <= " + maxValue11.ToString();
      dgv.Columns.Add("Lightning Attribute", "Lightning Attribute");
      dgv.Columns["Lightning Attribute"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue12 = byte.MaxValue;
      dgv.Columns["Lightning Attribute"].ToolTipText = maxValue12.ToString() + " <= Value(Numbers) <= " + maxValue12.ToString();
      dgv.Columns.Add("Fire Attribute", "Fire Attribute");
      dgv.Columns["Fire Attribute"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue13 = byte.MaxValue;
      dgv.Columns["Fire Attribute"].ToolTipText = maxValue13.ToString() + " <= Value(Numbers) <= " + maxValue13.ToString();
      dgv.Columns.Add("Earth Attribute", "Earth Attribute");
      dgv.Columns["Earth Attribute"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue14 = byte.MaxValue;
      dgv.Columns["Earth Attribute"].ToolTipText = maxValue14.ToString() + " <= Value(Numbers) <= " + maxValue14.ToString();
      dgv.Columns.Add("Wind Attribute", "Wind Attribute");
      dgv.Columns["Wind Attribute"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue15 = byte.MaxValue;
      dgv.Columns["Wind Attribute"].ToolTipText = maxValue15.ToString() + " <= Value(Numbers) <= " + maxValue15.ToString();
      dgv.Columns.Add("Water Attribute", "Water Attribute");
      dgv.Columns["Water Attribute"].ValueType = typeof (byte);
      num1 = (byte) 0;
      byte maxValue16 = byte.MaxValue;
      dgv.Columns["Water Attribute"].ToolTipText = maxValue16.ToString() + " <= Value(Numbers) <= " + maxValue16.ToString();
      for (int index = 5; index < 22; ++index)
      {
        dgv.Columns.Add("Unk_" + (object) index, "Unk_" + (object) index);
        dgv.Columns["Unk_" + (object) index].ValueType = typeof (byte);
        byte num2 = 0;
        num2 = byte.MaxValue;
        dgv.Columns["Unk_" + (object) index].ToolTipText = num2.ToString() + " <= Value(Numbers) <= " + num2.ToString();
      }
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeItemSetOptionGrid(DataGridView dgv)
    {
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = (byte) 0.ToString() + "0 <= Value(Chars) <= 64" + byte.MaxValue.ToString();
      for (int index = 1; index <= 46; ++index)
      {
        dgv.Columns.Add("v" + (object) index, "v" + (object) index);
        dgv.Columns["v" + (object) index].ValueType = typeof (byte);
        dgv.Columns["v" + (object) index].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
        dgv.Columns["v" + (object) index].Width = 30;
      }
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
        if (column.Name == "Name")
        {
          column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
          column.Width = 300;
        }
      }
    }

    private void initializeItemToolTipTextGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Code", "Code");
      dgv.Columns["Code"].ValueType = typeof (ushort);
      dgv.Columns["Code"].ToolTipText = (ushort) 0.ToString() + " <= Value <= " + (object) ushort.MaxValue;
      dgv.Columns.Add("Text", "Text");
      dgv.Columns["Text"].ValueType = typeof (string);
      dgv.Columns["Text"].ToolTipText = "Maximum 258 Chars";
      dgv.Columns["Text"].Width = 512;
      dgv.Columns["Text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns.Add("Unk", "Unk");
      dgv.Columns["Unk"].ValueType = typeof (ushort);
      dgv.Columns["Unk"].ToolTipText = (ushort) 0.ToString() + " <= Value <= " + (object) ushort.MaxValue;
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    public void initializeITTGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Group", "Group");
      dgv.Columns["Group"].ValueType = typeof (ushort);
      dgv.Columns["Group"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Group"].ReadOnly = true;
      dgv.Columns["Group"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Index", "Index");
      dgv.Columns["Index"].ValueType = typeof (ushort);
      dgv.Columns["Index"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 64";
      dgv.Columns.Add("Color", "Color");
      dgv.Columns["Color"].ValueType = typeof (short);
      dgv.Columns["Color"].ToolTipText = short.MinValue.ToString() + " <= Value(Numbers) <= " + short.MaxValue.ToString();
      dgv.Columns["Color"].ToolTipText += "\n\nIs the color:\n256 = normal\n257 = blue\n258 = red\n259 = gold\n260 = green\n261 = red BG\n262 = archangel\n263 = blue BG\n264 = orange BG\n265 = blue exc\n266 = gray\n267 = light pink\n268 = socket\n269 = orange\n270 = unknown";
      for (int index = 1; index <= 3; ++index)
      {
        dgv.Columns.Add("Unk_" + (object) index, "Unk_" + (object) index);
        dgv.Columns["Unk_" + (object) index].ValueType = typeof (short);
        dgv.Columns["Unk_" + (object) index].ToolTipText = short.MinValue.ToString() + " <= Value(Numbers) <= " + short.MaxValue.ToString();
      }
      int num = 4;
      for (int index = 1; index <= 12; ++index)
      {
        dgv.Columns.Add("iInfoLine_" + (object) index, "iInfoLine_" + (object) index);
        dgv.Columns["iInfoLine_" + (object) index].ValueType = typeof (short);
        dgv.Columns["iInfoLine_" + (object) index].ToolTipText = short.MinValue.ToString() + " <= Value(Numbers) <= " + short.MaxValue.ToString();
        dgv.Columns["iInfoLine_" + (object) index].ToolTipText += "\n\nIs the index from ItemToolTipText";
        dgv.Columns.Add("Unk_" + (object) num, "Unk_" + (object) num);
        dgv.Columns["Unk_" + (object) num].ValueType = typeof (short);
        dgv.Columns["Unk_" + (object) num].ToolTipText = short.MinValue.ToString() + " <= Value(Numbers) <= " + short.MaxValue.ToString();
        ++num;
      }
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
      {
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
        if (column.Name == "Name")
        {
          column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
          column.Width = 300;
        }
      }
    }

    public void initializeJOHSGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Group", "Group");
      dgv.Columns["Group"].ReadOnly = true;
      dgv.Columns["Group"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("Index", "Index");
      dgv.Columns["Index"].ReadOnly = true;
      dgv.Columns["Index"].DefaultCellStyle.BackColor = Color.LightGray;
      dgv.Columns.Add("v1", "v1");
      dgv.Columns["v1"].ValueType = typeof (int);
      dgv.Columns["v1"].ToolTipText = int.MinValue.ToString() + " <= Value(Numbers) <= " + int.MaxValue.ToString();
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 59";
      dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Name"].Width = 200;
      dgv.Columns.Add("v2", "v2");
      dgv.Columns["v2"].ValueType = typeof (int);
      dgv.Columns["v2"].ToolTipText = int.MinValue.ToString() + " <= Value(Numbers) <= " + int.MaxValue.ToString();
    }

    private void initializeMinimapGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Type", "Type");
      dgv.Columns["Type"].ValueType = typeof (uint);
      dgv.Columns["Type"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("X", "X");
      dgv.Columns["X"].ValueType = typeof (uint);
      dgv.Columns["X"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns["X"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["X"].Width = 50;
      dgv.Columns.Add("Y", "Y");
      dgv.Columns["Y"].ValueType = typeof (uint);
      dgv.Columns["Y"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns["Y"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Y"].Width = 50;
      dgv.Columns.Add("Rotation Angle", "Rotation Angle");
      dgv.Columns["Rotation Angle"].ValueType = typeof (uint);
      dgv.Columns["Rotation Angle"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 100";
      dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Name"].Width = 300;
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeMixGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      DataGridViewComboBoxColumn viewComboBoxColumn1 = new DataGridViewComboBoxColumn();
      viewComboBoxColumn1.Name = "MixGroup";
      viewComboBoxColumn1.DisplayIndex = 0;
      DataGridViewComboBoxColumn viewComboBoxColumn2 = viewComboBoxColumn1;
      viewComboBoxColumn2.HeaderText = viewComboBoxColumn2.Name;
      for (int index = 1; index < 15; ++index)
        viewComboBoxColumn2.Items.Add((object) index.ToString());
      dgv.Columns.Add((DataGridViewColumn) viewComboBoxColumn2);
      for (int index = 1; index < 15; ++index)
      {
        string columnName = index.ToString();
        dgv.Columns.Add(columnName, index.ToString());
        dgv.Columns[index].ValueType = typeof (uint);
        dgv.Columns[index].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      }
      dgv.Columns.Add("15", "15");
      dgv.Columns[15].ValueType = typeof (uint);
      dgv.Columns[15].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      for (int index = 16; index < 18; ++index)
      {
        string columnName = index.ToString();
        dgv.Columns.Add(columnName, index.ToString());
        dgv.Columns[index].ValueType = typeof (uint);
        dgv.Columns[index].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      }
      int index1 = 18;
      for (int index2 = 0; index2 < 32; ++index2)
      {
        string columnName1 = index1.ToString();
        dgv.Columns.Add(columnName1, index1.ToString());
        dgv.Columns[index1].ValueType = typeof (uint);
        dgv.Columns[index1].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
        int index3 = index1 + 1;
        string columnName2 = index3.ToString();
        dgv.Columns.Add(columnName2, index3.ToString());
        dgv.Columns[index3].ValueType = typeof (float);
        dgv.Columns[index3].ToolTipText = float.MinValue.ToString() + " <= Value(Numbers) <= " + float.MaxValue.ToString();
        index1 = index3 + 1;
      }
      dgv.Columns.Add("82", "82");
      dgv.Columns[82].ValueType = typeof (uint);
      dgv.Columns[82].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      for (int index4 = 83; index4 < 91; ++index4)
      {
        string columnName = index4.ToString();
        dgv.Columns.Add(columnName, index4.ToString());
        dgv.Columns[index4].ValueType = typeof (byte);
        dgv.Columns[index4].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      }
      int index5 = 91;
      for (int index6 = 0; index6 < 8; ++index6)
      {
        for (int index7 = 0; index7 < 2; ++index7)
        {
          string columnName = index5.ToString();
          dgv.Columns.Add(columnName, index5.ToString());
          dgv.Columns[index5].ValueType = typeof (short);
          dgv.Columns[index5].ToolTipText = short.MinValue.ToString() + " <= Value(Numbers) <= " + short.MaxValue.ToString();
          ++index5;
        }
        for (int index8 = 0; index8 < 9; ++index8)
        {
          string columnName = index5.ToString();
          dgv.Columns.Add(columnName, index5.ToString());
          dgv.Columns[index5].ValueType = typeof (uint);
          dgv.Columns[index5].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
          ++index5;
        }
      }
      string columnName3 = index5.ToString();
      dgv.Columns.Add(columnName3, index5.ToString());
      dgv.Columns[index5].ValueType = typeof (uint);
      dgv.Columns[index5].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      int index9 = 1;
      dgv.Columns[index9].Name = "MixID";
      dgv.Columns[index9].HeaderText = dgv.Columns[index9].Name;
      int index10 = index9 + 1;
      dgv.Columns[index10].Name = "HeadCode";
      dgv.Columns[index10].HeaderText = dgv.Columns[index10].Name;
      int index11 = index10 + 1;
      dgv.Columns[index11].Name = "MixInfo1";
      dgv.Columns[index11].HeaderText = dgv.Columns[index11].Name;
      int index12 = index11 + 1;
      dgv.Columns[index12].Name = "MixInfo2";
      dgv.Columns[index12].HeaderText = dgv.Columns[index12].Name;
      int index13 = index12 + 1;
      dgv.Columns[index13].Name = "MixInfo3";
      dgv.Columns[index13].HeaderText = dgv.Columns[index13].Name;
      int index14 = index13 + 1;
      dgv.Columns[index14].Name = "BadMixInfo1";
      dgv.Columns[index14].HeaderText = dgv.Columns[index14].Name;
      int index15 = index14 + 1;
      dgv.Columns[index15].Name = "BadMixInfo2";
      dgv.Columns[index15].HeaderText = dgv.Columns[index15].Name;
      int index16 = index15 + 1;
      dgv.Columns[index16].Name = "BadMixInfo3";
      dgv.Columns[index16].HeaderText = dgv.Columns[index16].Name;
      int index17 = index16 + 1;
      dgv.Columns[index17].Name = "GoodMixInfo1";
      dgv.Columns[index17].HeaderText = dgv.Columns[index17].Name;
      int index18 = index17 + 1;
      dgv.Columns[index18].Name = "GoodMixInfo2";
      dgv.Columns[index18].HeaderText = dgv.Columns[index18].Name;
      int index19 = index18 + 1;
      dgv.Columns[index19].Name = "GoodMixInfo3";
      dgv.Columns[index19].HeaderText = dgv.Columns[index19].Name;
      int index20 = index19 + 1;
      dgv.Columns[index20].Name = "Height";
      dgv.Columns[index20].HeaderText = dgv.Columns[index20].Name;
      int index21 = index20 + 1;
      dgv.Columns[index21].Name = "Width";
      dgv.Columns[index21].HeaderText = dgv.Columns[index21].Name;
      int index22 = index21 + 1;
      dgv.Columns[index22].Name = "MinLvl";
      dgv.Columns[index22].HeaderText = dgv.Columns[index22].Name;
      int index23 = index22 + 1;
      dgv.Columns[index23].Name = "MoneyRule";
      dgv.Columns[index23].HeaderText = dgv.Columns[index23].Name;
      int index24 = index23 + 1;
      dgv.Columns[index24].Name = "ReqMoney";
      dgv.Columns[index24].HeaderText = dgv.Columns[index24].Name;
      int index25 = index24 + 1;
      dgv.Columns[index25].Name = "RulesUsed";
      dgv.Columns[index25].HeaderText = dgv.Columns[index25].Name;
      int index26 = index25 + 1;
      for (int index27 = 0; index27 < 32; ++index27)
      {
        dgv.Columns[index26].Name = "RuleID";
        dgv.Columns[index26].HeaderText = dgv.Columns[index26].Name;
        int index28 = index26 + 1;
        dgv.Columns[index28].Name = "Div";
        dgv.Columns[index28].HeaderText = dgv.Columns[index28].Name;
        index26 = index28 + 1;
      }
      dgv.Columns[index26].Name = "MaxSuccessRate";
      dgv.Columns[index26].HeaderText = dgv.Columns[index26].Name;
      int index29 = index26 + 1;
      dgv.Columns[index29].Name = "Uk1";
      dgv.Columns[index29].HeaderText = dgv.Columns[index29].Name;
      int index30 = index29 + 1;
      dgv.Columns[index30].Name = "TalismanOfLuck";
      dgv.Columns[index30].HeaderText = dgv.Columns[index30].Name;
      int index31 = index30 + 1;
      dgv.Columns[index31].Name = "Uk2";
      dgv.Columns[index31].HeaderText = dgv.Columns[index31].Name;
      int index32 = index31 + 1;
      dgv.Columns[index32].Name = "Uk3";
      dgv.Columns[index32].HeaderText = dgv.Columns[index32].Name;
      int index33 = index32 + 1;
      dgv.Columns[index33].Name = "Uk4";
      dgv.Columns[index33].HeaderText = dgv.Columns[index33].Name;
      int index34 = index33 + 1;
      dgv.Columns[index34].Name = "Uk5";
      dgv.Columns[index34].HeaderText = dgv.Columns[index34].Name;
      int index35 = index34 + 1;
      dgv.Columns[index35].Name = "Uk6";
      dgv.Columns[index35].HeaderText = dgv.Columns[index35].Name;
      int index36 = index35 + 1;
      dgv.Columns[index36].Name = "Uk7";
      dgv.Columns[index36].HeaderText = dgv.Columns[index36].Name;
      int index37 = index36 + 1;
      for (int index38 = 0; index38 < 8; ++index38)
      {
        dgv.Columns[index37].Name = "StartId";
        dgv.Columns[index37].HeaderText = dgv.Columns[index37].Name;
        int index39 = index37 + 1;
        dgv.Columns[index39].Name = "EndId";
        dgv.Columns[index39].HeaderText = dgv.Columns[index39].Name;
        int index40 = index39 + 1;
        dgv.Columns[index40].Name = "MinLvl";
        dgv.Columns[index40].HeaderText = dgv.Columns[index40].Name;
        int index41 = index40 + 1;
        dgv.Columns[index41].Name = "MaxLvl";
        dgv.Columns[index41].HeaderText = dgv.Columns[index41].Name;
        int index42 = index41 + 1;
        dgv.Columns[index42].Name = "MinOpt";
        dgv.Columns[index42].HeaderText = dgv.Columns[index42].Name;
        int index43 = index42 + 1;
        dgv.Columns[index43].Name = "MaxOpt";
        dgv.Columns[index43].HeaderText = dgv.Columns[index43].Name;
        int index44 = index43 + 1;
        dgv.Columns[index44].Name = "MinDurability";
        dgv.Columns[index44].HeaderText = dgv.Columns[index44].Name;
        int index45 = index44 + 1;
        dgv.Columns[index45].Name = "MaxDurabiltiy";
        dgv.Columns[index45].HeaderText = dgv.Columns[index45].Name;
        int index46 = index45 + 1;
        dgv.Columns[index46].Name = "MinCnt";
        dgv.Columns[index46].HeaderText = dgv.Columns[index46].Name;
        int index47 = index46 + 1;
        dgv.Columns[index47].Name = "MaxCnt";
        dgv.Columns[index47].HeaderText = dgv.Columns[index47].Name;
        int index48 = index47 + 1;
        dgv.Columns[index48].Name = "ItemType";
        dgv.Columns[index48].HeaderText = dgv.Columns[index48].Name;
        index37 = index48 + 1;
      }
      dgv.Columns[index37].Name = "MixItemUsed";
      dgv.Columns[index37].HeaderText = dgv.Columns[index37].Name;
      int num = index37 + 1;
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeMonsterGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.Columns.Add("Model ID (1)", "Model ID (1)");
      dgv.Columns["Model ID (1)"].ValueType = typeof (uint);
      dgv.Columns["Model ID (1)"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Model Path", "Model Path");
      dgv.Columns["Model Path"].ValueType = typeof (string);
      dgv.Columns["Model Path"].ToolTipText = "0 <= Value(Cahrs) <= 64";
      dgv.Columns.Add("Model Name", "Model Name");
      dgv.Columns["Model Name"].ValueType = typeof (string);
      dgv.Columns["Model Name"].ToolTipText = "0 <= Value(Cahrs) <= 32";
      dgv.Columns.Add("Monster ID", "Monster ID");
      dgv.Columns["Monster ID"].ValueType = typeof (uint);
      dgv.Columns["Monster ID"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Monster Name", "Monster Name");
      dgv.Columns["Monster Name"].ValueType = typeof (string);
      dgv.Columns["Monster Name"].ToolTipText = "0 <= Value(Cahrs) <= 32";
      dgv.Columns.Add("Model ID (2)", "Model ID (2)");
      dgv.Columns["Model ID (2)"].ValueType = typeof (ushort);
      dgv.Columns["Model ID (2)"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns.Add("NPC?", "NPC?");
      dgv.Columns["NPC?"].ValueType = typeof (byte);
      dgv.Columns["NPC?"].ToolTipText = "0 or 1";
      dgv.Columns.Add("Scale", "Scale");
      dgv.Columns["Scale"].ValueType = typeof (float);
      dgv.Columns["Scale"].ToolTipText = float.MinValue.ToString() + " <= Value(Numbers) <= " + float.MaxValue.ToString();
      dgv.Columns.Add("Glow Power", "Glow Power");
      dgv.Columns["Glow Power"].ValueType = typeof (float);
      dgv.Columns["Glow Power"].ToolTipText = "0 <= Value(Numbers) <= 1";
      dgv.Columns.Add("R Color", "R Color");
      dgv.Columns["R Color"].ValueType = typeof (byte);
      dgv.Columns["R Color"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("G Color", "G Color");
      dgv.Columns["G Color"].ValueType = typeof (byte);
      dgv.Columns["G Color"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      dgv.Columns.Add("B Color", "B Color");
      dgv.Columns["B Color"].ValueType = typeof (byte);
      dgv.Columns["B Color"].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
    }

    private void initializeMRGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.Columns.Add("Index", "Index");
      dgv.Columns["Index"].ValueType = typeof (uint);
      dgv.Columns["Index"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Client Name", "Client Name");
      dgv.Columns["Client Name"].ValueType = typeof (string);
      dgv.Columns["Client Name"].ToolTipText = "0 <= Value(Chars) <= 32";
      dgv.Columns.Add("Server Name", "Server Name");
      dgv.Columns["Server Name"].ValueType = typeof (string);
      dgv.Columns["Server Name"].ToolTipText = "0 <= Value(Chars) <= 32";
      dgv.Columns.Add("Min Level", "Min Level");
      dgv.Columns["Min Level"].ValueType = typeof (uint);
      dgv.Columns["Min Level"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Max Level", "Max Level");
      dgv.Columns["Max Level"].ValueType = typeof (uint);
      dgv.Columns["Max Level"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Required Zen", "Required Zen");
      dgv.Columns["Required Zen"].ValueType = typeof (uint);
      dgv.Columns["Required Zen"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Gate Number", "Gate Number");
      dgv.Columns["Gate Number"].ValueType = typeof (uint);
      dgv.Columns["Gate Number"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
    }

    private void initializeNPCNGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.Columns.Add("ID", "ID");
      dgv.Columns["ID"].ValueType = typeof (int);
      dgv.Columns["ID"].ToolTipText = int.MinValue.ToString() + " <= Value(Numbers) <= " + int.MaxValue.ToString();
      dgv.Columns["ID"].Width = 50;
      dgv.Columns.Add("Unk_1", "Unk_1");
      dgv.Columns["Unk_1"].ValueType = typeof (uint);
      dgv.Columns["Unk_1"].ToolTipText = int.MinValue.ToString() + " <= Value(Numbers) <= " + int.MaxValue.ToString();
      dgv.Columns["Unk_1"].Width = 50;
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 256";
      dgv.Columns["Name"].Width = 512;
    }

    private void initializeNPCNPlusGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.Columns.Add("ID", "ID");
      dgv.Columns["ID"].ValueType = typeof (ushort);
      dgv.Columns["ID"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["ID"].Width = 50;
      dgv.Columns.Add("Unk_1", "Unk_1");
      dgv.Columns["Unk_1"].ValueType = typeof (ushort);
      dgv.Columns["Unk_1"].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      dgv.Columns["Unk_1"].Width = 50;
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 256";
      dgv.Columns["Name"].Width = 512;
    }

    private void initializeServerListEx700Grid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Code", "Code");
      dgv.Columns["Code"].ValueType = typeof (uint);
      dgv.Columns["Code"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 32";
      dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Name"].Width = 300;
      dgv.Columns.Add("Pos.", "Pos.");
      dgv.Columns["Pos."].ValueType = typeof (byte);
      dgv.Columns["Pos."].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString() + "\nThe server position (Sequence [1 = First, 2 = Second, etc..]).";
      for (int index = 1; index < 21; ++index)
      {
        dgv.Columns.Add("Server_" + (object) index, "Server_" + (object) index);
        dgv.Columns["Server_" + (object) index].ValueType = typeof (byte);
        dgv.Columns["Server_" + (object) index].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString() + "\n[0 = Normal PVP, 1 = Normal Non-PVP, 2 = Gold PVP, 3 = Gold Non-PVP]";
      }
      for (int index = 2; index < 6; ++index)
      {
        dgv.Columns.Add("Unk_" + (object) index, "Unk_" + (object) index);
        dgv.Columns["Unk_" + (object) index].ValueType = typeof (byte);
        dgv.Columns["Unk_" + (object) index].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      }
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeServerListS6E3Grid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Code", "Code");
      dgv.Columns["Code"].ValueType = typeof (uint);
      dgv.Columns["Code"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Name", "Name");
      dgv.Columns["Name"].ValueType = typeof (string);
      dgv.Columns["Name"].ToolTipText = "0 <= Value(Chars) <= 32";
      dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      dgv.Columns["Name"].Width = 300;
      dgv.Columns.Add("Pos.", "Pos.");
      dgv.Columns["Pos."].ValueType = typeof (byte);
      dgv.Columns["Pos."].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString() + "\nThe server position (Sequence [1 = First, 2 = Second, etc..]).";
      for (int index = 1; index < 16; ++index)
      {
        dgv.Columns.Add("Server_" + (object) index, "Server_" + (object) index);
        dgv.Columns["Server_" + (object) index].ValueType = typeof (byte);
        dgv.Columns["Server_" + (object) index].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
        dgv.Columns["Server_" + (object) index].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString() + "\n[0 = Normal PVP, 1 = Normal Non-PVP, 2 = Gold PVP, 3 = Gold Non-PVP]";
      }
      for (int index = 2; index < 6; ++index)
      {
        dgv.Columns.Add("Unk_" + (object) index, "Unk_" + (object) index);
        dgv.Columns["Unk_" + (object) index].ValueType = typeof (byte);
        dgv.Columns["Unk_" + (object) index].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      }
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeSkill_ExS8E1Grid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Name", "Name");
      dgv.Columns[0].ValueType = typeof (string);
      dgv.Columns[0].ToolTipText = "Maximum 32 Chars";
      dgv.Columns[0].Width = 128;
      dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      for (int index = 1; index < 5; ++index)
      {
        string columnName = index.ToString();
        dgv.Columns.Add(columnName, index.ToString());
        dgv.Columns[index].ValueType = typeof (ushort);
        dgv.Columns[index].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      }
      for (int index = 5; index < 8; ++index)
      {
        string columnName = index.ToString();
        dgv.Columns.Add(columnName, index.ToString());
        dgv.Columns[index].ValueType = typeof (uint);
        dgv.Columns[index].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      }
      dgv.Columns.Add("8", "8");
      dgv.Columns[8].ValueType = typeof (ushort);
      dgv.Columns[8].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      for (int index = 9; index < 51; ++index)
      {
        string columnName = index.ToString();
        dgv.Columns.Add(columnName, index.ToString());
        dgv.Columns[index].ValueType = typeof (byte);
        dgv.Columns[index].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      }
      int index1 = 1;
      dgv.Columns[index1].Name = "SkillLevel";
      dgv.Columns[index1].HeaderText = dgv.Columns[index1].Name;
      int index2 = index1 + 1;
      dgv.Columns[index2].Name = "Damage";
      dgv.Columns[index2].HeaderText = dgv.Columns[index2].Name;
      int index3 = index2 + 1;
      dgv.Columns[index3].Name = "Mana";
      dgv.Columns[index3].HeaderText = dgv.Columns[index3].Name;
      int index4 = index3 + 1;
      dgv.Columns[index4].Name = "Agility";
      dgv.Columns[index4].HeaderText = dgv.Columns[index4].Name;
      int index5 = index4 + 1;
      dgv.Columns[index5].Name = "Distance";
      dgv.Columns[index5].HeaderText = dgv.Columns[index5].Name;
      int index6 = index5 + 1;
      dgv.Columns[index6].Name = "TimeDelay";
      dgv.Columns[index6].HeaderText = dgv.Columns[index6].Name;
      int index7 = index6 + 1;
      dgv.Columns[index7].Name = "Req.Energy";
      dgv.Columns[index7].HeaderText = dgv.Columns[index7].Name;
      int index8 = index7 + 1;
      dgv.Columns[index8].Name = "Req.Level";
      dgv.Columns[index8].HeaderText = dgv.Columns[index8].Name;
      int index9 = index8 + 1;
      dgv.Columns[index9].Name = "Property";
      dgv.Columns[index9].HeaderText = dgv.Columns[index9].Name;
      int index10 = index9 + 1;
      dgv.Columns[index10].Name = "UseType";
      dgv.Columns[index10].HeaderText = dgv.Columns[index10].Name;
      int index11 = index10 + 1;
      dgv.Columns[index11].Name = "Brand";
      dgv.Columns[index11].HeaderText = dgv.Columns[index11].Name;
      int index12 = index11 + 1;
      dgv.Columns[index12].Name = "KillCount";
      dgv.Columns[index12].HeaderText = dgv.Columns[index12].Name;
      int index13 = index12 + 1;
      dgv.Columns[index13].Name = "Req.Status[0]";
      dgv.Columns[index13].HeaderText = dgv.Columns[index13].Name;
      int index14 = index13 + 1;
      dgv.Columns[index14].Name = "Req.Status[1]";
      dgv.Columns[index14].HeaderText = dgv.Columns[index14].Name;
      int index15 = index14 + 1;
      dgv.Columns[index15].Name = "Req.Status[2]";
      dgv.Columns[index15].HeaderText = dgv.Columns[index15].Name;
      int index16 = index15 + 1;
      dgv.Columns[index16].Name = "Req.Status[3]";
      dgv.Columns[index16].HeaderText = dgv.Columns[index16].Name;
      int index17 = index16 + 1;
      dgv.Columns[index17].Name = "Req.Status[4]";
      dgv.Columns[index17].HeaderText = dgv.Columns[index17].Name;
      int index18 = index17 + 1;
      dgv.Columns[index18].Name = "Req.Status[5]";
      dgv.Columns[index18].HeaderText = dgv.Columns[index18].Name;
      int index19 = index18 + 1;
      dgv.Columns[index19].Name = "DW";
      dgv.Columns[index19].HeaderText = dgv.Columns[index19].Name;
      int index20 = index19 + 1;
      dgv.Columns[index20].Name = "BK";
      dgv.Columns[index20].HeaderText = dgv.Columns[index20].Name;
      int index21 = index20 + 1;
      dgv.Columns[index21].Name = "ELF";
      dgv.Columns[index21].HeaderText = dgv.Columns[index21].Name;
      int index22 = index21 + 1;
      dgv.Columns[index22].Name = "MG";
      dgv.Columns[index22].HeaderText = dgv.Columns[index22].Name;
      int index23 = index22 + 1;
      dgv.Columns[index23].Name = "DL";
      dgv.Columns[index23].HeaderText = dgv.Columns[index23].Name;
      int index24 = index23 + 1;
      dgv.Columns[index24].Name = "SUM";
      dgv.Columns[index24].HeaderText = dgv.Columns[index24].Name;
      int index25 = index24 + 1;
      dgv.Columns[index25].Name = "RF";
      dgv.Columns[index25].HeaderText = dgv.Columns[index25].Name;
      int index26 = index25 + 1;
      dgv.Columns[index26].Name = "IconIndex";
      dgv.Columns[index26].HeaderText = dgv.Columns[index26].Name;
      int index27 = index26 + 1;
      dgv.Columns[index27].Name = "SkillType";
      dgv.Columns[index27].HeaderText = dgv.Columns[index27].Name;
      int index28 = index27 + 1;
      for (int index29 = index28; index29 < 51; ++index29)
      {
        dgv.Columns[index28].Name = "Unk_" + (object) index29;
        dgv.Columns[index28].HeaderText = dgv.Columns[index28].Name;
        ++index28;
      }
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeSkill_S6E3Grid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Name", "Name");
      dgv.Columns[0].ValueType = typeof (string);
      dgv.Columns[0].ToolTipText = "Maximum 32 Chars";
      dgv.Columns[0].Width = 128;
      dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      for (int index = 1; index < 5; ++index)
      {
        string columnName = index.ToString();
        dgv.Columns.Add(columnName, index.ToString());
        dgv.Columns[index].ValueType = typeof (ushort);
        dgv.Columns[index].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      }
      for (int index = 5; index < 8; ++index)
      {
        string columnName = index.ToString();
        dgv.Columns.Add(columnName, index.ToString());
        dgv.Columns[index].ValueType = typeof (uint);
        dgv.Columns[index].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      }
      dgv.Columns.Add("8", "8");
      dgv.Columns[8].ValueType = typeof (ushort);
      dgv.Columns[8].ToolTipText = (ushort) 0.ToString() + " <= Value(Numbers) <= " + ushort.MaxValue.ToString();
      for (int index = 9; index < 43; ++index)
      {
        string columnName = index.ToString();
        dgv.Columns.Add(columnName, index.ToString());
        dgv.Columns[index].ValueType = typeof (byte);
        dgv.Columns[index].ToolTipText = (byte) 0.ToString() + " <= Value(Numbers) <= " + byte.MaxValue.ToString();
      }
      int index1 = 1;
      dgv.Columns[index1].Name = "SkillLevel";
      dgv.Columns[index1].HeaderText = dgv.Columns[index1].Name;
      int index2 = index1 + 1;
      dgv.Columns[index2].Name = "Damage";
      dgv.Columns[index2].HeaderText = dgv.Columns[index2].Name;
      int index3 = index2 + 1;
      dgv.Columns[index3].Name = "Mana";
      dgv.Columns[index3].HeaderText = dgv.Columns[index3].Name;
      int index4 = index3 + 1;
      dgv.Columns[index4].Name = "Agility";
      dgv.Columns[index4].HeaderText = dgv.Columns[index4].Name;
      int index5 = index4 + 1;
      dgv.Columns[index5].Name = "Distance";
      dgv.Columns[index5].HeaderText = dgv.Columns[index5].Name;
      int index6 = index5 + 1;
      dgv.Columns[index6].Name = "TimeDelay";
      dgv.Columns[index6].HeaderText = dgv.Columns[index6].Name;
      int index7 = index6 + 1;
      dgv.Columns[index7].Name = "Req.Energy";
      dgv.Columns[index7].HeaderText = dgv.Columns[index7].Name;
      int index8 = index7 + 1;
      dgv.Columns[index8].Name = "Req.Level";
      dgv.Columns[index8].HeaderText = dgv.Columns[index8].Name;
      int index9 = index8 + 1;
      dgv.Columns[index9].Name = "Property";
      dgv.Columns[index9].HeaderText = dgv.Columns[index9].Name;
      int index10 = index9 + 1;
      dgv.Columns[index10].Name = "UseType";
      dgv.Columns[index10].HeaderText = dgv.Columns[index10].Name;
      int index11 = index10 + 1;
      dgv.Columns[index11].Name = "Brand";
      dgv.Columns[index11].HeaderText = dgv.Columns[index11].Name;
      int index12 = index11 + 1;
      dgv.Columns[index12].Name = "KillCount";
      dgv.Columns[index12].HeaderText = dgv.Columns[index12].Name;
      int index13 = index12 + 1;
      dgv.Columns[index13].Name = "Req.Status[0]";
      dgv.Columns[index13].HeaderText = dgv.Columns[index13].Name;
      int index14 = index13 + 1;
      dgv.Columns[index14].Name = "Req.Status[1]";
      dgv.Columns[index14].HeaderText = dgv.Columns[index14].Name;
      int index15 = index14 + 1;
      dgv.Columns[index15].Name = "Req.Status[2]";
      dgv.Columns[index15].HeaderText = dgv.Columns[index15].Name;
      int index16 = index15 + 1;
      dgv.Columns[index16].Name = "Req.Status[3]";
      dgv.Columns[index16].HeaderText = dgv.Columns[index16].Name;
      int index17 = index16 + 1;
      dgv.Columns[index17].Name = "Req.Status[4]";
      dgv.Columns[index17].HeaderText = dgv.Columns[index17].Name;
      int index18 = index17 + 1;
      dgv.Columns[index18].Name = "Req.Status[5]";
      dgv.Columns[index18].HeaderText = dgv.Columns[index18].Name;
      int index19 = index18 + 1;
      dgv.Columns[index19].Name = "DW";
      dgv.Columns[index19].HeaderText = dgv.Columns[index19].Name;
      int index20 = index19 + 1;
      dgv.Columns[index20].Name = "BK";
      dgv.Columns[index20].HeaderText = dgv.Columns[index20].Name;
      int index21 = index20 + 1;
      dgv.Columns[index21].Name = "ELF";
      dgv.Columns[index21].HeaderText = dgv.Columns[index21].Name;
      int index22 = index21 + 1;
      dgv.Columns[index22].Name = "MG";
      dgv.Columns[index22].HeaderText = dgv.Columns[index22].Name;
      int index23 = index22 + 1;
      dgv.Columns[index23].Name = "DL";
      dgv.Columns[index23].HeaderText = dgv.Columns[index23].Name;
      int index24 = index23 + 1;
      dgv.Columns[index24].Name = "SUM";
      dgv.Columns[index24].HeaderText = dgv.Columns[index24].Name;
      int index25 = index24 + 1;
      dgv.Columns[index25].Name = "RF";
      dgv.Columns[index25].HeaderText = dgv.Columns[index25].Name;
      int index26 = index25 + 1;
      dgv.Columns[index26].Name = "IconIndex";
      dgv.Columns[index26].HeaderText = dgv.Columns[index26].Name;
      int index27 = index26 + 1;
      dgv.Columns[index27].Name = "SkillType";
      dgv.Columns[index27].HeaderText = dgv.Columns[index27].Name;
      int index28 = index27 + 1;
      for (int index29 = index28; index29 < 43; ++index29)
      {
        dgv.Columns[index28].Name = "Unk_" + (object) index29;
        dgv.Columns[index28].HeaderText = dgv.Columns[index28].Name;
        ++index28;
      }
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeSlideGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Unk_1", "Unk_1");
      dgv.Columns["Unk_1"].ValueType = typeof (uint);
      dgv.Columns["Unk_1"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("Unk_2", "Unk_2");
      dgv.Columns["Unk_2"].ValueType = typeof (uint);
      dgv.Columns["Unk_2"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      for (int index = 1; index <= 32; ++index)
      {
        dgv.Columns.Add("Slide_" + (object) index, "Slide_" + (object) index);
        dgv.Columns["Slide_" + (object) index].ValueType = typeof (string);
        dgv.Columns["Slide_" + (object) index].ToolTipText = "Maximum 256 Chars";
        dgv.Columns["Slide_" + (object) index].Width = 512;
        dgv.Columns["Slide_" + (object) index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      }
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void initializeTEXTGrid(DataGridView dgv)
    {
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Dock = DockStyle.Fill;
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.RowsAdded += new DataGridViewRowsAddedEventHandler(this.TEXTdgv_RowsAdded);
      dgv.AllowUserToOrderColumns = false;
      dgv.AllowUserToResizeColumns = true;
      dgv.Columns.Add("Pointer", "Pointer");
      dgv.Columns["Pointer"].ValueType = typeof (uint);
      dgv.Columns["Pointer"].ToolTipText = 0.ToString() + " <= Value(Numbers) <= " + uint.MaxValue.ToString();
      dgv.Columns.Add("c_Count", "c_Count");
      dgv.Columns["c_Count"].ValueType = typeof (uint);
      dgv.Columns["c_Count"].ReadOnly = true;
      dgv.Columns["c_Count"].DefaultCellStyle.BackColor = Color.DarkGray;
      dgv.Columns.Add("Text", "Text");
      dgv.Columns["Text"].ValueType = typeof (string);
      dgv.Columns["Text"].ToolTipText = "Unlimited Length";
      dgv.Columns["Text"].Width = 1024;
      dgv.Columns["Text"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      foreach (DataGridViewColumn column in (BaseCollection) dgv.Columns)
        column.SortMode = DataGridViewColumnSortMode.NotSortable;
    }

    private void InitIAOGridAndAddItems(int theGroup, TabPage tp)
    {
      DataGridView dataGridView = new DataGridView();
      dataGridView.Size = tp.Size;
      DataGridView dgv = dataGridView;
      this.initializeIAOGrid(dgv);
      tp.Controls.Add((Control) dgv);
      int rowIndex = 0;
      for (int index = 512 * theGroup; index < 512 * theGroup + 512; ++index)
      {
        byte[] destinationArray = new byte[this.sBlockSize];
        Array.Copy((Array) this.T_fStruct, index * this.sBlockSize, (Array) destinationArray, 0, destinationArray.Length);
        dgv.Rows.Add();
        dgv[0, rowIndex].Value = (object) theGroup;
        dgv[1, rowIndex].Value = (object) rowIndex;
        dgv[2, rowIndex].Value = (object) BitConverter.ToInt16(destinationArray, 0);
        dgv[3, rowIndex].Value = (object) BitConverter.ToInt16(destinationArray, 2);
        dgv[4, rowIndex].Value = (object) BitConverter.ToInt16(destinationArray, 4);
        dgv[5, rowIndex].Value = (object) BitConverter.ToInt16(destinationArray, 6);
        dgv[6, rowIndex].Value = (object) BitConverter.ToInt32(destinationArray, 8);
        dgv[7, rowIndex].Value = (object) BitConverter.ToInt32(destinationArray, 12);
        ++rowIndex;
      }
      this.workingDGV = dgv;
      dgv.CellValueChanged += new DataGridViewCellEventHandler(this.IAOdgv_CellValueChanged);
      dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      dgv.Disposed += new EventHandler(this.IAOdgv_Disposed);
    }

    private void InitISTGridAndAddItems(int theGroup, TabPage tp)
    {
      DataGridView dataGridView = new DataGridView();
      dataGridView.Size = tp.Size;
      DataGridView dgv = dataGridView;
      this.initializeISTGrid(dgv);
      tp.Controls.Add((Control) dgv);
      int rowIndex = 0;
      for (int index = 512 * theGroup; index < 512 * theGroup + 512; ++index)
      {
        byte[] destinationArray = new byte[this.sBlockSize];
        Array.Copy((Array) this.T_fStruct, index * this.sBlockSize, (Array) destinationArray, 0, destinationArray.Length);
        dgv.Rows.Add();
        dgv[0, rowIndex].Value = (object) theGroup;
        dgv[1, rowIndex].Value = (object) rowIndex;
        dgv[2, rowIndex].Value = (object) destinationArray[0];
        dgv[3, rowIndex].Value = (object) destinationArray[1];
        dgv[4, rowIndex].Value = (object) destinationArray[2];
        dgv[5, rowIndex].Value = (object) destinationArray[3];
        ++rowIndex;
      }
      this.workingDGV = dgv;
      dgv.CellValueChanged += new DataGridViewCellEventHandler(this.ISTdgv_CellValueChanged);
      dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      dgv.Disposed += new EventHandler(this.ISTdgv_Disposed);
    }

    private void InitItem_S6E3GridAndAddItems(int theGroup, TabPage tp)
    {
      DataGridView dataGridView = new DataGridView();
      dataGridView.Size = tp.Size;
      DataGridView dgv = dataGridView;
      this.initializeItem_S6E3Grid(dgv);
      tp.Controls.Add((Control) dgv);
      int num = 0;
      for (int index1 = 512 * theGroup; index1 < 512 * theGroup + 512; ++index1)
      {
        bool flag = true;
        byte[] sourceArray = new byte[this.sBlockSize];
        for (int index2 = 0; index2 < this.sBlockSize; ++index2)
        {
          if (this.fStruct[index1, index2] == null)
          {
            flag = true;
            break;
          }
          sourceArray[index2] = Convert.ToByte(this.fStruct[index1, index2]);
          flag = false;
        }
        if (!flag)
        {
          byte[] numArray = new byte[30];
          byte[] destinationArray1 = new byte[1];
          byte[] destinationArray2 = new byte[2];
          byte[] destinationArray3 = new byte[2];
          byte[] destinationArray4 = new byte[2];
          byte[] destinationArray5 = new byte[1];
          byte[] destinationArray6 = new byte[1];
          byte[] destinationArray7 = new byte[1];
          byte[] destinationArray8 = new byte[1];
          byte[] destinationArray9 = new byte[1];
          byte[] destinationArray10 = new byte[2];
          byte[] destinationArray11 = new byte[1];
          byte[] destinationArray12 = new byte[1];
          byte[] destinationArray13 = new byte[1];
          byte[] destinationArray14 = new byte[1];
          byte[] destinationArray15 = new byte[2];
          byte[] destinationArray16 = new byte[2];
          byte[] destinationArray17 = new byte[2];
          byte[] destinationArray18 = new byte[2];
          byte[] destinationArray19 = new byte[2];
          byte[] destinationArray20 = new byte[2];
          byte[] destinationArray21 = new byte[1];
          byte[] destinationArray22 = new byte[1];
          byte[] destinationArray23 = new byte[4];
          byte[] destinationArray24 = new byte[1];
          byte[] destinationArray25 = new byte[1];
          byte[] destinationArray26 = new byte[1];
          byte[] destinationArray27 = new byte[1];
          byte[] destinationArray28 = new byte[1];
          byte[] destinationArray29 = new byte[1];
          byte[] destinationArray30 = new byte[1];
          byte[] destinationArray31 = new byte[1];
          byte[] destinationArray32 = new byte[1];
          byte[] destinationArray33 = new byte[1];
          byte[] destinationArray34 = new byte[1];
          byte[] destinationArray35 = new byte[1];
          byte[] destinationArray36 = new byte[1];
          byte[] destinationArray37 = new byte[1];
          byte[] destinationArray38 = new byte[1];
          byte[] destinationArray39 = new byte[1];
          byte[] destinationArray40 = new byte[1];
          byte[] destinationArray41 = new byte[1];
          Array.Copy((Array) sourceArray, 0, (Array) numArray, 0, numArray.Length);
          Array.Copy((Array) sourceArray, 30, (Array) destinationArray1, 0, destinationArray1.Length);
          Array.Copy((Array) sourceArray, 32, (Array) destinationArray2, 0, destinationArray2.Length);
          Array.Copy((Array) sourceArray, 34, (Array) destinationArray3, 0, destinationArray3.Length);
          Array.Copy((Array) sourceArray, 36, (Array) destinationArray4, 0, destinationArray4.Length);
          Array.Copy((Array) sourceArray, 38, (Array) destinationArray5, 0, destinationArray5.Length);
          Array.Copy((Array) sourceArray, 39, (Array) destinationArray6, 0, destinationArray6.Length);
          Array.Copy((Array) sourceArray, 40, (Array) destinationArray7, 0, destinationArray7.Length);
          Array.Copy((Array) sourceArray, 41, (Array) destinationArray8, 0, destinationArray8.Length);
          Array.Copy((Array) sourceArray, 42, (Array) destinationArray9, 0, destinationArray9.Length);
          Array.Copy((Array) sourceArray, 43, (Array) destinationArray10, 0, destinationArray10.Length);
          Array.Copy((Array) sourceArray, 44, (Array) destinationArray21, 0, destinationArray21.Length);
          Array.Copy((Array) sourceArray, 45, (Array) destinationArray11, 0, destinationArray11.Length);
          Array.Copy((Array) sourceArray, 46, (Array) destinationArray22, 0, destinationArray22.Length);
          Array.Copy((Array) sourceArray, 47, (Array) destinationArray12, 0, destinationArray12.Length);
          Array.Copy((Array) sourceArray, 48, (Array) destinationArray13, 0, destinationArray13.Length);
          Array.Copy((Array) sourceArray, 49, (Array) destinationArray14, 0, destinationArray14.Length);
          Array.Copy((Array) sourceArray, 50, (Array) destinationArray15, 0, destinationArray15.Length);
          Array.Copy((Array) sourceArray, 52, (Array) destinationArray16, 0, destinationArray16.Length);
          Array.Copy((Array) sourceArray, 54, (Array) destinationArray17, 0, destinationArray17.Length);
          Array.Copy((Array) sourceArray, 56, (Array) destinationArray18, 0, destinationArray18.Length);
          Array.Copy((Array) sourceArray, 58, (Array) destinationArray19, 0, destinationArray19.Length);
          Array.Copy((Array) sourceArray, 60, (Array) destinationArray20, 0, destinationArray20.Length);
          Array.Copy((Array) sourceArray, 62, (Array) destinationArray40, 0, destinationArray40.Length);
          Array.Copy((Array) sourceArray, 63, (Array) destinationArray41, 0, destinationArray41.Length);
          Array.Copy((Array) sourceArray, 64, (Array) destinationArray23, 0, destinationArray23.Length);
          Array.Copy((Array) sourceArray, 68, (Array) destinationArray25, 0, destinationArray25.Length);
          Array.Copy((Array) sourceArray, 69, (Array) destinationArray26, 0, destinationArray26.Length);
          Array.Copy((Array) sourceArray, 70, (Array) destinationArray27, 0, destinationArray27.Length);
          Array.Copy((Array) sourceArray, 71, (Array) destinationArray28, 0, destinationArray28.Length);
          Array.Copy((Array) sourceArray, 72, (Array) destinationArray29, 0, destinationArray29.Length);
          Array.Copy((Array) sourceArray, 73, (Array) destinationArray30, 0, destinationArray30.Length);
          Array.Copy((Array) sourceArray, 74, (Array) destinationArray31, 0, destinationArray31.Length);
          Array.Copy((Array) sourceArray, 75, (Array) destinationArray32, 0, destinationArray32.Length);
          Array.Copy((Array) sourceArray, 76, (Array) destinationArray33, 0, destinationArray33.Length);
          Array.Copy((Array) sourceArray, 77, (Array) destinationArray34, 0, destinationArray34.Length);
          Array.Copy((Array) sourceArray, 78, (Array) destinationArray35, 0, destinationArray35.Length);
          Array.Copy((Array) sourceArray, 79, (Array) destinationArray36, 0, destinationArray36.Length);
          Array.Copy((Array) sourceArray, 80, (Array) destinationArray37, 0, destinationArray37.Length);
          Array.Copy((Array) sourceArray, 81, (Array) destinationArray38, 0, destinationArray38.Length);
          Array.Copy((Array) sourceArray, 82, (Array) destinationArray39, 0, destinationArray39.Length);
          Array.Copy((Array) sourceArray, 83, (Array) destinationArray24, 0, destinationArray24.Length);
          dgv.Rows.Add();
          dgv[0, num].Value = (object) theGroup;
          dgv[1, num].Value = (object) num;
          dgv[2, num].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray).Replace("\0", "").Replace("?", "");
          dgv[3, num].Value = (object) destinationArray1[0];
          dgv[4, num].Value = (object) BitConverter.ToUInt16(destinationArray2, 0);
          dgv[5, num].Value = (object) BitConverter.ToUInt16(destinationArray3, 0);
          dgv[6, num].Value = (object) BitConverter.ToUInt16(destinationArray4, 0);
          dgv[7, num].Value = (object) destinationArray5[0];
          dgv[8, num].Value = (object) destinationArray6[0];
          dgv[9, num].Value = (object) destinationArray7[0];
          dgv[10, num].Value = (object) destinationArray8[0];
          dgv[11, num].Value = (object) destinationArray9[0];
          dgv[12, num].Value = (object) BitConverter.ToUInt16(destinationArray10, 0);
          dgv[13, num].Value = (object) destinationArray21[0];
          dgv[14, num].Value = (object) destinationArray11[0];
          dgv[15, num].Value = (object) destinationArray22[0];
          dgv[16, num].Value = (object) destinationArray12[0];
          dgv[17, num].Value = (object) destinationArray13[0];
          dgv[18, num].Value = (object) destinationArray14[0];
          dgv[19, num].Value = (object) BitConverter.ToUInt16(destinationArray15, 0);
          dgv[20, num].Value = (object) BitConverter.ToUInt16(destinationArray16, 0);
          dgv[21, num].Value = (object) BitConverter.ToUInt16(destinationArray17, 0);
          dgv[22, num].Value = (object) BitConverter.ToUInt16(destinationArray18, 0);
          dgv[23, num].Value = (object) BitConverter.ToUInt16(destinationArray19, 0);
          dgv[24, num].Value = (object) BitConverter.ToUInt16(destinationArray20, 0);
          dgv[25, num].Value = (object) destinationArray40[0];
          dgv[26, num].Value = (object) destinationArray41[0];
          dgv[27, num].Value = (object) BitConverter.ToUInt32(destinationArray23, 0);
          dgv[28, num].Value = (object) destinationArray25[0];
          dgv[29, num].Value = (object) destinationArray26[0];
          dgv[30, num].Value = (object) destinationArray27[0];
          dgv[31, num].Value = (object) destinationArray28[0];
          dgv[32, num].Value = (object) destinationArray29[0];
          dgv[33, num].Value = (object) destinationArray30[0];
          dgv[34, num].Value = (object) destinationArray31[0];
          dgv[35, num].Value = (object) destinationArray32[0];
          dgv[36, num].Value = (object) destinationArray33[0];
          dgv[37, num].Value = (object) destinationArray34[0];
          dgv[38, num].Value = (object) destinationArray35[0];
          dgv[39, num].Value = (object) destinationArray36[0];
          dgv[40, num].Value = (object) destinationArray37[0];
          dgv[41, num].Value = (object) destinationArray38[0];
          dgv[42, num].Value = (object) destinationArray39[0];
          dgv[43, num].Value = (object) destinationArray24[0];
        }
        else if (flag)
        {
          dgv.Rows.Add();
          dgv["Group", num].Value = (object) theGroup;
          dgv["Index", num].Value = (object) num;
          for (int index3 = 0; index3 < dgv.Columns.Count; ++index3)
          {
            if (index3 != 0 & index3 != 1)
              dgv.Rows[num].Cells[index3].Value = (object) "0";
          }
        }
        ++num;
      }
      this.workingDGV = dgv;
      dgv.CellValueChanged += new DataGridViewCellEventHandler(this.Item_S6E3dgv_CellValueChanged);
      dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      dgv.Disposed += new EventHandler(this.Item_S6E3dgv_Disposed);
    }

    private void InitItemEx700GridAndAddItems(int theGroup, TabPage tp)
    {
      DataGridView dataGridView = new DataGridView();
      dataGridView.Size = tp.Size;
      DataGridView dgv = dataGridView;
      this.initializeItemEx700Grid(dgv);
      tp.Controls.Add((Control) dgv);
      int num1 = 0;
      for (int index1 = 512 * theGroup; index1 < 512 * theGroup + 512; ++index1)
      {
        bool flag = true;
        byte[] sourceArray = new byte[this.sBlockSize];
        for (int index2 = 0; index2 < this.sBlockSize; ++index2)
        {
          if (this.fStruct[index1, index2] == null)
          {
            flag = true;
            break;
          }
          sourceArray[index2] = Convert.ToByte(this.fStruct[index1, index2]);
          flag = false;
        }
        if (!flag)
        {
          byte[] destinationArray1 = new byte[1];
          byte[] destinationArray2 = new byte[1];
          byte[] destinationArray3 = new byte[1];
          byte[] destinationArray4 = new byte[1];
          byte[] destinationArray5 = new byte[2];
          byte[] destinationArray6 = new byte[2];
          byte[] numArray1 = new byte[260];
          byte[] numArray2 = new byte[260];
          byte[] numArray3 = new byte[30];
          byte[] destinationArray7 = new byte[1];
          byte[] destinationArray8 = new byte[1];
          byte[] destinationArray9 = new byte[2];
          byte[] destinationArray10 = new byte[2];
          byte[] destinationArray11 = new byte[2];
          byte[] destinationArray12 = new byte[1];
          byte[] destinationArray13 = new byte[1];
          byte[] destinationArray14 = new byte[1];
          byte[] destinationArray15 = new byte[1];
          byte[] destinationArray16 = new byte[1];
          byte[] destinationArray17 = new byte[2];
          byte[] destinationArray18 = new byte[1];
          byte[] destinationArray19 = new byte[1];
          byte[] destinationArray20 = new byte[1];
          byte[] destinationArray21 = new byte[1];
          byte[] destinationArray22 = new byte[1];
          byte[] destinationArray23 = new byte[2];
          byte[] destinationArray24 = new byte[2];
          byte[] destinationArray25 = new byte[2];
          byte[] destinationArray26 = new byte[2];
          byte[] destinationArray27 = new byte[2];
          byte[] destinationArray28 = new byte[2];
          byte[] destinationArray29 = new byte[2];
          byte[] destinationArray30 = new byte[4];
          byte[] destinationArray31 = new byte[1];
          byte[] destinationArray32 = new byte[1];
          byte[] destinationArray33 = new byte[1];
          byte[] destinationArray34 = new byte[1];
          byte[] destinationArray35 = new byte[1];
          byte[] destinationArray36 = new byte[1];
          byte[] destinationArray37 = new byte[1];
          byte[] destinationArray38 = new byte[1];
          byte[] destinationArray39 = new byte[1];
          byte[] destinationArray40 = new byte[1];
          byte[] destinationArray41 = new byte[1];
          byte[] destinationArray42 = new byte[1];
          byte[] destinationArray43 = new byte[1];
          byte[] destinationArray44 = new byte[1];
          byte[] destinationArray45 = new byte[1];
          byte[] destinationArray46 = new byte[1];
          int num2 = 520;
          int num3 = 6;
          Array.Copy((Array) sourceArray, 0, (Array) destinationArray1, 0, destinationArray1.Length);
          Array.Copy((Array) sourceArray, 1, (Array) destinationArray2, 0, destinationArray2.Length);
          Array.Copy((Array) sourceArray, 2, (Array) destinationArray3, 0, destinationArray3.Length);
          Array.Copy((Array) sourceArray, 3, (Array) destinationArray4, 0, destinationArray4.Length);
          Array.Copy((Array) sourceArray, 4, (Array) destinationArray5, 0, destinationArray5.Length);
          Array.Copy((Array) sourceArray, 6, (Array) destinationArray6, 0, destinationArray6.Length);
          Array.Copy((Array) sourceArray, 2 + num3, (Array) numArray1, 0, numArray1.Length);
          Array.Copy((Array) sourceArray, 262 + num3, (Array) numArray2, 0, numArray2.Length);
          Array.Copy((Array) sourceArray, 522 + num3, (Array) numArray3, 0, numArray3.Length);
          Array.Copy((Array) sourceArray, 32 + num3 + num2, (Array) destinationArray7, 0, destinationArray7.Length);
          Array.Copy((Array) sourceArray, 33 + num3 + num2, (Array) destinationArray8, 0, destinationArray8.Length);
          Array.Copy((Array) sourceArray, 34 + num3 + num2, (Array) destinationArray9, 0, destinationArray9.Length);
          Array.Copy((Array) sourceArray, 36 + num3 + num2, (Array) destinationArray10, 0, destinationArray10.Length);
          Array.Copy((Array) sourceArray, 38 + num3 + num2, (Array) destinationArray11, 0, destinationArray11.Length);
          Array.Copy((Array) sourceArray, 40 + num3 + num2, (Array) destinationArray12, 0, destinationArray12.Length);
          Array.Copy((Array) sourceArray, 41 + num3 + num2, (Array) destinationArray13, 0, destinationArray13.Length);
          Array.Copy((Array) sourceArray, 42 + num3 + num2, (Array) destinationArray14, 0, destinationArray14.Length);
          Array.Copy((Array) sourceArray, 43 + num3 + num2, (Array) destinationArray15, 0, destinationArray15.Length);
          Array.Copy((Array) sourceArray, 44 + num3 + num2, (Array) destinationArray16, 0, destinationArray16.Length);
          Array.Copy((Array) sourceArray, 45 + num3 + num2, (Array) destinationArray17, 0, destinationArray17.Length);
          Array.Copy((Array) sourceArray, 47 + num3 + num2, (Array) destinationArray18, 0, destinationArray18.Length);
          Array.Copy((Array) sourceArray, 48 + num3 + num2, (Array) destinationArray19, 0, destinationArray19.Length);
          Array.Copy((Array) sourceArray, 49 + num3 + num2, (Array) destinationArray20, 0, destinationArray20.Length);
          Array.Copy((Array) sourceArray, 50 + num3 + num2, (Array) destinationArray21, 0, destinationArray21.Length);
          Array.Copy((Array) sourceArray, 51 + num3 + num2, (Array) destinationArray22, 0, destinationArray22.Length);
          Array.Copy((Array) sourceArray, 52 + num3 + num2, (Array) destinationArray23, 0, destinationArray23.Length);
          Array.Copy((Array) sourceArray, 54 + num3 + num2, (Array) destinationArray24, 0, destinationArray24.Length);
          Array.Copy((Array) sourceArray, 56 + num3 + num2, (Array) destinationArray25, 0, destinationArray25.Length);
          Array.Copy((Array) sourceArray, 58 + num3 + num2, (Array) destinationArray26, 0, destinationArray26.Length);
          Array.Copy((Array) sourceArray, 60 + num3 + num2, (Array) destinationArray27, 0, destinationArray27.Length);
          Array.Copy((Array) sourceArray, 62 + num3 + num2, (Array) destinationArray28, 0, destinationArray28.Length);
          Array.Copy((Array) sourceArray, 64 + num3 + num2, (Array) destinationArray29, 0, destinationArray29.Length);
          Array.Copy((Array) sourceArray, 66 + num3 + num2, (Array) destinationArray30, 0, destinationArray30.Length);
          Array.Copy((Array) sourceArray, 70 + num3 + num2, (Array) destinationArray31, 0, destinationArray31.Length);
          Array.Copy((Array) sourceArray, 71 + num3 + num2, (Array) destinationArray32, 0, destinationArray32.Length);
          Array.Copy((Array) sourceArray, 72 + num3 + num2, (Array) destinationArray33, 0, destinationArray33.Length);
          Array.Copy((Array) sourceArray, 73 + num3 + num2, (Array) destinationArray34, 0, destinationArray34.Length);
          Array.Copy((Array) sourceArray, 74 + num3 + num2, (Array) destinationArray35, 0, destinationArray35.Length);
          Array.Copy((Array) sourceArray, 75 + num3 + num2, (Array) destinationArray36, 0, destinationArray36.Length);
          Array.Copy((Array) sourceArray, 76 + num3 + num2, (Array) destinationArray37, 0, destinationArray37.Length);
          Array.Copy((Array) sourceArray, 77 + num3 + num2, (Array) destinationArray38, 0, destinationArray38.Length);
          Array.Copy((Array) sourceArray, 78 + num3 + num2, (Array) destinationArray39, 0, destinationArray39.Length);
          Array.Copy((Array) sourceArray, 79 + num3 + num2, (Array) destinationArray40, 0, destinationArray40.Length);
          Array.Copy((Array) sourceArray, 80 + num3 + num2, (Array) destinationArray41, 0, destinationArray41.Length);
          Array.Copy((Array) sourceArray, 81 + num3 + num2, (Array) destinationArray42, 0, destinationArray42.Length);
          Array.Copy((Array) sourceArray, 82 + num3 + num2, (Array) destinationArray43, 0, destinationArray43.Length);
          Array.Copy((Array) sourceArray, 83 + num3 + num2, (Array) destinationArray44, 0, destinationArray44.Length);
          Array.Copy((Array) sourceArray, 84 + num3 + num2, (Array) destinationArray45, 0, destinationArray45.Length);
          Array.Copy((Array) sourceArray, 85 + num3 + num2, (Array) destinationArray46, 0, destinationArray46.Length);
          dgv.Rows.Add();
          dgv[0, num1].Value = (object) destinationArray1[0];
          dgv[1, num1].Value = (object) destinationArray2[0];
          dgv[2, num1].Value = (object) destinationArray3[0];
          dgv[3, num1].Value = (object) destinationArray4[0];
          dgv[4, num1].Value = (object) BitConverter.ToUInt16(destinationArray5, 0);
          dgv[5, num1].Value = (object) BitConverter.ToUInt16(destinationArray6, 0);
          dgv[6, num1].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray1).Replace("\0", "");
          dgv[7, num1].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace("\0", "");
          dgv[8, num1].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray3).Replace("\0", "");
          dgv[9, num1].Value = (object) destinationArray7[0];
          dgv[10, num1].Value = (object) destinationArray8[0];
          dgv[11, num1].Value = (object) BitConverter.ToUInt16(destinationArray9, 0);
          dgv[12, num1].Value = (object) BitConverter.ToUInt16(destinationArray10, 0);
          dgv[13, num1].Value = (object) BitConverter.ToUInt16(destinationArray11, 0);
          dgv[14, num1].Value = (object) destinationArray12[0];
          dgv[15, num1].Value = (object) destinationArray13[0];
          dgv[16, num1].Value = (object) destinationArray14[0];
          dgv[17, num1].Value = (object) destinationArray15[0];
          dgv[18, num1].Value = (object) destinationArray16[0];
          dgv[19, num1].Value = (object) BitConverter.ToUInt16(destinationArray17, 0);
          dgv[20, num1].Value = (object) destinationArray18[0];
          dgv[21, num1].Value = (object) destinationArray19[0];
          dgv[22, num1].Value = (object) destinationArray20[0];
          dgv[23, num1].Value = (object) destinationArray21[0];
          dgv[24, num1].Value = (object) destinationArray22[0];
          dgv[25, num1].Value = (object) BitConverter.ToUInt16(destinationArray23, 0);
          dgv[26, num1].Value = (object) BitConverter.ToUInt16(destinationArray24, 0);
          dgv[27, num1].Value = (object) BitConverter.ToUInt16(destinationArray25, 0);
          dgv[28, num1].Value = (object) BitConverter.ToUInt16(destinationArray26, 0);
          dgv[29, num1].Value = (object) BitConverter.ToUInt16(destinationArray27, 0);
          dgv[30, num1].Value = (object) BitConverter.ToUInt16(destinationArray28, 0);
          dgv[31, num1].Value = (object) BitConverter.ToUInt16(destinationArray29, 0);
          dgv[32, num1].Value = (object) BitConverter.ToUInt32(destinationArray30, 0);
          dgv[33, num1].Value = (object) destinationArray31[0];
          dgv[34, num1].Value = (object) destinationArray32[0];
          dgv[35, num1].Value = (object) destinationArray33[0];
          dgv[36, num1].Value = (object) destinationArray34[0];
          dgv[37, num1].Value = (object) destinationArray35[0];
          dgv[38, num1].Value = (object) destinationArray36[0];
          dgv[39, num1].Value = (object) destinationArray37[0];
          dgv[40, num1].Value = (object) destinationArray38[0];
          dgv[41, num1].Value = (object) destinationArray39[0];
          dgv[42, num1].Value = (object) destinationArray40[0];
          dgv[43, num1].Value = (object) destinationArray41[0];
          dgv[44, num1].Value = (object) destinationArray42[0];
          dgv[45, num1].Value = (object) destinationArray43[0];
          dgv[46, num1].Value = (object) destinationArray44[0];
          dgv[47, num1].Value = (object) destinationArray45[0];
          dgv[48, num1].Value = (object) destinationArray46[0];
        }
        else if (flag)
        {
          dgv.Rows.Add();
          dgv["Group", num1].Value = (object) theGroup;
          dgv["Index", num1].Value = (object) num1;
          for (int index3 = 0; index3 < dgv.Columns.Count; ++index3)
          {
            if (index3 != 4 & index3 != 5)
              dgv.Rows[num1].Cells[index3].Value = (object) "0";
          }
        }
        ++num1;
      }
      this.workingDGV = dgv;
      dgv.CellValueChanged += new DataGridViewCellEventHandler(this.ItemEx700dgv_CellValueChanged);
      dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      dgv.Disposed += new EventHandler(this.ItemEx700dgv_Disposed);
    }

    private void InitItemEx700PlusGridAndAddItems(int theGroup, TabPage tp)
    {
      DataGridView dataGridView = new DataGridView();
      dataGridView.Size = tp.Size;
      DataGridView dgv = dataGridView;
      this.initializeItemEx700PlusGrid(dgv);
      tp.Controls.Add((Control) dgv);
      int num1 = 0;
      for (int index1 = 512 * theGroup; index1 < 512 * theGroup + 512; ++index1)
      {
        bool flag = true;
        byte[] sourceArray = new byte[this.sBlockSize];
        for (int index2 = 0; index2 < this.sBlockSize; ++index2)
        {
          if (this.fStruct[index1, index2] == null)
          {
            flag = true;
            break;
          }
          sourceArray[index2] = Convert.ToByte(this.fStruct[index1, index2]);
          flag = false;
        }
        if (!flag)
        {
          byte[] destinationArray1 = new byte[1];
          byte[] destinationArray2 = new byte[1];
          byte[] destinationArray3 = new byte[1];
          byte[] destinationArray4 = new byte[1];
          byte[] destinationArray5 = new byte[2];
          byte[] destinationArray6 = new byte[2];
          byte[] numArray1 = new byte[260];
          byte[] numArray2 = new byte[260];
          byte[] numArray3 = new byte[30];
          byte[] destinationArray7 = new byte[1];
          byte[] destinationArray8 = new byte[1];
          byte[] destinationArray9 = new byte[2];
          byte[] destinationArray10 = new byte[2];
          byte[] destinationArray11 = new byte[2];
          byte[] destinationArray12 = new byte[1];
          byte[] destinationArray13 = new byte[1];
          byte[] destinationArray14 = new byte[1];
          byte[] destinationArray15 = new byte[1];
          byte[] destinationArray16 = new byte[1];
          byte[] destinationArray17 = new byte[2];
          byte[] destinationArray18 = new byte[1];
          byte[] destinationArray19 = new byte[1];
          byte[] destinationArray20 = new byte[1];
          byte[] destinationArray21 = new byte[1];
          byte[] destinationArray22 = new byte[1];
          byte[] destinationArray23 = new byte[2];
          byte[] destinationArray24 = new byte[2];
          byte[] destinationArray25 = new byte[2];
          byte[] destinationArray26 = new byte[2];
          byte[] destinationArray27 = new byte[2];
          byte[] destinationArray28 = new byte[2];
          byte[] destinationArray29 = new byte[2];
          byte[] destinationArray30 = new byte[4];
          byte[] destinationArray31 = new byte[1];
          byte[] destinationArray32 = new byte[1];
          byte[] destinationArray33 = new byte[1];
          byte[] destinationArray34 = new byte[1];
          byte[] destinationArray35 = new byte[1];
          byte[] destinationArray36 = new byte[1];
          byte[] destinationArray37 = new byte[1];
          byte[] destinationArray38 = new byte[1];
          byte[] destinationArray39 = new byte[1];
          byte[] destinationArray40 = new byte[1];
          byte[] destinationArray41 = new byte[1];
          byte[] destinationArray42 = new byte[1];
          byte[] destinationArray43 = new byte[1];
          byte[] destinationArray44 = new byte[1];
          byte[] destinationArray45 = new byte[1];
          byte[] destinationArray46 = new byte[1];
          byte[] destinationArray47 = new byte[1];
          byte[] destinationArray48 = new byte[1];
          byte[] destinationArray49 = new byte[1];
          byte[] destinationArray50 = new byte[1];
          byte[] destinationArray51 = new byte[1];
          byte[] destinationArray52 = new byte[1];
          byte[] destinationArray53 = new byte[1];
          byte[] destinationArray54 = new byte[1];
          int num2 = 520;
          int num3 = 6;
          Array.Copy((Array) sourceArray, 0, (Array) destinationArray1, 0, destinationArray1.Length);
          Array.Copy((Array) sourceArray, 1, (Array) destinationArray2, 0, destinationArray2.Length);
          Array.Copy((Array) sourceArray, 2, (Array) destinationArray3, 0, destinationArray3.Length);
          Array.Copy((Array) sourceArray, 3, (Array) destinationArray4, 0, destinationArray4.Length);
          Array.Copy((Array) sourceArray, 4, (Array) destinationArray5, 0, destinationArray5.Length);
          Array.Copy((Array) sourceArray, 6, (Array) destinationArray6, 0, destinationArray6.Length);
          Array.Copy((Array) sourceArray, 2 + num3, (Array) numArray1, 0, numArray1.Length);
          Array.Copy((Array) sourceArray, 262 + num3, (Array) numArray2, 0, numArray2.Length);
          Array.Copy((Array) sourceArray, 522 + num3, (Array) numArray3, 0, numArray3.Length);
          Array.Copy((Array) sourceArray, 32 + num3 + num2, (Array) destinationArray7, 0, destinationArray7.Length);
          Array.Copy((Array) sourceArray, 33 + num3 + num2, (Array) destinationArray8, 0, destinationArray8.Length);
          Array.Copy((Array) sourceArray, 34 + num3 + num2, (Array) destinationArray9, 0, destinationArray9.Length);
          Array.Copy((Array) sourceArray, 36 + num3 + num2, (Array) destinationArray10, 0, destinationArray10.Length);
          Array.Copy((Array) sourceArray, 38 + num3 + num2, (Array) destinationArray11, 0, destinationArray11.Length);
          Array.Copy((Array) sourceArray, 40 + num3 + num2, (Array) destinationArray12, 0, destinationArray12.Length);
          Array.Copy((Array) sourceArray, 41 + num3 + num2, (Array) destinationArray13, 0, destinationArray13.Length);
          Array.Copy((Array) sourceArray, 42 + num3 + num2, (Array) destinationArray14, 0, destinationArray14.Length);
          Array.Copy((Array) sourceArray, 43 + num3 + num2, (Array) destinationArray15, 0, destinationArray15.Length);
          Array.Copy((Array) sourceArray, 44 + num3 + num2, (Array) destinationArray16, 0, destinationArray16.Length);
          Array.Copy((Array) sourceArray, 45 + num3 + num2, (Array) destinationArray17, 0, destinationArray17.Length);
          Array.Copy((Array) sourceArray, 47 + num3 + num2, (Array) destinationArray18, 0, destinationArray18.Length);
          Array.Copy((Array) sourceArray, 48 + num3 + num2, (Array) destinationArray19, 0, destinationArray19.Length);
          Array.Copy((Array) sourceArray, 49 + num3 + num2, (Array) destinationArray20, 0, destinationArray20.Length);
          Array.Copy((Array) sourceArray, 50 + num3 + num2, (Array) destinationArray21, 0, destinationArray21.Length);
          Array.Copy((Array) sourceArray, 51 + num3 + num2, (Array) destinationArray22, 0, destinationArray22.Length);
          Array.Copy((Array) sourceArray, 52 + num3 + num2, (Array) destinationArray23, 0, destinationArray23.Length);
          Array.Copy((Array) sourceArray, 54 + num3 + num2, (Array) destinationArray24, 0, destinationArray24.Length);
          Array.Copy((Array) sourceArray, 56 + num3 + num2, (Array) destinationArray25, 0, destinationArray25.Length);
          Array.Copy((Array) sourceArray, 58 + num3 + num2, (Array) destinationArray26, 0, destinationArray26.Length);
          Array.Copy((Array) sourceArray, 60 + num3 + num2, (Array) destinationArray27, 0, destinationArray27.Length);
          Array.Copy((Array) sourceArray, 62 + num3 + num2, (Array) destinationArray28, 0, destinationArray28.Length);
          Array.Copy((Array) sourceArray, 64 + num3 + num2, (Array) destinationArray29, 0, destinationArray29.Length);
          Array.Copy((Array) sourceArray, 66 + num3 + num2, (Array) destinationArray30, 0, destinationArray30.Length);
          Array.Copy((Array) sourceArray, 70 + num3 + num2, (Array) destinationArray31, 0, destinationArray31.Length);
          Array.Copy((Array) sourceArray, 71 + num3 + num2, (Array) destinationArray32, 0, destinationArray32.Length);
          Array.Copy((Array) sourceArray, 72 + num3 + num2, (Array) destinationArray33, 0, destinationArray33.Length);
          Array.Copy((Array) sourceArray, 73 + num3 + num2, (Array) destinationArray34, 0, destinationArray34.Length);
          Array.Copy((Array) sourceArray, 74 + num3 + num2, (Array) destinationArray35, 0, destinationArray35.Length);
          Array.Copy((Array) sourceArray, 75 + num3 + num2, (Array) destinationArray36, 0, destinationArray36.Length);
          Array.Copy((Array) sourceArray, 76 + num3 + num2, (Array) destinationArray37, 0, destinationArray37.Length);
          Array.Copy((Array) sourceArray, 77 + num3 + num2, (Array) destinationArray38, 0, destinationArray38.Length);
          Array.Copy((Array) sourceArray, 78 + num3 + num2, (Array) destinationArray39, 0, destinationArray39.Length);
          Array.Copy((Array) sourceArray, 79 + num3 + num2, (Array) destinationArray40, 0, destinationArray40.Length);
          Array.Copy((Array) sourceArray, 80 + num3 + num2, (Array) destinationArray41, 0, destinationArray41.Length);
          Array.Copy((Array) sourceArray, 81 + num3 + num2, (Array) destinationArray42, 0, destinationArray42.Length);
          Array.Copy((Array) sourceArray, 82 + num3 + num2, (Array) destinationArray43, 0, destinationArray43.Length);
          Array.Copy((Array) sourceArray, 83 + num3 + num2, (Array) destinationArray44, 0, destinationArray44.Length);
          Array.Copy((Array) sourceArray, 84 + num3 + num2, (Array) destinationArray45, 0, destinationArray45.Length);
          Array.Copy((Array) sourceArray, 85 + num3 + num2, (Array) destinationArray46, 0, destinationArray46.Length);
          Array.Copy((Array) sourceArray, 86 + num3 + num2, (Array) destinationArray47, 0, destinationArray47.Length);
          Array.Copy((Array) sourceArray, 87 + num3 + num2, (Array) destinationArray48, 0, destinationArray48.Length);
          Array.Copy((Array) sourceArray, 88 + num3 + num2, (Array) destinationArray49, 0, destinationArray49.Length);
          Array.Copy((Array) sourceArray, 89 + num3 + num2, (Array) destinationArray50, 0, destinationArray50.Length);
          Array.Copy((Array) sourceArray, 90 + num3 + num2, (Array) destinationArray51, 0, destinationArray51.Length);
          Array.Copy((Array) sourceArray, 91 + num3 + num2, (Array) destinationArray52, 0, destinationArray52.Length);
          Array.Copy((Array) sourceArray, 92 + num3 + num2, (Array) destinationArray53, 0, destinationArray53.Length);
          Array.Copy((Array) sourceArray, 93 + num3 + num2, (Array) destinationArray54, 0, destinationArray54.Length);
          dgv.Rows.Add();
          dgv[0, num1].Value = (object) destinationArray1[0];
          dgv[1, num1].Value = (object) destinationArray2[0];
          dgv[2, num1].Value = (object) destinationArray3[0];
          dgv[3, num1].Value = (object) destinationArray4[0];
          dgv[4, num1].Value = (object) BitConverter.ToUInt16(destinationArray5, 0);
          dgv[5, num1].Value = (object) BitConverter.ToUInt16(destinationArray6, 0);
          dgv[6, num1].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray1).Replace("\0", "");
          dgv[7, num1].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace("\0", "");
          dgv[8, num1].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray3).Replace("\0", "");
          dgv[9, num1].Value = (object) destinationArray7[0];
          dgv[10, num1].Value = (object) destinationArray8[0];
          dgv[11, num1].Value = (object) BitConverter.ToUInt16(destinationArray9, 0);
          dgv[12, num1].Value = (object) BitConverter.ToUInt16(destinationArray10, 0);
          dgv[13, num1].Value = (object) BitConverter.ToUInt16(destinationArray11, 0);
          dgv[14, num1].Value = (object) destinationArray12[0];
          dgv[15, num1].Value = (object) destinationArray13[0];
          dgv[16, num1].Value = (object) destinationArray14[0];
          dgv[17, num1].Value = (object) destinationArray15[0];
          dgv[18, num1].Value = (object) destinationArray16[0];
          dgv[19, num1].Value = (object) BitConverter.ToUInt16(destinationArray17, 0);
          dgv[20, num1].Value = (object) destinationArray18[0];
          dgv[21, num1].Value = (object) destinationArray19[0];
          dgv[22, num1].Value = (object) destinationArray20[0];
          dgv[23, num1].Value = (object) destinationArray21[0];
          dgv[24, num1].Value = (object) destinationArray22[0];
          dgv[25, num1].Value = (object) BitConverter.ToUInt16(destinationArray23, 0);
          dgv[26, num1].Value = (object) BitConverter.ToUInt16(destinationArray24, 0);
          dgv[27, num1].Value = (object) BitConverter.ToUInt16(destinationArray25, 0);
          dgv[28, num1].Value = (object) BitConverter.ToUInt16(destinationArray26, 0);
          dgv[29, num1].Value = (object) BitConverter.ToUInt16(destinationArray27, 0);
          dgv[30, num1].Value = (object) BitConverter.ToUInt16(destinationArray28, 0);
          dgv[31, num1].Value = (object) BitConverter.ToUInt16(destinationArray29, 0);
          dgv[32, num1].Value = (object) BitConverter.ToUInt32(destinationArray30, 0);
          dgv[33, num1].Value = (object) destinationArray31[0];
          dgv[34, num1].Value = (object) destinationArray32[0];
          dgv[35, num1].Value = (object) destinationArray33[0];
          dgv[36, num1].Value = (object) destinationArray34[0];
          dgv[37, num1].Value = (object) destinationArray35[0];
          dgv[38, num1].Value = (object) destinationArray36[0];
          dgv[39, num1].Value = (object) destinationArray37[0];
          dgv[40, num1].Value = (object) destinationArray38[0];
          dgv[41, num1].Value = (object) destinationArray39[0];
          dgv[42, num1].Value = (object) destinationArray40[0];
          dgv[43, num1].Value = (object) destinationArray41[0];
          dgv[44, num1].Value = (object) destinationArray42[0];
          dgv[45, num1].Value = (object) destinationArray43[0];
          dgv[46, num1].Value = (object) destinationArray44[0];
          dgv[47, num1].Value = (object) destinationArray45[0];
          dgv[48, num1].Value = (object) destinationArray46[0];
          dgv[49, num1].Value = (object) destinationArray47[0];
          dgv[50, num1].Value = (object) destinationArray48[0];
          dgv[51, num1].Value = (object) destinationArray49[0];
          dgv[52, num1].Value = (object) destinationArray50[0];
          dgv[53, num1].Value = (object) destinationArray51[0];
          dgv[54, num1].Value = (object) destinationArray52[0];
          dgv[55, num1].Value = (object) destinationArray53[0];
          dgv[56, num1].Value = (object) destinationArray54[0];
        }
        else if (flag)
        {
          dgv.Rows.Add();
          dgv["Group", num1].Value = (object) theGroup;
          dgv["Index", num1].Value = (object) num1;
          for (int index3 = 0; index3 < dgv.Columns.Count; ++index3)
          {
            if (index3 != 4 & index3 != 5)
              dgv.Rows[num1].Cells[index3].Value = (object) "0";
          }
        }
        ++num1;
      }
      this.workingDGV = dgv;
      dgv.CellValueChanged += new DataGridViewCellEventHandler(this.ItemEx700Plusdgv_CellValueChanged);
      dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      dgv.Disposed += new EventHandler(this.ItemEx700Plusdgv_Disposed);
    }

    private void InitItemSeason8Episode1GridAndAddItems(int theGroup, TabPage tp)
    {
      DataGridView dataGridView = new DataGridView();
      dataGridView.Size = tp.Size;
      DataGridView dgv = dataGridView;
      this.initializeItemSeason8Episode1Grid(dgv);
      tp.Controls.Add((Control) dgv);
      int num1 = 0;
      for (int index1 = 512 * theGroup; index1 < 512 * theGroup + 512; ++index1)
      {
        bool flag = true;
        byte[] sourceArray = new byte[this.sBlockSize];
        for (int index2 = 0; index2 < this.sBlockSize; ++index2)
        {
          if (this.fStruct[index1, index2] == null)
          {
            flag = true;
            break;
          }
          sourceArray[index2] = Convert.ToByte(this.fStruct[index1, index2]);
          flag = false;
        }
        if (!flag)
        {
          byte[] destinationArray1 = new byte[1];
          byte[] destinationArray2 = new byte[1];
          byte[] destinationArray3 = new byte[1];
          byte[] destinationArray4 = new byte[1];
          byte[] destinationArray5 = new byte[2];
          byte[] destinationArray6 = new byte[2];
          byte[] numArray1 = new byte[260];
          byte[] numArray2 = new byte[260];
          byte[] numArray3 = new byte[30];
          byte[] destinationArray7 = new byte[1];
          byte[] destinationArray8 = new byte[1];
          byte[] destinationArray9 = new byte[2];
          byte[] destinationArray10 = new byte[2];
          byte[] destinationArray11 = new byte[2];
          byte[] destinationArray12 = new byte[1];
          byte[] destinationArray13 = new byte[1];
          byte[] destinationArray14 = new byte[1];
          byte[] destinationArray15 = new byte[1];
          byte[] destinationArray16 = new byte[1];
          byte[] destinationArray17 = new byte[2];
          byte[] destinationArray18 = new byte[1];
          byte[] destinationArray19 = new byte[1];
          byte[] destinationArray20 = new byte[1];
          byte[] destinationArray21 = new byte[1];
          byte[] destinationArray22 = new byte[1];
          byte[] destinationArray23 = new byte[2];
          byte[] destinationArray24 = new byte[2];
          byte[] destinationArray25 = new byte[2];
          byte[] destinationArray26 = new byte[2];
          byte[] destinationArray27 = new byte[2];
          byte[] destinationArray28 = new byte[2];
          byte[] destinationArray29 = new byte[2];
          byte[] destinationArray30 = new byte[4];
          byte[] destinationArray31 = new byte[1];
          byte[] destinationArray32 = new byte[1];
          byte[] destinationArray33 = new byte[1];
          byte[] destinationArray34 = new byte[1];
          byte[] destinationArray35 = new byte[1];
          byte[] destinationArray36 = new byte[1];
          byte[] destinationArray37 = new byte[1];
          byte[] destinationArray38 = new byte[1];
          byte[] destinationArray39 = new byte[1];
          byte[] destinationArray40 = new byte[1];
          byte[] destinationArray41 = new byte[1];
          byte[] destinationArray42 = new byte[1];
          byte[] destinationArray43 = new byte[1];
          byte[] destinationArray44 = new byte[1];
          byte[] destinationArray45 = new byte[1];
          byte[] destinationArray46 = new byte[1];
          byte[] destinationArray47 = new byte[1];
          byte[] destinationArray48 = new byte[1];
          byte[] destinationArray49 = new byte[1];
          byte[] destinationArray50 = new byte[1];
          byte[] destinationArray51 = new byte[1];
          byte[] destinationArray52 = new byte[1];
          byte[] destinationArray53 = new byte[1];
          byte[] destinationArray54 = new byte[1];
          int num2 = 520;
          int num3 = 6;
          Array.Copy((Array) sourceArray, 0, (Array) destinationArray1, 0, destinationArray1.Length);
          Array.Copy((Array) sourceArray, 1, (Array) destinationArray2, 0, destinationArray2.Length);
          Array.Copy((Array) sourceArray, 2, (Array) destinationArray3, 0, destinationArray3.Length);
          Array.Copy((Array) sourceArray, 3, (Array) destinationArray4, 0, destinationArray4.Length);
          Array.Copy((Array) sourceArray, 4, (Array) destinationArray5, 0, destinationArray5.Length);
          Array.Copy((Array) sourceArray, 6, (Array) destinationArray6, 0, destinationArray6.Length);
          Array.Copy((Array) sourceArray, 2 + num3, (Array) numArray1, 0, numArray1.Length);
          Array.Copy((Array) sourceArray, 262 + num3, (Array) numArray2, 0, numArray2.Length);
          Array.Copy((Array) sourceArray, 522 + num3, (Array) numArray3, 0, numArray3.Length);
          Array.Copy((Array) sourceArray, 32 + num3 + num2, (Array) destinationArray7, 0, destinationArray7.Length);
          Array.Copy((Array) sourceArray, 33 + num3 + num2, (Array) destinationArray8, 0, destinationArray8.Length);
          Array.Copy((Array) sourceArray, 34 + num3 + num2, (Array) destinationArray9, 0, destinationArray9.Length);
          Array.Copy((Array) sourceArray, 36 + num3 + num2, (Array) destinationArray10, 0, destinationArray10.Length);
          Array.Copy((Array) sourceArray, 38 + num3 + num2, (Array) destinationArray11, 0, destinationArray11.Length);
          Array.Copy((Array) sourceArray, 40 + num3 + num2, (Array) destinationArray12, 0, destinationArray12.Length);
          Array.Copy((Array) sourceArray, 41 + num3 + num2, (Array) destinationArray13, 0, destinationArray13.Length);
          Array.Copy((Array) sourceArray, 42 + num3 + num2, (Array) destinationArray14, 0, destinationArray14.Length);
          Array.Copy((Array) sourceArray, 43 + num3 + num2, (Array) destinationArray15, 0, destinationArray15.Length);
          Array.Copy((Array) sourceArray, 44 + num3 + num2, (Array) destinationArray16, 0, destinationArray16.Length);
          Array.Copy((Array) sourceArray, 45 + num3 + num2, (Array) destinationArray17, 0, destinationArray17.Length);
          Array.Copy((Array) sourceArray, 47 + num3 + num2, (Array) destinationArray18, 0, destinationArray18.Length);
          Array.Copy((Array) sourceArray, 48 + num3 + num2, (Array) destinationArray19, 0, destinationArray19.Length);
          Array.Copy((Array) sourceArray, 49 + num3 + num2, (Array) destinationArray20, 0, destinationArray20.Length);
          Array.Copy((Array) sourceArray, 50 + num3 + num2, (Array) destinationArray21, 0, destinationArray21.Length);
          Array.Copy((Array) sourceArray, 51 + num3 + num2, (Array) destinationArray22, 0, destinationArray22.Length);
          Array.Copy((Array) sourceArray, 52 + num3 + num2, (Array) destinationArray23, 0, destinationArray23.Length);
          Array.Copy((Array) sourceArray, 54 + num3 + num2, (Array) destinationArray24, 0, destinationArray24.Length);
          Array.Copy((Array) sourceArray, 56 + num3 + num2, (Array) destinationArray25, 0, destinationArray25.Length);
          Array.Copy((Array) sourceArray, 58 + num3 + num2, (Array) destinationArray26, 0, destinationArray26.Length);
          Array.Copy((Array) sourceArray, 60 + num3 + num2, (Array) destinationArray27, 0, destinationArray27.Length);
          Array.Copy((Array) sourceArray, 62 + num3 + num2, (Array) destinationArray28, 0, destinationArray28.Length);
          Array.Copy((Array) sourceArray, 64 + num3 + num2, (Array) destinationArray29, 0, destinationArray29.Length);
          Array.Copy((Array) sourceArray, 66 + num3 + num2, (Array) destinationArray30, 0, destinationArray30.Length);
          Array.Copy((Array) sourceArray, 70 + num3 + num2, (Array) destinationArray31, 0, destinationArray31.Length);
          Array.Copy((Array) sourceArray, 71 + num3 + num2, (Array) destinationArray32, 0, destinationArray32.Length);
          Array.Copy((Array) sourceArray, 72 + num3 + num2, (Array) destinationArray33, 0, destinationArray33.Length);
          Array.Copy((Array) sourceArray, 73 + num3 + num2, (Array) destinationArray34, 0, destinationArray34.Length);
          Array.Copy((Array) sourceArray, 74 + num3 + num2, (Array) destinationArray35, 0, destinationArray35.Length);
          Array.Copy((Array) sourceArray, 75 + num3 + num2, (Array) destinationArray36, 0, destinationArray36.Length);
          Array.Copy((Array) sourceArray, 76 + num3 + num2, (Array) destinationArray37, 0, destinationArray37.Length);
          Array.Copy((Array) sourceArray, 77 + num3 + num2, (Array) destinationArray38, 0, destinationArray38.Length);
          Array.Copy((Array) sourceArray, 78 + num3 + num2, (Array) destinationArray39, 0, destinationArray39.Length);
          Array.Copy((Array) sourceArray, 79 + num3 + num2, (Array) destinationArray40, 0, destinationArray40.Length);
          Array.Copy((Array) sourceArray, 80 + num3 + num2, (Array) destinationArray41, 0, destinationArray41.Length);
          Array.Copy((Array) sourceArray, 81 + num3 + num2, (Array) destinationArray42, 0, destinationArray42.Length);
          Array.Copy((Array) sourceArray, 82 + num3 + num2, (Array) destinationArray43, 0, destinationArray43.Length);
          Array.Copy((Array) sourceArray, 83 + num3 + num2, (Array) destinationArray44, 0, destinationArray44.Length);
          Array.Copy((Array) sourceArray, 84 + num3 + num2, (Array) destinationArray45, 0, destinationArray45.Length);
          Array.Copy((Array) sourceArray, 85 + num3 + num2, (Array) destinationArray46, 0, destinationArray46.Length);
          Array.Copy((Array) sourceArray, 86 + num3 + num2, (Array) destinationArray47, 0, destinationArray47.Length);
          Array.Copy((Array) sourceArray, 87 + num3 + num2, (Array) destinationArray48, 0, destinationArray48.Length);
          Array.Copy((Array) sourceArray, 88 + num3 + num2, (Array) destinationArray49, 0, destinationArray49.Length);
          Array.Copy((Array) sourceArray, 89 + num3 + num2, (Array) destinationArray50, 0, destinationArray50.Length);
          Array.Copy((Array) sourceArray, 90 + num3 + num2, (Array) destinationArray51, 0, destinationArray51.Length);
          Array.Copy((Array) sourceArray, 91 + num3 + num2, (Array) destinationArray52, 0, destinationArray52.Length);
          Array.Copy((Array) sourceArray, 92 + num3 + num2, (Array) destinationArray53, 0, destinationArray53.Length);
          Array.Copy((Array) sourceArray, 93 + num3 + num2, (Array) destinationArray54, 0, destinationArray54.Length);
          dgv.Rows.Add();
          dgv[0, num1].Value = (object) destinationArray1[0];
          dgv[1, num1].Value = (object) destinationArray2[0];
          dgv[2, num1].Value = (object) destinationArray3[0];
          dgv[3, num1].Value = (object) destinationArray4[0];
          dgv[4, num1].Value = (object) BitConverter.ToUInt16(destinationArray5, 0);
          dgv[5, num1].Value = (object) BitConverter.ToUInt16(destinationArray6, 0);
          dgv[6, num1].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray1).Replace("\0", "");
          dgv[7, num1].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace("\0", "");
          dgv[8, num1].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray3).Replace("\0", "");
          dgv[9, num1].Value = (object) destinationArray7[0];
          dgv[10, num1].Value = (object) destinationArray8[0];
          dgv[11, num1].Value = (object) BitConverter.ToUInt16(destinationArray9, 0);
          dgv[12, num1].Value = (object) BitConverter.ToUInt16(destinationArray10, 0);
          dgv[13, num1].Value = (object) BitConverter.ToUInt16(destinationArray11, 0);
          dgv[14, num1].Value = (object) destinationArray12[0];
          dgv[15, num1].Value = (object) destinationArray13[0];
          dgv[16, num1].Value = (object) destinationArray14[0];
          dgv[17, num1].Value = (object) destinationArray15[0];
          dgv[18, num1].Value = (object) destinationArray16[0];
          dgv[19, num1].Value = (object) BitConverter.ToUInt16(destinationArray17, 0);
          dgv[20, num1].Value = (object) destinationArray18[0];
          dgv[21, num1].Value = (object) destinationArray19[0];
          dgv[22, num1].Value = (object) destinationArray20[0];
          dgv[23, num1].Value = (object) destinationArray21[0];
          dgv[24, num1].Value = (object) destinationArray22[0];
          dgv[25, num1].Value = (object) BitConverter.ToUInt16(destinationArray23, 0);
          dgv[26, num1].Value = (object) BitConverter.ToUInt16(destinationArray24, 0);
          dgv[27, num1].Value = (object) BitConverter.ToUInt16(destinationArray25, 0);
          dgv[28, num1].Value = (object) BitConverter.ToUInt16(destinationArray26, 0);
          dgv[29, num1].Value = (object) BitConverter.ToUInt16(destinationArray27, 0);
          dgv[30, num1].Value = (object) BitConverter.ToUInt16(destinationArray28, 0);
          dgv[31, num1].Value = (object) BitConverter.ToUInt16(destinationArray29, 0);
          dgv[32, num1].Value = (object) BitConverter.ToUInt32(destinationArray30, 0);
          dgv[33, num1].Value = (object) destinationArray31[0];
          dgv[34, num1].Value = (object) destinationArray32[0];
          dgv[35, num1].Value = (object) destinationArray33[0];
          dgv[36, num1].Value = (object) destinationArray34[0];
          dgv[37, num1].Value = (object) destinationArray35[0];
          dgv[38, num1].Value = (object) destinationArray36[0];
          dgv[39, num1].Value = (object) destinationArray37[0];
          dgv[40, num1].Value = (object) destinationArray38[0];
          dgv[41, num1].Value = (object) destinationArray39[0];
          dgv[42, num1].Value = (object) destinationArray40[0];
          dgv[43, num1].Value = (object) destinationArray41[0];
          dgv[44, num1].Value = (object) destinationArray42[0];
          dgv[45, num1].Value = (object) destinationArray43[0];
          dgv[46, num1].Value = (object) destinationArray44[0];
          dgv[47, num1].Value = (object) destinationArray45[0];
          dgv[48, num1].Value = (object) destinationArray46[0];
          dgv[49, num1].Value = (object) destinationArray47[0];
          dgv[50, num1].Value = (object) destinationArray48[0];
          dgv[51, num1].Value = (object) destinationArray49[0];
          dgv[52, num1].Value = (object) destinationArray50[0];
          dgv[53, num1].Value = (object) destinationArray51[0];
          dgv[54, num1].Value = (object) destinationArray52[0];
          dgv[55, num1].Value = (object) destinationArray53[0];
          dgv[56, num1].Value = (object) destinationArray54[0];
          dgv[57, num1].Value = (object) sourceArray[620];
          dgv[58, num1].Value = (object) sourceArray[621];
          dgv[59, num1].Value = (object) sourceArray[622];
          dgv[60, num1].Value = (object) sourceArray[623];
          dgv[61, num1].Value = (object) sourceArray[624];
          dgv[62, num1].Value = (object) sourceArray[625];
          dgv[63, num1].Value = (object) sourceArray[626];
          dgv[64, num1].Value = (object) sourceArray[627];
        }
        else if (flag)
        {
          dgv.Rows.Add();
          dgv["Group", num1].Value = (object) theGroup;
          dgv["Index", num1].Value = (object) num1;
          for (int index3 = 0; index3 < dgv.Columns.Count; ++index3)
          {
            if (index3 != 4 & index3 != 5)
              dgv.Rows[num1].Cells[index3].Value = (object) "0";
          }
        }
        ++num1;
      }
      this.workingDGV = dgv;
      dgv.CellValueChanged += new DataGridViewCellEventHandler(this.ItemSeason8Episode1dgv_CellValueChanged);
      dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      dgv.Disposed += new EventHandler(this.ItemSeason8Episode1dgv_Disposed);
    }

    private void InitITTGridAndAddItems(int theGroup, TabPage tp)
    {
      DataGridView dataGridView = new DataGridView();
      dataGridView.Size = tp.Size;
      DataGridView dgv = dataGridView;
      this.initializeITTGrid(dgv);
      tp.Controls.Add((Control) dgv);
      int num = 0;
      for (int index1 = 512 * theGroup; index1 < 512 * theGroup + 512; ++index1)
      {
        bool flag = false;
        byte[] sourceArray = new byte[this.sBlockSize];
        for (int index2 = 0; index2 < this.sBlockSize; ++index2)
          sourceArray[index2] = this.T_fStruct[index1 * this.sBlockSize + index2];
        if (!flag)
        {
          byte[] numArray = new byte[64];
          Array.Copy((Array) sourceArray, 4, (Array) numArray, 0, 64);
          dgv.Rows.Add();
          if (BitConverter.ToUInt16(sourceArray, 0) != (ushort) 0)
            theGroup = (int) BitConverter.ToUInt16(sourceArray, 0);
          dgv["Group", num].Value = (object) theGroup;
          dgv["Index", num].Value = (object) BitConverter.ToUInt16(sourceArray, 2);
          dgv["Name", num].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray).Replace(char.MinValue, ' ').Trim();
          dgv["Color", num].Value = (object) BitConverter.ToInt16(sourceArray, 68);
          dgv["Unk_1", num].Value = (object) BitConverter.ToInt16(sourceArray, 70);
          dgv["Unk_2", num].Value = (object) BitConverter.ToInt16(sourceArray, 72);
          dgv["Unk_3", num].Value = (object) BitConverter.ToInt16(sourceArray, 74);
          dgv["iInfoLine_1", num].Value = (object) BitConverter.ToInt16(sourceArray, 76);
          dgv["Unk_4", num].Value = (object) BitConverter.ToInt16(sourceArray, 78);
          dgv["iInfoLine_2", num].Value = (object) BitConverter.ToInt16(sourceArray, 80);
          dgv["Unk_5", num].Value = (object) BitConverter.ToInt16(sourceArray, 82);
          dgv["iInfoLine_3", num].Value = (object) BitConverter.ToInt16(sourceArray, 84);
          dgv["Unk_6", num].Value = (object) BitConverter.ToInt16(sourceArray, 86);
          dgv["iInfoLine_4", num].Value = (object) BitConverter.ToInt16(sourceArray, 88);
          dgv["Unk_7", num].Value = (object) BitConverter.ToInt16(sourceArray, 90);
          dgv["iInfoLine_5", num].Value = (object) BitConverter.ToInt16(sourceArray, 92);
          dgv["Unk_8", num].Value = (object) BitConverter.ToInt16(sourceArray, 94);
          dgv["iInfoLine_6", num].Value = (object) BitConverter.ToInt16(sourceArray, 96);
          dgv["Unk_9", num].Value = (object) BitConverter.ToInt16(sourceArray, 98);
          dgv["iInfoLine_7", num].Value = (object) BitConverter.ToInt16(sourceArray, 100);
          dgv["Unk_10", num].Value = (object) BitConverter.ToInt16(sourceArray, 102);
          dgv["iInfoLine_8", num].Value = (object) BitConverter.ToInt16(sourceArray, 104);
          dgv["Unk_11", num].Value = (object) BitConverter.ToInt16(sourceArray, 106);
          dgv["iInfoLine_9", num].Value = (object) BitConverter.ToInt16(sourceArray, 108);
          dgv["Unk_12", num].Value = (object) BitConverter.ToInt16(sourceArray, 110);
          dgv["iInfoLine_10", num].Value = (object) BitConverter.ToInt16(sourceArray, 112);
          dgv["Unk_13", num].Value = (object) BitConverter.ToInt16(sourceArray, 114);
          dgv["iInfoLine_11", num].Value = (object) BitConverter.ToInt16(sourceArray, 116);
          dgv["Unk_14", num].Value = (object) BitConverter.ToInt16(sourceArray, 118);
          dgv["iInfoLine_12", num].Value = (object) BitConverter.ToInt16(sourceArray, 120);
          dgv["Unk_15", num].Value = (object) BitConverter.ToInt16(sourceArray, 122);
        }
        else if (flag)
        {
          dgv.Rows.Add();
          dgv["Group", num].Value = (object) theGroup;
          for (int index3 = 1; index3 < dgv.Columns.Count; ++index3)
            dgv.Rows[num].Cells[index3].Value = (object) "0";
        }
        ++num;
      }
      this.workingDGV = dgv;
      dgv.CellValueChanged += new DataGridViewCellEventHandler(this.ITTdgv_CellValueChanged);
      dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      dgv.Disposed += new EventHandler(this.ITTdgv_Disposed);
    }

    private void InitJOHSGridAndAddItems(int theGroup, TabPage tp)
    {
      DataGridView dataGridView = new DataGridView();
      dataGridView.Size = tp.Size;
      DataGridView dgv = dataGridView;
      this.initializeJOHSGrid(dgv);
      tp.Controls.Add((Control) dgv);
      int rowIndex = 0;
      for (int index = 512 * theGroup; index < 512 * theGroup + 512; ++index)
      {
        byte[] numArray = new byte[this.sBlockSize];
        Array.Copy((Array) this.T_fStruct, index * this.sBlockSize, (Array) numArray, 0, numArray.Length);
        dgv.Rows.Add();
        dgv[0, rowIndex].Value = (object) theGroup;
        dgv[1, rowIndex].Value = (object) rowIndex;
        dgv[2, rowIndex].Value = (object) BitConverter.ToInt32(numArray, 0);
        dgv[3, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray, 4, 60).Trim('?').Trim(new char[1]);
        dgv[4, rowIndex].Value = (object) BitConverter.ToInt32(numArray, 64);
        ++rowIndex;
      }
      this.workingDGV = dgv;
      dgv.CellValueChanged += new DataGridViewCellEventHandler(this.JOHSdgv_CellValueChanged);
      dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      dgv.Disposed += new EventHandler(this.JOHSdgv_Disposed);
    }

    private void ISTbw_DoWork(object sender, DoWorkEventArgs e) => this.ItemSetTypeDec(((Form1.SendArgs) e.Argument).filePath);

    private void ISTbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_BmdItemAdder.Enabled = true;
      this.isLeaveOpenItemAdder = true;
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.progressBar_Loading.Visible = false;
      this.tc_Items.SelectedIndex = -1;
      this.tc_Items.SelectedIndex = 0;
    }

    private void ISTdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      byte num = Convert.ToByte(dataGridView[0, e.RowIndex].Value);
      int rowIndex = e.RowIndex;
      if (e.ColumnIndex == 0)
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) num;
      else if (e.ColumnIndex == 1)
      {
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) rowIndex;
      }
      else
      {
        if (dataGridView.EditingControl != null)
        {
          if (dataGridView.EditingControl.Text == "")
            dataGridView.EditingControl.Text = "0";
        }
        else if (this.PasteValue == "")
          this.PasteValue = "0";
        string empty = string.Empty;
        string str = !this.isPasteFromCP ? (dataGridView.EditingControl == null ? dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() : dataGridView.EditingControl.Text) : this.PasteValue;
        switch (e.ColumnIndex)
        {
          case 2:
            this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize] = Convert.ToByte(str);
            break;
          case 3:
            this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 1] = Convert.ToByte(str);
            break;
          case 4:
            this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 2] = Convert.ToByte(str);
            break;
          case 5:
            this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 3] = Convert.ToByte(str);
            break;
        }
        dataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
      }
    }

    private void ISTdgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] != null)
        Application.OpenForms["Form_Search"].Close();
      if (this.isLeaveOpenItemAdder)
        return;
      if (Application.OpenForms["Form_BmdItemAddercs"] != null)
        Application.OpenForms["Form_BmdItemAddercs"].Close();
      this.toolStripButton_BmdItemAdder.Enabled = false;
    }

    private void Item_S6E3_INI_Export()
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Title = "Select a location and file Name for the generated ItemListSettings.ini";
      saveFileDialog1.FileName = "ItemListSettings.ini";
      saveFileDialog1.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName)
      {
        AutoFlush = true
      };
      streamWriter.WriteLine("//Generated by MU.ToolKit coded by TopReal.IT");
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      List<string> stringList3 = new List<string>();
      List<string> stringList4 = new List<string>();
      List<string> stringList5 = new List<string>();
      List<string> stringList6 = new List<string>();
      List<string> stringList7 = new List<string>();
      List<string> stringList8 = new List<string>();
      List<string> stringList9 = new List<string>();
      List<string> stringList10 = new List<string>();
      List<string> stringList11 = new List<string>();
      List<string> stringList12 = new List<string>();
      List<string> stringList13 = new List<string>();
      List<string> stringList14 = new List<string>();
      List<string> stringList15 = new List<string>();
      List<string> stringList16 = new List<string>();
      for (int index = 0; index < 16; ++index)
      {
        this.tc_Items.SelectedIndex = index;
        string empty = string.Empty;
        int num = 0;
        foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
        {
          bool flag = false;
          if (num != this.workingDGV.Rows.Count - 1)
          {
            foreach (DataGridViewCell cell in (BaseCollection) row.Cells)
            {
              if (cell.Value.ToString() == "" & cell.ValueType != typeof (string))
                cell.Value = (object) "0";
              if (cell.Value.ToString() != "0" & cell.ColumnIndex != 0 & cell.ColumnIndex != 1 & cell.Value.ToString() != "")
              {
                flag = true;
                break;
              }
            }
            if (flag)
            {
              switch (Convert.ToInt32(row.Cells["Group"].Value))
              {
                case 0:
                  string str1 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList1.Add(str1);
                  break;
                case 1:
                  string str2 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList2.Add(str2);
                  break;
                case 2:
                  string str3 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList3.Add(str3);
                  break;
                case 3:
                  string str4 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList4.Add(str4);
                  break;
                case 4:
                  string str5 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList5.Add(str5);
                  break;
                case 5:
                  string str6 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList6.Add(str6);
                  break;
                case 6:
                  string str7 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Def Rate"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList7.Add(str7);
                  break;
                case 7:
                  string str8 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Def Rate"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList8.Add(str8);
                  break;
                case 8:
                  string str9 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Def Rate"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList9.Add(str9);
                  break;
                case 9:
                  string str10 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Def Rate"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList10.Add(str10);
                  break;
                case 10:
                  string str11 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Def Rate"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList11.Add(str11);
                  break;
                case 11:
                  string str12 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Def Rate"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList12.Add(str12);
                  break;
                case 12:
                  string str13 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Zen"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList13.Add(str13);
                  break;
                case 13:
                  string str14 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["Ice Attribute"].Value.ToString() + "\t" + row.Cells["Poison Attribute"].Value.ToString() + "\t" + row.Cells["Lightning Attribute"].Value.ToString() + "\t" + row.Cells["Fire Attribute"].Value.ToString() + "\t" + row.Cells["Earth Attribute"].Value.ToString() + "\t" + row.Cells["Wind Attribute"].Value.ToString() + "\t" + row.Cells["Water Attribute"].Value.ToString() + "\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList14.Add(str14);
                  break;
                case 14:
                  string str15 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["ItemValue"].Value.ToString() + "\t" + row.Cells["Level"].Value.ToString();
                  stringList15.Add(str15);
                  break;
                case 15:
                  string str16 = row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["Zen"].Value.ToString() + "\t" + row.Cells[29].Value.ToString() + "\t" + row.Cells[30].Value.ToString() + "\t" + row.Cells[31].Value.ToString() + "\t" + row.Cells[32].Value.ToString() + "\t" + row.Cells[33].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString();
                  stringList16.Add(str16);
                  break;
              }
              ++num;
            }
          }
          else
            break;
        }
      }
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("0");
      foreach (string str in stringList1)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("1");
      foreach (string str in stringList2)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("2");
      foreach (string str in stringList3)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("3");
      foreach (string str in stringList4)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("4");
      foreach (string str in stringList5)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("5");
      foreach (string str in stringList6)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tDefRate\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("6");
      foreach (string str in stringList7)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("7");
      foreach (string str in stringList8)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("8");
      foreach (string str in stringList9)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("9");
      foreach (string str in stringList10)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tASpeed\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("10");
      foreach (string str in stringList11)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tWSpeed\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("11");
      foreach (string str in stringList12)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tDur\tReqLvl\tReqEne\tReqStr\tReqDex\tReqCmd\tMoney\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("12");
      foreach (string str in stringList13)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDur\tRes1\tRes2\tRes3\tRes4\tRes5\tRes6\tRes7\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("13");
      foreach (string str in stringList14)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tValue\tLevel");
      streamWriter.WriteLine("14");
      foreach (string str in stringList15)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Index\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tReqLvl\tReqEne\tMoney\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("15");
      foreach (string str in stringList16)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.Close();
      if (MessageBox.Show("File generated succesfully.\nOpen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(saveFileDialog2.FileName);
    }

    private void Item_S6E3_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Season 6 Episode 3 Item.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.sSize;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Item_S6E3";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Item_S6E3bw_DoWork(object sender, DoWorkEventArgs e) => this.Item_S6E3Dec(((Form1.SendArgs) e.Argument).filePath);

    private void Item_S6E3bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.toolStripButton_BmdItemAdder.Enabled = true;
      this.isLeaveOpenItemAdder = true;
      this.progressBar_Loading.Visible = false;
      this.tc_Items.SelectedIndex = -1;
      this.tc_Items.SelectedIndex = 0;
    }

    private DataGridView Item_S6E3Dec(string filePath)
    {
      DataGridView dataGridView = new DataGridView();
      try
      {
        StreamReader streamReader = new StreamReader(filePath);
        streamReader.ReadToEnd();
        string encodingName = streamReader.CurrentEncoding.EncodingName;
        streamReader.Close();
        this.sBlockSize = 84;
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] Buffer = new byte[fileStream.Length];
        fileStream.Read(Buffer, 0, Buffer.Length);
        fileStream.Close();
        this.DecBlock(ref Buffer, Buffer.Length);
        Array.Resize<byte>(ref this.endBytes, 4);
        Array.Copy((Array) Buffer, Buffer.Length - 4, (Array) this.endBytes, 0, 4);
        this.sSize = (Buffer.Length - 4) / this.sBlockSize;
        this.fStruct = new object[this.sSize, this.sBlockSize];
        byte[] numArray = new byte[this.sBlockSize];
        for (int index1 = 0; index1 < this.sSize; ++index1)
        {
          byte[] destinationArray = new byte[this.sBlockSize];
          Array.Copy((Array) Buffer, index1 * this.sBlockSize, (Array) destinationArray, 0, destinationArray.Length);
          for (int index2 = 0; index2 < this.sBlockSize; ++index2)
          {
            try
            {
              this.fStruct[index1, index2] = (object) destinationArray[index2];
            }
            catch
            {
            }
          }
        }
      }
      catch (Exception ex)
      {
        dataGridView = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dataGridView;
    }

    private void Item_S6E3dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      int int16 = (int) Convert.ToInt16(dataGridView[0, e.RowIndex].Value);
      int rowIndex = e.RowIndex;
      if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
      {
        if (e.ColumnIndex == 0)
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) int16;
        else
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) rowIndex;
      }
      else
      {
        if (dataGridView.EditingControl != null)
        {
          if (dataGridView.EditingControl.Text == "")
            dataGridView.EditingControl.Text = "0";
        }
        else if (this.PasteValue == "")
          this.PasteValue = "0";
        byte[] numArray1 = new byte[1];
        byte[] numArray2 = new byte[4];
        byte[] numArray3 = new byte[2];
        byte[] OrigByt = new byte[30];
        string empty = string.Empty;
        string str = !this.isPasteFromCP ? (dataGridView.EditingControl == null ? dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() : dataGridView.EditingControl.Text) : this.PasteValue;
        switch (e.ColumnIndex)
        {
          case 2:
            this.StrToByteArray(ref OrigByt, str);
            for (int index = 0; index < OrigByt.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, index] = (object) OrigByt[index];
            break;
          case 3:
            byte[] bytes1 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes1.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 30 + index] = (object) bytes1[index];
            break;
          case 4:
            byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes2.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 32 + index] = (object) bytes2[index];
            break;
          case 5:
            byte[] bytes3 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes3.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 34 + index] = (object) bytes3[index];
            break;
          case 6:
            byte[] bytes4 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes4.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 36 + index] = (object) bytes4[index];
            break;
          case 7:
            byte[] bytes5 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 38] = (object) bytes5[0];
            break;
          case 8:
            byte[] bytes6 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 39] = (object) bytes6[0];
            break;
          case 9:
            byte[] bytes7 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 40] = (object) bytes7[0];
            break;
          case 10:
            byte[] bytes8 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 41] = (object) bytes8[0];
            break;
          case 11:
            byte[] bytes9 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 42] = (object) bytes9[0];
            break;
          case 12:
            byte[] bytes10 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 43] = (object) bytes10[0];
            break;
          case 13:
            byte[] bytes11 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 44] = (object) bytes11[0];
            break;
          case 14:
            byte[] bytes12 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 45] = (object) bytes12[0];
            break;
          case 15:
            byte[] bytes13 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 46] = (object) bytes13[0];
            break;
          case 16:
            byte[] bytes14 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 47] = (object) bytes14[0];
            break;
          case 17:
            byte[] bytes15 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 48] = (object) bytes15[0];
            break;
          case 18:
            byte[] bytes16 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 49] = (object) bytes16[0];
            break;
          case 19:
            byte[] bytes17 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes17.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 50 + index] = (object) bytes17[index];
            break;
          case 20:
            byte[] bytes18 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes18.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 52 + index] = (object) bytes18[index];
            break;
          case 21:
            byte[] bytes19 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes19.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 54 + index] = (object) bytes19[index];
            break;
          case 22:
            byte[] bytes20 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes20.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 56 + index] = (object) bytes20[index];
            break;
          case 23:
            byte[] bytes21 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 58] = (object) bytes21[0];
            break;
          case 24:
            byte[] bytes22 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes22.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 60 + index] = (object) bytes22[index];
            break;
          case 25:
            byte[] bytes23 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 62] = (object) bytes23[0];
            break;
          case 26:
            byte[] bytes24 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 63] = (object) bytes24[0];
            break;
          case 27:
            byte[] bytes25 = BitConverter.GetBytes(Convert.ToUInt32(str));
            for (int index = 0; index < bytes25.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 64 + index] = (object) bytes25[index];
            break;
          case 28:
            byte[] bytes26 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 68] = (object) bytes26[0];
            break;
          case 29:
            byte[] bytes27 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 69] = (object) bytes27[0];
            break;
          case 30:
            byte[] bytes28 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 70] = (object) bytes28[0];
            break;
          case 31:
            byte[] bytes29 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 71] = (object) bytes29[0];
            break;
          case 32:
            byte[] bytes30 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 72] = (object) bytes30[0];
            break;
          case 33:
            byte[] bytes31 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 73] = (object) bytes31[0];
            break;
          case 34:
            byte[] bytes32 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 74] = (object) bytes32[0];
            break;
          case 35:
            byte[] bytes33 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 75] = (object) bytes33[0];
            break;
          case 36:
            byte[] bytes34 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 76] = (object) bytes34[0];
            break;
          case 37:
            byte[] bytes35 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 77] = (object) bytes35[0];
            break;
          case 38:
            byte[] bytes36 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 78] = (object) bytes36[0];
            break;
          case 39:
            byte[] bytes37 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 79] = (object) bytes37[0];
            break;
          case 40:
            byte[] bytes38 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 80] = (object) bytes38[0];
            break;
          case 41:
            byte[] bytes39 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 81] = (object) bytes39[0];
            break;
          case 42:
            byte[] bytes40 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 82] = (object) bytes40[0];
            break;
          case 43:
            byte[] bytes41 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 83] = (object) bytes41[0];
            break;
        }
        dataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
      }
    }

    private void Item_S6E3dgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] != null)
        Application.OpenForms["Form_Search"].Close();
      if (this.isLeaveOpenItemAdder)
        return;
      if (Application.OpenForms["Form_BmdItemAddercs"] != null)
        Application.OpenForms["Form_BmdItemAddercs"].Close();
      this.toolStripButton_BmdItemAdder.Enabled = false;
    }

    private void Item_S6E3Enc(string filePath)
    {
      List<byte> source = new List<byte>();
      for (int percentProgress = 0; percentProgress < this.sSize; ++percentProgress)
      {
        byte[] Buffer = new byte[this.sBlockSize];
        for (int index = 0; index < this.sBlockSize; ++index)
          Buffer[index] = Convert.ToByte(this.fStruct[percentProgress, index]);
        this.EncBlock(ref Buffer, Buffer.Length);
        for (int index = 0; index < this.sBlockSize; ++index)
          source.Add(Buffer[index]);
        this.backgroundWorker.ReportProgress(percentProgress);
      }
      this.newFile = new byte[source.Count + this.endBytes.Length];
      byte[] array = source.ToArray<byte>();
      Array.Copy((Array) array, 0, (Array) this.newFile, 0, array.Length);
      Array.Copy((Array) this.endBytes, 0, (Array) this.newFile, this.newFile.Length - 4, this.endBytes.Length);
      Array.Copy((Array) this.CalcCRC(this.newFile, 58097U, 0U), 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void ItemAddOption_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the ItemAddOption.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.sSize * this.sBlockSize;
      this.Invalidate();
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ItemAddOption";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private DataGridView ItemAddOptionDec(string filePath)
    {
      DataGridView dataGridView = new DataGridView();
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] Buffer = new byte[fileStream.Length];
        this.sBlockSize = 16;
        this.sSize = Buffer.Length / this.sBlockSize;
        this.T_fStruct = new byte[this.sSize * this.sBlockSize];
        fileStream.Read(Buffer, 0, Buffer.Length);
        fileStream.Close();
        this.DecBlock(ref Buffer, Buffer.Length);
        byte[] destinationArray = new byte[this.sBlockSize];
        int num1 = 0;
        int num2 = 0;
        for (int index1 = 0; index1 < this.sSize; ++index1)
        {
          Array.Copy((Array) Buffer, index1 * this.sBlockSize, (Array) destinationArray, 0, this.sBlockSize);
          bool flag = false;
          for (int index2 = 0; index2 < destinationArray.Length; ++index2)
          {
            if (destinationArray[index2] != (byte) 0)
            {
              flag = true;
              break;
            }
          }
          if (flag)
          {
            for (int index3 = 0; index3 < this.sBlockSize; ++index3)
              this.T_fStruct[(512 * num2 + num1) * this.sBlockSize + index3] = destinationArray[index3];
          }
          ++num1;
          if (num1 > 511)
          {
            num1 = 0;
            ++num2;
          }
        }
      }
      catch (Exception ex)
      {
        dataGridView = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dataGridView;
    }

    private void ItemAddOptionEnc(string filePath)
    {
      this.newFile = this.T_fStruct;
      this.EncBlock(ref this.newFile, this.newFile.Length);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void ItemEx700_INI_Export()
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Title = "Select a location and file Name for the generated ItemListSettings.ini";
      saveFileDialog1.FileName = "ItemListSettings.ini";
      saveFileDialog1.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName)
      {
        AutoFlush = true
      };
      streamWriter.WriteLine("//Generated by MU.ToolKit coded by TopReal.IT");
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      List<string> stringList3 = new List<string>();
      List<string> stringList4 = new List<string>();
      List<string> stringList5 = new List<string>();
      List<string> stringList6 = new List<string>();
      List<string> stringList7 = new List<string>();
      List<string> stringList8 = new List<string>();
      List<string> stringList9 = new List<string>();
      List<string> stringList10 = new List<string>();
      List<string> stringList11 = new List<string>();
      List<string> stringList12 = new List<string>();
      List<string> stringList13 = new List<string>();
      List<string> stringList14 = new List<string>();
      List<string> stringList15 = new List<string>();
      List<string> stringList16 = new List<string>();
      for (int index = 0; index < 16; ++index)
      {
        this.tc_Items.SelectedIndex = index;
        string empty = string.Empty;
        int num = 0;
        foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
        {
          bool flag = false;
          if (num != this.workingDGV.Rows.Count - 1)
          {
            foreach (DataGridViewCell cell in (BaseCollection) row.Cells)
            {
              if (cell.Value.ToString() == "" & cell.ValueType != typeof (string))
                cell.Value = (object) "0";
              if (cell.Value.ToString() != "0" & cell.ColumnIndex != 4 & cell.ColumnIndex != 5)
                flag = true;
            }
            if (flag)
            {
              switch (Convert.ToInt32(row.Cells["Group"].Value))
              {
                case 0:
                  string str1 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList1.Add(str1);
                  break;
                case 1:
                  string str2 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList2.Add(str2);
                  break;
                case 2:
                  string str3 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList3.Add(str3);
                  break;
                case 3:
                  string str4 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList4.Add(str4);
                  break;
                case 4:
                  string str5 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList5.Add(str5);
                  break;
                case 5:
                  string str6 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList6.Add(str6);
                  break;
                case 6:
                  string str7 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Def Rate"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList7.Add(str7);
                  break;
                case 7:
                  string str8 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList8.Add(str8);
                  break;
                case 8:
                  string str9 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList9.Add(str9);
                  break;
                case 9:
                  string str10 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList10.Add(str10);
                  break;
                case 10:
                  string str11 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList11.Add(str11);
                  break;
                case 11:
                  string str12 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["WalkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList12.Add(str12);
                  break;
                case 12:
                  string str13 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Zen"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList13.Add(str13);
                  break;
                case 13:
                  string str14 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["Ice Attribute"].Value.ToString() + "\t" + row.Cells["Poison Attribute"].Value.ToString() + "\t" + row.Cells["Lightning Attribute"].Value.ToString() + "\t" + row.Cells["Fire Attribute"].Value.ToString() + "\t" + row.Cells["Earth Attribute"].Value.ToString() + "\t" + row.Cells["Wind Attribute"].Value.ToString() + "\t" + row.Cells["Water Attribute"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList14.Add(str14);
                  break;
                case 14:
                  string str15 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["ItemValue"].Value.ToString() + "\t" + row.Cells["Level"].Value.ToString();
                  stringList15.Add(str15);
                  break;
                case 15:
                  string str16 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["Zen"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList16.Add(str16);
                  break;
              }
              ++num;
            }
          }
          else
            break;
        }
      }
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("0");
      foreach (string str in stringList1)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("1");
      foreach (string str in stringList2)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("2");
      foreach (string str in stringList3)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("3");
      foreach (string str in stringList4)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("4");
      foreach (string str in stringList5)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("5");
      foreach (string str in stringList6)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tDefRate\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("6");
      foreach (string str in stringList7)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("7");
      foreach (string str in stringList8)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("8");
      foreach (string str in stringList9)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("9");
      foreach (string str in stringList10)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tASpeed\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("10");
      foreach (string str in stringList11)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tWSpeed\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("11");
      foreach (string str in stringList12)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tDur\tReqLvl\tReqEne\tReqStr\tReqDex\tReqCmd\tMoney\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("12");
      foreach (string str in stringList13)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDur\tRes1\tRes2\tRes3\tRes4\tRes5\tRes6\tRes7\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("13");
      foreach (string str in stringList14)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tValue\tLevel");
      streamWriter.WriteLine("14");
      foreach (string str in stringList15)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tReqLvl\tReqEne\tMoney\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("15");
      foreach (string str in stringList16)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.Close();
      if (MessageBox.Show("File generated succesfully.\nOpen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(saveFileDialog2.FileName);
    }

    private void ItemEx700_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the ItemEx700.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = 8192;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ItemEx700";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void ItemEx700bw_DoWork(object sender, DoWorkEventArgs e) => this.ItemEx700Dec(((Form1.SendArgs) e.Argument).filePath);

    private void ItemEx700bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.toolStripButton_BmdItemAdder.Enabled = true;
      this.isLeaveOpenItemAdder = true;
      this.progressBar_Loading.Visible = false;
      this.tc_Items.SelectedIndex = -1;
      this.tc_Items.SelectedIndex = 0;
    }

    private DataGridView ItemEx700Dec(string filePath)
    {
      DataGridView dataGridView = new DataGridView();
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray1 = new byte[fileStream.Length];
        long length = fileStream.Length;
        fileStream.Read(numArray1, 0, numArray1.Length);
        fileStream.Close();
        Array.Resize<byte>(ref this.startBytes, 4);
        Array.Copy((Array) numArray1, 0, (Array) this.startBytes, 0, 4);
        this.sSize = BitConverter.ToInt32(this.startBytes, 0);
        Array.Resize<byte>(ref this.endBytes, 4);
        this.fStruct = new object[8192, this.sBlockSize];
        Array.Copy((Array) numArray1, numArray1.Length - 4, (Array) this.endBytes, 0, 4);
        byte[] numArray2 = new byte[this.sBlockSize];
        for (int index1 = 0; index1 < this.sSize; ++index1)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          try
          {
            Array.Copy((Array) numArray1, index1 * this.sBlockSize + 4, (Array) Buffer, 0, Buffer.Length);
          }
          catch
          {
          }
          this.DecBlock(ref Buffer, Buffer.Length);
          for (int index2 = 0; index2 < this.sBlockSize; ++index2)
          {
            try
            {
              this.fStruct[(int) BitConverter.ToUInt16(Buffer, 4) * 512 + (int) BitConverter.ToUInt16(Buffer, 6), index2] = (object) Buffer[index2];
            }
            catch
            {
            }
          }
        }
      }
      catch (Exception ex)
      {
        dataGridView = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dataGridView;
    }

    private void ItemEx700dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      int int16 = (int) Convert.ToInt16(dataGridView[4, e.RowIndex].Value);
      int rowIndex = e.RowIndex;
      if (e.ColumnIndex == 5 || e.ColumnIndex == 4)
      {
        if (e.ColumnIndex == 4)
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) int16;
        else
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) rowIndex;
      }
      else
      {
        if (dataGridView.EditingControl != null)
        {
          if (dataGridView.EditingControl.Text == "")
            dataGridView.EditingControl.Text = "0";
        }
        else if (this.PasteValue == "")
          this.PasteValue = "0";
        byte[] numArray1 = new byte[1];
        byte[] numArray2 = new byte[4];
        byte[] numArray3 = new byte[2];
        byte[] OrigByt1 = new byte[30];
        byte[] OrigByt2 = new byte[30];
        string empty = string.Empty;
        string str = !this.isPasteFromCP ? (dataGridView.EditingControl == null ? dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() : dataGridView.EditingControl.Text) : this.PasteValue;
        if (this.fStruct[int16 * 512 + rowIndex, 0] == null)
        {
          byte[] bytes1 = BitConverter.GetBytes(Convert.ToUInt16(int16));
          for (int index = 0; index < bytes1.Length; ++index)
            this.fStruct[int16 * 512 + rowIndex, 4 + index] = (object) bytes1[index];
          byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt16(dataGridView[5, e.RowIndex].Value));
          for (int index = 0; index < bytes2.Length; ++index)
            this.fStruct[int16 * 512 + rowIndex, 6 + index] = (object) bytes2[index];
          for (int index = 0; index < this.sBlockSize; ++index)
          {
            if (index != 4 & index != 5 & index != 6 & index != 7)
              this.fStruct[int16 * 512 + rowIndex, index] = (object) 0;
          }
        }
        int num1 = 520;
        int num2 = 8;
        switch (e.ColumnIndex)
        {
          case 0:
            byte[] bytes3 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 0] = (object) bytes3[0];
            break;
          case 1:
            byte[] bytes4 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 1] = (object) bytes4[0];
            break;
          case 2:
            byte[] bytes5 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 2] = (object) bytes5[0];
            break;
          case 3:
            byte[] bytes6 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 3] = (object) bytes6[0];
            break;
          case 6:
            this.StrToByteArray(ref OrigByt2, str);
            for (int index = 0; index < OrigByt2.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, index + num2] = (object) OrigByt2[index];
            break;
          case 7:
            this.StrToByteArray(ref OrigByt2, str);
            for (int index = 0; index < OrigByt2.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 260 + index + num2] = (object) OrigByt2[index];
            break;
          case 8:
            if (str == "0")
              str = "";
            this.StrToByteArray(ref OrigByt1, str);
            for (int index = 0; index < OrigByt1.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 520 + index + num2] = (object) OrigByt1[index];
            break;
          case 9:
            byte[] bytes7 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 30 + num1 + num2] = (object) bytes7[0];
            break;
          case 10:
            byte[] bytes8 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 31 + num1 + num2] = (object) bytes8[0];
            break;
          case 11:
            byte[] bytes9 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes9.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 32 + num1 + num2 + index] = (object) bytes9[index];
            break;
          case 12:
            byte[] bytes10 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes10.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 34 + num1 + num2 + index] = (object) bytes10[index];
            break;
          case 13:
            byte[] bytes11 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes11.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 36 + num1 + num2 + index] = (object) bytes11[index];
            break;
          case 14:
            byte[] bytes12 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 38 + num1 + num2] = (object) bytes12[0];
            break;
          case 15:
            byte[] bytes13 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 39 + num1 + num2] = (object) bytes13[0];
            break;
          case 16:
            byte[] bytes14 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 40 + num1 + num2] = (object) bytes14[0];
            break;
          case 17:
            byte[] bytes15 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 41 + num1 + num2] = (object) bytes15[0];
            break;
          case 18:
            byte[] bytes16 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 42 + num1 + num2] = (object) bytes16[0];
            break;
          case 19:
            byte[] bytes17 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes17.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 43 + num1 + num2 + index] = (object) bytes17[index];
            break;
          case 20:
            byte[] bytes18 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 45 + num1 + num2] = (object) bytes18[0];
            break;
          case 21:
            byte[] bytes19 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 46 + num1 + num2] = (object) bytes19[0];
            break;
          case 22:
            byte[] bytes20 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 47 + num1 + num2] = (object) bytes20[0];
            break;
          case 23:
            byte[] bytes21 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 48 + num1 + num2] = (object) bytes21[0];
            break;
          case 24:
            byte[] bytes22 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 49 + num1 + num2] = (object) bytes22[0];
            break;
          case 25:
            byte[] bytes23 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes23.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 50 + num1 + num2 + index] = (object) bytes23[index];
            break;
          case 26:
            byte[] bytes24 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes24.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 52 + num1 + num2 + index] = (object) bytes24[index];
            break;
          case 27:
            byte[] bytes25 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes25.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 54 + num1 + num2 + index] = (object) bytes25[index];
            break;
          case 28:
            byte[] bytes26 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes26.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 56 + num1 + num2 + index] = (object) bytes26[index];
            break;
          case 29:
            byte[] bytes27 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes27.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 58 + num1 + num2 + index] = (object) bytes27[index];
            break;
          case 30:
            byte[] bytes28 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes28.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 60 + num1 + num2 + index] = (object) bytes28[index];
            break;
          case 31:
            byte[] bytes29 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes29.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 62 + num1 + num2 + index] = (object) bytes29[index];
            break;
          case 32:
            byte[] bytes30 = BitConverter.GetBytes(Convert.ToUInt32(str));
            for (int index = 0; index < bytes30.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 64 + num1 + num2 + index] = (object) bytes30[index];
            break;
          case 33:
            byte[] bytes31 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 68 + num1 + num2] = (object) bytes31[0];
            break;
          case 34:
            byte[] bytes32 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 69 + num1 + num2] = (object) bytes32[0];
            break;
          case 35:
            byte[] bytes33 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 70 + num1 + num2] = (object) bytes33[0];
            break;
          case 36:
            byte[] bytes34 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 71 + num1 + num2] = (object) bytes34[0];
            break;
          case 37:
            byte[] bytes35 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 72 + num1 + num2] = (object) bytes35[0];
            break;
          case 38:
            byte[] bytes36 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 73 + num1 + num2] = (object) bytes36[0];
            break;
          case 39:
            byte[] bytes37 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 74 + num1 + num2] = (object) bytes37[0];
            break;
          case 40:
            byte[] bytes38 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 75 + num1 + num2] = (object) bytes38[0];
            break;
          case 41:
            byte[] bytes39 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 76 + num1 + num2] = (object) bytes39[0];
            break;
          case 42:
            byte[] bytes40 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 77 + num1 + num2] = (object) bytes40[0];
            break;
          case 43:
            byte[] bytes41 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 78 + num1 + num2] = (object) bytes41[0];
            break;
          case 44:
            byte[] bytes42 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 79 + num1 + num2] = (object) bytes42[0];
            break;
          case 45:
            byte[] bytes43 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 80 + num1 + num2] = (object) bytes43[0];
            break;
          case 46:
            byte[] bytes44 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 81 + num1 + num2] = (object) bytes44[0];
            break;
          case 47:
            byte[] bytes45 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 82 + num1 + num2] = (object) bytes45[0];
            break;
          case 48:
            byte[] bytes46 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 83 + num1 + num2] = (object) bytes46[0];
            break;
        }
        dataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
        bool flag = true;
        foreach (DataGridViewColumn column in (BaseCollection) dataGridView.Columns)
        {
          if (dataGridView[column.Index, e.RowIndex].Value != null)
          {
            if (dataGridView[column.Index, e.RowIndex].Value.ToString() != "0")
              flag = false;
          }
          else if (dataGridView.EditingControl.Text != "0")
            flag = false;
        }
        if (!flag)
          return;
        for (int index = 0; index < this.sBlockSize; ++index)
          this.fStruct[int16 * 512 + rowIndex, index] = (object) null;
      }
    }

    private void ItemEx700dgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] != null)
        Application.OpenForms["Form_Search"].Close();
      if (this.isLeaveOpenItemAdder)
        return;
      if (Application.OpenForms["Form_BmdItemAddercs"] != null)
        Application.OpenForms["Form_BmdItemAddercs"].Close();
      this.toolStripButton_BmdItemAdder.Enabled = false;
    }

    private void ItemEx700Enc(string filePath)
    {
      List<byte> source = new List<byte>();
      for (int percentProgress = 0; percentProgress < 8192; ++percentProgress)
      {
        bool flag = false;
        for (int index = 528; index < 558; ++index)
        {
          if (Convert.ToByte(this.fStruct[percentProgress, index]) != (byte) 0)
          {
            flag = true;
            break;
          }
        }
        if (flag)
        {
          for (int index = 0; index < this.sBlockSize; ++index)
            source.Add(Convert.ToByte(this.fStruct[percentProgress, index]));
        }
        this.backgroundWorker.ReportProgress(percentProgress);
      }
      this.newFile = new byte[4 + source.Count + this.endBytes.Length];
      this.startBytes = BitConverter.GetBytes(source.Count / this.sBlockSize);
      Array.Copy((Array) this.startBytes, 0, (Array) this.newFile, 0, 4);
      byte[] array = source.ToArray<byte>();
      this.EncBlock(ref array, array.Length);
      Array.Copy((Array) array, 0, (Array) this.newFile, 4, array.Length);
      Array.Copy((Array) this.endBytes, 0, (Array) this.newFile, this.newFile.Length - 4, this.endBytes.Length);
      this.CalcCRC(this.newFile, 58097U, 0U);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void ItemEx700Plus_INI_Export()
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Title = "Select a location and file Name for the generated ItemListSettings.ini";
      saveFileDialog1.FileName = "ItemListSettings.ini";
      saveFileDialog1.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName)
      {
        AutoFlush = true
      };
      streamWriter.WriteLine("//Generated by MU.ToolKit coded by TopReal.IT");
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      List<string> stringList3 = new List<string>();
      List<string> stringList4 = new List<string>();
      List<string> stringList5 = new List<string>();
      List<string> stringList6 = new List<string>();
      List<string> stringList7 = new List<string>();
      List<string> stringList8 = new List<string>();
      List<string> stringList9 = new List<string>();
      List<string> stringList10 = new List<string>();
      List<string> stringList11 = new List<string>();
      List<string> stringList12 = new List<string>();
      List<string> stringList13 = new List<string>();
      List<string> stringList14 = new List<string>();
      List<string> stringList15 = new List<string>();
      List<string> stringList16 = new List<string>();
      for (int index = 0; index < 16; ++index)
      {
        this.tc_Items.SelectedIndex = index;
        string empty = string.Empty;
        int num = 0;
        foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
        {
          bool flag = false;
          if (num != this.workingDGV.Rows.Count - 1)
          {
            foreach (DataGridViewCell cell in (BaseCollection) row.Cells)
            {
              if (cell.Value.ToString() == "" & cell.ValueType != typeof (string))
                cell.Value = (object) "0";
              if (cell.Value.ToString() != "0" & cell.ColumnIndex != 4 & cell.ColumnIndex != 5)
                flag = true;
            }
            if (flag)
            {
              switch (Convert.ToInt32(row.Cells["Group"].Value))
              {
                case 0:
                  string str1 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList1.Add(str1);
                  break;
                case 1:
                  string str2 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList2.Add(str2);
                  break;
                case 2:
                  string str3 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList3.Add(str3);
                  break;
                case 3:
                  string str4 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList4.Add(str4);
                  break;
                case 4:
                  string str5 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList5.Add(str5);
                  break;
                case 5:
                  string str6 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList6.Add(str6);
                  break;
                case 6:
                  string str7 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Def Rate"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList7.Add(str7);
                  break;
                case 7:
                  string str8 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList8.Add(str8);
                  break;
                case 8:
                  string str9 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList9.Add(str9);
                  break;
                case 9:
                  string str10 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList10.Add(str10);
                  break;
                case 10:
                  string str11 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList11.Add(str11);
                  break;
                case 11:
                  string str12 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["WalkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList12.Add(str12);
                  break;
                case 12:
                  string str13 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Zen"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList13.Add(str13);
                  break;
                case 13:
                  string str14 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["Ice Attribute"].Value.ToString() + "\t" + row.Cells["Poison Attribute"].Value.ToString() + "\t" + row.Cells["Lightning Attribute"].Value.ToString() + "\t" + row.Cells["Fire Attribute"].Value.ToString() + "\t" + row.Cells["Earth Attribute"].Value.ToString() + "\t" + row.Cells["Wind Attribute"].Value.ToString() + "\t" + row.Cells["Water Attribute"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList14.Add(str14);
                  break;
                case 14:
                  string str15 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["ItemValue"].Value.ToString() + "\t" + row.Cells["Level"].Value.ToString();
                  stringList15.Add(str15);
                  break;
                case 15:
                  string str16 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["Zen"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList16.Add(str16);
                  break;
              }
              ++num;
            }
          }
          else
            break;
        }
      }
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("0");
      foreach (string str in stringList1)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("1");
      foreach (string str in stringList2)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("2");
      foreach (string str in stringList3)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("3");
      foreach (string str in stringList4)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("4");
      foreach (string str in stringList5)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("5");
      foreach (string str in stringList6)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tDefRate\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("6");
      foreach (string str in stringList7)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("7");
      foreach (string str in stringList8)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("8");
      foreach (string str in stringList9)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("9");
      foreach (string str in stringList10)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tASpeed\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("10");
      foreach (string str in stringList11)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tWSpeed\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("11");
      foreach (string str in stringList12)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tDur\tReqLvl\tReqEne\tReqStr\tReqDex\tReqCmd\tMoney\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("12");
      foreach (string str in stringList13)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDur\tRes1\tRes2\tRes3\tRes4\tRes5\tRes6\tRes7\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("13");
      foreach (string str in stringList14)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tValue\tLevel");
      streamWriter.WriteLine("14");
      foreach (string str in stringList15)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tReqLvl\tReqEne\tMoney\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("15");
      foreach (string str in stringList16)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.Close();
      if (MessageBox.Show("File generated succesfully.\nOpen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(saveFileDialog2.FileName);
    }

    private void ItemEx700Plus_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Ex700Plus Item.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = 8192;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ItemEx700Plus";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void ItemEx700Plusbw_DoWork(object sender, DoWorkEventArgs e) => this.ItemEx700PlusDec(((Form1.SendArgs) e.Argument).filePath);

    private void ItemEx700Plusbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_BmdItemAdder.Enabled = true;
      this.isLeaveOpenItemAdder = true;
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Visible = false;
      this.tc_Items.SelectedIndex = -1;
      this.tc_Items.SelectedIndex = 0;
    }

    private DataGridView ItemEx700PlusDec(string filePath)
    {
      DataGridView dataGridView = new DataGridView();
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray1 = new byte[fileStream.Length];
        long length = fileStream.Length;
        fileStream.Read(numArray1, 0, numArray1.Length);
        fileStream.Close();
        Array.Resize<byte>(ref this.startBytes, 4);
        Array.Copy((Array) numArray1, 0, (Array) this.startBytes, 0, 4);
        this.sSize = BitConverter.ToInt32(this.startBytes, 0);
        Array.Resize<byte>(ref this.endBytes, 4);
        this.fStruct = new object[8192, this.sBlockSize];
        Array.Copy((Array) numArray1, numArray1.Length - 4, (Array) this.endBytes, 0, 4);
        byte[] numArray2 = new byte[this.sBlockSize];
        for (int index1 = 0; index1 < this.sSize; ++index1)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray1, index1 * this.sBlockSize + 4, (Array) Buffer, 0, Buffer.Length);
          this.DecBlock(ref Buffer, Buffer.Length);
          for (int index2 = 0; index2 < this.sBlockSize; ++index2)
          {
            try
            {
              this.fStruct[(int) BitConverter.ToUInt16(Buffer, 4) * 512 + (int) BitConverter.ToUInt16(Buffer, 6), index2] = (object) Buffer[index2];
            }
            catch
            {
            }
          }
        }
      }
      catch (Exception ex)
      {
        dataGridView = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dataGridView;
    }

    private void ItemEx700Plusdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      int int16 = (int) Convert.ToInt16(dataGridView[4, e.RowIndex].Value);
      int rowIndex = e.RowIndex;
      if (e.ColumnIndex == 5 || e.ColumnIndex == 4)
      {
        if (e.ColumnIndex == 4)
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) int16;
        else
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) rowIndex;
      }
      else
      {
        if (dataGridView.EditingControl != null)
        {
          if (dataGridView.EditingControl.Text == "")
            dataGridView.EditingControl.Text = "0";
        }
        else if (this.PasteValue == "")
          this.PasteValue = "0";
        byte[] numArray1 = new byte[1];
        byte[] numArray2 = new byte[4];
        byte[] numArray3 = new byte[2];
        byte[] OrigByt1 = new byte[30];
        byte[] OrigByt2 = new byte[30];
        string empty = string.Empty;
        string str = !this.isPasteFromCP ? (dataGridView.EditingControl == null ? dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() : dataGridView.EditingControl.Text) : this.PasteValue;
        if (this.fStruct[int16 * 512 + rowIndex, 0] == null)
        {
          byte[] bytes1 = BitConverter.GetBytes(Convert.ToUInt16(int16));
          for (int index = 0; index < bytes1.Length; ++index)
            this.fStruct[int16 * 512 + rowIndex, 4 + index] = (object) bytes1[index];
          byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt16(dataGridView[5, e.RowIndex].Value));
          for (int index = 0; index < bytes2.Length; ++index)
            this.fStruct[int16 * 512 + rowIndex, 6 + index] = (object) bytes2[index];
          for (int index = 0; index < this.sBlockSize; ++index)
          {
            if (index != 4 & index != 5 & index != 6 & index != 7)
              this.fStruct[int16 * 512 + rowIndex, index] = (object) 0;
          }
        }
        int num1 = 520;
        int num2 = 8;
        switch (e.ColumnIndex)
        {
          case 0:
            byte[] bytes3 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 0] = (object) bytes3[0];
            break;
          case 1:
            byte[] bytes4 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 1] = (object) bytes4[0];
            break;
          case 2:
            byte[] bytes5 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 2] = (object) bytes5[0];
            break;
          case 3:
            byte[] bytes6 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 3] = (object) bytes6[0];
            break;
          case 6:
            this.StrToByteArray(ref OrigByt2, str);
            for (int index = 0; index < OrigByt2.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, index + num2] = (object) OrigByt2[index];
            break;
          case 7:
            this.StrToByteArray(ref OrigByt2, str);
            for (int index = 0; index < OrigByt2.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 260 + index + num2] = (object) OrigByt2[index];
            break;
          case 8:
            this.StrToByteArray(ref OrigByt1, str);
            for (int index = 0; index < OrigByt1.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 520 + index + num2] = (object) OrigByt1[index];
            break;
          case 9:
            byte[] bytes7 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 30 + num1 + num2] = (object) bytes7[0];
            break;
          case 10:
            byte[] bytes8 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 31 + num1 + num2] = (object) bytes8[0];
            break;
          case 11:
            byte[] bytes9 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes9.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 32 + num1 + num2 + index] = (object) bytes9[index];
            break;
          case 12:
            byte[] bytes10 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes10.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 34 + num1 + num2 + index] = (object) bytes10[index];
            break;
          case 13:
            byte[] bytes11 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes11.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 36 + num1 + num2 + index] = (object) bytes11[index];
            break;
          case 14:
            byte[] bytes12 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 38 + num1 + num2] = (object) bytes12[0];
            break;
          case 15:
            byte[] bytes13 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 39 + num1 + num2] = (object) bytes13[0];
            break;
          case 16:
            byte[] bytes14 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 40 + num1 + num2] = (object) bytes14[0];
            break;
          case 17:
            byte[] bytes15 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 41 + num1 + num2] = (object) bytes15[0];
            break;
          case 18:
            byte[] bytes16 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 42 + num1 + num2] = (object) bytes16[0];
            break;
          case 19:
            byte[] bytes17 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes17.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 43 + num1 + num2 + index] = (object) bytes17[index];
            break;
          case 20:
            byte[] bytes18 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 45 + num1 + num2] = (object) bytes18[0];
            break;
          case 21:
            byte[] bytes19 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 46 + num1 + num2] = (object) bytes19[0];
            break;
          case 22:
            byte[] bytes20 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 47 + num1 + num2] = (object) bytes20[0];
            break;
          case 23:
            byte[] bytes21 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 48 + num1 + num2] = (object) bytes21[0];
            break;
          case 24:
            byte[] bytes22 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 49 + num1 + num2] = (object) bytes22[0];
            break;
          case 25:
            byte[] bytes23 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes23.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 50 + num1 + num2 + index] = (object) bytes23[index];
            break;
          case 26:
            byte[] bytes24 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes24.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 52 + num1 + num2 + index] = (object) bytes24[index];
            break;
          case 27:
            byte[] bytes25 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes25.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 54 + num1 + num2 + index] = (object) bytes25[index];
            break;
          case 28:
            byte[] bytes26 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes26.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 56 + num1 + num2 + index] = (object) bytes26[index];
            break;
          case 29:
            byte[] bytes27 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes27.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 58 + num1 + num2 + index] = (object) bytes27[index];
            break;
          case 30:
            byte[] bytes28 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes28.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 60 + num1 + num2 + index] = (object) bytes28[index];
            break;
          case 31:
            byte[] bytes29 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes29.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 62 + num1 + num2 + index] = (object) bytes29[index];
            break;
          case 32:
            byte[] bytes30 = BitConverter.GetBytes(Convert.ToUInt32(str));
            for (int index = 0; index < bytes30.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 64 + num1 + num2 + index] = (object) bytes30[index];
            break;
          case 33:
            byte[] bytes31 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 68 + num1 + num2] = (object) bytes31[0];
            break;
          case 34:
            byte[] bytes32 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 69 + num1 + num2] = (object) bytes32[0];
            break;
          case 35:
            byte[] bytes33 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 70 + num1 + num2] = (object) bytes33[0];
            break;
          case 36:
            byte[] bytes34 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 71 + num1 + num2] = (object) bytes34[0];
            break;
          case 37:
            byte[] bytes35 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 72 + num1 + num2] = (object) bytes35[0];
            break;
          case 38:
            byte[] bytes36 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 73 + num1 + num2] = (object) bytes36[0];
            break;
          case 39:
            byte[] bytes37 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 74 + num1 + num2] = (object) bytes37[0];
            break;
          case 40:
            byte[] bytes38 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 75 + num1 + num2] = (object) bytes38[0];
            break;
          case 41:
            byte[] bytes39 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 76 + num1 + num2] = (object) bytes39[0];
            break;
          case 42:
            byte[] bytes40 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 77 + num1 + num2] = (object) bytes40[0];
            break;
          case 43:
            byte[] bytes41 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 78 + num1 + num2] = (object) bytes41[0];
            break;
          case 44:
            byte[] bytes42 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 79 + num1 + num2] = (object) bytes42[0];
            break;
          case 45:
            byte[] bytes43 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 80 + num1 + num2] = (object) bytes43[0];
            break;
          case 46:
            byte[] bytes44 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 81 + num1 + num2] = (object) bytes44[0];
            break;
          case 47:
            byte[] bytes45 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 82 + num1 + num2] = (object) bytes45[0];
            break;
          case 48:
            byte[] bytes46 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 83 + num1 + num2] = (object) bytes46[0];
            break;
          case 49:
            byte[] bytes47 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 84 + num1 + num2] = (object) bytes47[0];
            break;
          case 50:
            byte[] bytes48 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 85 + num1 + num2] = (object) bytes48[0];
            break;
          case 51:
            byte[] bytes49 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 86 + num1 + num2] = (object) bytes49[0];
            break;
          case 52:
            byte[] bytes50 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 87 + num1 + num2] = (object) bytes50[0];
            break;
          case 53:
            byte[] bytes51 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 88 + num1 + num2] = (object) bytes51[0];
            break;
          case 54:
            byte[] bytes52 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 89 + num1 + num2] = (object) bytes52[0];
            break;
          case 55:
            byte[] bytes53 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 90 + num1 + num2] = (object) bytes53[0];
            break;
          case 56:
            byte[] bytes54 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 91 + num1 + num2] = (object) bytes54[0];
            break;
        }
        dataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
        bool flag = true;
        foreach (DataGridViewColumn column in (BaseCollection) dataGridView.Columns)
        {
          if (dataGridView[column.Index, e.RowIndex].Value != null)
          {
            if (dataGridView[column.Index, e.RowIndex].Value.ToString() != "0")
              flag = false;
          }
          else if (dataGridView.EditingControl.Text != "0")
            flag = false;
        }
        if (!flag)
          return;
        for (int index = 0; index < this.sBlockSize; ++index)
          this.fStruct[int16 * 512 + rowIndex, index] = (object) null;
      }
    }

    private void ItemEx700Plusdgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] != null)
        Application.OpenForms["Form_Search"].Close();
      if (this.isLeaveOpenItemAdder)
        return;
      if (Application.OpenForms["Form_BmdItemAddercs"] != null)
        Application.OpenForms["Form_BmdItemAddercs"].Close();
      this.toolStripButton_BmdItemAdder.Enabled = false;
    }

    private void ItemEx700PlusEnc(string filePath)
    {
      List<byte> source = new List<byte>();
      for (int percentProgress = 0; percentProgress < 8192; ++percentProgress)
      {
        bool flag = false;
        for (int index = 528; index < 558; ++index)
        {
          if (Convert.ToByte(this.fStruct[percentProgress, index]) != (byte) 0)
          {
            flag = true;
            break;
          }
        }
        if (flag)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          for (int index = 0; index < this.sBlockSize; ++index)
            Buffer[index] = Convert.ToByte(this.fStruct[percentProgress, index]);
          this.EncBlock(ref Buffer, Buffer.Length);
          for (int index = 0; index < this.sBlockSize; ++index)
            source.Add(Buffer[index]);
        }
        this.backgroundWorker.ReportProgress(percentProgress);
      }
      this.newFile = new byte[4 + source.Count + this.endBytes.Length];
      this.startBytes = BitConverter.GetBytes(source.Count / this.sBlockSize);
      Array.Copy((Array) this.startBytes, 0, (Array) this.newFile, 0, 4);
      byte[] array = source.ToArray<byte>();
      Array.Copy((Array) array, 0, (Array) this.newFile, 4, array.Length);
      Array.Copy((Array) this.endBytes, 0, (Array) this.newFile, this.newFile.Length - 4, this.endBytes.Length);
      this.CalcCRC(this.newFile, 58097U, 0U);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void ItemSeason8Episode1_INI_Export()
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Title = "Select a location and file Name for the generated ItemListSettings.ini";
      saveFileDialog1.FileName = "ItemListSettings.ini";
      saveFileDialog1.Filter = "INI files (*.ini)|*.ini|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName)
      {
        AutoFlush = true
      };
      streamWriter.WriteLine("//Generated by MU.ToolKit coded by TopReal.IT");
      List<string> stringList1 = new List<string>();
      List<string> stringList2 = new List<string>();
      List<string> stringList3 = new List<string>();
      List<string> stringList4 = new List<string>();
      List<string> stringList5 = new List<string>();
      List<string> stringList6 = new List<string>();
      List<string> stringList7 = new List<string>();
      List<string> stringList8 = new List<string>();
      List<string> stringList9 = new List<string>();
      List<string> stringList10 = new List<string>();
      List<string> stringList11 = new List<string>();
      List<string> stringList12 = new List<string>();
      List<string> stringList13 = new List<string>();
      List<string> stringList14 = new List<string>();
      List<string> stringList15 = new List<string>();
      List<string> stringList16 = new List<string>();
      for (int index = 0; index < 16; ++index)
      {
        this.tc_Items.SelectedIndex = index;
        string empty = string.Empty;
        int num = 0;
        foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
        {
          bool flag = false;
          if (num != this.workingDGV.Rows.Count - 1)
          {
            foreach (DataGridViewCell cell in (BaseCollection) row.Cells)
            {
              if (cell.Value.ToString() == "" & cell.ValueType != typeof (string))
                cell.Value = (object) "0";
              if (cell.Value.ToString() != "0" & cell.ColumnIndex != 4 & cell.ColumnIndex != 5)
                flag = true;
            }
            if (flag)
            {
              switch (Convert.ToInt32(row.Cells["Group"].Value))
              {
                case 0:
                  string str1 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList1.Add(str1);
                  break;
                case 1:
                  string str2 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList2.Add(str2);
                  break;
                case 2:
                  string str3 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList3.Add(str3);
                  break;
                case 3:
                  string str4 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList4.Add(str4);
                  break;
                case 4:
                  string str5 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList5.Add(str5);
                  break;
                case 5:
                  string str6 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Min Dmg"].Value.ToString() + "\t" + row.Cells["Max Dmg"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["MagicPwr"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList6.Add(str6);
                  break;
                case 6:
                  string str7 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Def Rate"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList7.Add(str7);
                  break;
                case 7:
                  string str8 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList8.Add(str8);
                  break;
                case 8:
                  string str9 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList9.Add(str9);
                  break;
                case 9:
                  string str10 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["MagicDur"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList10.Add(str10);
                  break;
                case 10:
                  string str11 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["AtkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList11.Add(str11);
                  break;
                case 11:
                  string str12 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["WalkSpeed"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList12.Add(str12);
                  break;
                case 12:
                  string str13 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Defense"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqStr"].Value.ToString() + "\t" + row.Cells["ReqDex"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["ReqVit"].Value.ToString() + "\t" + row.Cells["ReqLea"].Value.ToString() + "\t" + row.Cells["Zen"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList13.Add(str13);
                  break;
                case 13:
                  string str14 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["Durability"].Value.ToString() + "\t" + row.Cells["Ice Attribute"].Value.ToString() + "\t" + row.Cells["Poison Attribute"].Value.ToString() + "\t" + row.Cells["Lightning Attribute"].Value.ToString() + "\t" + row.Cells["Fire Attribute"].Value.ToString() + "\t" + row.Cells["Earth Attribute"].Value.ToString() + "\t" + row.Cells["Wind Attribute"].Value.ToString() + "\t" + row.Cells["Water Attribute"].Value.ToString() + "\t" + row.Cells["SetOption"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList14.Add(str14);
                  break;
                case 14:
                  string str15 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["ItemValue"].Value.ToString() + "\t" + row.Cells["Level"].Value.ToString();
                  stringList15.Add(str15);
                  break;
                case 15:
                  string str16 = "\"" + row.Cells["Model Folder"].Value.ToString() + "\"\t\"" + row.Cells["Model Name"].Value.ToString() + "\"\t\t" + row.Cells["Type"].Value.ToString() + "\t" + row.Cells["Index"].Value.ToString() + "\t" + row.Cells["Slot"].Value.ToString() + "\t" + row.Cells["Skill"].Value.ToString() + "\t" + row.Cells["X"].Value.ToString() + "\t" + row.Cells["Y"].Value.ToString() + "\t1\t1\t1\t\"" + row.Cells["Name"].Value.ToString() + "\"\t\t\t\t" + row.Cells["Level"].Value.ToString() + "\t" + row.Cells["ReqLvl"].Value.ToString() + "\t" + row.Cells["ReqEne"].Value.ToString() + "\t" + row.Cells["Zen"].Value.ToString() + "\t" + row.Cells[34].Value.ToString() + "\t" + row.Cells[35].Value.ToString() + "\t" + row.Cells[36].Value.ToString() + "\t" + row.Cells[37].Value.ToString() + "\t" + row.Cells[38].Value.ToString() + "\t" + row.Cells[39].Value.ToString() + "\t" + row.Cells[40].Value.ToString();
                  stringList16.Add(str16);
                  break;
              }
              ++num;
            }
          }
          else
            break;
        }
      }
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("0");
      foreach (string str in stringList1)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("1");
      foreach (string str in stringList2)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("2");
      foreach (string str in stringList3)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("3");
      foreach (string str in stringList4)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("4");
      foreach (string str in stringList5)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDmgMin\tDmgMax\tASpeed\tDur\tMagDur\tMagPW\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("5");
      foreach (string str in stringList6)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tDefRate\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("6");
      foreach (string str in stringList7)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("7");
      foreach (string str in stringList8)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("8");
      foreach (string str in stringList9)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tMagDef\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("9");
      foreach (string str in stringList10)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tASpeed\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("10");
      foreach (string str in stringList11)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tWSpeed\tDur\tReqLvl\tReqStr\tReqDex\tReqEne\tReqVit\tReqCmd\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("11");
      foreach (string str in stringList12)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDef\tDur\tReqLvl\tReqEne\tReqStr\tReqDex\tReqCmd\tMoney\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("12");
      foreach (string str in stringList13)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tDur\tRes1\tRes2\tRes3\tRes4\tRes5\tRes6\tRes7\tSetA\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("13");
      foreach (string str in stringList14)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tValue\tLevel");
      streamWriter.WriteLine("14");
      foreach (string str in stringList15)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.WriteLine();
      streamWriter.WriteLine("//Texture\tModel\t\t\tType\tIndex\tSlot\tSkill\tX\tY\tSerial\tOption\tDrop\tName\t\t\t\tlevel\tReqLvl\tReqEne\tMoney\tC0\tC1\tC2\tC3\tC4\tC5\tC6");
      streamWriter.WriteLine("15");
      foreach (string str in stringList16)
        streamWriter.WriteLine(str);
      streamWriter.WriteLine("end");
      streamWriter.Close();
      if (MessageBox.Show("File generated succesfully.\nOpen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(saveFileDialog2.FileName);
    }

    private void ItemSeason8Episode1_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Season 8 Episode 1 Item.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = 8192;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ItemSeason8Episode1";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void ItemSeason8Episode1bw_DoWork(object sender, DoWorkEventArgs e) => this.ItemSeason8Episode1Dec(((Form1.SendArgs) e.Argument).filePath);

    private void ItemSeason8Episode1bw_RunWorkerCompleted(
      object sender,
      RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_BmdItemAdder.Enabled = true;
      this.isLeaveOpenItemAdder = true;
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Visible = false;
      this.tc_Items.SelectedIndex = -1;
      this.tc_Items.SelectedIndex = 0;
    }

    private DataGridView ItemSeason8Episode1Dec(string filePath)
    {
      DataGridView dataGridView = new DataGridView();
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray1 = new byte[fileStream.Length];
        long length = fileStream.Length;
        fileStream.Read(numArray1, 0, numArray1.Length);
        fileStream.Close();
        Array.Resize<byte>(ref this.startBytes, 4);
        Array.Copy((Array) numArray1, 0, (Array) this.startBytes, 0, 4);
        this.sSize = BitConverter.ToInt32(this.startBytes, 0);
        Array.Resize<byte>(ref this.endBytes, 4);
        this.sBlockSize = (numArray1.Length - 8) / this.sSize;
        this.fStruct = new object[8192, this.sBlockSize];
        Array.Copy((Array) numArray1, numArray1.Length - 4, (Array) this.endBytes, 0, 4);
        byte[] numArray2 = new byte[this.sBlockSize];
        for (int index1 = 0; index1 < this.sSize; ++index1)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray1, index1 * this.sBlockSize + 4, (Array) Buffer, 0, Buffer.Length);
          this.DecBlock(ref Buffer, Buffer.Length);
          for (int index2 = 0; index2 < this.sBlockSize; ++index2)
          {
            try
            {
              this.fStruct[(int) BitConverter.ToUInt16(Buffer, 4) * 512 + (int) BitConverter.ToUInt16(Buffer, 6), index2] = (object) Buffer[index2];
            }
            catch
            {
            }
          }
        }
      }
      catch (Exception ex)
      {
        dataGridView = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dataGridView;
    }

    private void ItemSeason8Episode1dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      int int16 = (int) Convert.ToInt16(dataGridView[4, e.RowIndex].Value);
      int rowIndex = e.RowIndex;
      if (e.ColumnIndex == 5 || e.ColumnIndex == 4)
      {
        if (e.ColumnIndex == 4)
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) int16;
        else
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) rowIndex;
      }
      else
      {
        if (dataGridView.EditingControl != null)
        {
          if (dataGridView.EditingControl.Text == "")
            dataGridView.EditingControl.Text = "0";
        }
        else if (this.PasteValue == "")
          this.PasteValue = "0";
        byte[] numArray1 = new byte[1];
        byte[] numArray2 = new byte[4];
        byte[] numArray3 = new byte[2];
        byte[] OrigByt1 = new byte[30];
        byte[] OrigByt2 = new byte[30];
        string empty = string.Empty;
        string str = !this.isPasteFromCP ? (dataGridView.EditingControl == null ? dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() : dataGridView.EditingControl.Text) : this.PasteValue;
        if (this.fStruct[int16 * 512 + rowIndex, 0] == null)
        {
          byte[] bytes1 = BitConverter.GetBytes(Convert.ToUInt16(int16));
          for (int index = 0; index < bytes1.Length; ++index)
            this.fStruct[int16 * 512 + rowIndex, 4 + index] = (object) bytes1[index];
          byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt16(dataGridView[5, e.RowIndex].Value));
          for (int index = 0; index < bytes2.Length; ++index)
            this.fStruct[int16 * 512 + rowIndex, 6 + index] = (object) bytes2[index];
          for (int index = 0; index < this.sBlockSize; ++index)
          {
            if (index != 4 & index != 5 & index != 6 & index != 7)
              this.fStruct[int16 * 512 + rowIndex, index] = (object) 0;
          }
        }
        int num1 = 520;
        int num2 = 8;
        switch (e.ColumnIndex)
        {
          case 0:
            byte[] bytes3 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 0] = (object) bytes3[0];
            break;
          case 1:
            byte[] bytes4 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 1] = (object) bytes4[0];
            break;
          case 2:
            byte[] bytes5 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 2] = (object) bytes5[0];
            break;
          case 3:
            byte[] bytes6 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 3] = (object) bytes6[0];
            break;
          case 6:
            this.StrToByteArray(ref OrigByt2, str);
            for (int index = 0; index < OrigByt2.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, index + num2] = (object) OrigByt2[index];
            break;
          case 7:
            this.StrToByteArray(ref OrigByt2, str);
            for (int index = 0; index < OrigByt2.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 260 + index + num2] = (object) OrigByt2[index];
            break;
          case 8:
            this.StrToByteArray(ref OrigByt1, str);
            for (int index = 0; index < OrigByt1.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 520 + index + num2] = (object) OrigByt1[index];
            break;
          case 9:
            byte[] bytes7 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 30 + num1 + num2] = (object) bytes7[0];
            break;
          case 10:
            byte[] bytes8 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 31 + num1 + num2] = (object) bytes8[0];
            break;
          case 11:
            byte[] bytes9 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes9.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 32 + num1 + num2 + index] = (object) bytes9[index];
            break;
          case 12:
            byte[] bytes10 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes10.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 34 + num1 + num2 + index] = (object) bytes10[index];
            break;
          case 13:
            byte[] bytes11 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes11.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 36 + num1 + num2 + index] = (object) bytes11[index];
            break;
          case 14:
            byte[] bytes12 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 38 + num1 + num2] = (object) bytes12[0];
            break;
          case 15:
            byte[] bytes13 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 39 + num1 + num2] = (object) bytes13[0];
            break;
          case 16:
            byte[] bytes14 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 40 + num1 + num2] = (object) bytes14[0];
            break;
          case 17:
            byte[] bytes15 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 41 + num1 + num2] = (object) bytes15[0];
            break;
          case 18:
            byte[] bytes16 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 42 + num1 + num2] = (object) bytes16[0];
            break;
          case 19:
            byte[] bytes17 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes17.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 43 + num1 + num2 + index] = (object) bytes17[index];
            break;
          case 20:
            byte[] bytes18 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 45 + num1 + num2] = (object) bytes18[0];
            break;
          case 21:
            byte[] bytes19 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 46 + num1 + num2] = (object) bytes19[0];
            break;
          case 22:
            byte[] bytes20 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 47 + num1 + num2] = (object) bytes20[0];
            break;
          case 23:
            byte[] bytes21 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 48 + num1 + num2] = (object) bytes21[0];
            break;
          case 24:
            byte[] bytes22 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 49 + num1 + num2] = (object) bytes22[0];
            break;
          case 25:
            byte[] bytes23 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes23.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 50 + num1 + num2 + index] = (object) bytes23[index];
            break;
          case 26:
            byte[] bytes24 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes24.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 52 + num1 + num2 + index] = (object) bytes24[index];
            break;
          case 27:
            byte[] bytes25 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes25.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 54 + num1 + num2 + index] = (object) bytes25[index];
            break;
          case 28:
            byte[] bytes26 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes26.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 56 + num1 + num2 + index] = (object) bytes26[index];
            break;
          case 29:
            byte[] bytes27 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes27.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 58 + num1 + num2 + index] = (object) bytes27[index];
            break;
          case 30:
            byte[] bytes28 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes28.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 60 + num1 + num2 + index] = (object) bytes28[index];
            break;
          case 31:
            byte[] bytes29 = BitConverter.GetBytes(Convert.ToUInt16(str));
            for (int index = 0; index < bytes29.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 62 + num1 + num2 + index] = (object) bytes29[index];
            break;
          case 32:
            byte[] bytes30 = BitConverter.GetBytes(Convert.ToUInt32(str));
            for (int index = 0; index < bytes30.Length; ++index)
              this.fStruct[int16 * 512 + rowIndex, 64 + num1 + num2 + index] = (object) bytes30[index];
            break;
          case 33:
            byte[] bytes31 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 68 + num1 + num2] = (object) bytes31[0];
            break;
          case 34:
            byte[] bytes32 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 69 + num1 + num2] = (object) bytes32[0];
            break;
          case 35:
            byte[] bytes33 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 70 + num1 + num2] = (object) bytes33[0];
            break;
          case 36:
            byte[] bytes34 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 71 + num1 + num2] = (object) bytes34[0];
            break;
          case 37:
            byte[] bytes35 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 72 + num1 + num2] = (object) bytes35[0];
            break;
          case 38:
            byte[] bytes36 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 73 + num1 + num2] = (object) bytes36[0];
            break;
          case 39:
            byte[] bytes37 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 74 + num1 + num2] = (object) bytes37[0];
            break;
          case 40:
            byte[] bytes38 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 75 + num1 + num2] = (object) bytes38[0];
            break;
          case 41:
            byte[] bytes39 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 76 + num1 + num2] = (object) bytes39[0];
            break;
          case 42:
            byte[] bytes40 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 77 + num1 + num2] = (object) bytes40[0];
            break;
          case 43:
            byte[] bytes41 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 78 + num1 + num2] = (object) bytes41[0];
            break;
          case 44:
            byte[] bytes42 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 79 + num1 + num2] = (object) bytes42[0];
            break;
          case 45:
            byte[] bytes43 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 80 + num1 + num2] = (object) bytes43[0];
            break;
          case 46:
            byte[] bytes44 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 81 + num1 + num2] = (object) bytes44[0];
            break;
          case 47:
            byte[] bytes45 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 82 + num1 + num2] = (object) bytes45[0];
            break;
          case 48:
            byte[] bytes46 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 83 + num1 + num2] = (object) bytes46[0];
            break;
          case 49:
            byte[] bytes47 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 84 + num1 + num2] = (object) bytes47[0];
            break;
          case 50:
            byte[] bytes48 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 85 + num1 + num2] = (object) bytes48[0];
            break;
          case 51:
            byte[] bytes49 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 86 + num1 + num2] = (object) bytes49[0];
            break;
          case 52:
            byte[] bytes50 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 87 + num1 + num2] = (object) bytes50[0];
            break;
          case 53:
            byte[] bytes51 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 88 + num1 + num2] = (object) bytes51[0];
            break;
          case 54:
            byte[] bytes52 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 89 + num1 + num2] = (object) bytes52[0];
            break;
          case 55:
            byte[] bytes53 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 90 + num1 + num2] = (object) bytes53[0];
            break;
          case 56:
            byte[] bytes54 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 91 + num1 + num2] = (object) bytes54[0];
            break;
          case 57:
            byte[] bytes55 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 620] = (object) bytes55[0];
            break;
          case 58:
            byte[] bytes56 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 621] = (object) bytes56[0];
            break;
          case 59:
            byte[] bytes57 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 622] = (object) bytes57[0];
            break;
          case 60:
            byte[] bytes58 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 623] = (object) bytes58[0];
            break;
          case 61:
            byte[] bytes59 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 624] = (object) bytes59[0];
            break;
          case 62:
            byte[] bytes60 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 625] = (object) bytes60[0];
            break;
          case 63:
            byte[] bytes61 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 626] = (object) bytes61[0];
            break;
          case 64:
            byte[] bytes62 = BitConverter.GetBytes(Convert.ToUInt16(str));
            this.fStruct[int16 * 512 + rowIndex, 627] = (object) bytes62[0];
            break;
        }
        dataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
        bool flag = true;
        foreach (DataGridViewColumn column in (BaseCollection) dataGridView.Columns)
        {
          if (dataGridView[column.Index, e.RowIndex].Value != null)
          {
            if (dataGridView[column.Index, e.RowIndex].Value.ToString() != "0")
              flag = false;
          }
          else if (dataGridView.EditingControl.Text != "0")
            flag = false;
        }
        if (!flag)
          return;
        for (int index = 0; index < this.sBlockSize; ++index)
          this.fStruct[int16 * 512 + rowIndex, index] = (object) null;
      }
    }

    private void ItemSeason8Episode1dgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] != null)
        Application.OpenForms["Form_Search"].Close();
      if (this.isLeaveOpenItemAdder)
        return;
      if (Application.OpenForms["Form_BmdItemAddercs"] != null)
        Application.OpenForms["Form_BmdItemAddercs"].Close();
      this.toolStripButton_BmdItemAdder.Enabled = false;
    }

    private void ItemSeason8Episode1Enc(string filePath)
    {
      List<byte> source = new List<byte>();
      for (int percentProgress = 0; percentProgress < 8192; ++percentProgress)
      {
        bool flag = false;
        for (int index = 528; index < 558; ++index)
        {
          if (Convert.ToByte(this.fStruct[percentProgress, index]) != (byte) 0)
          {
            flag = true;
            break;
          }
        }
        if (flag)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          for (int index = 0; index < this.sBlockSize; ++index)
            Buffer[index] = Convert.ToByte(this.fStruct[percentProgress, index]);
          this.EncBlock(ref Buffer, Buffer.Length);
          for (int index = 0; index < this.sBlockSize; ++index)
            source.Add(Buffer[index]);
        }
        this.backgroundWorker.ReportProgress(percentProgress);
      }
      this.newFile = new byte[4 + source.Count + this.endBytes.Length];
      this.startBytes = BitConverter.GetBytes(source.Count / this.sBlockSize);
      Array.Copy((Array) this.startBytes, 0, (Array) this.newFile, 0, 4);
      byte[] array = source.ToArray<byte>();
      Array.Copy((Array) array, 0, (Array) this.newFile, 4, array.Length);
      Array.Copy((Array) this.endBytes, 0, (Array) this.newFile, this.newFile.Length - 4, this.endBytes.Length);
      Array.Copy((Array) this.CalcCRC(this.newFile, 58097U, 0U), 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void ItemSetOption_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the ItemSetOption.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize + 4];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ItemSetOption";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void ItemSetOptionbw_DoWork(object sender, DoWorkEventArgs e) => this.ItemSetOptiondgv = this.ItemSetOptionDec(((Form1.SendArgs) e.Argument).filePath);

    private void ItemSetOptionbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.panel1.Controls.Add((Control) this.ItemSetOptiondgv);
      this.progressBar_Loading.Visible = false;
      this.ItemSetOptiondgv.CellValueChanged += new DataGridViewCellEventHandler(this.ItemSetOptiondgv_CellValueChanged);
      this.ItemSetOptiondgv.Disposed += new EventHandler(this.ItemSetOptiondgv_Disposed);
      this.ItemSetOptiondgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.ItemSetOptiondgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView ItemSetOptionDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      this.initializeItemSetOptionGrid(dgv);
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        this.sBlockSize = 110;
        byte[] numArray = new byte[fileStream.Length];
        this.sSize = ((int) fileStream.Length - 4) / this.sBlockSize;
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray, rowIndex * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, Buffer.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(Buffer, 0, 64).Trim(new char[1]).Replace("?", "");
          for (int columnIndex = 1; columnIndex < 47; ++columnIndex)
            dgv[columnIndex, rowIndex].Value = (object) Buffer[columnIndex + 63];
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void ItemSetOptiondgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => ((DataGridView) sender)[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void ItemSetOptiondgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void ItemSetOptionEnc(string filePath)
    {
      int num = 0;
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        bool flag = true;
        for (int index = 1; index < 47; ++index)
        {
          if (row.Cells[index].Value == null)
          {
            flag = false;
            break;
          }
        }
        if (flag)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[0].Value.ToString());
          Array.Resize<byte>(ref bytes, 64);
          Array.Copy((Array) bytes, 0, (Array) Buffer, 0, 64);
          for (int index = 0; index < 46; ++index)
            Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[index + 1].Value.ToString())), 0, (Array) Buffer, index + 64, 1);
          this.EncBlock(ref Buffer, this.sBlockSize);
          for (int index = 0; index < Buffer.Length; ++index)
            byteList.Add(Buffer[index]);
          this.backgroundWorker.ReportProgress(row.Index);
          num += this.sBlockSize;
        }
      }
      byte[] array = byteList.ToArray();
      this.newFile = new byte[array.Length + 4];
      Array.Copy((Array) array, (Array) this.newFile, array.Length);
      Array.Copy((Array) this.CalcCRC(this.newFile, 41713U, 0U), 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void ItemSetType_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the ItemSetType.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize + 4];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.sSize * this.sBlockSize;
      this.Invalidate();
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ItemSetType";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private DataGridView ItemSetTypeDec(string filePath)
    {
      DataGridView dataGridView = new DataGridView();
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray = new byte[fileStream.Length];
        this.sBlockSize = 4;
        this.sSize = (numArray.Length - 4) / this.sBlockSize;
        this.T_fStruct = new byte[this.sSize * this.sBlockSize];
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        Array.Copy((Array) numArray, numArray.Length - 4, (Array) this.endBytes, 0, 4);
        byte[] Buffer = new byte[this.sBlockSize];
        int num1 = 0;
        int num2 = 0;
        for (int index1 = 0; index1 < this.sSize; ++index1)
        {
          Array.Copy((Array) numArray, index1 * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, this.sBlockSize);
          bool flag = false;
          for (int index2 = 0; index2 < Buffer.Length; ++index2)
          {
            if (Buffer[index2] != (byte) 0)
            {
              flag = true;
              break;
            }
          }
          if (flag)
          {
            for (int index3 = 0; index3 < this.sBlockSize; ++index3)
              this.T_fStruct[(512 * num2 + num1) * this.sBlockSize + index3] = Buffer[index3];
          }
          ++num1;
          if (num1 > 511)
          {
            num1 = 0;
            ++num2;
          }
        }
      }
      catch (Exception ex)
      {
        dataGridView = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dataGridView;
    }

    private void ItemSetTypeEnc(string filePath)
    {
      byte[] Buffer = new byte[this.sBlockSize];
      for (int index = 0; index < this.sSize; ++index)
      {
        Array.Copy((Array) this.T_fStruct, index * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
        this.EncBlock(ref Buffer, this.sBlockSize);
        Array.Copy((Array) Buffer, 0, (Array) this.newFile, index * this.sBlockSize, Buffer.Length);
      }
      Array.Copy((Array) this.endBytes, 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      Array.Copy((Array) this.CalcCRC(((IEnumerable<byte>) this.newFile).ToArray<byte>(), 58865U, 0U), 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void ItemToolTip_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the ItemToolTip.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize + 4];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.sSize * this.sBlockSize;
      this.Invalidate();
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ItemToolTip";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private DataGridView ItemToolTipDec(string filePath)
    {
      DataGridView dataGridView = new DataGridView();
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray = new byte[fileStream.Length];
        this.T_fStruct = new byte[this.sSize * this.sBlockSize];
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        Array.Copy((Array) numArray, numArray.Length - 4, (Array) this.endBytes, 0, 4);
        byte[] Buffer = new byte[this.sBlockSize];
        int num1 = 0;
        for (int index1 = 0; index1 < this.sSize; ++index1)
        {
          Array.Copy((Array) numArray, index1 * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, this.sBlockSize);
          bool flag = false;
          for (int index2 = 4; index2 < 69; ++index2)
          {
            if (Buffer[index2] != (byte) 0)
            {
              flag = true;
              break;
            }
          }
          if (flag)
          {
            int num2 = Convert.ToInt32(BitConverter.ToUInt16(Buffer, 2));
            if (num1 != (int) Buffer[0])
              num2 = 0;
            for (int index3 = 0; index3 < this.sBlockSize; ++index3)
              this.T_fStruct[(512 * (int) Buffer[0] + num2) * this.sBlockSize + index3] = Buffer[index3];
            num1 = (int) Buffer[0];
          }
        }
      }
      catch (Exception ex)
      {
        dataGridView = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dataGridView;
    }

    private void ItemToolTipEnc(string filePath)
    {
      byte[] Buffer = new byte[this.sBlockSize];
      int num = 0;
      for (int index = 0; index < this.sSize; ++index)
      {
        Array.Copy((Array) this.T_fStruct, index * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
        this.EncBlock(ref Buffer, this.sBlockSize);
        Array.Copy((Array) Buffer, 0, (Array) this.newFile, index * this.sBlockSize, Buffer.Length);
        ++num;
        if (num > 511)
          num = 0;
      }
      Array.Copy((Array) this.endBytes, 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      Array.Copy((Array) this.CalcCRC(((IEnumerable<byte>) this.newFile).ToArray<byte>(), 58097U, 0U), 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void ItemToolTipText_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the ItemToolTipText.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ItemToolTipText";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void ItemToolTipTextbw_DoWork(object sender, DoWorkEventArgs e) => this.ItemToolTipTextdgv = this.ItemToolTipTextDec(((Form1.SendArgs) e.Argument).filePath);

    private void ItemToolTipTextbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.panel1.Controls.Add((Control) this.ItemToolTipTextdgv);
      this.progressBar_Loading.Visible = false;
      this.ItemToolTipTextdgv.Disposed += new EventHandler(this.ItemToolTipTextdgv_Disposed);
      this.ItemToolTipTextdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.ItemToolTipTextdgv.CellValueChanged += new DataGridViewCellEventHandler(this.ItemToolTipTextdgv_CellValueChanged);
      this.workingDGV = this.ItemToolTipTextdgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView ItemToolTipTextDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeItemToolTipTextGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray1 = new byte[fileStream.Length];
        fileStream.Read(numArray1, 0, numArray1.Length);
        fileStream.Close();
        this.endBytes = new byte[4];
        Array.Copy((Array) numArray1, numArray1.Length - 4, (Array) this.endBytes, 0, this.endBytes.Length);
        this.sBlockSize = 260;
        this.sSize = (numArray1.Length - 4) / this.sBlockSize;
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray1, rowIndex * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, Buffer.Length);
          byte[] numArray2 = new byte[256];
          Array.Copy((Array) Buffer, 2, (Array) numArray2, 0, numArray2.Length);
          string empty = string.Empty;
          foreach (byte num in numArray2)
            empty += (string) (object) Convert.ToChar(num);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, 0);
          dgv[1, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace("\0", string.Empty);
          dgv[2, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, 258);
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void ItemToolTipTextdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      if (dataGridView.EditingControl != null)
      {
        if (dataGridView.EditingControl.Text.Length > 258)
        {
          int num = (int) MessageBox.Show("Maximum 20 Chars allowed.", "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          dataGridView.EditingControl.Text = dataGridView.EditingControl.Text.Remove(258);
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) dataGridView.EditingControl.Text;
        }
      }
      else if (this.isPasteFromCP)
      {
        if (this.PasteValue.Length > 20)
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) this.PasteValue.Remove(258);
      }
      else if (dataGridView.CurrentCell.Value.ToString().Length > 20)
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) dataGridView.CurrentCell.Value.ToString().Remove(258);
      this.ItemToolTipTextdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
    }

    private void ItemToolTipTextdgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void ItemToolTipTextEnc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        byte[] Buffer = new byte[this.sBlockSize];
        ushort num1 = 0;
        string empty = string.Empty;
        ushort num2 = 0;
        if (row.Cells[0].Value != null)
          num1 = Convert.ToUInt16(row.Cells[0].Value.ToString());
        if (row.Cells[1].Value != null)
          empty = row.Cells[1].Value.ToString();
        if (row.Cells[2].Value != null)
          num2 = Convert.ToUInt16(row.Cells[2].Value.ToString());
        Array.Copy((Array) BitConverter.GetBytes(num1), 0, (Array) Buffer, 0, 2);
        byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(empty);
        Array.Copy((Array) bytes, 0, (Array) Buffer, 2, bytes.Length);
        Array.Copy((Array) BitConverter.GetBytes(num2), 0, (Array) Buffer, 258, 2);
        this.EncBlock(ref Buffer, Buffer.Length);
        for (int index = 0; index < Buffer.Length; ++index)
          byteList.Add(Buffer[index]);
        this.backgroundWorker.ReportProgress(this.workingDGV.Rows.IndexOf(row));
      }
      for (int index = 0; index < this.endBytes.Length; ++index)
        byteList.Add(this.endBytes[index]);
      this.newFile = new byte[0];
      this.CalcCRC(byteList.ToArray(), 15997U, 0U);
      this.newFile = byteList.ToArray();
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void itemToolTipTextToolStripMenuItem_Load_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the ItemToolTipText.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "ItemToolTipText";
      this.ItemToolTipTextdgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.ItemToolTipTextbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.ItemToolTipTextbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "ItemToolTipText.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void ITTbw_DoWork(object sender, DoWorkEventArgs e) => this.ItemToolTipDec(((Form1.SendArgs) e.Argument).filePath);

    private void ITTbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_BmdItemAdder.Enabled = true;
      this.isLeaveOpenItemAdder = true;
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.progressBar_Loading.Visible = false;
      this.tc_Items.SelectedIndex = -1;
      this.tc_Items.SelectedIndex = 0;
    }

    private void ITTdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      byte num = Convert.ToByte(dataGridView[0, e.RowIndex].Value);
      int rowIndex = e.RowIndex;
      if (e.ColumnIndex == 0)
      {
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) num;
      }
      else
      {
        if (dataGridView.EditingControl != null)
        {
          if (dataGridView.EditingControl.Text == "")
            dataGridView.EditingControl.Text = "0";
        }
        else if (this.PasteValue == "")
          this.PasteValue = "0";
        byte[] OrigByt = new byte[64];
        byte[] numArray = new byte[2];
        string empty = string.Empty;
        string str = !this.isPasteFromCP ? (dataGridView.EditingControl == null ? dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() : dataGridView.EditingControl.Text) : this.PasteValue;
        if (e.ColumnIndex == 1 && Convert.ToInt16(str) > (short) 511)
        {
          str = "511";
          dataGridView.EditingControl.Text = str;
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) str;
        }
        this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize] = num;
        switch (e.ColumnIndex)
        {
          case 1:
            byte[] bytes1 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes1.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 2 + index] = bytes1[index];
            break;
          case 2:
            this.StrToByteArray(ref OrigByt, str);
            for (int index = 0; index < OrigByt.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 4 + index] = OrigByt[index];
            break;
          case 3:
            byte[] bytes2 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes2.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 68 + index] = bytes2[index];
            break;
          case 4:
            byte[] bytes3 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes3.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 70 + index] = bytes3[index];
            break;
          case 5:
            byte[] bytes4 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes4.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 72 + index] = bytes4[index];
            break;
          case 6:
            byte[] bytes5 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes5.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 74 + index] = bytes5[index];
            break;
          case 7:
            byte[] bytes6 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes6.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 76 + index] = bytes6[index];
            break;
          case 8:
            byte[] bytes7 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes7.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 78 + index] = bytes7[index];
            break;
          case 9:
            byte[] bytes8 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes8.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 80 + index] = bytes8[index];
            break;
          case 10:
            byte[] bytes9 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes9.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 82 + index] = bytes9[index];
            break;
          case 11:
            byte[] bytes10 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes10.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 84 + index] = bytes10[index];
            break;
          case 12:
            byte[] bytes11 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes11.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 86 + index] = bytes11[index];
            break;
          case 13:
            byte[] bytes12 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes12.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 88 + index] = bytes12[index];
            break;
          case 14:
            byte[] bytes13 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes13.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 90 + index] = bytes13[index];
            break;
          case 15:
            byte[] bytes14 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes14.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 92 + index] = bytes14[index];
            break;
          case 16:
            byte[] bytes15 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes15.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 94 + index] = bytes15[index];
            break;
          case 17:
            byte[] bytes16 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes16.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 96 + index] = bytes16[index];
            break;
          case 18:
            byte[] bytes17 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes17.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 98 + index] = bytes17[index];
            break;
          case 19:
            byte[] bytes18 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes18.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 100 + index] = bytes18[index];
            break;
          case 20:
            byte[] bytes19 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes19.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 102 + index] = bytes19[index];
            break;
          case 21:
            byte[] bytes20 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes20.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 104 + index] = bytes20[index];
            break;
          case 22:
            byte[] bytes21 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes21.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 106 + index] = bytes21[index];
            break;
          case 23:
            byte[] bytes22 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes22.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 108 + index] = bytes22[index];
            break;
          case 24:
            byte[] bytes23 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes23.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 110 + index] = bytes23[index];
            break;
          case 25:
            byte[] bytes24 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes24.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 112 + index] = bytes24[index];
            break;
          case 26:
            byte[] bytes25 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes25.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 114 + index] = bytes25[index];
            break;
          case 27:
            byte[] bytes26 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes26.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 116 + index] = bytes26[index];
            break;
          case 28:
            byte[] bytes27 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes27.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 118 + index] = bytes27[index];
            break;
          case 29:
            byte[] bytes28 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes28.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 120 + index] = bytes28[index];
            break;
          case 30:
            byte[] bytes29 = BitConverter.GetBytes(Convert.ToInt16(str));
            for (int index = 0; index < bytes29.Length; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + 122 + index] = bytes29[index];
            break;
        }
        dataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
        bool flag = true;
        foreach (DataGridViewColumn column in (BaseCollection) dataGridView.Columns)
        {
          if (dataGridView[column.Index, e.RowIndex].Value != null)
          {
            if (dataGridView[column.Index, e.RowIndex].Value.ToString() != "0" || dataGridView[column.Index, e.RowIndex].Value.ToString() != "")
              flag = false;
          }
          else if (dataGridView.EditingControl.Text != "0" || dataGridView[column.Index, e.RowIndex].Value.ToString() != "")
            flag = false;
        }
        if (!flag)
          return;
        for (int index = 0; index < this.sBlockSize; ++index)
          this.T_fStruct[(int) num * 512 * this.sBlockSize + index] = (byte) 0;
      }
    }

    private void ITTdgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] != null)
        Application.OpenForms["Form_Search"].Close();
      if (this.isLeaveOpenItemAdder)
        return;
      if (Application.OpenForms["Form_BmdItemAddercs"] != null)
        Application.OpenForms["Form_BmdItemAddercs"].Close();
      this.toolStripButton_BmdItemAdder.Enabled = false;
    }

    private void JewelOfHarmonySmelt_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the JewelOfHarmonySmelt.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.sSize * this.sBlockSize;
      this.Invalidate();
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "JewelOfHarmonySmelt";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private DataGridView JewelOfHarmonySmeltDec(string filePath)
    {
      DataGridView dataGridView = new DataGridView();
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] Buffer = new byte[fileStream.Length];
        this.sBlockSize = 68;
        this.sSize = Buffer.Length / this.sBlockSize;
        this.T_fStruct = new byte[this.sSize * this.sBlockSize];
        fileStream.Read(Buffer, 0, Buffer.Length);
        fileStream.Close();
        this.DecBlock(ref Buffer, Buffer.Length);
        byte[] destinationArray = new byte[this.sBlockSize];
        int num1 = 0;
        int num2 = 0;
        for (int index1 = 0; index1 < this.sSize; ++index1)
        {
          Array.Copy((Array) Buffer, index1 * this.sBlockSize, (Array) destinationArray, 0, this.sBlockSize);
          bool flag = false;
          for (int index2 = 0; index2 < destinationArray.Length; ++index2)
          {
            if (destinationArray[index2] != (byte) 0)
            {
              flag = true;
              break;
            }
          }
          if (flag)
          {
            for (int index3 = 0; index3 < this.sBlockSize; ++index3)
              this.T_fStruct[(512 * num2 + num1) * this.sBlockSize + index3] = destinationArray[index3];
          }
          ++num1;
          if (num1 > 511)
          {
            num1 = 0;
            ++num2;
          }
        }
      }
      catch (Exception ex)
      {
        dataGridView = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dataGridView;
    }

    private void JewelOfHarmonySmeltEnc(string filePath)
    {
      this.newFile = this.T_fStruct;
      this.EncBlock(ref this.newFile, this.newFile.Length);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void JOHSbw_DoWork(object sender, DoWorkEventArgs e) => this.JewelOfHarmonySmeltDec(((Form1.SendArgs) e.Argument).filePath);

    private void JOHSbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_BmdItemAdder.Enabled = true;
      this.isLeaveOpenItemAdder = true;
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.progressBar_Loading.Visible = false;
      this.tc_Items.SelectedIndex = -1;
      this.tc_Items.SelectedIndex = 0;
    }

    private void JOHSdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      byte num = Convert.ToByte(dataGridView[0, e.RowIndex].Value);
      int rowIndex = e.RowIndex;
      if (e.ColumnIndex == 0)
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) num;
      else if (e.ColumnIndex == 1)
      {
        dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) rowIndex;
      }
      else
      {
        if (dataGridView.EditingControl != null)
        {
          if (dataGridView.EditingControl.Text == "")
            dataGridView.EditingControl.Text = "0";
        }
        else if (this.PasteValue == "")
          this.PasteValue = "0";
        byte[] numArray = new byte[60];
        string empty = string.Empty;
        string str = !this.isPasteFromCP ? (dataGridView.EditingControl == null ? dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString() : dataGridView.EditingControl.Text) : this.PasteValue;
        switch (e.ColumnIndex)
        {
          case 2:
            Array.Copy((Array) BitConverter.GetBytes(Convert.ToInt32(str)), 0, (Array) this.T_fStruct, ((int) num * 512 + rowIndex) * this.sBlockSize, 4);
            break;
          case 3:
            string s = str + "\0";
            for (int index = 4; index < 64; ++index)
              this.T_fStruct[((int) num * 512 + rowIndex) * this.sBlockSize + index] = byte.MaxValue;
            byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(s);
            if (bytes.Length > 60)
              Array.Resize<byte>(ref bytes, 60);
            Array.Copy((Array) bytes, 0, (Array) this.T_fStruct, ((int) num * 512 + rowIndex) * this.sBlockSize + 4, bytes.Length);
            break;
          case 4:
            Array.Copy((Array) BitConverter.GetBytes(Convert.ToInt32(str)), 0, (Array) this.T_fStruct, ((int) num * 512 + rowIndex) * this.sBlockSize + 64, 4);
            break;
        }
        dataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
      }
    }

    private void JOHSdgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] != null)
        Application.OpenForms["Form_Search"].Close();
      if (this.isLeaveOpenItemAdder)
        return;
      if (Application.OpenForms["Form_BmdItemAddercs"] != null)
        Application.OpenForms["Form_BmdItemAddercs"].Close();
      this.toolStripButton_BmdItemAdder.Enabled = false;
    }

    private void loadToolStripMenuItem_FilterBMD_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Filter.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Filter";
      this.Filterdgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Filterbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.Filterbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Filter.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_FilterNameBMD_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the FilterName.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "FilterName";
      this.FilterNamedgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.FilterNamebw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.FilterNamebw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "FilterName.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_Gate_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Gate.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Gate";
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Gatebw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.Gatebw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Gate.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_Glow_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Glow.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Glow";
      this.Glowdgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Glowbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.Glowbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Glow.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_IAO_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the ItemAddOption.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "ItemAddOption";
      this.CreateItemTabCategories("IAO");
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.DoWork += new DoWorkEventHandler(this.IAObw_DoWork);
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.IAObw_RunWorkerCompleted);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "ItemAddOption.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_ISO_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the ItemSetOption.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "ItemSetOption";
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.ItemSetOptionbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.ItemSetOptionbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "ItemSetOption.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_IST_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the ItemSetType.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "ItemSetType";
      this.CreateItemTabCategories("IST");
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.DoWork += new DoWorkEventHandler(this.ISTbw_DoWork);
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.ISTbw_RunWorkerCompleted);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "ItemSetType.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_Item_S6E3_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Season 6 Episode 3 Item.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = openFileDialog2.FileName.Split('\\');
      if (strArray[strArray.Length - 1].ToLower().EndsWith(".bmd"))
      {
        if (!this.toolStrip_RowOptions.Enabled)
          this.toolStrip_RowOptions.Enabled = true;
        this.sBlockSize = 84;
        this.isLeaveOpenItemAdder = false;
        this.panel1_DisposeUnusedControls();
        this.s_LoadedFile = "Item_S6E3";
        this.CreateItemTabCategories("ItemS6E3");
        this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
        this.progressBar_Loading.Visible = true;
        Form1.SendArgs sendArgs = new Form1.SendArgs()
        {
          filePath = openFileDialog2.FileName
        };
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Item_S6E3bw_RunWorkerCompleted);
        backgroundWorker.DoWork += new DoWorkEventHandler(this.Item_S6E3bw_DoWork);
        backgroundWorker.RunWorkerAsync((object) sendArgs);
      }
      else if (strArray[strArray.Length - 1].ToLower().EndsWith(".ini"))
        return;
      this.toolStripLabel_FileName1.Text = "Season 6 Episode 3 Item.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_ItemEx700_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the ItemEx700.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = openFileDialog2.FileName.Split('\\');
      if (strArray[strArray.Length - 1].ToLower().EndsWith(".bmd"))
      {
        if (!this.toolStrip_RowOptions.Enabled)
          this.toolStrip_RowOptions.Enabled = true;
        this.sBlockSize = 612;
        this.isLeaveOpenItemAdder = false;
        this.panel1_DisposeUnusedControls();
        this.s_LoadedFile = "Item_Ex700";
        this.CreateItemTabCategories("ItemEx700");
        this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
        this.progressBar_Loading.Visible = true;
        Form1.SendArgs sendArgs = new Form1.SendArgs()
        {
          filePath = openFileDialog2.FileName
        };
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.ItemEx700bw_RunWorkerCompleted);
        backgroundWorker.DoWork += new DoWorkEventHandler(this.ItemEx700bw_DoWork);
        backgroundWorker.RunWorkerAsync((object) sendArgs);
      }
      else if (strArray[strArray.Length - 1].ToLower().EndsWith(".ini"))
        return;
      this.toolStripLabel_FileName1.Text = "Ex700 Item.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_ItemEx700Plus_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Ex700Plus Item.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = openFileDialog2.FileName.Split('\\');
      if (strArray[strArray.Length - 1].ToLower().EndsWith(".bmd"))
      {
        if (!this.toolStrip_RowOptions.Enabled)
          this.toolStrip_RowOptions.Enabled = true;
        this.sBlockSize = 620;
        this.isLeaveOpenItemAdder = false;
        this.panel1_DisposeUnusedControls();
        this.s_LoadedFile = "Item_Ex700Plus";
        this.CreateItemTabCategories("ItemEx700Plus");
        this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
        this.progressBar_Loading.Visible = true;
        Form1.SendArgs sendArgs = new Form1.SendArgs()
        {
          filePath = openFileDialog2.FileName
        };
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.ItemEx700Plusbw_RunWorkerCompleted);
        backgroundWorker.DoWork += new DoWorkEventHandler(this.ItemEx700Plusbw_DoWork);
        backgroundWorker.RunWorkerAsync((object) sendArgs);
      }
      else if (strArray[strArray.Length - 1].ToLower().EndsWith(".ini"))
        return;
      this.toolStripLabel_FileName1.Text = "Ex700Plus Item.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_ItemSeason8Episode1_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Season 8 Episode 1 Item.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = openFileDialog2.FileName.Split('\\');
      if (strArray[strArray.Length - 1].ToLower().EndsWith(".bmd"))
      {
        if (!this.toolStrip_RowOptions.Enabled)
          this.toolStrip_RowOptions.Enabled = true;
        this.sBlockSize = 628;
        this.isLeaveOpenItemAdder = false;
        this.panel1_DisposeUnusedControls();
        this.s_LoadedFile = "Item_Season8Episode1";
        this.CreateItemTabCategories("ItemSeason8Episode1");
        this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
        this.progressBar_Loading.Visible = true;
        Form1.SendArgs sendArgs = new Form1.SendArgs()
        {
          filePath = openFileDialog2.FileName
        };
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.ItemSeason8Episode1bw_RunWorkerCompleted);
        backgroundWorker.DoWork += new DoWorkEventHandler(this.ItemSeason8Episode1bw_DoWork);
        backgroundWorker.RunWorkerAsync((object) sendArgs);
      }
      else if (strArray[strArray.Length - 1].ToLower().EndsWith(".ini"))
        return;
      this.toolStripLabel_FileName1.Text = "Season 8 Episode 1 Item.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_ITT_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the ItemToolTip.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "ItemToolTip";
      this.CreateItemTabCategories("ITT");
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.sSize = 8192;
      this.sBlockSize = 124;
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.DoWork += new DoWorkEventHandler(this.ITTbw_DoWork);
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.ITTbw_RunWorkerCompleted);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "ItemToolTip.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_JOHS_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the JewelOfHarmonySmelt.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "JewelOfHarmonySmelt";
      this.CreateItemTabCategories("JOHS");
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.DoWork += new DoWorkEventHandler(this.JOHSbw_DoWork);
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.JOHSbw_RunWorkerCompleted);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "JewelOfHarmonySmelt.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_Minimap_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Minimap_WorldX.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Minimap";
      this.Minimapdgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Minimapbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.Minimapbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Minimap_WorldX.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_MixBMD_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Mix.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Mix";
      this.Mixdgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.toolStripButton_BmdItemAdder.Enabled = false;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Mixbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.Mixbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Mix.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_Monster_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Monster.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Monster";
      this.Monsterdgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Monsterbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.Monsterbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Monster.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_MR_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the MoveReq File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|DAT files (*.dat)|*.dat|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      string[] strArray = openFileDialog2.FileName.Split('\\');
      if (strArray[strArray.Length - 1].ToLower().EndsWith(".bmd"))
      {
        if (!this.toolStrip_RowOptions.Enabled)
          this.toolStrip_RowOptions.Enabled = true;
        this.sBlockSize = 84;
        this.isLeaveOpenItemAdder = false;
        this.panel1_DisposeUnusedControls();
        this.s_LoadedFile = "MoveReq";
        this.MRdgv = new DataGridView();
        this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
        this.progressBar_Loading.Visible = true;
        Form1.SendArgs sendArgs = new Form1.SendArgs()
        {
          filePath = openFileDialog2.FileName
        };
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.MRbw_RunWorkerCompleted);
        backgroundWorker.DoWork += new DoWorkEventHandler(this.MRbw_DoWork);
        backgroundWorker.RunWorkerAsync((object) sendArgs);
        this.toolStripLabel_FileName1.Text = "MoveReq.bmd File";
        this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
      }
      else
      {
        if (!strArray[strArray.Length - 1].ToLower().EndsWith(".dat"))
          return;
        if (!this.toolStrip_RowOptions.Enabled)
          this.toolStrip_RowOptions.Enabled = true;
        this.sBlockSize = 84;
        this.isLeaveOpenItemAdder = false;
        this.panel1_DisposeUnusedControls();
        this.MRdgv = new DataGridView();
        this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
        this.progressBar_Loading.Visible = true;
        this.initializeMRGrid(this.MRdgv);
        this.MRdgv.CellValueChanged += new DataGridViewCellEventHandler(this.MRdgv_CellValueChanged);
        this.ReadINIFile(openFileDialog2.FileName, this.MRdgv, 84);
        this.panel1.Controls.Add((Control) this.MRdgv);
        this.progressBar_Loading.Visible = false;
        this.MRdgv.Disposed += new EventHandler(this.MRdgv_Disposed);
        this.MRdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
        this.workingDGV = this.MRdgv;
        this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
        this.toolStripLabel_FileName1.Text = "MoveReq.dat File";
        this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
      }
    }

    private void loadToolStripMenuItem_NpcName700_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the NpcName.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.sBlockSize = 264;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "NpcName";
      this.NPCNdgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.NPCNbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.NPCNbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Ex700 NpcName.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_NpcNameEx700Plus_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the NpcName.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.sBlockSize = 260;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "NpcName_Ex700Plus";
      this.NPCNPlusdgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.NPCNPlusbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.NPCNPlusbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Ex700Plus NpcName.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_SererListEx700_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the ServerList.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.sBlockSize = 60;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "ServerList_Ex700";
      this.ServerListEx700dgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.ServerListEx700bw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.ServerListEx700bw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Ex700 / Plus ServerList.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_SererListS6E3_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the ServerList.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.sBlockSize = 55;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "ServerList_S6E3";
      this.ServerListS6E3dgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.ServerListS6E3bw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.ServerListS6E3bw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "S6E3 ServerList.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_Skill_ExS8E1BMD_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Skill.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Skill_ExS8E1";
      this.Skill_ExS8E1dgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Skill_ExS8E1bw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.Skill_ExS8E1bw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Ex700/2 / Season 8 Episode 1 Skill.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_Skill_S6E3BMD_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Skill.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Skill_S6E3";
      this.Skill_S6E3dgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Skill_S6E3bw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.Skill_S6E3bw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Season 6 Episode 3 Skill.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_SlideBMD_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Slide.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Slide";
      this.Slidedgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Slidebw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.Slidebw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Slide.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void loadToolStripMenuItem_TextBMD_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Title = "Select the Text.bmd File";
      openFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      OpenFileDialog openFileDialog2 = openFileDialog1;
      if (openFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      if (!this.toolStrip_RowOptions.Enabled)
        this.toolStrip_RowOptions.Enabled = true;
      this.isLeaveOpenItemAdder = false;
      this.panel1_DisposeUnusedControls();
      this.s_LoadedFile = "Text";
      this.TEXTdgv = new DataGridView();
      this.toolStripButton_Save.Enabled = true;
      this.progressBar_Loading.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width / 2 - this.progressBar_Loading.Size.Width / 2, this.panel1.Location.Y + this.panel1.Size.Height / 2 - this.progressBar_Loading.Size.Height / 2);
      this.progressBar_Loading.Visible = true;
      Form1.SendArgs sendArgs = new Form1.SendArgs()
      {
        filePath = openFileDialog2.FileName
      };
      BackgroundWorker backgroundWorker = new BackgroundWorker();
      backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.TEXTbw_RunWorkerCompleted);
      backgroundWorker.DoWork += new DoWorkEventHandler(this.TEXTbw_DoWork);
      backgroundWorker.RunWorkerAsync((object) sendArgs);
      openFileDialog2.FileName.Split('\\');
      this.toolStripLabel_FileName1.Text = "Text.bmd File";
      this.toolStripLabel_FileName2.Text = "[" + openFileDialog2.FileName + "]";
    }

    private void Minimap_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Minimap_WorldX.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Minimap";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Minimapbw_DoWork(object sender, DoWorkEventArgs e) => this.Minimapdgv = this.MinimapDec(((Form1.SendArgs) e.Argument).filePath);

    private void Minimapbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.panel1.Controls.Add((Control) this.Minimapdgv);
      this.progressBar_Loading.Visible = false;
      this.Minimapdgv.CellValueChanged += new DataGridViewCellEventHandler(this.Minimapdgv_CellValueChanged);
      this.Minimapdgv.Disposed += new EventHandler(this.Minimapdgv_Disposed);
      this.Minimapdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.Minimapdgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView MinimapDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      this.initializeMinimapGrid(dgv);
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        this.sBlockSize = 116;
        byte[] numArray = new byte[fileStream.Length];
        this.sSize = ((int) fileStream.Length - 4) / this.sBlockSize;
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        this.endBytes = new byte[49];
        Array.Copy((Array) numArray, numArray.Length - 49, (Array) this.endBytes, 0, 49);
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray, rowIndex * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, Buffer.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, 0);
          dgv[1, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, 4);
          dgv[2, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, 8);
          dgv[3, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, 12);
          char[] chArray = new char[2]{ ' ', char.MinValue };
          dgv[4, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(Buffer, 16, 100).Trim(chArray);
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void Minimapdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => this.Minimapdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void Minimapdgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void MinimapEnc(string filePath)
    {
      List<byte> byteList1 = new List<byte>();
      List<byte> byteList2 = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        if (row.Cells[0].Value != null)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[0].Value.ToString())), 0, (Array) Buffer, 0, 4);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[1].Value.ToString())), 0, (Array) Buffer, 4, 4);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[2].Value.ToString())), 0, (Array) Buffer, 8, 4);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[3].Value.ToString())), 0, (Array) Buffer, 12, 4);
          byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[4].Value.ToString());
          Array.Copy((Array) bytes, 0, (Array) Buffer, 16, bytes.Length);
          for (int index = 0; index < Buffer.Length; ++index)
            byteList2.Add(Buffer[index]);
          this.EncBlock(ref Buffer, this.sBlockSize);
          for (int index = 0; index < Buffer.Length; ++index)
            byteList1.Add(Buffer[index]);
          this.backgroundWorker.ReportProgress(row.Index);
        }
      }
      for (int index = 0; index < this.endBytes.Length; ++index)
        byteList1.Add(this.endBytes[index]);
      byte[] sourceArray = this.CalcCRC(byteList1.ToArray(), 11201U, 0U);
      this.newFile = byteList1.ToArray();
      Array.Copy((Array) sourceArray, 0, (Array) this.newFile, this.newFile.Length - 4, 4);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void Mix_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Mix.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count - 1;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Mix";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Mixbw_DoWork(object sender, DoWorkEventArgs e) => this.Mixdgv = this.MixDec(((Form1.SendArgs) e.Argument).filePath);

    private void Mixbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.Mixdgv);
      this.progressBar_Loading.Visible = false;
      this.Mixdgv.CellValueChanged += new DataGridViewCellEventHandler(this.Mixdgv_CellValueChanged);
      this.Mixdgv.Disposed += new EventHandler(this.Mixdgv_Disposed);
      this.Mixdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.Mixdgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView MixDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeMixGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray = new byte[fileStream.Length];
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        this.startBytes = new byte[56];
        Array.Copy((Array) numArray, 0, (Array) this.startBytes, 0, this.startBytes.Length);
        this.DecBlock(ref this.startBytes, this.startBytes.Length);
        int int32_1 = BitConverter.ToInt32(this.startBytes, 0);
        int int32_2 = BitConverter.ToInt32(this.startBytes, 4);
        int int32_3 = BitConverter.ToInt32(this.startBytes, 8);
        int int32_4 = BitConverter.ToInt32(this.startBytes, 12);
        int int32_5 = BitConverter.ToInt32(this.startBytes, 16);
        int int32_6 = BitConverter.ToInt32(this.startBytes, 20);
        int int32_7 = BitConverter.ToInt32(this.startBytes, 24);
        int int32_8 = BitConverter.ToInt32(this.startBytes, 28);
        int int32_9 = BitConverter.ToInt32(this.startBytes, 32);
        int int32_10 = BitConverter.ToInt32(this.startBytes, 36);
        int int32_11 = BitConverter.ToInt32(this.startBytes, 40);
        int int32_12 = BitConverter.ToInt32(this.startBytes, 44);
        int int32_13 = BitConverter.ToInt32(this.startBytes, 48);
        int int32_14 = BitConverter.ToInt32(this.startBytes, 52);
        this.sBlockSize = 660;
        this.sSize = (numArray.Length - 56) / this.sBlockSize;
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray, 56 + rowIndex * this.sBlockSize, (Array) Buffer, 0, Buffer.Length);
          this.DecBlock(ref Buffer, Buffer.Length);
          dgv.Rows.Add();
          if (rowIndex < int32_1)
            dgv[0, rowIndex].Value = (object) "1";
          else if (rowIndex - int32_1 < int32_2)
            dgv[0, rowIndex].Value = (object) "2";
          else if (rowIndex - int32_1 - int32_2 < int32_3)
            dgv[0, rowIndex].Value = (object) "3";
          else if (rowIndex - int32_1 - int32_2 - int32_3 < int32_4)
            dgv[0, rowIndex].Value = (object) "4";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 < int32_5)
            dgv[0, rowIndex].Value = (object) "5";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 - int32_5 < int32_6)
            dgv[0, rowIndex].Value = (object) "6";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 - int32_5 - int32_6 < int32_7)
            dgv[0, rowIndex].Value = (object) "7";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 - int32_5 - int32_6 - int32_7 < int32_8)
            dgv[0, rowIndex].Value = (object) "8";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 - int32_5 - int32_6 - int32_7 - int32_8 < int32_9)
            dgv[0, rowIndex].Value = (object) "9";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 - int32_5 - int32_6 - int32_7 - int32_8 - int32_9 < int32_10)
            dgv[0, rowIndex].Value = (object) "10";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 - int32_5 - int32_6 - int32_7 - int32_8 - int32_9 - int32_10 < int32_11)
            dgv[0, rowIndex].Value = (object) "11";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 - int32_5 - int32_6 - int32_7 - int32_8 - int32_9 - int32_10 - int32_11 < int32_12)
            dgv[0, rowIndex].Value = (object) "12";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 - int32_5 - int32_6 - int32_7 - int32_8 - int32_9 - int32_10 - int32_11 - int32_12 < int32_13)
            dgv[0, rowIndex].Value = (object) "13";
          else if (rowIndex - int32_1 - int32_2 - int32_3 - int32_4 - int32_5 - int32_6 - int32_7 - int32_8 - int32_9 - int32_10 - int32_11 - int32_12 - int32_13 < int32_14)
            dgv[0, rowIndex].Value = (object) "14";
          int startIndex1 = 0;
          for (int columnIndex = 1; columnIndex < 15; ++columnIndex)
          {
            dgv[columnIndex, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, startIndex1);
            startIndex1 += 4;
          }
          dgv[15, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, startIndex1);
          int startIndex2 = startIndex1 + 4;
          for (int columnIndex = 16; columnIndex < 18; ++columnIndex)
          {
            dgv[columnIndex, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, startIndex2);
            startIndex2 += 4;
          }
          int columnIndex1 = 18;
          for (int index = 0; index < 32; ++index)
          {
            dgv[columnIndex1, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, startIndex2);
            int startIndex3 = startIndex2 + 4;
            int columnIndex2 = columnIndex1 + 1;
            dgv[columnIndex2, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, startIndex3);
            startIndex2 = startIndex3 + 4;
            columnIndex1 = columnIndex2 + 1;
          }
          dgv[82, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, startIndex2);
          int startIndex4 = startIndex2 + 4;
          for (int columnIndex3 = 83; columnIndex3 < 91; ++columnIndex3)
          {
            dgv[columnIndex3, rowIndex].Value = (object) Buffer[startIndex4];
            ++startIndex4;
          }
          int columnIndex4 = 91;
          for (int index1 = 0; index1 < 8; ++index1)
          {
            for (int index2 = 0; index2 < 2; ++index2)
            {
              dgv[columnIndex4, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, startIndex4);
              startIndex4 += 2;
              ++columnIndex4;
            }
            for (int index3 = 0; index3 < 9; ++index3)
            {
              dgv[columnIndex4, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, startIndex4);
              startIndex4 += 4;
              ++columnIndex4;
            }
          }
          dgv[columnIndex4, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, startIndex4);
          int num = startIndex4 + 4;
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void Mixdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (this.isNewRow && e.ColumnIndex == 0)
        this.Mixdgv[e.ColumnIndex, e.RowIndex].Value = (object) "1";
      this.Mixdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
    }

    private void Mixdgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void MixEnc(string filePath)
    {
      List<byte> byteList1 = new List<byte>();
      List<byte> collection1 = new List<byte>();
      List<byte> collection2 = new List<byte>();
      List<byte> collection3 = new List<byte>();
      List<byte> collection4 = new List<byte>();
      List<byte> collection5 = new List<byte>();
      List<byte> collection6 = new List<byte>();
      List<byte> collection7 = new List<byte>();
      List<byte> collection8 = new List<byte>();
      List<byte> collection9 = new List<byte>();
      List<byte> collection10 = new List<byte>();
      List<byte> collection11 = new List<byte>();
      List<byte> collection12 = new List<byte>();
      List<byte> collection13 = new List<byte>();
      List<byte> collection14 = new List<byte>();
      byte[] numArray = new byte[0];
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        List<byte> collection15 = new List<byte>();
        for (int index = 1; index < 83; ++index)
        {
          foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(row.Cells[index].Value)))
            collection15.Add(num);
        }
        for (int index = 83; index < 91; ++index)
        {
          byte[] bytes = BitConverter.GetBytes((short) Convert.ToByte(row.Cells[index].Value));
          collection15.Add(bytes[0]);
        }
        int index1 = 91;
        for (int index2 = 0; index2 < 8; ++index2)
        {
          for (int index3 = 0; index3 < 2; ++index3)
          {
            foreach (byte num in BitConverter.GetBytes(Convert.ToUInt16(row.Cells[index1].Value)))
              collection15.Add(num);
            ++index1;
          }
          for (int index4 = 0; index4 < 9; ++index4)
          {
            foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(row.Cells[index1].Value)))
              collection15.Add(num);
            ++index1;
          }
        }
        foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(row.Cells[index1].Value)))
          collection15.Add(num);
        if (row.Cells[0].Value.ToString() == "1")
          collection1.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "2")
          collection2.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "3")
          collection3.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "4")
          collection4.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "5")
          collection5.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "6")
          collection6.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "7")
          collection7.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "8")
          collection8.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "9")
          collection9.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "10")
          collection10.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "11")
          collection11.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "12")
          collection12.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "13")
          collection13.AddRange((IEnumerable<byte>) collection15);
        else if (row.Cells[0].Value.ToString() == "14")
          collection14.AddRange((IEnumerable<byte>) collection15);
        this.backgroundWorker.ReportProgress(this.workingDGV.Rows.IndexOf(row));
      }
      byte[] Buffer = new byte[56];
      Array.Copy((Array) BitConverter.GetBytes(collection1.Count / 660), 0, (Array) Buffer, 0, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection2.Count / 660), 0, (Array) Buffer, 4, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection3.Count / 660), 0, (Array) Buffer, 8, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection4.Count / 660), 0, (Array) Buffer, 12, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection5.Count / 660), 0, (Array) Buffer, 16, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection6.Count / 660), 0, (Array) Buffer, 20, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection7.Count / 660), 0, (Array) Buffer, 24, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection8.Count / 660), 0, (Array) Buffer, 28, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection9.Count / 660), 0, (Array) Buffer, 32, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection10.Count / 660), 0, (Array) Buffer, 36, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection11.Count / 660), 0, (Array) Buffer, 40, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection12.Count / 660), 0, (Array) Buffer, 44, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection13.Count / 660), 0, (Array) Buffer, 48, 4);
      Array.Copy((Array) BitConverter.GetBytes(collection14.Count / 660), 0, (Array) Buffer, 52, 4);
      this.EncBlock(ref Buffer, Buffer.Length);
      List<byte> byteList2 = new List<byte>();
      byteList2.AddRange((IEnumerable<byte>) collection1);
      byteList2.AddRange((IEnumerable<byte>) collection2);
      byteList2.AddRange((IEnumerable<byte>) collection3);
      byteList2.AddRange((IEnumerable<byte>) collection4);
      byteList2.AddRange((IEnumerable<byte>) collection5);
      byteList2.AddRange((IEnumerable<byte>) collection6);
      byteList2.AddRange((IEnumerable<byte>) collection7);
      byteList2.AddRange((IEnumerable<byte>) collection8);
      byteList2.AddRange((IEnumerable<byte>) collection9);
      byteList2.AddRange((IEnumerable<byte>) collection10);
      byteList2.AddRange((IEnumerable<byte>) collection11);
      byteList2.AddRange((IEnumerable<byte>) collection12);
      byteList2.AddRange((IEnumerable<byte>) collection13);
      byteList2.AddRange((IEnumerable<byte>) collection14);
      byte[] array = byteList2.ToArray();
      this.EncBlock(ref array, array.Length);
      this.newFile = new byte[Buffer.Length + array.Length];
      Array.Copy((Array) Buffer, 0, (Array) this.newFile, 0, Buffer.Length);
      Array.Copy((Array) array, 0, (Array) this.newFile, 56, array.Length);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void Monster_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Monster.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Monster";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Monsterbw_DoWork(object sender, DoWorkEventArgs e) => this.Monsterdgv = this.MonsterDec(((Form1.SendArgs) e.Argument).filePath);

    private void Monsterbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.Monsterdgv);
      this.progressBar_Loading.Visible = false;
      this.Monsterdgv.CellValueChanged += new DataGridViewCellEventHandler(this.Monsterdgv_CellValueChanged);
      this.Monsterdgv.Disposed += new EventHandler(this.Monsterdgv_Disposed);
      this.Monsterdgv.CellMouseClick += new DataGridViewCellMouseEventHandler(this.Monsterdgv_CellMouseClick);
      this.Monsterdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.Monsterdgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
      this.isIGCCustomBMD = true;
    }

    private DataGridView MonsterDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeMonsterGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] Buffer = new byte[fileStream.Length];
        fileStream.Read(Buffer, 0, Buffer.Length);
        fileStream.Close();
        this.DecIGCBlock(ref Buffer);
        this.Model_sSize = BitConverter.ToInt32(Buffer, 8);
        this.Monster_sSize = BitConverter.ToInt32(Buffer, 12);
        byte[] numArray1 = new byte[this.Model_sBlockSize * this.Model_sSize];
        byte[] numArray2 = new byte[this.Monster_sBlockSize * this.Monster_sSize];
        Array.Copy((Array) Buffer, 16, (Array) numArray1, 0, numArray1.Length);
        Array.Copy((Array) Buffer, 16 + numArray1.Length, (Array) numArray2, 0, numArray2.Length);
        byte[] numArray3 = new byte[this.Model_sBlockSize];
        for (int rowIndex = 0; rowIndex < this.Model_sSize; ++rowIndex)
        {
          Array.Copy((Array) numArray1, rowIndex * this.Model_sBlockSize, (Array) numArray3, 0, this.Model_sBlockSize);
          dgv.Rows.Add();
          dgv["Model ID (1)", rowIndex].Value = (object) BitConverter.ToUInt32(numArray3, 0);
          dgv["Model Path", rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray3, 4, 64).Replace("\0", "");
          dgv["Model Name", rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray3, 68, 32).Replace("\0", "");
        }
        byte[] numArray4 = new byte[this.Monster_sBlockSize];
        for (int rowIndex = 0; rowIndex < this.Monster_sSize; ++rowIndex)
        {
          Array.Copy((Array) numArray2, rowIndex * this.Monster_sBlockSize, (Array) numArray4, 0, this.Monster_sBlockSize);
          dgv["Monster ID", rowIndex].Value = (object) BitConverter.ToUInt32(numArray4, 0);
          dgv["Monster Name", rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray4, 4, 32).Replace("\0", "");
          dgv["Model ID (2)", rowIndex].Value = (object) BitConverter.ToUInt16(numArray4, 36);
          dgv["NPC?", rowIndex].Value = (object) Convert.ToByte(numArray4[38]);
          dgv["Scale", rowIndex].Value = (object) BitConverter.ToSingle(numArray4, 39);
          dgv["Glow Power", rowIndex].Value = (object) BitConverter.ToSingle(numArray4, 43);
          float single1 = BitConverter.ToSingle(numArray4, 47);
          float single2 = BitConverter.ToSingle(numArray4, 51);
          float single3 = BitConverter.ToSingle(numArray4, 55);
          dgv["R Color", rowIndex].Value = (object) Convert.ToByte(single1 * (float) byte.MaxValue);
          dgv["G Color", rowIndex].Value = (object) Convert.ToByte(single2 * (float) byte.MaxValue);
          dgv["B Color", rowIndex].Value = (object) Convert.ToByte(single3 * (float) byte.MaxValue);
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void Monsterdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.ColumnIndex != 11 && e.ColumnIndex != 10 && e.ColumnIndex != 9)
        return;
      ColorDialog colorDialog = new ColorDialog()
      {
        Color = Color.FromArgb(Convert.ToInt32(this.Monsterdgv[9, e.RowIndex].Value), Convert.ToInt32(this.Monsterdgv[10, e.RowIndex].Value), Convert.ToInt32(this.Monsterdgv[11, e.RowIndex].Value))
      };
      if (colorDialog.ShowDialog() != DialogResult.OK)
        return;
      this.Monsterdgv[9, e.RowIndex].Value = (object) colorDialog.Color.R;
      this.Monsterdgv[10, e.RowIndex].Value = (object) colorDialog.Color.G;
      this.Monsterdgv[11, e.RowIndex].Value = (object) colorDialog.Color.B;
    }

    private void Monsterdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => this.Monsterdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void Monsterdgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      this.isIGCCustomBMD = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void MonsterEnc(string filePath)
    {
      List<byte> byteList1 = new List<byte>();
      for (int index = 0; index < 4; ++index)
        byteList1.Add(byte.MaxValue);
      byteList1.Add((byte) 1);
      for (int index = 0; index < 3; ++index)
        byteList1.Add((byte) 0);
      byte[] bytes1 = BitConverter.GetBytes(this.Monsterdgv.RowCount);
      for (int index = 0; index < 2; ++index)
      {
        foreach (byte num in bytes1)
          byteList1.Add(num);
      }
      int percentProgress = 0;
      List<byte> byteList2 = new List<byte>();
      List<byte> byteList3 = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        ++percentProgress;
        if (row.Cells[0].Value != null)
        {
          byte[] numArray1 = new byte[4];
          byte[] numArray2 = new byte[64];
          byte[] numArray3 = new byte[32];
          byte[] numArray4 = new byte[2];
          byte[] numArray5 = new byte[0];
          byte[] destinationArray1 = new byte[this.Model_sBlockSize];
          byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt32(row.Cells[0].Value.ToString()));
          Array.Copy((Array) bytes2, 0, (Array) destinationArray1, 0, bytes2.Length);
          byte[] bytes3 = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[1].Value.ToString());
          Array.Copy((Array) bytes3, 0, (Array) numArray2, 0, bytes3.Length);
          Array.Copy((Array) numArray2, 0, (Array) destinationArray1, 4, numArray2.Length);
          byte[] bytes4 = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[2].Value.ToString());
          Array.Copy((Array) bytes4, 0, (Array) numArray3, 0, bytes4.Length);
          Array.Copy((Array) numArray3, 0, (Array) destinationArray1, 68, numArray3.Length);
          for (int index = 0; index < destinationArray1.Length; ++index)
            byteList2.Add(destinationArray1[index]);
          byte[] destinationArray2 = new byte[this.Monster_sBlockSize];
          byte[] bytes5 = BitConverter.GetBytes(Convert.ToUInt32(row.Cells[3].Value.ToString()));
          Array.Copy((Array) bytes5, 0, (Array) destinationArray2, 0, bytes5.Length);
          byte[] bytes6 = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[4].Value.ToString());
          Array.Copy((Array) bytes6, 0, (Array) numArray3, 0, bytes6.Length);
          Array.Copy((Array) numArray3, 0, (Array) destinationArray2, 4, numArray3.Length);
          byte[] bytes7 = BitConverter.GetBytes(Convert.ToUInt16(row.Cells[5].Value.ToString()));
          Array.Copy((Array) bytes7, 0, (Array) destinationArray2, 36, bytes7.Length);
          destinationArray2[38] = Convert.ToByte(row.Cells[6].Value.ToString());
          byte[] bytes8 = BitConverter.GetBytes(Convert.ToSingle(row.Cells[7].Value.ToString()));
          Array.Copy((Array) bytes8, 0, (Array) destinationArray2, 39, bytes8.Length);
          byte[] bytes9 = BitConverter.GetBytes(Convert.ToSingle(row.Cells[8].Value.ToString()));
          Array.Copy((Array) bytes9, 0, (Array) destinationArray2, 43, bytes9.Length);
          byte[] bytes10 = BitConverter.GetBytes((float) Convert.ToInt16(row.Cells[9].Value.ToString()) / (float) byte.MaxValue);
          Array.Copy((Array) bytes10, 0, (Array) destinationArray2, 47, bytes10.Length);
          byte[] bytes11 = BitConverter.GetBytes((float) Convert.ToInt16(row.Cells[10].Value.ToString()) / (float) byte.MaxValue);
          Array.Copy((Array) bytes11, 0, (Array) destinationArray2, 51, bytes11.Length);
          byte[] bytes12 = BitConverter.GetBytes((float) Convert.ToInt16(row.Cells[11].Value.ToString()) / (float) byte.MaxValue);
          Array.Copy((Array) bytes12, 0, (Array) destinationArray2, 55, bytes12.Length);
          for (int index = 0; index < destinationArray2.Length; ++index)
            byteList3.Add(destinationArray2[index]);
          this.backgroundWorker.ReportProgress(percentProgress);
        }
      }
      byte[] bArray = new byte[byteList1.Count + byteList2.Count + byteList3.Count];
      byteList1.CopyTo(0, bArray, 0, byteList1.Count);
      byteList2.CopyTo(0, bArray, byteList1.Count, byteList2.Count);
      byteList3.CopyTo(0, bArray, byteList1.Count + byteList2.Count, byteList3.Count);
      this.EncIGCBlock(ref bArray);
      System.IO.File.WriteAllBytes(filePath, bArray);
    }

    private void monsterSetBaseToolStripMenuItem_Click(object sender, EventArgs e) => new MSBEditor().Show();

    private void MoveReq_DAT_Export()
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Title = "Select a location and file Name for the generated MoveReq.dat";
      saveFileDialog1.FileName = "MoveReq.dat";
      saveFileDialog1.Filter = "DAT files (*.dat)|*.dat|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName)
      {
        AutoFlush = true
      };
      streamWriter.WriteLine("//Generated by MU.ToolKit coded by TopReal.IT");
      streamWriter.WriteLine("//------------------------------------------------------------------------");
      streamWriter.WriteLine("//\tIndex\tMoveName(Server)\tMoveName(Client)\tMinLvl\tMaxLvl\tZen\tGateNumber");
      streamWriter.WriteLine("//------------------------------------------------------------------------");
      streamWriter.WriteLine();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "0")
          streamWriter.WriteLine("\t{0}\t\"{2}\"\t\t\"{1}\"\t\t{3}\t{4}\t{5}\t{6}", (object) row.Cells[0].Value.ToString(), (object) row.Cells[1].Value.ToString(), (object) row.Cells[2].Value.ToString(), (object) row.Cells[3].Value.ToString(), (object) row.Cells[4].Value.ToString(), (object) row.Cells[5].Value.ToString(), (object) row.Cells[6].Value.ToString());
      }
      streamWriter.Close();
      if (MessageBox.Show("File generated succesfully.\nOpen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      Process.Start(saveFileDialog2.FileName);
    }

    private void MoveReq_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the MoveReq.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize + 4];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "MoveReq";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private DataGridView MoveReqDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      this.initializeMRGrid(dgv);
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray1 = new byte[fileStream.Length];
        fileStream.Read(numArray1, 0, numArray1.Length);
        fileStream.Close();
        this.sSize = (numArray1.Length - 4) / this.sBlockSize;
        this.fStruct = new object[this.sSize, this.sBlockSize];
        byte[] Buffer = new byte[this.sBlockSize];
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          try
          {
            Array.Copy((Array) numArray1, rowIndex * this.sBlockSize + 4, (Array) Buffer, 0, this.sBlockSize);
          }
          catch
          {
            return dgv;
          }
          this.DecBlock(ref Buffer, this.sBlockSize);
          for (int index = 0; index < this.sBlockSize; ++index)
            this.fStruct[rowIndex, index] = (object) Buffer[index];
          byte[] destinationArray1 = new byte[4];
          byte[] numArray2 = new byte[32];
          byte[] numArray3 = new byte[32];
          byte[] destinationArray2 = new byte[4];
          byte[] destinationArray3 = new byte[4];
          byte[] destinationArray4 = new byte[4];
          byte[] destinationArray5 = new byte[4];
          Array.Copy((Array) Buffer, 0, (Array) destinationArray1, 0, destinationArray1.Length);
          Array.Copy((Array) Buffer, 4, (Array) numArray2, 0, numArray2.Length);
          Array.Copy((Array) Buffer, 36, (Array) numArray3, 0, numArray3.Length);
          Array.Copy((Array) Buffer, 68, (Array) destinationArray2, 0, destinationArray2.Length);
          Array.Copy((Array) Buffer, 72, (Array) destinationArray3, 0, destinationArray3.Length);
          Array.Copy((Array) Buffer, 76, (Array) destinationArray4, 0, destinationArray4.Length);
          Array.Copy((Array) Buffer, 80, (Array) destinationArray5, 0, destinationArray5.Length);
          dgv.Rows.Add();
          dgv["Index", rowIndex].Value = (object) BitConverter.ToUInt32(destinationArray1, 0);
          dgv["Client Name", rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace("\0", "");
          dgv["Server Name", rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray3).Replace("\0", "");
          dgv["Min Level", rowIndex].Value = (object) BitConverter.ToUInt32(destinationArray2, 0);
          dgv["Max Level", rowIndex].Value = (object) BitConverter.ToUInt32(destinationArray3, 0);
          dgv["Required Zen", rowIndex].Value = (object) BitConverter.ToUInt32(destinationArray4, 0);
          dgv["Gate Number", rowIndex].Value = (object) BitConverter.ToUInt32(destinationArray5, 0);
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void MoveReqEnc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        if (row.Cells[0].Value != null)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          byte[] numArray = new byte[0];
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[0].Value.ToString())), 0, (Array) Buffer, 0, 4);
          byte[] bytes1 = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[1].Value.ToString());
          Array.Copy((Array) bytes1, 0, (Array) Buffer, 4, bytes1.Length);
          byte[] bytes2 = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[2].Value.ToString());
          Array.Copy((Array) bytes2, 0, (Array) Buffer, 36, bytes2.Length);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[3].Value.ToString())), 0, (Array) Buffer, 68, 4);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[4].Value.ToString())), 0, (Array) Buffer, 72, 4);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[5].Value.ToString())), 0, (Array) Buffer, 76, 4);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[6].Value.ToString())), 0, (Array) Buffer, 80, 4);
          this.EncBlock(ref Buffer, this.sBlockSize);
          for (int index = 0; index < Buffer.Length; ++index)
            byteList.Add(Buffer[index]);
          this.backgroundWorker.ReportProgress(row.Index);
        }
      }
      byte[] array = byteList.ToArray();
      int num = 0;
      foreach (DataGridViewRow row in (IEnumerable) this.MRdgv.Rows)
      {
        if (row.Cells[0].Value.ToString() != "0" & row.Cells[0].Value.ToString() != "")
          ++num;
      }
      this.startBytes = BitConverter.GetBytes(Convert.ToUInt32(num));
      this.newFile = new byte[4 + array.Length];
      Array.Copy((Array) this.startBytes, 0, (Array) this.newFile, 0, 4);
      Array.Copy((Array) array, 0, (Array) this.newFile, 4, array.Length);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void MRbw_DoWork(object sender, DoWorkEventArgs e) => this.MRdgv = this.MoveReqDec(((Form1.SendArgs) e.Argument).filePath);

    private void MRbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.MRdgv);
      this.progressBar_Loading.Visible = false;
      this.MRdgv.CellValueChanged += new DataGridViewCellEventHandler(this.MRdgv_CellValueChanged);
      this.MRdgv.Disposed += new EventHandler(this.MRdgv_Disposed);
      this.MRdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.MRdgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private void MRdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => this.MRdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void MRdgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void NpcName_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the NpcName.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count - 1;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "NpcName";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private DataGridView NpcNameDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeNPCNGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] Buffer = new byte[fileStream.Length];
        fileStream.Read(Buffer, 0, Buffer.Length);
        fileStream.Close();
        this.DecBlock(ref Buffer, Buffer.Length);
        this.sSize = Buffer.Length / this.sBlockSize;
        byte[] numArray1 = new byte[this.sBlockSize];
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          try
          {
            Array.Copy((Array) Buffer, rowIndex * this.sBlockSize, (Array) numArray1, 0, this.sBlockSize);
          }
          catch
          {
            return dgv;
          }
          byte[] numArray2 = new byte[256];
          Array.Copy((Array) numArray1, 8, (Array) numArray2, 0, numArray2.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) BitConverter.ToUInt32(numArray1, 0);
          dgv[1, rowIndex].Value = (object) BitConverter.ToUInt32(numArray1, 4);
          dgv[2, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace("\0", "");
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void NpcNameEnc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        if (row.Cells[0].Value != null)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[0].Value.ToString())), 0, (Array) Buffer, 0, 4);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt32(row.Cells[1].Value.ToString())), 0, (Array) Buffer, 4, 4);
          byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[2].Value.ToString());
          Array.Copy((Array) bytes, 0, (Array) Buffer, 8, bytes.Length);
          this.EncBlock(ref Buffer, this.sBlockSize);
          for (int index = 0; index < Buffer.Length; ++index)
            byteList.Add(Buffer[index]);
          this.backgroundWorker.ReportProgress(row.Index);
        }
      }
      this.newFile = byteList.ToArray();
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void NpcNameEx700Plus_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the NpcName.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count - 1;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "NpcNameEx700Plus";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private DataGridView NpcNameEx700PlusDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeNPCNPlusGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray1 = new byte[fileStream.Length];
        fileStream.Read(numArray1, 0, numArray1.Length);
        fileStream.Close();
        this.sSize = numArray1.Length / this.sBlockSize;
        byte[] Buffer = new byte[this.sBlockSize];
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          try
          {
            Array.Copy((Array) numArray1, rowIndex * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
            this.DecBlock(ref Buffer, Buffer.Length);
          }
          catch
          {
            return dgv;
          }
          byte[] numArray2 = new byte[256];
          Array.Copy((Array) Buffer, 4, (Array) numArray2, 0, numArray2.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, 0);
          dgv[1, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, 2);
          dgv[2, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace("\0", "");
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void NpcNameEx700PlusEnc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        if (row.Cells[0].Value != null)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt16(row.Cells[0].Value.ToString())), 0, (Array) Buffer, 0, 2);
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt16(row.Cells[1].Value.ToString())), 0, (Array) Buffer, 2, 2);
          byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[2].Value.ToString());
          Array.Copy((Array) bytes, 0, (Array) Buffer, 4, bytes.Length);
          this.EncBlock(ref Buffer, this.sBlockSize);
          for (int index = 0; index < Buffer.Length; ++index)
            byteList.Add(Buffer[index]);
          this.backgroundWorker.ReportProgress(row.Index);
        }
      }
      this.newFile = byteList.ToArray();
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void NPCNbw_DoWork(object sender, DoWorkEventArgs e) => this.NPCNdgv = this.NpcNameDec(((Form1.SendArgs) e.Argument).filePath);

    private void NPCNbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.NPCNdgv);
      this.progressBar_Loading.Visible = false;
      this.NPCNdgv.CellValueChanged += new DataGridViewCellEventHandler(this.NPCNdgv_CellValueChanged);
      this.NPCNdgv.Disposed += new EventHandler(this.NPCNdgv_Disposed);
      this.NPCNdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.NPCNdgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private void NPCNdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => this.NPCNdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void NPCNdgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void NPCNPlusbw_DoWork(object sender, DoWorkEventArgs e) => this.NPCNPlusdgv = this.NpcNameEx700PlusDec(((Form1.SendArgs) e.Argument).filePath);

    private void NPCNPlusbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.NPCNPlusdgv);
      this.progressBar_Loading.Visible = false;
      this.NPCNPlusdgv.CellValueChanged += new DataGridViewCellEventHandler(this.NPCNPlusdgv_CellValueChanged);
      this.NPCNPlusdgv.Disposed += new EventHandler(this.NPCNPlusdgv_Disposed);
      this.NPCNPlusdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.NPCNPlusdgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private void NPCNPlusdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => this.NPCNPlusdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void NPCNPlusdgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void panel1_DisposeUnusedControls()
    {
      if (this.panel1.Controls.Count == 1)
        return;
      try
      {
        this.panel1.Controls[1].Dispose();
      }
      catch
      {
        this.panel1_DisposeUnusedControls();
      }
    }

    private void panel1_SizeChanged(object sender, EventArgs e)
    {
      if (this.tc_Items == null)
        return;
      this.tc_Items.Size = this.panel1.Size;
    }

    private void ReadINIFile(string fLocation, DataGridView dgv, int BlockSize)
    {
      this.fStruct = new object[0, this.sBlockSize];
      string[] strArray1 = System.IO.File.ReadAllLines(fLocation);
      int rowIndex = 0;
      foreach (string source1 in strArray1)
      {
        if (source1.Length != 0 && !source1.StartsWith("end") && !source1.StartsWith("//"))
        {
          List<int> intList = new List<int>();
          int num = 0;
          foreach (char ch in source1)
          {
            if (ch == '"')
              intList.Add(num);
            ++num;
          }
          string source2 = source1.Replace(' ', '$');
          char[] array1 = source1.ToArray<char>();
          char[] array2 = source2.ToArray<char>();
          for (int index = 0; index <= intList.Count / 2; index += 2)
            Array.Copy((Array) array2, intList[index], (Array) array1, intList[index], intList[index + 1] - intList[index]);
          string[] strArray2 = new string(array1).Replace(' ', '\t').Split('\t');
          List<string> stringList = new List<string>();
          foreach (string source3 in strArray2)
          {
            string str;
            if (!source3.Contains<char>('"'))
              str = source3.Trim(' ');
            else
              str = source3.Trim('"').Replace('$', ' ');
            if (str.Length > 0)
              stringList.Add(str);
          }
          if (stringList.Count != 0)
          {
            string[] array3 = stringList.ToArray();
            dgv.Rows.Add();
            dgv[0, rowIndex].Value = (object) array3[0];
            dgv[1, rowIndex].Value = (object) array3[1];
            dgv[2, rowIndex].Value = (object) array3[2];
            dgv[3, rowIndex].Value = (object) array3[3];
            dgv[4, rowIndex].Value = (object) array3[4];
            dgv[5, rowIndex].Value = (object) array3[5];
            dgv[6, rowIndex].Value = (object) array3[6];
            ++rowIndex;
          }
        }
      }
    }

    private void ReadINIFileAsGroups(string fLocation, DataGridView dgv, int BlockSize)
    {
      string[] strArray1 = System.IO.File.ReadAllLines(fLocation);
      this.fStruct = new object[8192, BlockSize];
      int num1 = 0;
      int num2 = 0;
      foreach (string str1 in strArray1)
      {
        if (!str1.StartsWith("end") && !str1.StartsWith("//"))
        {
          string[] strArray2 = str1.Split('\t');
          List<string> stringList = new List<string>();
          foreach (string source in strArray2)
          {
            string str2;
            if (!source.Contains<char>('"'))
              str2 = source.Trim(' ');
            else
              str2 = source.Trim('"');
            if (str2 != "")
              stringList.Add(str2);
          }
          if (stringList.Count != 0)
          {
            string[] array = stringList.ToArray();
            if (array.Length == 1)
              num2 = (int) Convert.ToInt16(array[0]);
            dgv.Rows.Add();
            int int32 = Convert.ToInt32(array[3]);
            int index1 = num2 * 512 + int32;
            byte[] destinationArray = new byte[BlockSize];
            byte[] sourceArray1 = new byte[1];
            byte[] sourceArray2 = new byte[1];
            byte[] sourceArray3 = new byte[1];
            byte[] sourceArray4 = new byte[1];
            byte[] bytes1 = BitConverter.GetBytes(Convert.ToUInt16(num2));
            byte[] bytes2 = BitConverter.GetBytes(Convert.ToUInt16(int32));
            byte[] bytes3 = Encoding.GetEncoding("GB2312").GetBytes(array[0].Trim('"'));
            byte[] bytes4 = Encoding.GetEncoding("GB2312").GetBytes(array[1].Trim('"'));
            byte[] sourceArray5 = new byte[30];
            byte[] sourceArray6 = new byte[1];
            byte[] sourceArray7 = new byte[1];
            byte[] sourceArray8 = new byte[2];
            byte[] sourceArray9 = new byte[2];
            byte[] sourceArray10 = new byte[2];
            byte[] sourceArray11 = new byte[1];
            byte[] sourceArray12 = new byte[1];
            byte[] sourceArray13 = new byte[1];
            byte[] sourceArray14 = new byte[1];
            byte[] sourceArray15 = new byte[1];
            byte[] sourceArray16 = new byte[2];
            byte[] sourceArray17 = new byte[1];
            byte[] sourceArray18 = new byte[1];
            byte[] sourceArray19 = new byte[1];
            byte[] sourceArray20 = new byte[1];
            byte[] sourceArray21 = new byte[1];
            byte[] sourceArray22 = new byte[2];
            byte[] sourceArray23 = new byte[2];
            byte[] sourceArray24 = new byte[2];
            byte[] sourceArray25 = new byte[2];
            byte[] sourceArray26 = new byte[2];
            byte[] sourceArray27 = new byte[2];
            byte[] sourceArray28 = new byte[2];
            byte[] sourceArray29 = new byte[4];
            byte[] sourceArray30 = new byte[1];
            byte[] sourceArray31 = new byte[1];
            byte[] sourceArray32 = new byte[1];
            byte[] sourceArray33 = new byte[1];
            byte[] sourceArray34 = new byte[1];
            byte[] sourceArray35 = new byte[1];
            byte[] sourceArray36 = new byte[1];
            byte[] sourceArray37 = new byte[1];
            byte[] sourceArray38 = new byte[1];
            byte[] sourceArray39 = new byte[1];
            byte[] sourceArray40 = new byte[1];
            byte[] sourceArray41 = new byte[1];
            byte[] sourceArray42 = new byte[1];
            byte[] sourceArray43 = new byte[1];
            byte[] sourceArray44 = new byte[1];
            byte[] sourceArray45 = new byte[1];
            int num3 = 520;
            int num4 = 6;
            Array.Copy((Array) sourceArray1, 0, (Array) destinationArray, 0, sourceArray1.Length);
            Array.Copy((Array) sourceArray2, 0, (Array) destinationArray, 1, sourceArray2.Length);
            Array.Copy((Array) sourceArray3, 0, (Array) destinationArray, 2, sourceArray3.Length);
            Array.Copy((Array) sourceArray4, 0, (Array) destinationArray, 3, sourceArray4.Length);
            Array.Copy((Array) bytes1, 0, (Array) destinationArray, 4, bytes1.Length);
            Array.Copy((Array) bytes2, 0, (Array) destinationArray, 6, bytes2.Length);
            Array.Copy((Array) bytes3, 0, (Array) destinationArray, 2 + num4, bytes3.Length);
            Array.Copy((Array) bytes4, 0, (Array) destinationArray, 262 + num4, bytes4.Length);
            Array.Copy((Array) sourceArray5, 0, (Array) destinationArray, 522 + num4, sourceArray5.Length);
            Array.Copy((Array) sourceArray6, 0, (Array) destinationArray, 32 + num4 + num3, sourceArray6.Length);
            Array.Copy((Array) sourceArray7, 0, (Array) destinationArray, 33 + num4 + num3, sourceArray7.Length);
            Array.Copy((Array) sourceArray8, 0, (Array) destinationArray, 34 + num4 + num3, sourceArray8.Length);
            Array.Copy((Array) sourceArray9, 0, (Array) destinationArray, 36 + num4 + num3, sourceArray9.Length);
            Array.Copy((Array) sourceArray10, 0, (Array) destinationArray, 38 + num4 + num3, sourceArray10.Length);
            Array.Copy((Array) sourceArray11, 0, (Array) destinationArray, 40 + num4 + num3, sourceArray11.Length);
            Array.Copy((Array) sourceArray12, 0, (Array) destinationArray, 41 + num4 + num3, sourceArray12.Length);
            Array.Copy((Array) sourceArray13, 0, (Array) destinationArray, 42 + num4 + num3, sourceArray13.Length);
            Array.Copy((Array) sourceArray14, 0, (Array) destinationArray, 43 + num4 + num3, sourceArray14.Length);
            Array.Copy((Array) sourceArray15, 0, (Array) destinationArray, 44 + num4 + num3, sourceArray15.Length);
            Array.Copy((Array) sourceArray16, 0, (Array) destinationArray, 45 + num4 + num3, sourceArray16.Length);
            Array.Copy((Array) sourceArray17, 0, (Array) destinationArray, 47 + num4 + num3, sourceArray17.Length);
            Array.Copy((Array) sourceArray18, 0, (Array) destinationArray, 48 + num4 + num3, sourceArray18.Length);
            Array.Copy((Array) sourceArray19, 0, (Array) destinationArray, 49 + num4 + num3, sourceArray19.Length);
            Array.Copy((Array) sourceArray20, 0, (Array) destinationArray, 50 + num4 + num3, sourceArray20.Length);
            Array.Copy((Array) sourceArray21, 0, (Array) destinationArray, 51 + num4 + num3, sourceArray21.Length);
            Array.Copy((Array) sourceArray22, 0, (Array) destinationArray, 52 + num4 + num3, sourceArray22.Length);
            Array.Copy((Array) sourceArray23, 0, (Array) destinationArray, 54 + num4 + num3, sourceArray23.Length);
            Array.Copy((Array) sourceArray24, 0, (Array) destinationArray, 56 + num4 + num3, sourceArray24.Length);
            Array.Copy((Array) sourceArray25, 0, (Array) destinationArray, 58 + num4 + num3, sourceArray25.Length);
            Array.Copy((Array) sourceArray26, 0, (Array) destinationArray, 60 + num4 + num3, sourceArray26.Length);
            Array.Copy((Array) sourceArray27, 0, (Array) destinationArray, 62 + num4 + num3, sourceArray27.Length);
            Array.Copy((Array) sourceArray28, 0, (Array) destinationArray, 64 + num4 + num3, sourceArray28.Length);
            Array.Copy((Array) sourceArray29, 0, (Array) destinationArray, 66 + num4 + num3, sourceArray29.Length);
            Array.Copy((Array) sourceArray30, 0, (Array) destinationArray, 70 + num4 + num3, sourceArray30.Length);
            Array.Copy((Array) sourceArray31, 0, (Array) destinationArray, 71 + num4 + num3, sourceArray31.Length);
            Array.Copy((Array) sourceArray32, 0, (Array) destinationArray, 72 + num4 + num3, sourceArray32.Length);
            Array.Copy((Array) sourceArray33, 0, (Array) destinationArray, 73 + num4 + num3, sourceArray33.Length);
            Array.Copy((Array) sourceArray34, 0, (Array) destinationArray, 74 + num4 + num3, sourceArray34.Length);
            Array.Copy((Array) sourceArray35, 0, (Array) destinationArray, 75 + num4 + num3, sourceArray35.Length);
            Array.Copy((Array) sourceArray36, 0, (Array) destinationArray, 76 + num4 + num3, sourceArray36.Length);
            Array.Copy((Array) sourceArray37, 0, (Array) destinationArray, 77 + num4 + num3, sourceArray37.Length);
            Array.Copy((Array) sourceArray38, 0, (Array) destinationArray, 78 + num4 + num3, sourceArray38.Length);
            Array.Copy((Array) sourceArray39, 0, (Array) destinationArray, 79 + num4 + num3, sourceArray39.Length);
            Array.Copy((Array) sourceArray40, 0, (Array) destinationArray, 80 + num4 + num3, sourceArray40.Length);
            Array.Copy((Array) sourceArray41, 0, (Array) destinationArray, 81 + num4 + num3, sourceArray41.Length);
            Array.Copy((Array) sourceArray42, 0, (Array) destinationArray, 82 + num4 + num3, sourceArray42.Length);
            Array.Copy((Array) sourceArray43, 0, (Array) destinationArray, 83 + num4 + num3, sourceArray43.Length);
            Array.Copy((Array) sourceArray44, 0, (Array) destinationArray, 84 + num4 + num3, sourceArray44.Length);
            Array.Copy((Array) sourceArray45, 0, (Array) destinationArray, 85 + num4 + num3, sourceArray45.Length);
            for (int index2 = 0; index2 < this.sBlockSize; ++index2)
              this.fStruct[index1, index2] = (object) destinationArray[index2];
            ++num1;
          }
        }
      }
      this.sSize = num1;
      object[,] destinationArray1 = new object[this.sSize, BlockSize];
      Array.Copy((Array) this.fStruct, (Array) destinationArray1, destinationArray1.Length);
      this.fStruct = destinationArray1;
    }

    private void RegTimer_Tick(object sender, EventArgs e)
    {
      ((System.Windows.Forms.Timer) sender).Stop();
      try
      {
        this.UpdateCheck();
        int num = (int) MessageBox.Show(Form1.Kernel32.GetEnvironmentVariable("WLRegFirstRun", new StringBuilder(100), 100).ToString());
      }
      catch
      {
        Environment.Exit(0);
      }
      ((System.Windows.Forms.Timer) sender).Start();
    }

    private void s6e3ItemList_ToolStripMenuItem_ON_Click(object sender, EventArgs e)
    {
      this.isEx700ItemList = false;
      this.ex700ItemList_ToolStripMenuItem_ON.Font = new Font(this.ex700ItemList_ToolStripMenuItem_ON.Font, FontStyle.Regular);
      this.s6e3ItemList_ToolStripMenuItem_ON.Font = new Font(this.s6e3ItemList_ToolStripMenuItem_ON.Font, FontStyle.Bold);
    }

    private void ServerListEx700_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the ServerList.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ServerListEx700";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void ServerListEx700bw_DoWork(object sender, DoWorkEventArgs e) => this.ServerListEx700dgv = this.ServerListEx700Dec(((Form1.SendArgs) e.Argument).filePath);

    private void ServerListEx700bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.ServerListEx700dgv);
      this.progressBar_Loading.Visible = false;
      this.ServerListEx700dgv.CellValueChanged += new DataGridViewCellEventHandler(this.ServerListEx700dgv_CellValueChanged);
      this.ServerListEx700dgv.Disposed += new EventHandler(this.ServerListEx700dgv_Disposed);
      this.ServerListEx700dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.ServerListEx700dgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView ServerListEx700Dec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      this.initializeServerListEx700Grid(dgv);
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray1 = new byte[fileStream.Length];
        this.sSize = (int) fileStream.Length / this.sBlockSize;
        this.fStruct = new object[this.sSize, this.sBlockSize];
        fileStream.Read(numArray1, 0, numArray1.Length);
        fileStream.Close();
        byte[] Buffer = new byte[this.sBlockSize];
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          Array.Copy((Array) numArray1, rowIndex * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, Buffer.Length);
          byte[] destinationArray1 = new byte[2];
          byte[] numArray2 = new byte[32];
          byte[] destinationArray2 = new byte[1];
          byte[] destinationArray3 = new byte[1];
          byte[] destinationArray4 = new byte[1];
          byte[] destinationArray5 = new byte[1];
          byte[] destinationArray6 = new byte[1];
          byte[] destinationArray7 = new byte[1];
          byte[] destinationArray8 = new byte[1];
          byte[] destinationArray9 = new byte[1];
          byte[] destinationArray10 = new byte[1];
          byte[] destinationArray11 = new byte[1];
          byte[] destinationArray12 = new byte[1];
          byte[] destinationArray13 = new byte[1];
          byte[] destinationArray14 = new byte[1];
          byte[] destinationArray15 = new byte[1];
          byte[] destinationArray16 = new byte[1];
          byte[] destinationArray17 = new byte[1];
          byte[] destinationArray18 = new byte[1];
          byte[] destinationArray19 = new byte[1];
          byte[] destinationArray20 = new byte[1];
          byte[] destinationArray21 = new byte[1];
          byte[] destinationArray22 = new byte[1];
          byte[] destinationArray23 = new byte[1];
          byte[] destinationArray24 = new byte[1];
          byte[] destinationArray25 = new byte[1];
          byte[] destinationArray26 = new byte[1];
          Array.Copy((Array) Buffer, 0, (Array) destinationArray1, 0, destinationArray1.Length);
          Array.Copy((Array) Buffer, 2, (Array) numArray2, 0, numArray2.Length);
          Array.Copy((Array) Buffer, 35, (Array) destinationArray2, 0, destinationArray2.Length);
          Array.Copy((Array) Buffer, 36, (Array) destinationArray3, 0, destinationArray3.Length);
          Array.Copy((Array) Buffer, 37, (Array) destinationArray4, 0, destinationArray4.Length);
          Array.Copy((Array) Buffer, 38, (Array) destinationArray5, 0, destinationArray5.Length);
          Array.Copy((Array) Buffer, 39, (Array) destinationArray6, 0, destinationArray6.Length);
          Array.Copy((Array) Buffer, 40, (Array) destinationArray7, 0, destinationArray7.Length);
          Array.Copy((Array) Buffer, 41, (Array) destinationArray8, 0, destinationArray8.Length);
          Array.Copy((Array) Buffer, 42, (Array) destinationArray9, 0, destinationArray9.Length);
          Array.Copy((Array) Buffer, 43, (Array) destinationArray10, 0, destinationArray10.Length);
          Array.Copy((Array) Buffer, 44, (Array) destinationArray11, 0, destinationArray11.Length);
          Array.Copy((Array) Buffer, 45, (Array) destinationArray12, 0, destinationArray12.Length);
          Array.Copy((Array) Buffer, 46, (Array) destinationArray13, 0, destinationArray13.Length);
          Array.Copy((Array) Buffer, 47, (Array) destinationArray14, 0, destinationArray14.Length);
          Array.Copy((Array) Buffer, 48, (Array) destinationArray15, 0, destinationArray15.Length);
          Array.Copy((Array) Buffer, 49, (Array) destinationArray16, 0, destinationArray16.Length);
          Array.Copy((Array) Buffer, 50, (Array) destinationArray17, 0, destinationArray17.Length);
          Array.Copy((Array) Buffer, 51, (Array) destinationArray18, 0, destinationArray18.Length);
          Array.Copy((Array) Buffer, 52, (Array) destinationArray19, 0, destinationArray19.Length);
          Array.Copy((Array) Buffer, 53, (Array) destinationArray20, 0, destinationArray20.Length);
          Array.Copy((Array) Buffer, 54, (Array) destinationArray21, 0, destinationArray21.Length);
          Array.Copy((Array) Buffer, 55, (Array) destinationArray22, 0, destinationArray22.Length);
          Array.Copy((Array) Buffer, 56, (Array) destinationArray23, 0, destinationArray23.Length);
          Array.Copy((Array) Buffer, 57, (Array) destinationArray24, 0, destinationArray24.Length);
          Array.Copy((Array) Buffer, 58, (Array) destinationArray25, 0, destinationArray25.Length);
          Array.Copy((Array) Buffer, 59, (Array) destinationArray26, 0, destinationArray26.Length);
          dgv.Rows.Add();
          dgv["Code", rowIndex].Value = (object) BitConverter.ToUInt16(destinationArray1, 0);
          dgv["Name", rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace(char.MinValue, ' ').Trim();
          dgv[2, rowIndex].Value = (object) destinationArray2[0];
          dgv[3, rowIndex].Value = (object) destinationArray3[0];
          dgv[4, rowIndex].Value = (object) destinationArray4[0];
          dgv[5, rowIndex].Value = (object) destinationArray5[0];
          dgv[6, rowIndex].Value = (object) destinationArray6[0];
          dgv[7, rowIndex].Value = (object) destinationArray7[0];
          dgv[8, rowIndex].Value = (object) destinationArray8[0];
          dgv[9, rowIndex].Value = (object) destinationArray9[0];
          dgv[10, rowIndex].Value = (object) destinationArray10[0];
          dgv[11, rowIndex].Value = (object) destinationArray11[0];
          dgv[12, rowIndex].Value = (object) destinationArray12[0];
          dgv[13, rowIndex].Value = (object) destinationArray13[0];
          dgv[14, rowIndex].Value = (object) destinationArray14[0];
          dgv[15, rowIndex].Value = (object) destinationArray15[0];
          dgv[16, rowIndex].Value = (object) destinationArray16[0];
          dgv[17, rowIndex].Value = (object) destinationArray17[0];
          dgv[18, rowIndex].Value = (object) destinationArray18[0];
          dgv[19, rowIndex].Value = (object) destinationArray19[0];
          dgv[20, rowIndex].Value = (object) destinationArray20[0];
          dgv[21, rowIndex].Value = (object) destinationArray21[0];
          dgv[22, rowIndex].Value = (object) destinationArray22[0];
          dgv[23, rowIndex].Value = (object) destinationArray23[0];
          dgv[24, rowIndex].Value = (object) destinationArray24[0];
          dgv[25, rowIndex].Value = (object) destinationArray25[0];
          dgv[26, rowIndex].Value = (object) destinationArray26[0];
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void ServerListEx700dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => this.ServerListEx700dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void ServerListEx700dgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void ServerListEx700Enc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        if (row.Cells[0].Value != null)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt16(row.Cells[0].Value.ToString())), 0, (Array) Buffer, 0, 2);
          byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[1].Value.ToString());
          Array.Copy((Array) bytes, 0, (Array) Buffer, 2, bytes.Length);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[2].Value.ToString())), 0, (Array) Buffer, 35, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[3].Value.ToString())), 0, (Array) Buffer, 36, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[4].Value.ToString())), 0, (Array) Buffer, 37, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[5].Value.ToString())), 0, (Array) Buffer, 38, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[6].Value.ToString())), 0, (Array) Buffer, 39, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[7].Value.ToString())), 0, (Array) Buffer, 40, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[8].Value.ToString())), 0, (Array) Buffer, 41, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[9].Value.ToString())), 0, (Array) Buffer, 42, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[10].Value.ToString())), 0, (Array) Buffer, 43, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[11].Value.ToString())), 0, (Array) Buffer, 44, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[12].Value.ToString())), 0, (Array) Buffer, 45, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[13].Value.ToString())), 0, (Array) Buffer, 46, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[14].Value.ToString())), 0, (Array) Buffer, 47, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[15].Value.ToString())), 0, (Array) Buffer, 48, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[16].Value.ToString())), 0, (Array) Buffer, 49, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[17].Value.ToString())), 0, (Array) Buffer, 50, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[18].Value.ToString())), 0, (Array) Buffer, 51, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[19].Value.ToString())), 0, (Array) Buffer, 52, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[20].Value.ToString())), 0, (Array) Buffer, 53, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[21].Value.ToString())), 0, (Array) Buffer, 54, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[22].Value.ToString())), 0, (Array) Buffer, 55, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[23].Value.ToString())), 0, (Array) Buffer, 56, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[24].Value.ToString())), 0, (Array) Buffer, 57, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[25].Value.ToString())), 0, (Array) Buffer, 58, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[26].Value.ToString())), 0, (Array) Buffer, 59, 1);
          this.EncBlock(ref Buffer, this.sBlockSize);
          for (int index = 0; index < Buffer.Length; ++index)
            byteList.Add(Buffer[index]);
          this.backgroundWorker.ReportProgress(row.Index);
        }
      }
      this.newFile = byteList.ToArray();
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void ServerListS6E3_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the ServerList.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.newFile = new byte[this.sSize * this.sBlockSize];
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "ServerListS6E3";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void ServerListS6E3bw_DoWork(object sender, DoWorkEventArgs e) => this.ServerListS6E3dgv = this.ServerListS6E3Dec(((Form1.SendArgs) e.Argument).filePath);

    private void ServerListS6E3bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.ServerListS6E3dgv);
      this.progressBar_Loading.Visible = false;
      this.ServerListS6E3dgv.CellValueChanged += new DataGridViewCellEventHandler(this.ServerListS6E3dgv_CellValueChanged);
      this.ServerListS6E3dgv.Disposed += new EventHandler(this.ServerListS6E3dgv_Disposed);
      this.ServerListS6E3dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.ServerListS6E3dgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView ServerListS6E3Dec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      this.initializeServerListS6E3Grid(dgv);
      try
      {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray1 = new byte[fileStream.Length];
        this.sBlockSize = 55;
        this.sSize = (int) fileStream.Length / this.sBlockSize;
        fileStream.Read(numArray1, 0, numArray1.Length);
        fileStream.Close();
        byte[] Buffer = new byte[this.sBlockSize];
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          Array.Copy((Array) numArray1, rowIndex * this.sBlockSize, (Array) Buffer, 0, this.sBlockSize);
          this.DecBlock(ref Buffer, Buffer.Length);
          byte[] destinationArray1 = new byte[2];
          byte[] numArray2 = new byte[32];
          byte[] destinationArray2 = new byte[1];
          byte[] destinationArray3 = new byte[1];
          byte[] destinationArray4 = new byte[1];
          byte[] destinationArray5 = new byte[1];
          byte[] destinationArray6 = new byte[1];
          byte[] destinationArray7 = new byte[1];
          byte[] destinationArray8 = new byte[1];
          byte[] destinationArray9 = new byte[1];
          byte[] destinationArray10 = new byte[1];
          byte[] destinationArray11 = new byte[1];
          byte[] destinationArray12 = new byte[1];
          byte[] destinationArray13 = new byte[1];
          byte[] destinationArray14 = new byte[1];
          byte[] destinationArray15 = new byte[1];
          byte[] destinationArray16 = new byte[1];
          byte[] destinationArray17 = new byte[1];
          byte[] destinationArray18 = new byte[1];
          byte[] destinationArray19 = new byte[1];
          byte[] destinationArray20 = new byte[1];
          byte[] destinationArray21 = new byte[1];
          Array.Copy((Array) Buffer, 0, (Array) destinationArray1, 0, destinationArray1.Length);
          Array.Copy((Array) Buffer, 2, (Array) numArray2, 0, numArray2.Length);
          Array.Copy((Array) Buffer, 35, (Array) destinationArray2, 0, destinationArray2.Length);
          Array.Copy((Array) Buffer, 36, (Array) destinationArray3, 0, destinationArray3.Length);
          Array.Copy((Array) Buffer, 37, (Array) destinationArray4, 0, destinationArray4.Length);
          Array.Copy((Array) Buffer, 38, (Array) destinationArray5, 0, destinationArray5.Length);
          Array.Copy((Array) Buffer, 39, (Array) destinationArray6, 0, destinationArray6.Length);
          Array.Copy((Array) Buffer, 40, (Array) destinationArray7, 0, destinationArray7.Length);
          Array.Copy((Array) Buffer, 41, (Array) destinationArray8, 0, destinationArray8.Length);
          Array.Copy((Array) Buffer, 42, (Array) destinationArray9, 0, destinationArray9.Length);
          Array.Copy((Array) Buffer, 43, (Array) destinationArray10, 0, destinationArray10.Length);
          Array.Copy((Array) Buffer, 44, (Array) destinationArray11, 0, destinationArray11.Length);
          Array.Copy((Array) Buffer, 45, (Array) destinationArray12, 0, destinationArray12.Length);
          Array.Copy((Array) Buffer, 46, (Array) destinationArray13, 0, destinationArray13.Length);
          Array.Copy((Array) Buffer, 47, (Array) destinationArray14, 0, destinationArray14.Length);
          Array.Copy((Array) Buffer, 48, (Array) destinationArray15, 0, destinationArray15.Length);
          Array.Copy((Array) Buffer, 49, (Array) destinationArray16, 0, destinationArray16.Length);
          Array.Copy((Array) Buffer, 50, (Array) destinationArray17, 0, destinationArray17.Length);
          Array.Copy((Array) Buffer, 51, (Array) destinationArray18, 0, destinationArray18.Length);
          Array.Copy((Array) Buffer, 52, (Array) destinationArray19, 0, destinationArray19.Length);
          Array.Copy((Array) Buffer, 53, (Array) destinationArray20, 0, destinationArray20.Length);
          Array.Copy((Array) Buffer, 54, (Array) destinationArray21, 0, destinationArray21.Length);
          dgv.Rows.Add();
          dgv["Code", rowIndex].Value = (object) BitConverter.ToUInt16(destinationArray1, 0);
          dgv["Name", rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace(char.MinValue, ' ').Trim();
          dgv[2, rowIndex].Value = (object) destinationArray2[0];
          dgv[3, rowIndex].Value = (object) destinationArray3[0];
          dgv[4, rowIndex].Value = (object) destinationArray4[0];
          dgv[5, rowIndex].Value = (object) destinationArray5[0];
          dgv[6, rowIndex].Value = (object) destinationArray6[0];
          dgv[7, rowIndex].Value = (object) destinationArray7[0];
          dgv[8, rowIndex].Value = (object) destinationArray8[0];
          dgv[9, rowIndex].Value = (object) destinationArray9[0];
          dgv[10, rowIndex].Value = (object) destinationArray10[0];
          dgv[11, rowIndex].Value = (object) destinationArray11[0];
          dgv[12, rowIndex].Value = (object) destinationArray12[0];
          dgv[13, rowIndex].Value = (object) destinationArray13[0];
          dgv[14, rowIndex].Value = (object) destinationArray14[0];
          dgv[15, rowIndex].Value = (object) destinationArray15[0];
          dgv[16, rowIndex].Value = (object) destinationArray16[0];
          dgv[17, rowIndex].Value = (object) destinationArray17[0];
          dgv[18, rowIndex].Value = (object) destinationArray18[0];
          dgv[19, rowIndex].Value = (object) destinationArray19[0];
          dgv[20, rowIndex].Value = (object) destinationArray20[0];
          dgv[21, rowIndex].Value = (object) destinationArray21[0];
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void ServerListS6E3dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => this.ServerListS6E3dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void ServerListS6E3dgv_Disposed(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void ServerListS6E3Enc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        if (row.Cells[0].Value != null)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) BitConverter.GetBytes(Convert.ToUInt16(row.Cells[0].Value.ToString())), 0, (Array) Buffer, 0, 2);
          byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[1].Value.ToString());
          Array.Copy((Array) bytes, 0, (Array) Buffer, 2, bytes.Length);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[2].Value.ToString())), 0, (Array) Buffer, 35, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[3].Value.ToString())), 0, (Array) Buffer, 36, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[4].Value.ToString())), 0, (Array) Buffer, 37, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[5].Value.ToString())), 0, (Array) Buffer, 38, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[6].Value.ToString())), 0, (Array) Buffer, 39, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[7].Value.ToString())), 0, (Array) Buffer, 40, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[8].Value.ToString())), 0, (Array) Buffer, 41, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[9].Value.ToString())), 0, (Array) Buffer, 42, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[10].Value.ToString())), 0, (Array) Buffer, 43, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[11].Value.ToString())), 0, (Array) Buffer, 44, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[12].Value.ToString())), 0, (Array) Buffer, 45, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[13].Value.ToString())), 0, (Array) Buffer, 46, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[14].Value.ToString())), 0, (Array) Buffer, 47, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[15].Value.ToString())), 0, (Array) Buffer, 48, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[16].Value.ToString())), 0, (Array) Buffer, 49, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[17].Value.ToString())), 0, (Array) Buffer, 50, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[18].Value.ToString())), 0, (Array) Buffer, 51, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[19].Value.ToString())), 0, (Array) Buffer, 52, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[20].Value.ToString())), 0, (Array) Buffer, 53, 1);
          Array.Copy((Array) BitConverter.GetBytes((short) Convert.ToByte(row.Cells[21].Value.ToString())), 0, (Array) Buffer, 54, 1);
          this.EncBlock(ref Buffer, this.sBlockSize);
          for (int index = 0; index < Buffer.Length; ++index)
            byteList.Add(Buffer[index]);
          this.backgroundWorker.ReportProgress(row.Index);
        }
      }
      this.newFile = byteList.ToArray();
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void shopToolStripMenuItem_Click(object sender, EventArgs e) => new ShopEditor().Show();

    private void Skill_ExS8E1_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Skill.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count - 1;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Skill_ExS8E1";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Skill_ExS8E1bw_DoWork(object sender, DoWorkEventArgs e) => this.Skill_ExS8E1dgv = this.Skill_ExS8E1Dec(((Form1.SendArgs) e.Argument).filePath);

    private void Skill_ExS8E1bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.panel1.Controls.Add((Control) this.Skill_ExS8E1dgv);
      this.progressBar_Loading.Visible = false;
      this.Skill_ExS8E1dgv.CellValueChanged += new DataGridViewCellEventHandler(this.Skill_ExS8E1dgv_CellValueChanged);
      this.Skill_ExS8E1dgv.Disposed += new EventHandler(this.Skill_ExS8E1dgv_Disposed);
      this.Skill_ExS8E1dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.Skill_ExS8E1dgv;
    }

    private DataGridView Skill_ExS8E1Dec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeSkill_ExS8E1Grid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] Buffer = new byte[fileStream.Length];
        fileStream.Read(Buffer, 0, Buffer.Length);
        fileStream.Close();
        this.DecBlock(ref Buffer, Buffer.Length);
        this.sBlockSize = 96;
        this.sSize = (Buffer.Length - 4) / this.sBlockSize;
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] numArray = new byte[this.sBlockSize];
          Array.Copy((Array) Buffer, rowIndex * this.sBlockSize, (Array) numArray, 0, numArray.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray, 0, 32).Replace("\0", string.Empty);
          int startIndex = 32;
          for (int columnIndex = 1; columnIndex < 5; ++columnIndex)
          {
            dgv[columnIndex, rowIndex].Value = (object) BitConverter.ToUInt16(numArray, startIndex);
            startIndex += 2;
          }
          for (int columnIndex = 5; columnIndex < 8; ++columnIndex)
          {
            dgv[columnIndex, rowIndex].Value = (object) BitConverter.ToUInt32(numArray, startIndex);
            startIndex += 4;
          }
          dgv[8, rowIndex].Value = (object) BitConverter.ToUInt16(numArray, startIndex);
          int index = startIndex + 2;
          for (int columnIndex = 9; columnIndex < 51; ++columnIndex)
          {
            dgv[columnIndex, rowIndex].Value = (object) numArray[index];
            ++index;
          }
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void Skill_ExS8E1dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => this.Skill_ExS8E1dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void Skill_ExS8E1dgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void Skill_ExS8E1Enc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      byte[] numArray = new byte[0];
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        byte[] destinationArray = new byte[32];
        byte[] bytes1 = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[0].Value.ToString());
        Array.Resize<byte>(ref bytes1, 32);
        Array.Copy((Array) bytes1, 0, (Array) destinationArray, 0, bytes1.Length);
        for (int index = 0; index < destinationArray.Length; ++index)
          byteList.Add(destinationArray[index]);
        for (int index = 1; index < 5; ++index)
        {
          foreach (byte num in BitConverter.GetBytes(Convert.ToUInt16(row.Cells[index].Value)))
            byteList.Add(num);
        }
        for (int index = 5; index < 8; ++index)
        {
          foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(row.Cells[index].Value)))
            byteList.Add(num);
        }
        foreach (byte num in BitConverter.GetBytes(Convert.ToUInt16(row.Cells[8].Value)))
          byteList.Add(num);
        for (int index = 9; index < 51; ++index)
        {
          byte[] bytes2 = BitConverter.GetBytes((short) Convert.ToByte(row.Cells[index].Value));
          byteList.Add(bytes2[0]);
        }
        this.backgroundWorker.ReportProgress(this.workingDGV.Rows.IndexOf(row));
      }
      byte[] array = byteList.ToArray();
      this.EncBlock(ref array, array.Length);
      this.newFile = new byte[array.Length + 4];
      Array.Copy((Array) array, 0, (Array) this.newFile, 0, array.Length);
      byte[] sourceArray = this.CalcCRC(this.newFile, 23064U, 0U);
      Array.Copy((Array) sourceArray, 0, (Array) this.newFile, this.newFile.Length - 4, sourceArray.Length);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void Skill_S6E3_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Skill.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count - 1;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Skill_S6E3";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Skill_S6E3bw_DoWork(object sender, DoWorkEventArgs e) => this.Skill_S6E3dgv = this.Skill_S6E3Dec(((Form1.SendArgs) e.Argument).filePath);

    private void Skill_S6E3bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = false;
      this.toolStripButton_RemoveSelectedRow.Enabled = false;
      this.panel1.Controls.Add((Control) this.Skill_S6E3dgv);
      this.progressBar_Loading.Visible = false;
      this.Skill_S6E3dgv.CellValueChanged += new DataGridViewCellEventHandler(this.Skill_S6E3dgv_CellValueChanged);
      this.Skill_S6E3dgv.Disposed += new EventHandler(this.Skill_S6E3dgv_Disposed);
      this.Skill_S6E3dgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.Skill_S6E3dgv;
    }

    private DataGridView Skill_S6E3Dec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeSkill_S6E3Grid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray = new byte[fileStream.Length];
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        this.sBlockSize = 88;
        this.sSize = (numArray.Length - 4) / this.sBlockSize;
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] Buffer = new byte[this.sBlockSize];
          Array.Copy((Array) numArray, rowIndex * this.sBlockSize, (Array) Buffer, 0, Buffer.Length);
          this.DecBlock(ref Buffer, Buffer.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(Buffer, 0, 32).Replace("\0", string.Empty);
          int startIndex = 32;
          for (int columnIndex = 1; columnIndex < 5; ++columnIndex)
          {
            dgv[columnIndex, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, startIndex);
            startIndex += 2;
          }
          for (int columnIndex = 5; columnIndex < 8; ++columnIndex)
          {
            dgv[columnIndex, rowIndex].Value = (object) BitConverter.ToUInt32(Buffer, startIndex);
            startIndex += 4;
          }
          dgv[8, rowIndex].Value = (object) BitConverter.ToUInt16(Buffer, startIndex);
          int index = startIndex + 2;
          for (int columnIndex = 9; columnIndex < 43; ++columnIndex)
          {
            dgv[columnIndex, rowIndex].Value = (object) Buffer[index];
            ++index;
          }
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void Skill_S6E3dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e) => this.Skill_S6E3dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;

    private void Skill_S6E3dgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void Skill_S6E3Enc(string filePath)
    {
      List<byte> byteList1 = new List<byte>();
      List<byte> byteList2 = new List<byte>();
      byte[] numArray = new byte[0];
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        byte[] destinationArray = new byte[32];
        byte[] bytes1 = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[0].Value.ToString());
        Array.Resize<byte>(ref bytes1, 32);
        Array.Copy((Array) bytes1, 0, (Array) destinationArray, 0, bytes1.Length);
        for (int index = 0; index < destinationArray.Length; ++index)
          byteList2.Add(destinationArray[index]);
        for (int index = 1; index < 5; ++index)
        {
          foreach (byte num in BitConverter.GetBytes(Convert.ToUInt16(row.Cells[index].Value)))
            byteList2.Add(num);
        }
        for (int index = 5; index < 8; ++index)
        {
          foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(row.Cells[index].Value)))
            byteList2.Add(num);
        }
        foreach (byte num in BitConverter.GetBytes(Convert.ToUInt16(row.Cells[8].Value)))
          byteList2.Add(num);
        for (int index = 9; index < 43; ++index)
        {
          byte[] bytes2 = BitConverter.GetBytes((short) Convert.ToByte(row.Cells[index].Value));
          byteList2.Add(bytes2[0]);
        }
        byte[] array = byteList2.ToArray();
        this.EncBlock(ref array, array.Length);
        for (int index = 0; index < array.Length; ++index)
          byteList1.Add(array[index]);
        this.backgroundWorker.ReportProgress(this.workingDGV.Rows.IndexOf(row));
      }
      byte[] array1 = byteList1.ToArray();
      this.EncBlock(ref array1, array1.Length);
      this.newFile = new byte[array1.Length + 4];
      Array.Copy((Array) array1, 0, (Array) this.newFile, 0, array1.Length);
      byte[] sourceArray = this.CalcCRC(this.newFile, 23064U, 0U);
      Array.Copy((Array) sourceArray, 0, (Array) this.newFile, this.newFile.Length - 4, sourceArray.Length);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void Slide_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Slide.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count - 1;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Slide";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void Slidebw_DoWork(object sender, DoWorkEventArgs e) => this.Slidedgv = this.SlideDec(((Form1.SendArgs) e.Argument).filePath);

    private void Slidebw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.Slidedgv);
      this.progressBar_Loading.Visible = false;
      this.Slidedgv.CellValueChanged += new DataGridViewCellEventHandler(this.Slidedgv_CellValueChanged);
      this.Slidedgv.Disposed += new EventHandler(this.Slidedgv_Disposed);
      this.Slidedgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.Slidedgv;
      this.workingDGV.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
    }

    private DataGridView SlideDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeSlideGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] Buffer = new byte[fileStream.Length];
        fileStream.Read(Buffer, 0, Buffer.Length);
        fileStream.Close();
        this.DecBlock(ref Buffer, Buffer.Length);
        this.startBytes = new byte[8];
        Array.Copy((Array) Buffer, 0, (Array) this.startBytes, 0, this.startBytes.Length);
        this.sBlockSize = 8200;
        this.sSize = (Buffer.Length - 8) / this.sBlockSize;
        for (int rowIndex = 0; rowIndex < this.sSize; ++rowIndex)
        {
          byte[] numArray1 = new byte[this.sBlockSize];
          Array.Copy((Array) Buffer, 8 + rowIndex * this.sBlockSize, (Array) numArray1, 0, numArray1.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) BitConverter.ToUInt32(numArray1, 0);
          dgv[1, rowIndex].Value = (object) BitConverter.ToUInt32(numArray1, 4);
          for (int index = 0; index < 32; ++index)
          {
            byte[] numArray2 = new byte[256];
            Array.Copy((Array) numArray1, 8 + index * 256, (Array) numArray2, 0, numArray2.Length);
            dgv[index + 2, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(numArray2).Replace("\0", string.Empty);
          }
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void Slidedgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      DataGridView dataGridView = (DataGridView) sender;
      string empty = string.Empty;
      string str = dataGridView.EditingControl == null ? this.PasteValue : dataGridView.EditingControl.Text;
      if (e.ColumnIndex != 0 & e.ColumnIndex != 1)
      {
        if (str.Length > 256)
        {
          dataGridView.EditingControl.Text = str.Remove(256);
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) str.Remove(256);
        }
      }
      else
      {
        try
        {
          if (Convert.ToUInt32(str) <= uint.MaxValue)
          {
            if (Convert.ToUInt32(str) >= 0U)
              goto label_7;
          }
          dataGridView.EditingControl.Text = "0";
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) "0";
        }
        catch
        {
          dataGridView.EditingControl.Text = string.Empty;
          dataGridView[e.ColumnIndex, e.RowIndex].Value = (object) string.Empty;
        }
      }
label_7:
      this.Slidedgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
    }

    private void Slidedgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void SlideEnc(string filePath)
    {
      List<byte> byteList1 = new List<byte>();
      for (int index = 0; index < this.startBytes.Length; ++index)
        byteList1.Add(this.startBytes[index]);
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        List<byte> byteList2 = new List<byte>();
        byte[] numArray = new byte[0];
        foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(row.Cells[0].Value)))
          byteList2.Add(num);
        foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(row.Cells[1].Value)))
          byteList2.Add(num);
        for (int index1 = 0; index1 < 32; ++index1)
        {
          string empty = string.Empty;
          byte[] destinationArray = new byte[256];
          if (row.Cells[index1 + 2].Value != null)
            empty = row.Cells[index1 + 2].Value.ToString();
          byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(empty);
          Array.Copy((Array) bytes, 0, (Array) destinationArray, 0, bytes.Length);
          for (int index2 = 0; index2 < destinationArray.Length; ++index2)
            byteList2.Add(destinationArray[index2]);
        }
        foreach (byte num in byteList2.ToArray())
          byteList1.Add(num);
        this.backgroundWorker.ReportProgress(this.workingDGV.Rows.IndexOf(row));
      }
      this.newFile = new byte[0];
      this.newFile = byteList1.ToArray();
      this.EncBlock(ref this.newFile, this.newFile.Length);
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    public void StrToByteArray(ref byte[] OrigByt, string str)
    {
      byte[] numArray = new byte[str.Length];
      byte[] bytes = new UTF8Encoding().GetBytes(str);
      Array.Copy((Array) bytes, 0, (Array) OrigByt, 0, bytes.Length);
    }

    private void tc_Items_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.LastSelectedItemGroup != null)
        this.DisposeGrid(this.LastSelectedItemGroup);
      TabControl tabControl = (TabControl) sender;
      if (tabControl.SelectedIndex == -1)
        return;
      TabPage selectedTab = tabControl.SelectedTab;
      switch (selectedTab.Name.Split('_')[0])
      {
        case "ITT":
          this.InitITTGridAndAddItems((int) Convert.ToInt16(selectedTab.Name.Split('_')[2]), selectedTab);
          break;
        case "IST":
          this.InitISTGridAndAddItems((int) Convert.ToInt16(selectedTab.Name.Split('_')[2]), selectedTab);
          break;
        case "IAO":
          this.InitIAOGridAndAddItems((int) Convert.ToInt16(selectedTab.Name.Split('_')[2]), selectedTab);
          break;
        case "JOHS":
          this.InitJOHSGridAndAddItems((int) Convert.ToInt16(selectedTab.Name.Split('_')[2]), selectedTab);
          break;
        case "ItemEx700":
          this.InitItemEx700GridAndAddItems((int) Convert.ToInt16(selectedTab.Name.Split('_')[2]), selectedTab);
          break;
        case "ItemEx700Plus":
          this.InitItemEx700PlusGridAndAddItems((int) Convert.ToInt16(selectedTab.Name.Split('_')[2]), selectedTab);
          break;
        case "ItemSeason8Episode1":
          this.InitItemSeason8Episode1GridAndAddItems((int) Convert.ToInt16(selectedTab.Name.Split('_')[2]), selectedTab);
          break;
        case "ItemS6E3":
          this.InitItem_S6E3GridAndAddItems((int) Convert.ToInt16(selectedTab.Name.Split('_')[2]), selectedTab);
          break;
      }
      this.LastSelectedItemGroup = selectedTab;
      if (Application.OpenForms["Form_BmdItemAddercs"] == null)
        return;
      Form_BmdItemAddercs openForm = (Form_BmdItemAddercs) Application.OpenForms["Form_BmdItemAddercs"];
      openForm.isWorkingMainForm = true;
      openForm.comboBox_ToGroup.SelectedIndex = (int) Convert.ToInt16(selectedTab.Name.Split('_')[2]);
      openForm.isWorkingMainForm = false;
    }

    private void Text_Save()
    {
      Form1.SendArgs sendArgs = new Form1.SendArgs();
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Title = "Select a location to save the Text.bmd File";
      saveFileDialog1.Filter = "BMD files (*.bmd)|*.bmd|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      this.toolStripProgressBar_Save.Visible = true;
      this.toolStripProgressBar_Save.Value = 0;
      this.toolStripProgressBar_Save.Size = new Size(this.Width - 460, 22);
      this.toolStripProgressBar_Save.Maximum = this.workingDGV.Rows.Count;
      sendArgs.filePath = saveFileDialog2.FileName;
      sendArgs.fileType = "Text";
      this.backgroundWorker.RunWorkerAsync((object) sendArgs);
    }

    private void TEXTbw_DoWork(object sender, DoWorkEventArgs e) => this.TEXTdgv = this.TEXTDec(((Form1.SendArgs) e.Argument).filePath);

    private void TEXTbw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.toolStripButton_AddRow.Enabled = true;
      this.toolStripButton_RemoveSelectedRow.Enabled = true;
      this.panel1.Controls.Add((Control) this.TEXTdgv);
      this.progressBar_Loading.Visible = false;
      this.TEXTdgv.CellValueChanged += new DataGridViewCellEventHandler(this.TEXTdgv_CellValueChanged);
      this.TEXTdgv.Disposed += new EventHandler(this.TEXTdgv_Disposed);
      this.TEXTdgv.KeyDown += new KeyEventHandler(this.dgvPasteEvent_KeyDown);
      this.workingDGV = this.TEXTdgv;
    }

    private DataGridView TEXTDec(string filePath)
    {
      DataGridView dgv = new DataGridView();
      try
      {
        this.initializeTEXTGrid(dgv);
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        byte[] numArray = new byte[fileStream.Length];
        fileStream.Read(numArray, 0, numArray.Length);
        fileStream.Close();
        this.startBytes = new byte[2];
        Array.Copy((Array) numArray, 0, (Array) this.startBytes, 0, this.startBytes.Length);
        uint uint32 = BitConverter.ToUInt32(numArray, 2);
        int startIndex = 6;
        for (int rowIndex = 0; (long) rowIndex < (long) uint32; ++rowIndex)
        {
          byte[] Buffer = new byte[(IntPtr) BitConverter.ToUInt32(numArray, startIndex + 4)];
          Array.Copy((Array) numArray, startIndex + 8, (Array) Buffer, 0, Buffer.Length);
          this.DecBlock(ref Buffer, Buffer.Length);
          dgv.Rows.Add();
          dgv[0, rowIndex].Value = (object) BitConverter.ToUInt32(numArray, startIndex);
          dgv[1, rowIndex].Value = (object) BitConverter.ToUInt32(numArray, startIndex + 4);
          dgv[2, rowIndex].Value = (object) Encoding.GetEncoding("GB2312").GetString(Buffer).Replace("\0", "");
          startIndex = startIndex + Buffer.Length + 8;
        }
      }
      catch (Exception ex)
      {
        dgv = new DataGridView();
        int num = (int) MessageBox.Show("The selected file failed to decrypt. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      return dgv;
    }

    private void TEXTdgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      string str = string.Empty;
      if (this.TEXTdgv[e.ColumnIndex, e.RowIndex].Value != null)
        str = this.TEXTdgv[e.ColumnIndex, e.RowIndex].Value.ToString();
      if (str.Length == 0)
        str = " ";
      if (e.ColumnIndex == 2)
        this.TEXTdgv[1, e.RowIndex].Value = (object) str.Length;
      this.TEXTdgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.PaleGreen;
    }

    private void TEXTdgv_Disposed(object sender, EventArgs e)
    {
      this.toolStripButton_Save.Enabled = false;
      if (Application.OpenForms["Form_Search"] == null)
        return;
      Application.OpenForms["Form_Search"].Close();
    }

    private void TEXTdgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      if (this.progressBar_Loading.Visible)
        return;
      DataGridView dataGridView = (DataGridView) sender;
      dataGridView[0, e.RowIndex].Value = (object) (uint) ((int) Convert.ToUInt32(dataGridView[0, e.RowIndex - 1].Value) + 1);
      dataGridView[1, e.RowIndex].Value = (object) 1;
      dataGridView[2, e.RowIndex].Value = (object) " ";
    }

    private void TEXTEnc(string filePath)
    {
      List<byte> byteList = new List<byte>();
      for (int index = 0; index < this.startBytes.Length; ++index)
        byteList.Add(this.startBytes[index]);
      foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(this.workingDGV.Rows.Count)))
        byteList.Add(num);
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        byte[] numArray = new byte[0];
        foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(row.Cells[0].Value)))
          byteList.Add(num);
        foreach (byte num in BitConverter.GetBytes(Convert.ToUInt32(row.Cells[1].Value)))
          byteList.Add(num);
        byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(row.Cells[2].Value.ToString());
        this.EncBlock(ref bytes, bytes.Length);
        for (int index = 0; index < bytes.Length; ++index)
          byteList.Add(bytes[index]);
        this.backgroundWorker.ReportProgress(this.workingDGV.Rows.IndexOf(row));
      }
      this.newFile = new byte[0];
      this.newFile = byteList.ToArray();
      System.IO.File.WriteAllBytes(filePath, this.newFile);
    }

    private void toolStripButton_AddRow_Click(object sender, EventArgs e)
    {
      if (!(this.s_LoadedFile != "Item_Ex700") || !(this.s_LoadedFile != "Item_Ex700Plus") || !(this.s_LoadedFile != "ItemToolTip") || this.workingDGV == null)
        return;
      this.workingDGV.Rows.Add();
    }

    private void toolStripButton_BmdItemAdder_Click(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_BmdItemAddercs"] == null)
      {
        switch (this.s_LoadedFile)
        {
          case "Item_S6E3":
            new Form_BmdItemAddercs(0).Show((IWin32Window) this);
            break;
          case "Item_Ex700":
            new Form_BmdItemAddercs(1).Show((IWin32Window) this);
            break;
          case "Item_Ex700Plus":
            new Form_BmdItemAddercs(2).Show((IWin32Window) this);
            break;
          case "Item_Season8Episode1":
            new Form_BmdItemAddercs(3).Show((IWin32Window) this);
            break;
          case "ItemToolTip":
            new Form_BmdItemAddercs(4).Show((IWin32Window) this);
            break;
          case "ItemSetType":
            new Form_BmdItemAddercs(5).Show((IWin32Window) this);
            break;
          case "ItemAddOption":
            new Form_BmdItemAddercs(6).Show((IWin32Window) this);
            break;
          case "JewelOfHarmonySmelt":
            new Form_BmdItemAddercs(7).Show((IWin32Window) this);
            break;
        }
      }
      else
        Application.OpenForms["Form_BmdItemAddercs"].Focus();
    }

    private void toolStripButton_Export_Click(object sender, EventArgs e)
    {
      switch (this.s_LoadedFile)
      {
        case "MoveReq":
          this.MoveReq_DAT_Export();
          break;
        case "Item_Ex700":
          this.ItemEx700_INI_Export();
          break;
        case "Item_Ex700Plus":
          this.ItemEx700Plus_INI_Export();
          break;
        case "Item_Season8Episode1":
          this.ItemSeason8Episode1_INI_Export();
          break;
        case "Item_S6E3":
          this.Item_S6E3_INI_Export();
          break;
        case "Gate":
          this.Gate_DAT_Export();
          break;
      }
    }

    private void toolStripButton_Open_Click(object sender, EventArgs e)
    {
      switch (this.s_LoadedFile)
      {
        case "ItemToolTip":
          this.toolStripMenuItem_ItemToolTipBMD.PerformClick();
          break;
        case "ItemAddOption":
          this.itemAddOptionbmdToolStripMenuItem.PerformClick();
          break;
        case "ItemSetType":
          this.itemSetTypebmdToolStripMenuItem.PerformClick();
          break;
        case "ItemSetOption":
          this.itemSetOptionbmdToolStripMenuItem.PerformClick();
          break;
        case "ItemToolTipText":
          this.itemToolTipTextToolStripMenuItem_Load.PerformClick();
          break;
        case "JewelOfHarmonySmelt":
          this.jewelOfHarmonySmeltbmdToolStripMenuItem.PerformClick();
          break;
        case "MoveReq":
          this.moveReqbmdEx700ToolStripMenuItem_Load.PerformClick();
          break;
        case "NpcName":
          this.ex700ToolStripMenuItem_NpcNameEx700BMD.PerformClick();
          break;
        case "NpcName_Ex700Plus":
          this.ex700ToolStripMenuItem_NpcNameEx700PlusBMD.PerformClick();
          break;
        case "Item_Ex700":
          this.ItemEx700ToolStripMenuItem_Load.PerformClick();
          break;
        case "Item_S6E3":
          this.ToolStripMenuItem_ItemS6E3_Load.PerformClick();
          break;
        case "Item_Ex700Plus":
          this.ItemEx700PlusToolStripMenuItem_Load.PerformClick();
          break;
        case "Item_Season8Episode1":
          this.season8Episode1ToolStripMenuItem.PerformClick();
          break;
        case "ServerList_Ex700":
          this.ex700ToolStripMenuItem_ServerListBMD.PerformClick();
          break;
        case "ServerList_S6E3":
          this.ToolStripMenuItem_ServerList_S6E3.PerformClick();
          break;
        case "Monster":
          this.monsterbmdToolStripMenuItem_Load.PerformClick();
          break;
        case "Glow":
          this.glowbmdToolStripMenuItem_Load.PerformClick();
          break;
        case "Text":
          this.textbmdToolStripMenuItem_Load.PerformClick();
          break;
        case "Slide":
          this.slidebmdToolStripMenuItem_Load.PerformClick();
          break;
        case "Skill_ExS8E1":
          this.skillbmdToolStripMenuItem_ExS8E1_Load.PerformClick();
          break;
        case "Skill_S6E3":
          this.skillbmdToolStripMenuItem_S6E3_Load.PerformClick();
          break;
        case "Mix":
          this.mixToolStripMenuItem_Load.PerformClick();
          break;
        case "Filter":
          this.filterbmdToolStripMenuItem_Load.PerformClick();
          break;
        case "FilterName":
          this.filterNamebmdToolStripMenuItem_Load.PerformClick();
          break;
        case "Minimap":
          this.minimapWorldXbmdToolStripMenuItem_Load.PerformClick();
          break;
        case "Gate":
          this.gatebmdToolStripMenuItem_Load.PerformClick();
          break;
      }
    }

    private void toolStripButton_RemoveSelectedRow_Click(object sender, EventArgs e)
    {
      if (!(this.s_LoadedFile != "Item_Ex700") || !(this.s_LoadedFile != "Item_Ex700Plus") || !(this.s_LoadedFile != "ItemToolTip") || this.workingDGV.CurrentRow == null)
        return;
      this.workingDGV.Rows.RemoveAt(this.workingDGV.Rows.IndexOf(this.workingDGV.CurrentRow));
    }

    private void toolStripButton_Save_Click(object sender, EventArgs e)
    {
      switch (this.s_LoadedFile)
      {
        case "ItemToolTip":
          this.ItemToolTip_Save();
          break;
        case "ItemSetType":
          this.ItemSetType_Save();
          break;
        case "ItemSetOption":
          this.ItemSetOption_Save();
          break;
        case "ItemAddOption":
          this.ItemAddOption_Save();
          break;
        case "ItemToolTipText":
          this.ItemToolTipText_Save();
          break;
        case "JewelOfHarmonySmelt":
          this.JewelOfHarmonySmelt_Save();
          break;
        case "MoveReq":
          this.MoveReq_Save();
          break;
        case "NpcName":
          this.NpcName_Save();
          break;
        case "NpcName_Ex700Plus":
          this.NpcNameEx700Plus_Save();
          break;
        case "Item_Ex700":
          this.ItemEx700_Save();
          break;
        case "Item_S6E3":
          this.Item_S6E3_Save();
          break;
        case "Item_Ex700Plus":
          this.ItemEx700Plus_Save();
          break;
        case "Item_Season8Episode1":
          this.ItemSeason8Episode1_Save();
          break;
        case "ServerList_Ex700":
          this.ServerListEx700_Save();
          break;
        case "ServerList_S6E3":
          this.ServerListS6E3_Save();
          break;
        case "Monster":
          this.Monster_Save();
          break;
        case "Glow":
          this.Glow_Save();
          break;
        case "Text":
          this.Text_Save();
          break;
        case "Slide":
          this.Slide_Save();
          break;
        case "Skill_ExS8E1":
          this.Skill_ExS8E1_Save();
          break;
        case "Skill_S6E3":
          this.Skill_S6E3_Save();
          break;
        case "Mix":
          this.Mix_Save();
          break;
        case "Filter":
          this.Filter_Save();
          break;
        case "FilterName":
          this.FilterName_Save();
          break;
        case "Minimap":
          this.Minimap_Save();
          break;
        case "Gate":
          this.Gate_Save();
          break;
      }
    }

    private void toolStripButton_SaveTXT_Click(object sender, EventArgs e)
    {
      if (this.workingDGV == null)
        return;
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.DefaultExt = ".txt";
      saveFileDialog1.AddExtension = true;
      saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
      SaveFileDialog saveFileDialog2 = saveFileDialog1;
      if (saveFileDialog2.ShowDialog() != DialogResult.OK)
        return;
      StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName)
      {
        AutoFlush = true
      };
      streamWriter.WriteLine("******** File Generated by MU.ToolKit [Silver Edition] coded by TopReal.IT ********");
      string str1 = string.Empty;
      foreach (DataGridViewColumn column in (BaseCollection) this.workingDGV.Columns)
        str1 = str1 + "\t" + column.Name;
      streamWriter.WriteLine(str1);
      foreach (DataGridViewRow row in (IEnumerable) this.workingDGV.Rows)
      {
        string str2 = string.Empty;
        for (int index = 0; index < row.Cells.Count; ++index)
          str2 = str2 + "\t" + row.Cells[index].Value;
        streamWriter.WriteLine(str2);
      }
      streamWriter.Close();
    }

    private void toolStripButton_Search_Click(object sender, EventArgs e)
    {
      if (Application.OpenForms["Form_Search"] == null)
        new Form_Search().Show((IWin32Window) this);
      else
        Application.OpenForms["Form_Search"].Focus();
    }

    private void UpdateCheck()
    {
      WebClient webClient = new WebClient();
      try
      {
        string[] strArray = Encoding.ASCII.GetString(webClient.DownloadData(this.UpdatePath)).Replace("\r", "").Split('\n');
        if (!(strArray[0].Trim('"') != this.ProductVersion))
          return;
        if (!(strArray[1].Trim('"') != this.ProductVersion))
          return;
        int num = (int) new MyDialog("v" + strArray[0].Trim('"'), strArray[2]).ShowDialog();
        Environment.Exit(0);
      }
      catch
      {
        int num = (int) MessageBox.Show("Failed to check for latest version.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        Environment.Exit(0);
      }
    }

    private void xMLNewToolStripMenuItem_Click(object sender, EventArgs e) => new EventBagEditor_XML().Show();

    public class Kernel32
    {
      [DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall)]
      public static extern bool GetEnvironmentVariable(
        string lpName,
        StringBuilder lpBuffer,
        int nSize);
    }

    internal class SendArgs
    {
      internal string filePath { get; set; }

      internal string fileType { get; set; }
    }
  }
}
