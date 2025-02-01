Subject subject = new Subject();
Observer alice = new Observer("Alice");
Observer bob = new Observer("Bob");

subject.Attach(alice);
subject.Attach(bob);
subject.SetState("Update 1"); // Alice and Bob receive notification

class Subject  // Subject maintains state and notifies observers
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _state;

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void SetState(string state)
    {
        _state = state;
        Notify();
    }
    private void Notify() => _observers.ForEach(o => o.Update(_state));
}

interface IObserver { void Update(string state); } // Observer interface
class Observer : IObserver // Concrete Observer
{
    private string _name;
    public Observer(string name) => _name = name;
    public void Update(string state) => Console.WriteLine(_name + " received: " + state);
}
