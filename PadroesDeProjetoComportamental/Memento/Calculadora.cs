namespace Memento;

public class Calculadora : ICalculadora
{
    private int primeiroNumero;
    private int segundoNumero;
    public ICaretaker BackupUltimoCalculo()
    {
        return new Memento(primeiroNumero, segundoNumero);
    }

    public int GetCalculoResultado()
    {
        return primeiroNumero + segundoNumero;
    }

    public void RestauraUltimoCalculo(ICaretaker memento)
    {
        primeiroNumero = ((IOriginator)memento).GetPrimeiroNumero();
        segundoNumero = ((IOriginator)memento).GetSegundoNumero();
    }

    public void SetPrimeiroNumero(int num1)
    {
        primeiroNumero = num1;
    }

    public void SetSegundoNumero(int num2)
    {
        segundoNumero = num2;
    }
}
