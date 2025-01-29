// Factory Pattern → Creates objects using interfaces without specifying exact classes.
public interface IProduct// Common interface for all products
{
    void Show();
}
public class ProductA : IProduct
{
    public void Show() => Console.WriteLine("Product A created");
}
public class ProductB : IProduct
{
    public void Show() => Console.WriteLine("Product B created");
}
public class Factory
{
    public static IProduct CreateProduct(string type) =>
        type == "A" ? new ProductA() : new ProductB(); // Decides which product to create
}
// Client
class Program
{
    static void Main()
    {
        IProduct product = Factory.CreateProduct("A"); // Requests a specific product
        product.Show(); // Output: Product A created
        Console.ReadLine(); ///just keep console open
    }
}
