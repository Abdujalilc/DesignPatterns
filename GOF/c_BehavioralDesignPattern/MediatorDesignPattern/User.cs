namespace MediatorDesignPattern
{
    public abstract class User
    {
        protected FacebookGroupMediator mediator;
        protected string name;
        public User(FacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
        /* public string MyProperty { get { return Name; } set { Name = value; } }
         public string Name { get; set; }*/
    }
}