using System;
using System.Collections.Generic;

    class List
    {
        public static int MaxInteger(List<int> myList)
        {
            if (myList.Count == 0)
            {
                Console.WriteLine("List is empty");
                return -1;
            }
            int m = myList[0];
            foreach (int value in myList)
            {
                if (value > m)
                {
                    m = value;
                }
            }
            return m;
        }
    }

