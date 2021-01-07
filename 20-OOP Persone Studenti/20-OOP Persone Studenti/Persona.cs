using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_OOP_Persone_Studenti
{
    class Persona
    {
        protected string nome, cognome, sesso;
        protected int eta;

        public void SetAttributes(string nome, string cognome, string sesso, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.sesso = sesso;
            this.eta = eta;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCognome()
        {
            return this.cognome;
        }

        public string getSesso()
        {
            return this.sesso;
        }

        public int getEta()
        {
            return this.eta;
        }
    }
}
