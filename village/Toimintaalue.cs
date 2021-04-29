using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace village
{
    public class Toimintaalue
    {
        

        public int Toimintaalue_id { get; set; }
        public string Nimi { get; set; }

        public override string ToString()
        {
            return Toimintaalue_id + Nimi;
        }
    }
}
