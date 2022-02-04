using System;

namespace _12_fizzbuzz
{
    /// <summary> class Program </summary>
    class Program
    {
        /// <summary> print fizz, buzz, and fizzbuzz in a crazy format </summary>
        static void Main(string[] args)
        {
	        int i;
	        for (i = 1; i <= 100; i++)
            {
		        if ((i % 3 == 0) && (i % 5 == 0))
			        Console.Write("FizzBuzz ");
		        else if (i % 3 == 0)
			        Console.Write("Fizz ");
                else if (i == 100)
                    Console.Write("Buzz");
		        else if (i % 5 == 0)
			        Console.Write("Buzz ");
		        else
			        Console.Write(i + " ");
            }
        }
    }
}
