namespace LiskovSubstitution.GoodExample
{
    class Program
    {
        static void Main()
        {
            Bird sparrow = new Sparrow();
            Bird penguin = new Penguin();

            sparrow.Move();
            penguin.Move(); // Both objects behave correctly without breaking substitution
        }
    }
    public abstract class Bird
    {
        public abstract void Move(); // Abstract method ensures each subclass defines its own movement
    }
    public class Sparrow : Bird
    {
        public override void Move() => Console.WriteLine("Flying");
    }
    public class Penguin : Bird
    {
        public override void Move() => Console.WriteLine("Swimming"); // No unexpected behavior or misuse of base class methods
    }
}

/*
 * Why is this good?
 * ✅ Follows LSP → Each bird moves in a way that matches its nature without breaking behavior.
 */
