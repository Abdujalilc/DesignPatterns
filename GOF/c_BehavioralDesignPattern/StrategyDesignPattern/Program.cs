Context context = new Context(new StrategyA());
context.Execute(); // Strategy A executed
context.SetStrategy(new StrategyB());
context.Execute(); // Strategy B executed

// Strategy interface
interface IStrategy { void Execute(); }

// Concrete Strategies
class StrategyA : IStrategy { public void Execute() => Console.WriteLine("Strategy A executed"); }
class StrategyB : IStrategy { public void Execute() => Console.WriteLine("Strategy B executed"); }

// Context uses a strategy
class Context
{
    private IStrategy _strategy;
    public Context(IStrategy strategy) => _strategy = strategy;
    public void SetStrategy(IStrategy strategy) => _strategy = strategy;
    public void Execute() => _strategy.Execute();
}
