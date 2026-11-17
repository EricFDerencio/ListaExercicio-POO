public class Livro
{
    private string titulo;
    private string autor;
    private uint numeroPaginas;

    public Livro(string titulo, string autor, uint numeroPaginas)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.numeroPaginas = numeroPaginas;
    }
  

    public string GetTitulo()
    {
        return titulo;
    }

    public string GetAutor()
    {
        return autor;
    }

    public uint GetNumeroPaginas()
    {
        return numeroPaginas;
    }

    public override string ToString()
    {
        return $"Título: {titulo}, Autor: {autor}, Número de páginas: {numeroPaginas}";
    }
}