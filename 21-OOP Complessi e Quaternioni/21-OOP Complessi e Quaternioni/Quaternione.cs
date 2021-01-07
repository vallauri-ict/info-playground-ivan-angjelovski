using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Complessi_e_Quaternioni
{
    class Quaternione : Complesso
    {
        private double j;
        private double k;

        public double J 
        { 
            get => j; 
            set => j = value; 
        }

        public double K 
        { 
            get => k; 
            set => k = value; 
        }

        public Quaternione()
        {

        }

        public Quaternione(double immaginario)
        {

        }
    }
}
