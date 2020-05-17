using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxMosheAtlani
{
    public partial class Form1 : Form
    {
        private string aWord;
        private bool player = true;//true = player1//false = player2
        private int countWordPlayer1 = 0;
        private int countWordPlayer2 = 0;
        private int turn = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void LetterPlayer1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Start();
            LBToGB(LetterPlayer1.SelectedItem.ToString());
        }

        private void LetterPlayer2_DoubleClick(object sender, EventArgs e)
        {
            timer1.Start();
            LBToGB(LetterPlayer2.SelectedItem.ToString());
        }

        public void LBToGB(string l)//rempli "aWord" et rempli le "GB"
        {
            for (int i = 1; i <= 9; i++)
            {
                if (word.Controls["label" + i].Text == "_")
                {
                    word.Controls["label" + i].Text = l;
                    aWord += l;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//bouton "OK"
        {
            int countLetter = 0;
            for (int i = 0; i < aWord.Length; i++)//check how much letter in aWord
            {
                countLetter++;
            }
            if (countLetter >= 3)
            {
                if (player)
                {
                    listBoxP1.Items.Add(aWord);
                    countWordPlayer1++;
                }
                else
                {
                    listBoxP2.Items.Add(aWord);
                    countWordPlayer2++;
                }
                aWord = null;

                for (int i = 1; i <= 9; i++)//une fois que le mot a aite sauvgarder se "for" remet chaque label egal a "_" pour continue a ecrire
                {
                    word.Controls["label" + i].Text = "_";
                }
            }
            else
            {
                MessageBox.Show("you have to write a full word");
            }

        }

        private void button2_Click(object sender, EventArgs e)//boutin "Delete"
        {
            for (int i = 1; i <= 9; i++)
            {
                if (word.Controls["label" + i].Text == "_")//trouve le premier lebel egal a "_" se qui veut dire que celui d avant etai la dernier lettre et donc l efface 
                {
                    word.Controls["label" + (i - 1)].Text = "_";
                    return;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (turn == 0)
            {

                LetterPlayer1.Enabled = false;
                LetterPlayer2.Enabled = true;
                player = false;
                aWord = null;
                for (int i = 1; i <= 9; i++)//une fois que le tour et fini se "for" remet chaque label egal a "_" pour continue a ecrire au tour suivan ou pas 
                {
                    if (word.Controls["label" + i].Text != "_")
                        word.Controls["label" + i].Text = "_";
                }
                turn = 2;
                MessageBox.Show("Time up! 2nd player's turn");
                turn = 1;
            }
            else if (turn == 1)
            {
                turn = 2;
                if (countWordPlayer1 > countWordPlayer2)
                    MessageBox.Show("Player 1 win !");
                else if (countWordPlayer1 < countWordPlayer2)
                    MessageBox.Show("Player 2 win !");
                else
                    MessageBox.Show("Player 1 and Player 2 do the same score !");
            }
            timer1.Stop();
        }


        //separation

    }
}
