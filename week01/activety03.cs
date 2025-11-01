using System;

class Program
{
    static void Main()
    {
        int result = AddNumbers(5, 7);
        Console.WriteLine($"The sum is: {result}");
    }

    static int AddNumbers(int first, int second)
    {
        return first + second;
    }
}
