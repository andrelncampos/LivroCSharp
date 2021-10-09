using System.Collections.Generic;

namespace LivroCSharp.MinhasClasses
{
	public class BancoDados
	{
		public List<Funcionario> Funcionarios { get; set; }

		public BancoDados()
		{
			Funcionarios = new List<Funcionario>();

			Funcionario f1 = new Funcionario
			{
				Nome = "João",
				Departamento = "Vendas",
				Genero = "M",
				Salario = 4600
			};
			Funcionarios.Add(f1);

			Funcionario f2 = new Funcionario
			{
				Nome = "Maria",
				Departamento = "Vendas",
				Genero = "F",
				Salario = 5200
			};
			Funcionarios.Add(f2);

			Funcionario f3 = new Funcionario
			{
				Nome = "Jose",
				Departamento = "Sistemas",
				Genero = "M",
				Salario = 9500
			};
			Funcionarios.Add(f3);

			Funcionario f4 = new Funcionario
			{
				Nome = "Clara",
				Departamento = "Sistemas",
				Genero = "F",
				Salario = 10500
			};
			Funcionarios.Add(f4);

			Funcionario f5 = new Funcionario
			{
				Nome = "Sandro",
				Departamento = "Sistemas",
				Genero = "M",
				Salario = 10200
			};
			Funcionarios.Add(f5);

			Funcionario f6 = new Funcionario
			{
				Nome = "Fábio",
				Departamento = "Planejamento",
				Genero = "M",
				Salario = 7400
			};
			Funcionarios.Add(f6);

			Funcionario f7 = new Funcionario
			{
				Nome = "Suelen",
				Departamento = "RH",
				Genero = "F",
				Salario = 6500
			};
			Funcionarios.Add(f7);

			Funcionario f8 = new Funcionario
			{
				Nome = "Daniele",
				Departamento = "Marketing",
				Genero = "F",
				Salario = 8000
			};
			Funcionarios.Add(f8);

			Funcionario f9 = new Funcionario
			{
				Nome = "Adriana",
				Departamento = "Marketing",
				Genero = "F",
				Salario = 7100
			};
			Funcionarios.Add(f9);

			Funcionario f10 = new Funcionario
			{
				Nome = "Rogério",
				Departamento = "Marketing",
				Genero = "M",
				Salario = 7000
			};
			Funcionarios.Add(f10);
		}
	}

	public class Funcionario
	{
		public string Nome { get; set; }
		public string Departamento { get; set; }
		public decimal Salario { get; set; }
		public string Genero { get; set; }
	}

}
