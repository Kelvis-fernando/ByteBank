using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura.Employees
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = Nome;
            Cpf = cpf;
            Salario = salario;
        }
        public double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
