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
            string nomeUtente = "";

            //cognome
            Regex cognome = new Regex(@"^[A-Z]{1}[a-z]+$");
            controllaValido(txtCognome, cognome, ref valido, "cognome");

            //nome
            Regex nome = new Regex(@"^[A-Z]{1}[a-z]+$");
            controllaValido(txtNome, nome, ref valido, "nome");

            //indirizzo
            Regex indirizzo = new Regex(@"^[A-Z]{1}[a-z]{2}\s[A-Z]{1}[a-z]{1,10}\s\d{1,3}$");
            controllaValido(txtIndirizzo, indirizzo, ref valido, "indirizzo");

            //citta
            Regex citta = new Regex(@"^[A-Z]{1}[a-z]{1,15}$");
            controllaValido(txtCitta, citta, ref valido, "città");

            //cap
            Regex cap = new Regex(@"\d{5}");
            controllaValido(txtCAP, cap, ref valido, "CAP");

            //mail
            Regex mail = new Regex(@"^[A-z0-9\.\+_-]+@[A-z0-9\._-]+\.[A-z]{2,6}$");
            controllaValido(txtMail, mail, ref valido, "mail");

            //codice fiscale
            Regex cod = new Regex(@"^[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$");
            controllaValido(txtCodFisc, cod, ref valido, "codice fiscale");

            //username
            Regex user = new Regex(@"^[A-Z]{1}[a-z]+$");
            controllaValido(txtUsername, user, ref valido, "username");

            //password
            Regex password = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$");
            controllaValido(txtPassword, password, ref valido, "password");

            //controllo dei campi
            if (valido)
            {
                MessageBox.Show("Dati corretti e inseriti nel file");
                //vado ad inserire i dati nel file di testo
                Utenti.inserisciDati(txtCognome, txtCAP, txtCitta, txtCodFisc, txtIndirizzo, txtMail, txtNome, txtUsername, txtPassword);
            }
        }

        private void controllaValido(TextBox txt, Regex rgx, ref bool valido, string campo)
        {
            if (txt.Text == "")
            {
                MessageBox.Show(campo + " mancante");
                valido = false;
                txt.Focus();
            }
            else
            {
                if (!rgx.IsMatch(txt.Text))
                {
                    valido = false;
                    MessageBox.Show(campo + " non valido");
                    txt.Focus();
                }
            }
        }
    }
}
