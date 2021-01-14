using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Scopa
{
    class Mazzo
    {
        private List<Carta> mazzo = new List<Carta>();
        string[] semi = { "quadri", "picche", "fiori", "cuori" };
        Carta nuovaCarta;

        public List<Carta> MAZZO
        {
            get => mazzo;
            set => mazzo = value;
        }

        public Mazzo()
        {
            for (int i = 0; i < 40; i++)
            {
                Random rnd = new Random();
                nuovaCarta = new Carta();
                nuovaCarta.VALORE = rnd.Next(1, 11);
                nuovaCarta.SEME = semi[rnd.Next(0, 4)];
                MessageBox.Show(nuovaCarta.VALORE + " " + nuovaCarta.SEME, (i + 1).ToString());
                mazzo.Add(nuovaCarta);
            }
        }

        private void mescola()
        {

        }

        private void estrai()
        {

        }
    }
}
