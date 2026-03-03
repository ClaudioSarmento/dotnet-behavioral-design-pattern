namespace Observer;

public interface ISubject
{
    void NotificarObservers();
    void RegistrarObserver(IObserver observer);
    void RemoverObserver(IObserver observer);
}
