interface IRequestHandler { IRequestHandler SetNext(IRequestHandler next); void Process(string request); }
class BaseHandler : IRequestHandler
{
    private IRequestHandler _next;
    public IRequestHandler SetNext(IRequestHandler next) { _next = next; return next; } //creates child instance and returns
    public virtual void Process(string request) => _next?.Process(request);
}
class Logger : BaseHandler
{
    public override void Process(string request) { Console.WriteLine($"[Logger] {request}"); base.Process(request); }
}

class Authenticator : BaseHandler
{
    public override void Process(string request)    
    {
        if (request != "admin") { Console.WriteLine("[Authenticator] Access Denied"); return; }
        base.Process(request);
    }
}
class Processor : BaseHandler
{
    public override void Process(string request) => Console.WriteLine($"[Processor] Handling {request}");
}
class Program
{
    static void Main()
    {
        Logger? handler = new Logger();
        handler./*base*/SetNext(new Authenticator())./*base*/SetNext(new Processor());
        handler.Process("user");   // Logs & Denies
        handler.Process("admin");  // Logs, Authorizes, & Processes
    }
}
