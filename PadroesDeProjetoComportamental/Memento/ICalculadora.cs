namespace Memento;

public interface ICalculadora
{
    ICaretaker BackupUltimoCalculo();
    void RestauraUltimoCalculo(ICaretaker memento);
    int GetCalculoResultado();
    void SetPrimeiroNumero(int num1);
    void SetSegundoNumero(int num2);
}
