using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura.Employees
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        // Se eu quiser sobre escrever uma func que e herdada de outra classe, basta dar um virtual na classe pai e override na classe derivada
        public override double GetBonificacao()
        {
            return Salario *= 0.2 ;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
