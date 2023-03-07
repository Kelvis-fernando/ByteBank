using POO_Alura.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura.Employees
{
    public class Desenvolvedor : Autenticavel
    {
        public Desenvolvedor(string name, string cpf, double salario) : base(name, cpf, salario) { }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
            
        }

        public override double GetBonificacao()
        {
            return Salario *= 1.15;
        }
    }
}
