using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Keys == null)
            return ("None");
        string maxKey = myList.Keys.Max();
        return (maxKey);
    }
}
