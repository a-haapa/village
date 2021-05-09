using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace village
{
    public class Palvelu
    {
        public int Palvelu_id { get; set; }
        public string Nimi { get; set; }
        public string Kuvaus { get; set; }
        public double Hinta { get; set; }
        public double Alv { get; set; }
        public int Tyyppi { get; set; }

        public Toimintaalue toimintaalue = new Toimintaalue();
        public override string ToString()
        {
            return Palvelu_id + Nimi + Kuvaus + Hinta + Alv;
        }
    }
}
