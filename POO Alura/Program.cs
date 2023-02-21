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
            contaKelvis.saldo = 1234.5;
            contaKelvis.numero = 08754;
            contaKelvis.agencia = 865;

            Console.WriteLine(contaKelvis.titular);
            Console.WriteLine(contaKelvis.numero);
            Console.WriteLine(contaKelvis.agencia);
            Console.WriteLine(contaKelvis.saldo);

            Console.ReadLine();
        }
    }
}
