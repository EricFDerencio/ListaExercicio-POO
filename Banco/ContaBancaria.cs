public class ContaBancaria
{
    string Titular;
    double Saldo;

    public ContaBancaria(string titular, double saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public double Depositar(double valor)
    {
        if (valor > 0) { Saldo += valor; }

        return Saldo;
    }

    public double Sacar(double valor)
    {
        if (valor > 0) { return Saldo -= valor; }
        return Saldo;
    }

    public double ExibirSaldo()
    {
        return Saldo;
    }

    public override string ToString()
    {
        return
            $"""
            Titular: {Titular}
            Saldo:   {Saldo}
            """;
    }
}
