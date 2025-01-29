namespace LiskovSubstitution.GoodExample
{
    class Program
    {
        static void Main()
        {
            Bird sparrow = new Sparrow();
            Bird penguin = new Penguin();

            sparrow.Move();
            penguin.Move();
        }
    }

    public abstract class Bird
    {
        public abstract void Move();
    }

    public class Sparrow : Bird
    {
        public override void Move() => Console.WriteLine("Flying");
    }

    public class Penguin : Bird
    {
        public override void Move() => Console.WriteLine("Swimming");
    }
}
/*
 * Why is this good?
 * Because each bird moves in a way that matches its nature without breaking behavior.
 */
