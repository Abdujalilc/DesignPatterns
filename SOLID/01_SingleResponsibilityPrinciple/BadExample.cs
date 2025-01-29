namespace SRP.BadExample
{
    class Program
    {
        static void Main()
        {
            UserManager userManager = new UserManager();
            userManager.AddUser("John Doe");
            userManager.SaveToFile("John Doe"); // Violates SRP: UserManager shouldn't handle file operations
        }
    }
    class UserManager
    {
        public void AddUser(string name)
        {
            Console.WriteLine($"User {name} added.");
        }

        public void SaveToFile(string data)
        {
            File.WriteAllText("users.txt", data); // Mixing concerns: should be handled by a separate class
            Console.WriteLine("Data saved to file.");
        }
    }
}

/*
 * Why is this bad?
 * Because UserManager mixes user logic and file handling.
 */
