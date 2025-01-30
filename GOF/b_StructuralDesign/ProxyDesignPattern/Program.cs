interface IService // Subject Interface
{
    void Request();
} 
class RealService : IService // Real Object: Actual functionality
{
    public void Request() => Console.WriteLine("RealService: Handling request.");
}

class ServiceProxy : IService // Proxy: Controls access to RealService
{
    private RealService? _realService;
    public void Request()
    {
        _realService ??= new RealService(); // Lazy initialization
        Console.WriteLine("Proxy: Logging request.");
        _realService.Request();
    }
}
class Program
{
    static void Main()
    {
        IService service = new ServiceProxy();
        service.Request(); // Proxy logs and delegates to RealService
    }
}
