public class Gerente : Funcionario
{
    private string departamento;

    public Gerente(string nome, string cpf, int idade, double salario, string cargo, string departamento) : base(nome, cpf, idade, salario, cargo)
    {
        this.departamento = departamento;
    }

    public override void exibirDadosBasicos()
    {
        base.exibirDadosBasicos();
        System.Console.WriteLine("Cargo: " + GetCargo());
        System.Console.WriteLine("Departamento: " + departamento);
    }
}
