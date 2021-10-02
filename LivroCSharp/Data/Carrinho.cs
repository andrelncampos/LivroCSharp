using System.Collections.Generic;
using LivroCSharp.MinhasClasses;

namespace LivroCSharp.Data
{
	public static class Carrinho
	{

		private static List<Item> Itens { get; set; } = new List<Item>();

		public static List<Item> CarrinhoLista()
		{
			return Itens;
		}

		public static void CarrinhoAdicionar(Produto produto, int quantidade)
		{
			if (quantidade == 0) { return; }

			Item item = Itens.Find(p => p.Produto.Codigo == produto.Codigo);

			if (item == null)
			{
				// O item não existia no carrinho.
				Itens.Add(new Item { Produto = produto, Quantidade = quantidade });
			}
			else
			{
				// O item já existia. Adicionar a quantidade.
				item.Quantidade += quantidade;
			}
		}

		public static void CarrinhoExcluir(Produto produto)
		{
			Item item = Itens.Find(p => p.Produto.Codigo == produto.Codigo);

			if (item!=null)
			{
				Itens.Remove(item);
			}
		}

		public static decimal CarrinhoTotal()
		{
			decimal retorno=0;

			foreach(Item item in Itens)
			{
				retorno += (item.Produto.Preco * item.Quantidade);
			}

			return retorno;
		}
	}
}
