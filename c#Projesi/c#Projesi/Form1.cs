using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace c_Projesi
{
    public partial class Form1 : Form
    {
        int yolHızı;
        int trafikHızı;
        int oyuncuHızı = 12;
        int score;
        int arabaFoto;

        Random rand = new Random(); 
        Random arabaYeri = new Random();

        bool solagit, sağagit;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void Yol1_Click(object sender, EventArgs e)
        {
            Yol1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Yol2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ödül.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            YZ1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Left)
            {
                solagit = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                sağagit = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solagit = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                sağagit = false;
            }
        }

        private void OyunZamanlayıcıOlay(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void değiştirYZarabalar(PictureBox Tempcar)
        {
        
        }
        private void GameOver()
        {

        }
        private void OyunuDurdur()
        {
            Başlabuton.Enabled = false; 
            Patlama.Visible = false;
            Ödül.Visible = false;
            solagit = false ;
            sağagit = false ;
            Skor = 0;
            Ödül.Image = Properties.Resources.bronze;

            yolHızı = 12;
            trafikHızı = 15;

            YZ1.Top = arabaYeri.Next(200, 500) * -1;
            YZ1.Left = arabaYeri.Next(5, 200);

            YZ1.Top = arabaYeri.Next(200, 500) * -1;
            YZ2.Left = arabaYeri.Next(245, 422);
        }

        private void Skor_Click(object sender, EventArgs e)
        {
            string = 0;
        }

        private void Playsound()
        {

        }

    }
}
