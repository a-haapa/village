using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace village
{
    public class Mokki
    {
        public int Mokki_id { get; set; }

        public Toimintaalue MokinToimintaalue = new Toimintaalue();

        public string Mokkinimi { get; set; }
        public string Katuosoite { get; set; }
        public string Postinro { get; set; }
        public string Kuvaus { get; set; }
        public int Henkilomaara { get; set; }
        public string Varustelu { get; set; }
        public double Mokinhinta { get; set; }
        public double Mokinalv { get; set; }
        

        public override string ToString()
        {
            return Mokki_id + Mokkinimi + Katuosoite + Postinro + Kuvaus + Henkilomaara + Varustelu + Mokinhinta + Mokinalv;
        }
    }
}
