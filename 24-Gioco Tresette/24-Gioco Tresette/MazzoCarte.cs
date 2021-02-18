using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Gioco_Tresette
{
    class MazzoCarte : Carte
    {
        Random rnd = new Random();
        private int progr = 0;
        private List<Carte> mazzo = new List<Carte>();

        public MazzoCarte()
        {
            Carte aus = new Carte();
            foreach (var seme in aus.semi)
            {
                foreach (var valore in aus.val)
                {
                    Carte carta = new Carte(valore, seme);
                    mazzo.Add(carta);
                }
            }
        }

        public void InserisciCarta(string valore, string seme)
        {
            Carte carta = new Carte();
            carta.Seme = seme;
            carta.Valore = valore;
            if (mazzo.Find(bf => bf.Valore == valore && bf.Seme == seme) == null)
            {
                mazzo.Add(carta);
                System.Windows.Forms.MessageBox.Show("Carta inserita");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Carta già presente");
            }
        }

        public Carte DammiCarta()
        {
            Carte aus = mazzo.First();
            mazzo.RemoveAt(0);
            return aus;
        }

        public int DammiCarta(string valore, string seme)
        {
            Carte aus = mazzo.Find(bf => bf.Valore == valore && bf.Seme == seme);
            return mazzo.IndexOf(aus);
        }

        public void Mescola()
        {
            Carte app;
            int length = mazzo.Count;
            for (int i = 0; i < length; i++)
            {
                app = mazzo.First();
                mazzo.Remove(mazzo.First());
                mazzo.Insert(rnd.Next(1, length), app);
            }
        }
    }
}
