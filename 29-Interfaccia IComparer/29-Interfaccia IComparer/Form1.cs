using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_Interfaccia_IComparer
{
    public partial class Form1 : Form
    {
        Persona[] vect = {new Persona("Luca","Ariaudo","Fossano"),
                          new Persona("Samuele","De Toffol","Bra"),
                          new Persona("Andrea","Abbate","Alba"),
                          new Persona("Christian","Galloro","Fossano")};
        public Form1()
        {
            InitializeComponent();
            ShowPersona();
        }
        public void ShowPersona()
        {
            string s = "";
            foreach (var item in vect)
            {
                s += item.ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnCognome_Click(object sender, EventArgs e)
        {
            Array.Sort(vect, new Persona.ConfrontaCognome());
            ShowPersona();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            Array.Sort(vect, new Persona.ConfrontaNome());
            ShowPersona();
        }
    }
}
