using System.Collections.Generic;
using LivroCSharp.MinhasClasses;

namespace LivroCSharp.Data
{
	public static class Produtos
	{
		private static List<Produto> Itens { get; set; }
		public static string ProdutosFiltro { get; set; }

		public static int ProdutosTotal { get => Itens.Count; }
		public static List<Produto> ProdutosLista()
		{
			if(ProdutosFiltro!="")
			{
				return Itens;
			}
			else
			{
				List<Produto> listaFiltrada = new List<Produto>();
				foreach(Produto p in Itens)
				{
					if(p.Nome.ToUpper().IndexOf(ProdutosFiltro.ToUpper()) < 0)
					{
						listaFiltrada.Add(p);
					}
				}
				return listaFiltrada;
			}
		}

		static Produtos()
		{
			Itens = new List<Produto>();
		}

		public static void ProdutosFiltrar(string filtro)
		{
			ProdutosFiltro = filtro;
		}

		public static void ProdutosLimparFiltro()
		{
			ProdutosFiltro = "";
		}

		public static void ProdutosIncluir(Produto p)
		{

			Produto produtoEncontrado = ProdutosLista().Find(
					produtoLista => produtoLista.Codigo == p.Codigo
				);
			int codigo = 1;

			if (produtoEncontrado != null)
			{
				// Produto já existia na lista
				produtoEncontrado = p;
			}
			else
			{
				// Produto não existia na lista
				int total = ProdutosTotal;

				if (total > 0)
				{
					codigo = ProdutosLista()[total - 1].Codigo + 1;
				}

				p.Codigo = codigo;
				Itens.Add(p);
			}
		}

		public static void ProdutosExcluir(int produtoCodigo)
		{
			Produto produtoEncontrado = Itens.Find(
					produto => produto.Codigo == produtoCodigo
				);

			if (produtoEncontrado != null)
			{
				Itens.Remove(produtoEncontrado);
			}
		}
	}
}
