﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Mondo_Animale
{
    class Animale
    {
		protected string nome;
		protected string verso;

		public Animale(string s)
		{
			nome = s;
		}

		public abstract string si_muove();

		public abstract string vive();

		public abstract string chi_sei();

		public void mostra()
		{
			Console.WriteLine(nome + ", " + chi_sei() + ", " + verso + ", si muove " + si_muove() + " e vive " + vive());
		}
	}
}
