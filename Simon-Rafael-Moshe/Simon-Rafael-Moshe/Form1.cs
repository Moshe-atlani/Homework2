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
        private Color[] arr_colors = new Color[4];
        private Color[] arr_user_check = new Color[10];
        private int i_user = 0;
        private Color[] arr_suit = new Color[10];
        private int i = 0;

        public Form1()
        {
            InitializeComponent();
            SetColorToArray();
        }

        public Color RandomArrayColors()//Random sur une des 4 couleurs
        {
            Random rnd = new Random();
            int result = rnd.Next(0, 4);
            return arr_colors[result];
        }

        public void SetColorToArray()//Remplis le Maarah du random avec les couleurs
        {
            arr_colors[0] = Color.Gold;
            arr_colors[1] = Color.Brown;
            arr_colors[2] = Color.RoyalBlue;
            arr_colors[3] = Color.Green;

        }

        public void ShowAllColors()// allume toutes les touches du jeu(j ai changer)
        {
            pictureBoxBleu.BackColor = Color.White;//Bleu -->White
            pictureBoxJaune.BackColor = Color.White;//Yellow -->White
            pictureBoxRouge.BackColor = Color.White;//Red -->White
            pictureBoxVert.BackColor = Color.White;//Green -->White          
        }

        public void AllColorWhite()// eteins toutes les touches du jeu(remet en blanc)(j ai changer)
        {
            pictureBoxBleu.BackColor = Color.RoyalBlue;//Bleu <--White
            pictureBoxJaune.BackColor = Color.Gold;//Yellow <--White
            pictureBoxRouge.BackColor = Color.Brown;//Red <--White
            pictureBoxVert.BackColor = Color.Green;//Green <--White
        }

        private void button1_Click(object sender, EventArgs e)//bouton de demmarage
        {
            Color rnd_color = RandomArrayColors();

            timer1.Start();
            if (rnd_color == Color.RoyalBlue)
            {
                pictureBoxBleu.BackColor = Color.White;//bleu--> White
            }
            if (rnd_color == Color.Green)
            {
                pictureBoxVert.BackColor = Color.White;//Green--> White
            }
            if (rnd_color == Color.Brown)
            {
                pictureBoxRouge.BackColor = Color.White;//Red--> White
            }
            if (rnd_color == Color.Gold)
            {
                pictureBoxJaune.BackColor = Color.White;//Yellow--> White
            }
            arr_suit[i] = rnd_color;
            i++;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            AllColorWhite();
            timer1.Stop();
        }
        
        private void pictureBoxRouge_Click(object sender, EventArgs e)//A travailler !!!!
        {
            timer2.Start();
            if ((sender as PictureBox).Name == "pictureBoxBleu")
            {
                (sender as PictureBox).BackColor = Color.White;
                arr_user_check[i_user] = Color.RoyalBlue;
            }
            if ((sender as PictureBox).Name == "pictureBoxRouge")
            {
                (sender as PictureBox).BackColor = Color.White;
                arr_user_check[i_user] = Color.Brown;
            }
            if ((sender as PictureBox).Name == "pictureBoxJaune")
            {
                (sender as PictureBox).BackColor = Color.White;
                arr_user_check[i_user] = Color.Gold;
            }
            if ((sender as PictureBox).Name == "pictureBoxVert")
            {
                (sender as PictureBox).BackColor = Color.White;
                arr_user_check[i_user] = Color.Green;
            }

            if (arr_user_check[i_user] != arr_suit[i_user])
                MessageBox.Show("Looser");
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            AllColorWhite();
            timer2.Stop();
        }
    }
}
