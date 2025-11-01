using System;

class Program
{
    static void Main()
    {
        DisplayPersonalMessage("Marcos");
    }

    static void DisplayPersonalMessage(string userName)
    {
        Console.WriteLine($"Hello {userName}!");
    }
}
