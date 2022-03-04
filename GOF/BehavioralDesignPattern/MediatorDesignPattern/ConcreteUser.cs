namespace MediatorDesignPattern
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine(name + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(name + ": Sending Message=" + message + "\n");
            mediator.SendMessage(message, this);
        }
    }
}