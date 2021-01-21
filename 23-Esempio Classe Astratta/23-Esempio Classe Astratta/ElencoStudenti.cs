using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _23_Esempio_Classe_Astratta
{
    class ElencoStudenti : Report
    {
        private List<Studente> lstStudenti = new List<Studente>();
        private string stampa = "";

        protected override void printBody()
        {
            foreach (var student in lstStudenti)
            {
                stampa += student.nomeCompleto() + "\n";
            }
        }

        protected override void printFooter()
        {
            stampa += "FOOTER STAMPA STUDENTI\n";
        }

        protected override void printHeader()
        {
            stampa += "INTESTAZIONE STAMPA STUDENTI\n";
        }

        public ElencoStudenti()
        {
            lstStudenti.Add(new Studente("Andrea", "Giaccardi"));
            lstStudenti.Add(new Studente("Sergio", "Grosso"));
        }
    }
}
