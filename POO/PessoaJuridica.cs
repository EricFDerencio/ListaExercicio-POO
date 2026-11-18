using System.Reflection;

public class PessoaJuridica:Pessoa
{
    public string CNPJ { get; set; }
    public string Alias { get; set; }

    public PessoaJuridica(string cnpj, string name, string phone) : base(name, phone)
    {
        CNPJ = cnpj;

    }
    public PessoaJuridica(string cnpj, string name, string phone,string? alias) : base(name, phone)
    {
        CNPJ = cnpj;
        if (string.IsNullOrEmpty(alias)) { alias = Name; }
        Alias = alias;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"""
            CNPJ:                {CNPJ}
            Apelido:             {Alias}

            """;
    }
}