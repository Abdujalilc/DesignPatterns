// Abstract Factory & Products
public interface IGUIFactory { IButton CreateButton(); }
public interface IButton { void Render(); }

// Concrete Implementations
public class WindowsFactory : IGUIFactory { public IButton CreateButton() => new WindowsButton(); }
public class MacFactory : IGUIFactory { public IButton CreateButton() => new MacButton(); }
public class WindowsButton : IButton { public void Render() => Console.WriteLine("Windows Button"); }
public class MacButton : IButton { public void Render() => Console.WriteLine("Mac Button"); }

// Client
class Program
{
    static void Main()
    {
        IGUIFactory factory = new WindowsFactory(); // or new MacFactory()
        factory.CreateButton().Render();
    }
}
