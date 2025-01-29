namespace InterfaceSegregation.GoodExample
{
    class Program
    {
        static void Main()
        {
            IWorkable human = new HumanWorker();
            IEatable humanEater = new HumanWorker(); // Only humans eat

            IWorkable robot = new RobotWorker();

            human.Work();
            humanEater.Eat(); // ✅ Humans eat.
            robot.Work();
            // robot.Eat(); ❌ Not possible anymore, fixing ISP violation
        }
    }
    public interface IWorkable
    {
        void Work(); // Only work-related behavior
    }
    public interface IEatable
    {
        void Eat(); // Separate eating behavior
    }
    public class HumanWorker : IWorkable, IEatable
    {
        public void Work() => Console.WriteLine("Working...");
        public void Eat() => Console.WriteLine("Eating lunch...");
    }
    public class RobotWorker : IWorkable
    {
        public void Work() => Console.WriteLine("Working tirelessly...");
        // No Eat() method, avoiding unnecessary implementation
    }
}

/*
 * Why is this good?
 * ✅ Follows ISP → Robots are not forced to implement Eat(), keeping interfaces specific.
 */
