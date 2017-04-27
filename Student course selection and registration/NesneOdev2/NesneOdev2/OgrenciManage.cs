namespace Nesne1odev2v2
{
    public class OgrenciManage
    {
        static public bool AddLisans(string ad, string soyad, string ogrNo, string bolumAdi)
        {
            if(ad!=null && ad.Length>0)
            {
                Okul.Instance().AddLisans(new LisansOgr(ad,soyad, ogrNo, bolumAdi));
                return true;
            }

            return false;
        }

        static public bool AddYuksekLisans(string ad, string soyad, string ogrNo, string bolumAdi, string lisansMezunOkulAd, string lisansMezunBolumAd)
        {
            if (ad != null && ad.Length > 0)
            {
                Okul.Instance().AddYuksek(new YuksekOgr(ad, soyad, ogrNo, bolumAdi, lisansMezunOkulAd, lisansMezunBolumAd) { LisansMezunOkulAd = lisansMezunBolumAd, LisansMezunBolumAd = lisansMezunBolumAd });
                return true;
            }

            return false;
        }

        static public bool AddDoktora(string ad, string soyad, string ogrNo, string bolumAdi, string lisansMezunOkulAd, string lisansMezunBolumAd, string yuksekLisansMezunOkulAd, string yuksekLisansMezunBolumAd)
        {
            if (ad != null && ad.Length > 0)
            {
                Okul.Instance().AddDoktora(new DoktoraOgr(ad, soyad, ogrNo, bolumAdi, lisansMezunOkulAd, lisansMezunBolumAd, yuksekLisansMezunOkulAd, yuksekLisansMezunBolumAd) { LisansMezunOkulAd = lisansMezunBolumAd, LisansMezunBolumAd = lisansMezunBolumAd,YuksekMezunOkulAd=yuksekLisansMezunOkulAd,YuksekMezunBolumAd=yuksekLisansMezunBolumAd });
                return true;
            }

            return false;
        }


        static public bool AddDers(Ogrenci ogrenci, Ders ders, double not)
        {
            ogrenci.addDers(new OgrenciDers(ders,not));
            return true;
        }
    }
}
