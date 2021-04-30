using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace village
{
    public class varausL
    {
        public int varaus_id { get; set; }
        public int lukumaara { get; set; }
        public DateTime varattu { get; set; }
        public DateTime vahvistus_pvm { get; set; }
        public DateTime varattu_alkupvm { get; set; }
        public DateTime varattu_loppupvm { get; set; }

        public Mokki mokki = new Mokki();
        public Asiakas asiakas = new Asiakas();
        public List<Palvelu> palvelut = new List<Palvelu>();

    }
}
