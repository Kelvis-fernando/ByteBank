﻿using POO_Alura.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Alura
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao) 
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
        }

        public static implicit operator Cliente(Funcionario v)
        {
            throw new NotImplementedException();
        }
    }
}
