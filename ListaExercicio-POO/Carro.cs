public class Carro
{
    private string  fabricane;
    private string  modelo;
    private int     anoModelo;
    private int     anoFabricacao;
    private double  valorVenda;

    public Carro(string fabricane, string modelo, int anoModelo, int anoFabricacao, double valorVenda)
    {
        this.fabricane = fabricane;
        this.modelo = modelo;
        this.anoModelo = anoModelo;
        this.anoFabricacao = anoFabricacao;
        this.valorVenda = valorVenda;
    }

    public string GetFabricane() { return fabricane; } 
    public string GetModelo() { return modelo; }
    public int GetAnoModelo() {return anoModelo; }
    public int GetAnoFabricacao() { return anoFabricacao;}
    public double GetValorVenda() { return valorVenda; }

    public override string ToString()
    {
        return 
            $"Fabricante: \t{fabricane} \n" +
            $"Modelo: \t{modelo} \n" +
            $"Ano do Modelo: \t{anoModelo} \n" +
            $"Ano de Fabricação: \t{anoFabricacao} \n" +
            $"Valor de Venda: \t{valorVenda}\n";
    }
}

