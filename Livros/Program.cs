// 3- Crie uma classe livro com os atributos, titulo e autor sendo stirng e nropaginas int positivo,
// Crie um construtor que receba esses 3 valores.
// Crie a função get para cada uma das propriedades. Reescreva a função tostring para exibir os dados dos livros.

int DefineTamanhoVetor()
{
    int x = 0;
    int i = -1;
    while (x == 0)
    {
        i = int.Parse(Console.ReadLine());
        if (x <= 0) x = 0;
    }

    return i;
}
bool ValidaLivro(int paginas)
{
    if (paginas < 0) { return false; }
    return true;
}
Livro PopulaLivro()
{
    Console.WriteLine("Titulo: ");
    string titulo = Console.ReadLine();
    Console.WriteLine("Autor: ");
    string autor = Console.ReadLine();
    Console.WriteLine("Nro Paginas");
    uint nroPaginas;
    do
        nroPaginas = uint.Parse(Console.ReadLine());
    while (nroPaginas <= 0);

    return new(titulo, autor, nroPaginas);
}
Livro[] PopulaVetorLivro()
{
    int x = DefineTamanhoVetor();
    Livro[] livro = new Livro[x];

    for (int i = 0; i < livro.Length; i++)
    {
        livro[i] = PopulaLivro();
    }
    return livro;
}
void ExibeVetor(Livro[] livro)
{
    for (int i = 0; i < livro.Length; i++)
    {
        Console.WriteLine(livro[i].ToString());
    }
}


ExibeVetor(PopulaVetorLivro());

