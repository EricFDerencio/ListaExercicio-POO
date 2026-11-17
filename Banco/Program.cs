// 2- Crie uma classe ContaBancaria e os atributos titular como string e saldo como double.
// Adicione os seguintes metodos à classe depositar recebendo um parametro double,
// sacar recebendo um parametro Double,
// Exibir saldo mostrando o saldo formatado e
// Tostring exibindo as informações da conta

ContaBancaria conta = new("Eric", 120.00);

Console.WriteLine(conta.Depositar(500));
Console.WriteLine(conta.Sacar(200));

Console.WriteLine(conta.ExibirSaldo());

Console.WriteLine(conta.ToString());