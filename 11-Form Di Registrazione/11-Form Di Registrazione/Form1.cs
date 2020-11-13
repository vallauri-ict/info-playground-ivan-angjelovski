using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Form_Di_Registrazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;

            // cognome
            if (txtCognome.Text == "")
            {
                MessageBox.Show("Cognome non inserito!");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            else if (!Regex.IsMatch(txtCognome.Text, @"^[A-Z]{1}[a-z]+$"))
            {
                MessageBox.Show("Formato cognome non valido!");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }

            // nome
            if (txtCognome.Text == "")
            {
                MessageBox.Show("Nome non inserito!");
                valido = false;
                txtNome.BackColor = Color.Salmon;
            }
            else if (!Regex.IsMatch(txtNome.Text, @"^[A-Z]{1}[a-z]+$"))
            {
                MessageBox.Show("Formato nome non valido!");
                valido = false;
                txtNome.BackColor = Color.Salmon;
            }

            // Indirizzo
            if (txtIndirizzo.Text == "")
            {
                MessageBox.Show("Indirizzo non inserito!");
                valido = false;
                txtIndirizzo.BackColor = Color.Salmon;
            }
            else if (!Regex.IsMatch(txtIndirizzo.Text, @"^[A-Za-z\s]+\s\d+$"))
            {
                MessageBox.Show("Formato indirizzo non valido!");
                valido = false;
                txtIndirizzo.BackColor = Color.Salmon;
            }

            // città
            if (txtCitta.Text == "")
            {
                MessageBox.Show("Città non inserita!");
                valido = false;
                txtCitta.BackColor = Color.Salmon;
            }
            else if (!Regex.IsMatch(txtCitta.Text, @"^[A-Z]{1}[a-z]+$"))
            {
                MessageBox.Show("Formato città non valido!");
                valido = false;
                txtCitta.BackColor = Color.Salmon;
            }

            // CAP
            if (txtCAP.Text == "")
            {
                MessageBox.Show("CAP non inserito!");
                valido = false;
                txtCAP.BackColor = Color.Salmon;
            }
            else if (!Regex.IsMatch(txtCAP.Text, @"^\d{5}$"))
            {
                MessageBox.Show("Formato CAP non valido!");
                valido = false;
                txtCAP.BackColor = Color.Salmon;
            }

            // mail
            if (txtMail.Text == "")
            {
                MessageBox.Show("Mail non inserita!");
                valido = false;
                txtMail.BackColor = Color.Salmon;
            }
            else if (!Regex.IsMatch(txtMail.Text, @"^[a-z._-]+\@[a-z]+\.[a-z]{2,6}"))
            {
                MessageBox.Show("Formato mail non valido!");
                valido = false;
                txtMail.BackColor = Color.Salmon;
            }

            // codice fiscale
            if (txtCodFisc.Text == "")
            {
                MessageBox.Show("Codice fiscale non inserito!");
                valido = false;
                txtCodFisc.BackColor = Color.Salmon;
            }
            else if (!Regex.IsMatch(txtCodFisc.Text, @"^[A-Z\d]+$"))
            {
                MessageBox.Show("Formato codice fiscale non valido!");
                valido = false;
                txtCodFisc.BackColor = Color.Salmon;
            }

            // username
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username non inserito!");
                valido = false;
                txtUsername.BackColor = Color.Salmon;
            }
            else if (!Regex.IsMatch(txtUsername.Text, @"^[A-Za-z]+$"))
            {
                MessageBox.Show("Formato username non valido!");
                valido = false;
                txtUsername.BackColor = Color.Salmon;
            }

            // password
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password non inserita!");
                valido = false;
                txtPassword.BackColor = Color.Salmon;
            }
            else if (!Regex.IsMatch(txtPassword.Text, @"^((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20})$"))
            {
                MessageBox.Show("Formato password non valido!");
                valido = false;
                txtPassword.BackColor = Color.Salmon;
            }

            if (valido)
            {
                MessageBox.Show("Registrazione eseguita con successo!");
                Utenti utente = Utenti.caricaUtente((txtCognome.Text, txtNome.Text, txtIndirizzo.Text, txtCitta.Text,
                    txtCAP.Text, txtMail.Text, txtCodFisc.Text, txtUsername.Text, txtPassword.Text));
            }
            else
            {
                MessageBox.Show("Registrazione fallita!");
            }
        }
    }
}
