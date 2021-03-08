using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Secondo_Progetto_Delegate_Dispense
{
    class OverMaxEventArgs : EventArgs
    {
        public int ValoreSoglia { get; }

        public OverMaxEventArgs(int valoreSoglia)
        {
            ValoreSoglia = valoreSoglia;
        }
    }
}
