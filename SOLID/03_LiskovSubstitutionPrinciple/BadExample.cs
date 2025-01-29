namespace LiskovSubstitution.BadExample
{
    class Program
    {
        static void Main()
        {
            Bird sparrow = new Sparrow();
            Bird penguin = new Penguin();

            sparrow.Fly();
            penguin.Fly(); // ❌ Throws an exception! Penguins can't fly.
        }
    }

    public class Bird
    {
        public virtual void Fly() => Console.WriteLine("Flying");
    }

    public class Sparrow : Bird
    {
        public override void Fly() => Console.WriteLine("Flying high");
    }

    public class Penguin : Bird
    {
        public override void Fly() => throw new NotImplementedException(); // ❌ Violates LSP
    }
}
/*
 * Why is this bad?
 * ❌ Violates LSP → Penguin inherits Fly() but cannot fly, causing unexpected behavior.
 */
