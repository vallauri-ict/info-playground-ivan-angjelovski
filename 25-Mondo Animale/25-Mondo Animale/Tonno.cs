using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Mondo_Animale
{
    class Tonno:AnimaleMarino
    {
        public Tonno(string s) : base(s)
        {
            verso = "non fa versi";
        }

        public override string chi_sei()
        {
            return "tonno";
        }

        public override string si_muove()
        {
            return "nuotando";
        }
    }
}
