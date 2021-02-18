using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Mondo_Animale
{
    class Quadrupede:AnimaleTerrestre
    {
        public Quadrupede(string s) : base(s)
        {
            //super(s);
        }

        public override string si_muove()
        {
            return "avanzando su 4 zampe";
        }
    }
}
