namespace SRP.BadExample
{
    class Program
    {
        static void Main()
        {
            UserManager userManager = new UserManager();
            userManager.AddUser("John Doe");
            userManager.SaveToFile("John Doe");
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
            File.WriteAllText("users.txt", data);
            Console.WriteLine("Data saved to file.");
        }
    }
}
/*
 * Why is this bad?
 * Because UserManager mixes user logic and file handling.
 */
