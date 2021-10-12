using System;
namespace LivroCSharp.MinhasClasses
{
	public class AcerteUmNumero : IJogos
	{
		private bool _acertou;

		private int _aposta;
		int IJogos.Aposta { get => _aposta; }

		public void Apostar(int aposta)
		{
			if(aposta<1 || aposta > 100)
			{
				throw new Exception("Escolha um número entre 1 e 100");
			}
			_aposta = aposta;
		}

		public void Jogar()
		{
			Random rnd = new Random();
			int r = rnd.Next(99) + 1;

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
