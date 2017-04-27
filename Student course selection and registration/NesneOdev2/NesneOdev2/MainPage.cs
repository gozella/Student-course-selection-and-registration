using Nesne1odev2v2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneOdev2
{
    public partial class MainPage : Form, IMainPage
    {
        private readonly object listbox1;

        public MainPage()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            new OgrenciEklePage(this).Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            derscombo.SelectedIndex = 0;

            //Lisans Dersleri //
            
            Okul.Instance().AddDers(new Ders("MAT101", "Matematik1", 6, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("MAT107", "Soyut Matematik", 6, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("FSH333", "Hayat Bilgisi", 8, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("AST101", "Astrofiziğe Giriş", 12, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("ATA1001", "ATATÜRK İLKELERİ VE İNKILAP TARİHİ I", 2, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("BİL1001", "BİLGİSAYAR BİLİMLERİNE GİRİŞ I.", 7, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("BİL1003", "TEKNİK İNGİLİZCE I	", 3, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("BİL1005", "AYRIK MATEMATİK VE MANTIK", 6, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("MKN1006", "BİLGİSAYAR DESTEKLİ TEKNİK RESİM", 3, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("MKN2003", "MEASUREMENT AND EVALUATION TECHNIQUES", 4, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("MKN4001", "MAKİNA ELEMANLARI - II", 5, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("MKN3004", "GİRİŞİMCİLİK VE ETİK", 2, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("ELK2007", "MICROPROCESSOR BASED SYSTEM DESIGN	", 6, DersTipEnum.Lisans));
            Okul.Instance().AddDers(new Ders("ELK3003", "ELEKTROMEKANİK ENERJİ DÖNÜŞÜMÜ-I", 6, DersTipEnum.Lisans));

            //Yuksek Lisans Dersleri//
            Okul.Instance().AddDers(new Ders("TAR505", "Tatar Tarihi", 18, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("TAR511", "Uzakdoğu Halkları", 18, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("CSC5001", "Fuzzy Data Analysis", 8, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("CSC5019", "Software Requirements Engineering", 8, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("CSC5008", "YAPAY ZEKA OPTİMİZASYON ALGORİTMALARI", 8, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("MAT5102", "NUMERİK VE YAKLAŞIK YÖNTEMLER", 9, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("FBE5555","BİLİMSEL ARAŞTIRMA TEKNİKLERİ VE YAYIN ETİĞİ", 5, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("BIO5005","Histokimyasal Teknikler", 8, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("BIO5007","Evrimsel Genetik", 8, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("MAT5003", "ideal Topolojik Uzaylar I", 8, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("BTK5001", "Böcek Taksonomisi", 7, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("BTK5002", "Böceklerle Bitkiler Arasındaki Besin İlişkileri", 7, DersTipEnum.Yuksek));
            Okul.Instance().AddDers(new Ders("BTK5003", "Entomolojide Preparasyon ve Çizim", 8, DersTipEnum.Yuksek));

            //Doktora Dersler//
            Okul.Instance().AddDers(new Ders("MAT8101", "Applied Mathematics", 9, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("TIP8003", "İleri Nöroanatomi", 8, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("TIP8005", "Nörohistoloji ve Nöroembriyoloji", 8, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8001", "Meta Data Management", 5, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8003", "Advanced Database Management Systems", 9, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8004", "Complex Adaptive Systems", 8, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8005", "C4I and Information Warfare", 8, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8006", "System Modeling and Computer Simulation", 8, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8007", "Digital Image Processing", 8, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8008", "Knowledge Discovery", 8, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8009", "Research Methods in Computer Science", 7, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8010", "Data Integration", 7, DersTipEnum.Doktora));
            Okul.Instance().AddDers(new Ders("BMO8011", "Probabilistic Reasoning", 7, DersTipEnum.Doktora));


            //Ornek Ogrenciler//

            Okul.Instance().AddLisans(new LisansOgr("Hasan", "Büyükaşık", "2015280007", "Bilgisayar Bilimleri"));
            Okul.Instance().AddYuksek(new YuksekOgr("HasanL", "Büyükaşık", "2012170010", "Makine Mühendisi","Dokuz Eylul Universitesi","Makine Mühendisi"));
            Okul.Instance().AddDoktora(new DoktoraOgr("HasanD", "Büyükaşık", "2009281023", "Matematik Bölümü", "Dokuz Eylul Universitesi", "Makine Mühendisi","Dokuz Eylul Universitesi","Yüksek Makine Mühendisi"));
            Okul.Instance().AddDoktora(new DoktoraOgr("Ornek2", "Ornek2", "2010210001", "İstatistik Bölümü", "Dokuz Eylul Universitesi", "Malzeme Mühendisi", "Ege Universitesi", "Yüksek Malzeme Mühendisi"));

            DersList();
            OgrenciList();
        }

        private void derscombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DersList();
            OgrenciList();
        }

        public void OgrenciList()
        {
            ogrenciList.Items.Clear();

            var index = derscombo.SelectedIndex;

            if (index == 0)
                foreach (var item in Okul.Instance().getLisans())
                {
                    ogrenciList.Items.Add(item.OgrNo + "  " + item.Ad + " " + item.Soyad);
                }

            if (index == 1)
                foreach (var item in Okul.Instance().getYuksekLisans())
                {
                    ogrenciList.Items.Add(item.OgrNo + "  " + item.Ad + " " + item.Soyad);
                }

            if (index == 2)
                foreach (var item in Okul.Instance().getDoktora())
                {
                    ogrenciList.Items.Add(item.OgrNo + "  " + item.Ad + " " + item.Soyad);
                }

        }

        public void DersList()
        {
            var index = derscombo.SelectedIndex;

            derslerList.Items.Clear();

            foreach (var item in Okul.Instance().getDers())
            {
                if (item.dersTip == (DersTipEnum)index)
                    derslerList.Items.Add(item.DersKodu + "  " + item.DersAdi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = derscombo.SelectedIndex;
            var index2 = ogrenciList.SelectedIndex;
            var index3 = derslerList.SelectedIndex;
            Ogrenci ogrenci = null;
            Ders ders = null;
            double dersNotu = Double.Parse(this.dersNotu.Text);

            if (index == 0)
            {
                ogrenci = Okul.Instance().getLisans()[index2];
                ders = ((List<Ders>)Okul.Instance().getDers().Where(n => n.dersTip == DersTipEnum.Lisans).ToList())[index3];
            }

            if (index == 1)
            {
                ogrenci = Okul.Instance().getYuksekLisans()[index2];
                ders = ((List<Ders>)Okul.Instance().getDers().Where(n => n.dersTip == DersTipEnum.Yuksek).ToList())[index3];
            }

            if (index == 2)
            {
                ogrenci = Okul.Instance().getDoktora()[index2];
                ders = ((List<Ders>)Okul.Instance().getDers().Where(n => n.dersTip == DersTipEnum.Doktora).ToList())[index3];
            }

            OgrenciManage.AddDers(ogrenci,ders,dersNotu);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void derslerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BilgiGöster frm = new BilgiGöster();
            frm.Show();
            

        }

        private void ogrenciList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
