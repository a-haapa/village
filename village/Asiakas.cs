using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace village
{
    public class Asiakas
    {
        public int Asiakas_id { get; set; }

        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Lahiosoite { get; set; }
        public int Postinro { get; set; }
        public string Puhelinnro { get; set; }
        public string Email { get; set; }
       

        public override string ToString()
        {
            return Asiakas_id + Etunimi + Sukunimi + Lahiosoite + Postinro + Puhelinnro + Email;
        }
    }
}
