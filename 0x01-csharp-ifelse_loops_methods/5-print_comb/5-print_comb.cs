using System;

namespace _5_print_comb
{
    /// <summary> class Program </summary>
    class Program
    {
        /// <summary> print comb </summary>
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 99)
                    Console.WriteLine(i);
                else
                    Console.Write((i.ToString("D2")) + ", ");
            }
        }
    }
}
