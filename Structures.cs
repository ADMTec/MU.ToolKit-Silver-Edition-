// Decompiled with JetBrains decompiler
// Type: MU_ToolKit.Structures
// Assembly: MU.ToolKit [Silver Edition], Version=0.0.0.0, Culture=neutral, PublicKeyToken=b4bcea52f57bccfa
// MVID: FBED834D-5939-4C20-BA60-B9A96F9EF947
// Assembly location: C:\Users\Rafael Mazzoni\Downloads\Modelos e Texturas\Projeto\ToolKit\ToolKit\MU.ToolKit [Silver Edition].exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MU_ToolKit
{
  public class Structures
  {
    private bool CheckAndFixLine(string theLine, out string[] fixedLine)
    {
      string str1 = theLine.Replace(" ", string.Empty).Replace("\t", string.Empty);
      if (!str1.StartsWith("/") && !str1.StartsWith("end") && str1.Length > 0)
      {
        List<string> stringList = new List<string>();
        string str2 = theLine;
        int num = 0;
        List<int> intList = new List<int>();
        foreach (char ch in theLine)
        {
          if (ch == '"')
            intList.Add(num);
          ++num;
        }
        for (int index = 0; index < intList.Count; index += 2)
        {
          try
          {
            string oldValue = theLine.Substring(intList[index], intList[index + 1] - intList[index]);
            string newValue = oldValue.Replace("\t", " ").Replace(" ", "^");
            str2 = str2.Replace(oldValue, newValue);
          }
          catch
          {
          }
        }
        string[] strArray = str2.Replace(" ", "\t").Split('\t');
        for (int index = 0; index < strArray.Length; ++index)
        {
          if (strArray[index].Replace(" ", string.Empty).Length > 0)
            stringList.Add(strArray[index].Replace("^", " "));
        }
        fixedLine = stringList.ToArray();
        return true;
      }
      fixedLine = (string[]) null;
      return false;
    }

    public string[] FixLine(string theLine)
    {
      string empty = string.Empty;
      string str1 = theLine;
      string[] strArray1 = theLine.Split('"');
      if (strArray1.Length == 3)
      {
        string str2 = strArray1[0];
        string str3 = strArray1[1];
        string str4 = strArray1[2];
        string str5 = str3.Replace('\t', ' ').Replace(' ', '$');
        str1 = str2 + str5 + str4;
      }
      string[] strArray2 = str1.Replace(' ', '\t').Split('\t');
      List<string> stringList = new List<string>();
      foreach (string str6 in strArray2)
      {
        if (str6.Length > 0)
          stringList.Add(str6);
      }
      return stringList.ToArray();
    }

    public void initMapList(ref ComboBox lb, ref List<Structures.Map> mMapList)
    {
      Structures.Map map = new Structures.Map()
      {
        MapCode = 0,
        MapName = "Lorencia"
      };
      mMapList.Add(map);
      map.MapCode = 1;
      map.MapName = "Dungeon";
      mMapList.Add(map);
      map.MapCode = 2;
      map.MapName = "Devias";
      mMapList.Add(map);
      map.MapCode = 3;
      map.MapName = "Noria";
      mMapList.Add(map);
      map.MapCode = 4;
      map.MapName = "Lost Tower";
      mMapList.Add(map);
      map.MapCode = 6;
      map.MapName = "Arena";
      mMapList.Add(map);
      map.MapCode = 7;
      map.MapName = "Atlans";
      mMapList.Add(map);
      map.MapCode = 8;
      map.MapName = "Tarkan";
      mMapList.Add(map);
      map.MapCode = 9;
      map.MapName = "Devil Square 1 - 4";
      mMapList.Add(map);
      map.MapCode = 32;
      map.MapName = "Devil Square 5 - 8";
      mMapList.Add(map);
      map.MapCode = 10;
      map.MapName = "Icarus";
      mMapList.Add(map);
      map.MapCode = 11;
      map.MapName = "Blood Castle 1";
      mMapList.Add(map);
      map.MapCode = 12;
      map.MapName = "Blood Castle 2";
      mMapList.Add(map);
      map.MapCode = 13;
      map.MapName = "Blood Castle 3";
      mMapList.Add(map);
      map.MapCode = 14;
      map.MapName = "Blood Castle 4";
      mMapList.Add(map);
      map.MapCode = 15;
      map.MapName = "Blood Castle 5";
      mMapList.Add(map);
      map.MapCode = 16;
      map.MapName = "Blood Castle 6";
      mMapList.Add(map);
      map.MapCode = 17;
      map.MapName = "Blood Castle 7";
      mMapList.Add(map);
      map.MapCode = 18;
      map.MapName = "Chaos Castle 1";
      mMapList.Add(map);
      map.MapCode = 19;
      map.MapName = "Chaos Castle 2";
      mMapList.Add(map);
      map.MapCode = 20;
      map.MapName = "Chaos Castle 3";
      mMapList.Add(map);
      map.MapCode = 21;
      map.MapName = "Chaos Castle 4";
      mMapList.Add(map);
      map.MapCode = 22;
      map.MapName = "Chaos Castle 5";
      mMapList.Add(map);
      map.MapCode = 23;
      map.MapName = "Chaos Castle 6";
      mMapList.Add(map);
      map.MapCode = 24;
      map.MapName = "Kalima 1";
      mMapList.Add(map);
      map.MapCode = 25;
      map.MapName = "Kalima 2";
      mMapList.Add(map);
      map.MapCode = 26;
      map.MapName = "Kalima 3";
      mMapList.Add(map);
      map.MapCode = 27;
      map.MapName = "Kalima 4";
      mMapList.Add(map);
      map.MapCode = 28;
      map.MapName = "Kalima 5";
      mMapList.Add(map);
      map.MapCode = 29;
      map.MapName = "Kalima 6";
      mMapList.Add(map);
      map.MapCode = 36;
      map.MapName = "Kalima 7";
      mMapList.Add(map);
      map.MapCode = 30;
      map.MapName = "Valley Of Loren";
      mMapList.Add(map);
      map.MapCode = 31;
      map.MapName = "Lands Of Trial";
      mMapList.Add(map);
      map.MapCode = 33;
      map.MapName = "Aida";
      mMapList.Add(map);
      map.MapCode = 34;
      map.MapName = "Cry Wolf";
      mMapList.Add(map);
      map.MapCode = 37;
      map.MapName = "Kantru";
      mMapList.Add(map);
      map.MapCode = 38;
      map.MapName = "Kantru Ruins";
      mMapList.Add(map);
      map.MapCode = 39;
      map.MapName = "Refinery Tower";
      mMapList.Add(map);
      map.MapCode = 40;
      map.MapName = "Silent Map";
      mMapList.Add(map);
      map.MapCode = 41;
      map.MapName = "Balgas Barracks";
      mMapList.Add(map);
      map.MapCode = 42;
      map.MapName = "Balgas Refuge";
      mMapList.Add(map);
      map.MapCode = 46;
      map.MapName = "Illusion Temple 1";
      mMapList.Add(map);
      map.MapCode = 47;
      map.MapName = "Illusion Temple 2";
      mMapList.Add(map);
      map.MapCode = 48;
      map.MapName = "Illusion Temple 3";
      mMapList.Add(map);
      map.MapCode = 49;
      map.MapName = "Illusion Temple 4";
      mMapList.Add(map);
      map.MapCode = 50;
      map.MapName = "Illusion Temple 5";
      mMapList.Add(map);
      map.MapCode = 51;
      map.MapName = "Elbeland";
      mMapList.Add(map);
      map.MapCode = 56;
      map.MapName = "Swamp Of Calmness";
      mMapList.Add(map);
      map.MapCode = 57;
      map.MapName = "Raklion";
      mMapList.Add(map);
      map.MapCode = 58;
      map.MapName = "Hatchery";
      mMapList.Add(map);
      map.MapCode = 62;
      map.MapName = "Santa Village";
      mMapList.Add(map);
      map.MapCode = 63;
      map.MapName = "Vulcanus";
      mMapList.Add(map);
      map.MapCode = 64;
      map.MapName = "Duel Arena";
      mMapList.Add(map);
      map.MapCode = 65;
      map.MapName = "DoppleGanger Snow";
      mMapList.Add(map);
      map.MapCode = 66;
      map.MapName = "DoppleGanger Volcan";
      mMapList.Add(map);
      map.MapCode = 67;
      map.MapName = "DoppleGanger Sea";
      mMapList.Add(map);
      map.MapCode = 68;
      map.MapName = "DoppleGanger Crystals";
      mMapList.Add(map);
      map.MapCode = 69;
      map.MapName = "Imperial Fortress 1";
      mMapList.Add(map);
      map.MapCode = 70;
      map.MapName = "Imperial Fortress 2";
      mMapList.Add(map);
      map.MapCode = 71;
      map.MapName = "Imperial Fortress 3";
      mMapList.Add(map);
      map.MapCode = 72;
      map.MapName = "Imperial Fortress 4";
      mMapList.Add(map);
      map.MapCode = 79;
      map.MapName = "Loren Market";
      mMapList.Add(map);
      map.MapCode = 80;
      map.MapName = "Karutan 1";
      mMapList.Add(map);
      map.MapCode = 81;
      map.MapName = "Karutan 2";
      mMapList.Add(map);
      map.MapCode = 91;
      map.MapName = "Acheron";
      mMapList.Add(map);
      map.MapCode = 92;
      map.MapName = "Arca War";
      mMapList.Add(map);
      map.MapCode = 93;
      map.MapName = "New Map 93";
      mMapList.Add(map);
      map.MapCode = 94;
      map.MapName = "New Map 94";
      mMapList.Add(map);
      lb.DataSource = (object) mMapList;
      lb.ValueMember = "MapCode";
      lb.DisplayMember = "MapName";
    }

    public void initMapListBox(ref ListBox lb)
    {
      Structures.Map map = new Structures.Map();
      List<Structures.Map> mapList = new List<Structures.Map>();
      map.MapCode = 0;
      map.MapName = "Lorencia";
      mapList.Add(map);
      map.MapCode = 1;
      map.MapName = "Dungeon";
      mapList.Add(map);
      map.MapCode = 2;
      map.MapName = "Devias";
      mapList.Add(map);
      map.MapCode = 3;
      map.MapName = "Noria";
      mapList.Add(map);
      map.MapCode = 4;
      map.MapName = "Lost Tower";
      mapList.Add(map);
      map.MapCode = 6;
      map.MapName = "Arena";
      mapList.Add(map);
      map.MapCode = 7;
      map.MapName = "Atlans";
      mapList.Add(map);
      map.MapCode = 8;
      map.MapName = "Tarkan";
      mapList.Add(map);
      map.MapCode = 9;
      map.MapName = "Devil Square 1 - 4";
      mapList.Add(map);
      map.MapCode = 32;
      map.MapName = "Devil Square 5 - 8";
      mapList.Add(map);
      map.MapCode = 10;
      map.MapName = "Icarus";
      mapList.Add(map);
      map.MapCode = 11;
      map.MapName = "Blood Castle 1";
      mapList.Add(map);
      map.MapCode = 12;
      map.MapName = "Blood Castle 2";
      mapList.Add(map);
      map.MapCode = 13;
      map.MapName = "Blood Castle 3";
      mapList.Add(map);
      map.MapCode = 14;
      map.MapName = "Blood Castle 4";
      mapList.Add(map);
      map.MapCode = 15;
      map.MapName = "Blood Castle 5";
      mapList.Add(map);
      map.MapCode = 16;
      map.MapName = "Blood Castle 6";
      mapList.Add(map);
      map.MapCode = 17;
      map.MapName = "Blood Castle 7";
      mapList.Add(map);
      map.MapCode = 18;
      map.MapName = "Chaos Castle 1";
      mapList.Add(map);
      map.MapCode = 19;
      map.MapName = "Chaos Castle 2";
      mapList.Add(map);
      map.MapCode = 20;
      map.MapName = "Chaos Castle 3";
      mapList.Add(map);
      map.MapCode = 21;
      map.MapName = "Chaos Castle 4";
      mapList.Add(map);
      map.MapCode = 22;
      map.MapName = "Chaos Castle 5";
      mapList.Add(map);
      map.MapCode = 23;
      map.MapName = "Chaos Castle 6";
      mapList.Add(map);
      map.MapCode = 24;
      map.MapName = "Kalima 1";
      mapList.Add(map);
      map.MapCode = 25;
      map.MapName = "Kalima 2";
      mapList.Add(map);
      map.MapCode = 26;
      map.MapName = "Kalima 3";
      mapList.Add(map);
      map.MapCode = 27;
      map.MapName = "Kalima 4";
      mapList.Add(map);
      map.MapCode = 28;
      map.MapName = "Kalima 5";
      mapList.Add(map);
      map.MapCode = 29;
      map.MapName = "Kalima 6";
      mapList.Add(map);
      map.MapCode = 36;
      map.MapName = "Kalima 7";
      mapList.Add(map);
      map.MapCode = 30;
      map.MapName = "Valley Of Loren";
      mapList.Add(map);
      map.MapCode = 31;
      map.MapName = "Lands Of Trial";
      mapList.Add(map);
      map.MapCode = 33;
      map.MapName = "Aida";
      mapList.Add(map);
      map.MapCode = 34;
      map.MapName = "Cry Wolf";
      mapList.Add(map);
      map.MapCode = 37;
      map.MapName = "Kantru";
      mapList.Add(map);
      map.MapCode = 38;
      map.MapName = "Kantru Ruins";
      mapList.Add(map);
      map.MapCode = 39;
      map.MapName = "Refinery Tower";
      mapList.Add(map);
      map.MapCode = 40;
      map.MapName = "Silent Map";
      mapList.Add(map);
      map.MapCode = 41;
      map.MapName = "Balgas Barracks";
      mapList.Add(map);
      map.MapCode = 42;
      map.MapName = "Balgas Refuge";
      mapList.Add(map);
      map.MapCode = 46;
      map.MapName = "Illusion Temple 1";
      mapList.Add(map);
      map.MapCode = 47;
      map.MapName = "Illusion Temple 2";
      mapList.Add(map);
      map.MapCode = 48;
      map.MapName = "Illusion Temple 3";
      mapList.Add(map);
      map.MapCode = 49;
      map.MapName = "Illusion Temple 4";
      mapList.Add(map);
      map.MapCode = 50;
      map.MapName = "Illusion Temple 5";
      mapList.Add(map);
      map.MapCode = 51;
      map.MapName = "Elbeland";
      mapList.Add(map);
      map.MapCode = 56;
      map.MapName = "Swamp Of Calmness";
      mapList.Add(map);
      map.MapCode = 57;
      map.MapName = "Raklion";
      mapList.Add(map);
      map.MapCode = 58;
      map.MapName = "Hatchery";
      mapList.Add(map);
      map.MapCode = 62;
      map.MapName = "Santa Village";
      mapList.Add(map);
      map.MapCode = 63;
      map.MapName = "Vulcanus";
      mapList.Add(map);
      map.MapCode = 64;
      map.MapName = "Duel Arena";
      mapList.Add(map);
      map.MapCode = 65;
      map.MapName = "DoppleGanger Snow";
      mapList.Add(map);
      map.MapCode = 66;
      map.MapName = "DoppleGanger Volcan";
      mapList.Add(map);
      map.MapCode = 67;
      map.MapName = "DoppleGanger Sea";
      mapList.Add(map);
      map.MapCode = 68;
      map.MapName = "DoppleGanger Crystals";
      mapList.Add(map);
      map.MapCode = 69;
      map.MapName = "Imperial Fortress 1";
      mapList.Add(map);
      map.MapCode = 70;
      map.MapName = "Imperial Fortress 2";
      mapList.Add(map);
      map.MapCode = 71;
      map.MapName = "Imperial Fortress 3";
      mapList.Add(map);
      map.MapCode = 72;
      map.MapName = "Imperial Fortress 4";
      mapList.Add(map);
      map.MapCode = 79;
      map.MapName = "Loren Market";
      mapList.Add(map);
      map.MapCode = 80;
      map.MapName = "Karutan 1";
      mapList.Add(map);
      map.MapCode = 81;
      map.MapName = "Karutan 2";
      mapList.Add(map);
      map.MapCode = 91;
      map.MapName = "Acheron";
      mapList.Add(map);
      map.MapCode = 92;
      map.MapName = "Arca War";
      mapList.Add(map);
      map.MapCode = 93;
      map.MapName = "New Map 93";
      mapList.Add(map);
      map.MapCode = 94;
      map.MapName = "New Map 94";
      mapList.Add(map);
      lb.DataSource = (object) mapList;
      lb.ValueMember = "MapCode";
      lb.DisplayMember = "MapName";
    }

    public void initMapListBox(ref ListBox lb, ref string[] MapName)
    {
      Structures.Map map = new Structures.Map();
      List<Structures.Map> mapList = new List<Structures.Map>();
      map.MapCode = 0;
      map.MapName = "Lorencia";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 1;
      map.MapName = "Dungeon";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 2;
      map.MapName = "Devias";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 3;
      map.MapName = "Noria";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 4;
      map.MapName = "Lost Tower";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 6;
      map.MapName = "Arena";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 7;
      map.MapName = "Atlans";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 8;
      map.MapName = "Tarkan";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 9;
      map.MapName = "Devil Square 1 - 4";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 32;
      map.MapName = "Devil Square 5 - 8";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 10;
      map.MapName = "Icarus";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 11;
      map.MapName = "Blood Castle 1";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 12;
      map.MapName = "Blood Castle 2";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 13;
      map.MapName = "Blood Castle 3";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 14;
      map.MapName = "Blood Castle 4";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 15;
      map.MapName = "Blood Castle 5";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 16;
      map.MapName = "Blood Castle 6";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 17;
      map.MapName = "Blood Castle 7";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 18;
      map.MapName = "Chaos Castle 1";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 19;
      map.MapName = "Chaos Castle 2";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 20;
      map.MapName = "Chaos Castle 3";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 21;
      map.MapName = "Chaos Castle 4";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 22;
      map.MapName = "Chaos Castle 5";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 23;
      map.MapName = "Chaos Castle 6";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 24;
      map.MapName = "Kalima 1";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 25;
      map.MapName = "Kalima 2";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 26;
      map.MapName = "Kalima 3";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 27;
      map.MapName = "Kalima 4";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 28;
      map.MapName = "Kalima 5";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 29;
      map.MapName = "Kalima 6";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 36;
      map.MapName = "Kalima 7";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 30;
      map.MapName = "Valley Of Loren";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 31;
      map.MapName = "Lands Of Trial";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 33;
      map.MapName = "Aida";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 34;
      map.MapName = "Cry Wolf";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 37;
      map.MapName = "Kantru";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 38;
      map.MapName = "Kantru Ruins";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 39;
      map.MapName = "Refinery Tower";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 40;
      map.MapName = "Silent Map";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 41;
      map.MapName = "Balgas Barracks";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 42;
      map.MapName = "Balgas Refuge";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 46;
      map.MapName = "Illusion Temple 1";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 47;
      map.MapName = "Illusion Temple 2";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 48;
      map.MapName = "Illusion Temple 3";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 49;
      map.MapName = "Illusion Temple 4";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 50;
      map.MapName = "Illusion Temple 5";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 51;
      map.MapName = "Elbeland";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 56;
      map.MapName = "Swamp Of Calmness";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 57;
      map.MapName = "Raklion";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 58;
      map.MapName = "Hatchery";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 62;
      map.MapName = "Santa Village";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 63;
      map.MapName = "Vulcanus";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 64;
      map.MapName = "Duel Arena";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 65;
      map.MapName = "DoppleGanger Snow";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 66;
      map.MapName = "DoppleGanger Volcan";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 67;
      map.MapName = "DoppleGanger Sea";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 68;
      map.MapName = "DoppleGanger Crystals";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 69;
      map.MapName = "Imperial Fortress 1";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 70;
      map.MapName = "Imperial Fortress 2";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 71;
      map.MapName = "Imperial Fortress 3";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 72;
      map.MapName = "Imperial Fortress 4";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 79;
      map.MapName = "Loren Market";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 80;
      map.MapName = "Karutan 1";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 81;
      map.MapName = "Karutan 2";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 91;
      map.MapName = "Acheron";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 92;
      map.MapName = "Arca War";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 93;
      map.MapName = "New Map 93";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      map.MapCode = 94;
      map.MapName = "New Map 94";
      MapName[map.MapCode] = map.MapName;
      mapList.Add(map);
      lb.DataSource = (object) mapList;
      lb.ValueMember = "MapCode";
      lb.DisplayMember = nameof (MapName);
    }

    public void ReadEventBagFile(
      string fLocation,
      ref BindingList<Structures.EventBagMap> mapList,
      ref Structures.EventBagDrop drop,
      ref BindingList<Structures.EventBagItem> BagItems,
      string[,] ItemName,
      string[] MapName)
    {
      string[] strArray1 = File.ReadAllLines(fLocation);
      int num1 = 0;
      foreach (string str1 in strArray1)
      {
        if (!str1.ToLower().Replace("\t", "").Trim().StartsWith("end") & !str1.ToUpper().Replace("\t", "").Trim().StartsWith("/") & str1.ToUpper().Replace("\t", "").Trim().Length != 0)
        {
          if (str1.ToUpper().Replace("\t", "").Trim().Length > 1)
          {
            string empty = string.Empty;
            string str2 = str1;
            string[] strArray2 = str1.Split('"');
            if (strArray2.Length == 3)
            {
              strArray2[1] = strArray2[1].Replace("\t", " ").Replace(" ", "$");
              str2 = strArray2[0] + strArray2[1] + strArray2[2];
            }
            string[] strArray3 = str2.Replace(" ", "\t").Split('\t');
            List<string> stringList = new List<string>();
            for (int index = 0; index < strArray3.Length; ++index)
            {
              if (strArray3[index].Trim().Length != 0)
                stringList.Add(strArray3[index]);
            }
            string[] array = stringList.ToArray();
            switch (num1)
            {
              case 0:
                if (array.Length < 4)
                {
                  int num2 = (int) MessageBox.Show("\tInvalid line", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                  return;
                }
                Structures.EventBagMap eventBagMap = new Structures.EventBagMap()
                {
                  ID = Convert.ToInt32(array[0]),
                  Drop = Convert.ToBoolean(Convert.ToInt32(array[1])),
                  MobMinLvl = Convert.ToInt32(array[2]),
                  MobMaxLvl = Convert.ToInt32(array[3])
                };
                eventBagMap.Name = MapName[eventBagMap.ID];
                mapList.Add(eventBagMap);
                continue;
              case 1:
                if (array.Length < 8)
                {
                  int num3 = (int) MessageBox.Show("\tInvalid line", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                  return;
                }
                drop.Name = array[0].Replace("\"", "");
                drop.Zen = Convert.ToInt32(array[1]);
                drop.BagGroup = Convert.ToInt32(array[2]);
                drop.BagIndex = Convert.ToInt32(array[3]);
                drop.BagLevel = Convert.ToInt32(array[4]);
                drop.BagDropRate = (double) Convert.ToInt32(array[5]);
                drop.ItemDropRate = (double) Convert.ToInt32(array[6]);
                drop.ExcDropRate = (double) Convert.ToInt32(array[7]);
                continue;
              case 2:
                if (array.Length < 8)
                {
                  int num4 = (int) MessageBox.Show("\tInvalid line", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                  return;
                }
                Structures.EventBagItem eventBagItem = new Structures.EventBagItem()
                {
                  Group = Convert.ToInt32(array[0]),
                  Index = Convert.ToInt32(array[1]),
                  MinLevel = Convert.ToInt32(array[2]),
                  MaxLevel = Convert.ToInt32(array[3]),
                  Skill = Convert.ToBoolean(Convert.ToInt32(array[4])),
                  Luck = Convert.ToBoolean(Convert.ToInt32(array[5])),
                  Option = Convert.ToBoolean(Convert.ToInt32(array[6])),
                  Excellent = Convert.ToBoolean(Convert.ToInt32(array[7]))
                };
                eventBagItem.Name = ItemName[eventBagItem.Group, eventBagItem.Index];
                BagItems.Add(eventBagItem);
                continue;
              default:
                continue;
            }
          }
          else
            num1 = (int) Convert.ToInt16(str1);
        }
      }
    }

    public void ReadItemList(
      string fLocation,
      bool isEx700ItemList,
      ref List<Structures.c_Groups> L_Groups,
      ref List<Structures.UniItem> L_Swords,
      ref List<Structures.UniItem> L_Axes,
      ref List<Structures.UniItem> L_MacesScepters,
      ref List<Structures.UniItem> L_Spears,
      ref List<Structures.UniItem> L_BowsCrossBows,
      ref List<Structures.UniItem> L_Staffs,
      ref List<Structures.UniItem> L_Shields,
      ref List<Structures.UniItem> L_Helms,
      ref List<Structures.UniItem> L_Armors,
      ref List<Structures.UniItem> L_Pants,
      ref List<Structures.UniItem> L_Gloves,
      ref List<Structures.UniItem> L_Boots,
      ref List<Structures.UniItem> L_WingsSkillsSeedsOther,
      ref List<Structures.UniItem> L_Others1,
      ref List<Structures.UniItem> L_Others2,
      ref List<Structures.UniItem> L_Scrolls,
      ref string[,] ItemName,
      ref string[,] ItemSize)
    {
      try
      {
        int num = 0;
        foreach (string readAllLine in File.ReadAllLines(fLocation))
        {
          string[] fixedLine;
          if (this.CheckAndFixLine(readAllLine, out fixedLine))
          {
            if (fixedLine.Length == 1)
            {
              num = Convert.ToInt32(fixedLine[0]);
              switch (num)
              {
                case 0:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Swords"));
                  num = 0;
                  continue;
                case 1:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Axes"));
                  num = 1;
                  continue;
                case 2:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Maces/Scepters"));
                  num = 2;
                  continue;
                case 3:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Spears"));
                  num = 3;
                  continue;
                case 4:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Bow/CrossBow"));
                  num = 4;
                  continue;
                case 5:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Staffs"));
                  num = 5;
                  continue;
                case 6:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Shield"));
                  num = 6;
                  continue;
                case 7:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Helms"));
                  num = 7;
                  continue;
                case 8:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Armors"));
                  num = 8;
                  continue;
                case 9:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Pants"));
                  num = 9;
                  continue;
                case 10:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Gloves"));
                  num = 10;
                  continue;
                case 11:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Boots"));
                  num = 11;
                  continue;
                case 12:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Wings/Orbs/Spheres"));
                  num = 12;
                  continue;
                case 13:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Pets/Rings/Etc"));
                  num = 13;
                  continue;
                case 14:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Jewels/Misc"));
                  num = 14;
                  continue;
                case 15:
                  L_Groups.Add(new Structures.c_Groups(num.ToString(), "Scrolls"));
                  num = 15;
                  continue;
                default:
                  continue;
              }
            }
            else
            {
              int index = 0;
              if (isEx700ItemList)
                index = 3;
              string[] strArray = fixedLine;
              Structures.UniItem uniItem = new Structures.UniItem()
              {
                Group = num,
                Index = Convert.ToInt32(strArray[index]),
                Slot = Convert.ToInt32(strArray[index + 1]),
                Skill = Convert.ToInt32(strArray[index + 2]),
                X = Convert.ToInt32(strArray[index + 3]),
                Y = Convert.ToInt32(strArray[index + 4]),
                Option = Convert.ToInt32(strArray[index + 6]),
                Name = strArray[index + 8].Replace("\"", string.Empty)
              };
              switch (num)
              {
                case 0:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 13]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 22]);
                  L_Swords.Add(uniItem);
                  break;
                case 1:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 13]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 22]);
                  L_Axes.Add(uniItem);
                  break;
                case 2:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 13]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 22]);
                  L_MacesScepters.Add(uniItem);
                  break;
                case 3:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 13]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 22]);
                  L_Spears.Add(uniItem);
                  break;
                case 4:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 13]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 22]);
                  L_BowsCrossBows.Add(uniItem);
                  break;
                case 5:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 13]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 22]);
                  L_Staffs.Add(uniItem);
                  break;
                case 6:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 12]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 19]);
                  L_Shields.Add(uniItem);
                  break;
                case 7:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 12]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 19]);
                  L_Helms.Add(uniItem);
                  break;
                case 8:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 12]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 19]);
                  L_Armors.Add(uniItem);
                  break;
                case 9:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 12]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 19]);
                  L_Pants.Add(uniItem);
                  break;
                case 10:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 12]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 19]);
                  L_Gloves.Add(uniItem);
                  break;
                case 11:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 12]);
                  uniItem.Ancient = (int) Convert.ToInt16(strArray[index + 19]);
                  L_Boots.Add(uniItem);
                  break;
                case 12:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 12]);
                  uniItem.Ancient = 0;
                  L_WingsSkillsSeedsOther.Add(uniItem);
                  break;
                case 13:
                  uniItem.Durability = (int) Convert.ToInt16(strArray[index + 11]);
                  uniItem.Ancient = 0;
                  L_Others1.Add(uniItem);
                  break;
                case 14:
                  uniItem.Durability = 0;
                  uniItem.Ancient = 0;
                  L_Others2.Add(uniItem);
                  break;
                case 15:
                  uniItem.Durability = 0;
                  uniItem.Ancient = 0;
                  L_Scrolls.Add(uniItem);
                  break;
              }
              if (ItemName != null)
                ItemName[uniItem.Group, uniItem.Index] = uniItem.Name;
              if (ItemSize != null)
                ItemSize[uniItem.Group, uniItem.Index] = uniItem.X.ToString() + "x" + (object) uniItem.Y;
            }
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "[ReadItemList] ERROR");
        Application.Exit();
      }
    }

    public void ReadXMLEventBagFile(
      string fLocation,
      ref Structures.EventBagDrop drop,
      ref BindingList<Structures.EventBagItem> BagItems,
      string[,] ItemName)
    {
      foreach (XElement element in XDocument.Load(fLocation).Root.Elements())
      {
        switch (element.Name.LocalName)
        {
          case "Bag":
            using (IEnumerator<XElement> enumerator = element.Elements().GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                foreach (XAttribute attribute in enumerator.Current.Attributes())
                {
                  switch (attribute.Name.LocalName)
                  {
                    case "Name":
                      drop.Name = attribute.Value;
                      continue;
                    case "ZenDrop":
                      drop.Zen = Convert.ToInt32(attribute.Value);
                      continue;
                    case "ItemRate":
                      drop.ItemDropRate = Convert.ToDouble(attribute.Value);
                      continue;
                    case "ExcRate":
                      drop.ExcDropRate = Convert.ToDouble(attribute.Value);
                      continue;
                    case "AncientRate":
                      drop.AncDropRate = Convert.ToDouble(attribute.Value);
                      continue;
                    case "SocketRate":
                      drop.SocketDropRate = Convert.ToDouble(attribute.Value);
                      continue;
                    default:
                      continue;
                  }
                }
              }
              continue;
            }
          case "Default":
            using (IEnumerator<XElement> enumerator = element.Elements().GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                XElement current = enumerator.Current;
                drop.Default_Cat = Convert.ToInt32(current.Attribute((XName) "cat").Value);
                drop.Default_ID = Convert.ToInt32(current.Attribute((XName) "id").Value);
                drop.Default_minlv = Convert.ToInt32(current.Attribute((XName) "minlv").Value);
                drop.Default_maxlv = Convert.ToInt32(current.Attribute((XName) "maxlv").Value);
                drop.Default_skill = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "skill").Value));
                drop.Default_luck = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "luck").Value));
                drop.Default_addopt = Convert.ToInt32(current.Attribute((XName) "addopt").Value);
                drop.Default_exc = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "exc").Value));
                drop.Default_anc = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "anc").Value));
                drop.Default_sock = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "sock").Value));
              }
              continue;
            }
          case "Items":
            using (IEnumerator<XElement> enumerator = element.Elements().GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                XElement current = enumerator.Current;
                Structures.EventBagItem eventBagItem = new Structures.EventBagItem()
                {
                  Group = Convert.ToInt32(current.Attribute((XName) "cat").Value),
                  Index = Convert.ToInt32(current.Attribute((XName) "id").Value),
                  MinLevel = Convert.ToInt32(current.Attribute((XName) "minlv").Value),
                  MaxLevel = Convert.ToInt32(current.Attribute((XName) "maxlv").Value),
                  Skill = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "skill").Value)),
                  Luck = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "luck").Value)),
                  new_MaxOption = Convert.ToInt32(current.Attribute((XName) "addopt").Value),
                  Excellent = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "exc").Value)),
                  Ancient = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "anc").Value)),
                  Socket = Convert.ToBoolean(Convert.ToInt32(current.Attribute((XName) "sock").Value))
                };
                eventBagItem.Name = ItemName[eventBagItem.Group, eventBagItem.Index];
                BagItems.Add(eventBagItem);
              }
              continue;
            }
          default:
            continue;
        }
      }
    }

    public void Setc_LevelData(ref List<Structures.c_LevelData> c_LevelDatas)
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
    }

    public void Setc_OptionData(ref List<Structures.c_OptionData> c_OptionDatas)
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
    }

    public class c_AncientData
    {
      private int _ID;
      private string _Name;

      public int ID
      {
        get => this._ID;
        set => this._ID = value;
      }

      public string Name
      {
        get => this._Name;
        set => this._Name = value;
      }
    }

    public class c_Groups
    {
      public int _GroupID;
      public string _GroupName;

      public c_Groups(string GroupID, string GroupName)
      {
        int result = -1;
        int.TryParse(GroupID, out result);
        this._GroupID = result;
        this._GroupName = GroupName;
      }

      public int Group
      {
        get => this._GroupID;
        set => this._GroupID = value;
      }

      public string GroupName
      {
        get => this._GroupName;
        set => this._GroupName = value;
      }
    }

    public class c_LevelData
    {
      public int _LevelID;
      public string _LevelName;

      public c_LevelData(int ID, string Name)
      {
        this._LevelID = ID;
        this._LevelName = Name;
      }

      public int ID
      {
        get => this._LevelID;
        set => this._LevelID = value;
      }

      public string Name
      {
        get => this._LevelName;
        set => this._LevelName = value;
      }
    }

    public struct c_OptionData
    {
      public int ID { get; set; }

      public string Name { get; set; }
    }

    public class CustomPictureBox : PictureBox
    {
      private int _MSBType;
      private Color colorBorder = Color.Transparent;

      public CustomPictureBox() => this.SetStyle(ControlStyles.UserPaint, true);

      protected override void OnPaint(PaintEventArgs e)
      {
        base.OnPaint(e);
        e.Graphics.DrawRectangle(new Pen((Brush) new SolidBrush(this.colorBorder), 4f), e.ClipRectangle);
      }

      public Color BorderColor
      {
        get => this.colorBorder;
        set => this.colorBorder = value;
      }

      public int MSBType
      {
        get => this._MSBType;
        set => this._MSBType = value;
      }
    }

    public class CustomToolTip : ToolTip
    {
      private int _sizeX = 230;
      private int _sizeY = 140;

      public CustomToolTip()
      {
        this.OwnerDraw = true;
        this.Popup += new PopupEventHandler(this.OnPopup);
        this.Draw += new DrawToolTipEventHandler(this.OnDraw);
      }

      private void OnDraw(object sender, DrawToolTipEventArgs e)
      {
        Graphics graphics = e.Graphics;
        LinearGradientBrush linearGradientBrush = new LinearGradientBrush(e.Bounds, Color.Silver, Color.Goldenrod, 50f);
        graphics.FillRectangle((Brush) linearGradientBrush, e.Bounds);
        graphics.DrawRectangle(new Pen(Brushes.Azure, 1f), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
        graphics.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.Silver, new PointF((float) (e.Bounds.X + 6), (float) (e.Bounds.Y + 6)));
        graphics.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.Black, new PointF((float) (e.Bounds.X + 5), (float) (e.Bounds.Y + 5)));
        linearGradientBrush.Dispose();
      }

      private void OnPopup(object sender, PopupEventArgs e) => e.ToolTipSize = new Size(this._sizeX, this._sizeY);

      public int sizeX
      {
        get => this._sizeX;
        set => this._sizeX = value;
      }

      public int sizeY
      {
        get => this._sizeY;
        set => this._sizeY = value;
      }
    }

    public struct EventBagDrop
    {
      public string Name;
      public int Zen;
      public int BagGroup;
      public int BagIndex;
      public int BagLevel;
      public double BagDropRate;
      public double ItemDropRate;
      public double ExcDropRate;
      public double AncDropRate;
      public double SocketDropRate;
      public int Default_Cat;
      public int Default_ID;
      public int Default_minlv;
      public int Default_maxlv;
      public bool Default_skill;
      public bool Default_luck;
      public int Default_addopt;
      public bool Default_exc;
      public bool Default_anc;
      public bool Default_sock;
    }

    public struct EventBagItem
    {
      public int Index;
      public int Group;
      public int MaxLevel;
      public int MinLevel;
      public bool Skill;
      public bool Option;
      public bool Luck;
      public bool Excellent;
      public bool Ancient;
      public bool Socket;

      public string Name { get; set; }

      public int new_MaxOption { get; set; }
    }

    public struct EventBagMap
    {
      public bool Drop;
      public int MobMinLvl;
      public int MobMaxLvl;

      public string Name { get; set; }

      public int ID { get; set; }
    }

    public struct IBSCategory
    {
      public int Index;
      public string Name;
      public short Unk1;
      public short Unk2;
      public int HeadCatIndex;
      public short Seq;
      public bool IsHeadCat;
      public int TraceNumber;
      public string TraceString;
    }

    public struct IBSPackage
    {
      public short CatIndex;
      public short Seq;
      public short Index;
      public short Unk1;
      public int Price;
      public string Info;
      public string Empty;
      public short Unk2;
      public short Unk3;
      public string Unk4;
      public string Unk5;
      public short Unk6;
      public short RewardCount;
      public string CoinTxt1;
      public string CoinTxt2;
      public short Unk7;
      public short Unk8;
      public short Unk9;
      public string ProductRewardIndex1;
      public int ItemID;
      public short Unk10;
      public short CheckBoxCount;
      public string ProductRewardIndexes7;
      public string Unk11;
      public int ServerCatIndex;
      public int Const669;
      public int TraceNumber;
      public string TraceString;

      public string Name { get; set; }
    }

    public struct IBSProduct
    {
      public int Index1;
      public string BuyTypeTxt1;
      public string TypeCount;
      public string BuyTypeTxt2;
      public int Price;
      public int Index7;
      public short Unk1;
      public short Unk2;
      public short Unk3;
      public short Unk4;
      public short Unk5;
      public short Unk6;
      public string ItemID;
      public string Unk7;
      public string Unk8;
      public string Unk9;
      public int TraceNumber;
      public string TraceString;

      public string Name { get; set; }
    }

    public struct IGCCashItemInfo
    {
      public int GID;
      public int ID;
      public int iGroup;
      public int iIndex;
      public int Level;
      public int Dur;
      public int Skill;
      public int Luck;
      public int Option;
      public int Exc;
      public int Ancient;
      public int Socket;
      public int Type;
      public int Period;
      public int TraceNumber;
      public string TraceString;

      public string Name { get; set; }
    }

    public struct IGCCashItemList
    {
      public int GUID;
      public int Index;
      public int SubIndex;
      public int iOpt;
      public int pID;
      public int cType;
      public int iPrice;
      public int iInfoGD;
      public int iInfoID;
      public int iCat;
      public int iGP;
      public int iSale;
      public int iRand;
      public string Name;
      public int TraceNumber;
      public string TraceString;
    }

    public struct IGCCashItemPackages
    {
      public int GUID;
      public int pID;
      public int iSeq;
      public int iGUID;
      public int iID;
      public string TraceString;

      public string Name { get; set; }

      public string PackName { get; set; }
    }

    public struct IGCDropManagerFile
    {
      public string iGroup { get; set; }

      public string iIndex { get; set; }

      public string MinLvl { get; set; }

      public string MaxLvl { get; set; }

      public string Skill { get; set; }

      public string Luck { get; set; }

      public string Opt { get; set; }

      public string Exc { get; set; }

      public string Ancient { get; set; }

      public string MapID { get; set; }

      public string MobID { get; set; }

      public string MinMobLvl { get; set; }

      public string MaxMobLvl { get; set; }

      public string Durability { get; set; }

      public string DropRate { get; set; }

      public string Name { get; set; }
    }

    public struct Map
    {
      private string mMapName;
      private int mMapCode;

      public string MapName
      {
        get => this.mMapName;
        set => this.mMapName = value;
      }

      public int MapCode
      {
        get => this.mMapCode;
        set => this.mMapCode = value;
      }
    }

    public struct Monster
    {
      public int ID { get; set; }

      public int Rate { get; set; }

      public string Name { get; set; }

      public int Level { get; set; }

      public int HP { get; set; }

      public int MP { get; set; }

      public int MinDmg { get; set; }

      public int MaxDmg { get; set; }

      public int Def { get; set; }

      public int MagDef { get; set; }

      public int AtkPower { get; set; }

      public int AtkSucRate { get; set; }

      public int Move { get; set; }

      public int AType { get; set; }

      public int ARange { get; set; }

      public int VRange { get; set; }

      public int MovSP { get; set; }

      public int ASpeed { get; set; }

      public int RegTime { get; set; }

      public int Attrib { get; set; }

      public int ItemR { get; set; }

      public int MoneyR { get; set; }

      public int MaxIS { get; set; }

      public int RWind { get; set; }

      public int RPois { get; set; }

      public int RIce { get; set; }

      public int RWtr { get; set; }

      public int RFire { get; set; }

      public int Element { get; set; }

      public int MaxElem { get; set; }

      public int MinElem { get; set; }

      public int ElemDef { get; set; }
    }

    public struct MSB : IComparable<Structures.MSB>
    {
      public int Type;
      public int MobID;
      public int MapID;
      public int Dis;
      public int X;
      public int Y;
      public int EndX;
      public int EndY;
      public int Dir;
      public int Total;

      public string ToolTipInfo { get; set; }

      public string MobName { get; set; }

      public string FileDesc { get; set; }

      public string UniKey { get; set; }

      public int CompareTo(Structures.MSB cus) => this.MapID.CompareTo(cus.MapID);
    }

    public struct ShopItem
    {
      public int ShopLocX;
      public int ShopLocY;
      public string UniqName;
      public int Group;
      public int Index;

      public byte Level { get; set; }

      public byte Durablity { get; set; }

      public bool Skill { get; set; }

      public bool Luck { get; set; }

      public byte Option { get; set; }

      public byte Excellent { get; set; }

      public byte Ancient { get; set; }
    }

    public struct UniItem
    {
      public int Group { get; set; }

      public int Index { get; set; }

      public int Slot { get; set; }

      public int Skill { get; set; }

      public int X { get; set; }

      public int Y { get; set; }

      public int Option { get; set; }

      public string Name { get; set; }

      public int Durability { get; set; }

      public int Ancient { get; set; }
    }
  }
}
