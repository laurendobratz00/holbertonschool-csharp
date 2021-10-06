﻿using System;
using System.Collections.Generic;

    class LList
    {
        public static LinkedList<int> CreatePrint(int size)
        {
            int i = size - 1;
            LinkedList<int> newList = new LinkedList<int>();
            if (size < 0)
                return (null);
            while (i >= 0 && i <= size)
            {
                newList.AddFirst(i);
                i--;
            }
            foreach (int x in newList)
            {
                if (size == 0)
                    Console.WriteLine("Linked List Length: 0");
                else
                    Console.WriteLine(x.ToString());
            }
            return (newList);
        }
    }

