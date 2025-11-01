using System;

class Program
{
    static void Main()
    {
        string name = GetName();
        int age = GetAge();
        Console.WriteLine($"Hello {name}, you are {age} years old.");
    }

    static string GetName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int GetAge()
    {
        Console.Write("Please enter your age: ");
        return int.Parse(Console.ReadLine());
    }
}
