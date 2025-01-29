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
            fileManager.SaveToFile(user); // Responsibility is now separated
        }
    }
    class UserManager
    {
        public void AddUser(string name)
        {
            Console.WriteLine($"User {name} added."); // Handles only user logic
        }
    }
    class FileManager
    {
        public void SaveToFile(string data)
        {
            File.WriteAllText("users.txt", data); // Handles only file operations
            Console.WriteLine("Data saved to file.");
        }
    }
}
/*
 * Why is this good?
 * Because UserManager handles user logic, FileManager handles file operations.
 * This follows SRP, making the code more maintainable and testable.
 */
