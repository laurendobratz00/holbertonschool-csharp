using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
            Console.WriteLine();
        else
        {
            string j = "";
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(j + @"\");
                j += " ";
            }
            Console.WriteLine();
        }
    }
}
