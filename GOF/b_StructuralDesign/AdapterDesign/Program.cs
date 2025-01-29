// Adapter Pattern → Bridges incompatible interfaces without modifying existing code.
using System;

public interface ITarget// Expected interface
{
    void Request();
} 

public class Adaptee
{
    public void SpecificRequest() => Console.WriteLine("Adaptee's behavior adapted");
}

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee = new Adaptee(); // Holds reference to existing implementation
    public void Request() => _adaptee.SpecificRequest(); // Adapts to expected interface
}

// Client
class Program
{
    static void Main()
    {
        ITarget adapter = new Adapter();
        adapter.Request(); // Output: Adaptee's behavior adapted
    }
}
