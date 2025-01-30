public interface IGraphic// Component
{
    void Draw();
}
public class Circle : IGraphic// Leaf
{
    public void Draw() => Console.WriteLine("Circle");
}
public class Group : IGraphic// Composite
{
    private readonly List<IGraphic> _graphics = new List<IGraphic>();
    public void Add(IGraphic g) => _graphics.Add(g); // Stores multiple components
    public void Draw()// Delegates drawing
    {
        foreach (var g in _graphics) g.Draw();
    } 
}
// Client
class Program
{
    static void Main()
    {
        var group = new Group();
        group.Add(new Circle());
        group.Add(new Circle());
        group.Draw(); // Output: Circle Circle
    }
}
