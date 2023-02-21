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
            ContaCorrente contaKelvis = new ContaCorrente();
            contaKelvis.titular = "Kelvis";
            contaKelvis.numero = 08754;
            contaKelvis.agencia = 865;
            contaKelvis.saldo = 1000.50;

            Console.WriteLine(contaKelvis.titular);
            Console.WriteLine(contaKelvis.numero);
            Console.WriteLine(contaKelvis.agencia);
            Console.WriteLine(contaKelvis.saldo);

            bool resultadoDoSaque = contaKelvis.Sacar(100);

            if (resultadoDoSaque)
            {
                Console.WriteLine("O seu saldo atual e: $" + contaKelvis.saldo);
            }
            else
            {
                Console.WriteLine("O seu saldo e insuficiente, o valor atual e de: $" + contaKelvis.saldo);
            }

            Console.ReadLine();
        }
    }
}
