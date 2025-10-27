using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreMetodos
{
    public class MetodosDeClasse
    {
        private double saldo;
        private string senha;
        private string nomeCliente;
        private string numDocumento;

        public MetodosDeClasse(double saldo, string senha, string nomeCliente, string numDocumento)
        {
            this.saldo = 0;
            this.senha = senha;
            this.nomeCliente = nomeCliente;
            this.numDocumento = numDocumento;
        }
        public MetodosDeClasse(string senha, string nomeCliente, string numDocumento)
        {
            this.senha = senha;
            this.nomeCliente = nomeCliente;
            this.numDocumento = numDocumento;
        }

        public double Sacar(double valorSacar, string senhaCliente)
        {
            if (senha == senhaCliente)
            {
                if (saldo > valorSacar)
                {
                    saldo -= valorSacar;
                    Console.WriteLine("Valor sacado foi de: "+ valorSacar);
                    return valorSacar;
                }else
                {
                    Console.WriteLine("Não é possível sacar: saldo insuficiente");
                    return 0;
                }
            }
            Console.WriteLine("A senha está incorreta.");
            return 0;
        }

        public void Depositar(double valorDeposito)
        {
            if (valorDeposito <= 0)
            {
                Console.WriteLine("Insira um valor válido."); return;
            }
            saldo += valorDeposito;
            Console.WriteLine("Foi depositado " + valorDeposito);
        }

        public void ConsultarSaldo(string senhaCliente)
        {
            if (senha != senhaCliente)
            {
                Console.WriteLine("Senha incorreta."); return;
            }
            Console.WriteLine("O saldo da conta é de: " + saldo);
        }
    }
    internal class Program
    {
        public static void Metodos(string param1, string param2, ref string paramRef)
        {
            param1 = "Algo";
            param2 = "Outro";
            // ref é uma espécie de sinalizador que indica que o param de entrada PODE ou não ser modificado pelo método.
            //paramRef = "Exemplo";
        }
        public static double OutroExemplo(double x, double y, out double paramRef)
        {
            // No caso de out é o contrário. Você PRECISA modifica-lo.
            paramRef = x*y;
            return 0.0;
        }

        static void Main(string[] args)
        {
            MetodosDeClasse exemploConta = new MetodosDeClasse(1000,"123456","Fulano","0987654");
            //exemploConta.saldo = 0;
            //exemploConta.senha = "123456";
            //exemploConta.nomeCliente = "Fulano";

            double valorSacado = exemploConta.Sacar(20, "123456");
            exemploConta.Depositar(1000);
            exemploConta.ConsultarSaldo("123456");
            valorSacado = exemploConta.Sacar(20, "123456");
        }
    }
}
