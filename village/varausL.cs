using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace village
{
    class varausL
    {
        public int varaus_id { get; set; }
        public int lukumaara { get; set; }
        public DateTime varattu { get; set; }
        public DateTime vahvistus_pvm { get; set; }
        public DateTime varattu_alkupvm { get; set; }
        public DateTime varattu_loppupvm { get; set; }

        Mokki mokki = new Mokki();
        Palvelu palvelu = new Palvelu();
        Asiakas asiakas = new Asiakas();
        
    }
}
