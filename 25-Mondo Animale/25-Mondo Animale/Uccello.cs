﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Mondo_Animale
{
    class Uccello:Animale
    {
        public Uccello(String s) : base(s)
        {
            verso = "cinguetta";
        }

        public override string chi_sei()
        {
            return "un uccello";
        }

        public override string si_muove()
        {
            return "volando";
        }

        public override string vive()
        {
            return "in un nido su un albero";
        }
    }
}
