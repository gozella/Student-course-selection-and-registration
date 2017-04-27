using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne1odev2v2
{
    public partial class Okul
    {
        private static Okul instance = new Okul();

        public static Okul Instance()
        {
            return instance;
        }


        private List<Ders> dersler=new List<Ders>();
        private List<Ogrenci> LisansOgrs=new List<Ogrenci>();
        private List<Ogrenci> YuksekOgrs=new List<Ogrenci>();
        private List<Ogrenci> DoktoraOgrs=new List<Ogrenci>();

        
        public void AddLisans(LisansOgr ogrenci)
        {
            LisansOgrs.Add(ogrenci);
        }

        public void AddYuksek(YuksekOgr ogrenci)
        {
            YuksekOgrs.Add(ogrenci);
        }

        public void AddDoktora(DoktoraOgr ogrenci)
        {
            DoktoraOgrs.Add(ogrenci);
        }

        public void AddDers(Ders ders)
        {
           dersler.Add(ders);
        }

        public List<Ders> getDers()
        {
            return dersler;
        }

        public List<Ogrenci> getLisans()
        {
            return LisansOgrs;
        }

        public List<Ogrenci> getYuksekLisans()
        {
            return YuksekOgrs;
        }

        public List<Ogrenci> getDoktora()
        {
            return DoktoraOgrs;
        }
    }
}
