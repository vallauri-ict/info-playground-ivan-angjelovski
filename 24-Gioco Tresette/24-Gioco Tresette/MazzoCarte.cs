using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Gioco_Tresette
{
    class MazzoCarte
    {
        private int i;
        private List<Carte> lstCarte = new List<Carte>();

        public void InserisciCarta(Carte nuovaCarta)
        {
            lstCarte.Add(nuovaCarta);
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
            foreach (var carta in lstCarte)
            {
                int n;
                do
                {
                    n = rnd.Next(0, mazzoMescolato.Length);
                    mazzoMescolato[n] = carta;
                }
                while (mazzoMescolato[n] == null);
            }

            lstCarte.Clear();
            foreach (var carta in mazzoMescolato)
            {
                lstCarte.Add(carta);
            }
        }
    }
}
