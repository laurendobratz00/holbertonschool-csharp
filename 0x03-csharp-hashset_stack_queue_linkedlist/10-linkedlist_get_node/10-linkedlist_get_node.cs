using System;
using System.Collections.Generic;
using System.Linq;

    class LList
    {
        public static int GetNode(LinkedList<int> myLList, int n)
        {
            int count = 0;
            LinkedListNode<int> current = myLList.First;

            if (myLList == null || n < 0)
            {
                return (0);
            }
            while (current != null)
            {
                if (n <= myLList.Count)
                    count++;
                    current = current.Next;
            }
            return (myLList.ElementAt(n));
        }
    }

