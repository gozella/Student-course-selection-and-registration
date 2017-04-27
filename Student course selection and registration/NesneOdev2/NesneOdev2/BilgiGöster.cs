using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nesne1odev2v2;
namespace NesneOdev2
{
    public partial class BilgiGöster : Form
    {
        
        private MainPage mainPage;

        public BilgiGöster()
        {
            InitializeComponent();
        }
 
        public void EkranCikti()
        {
            richTextBox1.AppendText("Lisans Öğrenci Bilgisi\n");
            var lisans = Okul.Instance().getLisans();
            var ylisans = Okul.Instance().getYuksekLisans();
            var doktora = Okul.Instance().getDoktora();     

            foreach(var item in lisans)
            {
                richTextBox1.AppendText("   "+ item.OgrNo + "; " + item.Ad + "; " + item.Soyad + ";" + item.BolumAdi + "\n");

                richTextBox1.AppendText("       Ders Bilgileri\n");

                foreach (var item2 in item.Dersler)
                {
                    var temp = item as LisansOgr;

                    richTextBox1.AppendText("   " + item2.dersi.DersKodu + "  " + item2.dersi.DersAdi + "  " + "AKTS "+ item2.dersi.Akts +" " + "Öğr Not "+item2.Notu +"   \n" );
                }
                richTextBox1.AppendText("\n" + "Öğrencinin Kumulatif Ortalaması: " + item.kumulatif().ToString("F2")+"\n");
                richTextBox1.AppendText("***************************\n");
            }

            richTextBox1.AppendText("\n--------------------------------\n");
            richTextBox1.AppendText("Yüksek Lisans Öğrenci Bilgisi\n");

            foreach (var item in ylisans)
            {
                richTextBox1.AppendText("   " + item.OgrNo + "; " + item.Ad + "; " + item.Soyad + ";" + item.BolumAdi + "\n");
                

                var temp = item as YuksekOgr;
				
				richTextBox1.AppendText("   Lisans Bilgileri\n");

                richTextBox1.AppendText("Lisansta Mezun Oldugu Okul:" + temp.LisansMezunOkulAd + ";\nLisansta Okuduğu Bölüm :" + temp.LisansMezunBolumAd +"\n");

                richTextBox1.AppendText("   Ders Bilgileri\n");
                foreach (var item2 in item.Dersler)
                {
               
                    richTextBox1.AppendText("       " + item2.dersi.DersKodu + "  " + item2.dersi.DersAdi + "  " + "AKTS " + item2.dersi.Akts + " " + "Öğr Not " + item2.Notu + "   \n");
                }
                richTextBox1.AppendText("\n" + "Öğrencinin Kumulatif Ortalaması: " + item.kumulatif().ToString("F2") + "\n");
                richTextBox1.AppendText("***************************\n");
            }

            richTextBox1.AppendText("\n --------------------------------\n");

            richTextBox1.AppendText("Doktora Öğrenci Bilgisi\n");
            foreach (var item in doktora)
            {
                richTextBox1.AppendText("   "+item.OgrNo + "; " + item.Ad + "; " + item.Soyad + ";" +  item.BolumAdi + "\n");


                var temp = item as DoktoraOgr;

                richTextBox1.AppendText("   Lisans Bilgileri\n");

                richTextBox1.AppendText("Lisansta Mezun Oldugu Okul: " + temp.LisansMezunOkulAd + ";\nLisansta Okuduğu Bölüm:  " + temp.LisansMezunBolumAd + "\n");

                richTextBox1.AppendText("   Yüksek Lisans Bilgileri\n");

                richTextBox1.AppendText("Yuksek Lisansta Mezun Oldugu Okul:" + temp.YuksekMezunOkulAd + ";\nYüksek Lisansta Okuduğu Bölüm:" + temp.YuksekMezunBolumAd + "\n");

                richTextBox1.AppendText("   Ders Bilgileri\n");
                foreach (var item2 in item.Dersler)
                {
                    richTextBox1.AppendText("       " + item2.dersi.DersKodu + "  " + item2.dersi.DersAdi + "  " + "AKTS " + item2.dersi.Akts + " " + "Öğr Not " + item2.Notu + "   \n");
                }
                richTextBox1.AppendText("\n" + "Öğrencinin Kumulatif Ortalaması:  " + item.kumulatif().ToString("F2")+"\n");
                richTextBox1.AppendText("***************************\n");
            }              
        }                   

        public BilgiGöster(MainPage mainPage)
        {
            this.mainPage = mainPage;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BilgiGöster_Load(object sender, EventArgs e)
        {
            EkranCikti();
        }
    }
}
