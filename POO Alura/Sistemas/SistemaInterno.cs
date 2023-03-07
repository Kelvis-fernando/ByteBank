using POO_Alura.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura.Sistemas
{
    public class SistemaInterno
    {
        public static bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }

            Console.WriteLine("Erro ao logar");
            return false;
        }
    }
}
