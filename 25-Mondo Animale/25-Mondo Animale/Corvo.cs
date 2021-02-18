using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Mondo_Animale
{
    class Corvo:Uccello
    {
        public Corvo(string s) : base(s)
        {
            verso = "gracchia";
        }

        public override string chi_sei()
        {
            return "un corvo";
        }
    }
}
