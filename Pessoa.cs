public class Pessoa
{
    protected string nome;
    protected string cpf;
    protected int idade;

    public Pessoa(string nome, string cpf, int idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
    }

    public virtual void exibirDadosBasicos()
    {
        System.Console.WriteLine("Nome: " + nome);
        System.Console.WriteLine("CPF: " + cpf);
        System.Console.WriteLine("Idade: " + idade);
    }
}
