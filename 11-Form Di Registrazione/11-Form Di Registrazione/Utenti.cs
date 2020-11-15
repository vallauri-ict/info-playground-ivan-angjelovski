using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Form_Di_Registrazione
{
    class Utenti
    {
        

        internal static void inserisciDati(TextBox txtCognome, TextBox txtCAP, TextBox txtCitta, TextBox txtCodFisc, TextBox txtIndirizzo, TextBox txtMail, TextBox txtNome, TextBox txtUsername, TextBox txtPassword)
        {
            StreamWriter sw = new StreamWriter("dati.txt", false);
            string s = "";
            s = "Cognome: " + txtCognome.Text;
            sw.WriteLine(s);
            s = "Nome: " + txtNome.Text;
            sw.WriteLine(s);
            s = "Indirizzo: " + txtIndirizzo.Text;
            sw.WriteLine(s);
            s = "Città: " + txtCitta.Text;
            sw.WriteLine(s);
            s = "CAP: " + txtCAP.Text;
            sw.WriteLine(s);
            s = "Mail: " + txtMail.Text;
            sw.WriteLine(s);
            s = "Codice fiscale: " + txtCodFisc.Text;
            sw.WriteLine(s);
            s = "Username: " + txtUsername.Text;
            sw.WriteLine(s);
            s = "Password: " + txtPassword.Text;
            sw.WriteLine(s);

            sw.Close();
        }
    }
}
