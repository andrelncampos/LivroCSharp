using System;
using LivroCSharp.MinhasClasses;

namespace LivroCSharp.Desafios
{
	public class Dados : IJogos
	{
		public int Aposta { get; set; }
		public bool Acertou { get => Acertou; set => Acertou = value; }

		public void Jogar()
		{
			Acertou = true;
			Random rnd = new Random();
			int r = rnd.Next(5) + 1;

			if (r == Aposta)
			{
				Acertou = true;
			}
		}

	}
}
