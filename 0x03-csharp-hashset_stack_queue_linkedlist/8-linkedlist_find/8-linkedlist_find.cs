using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int i;
        if (myLList.Contains(value) == true)
        {
            i = myLList.TakeWhile(n => n != value).Count();
            return i;
        }
        else
            return (-1);
    }
}
