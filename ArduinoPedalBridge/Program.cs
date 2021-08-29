using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoPedalBridge
{
  static class Program
  {
    public static string ProgramDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ArduinoBridge");

    [STAThread]
    static void Main()
    {
      if (!Directory.Exists(ProgramDataPath)) Directory.CreateDirectory(ProgramDataPath);
      
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
