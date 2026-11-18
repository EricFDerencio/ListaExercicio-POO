public abstract class Conta
{
    public int Numero { get; set; }
    public double Saldo { get; set; }

    public Conta()
    {
        Numero = Random.Shared.Next(100000, 10000000);
        Saldo = 0;
    }

    public virtual string Depositar(double valor)
    {
        Saldo += valor;
        return "Valor depositado com sucesso";
    }
    public virtual string Sacar(double valor) 
    {
        if (valor > Saldo)
        {
            return "Valor de saque acima do saldo em conta";

        }
        Saldo -= valor;
        return "Saque realisado com sucesso";
    }

    public virtual Conta Tranferir(double valor,Conta conta)
    {
        if(valor > Saldo) { valor = Saldo; }
        Saldo -= valor;
        conta.Saldo += valor;

        return conta;
    }
    public virtual string Pagar(double valor) 
    {
        if(valor > Saldo)
        {
            return "Não possui saldo suficiente para pagar a conta";
        }
        Saldo-=valor;
        return "Conta paga com sucesso";
    }
}

