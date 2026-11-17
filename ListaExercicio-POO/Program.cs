// 1 - Faça um programa que crie 4 objetos de carro onde tenham fabricante, modelo, ano de fabricação, ano de modelo e valor de venda.
// Grave esses carros em um vetor e faça a exibição do mesmo 

string SetFabricante()
{
    Console.WriteLine("Digite o Fabricante do Veiculo: ");
    string fabricante = Console.ReadLine();
    return fabricante;
}
string SetModelo()
{
    Console.WriteLine("Digite o Modelo do Veiculo: ");
    string modelo = Console.ReadLine();
    return modelo;
}
int SetAnoModelo()
{
    Console.WriteLine("Digite o Ano do Modelo do Veiculo: ");
    int anoModelo = int.Parse(Console.ReadLine());
    return anoModelo;
}
int SetAnoFabricacao()
{
    Console.WriteLine("Digite o Ano de Fabricação do Veiculo: ");
    int anoFabricacao = int.Parse(Console.ReadLine());
    return anoFabricacao;
}
double SetValorVenda()
{
    Console.WriteLine("Digite o Valor da venda do Veiculo: ");
    double valorVenda = double.Parse(Console.ReadLine());
    return valorVenda;
}

Motor PopularMotor()
{
    Motor m = new();
    Console.WriteLine("Digite o tipo de gasolina do motor: ");
    m.SetCombustive(Console.ReadLine());
    Console.WriteLine("Digite a cilindrada: ");
    m.SetCilindrada(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite a potencia: ");
    m.SetPotencia(int.Parse(Console.ReadLine()));

    return m;
}
Carro PopulaCarro()
{
    Carro c = new(SetFabricante(), SetModelo(), SetAnoModelo(), SetAnoFabricacao(), SetValorVenda(),PopularMotor());
    return c;
}
Carro[] PopulaVetor()
{
    Carro[] c = new Carro[4];
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Carro " + i);
        c[i] = PopulaCarro();
    }
    return c;
}
void ImprimeVetor(Carro[] listaCarro)
{
    const double aliquotaIpva = 4.0;

    for (int i = 0; i < listaCarro.Length; i++)
    {
        double ipva = listaCarro[i].CalcularIpva(aliquotaIpva);

        Console.WriteLine(listaCarro[i]);
        Console.WriteLine($"IPVA previsto: {ipva:C2}");
        Console.WriteLine();
    }
}


Carro[] listaCarro = new Carro[4];

listaCarro = PopulaVetor();

ImprimeVetor(listaCarro);