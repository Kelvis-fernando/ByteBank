using POO_Alura;
using System;

namespace POO_Alura
{
    public class ContaCorrente
    {
        private double _saldo = 100.00;
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numero, double saldo, Cliente titular)
        {
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
            Titular = titular;

            TotalDeContasCriadas++;
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nao e possivel atribuir valores negativos!!");
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);

                return true;
            }
        }
    }
}
