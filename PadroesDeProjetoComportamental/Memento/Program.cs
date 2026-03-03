using Memento;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Padrão Memento");
        
        ICalculadora calculadora = new Calculadora();

        calculadora.SetPrimeiroNumero(10);
        calculadora.SetSegundoNumero(100);

        Console.WriteLine($"Estado 1: {calculadora.GetCalculoResultado()}");

        ICaretaker memento = calculadora.BackupUltimoCalculo();
        Console.ReadKey();

        Console.WriteLine("\nCalcula uma nova soma de dois numeros\n");

        calculadora.SetPrimeiroNumero(17);
        calculadora.SetSegundoNumero(-290);

        Console.WriteLine($"Estado 2: {calculadora.GetCalculoResultado()}");

        Console.WriteLine("\nRestaura o resultado da soma anterior\n");

        calculadora.RestauraUltimoCalculo(memento);

        Console.WriteLine($"Estado 1: {calculadora.GetCalculoResultado()}");

        Console.ReadKey();
    }
}