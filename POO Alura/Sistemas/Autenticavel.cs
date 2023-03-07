using POO_Alura.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura.Sistemas
{

    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
