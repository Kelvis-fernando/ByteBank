using POO_Alura.Employees;
using POO_Alura.Sistemas;
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
            CalcularBonificacao();
            UsarPrograma();

            Console.ReadLine();
        }

        public static void UsarPrograma()
        {
            Diretor rafael = new Diretor("Rafaek", "6534545776", 25000);
            rafael.Senha = "123";
            SistemaInterno.Logar(rafael, "1235");

            Desenvolvedor kelvis = new Desenvolvedor("Kelvis", "1234355567", 10000.00);
            kelvis.Senha = "987";
            SistemaInterno.Logar(kelvis, "987");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";
            SistemaInterno.Logar(parceiro, "123");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("Pedro", "23243556456", 3000);
            Auxiliar joao = new Auxiliar("Joao", "345667689898", 2000);
            Diretor rafael = new Diretor("Rafaek", "6534545776", 25000);
            Desenvolvedor kelvis = new Desenvolvedor("Kelvis", "1234355567", 10000.00);

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(joao);
            gerenciador.Registrar(rafael);
            gerenciador.Registrar(kelvis);

            Console.WriteLine("Total de bonificacao do mes: " + gerenciador.GetBonificacao());
        }
    }
}
