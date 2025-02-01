ChatMediator mediator = new ChatMediator();
User alice = new User(mediator, "Alice");
User bob = new User(mediator, "Bob");

mediator.Register(alice).Register(bob);
alice.Send("Hello!"); // Bob receives: "Hello!"

interface IMediator { void Notify(string message, Colleague sender); } // Mediator interface
class ChatMediator : IMediator // Concrete Mediator
{
    private List<Colleague> _users = new();
    public ChatMediator Register(Colleague user) { _users.Add(user); return this; }
    public void Notify(string message, Colleague sender) =>
        _users.Where(u => u != sender).ToList().ForEach(u => u.Receive(message));
}
abstract class Colleague // Base class for participants
{
    protected IMediator _mediator;
    public Colleague(IMediator mediator) => _mediator = mediator;
    public abstract void Receive(string message);
}
class User : Colleague // Concrete Colleague
{
    public string Name { get; }
    public User(IMediator mediator, string name) : base(mediator) => Name = name;
    public void Send(string message) => _mediator.Notify(message, this);
    public override void Receive(string message) => Console.WriteLine($"{Name} received: {message}");
}
