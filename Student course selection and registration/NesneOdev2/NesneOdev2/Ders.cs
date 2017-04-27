using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne1odev2v2
{
    public class Ders
    {
        public Ders(string dersKodu, string dersAdi, int akts,DersTipEnum dersTip)
        {
            
            DersKodu = dersKodu;
            DersAdi = dersAdi;
            Akts = akts;
            this.dersTip = dersTip;
        }

        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public int Akts { get; set; }
        public DersTipEnum dersTip { get; set; }
    }
}
