using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura.Employees
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = Nome;
            Cpf = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        // adicionado methods abstratos para implementar nas classes filhos
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}
