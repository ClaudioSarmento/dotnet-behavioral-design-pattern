using Visitor.ConcreteElement;
using Visitor.Visitor;

namespace Visitor.ConcreteVisitor;

public class PrecoVisitor : IVisitor
{
    private const int CARRO_DESCONTO = 12;
    public void Accept(Carro carro)
    {
        decimal precoCarroAposDesconto = carro.Preco
            - ((carro.Preco / 100) * CARRO_DESCONTO);
        Console.WriteLine($"{carro.Modelo} {carro.Nome} :" +
            $" R${precoCarroAposDesconto}");
    }
}
