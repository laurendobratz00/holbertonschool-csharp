using System;

/// <summary> class Line </summary>
class Line
{
    /// <summary> print line to the length given </summary>
    public static void PrintLine(int length)
    {
        if (length <= 0)
            Console.WriteLine();
        else
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write('_');
            }
            Console.WriteLine();
        }
    }
}
