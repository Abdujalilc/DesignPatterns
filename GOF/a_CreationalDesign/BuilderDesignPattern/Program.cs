public class Product
{
    public string Part { get; set; } = ""; // Stores the built component
}
public interface IBuilder
{
    IBuilder BuildPartOne();
    IBuilder BuildPartTwo();
    Product GetResult();
}
public class ConcreteBuilder : IBuilder
{
    private Product _product = new();
    public IBuilder BuildPartOne()
    {
        _product.Part += "Product component One built. ";
        return this;
    }
    public IBuilder BuildPartTwo()
    {
        _product.Part += "\nProduct component Two built. "; // Append instead of overwrite
        return this;
    }
    public Product GetResult() => _product;
}

// Client
class Program
{
    static void Main()
    {
        IBuilder builder = new ConcreteBuilder();
        Product product = builder.BuildPartOne().BuildPartTwo()/*construction*/.GetResult()/*representation*/;
        Console.WriteLine(product.Part); // Output: Product component successfully built
        Console.ReadLine();
    }
}
//builder.BuildPartOne().BuildPartTwo().GetResult(); ///method chaining