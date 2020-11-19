using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Queue_Pronto_Soccorso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct paziente
        {
            public string nome;
            public int eta;
            public string colore;
            public int temperatura;
        }

        public static Queue<string> codaRosso = new Queue<string>();
        public static Queue<string> codaGiallo = new Queue<string>();
        public static Queue<string> codaVerde = new Queue<string>();
        public static Queue<string> codaBianco = new Queue<string>();

        // temperatura
        public int max = Int32.MinValue;
        public int min = Int32.MaxValue;

        private void btnInserisci_Click(object sender, EventArgs e)
        {


            paziente p = new paziente();
            p.nome = txtNome.Text;
            p.eta = Convert.ToInt32(txtEta.Text);
            p.colore = cmbColore.Text;
            p.temperatura = Convert.ToInt32(txtTemperatura.Text);

            switch (p.colore)
            {
                case "Rosso":
                    codaRosso.Enqueue(p.nome);
                    break;
                case "Giallo":
                    codaGiallo.Enqueue(p.nome);
                    break;
                case "Verde":
                    codaVerde.Enqueue(p.nome);
                    break;
                case "Bianco":
                    codaBianco.Enqueue(p.nome);
                    break;
            }

            if (p.temperatura < min)
            {
                min = p.temperatura;
            }
            if (p.temperatura > max)
            {
                max = p.temperatura;
            }

            txtNome.Text = "";
            txtEta.Text = "";
            cmbColore.Text = "";
            txtTemperatura.Text = "";
        }

        private void btnCura_Click(object sender, EventArgs e)
        {
            if (codaRosso.Count != 0)
            {
                pull(codaRosso);
            }
            else if (codaGiallo.Count != 0)
            {
                pull(codaGiallo);
            }
            else if (codaVerde.Count != 0)
            {
                pull(codaVerde);
            }
            else if (codaBianco.Count != 0)
            {
                pull(codaBianco);
            }
            else
            {
                MessageBox.Show("Temperatura massima: " + max.ToString() + "\nTemperatura minima: " + min.ToString());
                MessageBox.Show("Non ci sono pazienti da curare");
            }
        }

        private void pull(Queue<string> coda)
        {
            string s = coda.Dequeue();
            MessageBox.Show(s);
        }
    }
}
