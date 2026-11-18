public class ContaCorrente : Conta
{
    public double Limite { get; set; }

    public ContaCorrente()
    {
        Limite = 3 * Saldo;
    }

    public override string Depositar(double valor)
    {
        Saldo += valor;
        AtualizaLimite();
        return "Valor depositado com sucesso";
    }
    public override string Sacar(double valor)
    {
        if (valor > Saldo + Limite)
        {
            return "Valor de saque acima do saldo em conta";

        }
        Saldo -= valor;
        AtualizaLimite();
        return "Saque realisado com sucesso";
    }

    public override Conta Tranferir(double valor, Conta conta)
    {
        if (valor > Saldo + Limite) { valor = Saldo + Limite; }
        Saldo -= valor;
        AtualizaLimite();
        conta.Saldo += valor;


        return conta;
    }
    public ContaCorrente Tranferir(double valor, ContaCorrente conta)
    {
        if (valor > Saldo + Limite) { valor = Saldo + Limite; }
        Saldo -= valor;
        AtualizaLimite();
        conta.Saldo += valor;
        conta.AtualizaLimite();


        return conta;
    }
    public ContaPoupanca Tranferir(double valor, ContaPoupanca conta)
    {
        if (valor > Saldo + Limite) { valor = Saldo + Limite; }
        Saldo -= valor;
        AtualizaLimite();
        conta.Saldo += valor;
        conta.AtualizaLimite();


        return conta;
    }
    public override string Pagar(double valor)
    {
        if (valor > Saldo + Limite)
        {
            return "Não possui saldo suficiente para pagar a conta";
        }
        Saldo -= valor;
        AtualizaLimite();
        return "Conta paga com sucesso";
    }

    public void AtualizaLimite()
    {
        if (Saldo < 0)
        {
            Limite = 0;
        }
        else
        {
            Limite = Saldo * 3;
        }
    }
}
