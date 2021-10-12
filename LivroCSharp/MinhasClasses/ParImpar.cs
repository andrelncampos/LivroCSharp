using System;

namespace LivroCSharp.MinhasClasses
{
	public class ParImpar : IJogos
	{
		private bool _acertou;

		private int _aposta;
		int IJogos.Aposta => _aposta;

		public void Apostar(int aposta)
		{
			if (aposta < 1 || aposta > 2)
			{
				throw new Exception("Envie 1 para ímpar e 2 para par.");
			}

			_aposta = aposta;
		}

		public void Jogar()
		{
			Random rnd = new Random();
			int r = rnd.Next(10);

			_acertou = false;
			if (r % 2 == 0)
			{
				// É par
				if (_aposta == 2) _acertou = true;
			}
			else
			{
				if (_aposta == 1) _acertou = true;
			}
		}

		public bool PegarResultado()
		{
			return _acertou;
		}
	}
}
