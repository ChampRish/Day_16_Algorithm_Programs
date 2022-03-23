using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Programs_Day16_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC1_permutationFunction permutation = new UC1_permutationFunction();
            String str = "ABC";
            int n = str.Length;
            permutation.permute(str, 0, n - 1);

            Console.WriteLine("\n--------------------------------------------------------\n");

            UC2_BinarySearch binarySearch = new UC2_BinarySearch();
            binarySearch.PrintOutput();

            Console.WriteLine("\n--------------------------------------------------------\n");

            UC3_InsertionSort insertionSort = new UC3_InsertionSort();
            insertionSort.InsertionSort();

            Console.WriteLine("\n--------------------------------------------------------\n");

            UC4_BubbleSort bubbleSort = new UC4_BubbleSort();
            bubbleSort.BubbleSort();

            Console.WriteLine("\n--------------------------------------------------------\n");
            UC5_MergeSort mergeSort = new UC5_MergeSort();
            mergeSort.MergeSort();

            Console.WriteLine("\n--------------------------------------------------------\n");

            UC6_AnagramsProgram anagramsProgram = new UC6_AnagramsProgram();
            anagramsProgram.AnagramsProgram();

            Console.WriteLine("\n--------------------------------------------------------\n");

            UC7_PrimeNumbers primeNumbers = new UC7_PrimeNumbers();
            primeNumbers.CheckNumberPrimeNumber();

            Console.WriteLine("\n--------------------------------------------------------\n");

            UC8_AnagramAndPalindrome palindrome = new UC8_AnagramAndPalindrome();
            palindrome.Palindrome();

            Console.WriteLine("\n--------------------------------------------------------\n");

            UC9_GenericSorting sorting = new UC9_GenericSorting();
            sorting.PrintSortedList();

            Console.ReadLine();
        }
    }
}
