static void CadastrarConta(Conta conta)
{
    Console.WriteLine($"\nTipo: {conta.GetType().Name}");
    Console.WriteLine($"Número: {conta.Numero}");

    Console.WriteLine("Informe o saldo inicial da conta: ");
    double saldo = double.Parse(Console.ReadLine());

    Console.WriteLine(conta.Depositar(saldo));
}
static void ExibirContas(Conta[] contas)
{
    Console.WriteLine("\n=== CONTAS ===");

    ExibirConta(contas[0]);
    ExibirConta(contas[1]);
    ExibirConta(contas[2]);
}
static void ExibirConta(Conta conta)
{
    Console.WriteLine(
        $"Tipo: {conta.GetType().Name} | " +
        $"Número: {conta.Numero} | " +
        $"Saldo: {conta.Saldo:C}");

    if (conta is ContaCorrente contaCorrente)
    {
        Console.WriteLine($"Limite: {contaCorrente.Limite:C}");
    }
}
static Conta EscolherConta(Conta[] contas)
{
    Console.WriteLine("\nEscolha uma conta:");
    Console.WriteLine($"1 - {contas[0].GetType().Name} - {contas[0].Numero}");
    Console.WriteLine($"2 - {contas[1].GetType().Name} - {contas[1].Numero}");
    Console.WriteLine($"3 - {contas[2].GetType().Name} - {contas[2].Numero}");

    while (true)
    {
        Console.Write("Opção: ");

        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            if (opcao == 1)
            {
                return contas[0];
            }

            if (opcao == 2)
            {
                return contas[1];
            }

            if (opcao == 3)
            {
                return contas[2];
            }
        }

        Console.WriteLine("Opção inválida.");
    }
}

Conta[] contas =
[
    new ContaCorrente(),
    new ContaPoupanca(),
    new ContaSalario()
];

Console.WriteLine("=== Cadastro das contas ===");

CadastrarConta(contas[0]);
CadastrarConta(contas[1]);
CadastrarConta(contas[2]);

while (true)
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1 - Exibir contas");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Transferir");
    Console.WriteLine("5 - Pagar");
    Console.WriteLine("0 - Sair");

    Console.Write("Escolha uma opção: ");
    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            ExibirContas(contas);
            break;

        case "2":
            {
                Conta conta = EscolherConta(contas);
                Console.WriteLine("Informe o valor do depósito: ");
                double valor = double.Parse(Console.ReadLine());

                Console.WriteLine(conta.Depositar(valor));
                break;
            }

        case "3":
            {
                Conta conta = EscolherConta(contas);
                Console.WriteLine("Informe o valor do saque: ");
                double valor = double.Parse(Console.ReadLine());

                Console.WriteLine(conta.Sacar(valor));
                break;
            }

        case "4":
            {
                Console.WriteLine("\nConta de origem:");
                Conta origem = EscolherConta(contas);

                Console.WriteLine("\nConta de destino:");
                Conta destino = EscolherConta(contas);

                if (origem == destino)
                {
                    Console.WriteLine("As contas não podem ser iguais.");
                    break;
                }

                Console.WriteLine("Informe o valor da transferência: ");
                double valor = double.Parse(Console.ReadLine());

                origem.Tranferir(valor, destino);

                if(origem is ContaCorrente contaCorrenteOrigem)
                {
                    contaCorrenteOrigem.AtualizaLimite();
                }
                if(destino is ContaCorrente contaCorrenteDestino)
                {
                    contaCorrenteDestino.AtualizaLimite();
                }

                Console.WriteLine("Transferência realizada com sucesso.");
                break;
            }

        case "5":
            {
                Conta conta = EscolherConta(contas);
                Console.WriteLine("Informe o valor da conta: ");
                double valor = double.Parse(Console.ReadLine());

                Console.WriteLine(conta.Pagar(valor));
                break;
            }

        case "0":
            Console.WriteLine("Programa encerrado.");
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

