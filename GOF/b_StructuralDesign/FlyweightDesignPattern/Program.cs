interface IShape { 
    void Draw(string color); } // Flyweight Interface
class Circle : IShape // Concrete Flyweight: Shared object
{
    public void Draw(string color) => Console.WriteLine($"Drawing {color} circle.");
}
class ShapeFactory // Flyweight Factory: Manages object reuse
{
    private static readonly Dictionary<string, IShape> _shapes = new Dictionary<string, IShape>();

    public static IShape GetCircle()
    {
        if (!_shapes.ContainsKey("circle"))
            _shapes["circle"] = new Circle();
        return _shapes["circle"];
    }
}
class Program
{
    static void Main()
    {
        IShape shape1 = ShapeFactory.GetCircle();
        shape1.Draw("Red");

        IShape shape2 = ShapeFactory.GetCircle();
        shape2.Draw("Blue"); // Same object, different color
    }
}
