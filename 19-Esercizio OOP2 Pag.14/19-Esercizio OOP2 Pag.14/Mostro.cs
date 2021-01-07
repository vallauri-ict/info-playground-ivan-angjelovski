using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_Esercizio_OOP2_Pag._14
{
    public class Mostro
    {
        public string nome;

        public Mostro() : this("Mostro") // richiama un altro costruttore che in questo caso è string nome \/
        {

        }

        public Mostro(string nome)
        {
            this.nome = nome;
        }

        public void Rivela()
        {
            MessageBox.Show(nome);
        }

    }
}
