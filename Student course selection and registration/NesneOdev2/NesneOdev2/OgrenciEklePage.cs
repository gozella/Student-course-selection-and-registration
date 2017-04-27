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
    public partial class OgrenciEklePage : Form
    {
        private IMainPage iMainPage;

        public OgrenciEklePage(IMainPage iMainPage)
        {
            InitializeComponent();
            this.iMainPage = iMainPage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = secimcombo1.SelectedIndex;
            var ad = Ad.Text;
            var soyad = this.soayd.Text;
            var no = this.no.Text;
            var bolum = this.bolumadi.Text;
            if (index == 0)
            {
                Okul.Instance().AddLisans(new LisansOgr(ad, soyad, no, bolum));
                iMainPage.OgrenciList();
                this.Close();
            }
            else if(index == 1)
            {
                Okul.Instance().AddYuksek(new YuksekOgr(ad, soyad, no, bolum,textBox1.Text,textBox2.Text));
                iMainPage.OgrenciList();
                this.Close();

            }
            else if (index == 2)
            {
                Okul.Instance().AddDoktora(new DoktoraOgr(ad, soyad, no, bolum,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text));
                iMainPage.OgrenciList();
                this.Close();
            }
        }

        private void OgrenciEklePage_Load(object sender, EventArgs e)
        {
            secimcombo1.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void bolumadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void secimcombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = secimcombo1.SelectedIndex;
             if(index == 0)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
           else if (index == 1)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else if (index == 2)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
