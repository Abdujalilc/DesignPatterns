// Prototype Pattern → Creates object copies without knowing their exact class.
public interface IPrototype
{
    IPrototype Clone();
} // Defines cloning behavior

public class Product : IPrototype
{
    public string Name { get; set; } = "Original Product";
    public IPrototype Clone() => new Product { Name = $"{Name} (Cloned)" }; // Creates a modified copy
}

// Client
class Program
{
    static void Main()
    {
        Product original = new();
        Product clone = (Product)original.Clone(); // Duplicate object

        Console.WriteLine(original.Name); // Output: Original Product
        Console.WriteLine(clone.Name);    // Output: Original Product (Cloned)
    }
}
