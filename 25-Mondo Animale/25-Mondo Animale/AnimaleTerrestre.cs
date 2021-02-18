using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Mondo_Animale
{
    class AnimaleTerrestre:Animale
    {
		public AnimaleTerrestre(string s) : base(s)
		{
			//super(s);
		}

		public override string vive()
		{
			return "sulla terraferma";
		}

		public override string chi_sei()
		{
			return "un animale terrestre";
		}
	}
}
