// Singleton Pattern → Ensures a class has only one instance with global access.
public class Singleton
{
    private static Singleton? _instance; // Holds the single instance
    private Singleton() { } // Private constructor prevents instantiation

    public static Singleton Instance => _instance ??= new Singleton(); // Lazy initialization

    public void Show() => Console.WriteLine("Single instance active"); // Informational assignment
}
// Client
class Program
{
    static void Main()
    {
        Singleton obj1 = Singleton.Instance;
        Singleton obj2 = Singleton.Instance;

        Console.WriteLine(obj1 == obj2); // Output: True (Same instance)
        obj1.Show(); // Output: Single instance active
    }
}
