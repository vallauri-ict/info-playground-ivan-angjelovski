using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _23_Esempio_Classe_Astratta
{
    class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        private DateTime dataNascita;

        public string nomeCompleto()
        {
            return Nome + " " + Cognome;
        }
    }
}
