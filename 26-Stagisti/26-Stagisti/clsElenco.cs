using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_Stagisti
{
    class clsElenco
    {
        List<clsAlunno> elenco;

        public clsElenco()
        {
            elenco = new List<clsAlunno>();
        }
        public void inserisci(clsAlunno a)
        {
            elenco.Add(a);
        }
        public void visualizzaDgv(DataGridView dgv)
        {
            dgv.DataSource = typeof(List<>);
            dgv.DataSource = elenco;
        }
        public int OreAzienda(string nomeA)
        {
            int oreTotAzienda = 0;

            foreach (clsAlunno a in elenco)
            {
                if (a is clsStagista)
                {
                    // converte un oggetto di tipo padre in una classe specializzata
                    clsStagista s = a as clsStagista; // anche clsStagista s = (clsStagista)s
                    if (s.Azienda == nomeA)
                    {
                        oreTotAzienda += Convert.ToInt32(s.Ore);
                    }
                }
            }
            return oreTotAzienda;
        }

        public void cancella()
        {
            if (elenco.Count == 0)
            {
                throw new Exception("Lista vuota!");
            }
            else
            {
                elenco.RemoveAt(elenco.Count - 1);
            }
        }

        public void cancella(int posizione)
        {
            posizione--;
            // Verifico l'esistenza dell'elemento
            if (elenco.Count == 0)
            {
                throw new Exception("Lista vuota!");
            }
            // Verifico che non superi i limiti della lista
            else if (posizione < 0 || posizione > elenco.Count - 1)
            {
                throw new Exception("Posizione non valida");
            }
            else
                elenco.RemoveAt(posizione);
        }
    }
}
