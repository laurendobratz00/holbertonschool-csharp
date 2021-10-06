using System;
using System.Collections.Generic;
using System.Linq;

    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
            ///var list = myDict.Keys.ToList();
            ///list.Sort();
            var myList = myDict.Keys.ToList();
            myList.Sort();
            foreach (var key in myList)
            {
                Console.WriteLine("{0}: {1}", key, myDict[key]);
            }
        }
    }
