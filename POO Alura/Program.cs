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
            Cliente usuario2 = new Cliente("Kelvis", "11917646966", "Desenvolvedor");
            Diretor diretorCarlos = new Diretor("Carlos", "121324345", 23000.00);
            ContaCorrente contaKelvis = new ContaCorrente(864, 987653, 1200.40, usuario1);
            ContaCorrente contaFernando = new ContaCorrente(864, 987653, 4, usuario2);
            Funcionario dev = new Funcionario("Joao", "1233455234", 10000.00);

            gerenciador.Registrar(diretorCarlos);


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
            Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

            dev.AumentarSalario();
            diretorCarlos.AumentarSalario();
            Console.WriteLine("Este e o novo salario do dev: " + dev.Salario + " E este o novo salario do diretor: " + diretorCarlos.Salario);

            Console.ReadLine();
        }
    }
}
