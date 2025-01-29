namespace SRP.GoodExample
{
    class Program
    {
        static void Main()
        {
            UserManager userManager = new UserManager();
            FileManager fileManager = new FileManager();

            string user = "John Doe";
            userManager.AddUser(user);
            fileManager.SaveToFile(user);
        }
    }
    class UserManager
    {
        public void AddUser(string name)
        {
            Console.WriteLine($"User {name} added.");
        }
    }
    class FileManager
    {
        public void SaveToFile(string data)
        {
            File.WriteAllText("users.txt", data);
            Console.WriteLine("Data saved to file.");
        }
    }
}
/*
 * Why is this good?
 * Because UserManager handles user logic, FileManager handles file operations.
 */
