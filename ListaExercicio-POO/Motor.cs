// 4 -No ex VetorCarro Faça uma função que calcule o IPVA previsto do carro,
// Criar uma classe motor com 3 atributos combustivel (tipo) ,cilindrada e potencia que é um atributo de carro,

public class Motor
{
    string Combustivel;
    int Cilindrada;
    int Potencia;

    public Motor()
    {
       
    }

    public void SetCombustive(string c)
    {
        Combustivel = c;
    }
    public void SetCilindrada(int c)
    {
        Cilindrada= c;
    }
    public void SetPotencia(int c)
    {
        Potencia= c;
    }

    public override string ToString()
    {
        return
            $"""
            Combustive: {Combustivel}
            Cilindrada: {Cilindrada}
            Potencia: {Potencia}
            """;
    }
}