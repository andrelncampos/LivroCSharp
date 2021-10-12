namespace LivroCSharp.MinhasClasses
{
	public interface IJogos
	{
		/* Propriedade para gardar a aposta */
		protected int Aposta { get; }

		/* Envia um número para aposta */
		public void Apostar(int aposta);

		/* Executa o jogo */
		public void Jogar();

		/* True para Acertou e False para não acertou */
		public bool PegarResultado();

	}
}
