using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            int i = 0, j = 0;
            List<int> listyList = new List<int>();
            while (list1.Contains(i))
            {
                if (list2.Contains(i))
                {
                    i++;
                }
                else
                    listyList.Add(i);
            }
            while (list2.Contains(j))
            {
                if (list1.Contains(j))
                    j++;
                else
                    listyList.Add(j);
            }
            i++;
            j++;
            listyList.Sort();
            return (listyList);
        }
    }
