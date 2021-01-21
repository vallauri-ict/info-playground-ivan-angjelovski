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
        private int i;
        private List<Carte> lstCarte = new List<Carte>();

        public void InserisciCarta(Carte nuovaCarta)
        {
            bool occorrenza = false;
            foreach (var carta in lstCarte)
            {
                if((carta.Valore == nuovaCarta.Valore) && (carta.Seme == nuovaCarta.Seme))
                {
                    occorrenza = true;
                }
            }
            if(!occorrenza)
            {
                lstCarte.Add(nuovaCarta);
            }
        }

        public void DammiCarta()
        {
            MessageBox.Show(lstCarte.First().Valore + " " + lstCarte.First().Seme);
        }

        public void DammiCarta(Carte cartaRichiesta)
        {
        }

        public void MescolaCarte()
        {
            Carte[] mazzoMescolato = new Carte[lstCarte.Count];
            Random rnd = new Random();
            i = 0;

            foreach (var carta in mazzoMescolato)
            {
                carta.Seme = null;
                carta.Valore = null;
            }

            foreach (var carta in lstCarte)
            {
                int n;
                do
                {
                    n = rnd.Next(0, mazzoMescolato.Length);
                }
                while ((mazzoMescolato[n].Seme != null) && (mazzoMescolato[n].Valore != null));
                mazzoMescolato[n] = carta;
            }

            lstCarte.Clear();
            foreach (var carta in mazzoMescolato)
            {
                lstCarte.Add(carta);
            }
        }
    }
}
