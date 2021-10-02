using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int i, sum = 0;

        List<int> myList1;
        myList1 = myList.Distinct().ToList();
        for (i = 0; i < myList1.Count; i++)
        {
            sum += myList1[i];
        }
        return sum;
    }
}
