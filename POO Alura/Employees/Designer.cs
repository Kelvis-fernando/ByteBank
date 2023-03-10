using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura.Employees
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf, double salario) : base(nome, cpf, 3000.00)
        {
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
