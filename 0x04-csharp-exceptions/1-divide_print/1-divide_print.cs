using System;

    class Int
    {
        public static void divide(int a, int b)
        {
            int res = 0;
            try
            {
                if (b != 0)
                {
                    res = a / b;
                }
            }
            catch (DivideByZeroException)
            {  
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    Console.WriteLine(a + " / " + b + " = " + res);
                }
                else
                {
                    Console.WriteLine(a + " / " + b + " = " + res);
                }
            }
        }
    }

