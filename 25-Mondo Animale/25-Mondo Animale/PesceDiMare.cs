using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Mondo_Animale
{
    class PesceDiMare:AnimaleMarino
    {
        public PesceDiMare(string s) : base(s)
        {
            //super(s);
        }

        public override string vive()
        {
            return "in mare";
        }

        public override string chi_sei()
        {
            return "un pesce di mare";
        }
    }
}
