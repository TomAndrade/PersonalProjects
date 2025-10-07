// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Testando...");

using TesteConsoleDIO.Calc;
using TesteConsoleDIO.Models;

DateTime data = DateTime.Now;

PessoaFisica pessoa1 = new PessoaFisica();

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
pessoa1.InsereAtributos("Fulano",32);
pessoa1.Apresentarse();

CalcComum calcular = new CalcComum();

Console.WriteLine(calcular.Seno(Math.Round(42.2, 4)));

