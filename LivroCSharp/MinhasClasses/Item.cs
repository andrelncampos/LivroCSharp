using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivroCSharp.MinhasClasses
{
	public class Item
	{
		public Produto Produto { get; set; }
		public int Quantidade { get; set; }
		public double Desconto { get; set; }
	}
}
