using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Gioco_Tresette
{
    public partial class Form1 : Form
    {
        MazzoCarte mazzo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mazzo = new MazzoCarte();
            MessageBox.Show("Mazzo creato");
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (txtSeme.Text != "" && txtValore.Text != "")
            {
                try
                {
                    mazzo.InserisciCarta(txtValore.Text, txtSeme.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Dati mancanti!");
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            mazzo.Mescola();
            Carte aus = mazzo.DammiCarta();
            MessageBox.Show("Carta: " + aus.Valore + " di " + aus.Seme);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (txtSeme.Text != "" && txtValore.Text != "")
            {
                pos = mazzo.DammiCarta(txtValore.Text, txtSeme.Text);
            }
            else
                MessageBox.Show("Dati mancanti!");
            if (pos == -1)
            {
                MessageBox.Show("La carta non è presente nel mazzo");
            }
            else
                MessageBox.Show("Posizione nel mazzo: " + pos);
        }
    }
}
