using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Form_Di_Registrazione
{
    class Utenti
    {


        public static Utenti caricaUtente(string cognome, string nome, string indirizzo, string citta,
            string cap, string mail, string codfisc, string username, string password)
        {
           /*MessageBox.Show("Campi corretti e salvati nel file");
            StreamWriter sw = new StreamWriter("dati.txt", false);

            //vado ad inserire i dati nel file di testo
            string s = "";
            s = "Cognome: " + txtCognome.Text;
            sw.WriteLine(s);
            s = "Nome: " + txtNome.Text;
            sw.WriteLine(s);
            s = "Indirizzo: " + txtIndirizzo.Text;
            sw.WriteLine(s);
            s = "Città: " + txtCitta.Text;
            sw.WriteLine(s);
            s = "CAP: " + txtCap.Text;
            sw.WriteLine(s);
            s = "Mail: " + txtMail.Text;
            sw.WriteLine(s);
            s = "Codice fisacle: " + txtCod.Text;
            sw.WriteLine(s);
            s = "Username: " + txtUser.Text;
            sw.WriteLine(s);
            s = "Password: " + txtPassword.Text;
            sw.WriteLine(s);

            sw.Close();*/
        }

        public static Utenti caricaUtente((string cognome, string nome, string indirizzo, string citta,
            string cap, string mail, string codfisc, string username, string password) p)
        {
            throw new NotImplementedException();
        }
    }
}
