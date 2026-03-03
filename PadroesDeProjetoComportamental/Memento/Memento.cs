namespace Memento;

public class Memento : ICaretaker, IOriginator
{
    private int primeiroNumero;
    private int segundoNumero;

    public Memento(int primeiroNumero, int segundoNumero)
    {
        this.primeiroNumero = primeiroNumero;
        this.segundoNumero = segundoNumero;
    }

    public int GetPrimeiroNumero()
    {
        return primeiroNumero;
    }

    public int GetSegundoNumero()
    {
        return segundoNumero;
    }
}
