using Visitor.ConcreteElement;
using Visitor.ConcreteVisitor;
using Visitor.Element;

Console.WriteLine("### Padrão Visitor ###");

List<Carro> carros = new List<Carro>();
carros.Add(new Carro() { Nome = "A1", Preco = 2000M, Modelo = "Mercedes" });
carros.Add(new Carro() { Nome = "458", Preco = 3500M, Modelo = "Ferrari" });
carros.Add(new Carro() { Nome = "718 GTS", Preco = 2800M, Modelo = "Porsche" });

List<ILoja> lojas = new List<ILoja>();

Console.WriteLine("Preços normais dos carros\n");
foreach(var carro in carros)
{
    Console.WriteLine($" {carro.Modelo} {carro.Nome} : R${carro.Preco}");
    lojas.Add(carro);
}

Console.WriteLine("\nPreços dos carros com desconto");
Console.WriteLine("Aplicando padrão Visitor");
Console.WriteLine("tecle algo...");

Console.ReadLine();
Console.WriteLine("Novos Preços com desconto de 12%\n");

//Exibe o preço de cada item usando o Visitor
PrecoVisitor precoVisitor = new PrecoVisitor();
foreach(var element in lojas)
{
    element.Visit(precoVisitor);
}

Console.ReadLine();