using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tictactoe
{
    internal static class Program
    {
       
        /// The main 
       
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new xoxGame());
        }
    }
}
