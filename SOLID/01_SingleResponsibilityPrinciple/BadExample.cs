using System;
using System.IO;

class BadExample
{
    static void Main()
    {
        UserManager2 userManager2 = new UserManager2();
        userManager2.AddUser("John Doe");
        userManager2.SaveToFile("John Doe");
    }
}

class UserManager2
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
