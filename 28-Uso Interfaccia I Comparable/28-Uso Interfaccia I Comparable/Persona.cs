using System;

namespace _28_Uso_Interfaccia_I_Comparable
{
    class Persona : IComparable
    {
        private string nome;
        private string cognome;
        private string citta;

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Citta { get => citta; set => citta = value; }

        public Persona(string nome, string cognome, string citta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Citta = citta;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1; // un oggetto null è più piccolo di true 
            Persona p = obj as Persona;
            return String.Compare(Cognome, p.Cognome, true); // true per il case sensitive
        }

        public override string ToString()
        {
            return Cognome + " " + Nome + " " + Citta;
        }
    }
}
