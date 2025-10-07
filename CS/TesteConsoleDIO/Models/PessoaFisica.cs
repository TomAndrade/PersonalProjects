namespace TesteConsoleDIO.Models;

public class PessoaFisica
{
    private string Nome { get; set; }
    private int Idade { get; set; }

    public void InsereAtributos(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    
    public void Apresentarse()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
    }
}