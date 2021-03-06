using System;
using System.Collections.Generic;

    class LList
    {
        public static LinkedList<int> CreatePrint(int size)
        {
            int i = size - 1;
            LinkedList<int> newList = new LinkedList<int>();

            while (size >= 0 && i >= 0 && i <= size)
            {
                newList.AddFirst(i);
                i--;
            }
            foreach (int x in newList)
            {
                Console.WriteLine(x.ToString());
            }
            return (newList);
        }
    }

