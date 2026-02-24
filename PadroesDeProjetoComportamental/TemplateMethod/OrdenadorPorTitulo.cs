namespace TemplateMethod;

public class OrdenadorPorTitulo : OrdernadorTemplateMethod
{
    public override bool IsPrimeiro(Filme filme1, Filme filme2)
    {
        return string.Compare(filme1.Titulo, filme2.Titulo, StringComparison.CurrentCultureIgnoreCase) <= 0;
    }
}
