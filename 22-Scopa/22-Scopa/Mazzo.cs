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
        public List<Carta> mazzo = new List<Carta>();
        string[] semi = { "Denari", "Bastoni", "Spade", "Coppe" };
        Random rnd = new Random();

        public Mazzo()
        {
            for (int i = 0; i < 40; i++)
            {
                int val = rnd.Next(1, 11);
                string seme = semi[rnd.Next(0, 4)];
                Carta nuovaCarta = new Carta(val, seme);
                mazzo.Add(nuovaCarta);
            }
        }

        public void Mescola()
        {
            Carta aus;
            int l = mazzo.Count;//per evitare errore sulla modifica della lista
            for (int i = 0; i < l; i++)//mischio per ogni carta
            {
                aus = mazzo.First();
                mazzo.Remove(mazzo.First());
                mazzo.Insert(rnd.Next(1, l), aus);
            }
        }

        public Carta Estrai()
        {
            //restituisco ed elimino
            Carta aus = mazzo.First();
            mazzo.RemoveAt(0);
            return aus;
        }
    }
}
