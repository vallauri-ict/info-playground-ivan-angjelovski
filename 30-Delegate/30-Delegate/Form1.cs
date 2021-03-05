using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1^ OPERAZIONE: Dichiarazione del delegate che accetta 2 parametri interi
        // e restituisce un valore intero
        public delegate int Operazione(int a, int b);

        // 2^ OPERAZIONE: Dichiaro le 3 funzioni che utilizzerà il delegate
        public int Somma(int x, int y)
        {
            return x + y;
        }
        public int Sottrazione(int x, int y)
        {
            return x - y;
        }
        public int Prodotto(int x, int y)
        {
            return x * y;
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            // PRIMO METODO per usare un delegate
            // 3^ OPERAZIONE:
            // ISTANZIO il delegate e come parametro passo il nome della funzione
            Operazione op = new Operazione(Somma); // Somma è la "funzione" puntata dal delegate

            // 4^ OPERAZIONE: Richiamo il delegate che eseguirà la funzione somma
            MessageBox.Show("Somma = " + op(15, 10));
        }

        private void btnProdotto_Click(object sender, EventArgs e)
        {
            // SECONDO METODO per usare un delegate
            Operazione op = Prodotto; // analogo a Operazione op = new Operazione(Prodotto);
            MessageBox.Show("Prodotto = " + op(15, 10));
        }

        private void btnSottrazione_Click(object sender, EventArgs e)
        {
            // TERZO METODO per usare un delegate
            Operazione op = Sottrazione;
            MessageBox.Show("Sottrazione = " + op(15, 10));
        }
    }
}
