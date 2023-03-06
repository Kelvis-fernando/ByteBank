﻿using POO_Alura.Employees;
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

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("Pedro", "23243556456", 3000);
            Auxiliar joao = new Auxiliar("Joao", "345667689898", 2000);
            Diretor rafael = new Diretor("Rafaek", "6534545776", 25000);

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(joao);
            gerenciador.Registrar(rafael);

            Console.WriteLine("Total de bonificacao do mes: " + gerenciador.GetBonificacao());
        }
    }
}
