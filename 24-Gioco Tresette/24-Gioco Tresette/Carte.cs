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
        private string valore;
        private string seme;

        private string[] valori = { "Asso", "2", "3", "4", "5", "6", "7", "Fante", "Regina", "Re" };
        private string[] semi = { "Cuore", "Picche", "Fiore", "Quadri" };

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

        private void Proponi()
        {
            Random rnd = new Random();
            Valore = valori[rnd.Next(0, valori.Length)];
            Seme = semi[rnd.Next(0, semi.Length)];
            MessageBox.Show(Valore + " " + Seme);
        }
    }
}
