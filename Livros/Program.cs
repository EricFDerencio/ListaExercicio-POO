// 3- Crie uma classe livro com os atributos, titulo e autor sendo stirng e nropaginas int positivo,
// Crie um construtor que receba esses 3 valores.
// Crie a função get para cada uma das propriedades. Reescreva a função tostring para exibir os dados dos livros.

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
    int nroPaginas;
    do
        nroPaginas = int.Parse(Console.ReadLine());
    while (nroPaginas <= 0);

    Livro livro = new(titulo,autor,nroPaginas);

    return livro;
}

Livro[] PopulaVetorLivro(Livro[] livro)
{
   
    for (int i = 0; i < livro.Length; i++)
    {
        livro[i] = PopulaLivro();
    }
    return livro;
}
void ExibeVetor(Livro[] livro)
{
    for(int i = 0;i < livro.Length; i++)
    {
        Console.WriteLine(livro[i].ToString());
    }
}

Livro[] livro = new Livro[3];
livro = PopulaVetorLivro(livro);

ExibeVetor(livro);

