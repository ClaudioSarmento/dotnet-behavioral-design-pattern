using Visitor.Visitor;

namespace Visitor.Element;

public interface ILoja
{
    void Visit(IVisitor visitor);
}
