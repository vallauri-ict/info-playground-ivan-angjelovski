using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Scopa
{
    class Carta
    {
        private string seme;
        private int valore;

        public string SEME
        {
            get => seme;
            set => seme = value;
        }

        public int VALORE
        {
            get => valore;
            set => valore = value;
        }

        public void lettura()
        {
            MessageBox.Show("Valore: " + valore.ToString() + "\nSeme: " + seme.ToString());
        }
    }
}
