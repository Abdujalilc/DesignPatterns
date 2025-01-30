public interface IRemote
{
    void PowerOn(); // Defines operation for remote control
}
public class BasicRemote : IRemote
{
    public void PowerOn() => Console.WriteLine("Power On"); // Basic implementation of remote
}
public abstract class Device
{
    protected IRemote remote; // Bridge to remote control
    public Device(IRemote r) => remote = r; // Inject remote control implementation
    public abstract void Operate(); // Abstract operation
}
public class TV : Device
{
    public TV(IRemote r) : base(r) { } // Pass remote to base class
    public override void Operate() => remote.PowerOn(); // Delegate operation to remote
}
class Program
{
    static void Main()
    {
        new TV(new BasicRemote()).Operate(); // Use TV with BasicRemote
    }
}
