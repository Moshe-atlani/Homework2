using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxMoshe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            MessageBox.Show("Choisi un super hero et mon programe le devinera avec quelque question", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
           

        }
    }
}
