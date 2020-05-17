using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxMoshe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Question(object sender, EventArgs e)
        {
            int[] countPoint = new int[4];
            countPoint[0] = 0;//0 = superman
            countPoint[1] = 0;//1 = batman
            countPoint[2] = 0;//2 = wonderwoman
            countPoint[3] = 0;//3 = catwoman

            if (MessageBox.Show("Votre Personnage et t il un Homme ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                countPoint[2] += 100;
                countPoint[3] += 100;
            }
            else
            {
                countPoint[0] += 100;
                countPoint[1] += 100;
            }
            if (MessageBox.Show("Votre Personnage peut t il voler ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                countPoint[3] += 100;
                countPoint[1] += 100;
            }
            else
            {
                countPoint[0] += 100;
                countPoint[2] += 100;
            }
            if (MessageBox.Show("Votre Personnage son costume et t il noir ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                countPoint[0] += 100;
                countPoint[2] += 100;
            }
            else
            {
                countPoint[1] += 100;
                countPoint[3] += 100;
            }

            int win = YAtIlUnGagnen(countPoint);
            if (win == 0)
            {
                MessageBox.Show("Votre Personnage c est Superman ! ", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (win == 1)
            {
                MessageBox.Show("Votre Personnage c est Batman ! ", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (win == 2)
            {
                MessageBox.Show("Votre Personnage c est Wonderwoman ! ", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (win == 3)
            {
                MessageBox.Show("Votre Personnage c est Catwoman ! ", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Votre Personnage a t il une cappe ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                countPoint[2] += 100;
                countPoint[3] += 100;
            }
            else
            {
                countPoint[0] += 100;
                countPoint[1] += 100;
            }

            if (MessageBox.Show("Votre Personnage a t il un masque ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                countPoint[0] += 100;
                countPoint[2] += 100;
            }
            else
            {
                countPoint[1] += 100;
                countPoint[3] += 100;
            }



            win = YAtIlUnGagnen(countPoint);
            if (win == 0)
            { 
                MessageBox.Show("Votre Personnage c est Superman ! ", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (win == 1)
            { 
                MessageBox.Show("Votre Personnage c est Batman ! ", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (win == 2)
            { 
                MessageBox.Show("Votre Personnage c est Wonderwoman ! ", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (win == 3)
            { 
                MessageBox.Show("Votre Personnage c est Catwoman ! ", "Reponse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Bravo tu as reussi a me battre ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public int YAtIlUnGagnen(int[] arr)
        {
            if (arr[0] >= 100 && arr[1] >= 100 && arr[2] >= 100)//3
                return 3;
            if (arr[0] >= 100 && arr[1] >= 100 && arr[3] >= 100)//2
                return 2;
            if (arr[0] >= 100 && arr[3] >= 100 && arr[2] >= 100)//1
                return 1;
            if (arr[3] >= 100 && arr[1] >= 100 && arr[2] >= 100)//0
                return 0;
            return 100;
        }

    }
}
