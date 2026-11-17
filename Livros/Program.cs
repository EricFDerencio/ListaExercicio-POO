// 3- Crie uma classe livro com os atributos, titulo e autor sendo stirng e nropaginas int positivo,
// Crie um construtor que receba esses 3 valores.
// Crie a função get para cada uma das propriedades. Reescreva a função tostring para exibir os dados dos livros.

using Livros;

Livro livro = new Livro(
    "O Senhor dos Anéis",
    "J. R. R. Tolkien",
    1200);

Console.WriteLine(livro.GetTitulo());
Console.WriteLine(livro.GetAutor());
Console.WriteLine(livro.GetNumeroPaginas());

Console.WriteLine(livro);