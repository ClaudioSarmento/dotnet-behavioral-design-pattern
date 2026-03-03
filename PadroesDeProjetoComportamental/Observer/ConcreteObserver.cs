namespace Observer;

public class ConcreteObserver : IObserver
{
    public string Usuario { get; set; }
    public ConcreteObserver(string usuario, ISubject subject)
    {
        Usuario = usuario;
        subject.RegistrarObserver(this);
    }

    public void Atualiza(string disponilibidade)
    {
        Console.WriteLine($"Olá {Usuario}, o Produto que você deseja agora " +
            $"esta {disponilibidade} em nosso site");
    }
}
