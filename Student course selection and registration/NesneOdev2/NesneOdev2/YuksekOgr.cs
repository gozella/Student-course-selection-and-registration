using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne1odev2v2
{
    public class YuksekOgr : Ogrenci
    {
        public YuksekOgr(string ad, string soyad, string ogrNo, string bolumAdi,string LisansMezunOkulAd,string LisansMezunBolumAd) : base(ad, soyad, ogrNo, bolumAdi)
        {
            this.LisansMezunBolumAd = LisansMezunBolumAd;
            this.LisansMezunOkulAd = LisansMezunOkulAd;
        }

        public string LisansMezunOkulAd { get; set; }
        public string LisansMezunBolumAd { get; set; }

    }
}
