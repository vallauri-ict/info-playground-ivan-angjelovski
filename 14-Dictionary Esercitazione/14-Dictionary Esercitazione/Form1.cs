using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Dictionary_Esercitazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct dizionario
        {
            public int key;
            public string articolo;
        }

        Dictionary<int, dizionario> diz = new Dictionary<int, dizionario>();
        int i = 0;

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            dizionario d;
            d.key = Convert.ToInt32(txtKey.Text);
            d.articolo = txtValue.Text;
            diz.Add(i++, d);
            MessageBox.Show("Inserimento avvenuto con successo");
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lblNumeroArticoli.Text = "Numero Articoli: " + diz.Count;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            lblArticoloCercato.Text = "Articolo Cercato: " + diz[Convert.ToInt32(txtKey.Text)-1].articolo;
        }
    }
}
