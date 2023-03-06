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
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void AumentarSalario()
        {
             Salario *= 1.1;
        }
    }
}
