using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Esempio_Classe_Astratta
{
    abstract class Report
    {
        protected abstract void printHeader();
        protected abstract void printBody();
        protected abstract void printFooter();
        
        public string print()
        {
            printHeader();
            printBody();
            printFooter();
        }
    }
}
