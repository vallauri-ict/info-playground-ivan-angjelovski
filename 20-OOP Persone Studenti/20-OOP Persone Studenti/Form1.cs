using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_OOP_Persone_Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Studente> lstStudenti = new List<Studente>();

        private void btnCarica_Click(object sender, EventArgs e)
        {
            try
            {
                Studente s = new Studente();
                s.SetAttributes(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
                lstStudenti.Add(s);
                lstVwStudenti.Items.Add(s.getCognome());

                txtNome.Text = null;
                txtCognome.Text = null;
                txtEta.Text = null;
                txtSesso.Text = null;
            }
            catch
            {
                MessageBox.Show("Campi compilati in modo errato");
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            string studenteSelezionato = lstVwStudenti.SelectedItems[0].Text;
            foreach (var studente in lstStudenti)
            {
                if (studente.getCognome() == studenteSelezionato)
                {
                    MessageBox.Show("La media dei voti di " + studente.getCognome() + " è " + studente.media().ToString());
                }
            }
        }

        // questo programma non tiene conto degli omonimi
        private void btnAggiungiVoto_Click(object sender, EventArgs e)
        {
            try
            {
                int voto = Convert.ToInt32(txtVoto.Text);
                string studenteSelezionato = lstVwStudenti.SelectedItems[0].Text;
                foreach (var studente in lstStudenti)
                {
                    if (studente.getCognome() == studenteSelezionato)
                    {
                        studente.voti.Add(voto);
                    }
                }
                txtVoto.Text = "";
            }
            catch
            {
                MessageBox.Show("Inserisci prima un voto");
            }
        }
    }
}
