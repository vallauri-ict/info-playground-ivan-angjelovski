using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Gioco_Tresette
{
    class Carte 
    {
        private string seme;
        private string valore;
        public string[] val = { "Asso", "2", "3", "4", "5", "6", "7", "Fante", "Regina", "Re" };
        public string[] semi = { "Cuori", "Quadri", "Picche", "Fiori" };

        public Carte()
        {

        }
        public Carte(string valore, string seme)
        {
            Valore = valore;
            Seme = seme;
        }


        public string Valore
        {
            get => valore;
            set => valore = value;
        }

        public string Seme
        {
            get => seme;
            set => seme = value;
        }
    }
}
