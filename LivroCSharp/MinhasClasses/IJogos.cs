using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivroCSharp.MinhasClasses
{
	public interface IJogos
	{
		public int Aposta { get; set; }
		public bool Acertou { get; }

		public void Jogar();

	}
}
