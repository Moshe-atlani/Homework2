using morpion.Properties;
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
    public partial class Form1 : Form
    {
        private bool m_IsFirstPlayer = true;//qulle joueur joue 
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Click_Pic(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;

            if (m_IsFirstPlayer)
            {
                if (pictureBox.Enabled)//if c la pic white
                {
                    pictureBox.Image = Resources.morpion_pic_crois;
                    pictureBox.Enabled = false;
                    m_IsFirstPlayer = false;
                }
            }
            else
            {
                if (pictureBox.Enabled)//if c la pic white
                {
                    pictureBox.Image = Resources.morpion_pic_rond;
                    pictureBox.Enabled = false;
                    m_IsFirstPlayer = true;
                }
            }
            count++;
            



        }

        public string[,] FormToMatrix()
        {

            //המטריצה המוחזרת

            string[,] m = new string[3, 3];
            int row, col;
            PictureBox curImage;//????

            //עוברים על כלל הפקדים בטופס - נעזרים בלולאת foreach

            foreach (Control ctrl in this.Controls)//ds notre cas c sur tout la page?
                if (ctrl is PictureBox )//se qui a sur la page ?
                {
                    curImage = ctrl as PictureBox;//la quelle ?

                    //מציאת מספר השורה והעמודה מתוך שם הפקד
                    col = int.Parse(curImage.Name[curImage.Name.Length - 1].ToString());//c quoi sa ?
                    row = int.Parse(curImage.Name[curImage.Name.Length - 2].ToString());
                    m[row, col] = curImage.Text;//PASSS BON -resousre
                }
            return m;
        }

        public void IsWin(string[,] t)
        {
            for (int i = 0; i < 3; i++)//x
            {
                if (t[i, 0] == t[i, 1] && t[i, 0] == t[i, 2])
                    MessageBox.Show("Winnnnn");
            }
        }

        
    }
}
