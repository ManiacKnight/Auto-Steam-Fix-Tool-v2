using System;
using System.Windows.Forms;

namespace Auto_Steam_Fix
{

    static class Program
    {  
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

