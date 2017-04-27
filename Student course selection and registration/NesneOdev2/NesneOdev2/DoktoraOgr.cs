using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne1odev2v2
{
    public class DoktoraOgr : Ogrenci,IOgrenci
    {
        public DoktoraOgr(string ad, string soyad, string ogrNo, string bolumAdi, string LisansMezunOkulAd, string LisansMezunBolumAd, string YuksekMezunOkulAd, string YuksekMezunBolumAd) : base(ad, soyad, ogrNo, bolumAdi)
        {
            this.LisansMezunBolumAd = LisansMezunBolumAd;
            this.LisansMezunOkulAd = LisansMezunOkulAd;
            this.YuksekMezunBolumAd = YuksekMezunBolumAd;
            this.YuksekMezunOkulAd = YuksekMezunOkulAd;
        }

        public string LisansMezunOkulAd { get; set; }
        public string LisansMezunBolumAd { get; set; }
        public string YuksekMezunOkulAd { get; set; }
        public string YuksekMezunBolumAd { get; set; }

        public double getNot()
        {
            throw new NotImplementedException();
        }
    }
}
