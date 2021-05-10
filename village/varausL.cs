using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace village
{
    public class varausL
    {
        public int Varaus_id { get; set; }
        public int Lukumaara { get; set; }
        public DateTime Varattu { get; set; }
        public DateTime Vahvistus_pvm { get; set; }
        public DateTime Varattu_alkupvm { get; set; }
        public DateTime Varattu_loppupvm { get; set; }
        public int Mokki_mokki_id { get; set; }

        public Asiakas asiakas = new Asiakas();

    }
}
