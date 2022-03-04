Fruit fruit = new Orange();
Console.WriteLine(fruit.GetColor());
fruit = new Apple();
Console.WriteLine(fruit.GetColor());

#region With
public abstract class Fruit
{
    public abstract string GetColor();
}
public class Apple : Fruit
{
    public override string GetColor()
    {
        return "Red";
    }
}
public class Orange : Fruit
{
    public override string GetColor()
    {
        return "Orange";
    }
}
#endregion With