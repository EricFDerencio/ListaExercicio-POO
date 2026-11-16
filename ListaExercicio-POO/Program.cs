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
    int anoModelo=int.Parse(Console.ReadLine());
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
Carro PopulaCarro()
{
    Carro c = new(SetFabricante(), SetModelo(), SetAnoModelo(), SetAnoFabricacao(), SetValorVenda());
    return c;
}
void ImprimeVetor(Carro[] listaCarro)
{
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine(listaCarro[i].ToString());
    }

}

Carro[] listaCarro = new Carro[4];

Console.WriteLine("Carro1");
Carro carro1 = PopulaCarro();
Console.WriteLine("Carro2");
Carro carro2 = PopulaCarro();
Console.WriteLine("Carro3");
Carro carro3 = PopulaCarro();
Console.WriteLine("Carro4");
Carro carro4 = PopulaCarro();

listaCarro[0] = carro1;
listaCarro[1] = carro2;
listaCarro[2] = carro3;
listaCarro[3] = carro4;

ImprimeVetor(listaCarro);