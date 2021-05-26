using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ClasseIndexata
{
    class MyIndexClass
    {
        private string[] elements;

        public MyIndexClass(int elementsNumber)
        {
            // creazione vettore elements con valore di inizializzazione
            elements = new string[elementsNumber];
            for (int i = 0; i < elementsNumber; i++)
            {
                elements[i] = "empty";
            }
        }

        // iteratore
        public string this[int pos]
        {
            // metodo pubblico che restituisce una stringa
            get { return elements[pos]; }
            set { elements[pos] = value; }
        }

        public int length()
        {
            return elements.Length;
        }
    }
}
