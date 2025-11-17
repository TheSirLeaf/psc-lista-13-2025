public class Funcionario : Pessoa
{
    private double salario;
    private string cargo;

    public Funcionario(string nome, string cpf, int idade, double salario, string cargo) : base(nome, cpf, idade)
    {
        this.salario = salario;
        this.cargo = cargo;
    }

    public double calcularSalarioAnual()
    {
        return salario * 12;
    }

    public string GetCargo()
    {
        return cargo;
    }
}
