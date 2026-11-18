
public class ContaPoupanca:ContaCorrente
{
    public override string Sacar(double valor)
    {
        valor += valor * 0.05;
        if (valor > Saldo + Limite)
        {
            return "Valor de saque acima do saldo em conta";

        }
        Saldo -= valor;
        AtualizaLimite();
        return "Saque realisado com sucesso";
    }
}

//A conta popança todo o saque desconta 5% de taxa
