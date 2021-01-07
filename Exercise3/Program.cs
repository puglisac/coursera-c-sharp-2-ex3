using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();

            //add integers 1-10 to the list
            for(int i = 1; i<=10; i++)
            {
                integers.Add(i);
            }

            //print out all the integers in the list
            for(int i = 0; i<integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }

            //remove every other integer starting from the end of the list
            for (int i = integers.Count-1; i > 0; i -= 2)
            {
                integers.RemoveAt(i);
            }

            //print out all the integers in the list
            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }

            List<int> newList = new List<int>();

            //add integers 1-5 to newList
            for (int i = 1; i <= 5; i++)
            {
                newList.Add(i);
            }

            //remove the first three integers from newList
            for (int i = 0; i<=2; i++)
            {
                newList.RemoveAt(i);
            }

            //print out all the integers in newList
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }
        }
    }
}
