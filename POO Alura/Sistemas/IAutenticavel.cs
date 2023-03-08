using POO_Alura.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura.Sistemas
{

    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
