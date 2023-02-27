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
            Cliente usuario1 = new Cliente("Kelvis", "11917646966", "Desenvolvedor");
            Cliente usuario2 = new Cliente("Fernando", "12354267899", "Contador");
            Cliente usuario3 = new Cliente("Fernando", "12354267899", "Contador");

            ContaCorrente contaKelvis = new ContaCorrente(864, 987653, 1200.40, usuario1);
            ContaCorrente contaFernando = new ContaCorrente(864, 0098763, 500.50, usuario2);
            ContaCorrente contaTeste = new ContaCorrente(864, 0098763, 500.50, usuario3);


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

            Console.ReadLine();
        }
    }
}
