﻿using System;

/// <summary> class Program </summary>
class Program
{
    /// <summary> scipt testing greater than or less than </summary>
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        if (number % 10 > 5)
            Console.WriteLine("The last digit of " + number + " is " + (number % 10) + " and is greater than 5");
        if (number % 10 == 0)
            Console.WriteLine("The last digit of " + number + " is " + (number % 10) + " and is 0");
        if (number % 10 < 6 && number % 10 != 0)
            Console.WriteLine("The last digit of " + number + " is " + (number % 10) + " and is less than 6 and not 0");
    }
}