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
        private int count = 0;//combien de fois on a jouer 
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
                    count++;
                    if (count >= 5)
                    {
                        if (IsWin(FormToMatrix()))
                        {
                            Form_win1 form_win = new Form_win1("x");
                            form_win.ShowDialog();
                            groupBox1.Enabled = false;

                        }

                    }
                }

            }

            else
            {
                if (pictureBox.Enabled)//if c la pic white
                {
                    pictureBox.Image = Resources.morpion_pic_rond;
                    pictureBox.Enabled = false;
                    m_IsFirstPlayer = true;
                    count++;
                    if (count >= 5)
                    {
                        if (IsWin(FormToMatrix()))
                        {
                            Form_win1 form_win = new Form_win1("o");//c la  pour simon 
                            form_win.ShowDialog();
                            groupBox1.Enabled = false;
                        }

                    }
                }
            }                       
        }

        public string[,] FormToMatrix()
        {

            //המטריצה המוחזרת

            string[,] m = new string[3, 3];
            int row, col;
            PictureBox curImage;//????
            string picSimbol;

            //עוברים על כלל הפקדים בטופס - נעזרים בלולאת foreach

            foreach (Control ctrl in groupBox1.Controls)//ds notre cas c sur tout la page?
                if (ctrl is PictureBox)//se qui a sur la page ?
                {
                    curImage = ctrl as PictureBox;//la quelle ?

                    //מציאת מספר השורה והעמודה מתוך שם הפקד
                    col = int.Parse(curImage.Name[curImage.Name.Length - 1].ToString());//c quoi sa ?
                    row = int.Parse(curImage.Name[curImage.Name.Length - 2].ToString());
                    if (IsImagesMatch(Resources.morpion_pic_crois, curImage.Image))
                        m[row, col] = "x";
                    else if (IsImagesMatch(Resources.morpion_pic_rond, curImage.Image))
                        m[row, col] = "o";
                }
            return m;
        }


        public bool IsWin(string[,] t)
        {
            if (t[0, 0] == "x" && t[0, 1] == "x" && t[0, 2] == "x" || t[0, 0] == "o" && t[0, 1] == "o" && t[0, 2] == "o")
                return true;
            else if (t[1, 0] == "x" && t[1, 1] == "x" && t[1, 2] == "x" || t[1, 0] == "o" && t[1, 1] == "o" && t[1, 2] == "o")
                return true;

            else if (t[2, 0] == "x" && t[2, 1] == "x" && t[2, 2] == "x" || t[2, 0] == "o" && t[2, 1] == "o" && t[2, 2] == "o")
                return true;

            else if (t[0, 0] == "x" && t[1, 0] == "x" && t[2, 0] == "x" || t[0, 0] == "o" && t[1, 0] == "o" && t[2, 0] == "o")
                return true;

            else if (t[0, 1] == "x" && t[1, 1] == "x" && t[2, 1] == "x" || t[0, 1] == "o" && t[1, 1] == "o" && t[2, 1] == "o")
                return true;

            else if (t[0, 2] == "x" && t[1, 2] == "x" && t[2, 2] == "x" || t[0, 2] == "o" && t[1, 2] == "o" && t[2, 2] == "o")
                return true;

            else if (t[0, 0] == "x" && t[1, 1] == "x" && t[2, 2] == "x" || t[0, 0] == "o" && t[1, 1] == "o" && t[2, 2] == "o")
                return true;

            else if (t[0, 2] == "x" && t[1, 1] == "x" && t[2, 0] == "x" || t[0, 2] == "o" && t[1, 1] == "o" && t[2, 0] == "o")
                return true;
            else
                return false;



        }


        public bool IsImagesMatch(Image image1, Image image2)
        {
            try
            {
                //create instance or System.Drawing.ImageConverter to convert
                //each image to a byte array
                ImageConverter converter = new ImageConverter();
                //create 2 byte arrays, one for each image
                byte[] imgBytes1 = new byte[1];
                byte[] imgBytes2 = new byte[1];

                //convert images to byte array
                imgBytes1 = (byte[])converter.ConvertTo(image1, imgBytes2.GetType());
                imgBytes2 = (byte[])converter.ConvertTo(image2, imgBytes1.GetType());

                //now compute a hash for each image from the byte arrays
                System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();
                byte[] imgHash1 = sha.ComputeHash(imgBytes1);
                byte[] imgHash2 = sha.ComputeHash(imgBytes2);

                //now let's compare the hashes
                for (int i = 0; i < imgHash1.Length && i < imgHash2.Length; i++)
                {
                    //whoops, found a non-match, exit the loop
                    //with a false value
                    if (!(imgHash1[i] == imgHash2[i]))
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //we made it this far so the images must match
            return true;
        }





    }
}
