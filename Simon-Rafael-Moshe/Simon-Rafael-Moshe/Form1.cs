using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_Rafael_Moshe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simon_who_comes_from_the_earth s = new Simon_who_comes_from_the_earth();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Simon_from_another_galaxi s = new Simon_from_another_galaxi();
            s.ShowDialog();
        }
    }
}
