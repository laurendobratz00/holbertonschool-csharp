using System;
using System.Collections.Generic;

    class LList
    {
        public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
        {
            LinkedListNode<int> newNode = new LinkedListNode<int>(n);
            LinkedListNode<int> node = myLList.First;

            while (node != null)
            {
                if (node.Value > n)
                {
                    myLList.AddBefore(node, newNode);
                    break;
                }
                else
                {
                    if (node.Next == null)
                    {
                        myLList.AddAfter(node, newNode);
                        break;
                    }
                }
                node = node.Next;
            }
            return (newNode);
        }
    }
