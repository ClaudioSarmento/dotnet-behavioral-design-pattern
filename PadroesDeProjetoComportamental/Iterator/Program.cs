using System.Collections;

class ConcreteAggregate : IAggregate
{
    private ArrayList _items = new ArrayList();

    public void AddItem(object item)
    {
        _items.Add(item);
    }

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count
    {
        get { return _items.Count; }
    }

    public object this[int index]
    {
        get { return _items[index]; }
        set
        {
            _items[index] = value;
        }
    }
}

interface IAggregate
{
    IIterator CreateIterator();
    int Count { get; }
    object this[int index] { get; set; }
}

interface IIterator
{
    object First();
    object Next();
    bool IsDone { get; }
    object CurrentItem { get; }

}

class ConcreteIterator : IIterator
{
    private ConcreteAggregate _aggregate;
    private int _currentIndex = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        _aggregate = aggregate;
    }

    public object First()
    {
        return _aggregate[0];
    }

    public object Next()
    {
        object result = null;
        if (_currentIndex < _aggregate.Count - 1)
        {
            _currentIndex++;
            result = _aggregate[_currentIndex];
        }
        return result;
    }

    public bool IsDone
    {
        get { return _currentIndex >= _aggregate.Count - 1; }
    }

    public object CurrentItem
    {
        get { return _aggregate[_currentIndex];  }
    }

}

class Program
{
    static void Main(string[] args)
    {
        ConcreteAggregate aggregate = new ConcreteAggregate();
        aggregate.AddItem("Item 1");
        aggregate.AddItem("Item 2");
        aggregate.AddItem("Item 3");

        IIterator iterator = aggregate.CreateIterator();
        Console.WriteLine("Iterating over collection: ");
        for (object item = iterator.First(); !iterator.IsDone; item = iterator.Next()) 
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}