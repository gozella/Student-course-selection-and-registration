using Nesne1odev2v2;
using System.Collections.Generic;
using System;

namespace Nesne1odev2v2
{
    public abstract  class Ogrenci : IOgrenci
    {
        private string ad, soyad, ogrNo, bolumAdi;
        private List<OgrenciDers> dersler = new List<OgrenciDers>();

        public Ogrenci(string ad, string soyad, string ogrNo, string bolumAdi)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.ogrNo = ogrNo;
            this.bolumAdi = bolumAdi;
        }



        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string BolumAdi
        {
            get
            {
                return bolumAdi;
            }

            set
            {
                bolumAdi = value;
            }
        }

        public List<OgrenciDers> Dersler
        {
            get
            {
                return dersler;
            }
        }

        public void addDers(OgrenciDers ders)
        {
            dersler.Add(ders);
        }

        public string OgrNo
        {
            get
            {
                return ogrNo;
            }

            set
            {
                ogrNo = value;
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }



        public double kumulatif()
        {
            double kumulatif = 0;
            double toplamKredi = 0;
            foreach(var ders in dersler)
            {
                kumulatif += ders.dersi.Akts * ders.Notu;
                toplamKredi += ders.dersi.Akts;
            }
            if(toplamKredi != 0)
            {
                return kumulatif / toplamKredi;
            }
            else
            {
                return 0;
            }
            
        }


    }
}
