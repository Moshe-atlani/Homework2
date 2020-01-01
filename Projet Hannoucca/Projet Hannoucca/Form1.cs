using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Hannoucca
{
    public partial class Form1 : Form
    {
        bool isVisible = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (isVisible)
            {
                pictureBox2.Visible = false;
                pictureBox10.Visible = false;
                isVisible = false;
            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox10.Visible = true;
                isVisible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (pictureBox3.Height < 200 && pictureBox9.Height < 200)
            {
                pictureBox3.Height += 10;
                pictureBox3.Top -= 10;
                pictureBox9.Height += 10;
                pictureBox9.Top -= 10;
            }
            else
            {
                pictureBox3.Height =110;
                pictureBox3.Top = 80;
                pictureBox9.Height = 110;
                pictureBox9.Top = 80;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Height < 200 && pictureBox8.Height < 200)
            {
                pictureBox4.Height += 10;
                pictureBox4.Top -= 10;
                pictureBox8.Height += 10;
                pictureBox8.Top -= 10;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pictureBox6.Top <100  && pictureBox7.Top < 100)
            {
                
                pictureBox6.Top -= 10;
               
                pictureBox7.Top -= 10;
            }
            else
            {
                
                pictureBox6.Top= 80;
                
                pictureBox7.Top = 80;
                
            }
        }
    }
}

