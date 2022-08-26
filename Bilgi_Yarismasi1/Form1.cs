using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0, puan = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                puan = puan + 20;
                lblPuan.Text = puan.ToString();
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }


        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled=true;

            label5.Text = BtnC.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                puan = puan + 20;
                lblPuan.Text = puan.ToString();
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                puan = puan + 20;
                lblPuan.Text = puan.ToString();
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }


        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                puan = puan + 20;
                lblPuan.Text = puan.ToString();
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            richTextBox1.ReadOnly = true;



            soruno++;
            
            lblSoru.Text = soruno.ToString();
            if(soruno == 1)
            {
                richTextBox1.Text = "İstiklal Marşı kaç yılında yazılmıştır?";
                BtnA.Text = "1919";
                BtnB.Text = "1920";
                BtnC.Text = "1921";
                BtnD.Text = "1922";
                label4.Text = "1921";
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "İlk Türk kadın opera sanatçısı aşağıdakilerden hangisidir?";
                BtnA.Text = "Zeliha Berksoy";
                BtnB.Text = "Semiha Berksoy";
                BtnC.Text = "Afife Jale";
                BtnD.Text = "Leyla Gencer";
                label4.Text = "Semiha Berksoy";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Fransız İhtilali kaç yılında gerçekleşmiştir?";
                BtnA.Text = "1789-1799";
                BtnB.Text = "1768-1787";
                BtnC.Text = "1876-1889";
                BtnD.Text = "1850-1875";
                label4.Text = "1789-1799";
                
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Hangi şair İkinci Yeni akımına dahildir?";
                BtnA.Text = "Can Yücel";
                BtnB.Text = "Sezai Karakoç";
                BtnC.Text = "Ziya Gökalp";
                BtnD.Text = "Orhan Veli";
                label4.Text = "Sezai Karakoç";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Aziz Nesin'in bir eseri değildir?";
                BtnA.Text = "Gol Kralı";
                BtnB.Text = "Zübük";
                BtnC.Text = "Yer Demir Gök Bakır";
                BtnD.Text = "Üvercinka";
                label4.Text = "Yer Demir Gök Bakır";
               
            }
            if (soruno == 6)
            {
                BtnSonraki.Text = "Sonuçlar";
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis + "\n" + "Puan: " + puan, "Bilgilendirme Penceresi" ,MessageBoxButtons.OK);
            }
        }
    }
}
