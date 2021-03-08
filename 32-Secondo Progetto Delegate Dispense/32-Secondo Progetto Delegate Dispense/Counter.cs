using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Secondo_Progetto_Delegate_Dispense
{
    public delegate void OverMaxEventHandler(object sender, OverMaxEventArgs e);

    class Counter
    {
        public event OverMaxEventHandler OverMax;
        private int maxVal;
        public int counter = 0;
        public Counter(int n)
        {
            if (n > 10)
            {
                throw new ArgumentException("Il valore massimo è 10");
            }
            else
            {
                maxVal = n;
            }
        }

        public void Incrementa()
        {
            counter++;
            if (counter >= maxVal)
            {
                OverMaxEventArgs e = new OverMaxEventArgs(counter);
                OnOverMax(this, e);
            }
        }

        private void OnOverMax(object sender, OverMaxEventArgs e)
        {
            if (OverMax != null) // se OverMax punta ad una funzione (se è stato gestito al di fuori della nostra classe)
            {
                OverMax(sender, e);
            }
        }
    }
}
