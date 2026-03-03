using Observer;

class Program
{
    static void Main(string[] args)
    {
        ConcreteSubject Redmi11 = new ConcreteSubject("Redmi 11", 1600, "Sem Estoque");
        Console.WriteLine("Redmi 11 - estado atual: " +  Redmi11.GetDisponibilidade());

        Console.WriteLine("\nObservers inscritos para receber notificações sobre " +
            "o produto Redmi 11\n");

        ConcreteObserver Claudio = new ConcreteObserver("Claudio", Redmi11);
        ConcreteObserver Tati = new ConcreteObserver("Tati", Redmi11);
        ConcreteObserver Fabi = new ConcreteObserver("Fabi", Redmi11);

        Console.WriteLine("\nPressione algo para alterar a disponibilidade e " +
            "notificar os observers\n");
        Console.ReadKey();

        Redmi11.SetDisponibilidade("Disponível");

        Console.Read();

    }
} 