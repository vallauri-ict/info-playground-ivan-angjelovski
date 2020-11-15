using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct libro
        {
            public string titolo;
            public string autore;
        }
        public int i = 0;
        Dictionary<int, libro> dizionarioLibri = new Dictionary<int, libro>();

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            dizionarioLibri.Add(i, l);
            i++;
            MessageBox.Show("Libro aggiunto correttamente");
        }

        private void btnVisualizza_Click_1(object sender, EventArgs e)
        {
            foreach (int key in dizionarioLibri.Keys)
                MessageBox.Show(Convert.ToString(key + 1), "N° libro");   // stampa di fatto dell'indice nel dictionary (+ 1 così parte da 1)

            foreach (libro l in dizionarioLibri.Values)
                MessageBox.Show(l.titolo + " " + l.autore, "Libri inseriti");  // stampa elementi
        }
    }
}
