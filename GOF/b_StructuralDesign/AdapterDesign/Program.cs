using System;
public interface ITarget
{
    void Request();
}
public class Adaptee
{
    private string _log = "Initial";
    private int _count = 0;
    public void SpecificRequest()
    {
        _count++;
        _log += " -> Request #" + _count;
        Console.WriteLine($"Adaptee log: {_log}");
    }
}
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee = new Adaptee(); // Single instance
    public void Request() => _adaptee.SpecificRequest();
}
class Program
{
    static void Main()
    {
        ITarget adapter = new Adapter();
        adapter.Request(); // Output: Adaptee log: Initial ->  Request #1
        adapter.Request(); // Output: Adaptee log: Initial -> Request #1 -> Request #2
    }
}