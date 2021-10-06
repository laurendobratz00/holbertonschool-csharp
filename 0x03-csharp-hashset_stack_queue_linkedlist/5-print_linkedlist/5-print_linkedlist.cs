using System;
using System.Collections.Generic;

    class LList
    {
        public static LinkedList<int> CreatePrint(int size)
        {
            int i = 0;
            LinkedList<int> newList = new LinkedList<int>();
            if (size < 0)
                return (null);
            if (i >= 0 && i <= size)
            {
                newList.AddFirst(i);
                i++;
            }
            foreach (int x in newList)
            {
                Console.WriteLine(x.ToString());
            }
            return (newList);
        }
    }

