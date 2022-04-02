using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chordale
{
  public partial class Form1 : Form
  {
    Random rnd = new Random();
    DateTime _lastRandomTime = DateTime.Now.AddDays(-1);

    public Form1()
    {
      InitializeComponent();
    }

    private void ShowRandomChord()
    {
      List<Chord> possibleChords = new List<Chord>();

      foreach (Chord c in lstChords.Items)
      {
        bool canAdd = false;
        if (c.ChordType == ChordType.Major && chkIncludeMajor.Checked) canAdd = true;
        else if (c.ChordType == ChordType.Minor && chkIncludeMinor.Checked) canAdd = true;
        else if (c.ChordType == ChordType.Dominant7 && chkIncludeDominant.Checked) canAdd = true;

        if (lstChords.SelectedItem != null && (Chord)lstChords.SelectedItem == c) canAdd = false;
        
        if (canAdd) possibleChords.Add(c);
      }

      if (possibleChords.Count > 0)
      {
        int next = rnd.Next(0, possibleChords.Count);
        Chord c = possibleChords[next];
        lstChords.SelectedItem = c;
        _lastRandomTime = DateTime.Now;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      foreach (Chord c in Chord.GetAllChords())
      {
        lstChords.Items.Add(c);
      }
    }

    private void lstChords_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lstChords.SelectedItem != null)
      {
        Chord c = (Chord)lstChords.SelectedItem;
        lblVisualizedName.Text = c.Name;
        fretboardVisualizer1.VisualizeChord(c);
      }
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Space)
      {
        ShowRandomChord();
      }
      
      if (e.KeyCode == Keys.F1)
      {
        autoVisualizer.Enabled = !autoVisualizer.Enabled;
        lblAuto.Visible = autoVisualizer.Enabled;
      }
    }

    private void trackBPM_ValueChanged(object sender, EventArgs e)
    {
      lblBPM.Text = $"{trackBPM.Value} bpm";
    }

    private void autoVisualizer_Tick(object sender, EventArgs e)
    {
      double waitTimeMS = (60 / trackBPM.Value) * 1000;

      TimeSpan span = DateTime.Now - _lastRandomTime;
      if (span.TotalMilliseconds > waitTimeMS) ShowRandomChord();
    }
  }
}
