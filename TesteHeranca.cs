using System;

class TesteHeranca
{
	static void Main(string[] args)
	{
		Pessoa p = new Pessoa("Ana Silva", "123.456.789-00", 30);
		Funcionario f = new Funcionario("Bruno Souza", "987.654.321-00", 28, 3500.0, "Analista");
		Gerente g = new Gerente("Carla Pereira", "111.222.333-44", 40, 8000.0, "Gerente", "TI");

		p.exibirDadosBasicos();
		Console.WriteLine();

		f.exibirDadosBasicos();
		Console.WriteLine("Salario anual: " + f.calcularSalarioAnual());
		Console.WriteLine();

		g.exibirDadosBasicos();
		Console.WriteLine("Salario anual: " + g.calcularSalarioAnual());
	}
}
