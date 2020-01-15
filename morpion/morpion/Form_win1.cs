using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace morpion
{
    public partial class Form_win1 : Form
    {
       

        public Form_win1(string simbol)
        {
            InitializeComponent();
           

            if (simbol == "x")
            {
                label1.Visible = true;
            }
            else if (simbol == "o")
            {
                label2.Visible = true;
            }
        }

        private void Form_win1_Load(object sender, EventArgs e)
        {

        }
    }
}
