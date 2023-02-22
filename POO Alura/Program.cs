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

            usuario.nome = "Kelvis";
            usuario.cpf = "11917646966";
            usuario.nome = "Desenvolvedor";

            ContaCorrente contaKelvis = new ContaCorrente();
            ContaCorrente contaFernando = new ContaCorrente();
            
            contaKelvis.titular = usuario;
            contaKelvis.numero = 08754;
            contaKelvis.agencia = 865;
            contaKelvis.saldo = 1000.50;

            Console.WriteLine("Usuario" + contaKelvis.titular);

            bool resultadoDoSaque = contaKelvis.Sacar(1000);

            if (resultadoDoSaque)
            {
                Console.WriteLine("O seu saldo atual e: $" + contaKelvis.saldo);
            }
            else
            {
                Console.WriteLine("O seu saldo e insuficiente, o valor atual e de: $" + contaKelvis.saldo);
            }

            contaKelvis.Depositar(200);

            Console.WriteLine("Saldo atual: " + contaKelvis.saldo);

            bool resultadoTransferencia = contaKelvis.Transferir(100000, contaFernando);

            if (resultadoTransferencia)
            {
                Console.WriteLine("Saldo da sua conta pos transferencia: " + contaKelvis.saldo);
            }
            else
            {
                Console.WriteLine("Erro ao fazer a transferencia, saldo insuficiente: $" + contaKelvis.saldo);
            }

            Console.ReadLine();
        }
    }
}
