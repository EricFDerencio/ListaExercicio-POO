namespace Livros;

internal class Livro
{
    private string titulo;
    private string autor;
    private int numeroPaginas;

    public Livro(string titulo, string autor, int numeroPaginas)
    {
        if (numeroPaginas <= 0)
        {
            throw new ArgumentException(
                "O número de páginas deve ser positivo.",
                nameof(numeroPaginas));
        }

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

    public int GetNumeroPaginas()
    {
        return numeroPaginas;
    }

    public override string ToString()
    {
        return $"Título: {titulo}, Autor: {autor}, Número de páginas: {numeroPaginas}";
    }
}