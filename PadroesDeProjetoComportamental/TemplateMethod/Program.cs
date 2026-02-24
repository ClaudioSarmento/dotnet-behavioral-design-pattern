using TemplateMethod;

var filmes = Filme.ObterFilmes();

var filmesPorAvaliacao =  new OrdenadorPorAvaliacao().OrdenarFilme(filmes);
var filmesPorTitulo = new OrdenadorPorTitulo().OrdenarFilme(filmes);

Console.WriteLine("Filmes por avaliação\n");
foreach(var filme in filmesPorAvaliacao)
{
    Console.WriteLine($"{filme.ToString()}");
}


Console.WriteLine("\nFilmes por título\n");
foreach (var filme in filmesPorTitulo)
{
    Console.WriteLine($"{filme.ToString()}");
}
