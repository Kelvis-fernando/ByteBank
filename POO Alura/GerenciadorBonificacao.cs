using POO_Alura.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura
{
    internal class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetBonificacao()
        {
            return _totalBonificacao;
        }

        internal void Registrar(Cliente usuario2)
        {
            throw new NotImplementedException();
        }
    }
}
