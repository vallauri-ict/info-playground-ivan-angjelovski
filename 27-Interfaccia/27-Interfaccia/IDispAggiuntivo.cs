﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Interfaccia
{
    interface IDispAggiuntivo
    {
        int id { get; set; }
        bool status { get; }

        void connetti(string s);

        void disconnetti(string s);
    }
}
