using System;

/// <summary> class Number </summary>
class Number
{
    /// <summary> print the last digit of a number </summary>
    public static int PrintLastDigit(int number)
    {
        int newnum = number % 10;
        return (newnum);
    }
}
