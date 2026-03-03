namespace Observer;

public class ConcreteSubject : ISubject
{
    private List<IObserver> Observers = new List<IObserver>();
    private string Produto { get; set; }
    private int Preco { get; set; }
    private string Disponibilidade { get; set; }
    public ConcreteSubject(string produto, int preco, string disponibilidade)
    {
        Produto = produto;
        Preco = preco;
        Disponibilidade = disponibilidade;
    }

    public string GetDisponibilidade()
    {
        return Disponibilidade;
    }

    public void SetDisponibilidade(string disponibilidade)
    {
        Disponibilidade = disponibilidade;
        Console.WriteLine("A disponibilidade mudou de 'Sem Estoque' para 'Disponível'");
        NotificarObservers();
    }

    public void RegistrarObserver(IObserver observer)
    {
        Console.WriteLine("Observer Adicionado : " + ((ConcreteObserver)observer).Usuario);
        Observers.Add(observer);
    }

    public void AdicionarObservers(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoverObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void NotificarObservers()
    {
        Console.WriteLine($"O Produto: {Produto} no valor R${Preco} agora está disponível");
        Console.WriteLine($"Notificando todos os Observers registrados");

        Console.WriteLine();

        foreach(IObserver observer in Observers)
        {
            observer.Atualiza(Disponibilidade);
        }
    }
}
