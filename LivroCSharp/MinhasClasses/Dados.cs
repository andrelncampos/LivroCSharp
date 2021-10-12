using System;

namespace LivroCSharp.MinhasClasses
{
	public class Dados : IJogos
	{
		private bool _acertou;

		private int _aposta;
		int IJogos.Aposta { get => _aposta; }

		public void Apostar(int aposta)
		{
			if(aposta<1 || aposta > 6)
			{
				throw new Exception("O dado aceita números entre 1 e 6");
			}
			_aposta = aposta;
		}

		public void Jogar()
		{
			Random rnd = new Random();
			int r = rnd.Next(5) + 1;

			if (r == _aposta)
			{
				_acertou = true;
			}
		}

		public bool PegarResultado()
		{
			return _acertou;
		}
		
	}
}
