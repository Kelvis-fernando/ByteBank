using POO_Alura.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Cliente usuario1 = new Cliente("Kelvis", "11917646966", "Desenvolvedor");
            Cliente usuario2 = new Funcionario("Fernando", "12354267899", 2134.45);
            Diretor diretorCarlos = new Diretor("Carlos", "121324345", 23000.00);

            gerenciador.Registrar(usuario2);

            ContaCorrente contaKelvis = new ContaCorrente(864, 987653, 1200.40, usuario1);
            ContaCorrente contaFernando = new ContaCorrente(864, 0098763, 500.50, usuario2);


            Console.WriteLine("Agencia e conta: " + contaKelvis.Agencia + " " + contaKelvis.Numero);

            Console.WriteLine("Usuario: " + contaKelvis.Titular.Nome);

            bool resultadoDoSaque = contaKelvis.Sacar(1000);

            if (resultadoDoSaque)
            {
                Console.WriteLine("O seu saldo atual e: $" + contaKelvis.Saldo);
            }
            else
            {
                Console.WriteLine("O seu saldo e insuficiente, o valor atual e de: $" + contaKelvis.Saldo);
            }

            contaKelvis.Depositar(200);

            Console.WriteLine("Saldo atual: " + contaKelvis.Saldo);

            bool resultadoTransferencia = contaKelvis.Transferir(100000, contaFernando);

            if (resultadoTransferencia)
            {
                Console.WriteLine("Saldo da sua conta pos transferencia: " + contaKelvis.Saldo);
            }
            else
            {
                Console.WriteLine("Erro ao fazer a transferencia, saldo insuficiente: $" + contaKelvis.Saldo);
            }

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            ////////////////////////////////////

            Funcionario novoFuncionario = new Funcionario("Joao", "12345678955", 5000.50);
            Console.WriteLine("Bonificacao funcionario: " + novoFuncionario.GetBonificacao());

            Console.ReadLine();
        }
    }
}
