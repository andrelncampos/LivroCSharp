using System.Collections;
using System.Collections.Generic;

namespace LivroCSharp.MinhasClasses
{
	public class JogoTeste : IList
	{
		List<string> x;


		int IJogos.Aposta => throw new System.NotImplementedException();

		public void Apostar(int aposta)
		{
			throw new System.NotImplementedException();
		}

		public void Jogar()
		{
			throw new System.NotImplementedException();
		}

		public bool PegarResultado()
		{
			throw new System.NotImplementedException();
		}

	}
}

