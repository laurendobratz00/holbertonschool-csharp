using System;

namespace _3_print_alphabt
{
    /// <summary> class Program </summary>
    class Program
    {
        /// <summary> print alphabet </summary>
        static void Main(string[] args)
        {
            char i;
            
            for (i = 'a'; i <= 'z'; i++)
            {
                if (i != 'e' && i != 'q')
                    Console.Write(i);
            }
        }
    }
}
