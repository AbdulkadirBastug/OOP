
using projendp.meyveler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projendp
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();

        }







        Random rastgele = new Random();

        int saniye = 60;    //Timer ı 60 dan başlatmak için değişken.
        int topsivi = 0;    //Toplam sıvıyı tutmak için değişken.
        int toppure = 0;    //Toplam püreyi tutmak için değişken.
        int topcvitamini=0; //Toplam C vitamini için değişken.
        int topavitamini=0; //Toplam A vitamini için değişken.


        private void button1_Click(object sender, EventArgs e)  //Butona basıldığında işlem yap
        {
            timer1.Start();                 //timer çalıştır.
            int sayi = rastgele.Next(6);    //0 ile 6 arasında rastegele sayı üretir.
            
                if (sayi == 0)              //Rastgele Sayı 0 sa portakal üret ve ekrana portakal oluşturuldu mesajı göster.
                {
                    pictureBoxMeyve.ImageLocation = "portakal.jpg";
                    MessageBox.Show("Portakal oluşturuldu");



                }
                if (sayi == 1)              //Rastgele Sayı 1 sa mandalina üret ve ekrana mandalina oluşturuldu mesajı göster.
            {
                    pictureBoxMeyve.ImageLocation = "mandalina.jpg";
                    MessageBox.Show("Mandalina oluşturuldu");

                }
                if (sayi == 2)              //Rastgele Sayı 2 sa greyfurt üret ve ekrana greyfurt oluşturuldu mesajı göster.
            {
                    pictureBoxMeyve.ImageLocation = "greyfurt.jpg";
                    MessageBox.Show("Greyfurt oluşturuldu");

                }
                if (sayi == 3)              //Rastgele Sayı 3 sa elma üret ve ekrana elma oluşturuldu mesajı göster.
            {
                    pictureBoxMeyve.ImageLocation = "elma.jpg";
                    MessageBox.Show("Elma oluşturuldu");

                }
                if (sayi == 4)              //Rastgele Sayı 4 sa armut üret ve ekrana armut oluşturuldu mesajı göster.
            {
                    pictureBoxMeyve.ImageLocation = "armut.jpeg";
                    MessageBox.Show("Armut oluşturuldu");

                }
                if (sayi == 5)              //Rastgele Sayı 5 sa çilek üret ve ekrana çilek oluşturuldu mesajı göster.
            {
                    pictureBoxMeyve.ImageLocation = "cilek.jpg";
                    MessageBox.Show("Çilek oluşturuldu");

                }
                radioBtnKatiMeyve.Enabled = true;   //Katı meyve sıkacak radio butonunu aktifleştirir.
                radioBtnNarenciye.Enabled = true;   //Narenciye sıkacak radio butonunu aktifleştirir.

                btnBasla.Enabled = false;
        }
            
        private void timer1_Tick(object sender, EventArgs e)    //Timerı 60 dan 0 a birer saniye şeklinde azaltır.
        {
               

                timer1.Interval = 1000;

                saniye = saniye - 1;
                labelsaniye.Text = Convert.ToString(saniye);

            if (labelsaniye.Text == "-1")                       //0 dan daha fazla azaltımamasını sağlar ve radio butonları kapatır.
            {
                    timer1.Stop();

                    labelsaniye.Text = "0";

                    radioBtnKatiMeyve.Enabled = false;
                    radioBtnNarenciye.Enabled = false;
            }

        }

        private void radioBtnNarenciye_CheckedChanged(object sender, EventArgs e)   //Narenciye sıkacak radio butonu değiştiğinde çalışır.
        {
           
            if (pictureBoxMeyve.ImageLocation == "portakal.jpg")                    //Resimdeki portakalsa portakal classından değerleriyle birlikte nesne oluşturur ve değerlerini textboxlara yazdırır.
            {
                Portakal Portakal = new Portakal();
                Portakal.agirlik();
                Portakal.Verim();
                Portakal.VitaminA();
                Portakal.VitaminC();
                txtAVitamini.Text = Portakal.AVitamin.ToString();
                txtCVitamini.Text = Portakal.CVitamin.ToString();
                txtMeyveGram.Text = Portakal.gram.ToString();
                txtSivi.Text = (Portakal.gram * Portakal.verim / 100).ToString();
                txtPure.Text = (Portakal.gram - Portakal.gram * Portakal.verim / 100).ToString();
                radioBtnKatiMeyve.Enabled = false;
                

            }
            if (pictureBoxMeyve.ImageLocation == "mandalina.jpg")                   //Resimdeki mandalinaysa mandalina classından değerleriyle birlikte nesne oluşturur ve değerlerini textboxlara yazdırır.                   
            {
                
                Mandalina Mandalina = new Mandalina();
                Mandalina.agirlik();
                Mandalina.Verim();
                Mandalina.VitaminA();
                Mandalina.VitaminC();
                txtAVitamini.Text = Mandalina.AVitamin.ToString();
                txtCVitamini.Text = Mandalina.CVitamin.ToString();
                txtMeyveGram.Text = Mandalina.gram.ToString();
                txtSivi.Text = (Mandalina.gram * Mandalina.verim / 100).ToString();
                txtPure.Text = (Mandalina.gram - Mandalina.gram * Mandalina.verim / 100).ToString();
                radioBtnKatiMeyve.Enabled = false;
         
            }
            if (pictureBoxMeyve.ImageLocation == "greyfurt.jpg")                    //Resimdeki greyfurtsa greyfurt classından değerleriyle birlikte nesne oluşturur ve değerlerini textboxlara yazdırır.
            {
                Greyfurt Greyfurt = new Greyfurt();
                Greyfurt.agirlik();
                Greyfurt.Verim();
                Greyfurt.VitaminA();
                Greyfurt.VitaminC();
                txtAVitamini.Text = Greyfurt.AVitamin.ToString();
                txtCVitamini.Text = Greyfurt.CVitamin.ToString();
                txtMeyveGram.Text = Greyfurt.gram.ToString();
                txtSivi.Text = (Greyfurt.gram * Greyfurt.verim / 100).ToString();
                txtPure.Text = (Greyfurt.gram - Greyfurt.gram * Greyfurt.verim / 100).ToString();
                radioBtnKatiMeyve.Enabled = false;
               
            }
            //radio butonda seçim yapıldıgında ürettiği meyvelerin değerlerini toplam değerlere aktarır ve yeni bir meyve üretir.
            if ((radioBtnKatiMeyve.Enabled == false || radioBtnNarenciye.Enabled == false) && (radioBtnKatiMeyve.Checked == true || radioBtnNarenciye.Checked == true))
            {
                radioBtnKatiMeyve.Checked = false;
                radioBtnNarenciye.Checked = false;

                topsivi += Convert.ToInt32(txtSivi.Text);
                txtTopSivi.Text = topsivi.ToString();
                
                toppure += Convert.ToInt32(txtPure.Text);
                txtTopPure.Text = toppure.ToString();

                topavitamini += Convert.ToInt32(txtAVitamini.Text);
                txtTopAVitamini.Text = topavitamini.ToString();

                topcvitamini += Convert.ToInt32(txtCVitamini.Text);
                txtTopCVitamini.Text = topcvitamini.ToString();

                int sayi = rastgele.Next(6);

                if (sayi == 0)
                {
                    pictureBoxMeyve.ImageLocation = "portakal.jpg";
                    MessageBox.Show("Portakal oluşturuldu");

                }
                if (sayi == 1)
                {
                    pictureBoxMeyve.ImageLocation = "mandalina.jpg";
                    MessageBox.Show("Mandalina oluşturuldu");

                }
                if (sayi == 2)
                {
                    pictureBoxMeyve.ImageLocation = "greyfurt.jpg";
                    MessageBox.Show("Greyfurt oluşturuldu");

                }
                if (sayi == 3)
                {
                    pictureBoxMeyve.ImageLocation = "elma.jpg";
                    MessageBox.Show("Elma oluşturuldu");

                }
                if (sayi == 4)
                {
                    pictureBoxMeyve.ImageLocation = "armut.jpeg";
                    MessageBox.Show("Armut oluşturuldu");

                }
                if (sayi == 5)
                {
                    pictureBoxMeyve.ImageLocation = "cilek.jpg";
                    MessageBox.Show("Çilek oluşturuldu");

                }
                radioBtnKatiMeyve.Enabled = true;
                radioBtnNarenciye.Enabled = true;
                
            }

        }

        private void radioBtnKatiMeyve_CheckedChanged(object sender, EventArgs e)//Katı meyve sıkacak radio butonu değiştiğinde çalışır.   
        {
            if (pictureBoxMeyve.ImageLocation == "elma.jpg")                    //Resimdeki elmaysa elma classından değerleriyle birlikte nesne oluşturur ve değerlerini textboxlara yazdırır.           
            {
                Elma Elma = new Elma();
                Elma.agirlik();
                Elma.Verim();
                Elma.VitaminA();
                Elma.VitaminC();
                txtAVitamini.Text = Elma.AVitamin.ToString();
                txtCVitamini.Text = Elma.CVitamin.ToString();
                txtMeyveGram.Text = Elma.gram.ToString();
                txtSivi.Text = (Elma.gram * Elma.verim / 100).ToString();
                txtPure.Text = (Elma.gram - Elma.gram * Elma.verim / 100).ToString();
                radioBtnNarenciye.Enabled = false;
      
            }
            if (pictureBoxMeyve.ImageLocation == "armut.jpeg")                  //Resimdeki armutsa armut classından değerleriyle birlikte nesne oluşturur ve değerlerini textboxlara yazdırır.
            {
                Armut Armut = new Armut();
                Armut.agirlik();
                Armut.Verim();
                Armut.VitaminA();
                Armut.VitaminC();
                txtAVitamini.Text = Armut.AVitamin.ToString();
                txtCVitamini.Text = Armut.CVitamin.ToString();
                txtMeyveGram.Text = Armut.gram.ToString();
                txtSivi.Text = (Armut.gram * Armut.verim / 100).ToString();
                txtPure.Text = (Armut.gram - Armut.gram * Armut.verim / 100).ToString();
                radioBtnNarenciye.Enabled = false;

            }
            if (pictureBoxMeyve.ImageLocation == "cilek.jpg")                   //Resimdeki çilekse çilek classından değerleriyle birlikte nesne oluşturur ve değerlerini textboxlara yazdırır.
            {
                Cilek Cilek = new Cilek();
                Cilek.agirlik();
                Cilek.Verim();
                Cilek.VitaminA();
                Cilek.VitaminC();
                txtAVitamini.Text = Cilek.AVitamin.ToString();
                txtCVitamini.Text = Cilek.CVitamin.ToString();
                txtMeyveGram.Text = Cilek.gram.ToString();
                txtSivi.Text = (Cilek.gram * Cilek.verim / 100).ToString();
                txtPure.Text = (Cilek.gram - Cilek.gram * Cilek.verim / 100).ToString();
                radioBtnNarenciye.Enabled = false;
       
            }
            //radio butonda seçim yapıldıgında ürettiği meyvelerin değerlerini toplam değerlere aktarır ve yeni bir meyve üretir.
            if ((radioBtnKatiMeyve.Enabled==false||radioBtnNarenciye.Enabled==false)&&(radioBtnKatiMeyve.Checked==true||radioBtnNarenciye.Checked==true))
                {
                    radioBtnKatiMeyve.Checked = false;
                    radioBtnNarenciye.Checked = false;

                    topsivi += Convert.ToInt32(txtSivi.Text);
                    txtTopSivi.Text = topsivi.ToString();

                    toppure += Convert.ToInt32(txtPure.Text);
                    txtTopPure.Text = toppure.ToString();

                    topavitamini += Convert.ToInt32(txtAVitamini.Text);
                    txtTopAVitamini.Text = topavitamini.ToString();

                    topcvitamini += Convert.ToInt32(txtCVitamini.Text);
                    txtTopCVitamini.Text = topcvitamini.ToString();

                    int sayi = rastgele.Next(6);

                    if (sayi == 0)
                    {
                    pictureBoxMeyve.ImageLocation = "portakal.jpg";
                    MessageBox.Show("Portakal oluşturuldu");

                    }
                    if (sayi == 1)
                    {
                        pictureBoxMeyve.ImageLocation = "mandalina.jpg";
                        MessageBox.Show("Mandalina oluşturuldu");

                    }
                    if (sayi == 2)
                    {
                        pictureBoxMeyve.ImageLocation = "greyfurt.jpg";
                        MessageBox.Show("Greyfurt oluşturuldu");

                    }
                    if (sayi == 3)
                    {
                        pictureBoxMeyve.ImageLocation = "elma.jpg";
                        MessageBox.Show("Elma oluşturuldu");

                    }
                    if (sayi == 4)
                    {
                        pictureBoxMeyve.ImageLocation = "armut.jpeg";
                        MessageBox.Show("Armut oluşturuldu");

                    }
                    if (sayi == 5)
                    {
                        pictureBoxMeyve.ImageLocation = "cilek.jpg";
                        MessageBox.Show("Çilek oluşturuldu");

                    }
                    radioBtnKatiMeyve.Enabled = true;
                    radioBtnNarenciye.Enabled = true;
                
            }


        }

        private void button2_Click(object sender, EventArgs e)  //Çıkış butonuna basıldığında programdan çıkartır.
        {
            Environment.Exit(0);
        }
    }

   
}
