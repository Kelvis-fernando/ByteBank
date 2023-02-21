using System;

public class ContaCorrente
{
    public string titular;
    public int numero;
    public int agencia;
    public double saldo = 100.00;

    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
}