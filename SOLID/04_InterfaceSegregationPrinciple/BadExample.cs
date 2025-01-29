namespace InterfaceSegregation.BadExample
{
    class Program
    {
        static void Main()
        {
            IWorker human = new HumanWorker();
            IWorker robot = new RobotWorker();

            human.Work();
            human.Eat(); // ✅ Humans eat.
            robot.Work();
            robot.Eat(); // ❌ Throws an exception! Robots don't eat.
        }
    }
    public interface IWorker
    {
        void Work();
        void Eat(); // ❌ Forces all workers to implement eating.
    }
    public class HumanWorker : IWorker
    {
        public void Work() => Console.WriteLine("Working...");
        public void Eat() => Console.WriteLine("Eating lunch...");
    }
    public class RobotWorker : IWorker
    {
        public void Work() => Console.WriteLine("Working tirelessly...");
        public void Eat() => throw new NotImplementedException(); // ❌ Violates ISP
    }
}
/*
 * Why is this bad?
 * Because robots are forced to implement Eat(), which they don’t need.
 */
