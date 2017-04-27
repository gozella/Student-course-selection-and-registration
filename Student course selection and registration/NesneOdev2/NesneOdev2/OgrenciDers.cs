using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne1odev2v2
{
    public class OgrenciDers
    {
        public OgrenciDers(Ders dersi, double notu)
        {
            this.dersi = dersi;
            Notu = notu;
        }

        public Ders dersi { get; set; }
        public double Notu { get; set; }

    }
}
