ChatMediator mediator = new ChatMediator();
User alice = new User(mediator, "Alice");
User bob = new User(mediator, "Bob");
mediator.Register(alice).Register(bob);
alice.Send("Hello!"); // Bob receives: "Hello!"

interface IMediator { void Notify(string msg, User sender); } // Mediator interface
class ChatMediator : IMediator // Concrete Mediator
{
    private List<User> _users = new List<User>();
    public ChatMediator Register(User user) { _users.Add(user); return this; }
    public void Notify(string msg, User sender) => _users.Where(u => u != sender).ToList().ForEach(u => u.Receive(msg));
}

class User // Colleague
{
    private IMediator _mediator;
    public string Name { get; }
    public User(IMediator mediator, string name) => (_mediator, Name) = (mediator, name);
    public void Send(string msg) => _mediator.Notify(msg, this);
    public void Receive(string msg) => Console.WriteLine($"{Name} received: {msg}");
}
