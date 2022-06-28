namespace SingleResponsibilityPrinciple
{
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
    public class Logger : ILogger
    {
        public Logger()
        {
            // here we need to write the Code for initialization 
            // that is Creating the Log file with necesssary details
        }
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
        public void Debug(string info)
        {
            Console.WriteLine(info);
        }
        public void Error(string message, Exception ex)
        {
            Console.WriteLine($"{message}  {ex.Message}");
        }
    }
}