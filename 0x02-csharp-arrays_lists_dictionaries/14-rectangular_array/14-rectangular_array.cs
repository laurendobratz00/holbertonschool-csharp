using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5,5] {{0,0,0,0,0}, {0,0,0,0,0}, {0,0,1,0,0}, {0,0,0,0,0}, {0,0,0,0,0}};
            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (j == (a.GetLength(1)) - 1)
                    {
                        Console.Write(string.Format("{0}", a[i, j]));
                    }
                    else
                    {
                        Console.Write(string.Format("{0} ", a[i, j]));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
