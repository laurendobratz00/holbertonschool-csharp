using System;

namespace _4_print_hexa
{
    /// <summary> class Program </summary>
    class Program
    {
        /// <summary> print hexa </summary>
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine(i + " = " + "0x{0:x}", i);
            }
        }
    }
}
