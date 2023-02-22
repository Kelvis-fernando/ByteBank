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
            Cliente usuario = new Cliente();

            usuario.Nome = "Kelvis";
            usuario.Cpf = "11917646966";
            usuario.Profissao = "Desenvolvedor";

            ContaCorrente contaKelvis = new ContaCorrente();
            ContaCorrente contaFernando = new ContaCorrente();
            
            contaKelvis.Titular = usuario;
            contaKelvis.Numero = 08754;
            contaKelvis.Agencia = 865;
            contaKelvis.Saldo = 1500.50;

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

            Console.ReadLine();
        }
    }
}
