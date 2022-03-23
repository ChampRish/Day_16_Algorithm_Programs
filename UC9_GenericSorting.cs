using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs_Day16_17
{
    internal class UC9_GenericSorting
    {
        public void PrintSortedList()
        {
            SortedList sortedList = new SortedList()
            {
                { 0, "Amit" } ,{ 1, "Rishabh"},
                { 2, "Vipin"},{ 3, "Vimal" },
                { 4, "Goru" },{ 5, "Satty" }
            };
            sortedList.Add(6, "");
            sortedList.Add(7, 333);
            sortedList.Add(8, "Bhindi");
            //sortedList.Add("ee", "Abhilasha"); Error Need to Explain Same Data Key
            //Accessing Specific Value

            //var value = sortedList[5];
            var value = sortedList[5];
            Console.WriteLine("\nValue is : " + value);

            Console.WriteLine("\n------Sorted List-----");

            foreach (DictionaryEntry data in sortedList)
                Console.WriteLine($"Key: {data.Key}, Value:- {data.Value}");
        }

    }
}
