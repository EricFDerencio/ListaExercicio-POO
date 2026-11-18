public class PessoaFisica:Pessoa
{
    public string CPF { get; set; }
    public char Gender { get; set; }
    public string Mobile { get; set; }


    public PessoaFisica(string cpf,string name, string phone) :base(name,phone)
    {
        CPF=cpf;
    }
    public override string ToString()
    {
        return base.ToString()+
            $"""
            CPF:                {CPF}
            Genero:             {Gender}
            Celular:            {Mobile}

            """;
    }
}