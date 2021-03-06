﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;
namespace Simon_Rafael_Moshe
{
    public partial class Simon_who_comes_from_the_earth : Form
    {

        private Color[] arr_colors = new Color[4];//maarah de toute les couleur (jaune, rouge ...)
        private Color[] arr_user_check = new Color[10];//maarah  de tout les couleur que le jouer a apuiyer(pour verifier s  il a pas rater une coueur )
        private Color[] arr_suit = new Color[10];//maarah de tout les couleur qu il faut  apuyer(tirer au sort)
        private int i_user = 0;//la  place du couleur ds les maarah (C PAS TRES CLAIR !)
        private int i = 0;//le nombre de la place de la prochain couleur 
        private int j = 0;//je l utilise ds ContinueRnd().timer_3 et il est senser etre toujour egal au j du for ds ContinueRnd()
       
        //private int countClick = 0;//je l utilise ds pictureBoxRouge_Click pour savoir si c le moment d utiliser ContinueRnd (si j ai fini d apuiyer sur toute les la arr_suite )


        public Simon_who_comes_from_the_earth()
        {
            InitializeComponent();
            SetColorToArray();
        }

        public void ReturnToTheBegening()
        {
            i_user = 0;
            i = 0;
            j = 0;
        }//very very very good BH

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

        private void button1_Click(object sender, EventArgs e)//bouton start
        {
            ReturnToTheBegening();
            ContinueRnd();
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
        }

        private void pictureBoxRouge_Click(object sender, EventArgs e)//sa devrai renplir un meerah pour le verifier apre
        {
            
            timer1.Start();
            //(sender as PictureBox).BackColor = Color.White;//sa pourait renplacai
            //arr_user_check[i_user] = (sender as PictureBox).BackColor;//sa pourait renplacai
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
            //je suit a la .
            if (arr_user_check[i_user] != arr_suit[i_user])//good
            {
                MessageBox.Show("Looser");
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;

            }
            else if (i - 1 == i_user)//pour attendre de faire un faute ou de finir la suite 
            {
                timer2.Start();
            }
            i_user++;//il me semble que cette ligne et indispensable pour rajouter des couleur
        }

        public void ContinueRnd()//fonction qui fait cliker les rnd
        {
            i_user = 0;//peut etre mauvai
            Color rnd_color = RandomArrayColors();
            arr_suit[i] = rnd_color;
            i++;
            //jusqu a la c bon


            AllumeTout();

        }

       public void AllumeTout()
        {
            
                timer3.Start();

                



            
        }

    

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer3.Start();

            //ContinueRnd();
            //timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //Light the current color
            if (arr_suit[j] == Color.RoyalBlue)//je peu qu on peut renplacer le "arr_suit[j] "par"rnd_color"
            {
                pictureBoxBleu.BackColor = Color.White;//bleu--> White
            }
            else if (arr_suit[j] == Color.Green)
            {
                pictureBoxVert.BackColor = Color.White;//Green--> White
            }
            else if (arr_suit[j] == Color.Brown)
            {
                pictureBoxRouge.BackColor = Color.White;//Red--> White
            }
            else if (arr_suit[j] == Color.Gold)
            {
                pictureBoxJaune.BackColor = Color.White;//Yellow--> White
            }

            timer3.Stop();
            timer1.Start();

            j++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sPayer = new SoundPlayer(@"C:\Users\Moshe\Desktop\workspace\Homework2\Simon-Rafael-Moshe\sound114.wav");
            sPayer.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AllColorWhite();
            
        }
    }
}

