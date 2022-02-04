using System;

/// <summary> class Program </summary>
class Program
{
    /// <summary> takes user input and tells whether it's 0, pos, or neg </summary>
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        if (number > 0)
        {
            Console.WriteLine(number + " is positive");
        }
        if (number == 0)
        {
            Console.WriteLine(number + " is zero");
        }
        if (number < 0)
        {
            Console.WriteLine(number + " is negative");
        }
    }
}
