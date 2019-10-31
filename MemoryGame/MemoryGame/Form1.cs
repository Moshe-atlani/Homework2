using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGame.Properties;

namespace MemoryGame
{
    public partial class Form_MemoryGame : Form
    {
        private bool m_IsFirst = true;
        private PictureBox m_FirstPictureBox;
        private PictureBox m_SecondPictureBox;

        private int m_CountTrue = 0;
        private const int CARD_NUMBER = 8;
        private Image[] m_Images = new Image[CARD_NUMBER];

        public Form_MemoryGame()
        {
            InitializeComponent();
            SetImagesArray();
        }


        private void Swap(int i, int j)
        {
            Image image = m_Images[i];
            m_Images[i] = m_Images[j];
            m_Images[j] = image;
        }


        //Notre arr de photo
        private void SetImagesArray()
        {
            m_Images[0] = Resources.img_desler;
            m_Images[1] = Resources.img_desler;
            m_Images[2] = Resources.img_kook;
            m_Images[3] = Resources.img_kook;
            m_Images[4] = Resources.img_baba_sale;
            m_Images[5] = Resources.img_baba_sale;
            m_Images[6] = Resources.rabi_shimon;
            m_Images[7] = Resources.rabi_shimon;

            Random rnd = new Random();
            for (int i = 0; i < CARD_NUMBER; i++)
            {
                Swap(i, rnd.Next(CARD_NUMBER));
            }
        }

        //Fonction click pour n'importe quelle carte
        private void pictureBox_Card_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            //k = a la place dans le מערך qui correspond au bon PictureBox
            //PictureBox3 ---> k = 2
            string picName = pictureBox.Name;
            int k = int.Parse(picName.Substring(picName.Length - 1));
            k--;


            //s'occupe de retourner la carte - 
            //si talit --> alors rav;
            //si rav ---> alors talit
            if (!IsImagesMatch(pictureBox.Image, Resources.back_card))
                pictureBox.Image = Resources.back_card;
            else
                pictureBox.Image = m_Images[k];          

            //lancer le timer quand la 2eme carte a ete retourne
            if (!m_IsFirst)//is second
            {
                m_SecondPictureBox = pictureBox;
                timer1.Start();
            }
            else//is first
            {
                m_FirstPictureBox = pictureBox; 
            }


            m_IsFirst = !m_IsFirst;
            //if (m_IsFirst == True)
            //      m_IsFirst = False    
            //else
            //      m_IsFirst = True 


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //verifie si les 2 images sont les memes
            //si oui ---> tu les desactive
            //si non ---> tu les retourne 
            if (IsImagesMatch(m_FirstPictureBox.Image, m_SecondPictureBox.Image))
            {
                m_FirstPictureBox.Enabled = false;
                m_SecondPictureBox.Enabled = false;
                m_CountTrue += 2;
            }
            else
            { 
                m_FirstPictureBox.Image = Resources.back_card;
                m_SecondPictureBox.Image = Resources.back_card;
            }
            timer1.Stop();

            //VICTOIRE
            if (m_CountTrue == CARD_NUMBER)
            {

                pictureBox9.Visible = true;               
                MessageBox.Show("Winnnnnnnnnnnnnnnn!!!!");
            }
        }


        //Verifie si les 2 images sont les memes
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
