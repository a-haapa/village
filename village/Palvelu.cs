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
        public string Tyyppi { get; set; }

        public Toimintaalue toimintaalue = new Toimintaalue();
        public varausL varaus = new varausL();
        public List<Palvelu> palvelut = new List<Palvelu>();
        public override string ToString()
        {
            return Palvelu_id + Nimi + Kuvaus + Hinta + Alv;
        }
    }
}
