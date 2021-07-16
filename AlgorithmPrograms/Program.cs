using System;
using System.IO;
using System.Collections.Generic;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs!");

            Console.WriteLine("\nEnter 1-to Calculate Permutation of a string using Recursion Method\nEnter 2-to Calculate Permutation of a string using Iterative Method\nEnter 3-Binary Search Word from a file\nEnter 4-InsertionSort\nEnter 5-BubbleSort");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter a string to calculate Permutation");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    Console.WriteLine("Permutation through Recursion Method");
                    Permutations.RecursivePermutation(str, 0, n - 1);
                    break;
                case 2:
                    Console.WriteLine("\nPermutation through Iteration Method");
                    string str1 = Console.ReadLine();
                    int n1 = str1.Length;
                    Permutations.IterativePermutation(str1, n1);
                    break;
                case 3:
                    Console.WriteLine("\nBinary Search word from a file");
                    string filePath = File.ReadAllText(@"C:\Users\charan kanduri\source\repos\AlgorithmPrograms_BridgeLabz\AlgorithmPrograms\SampleTextFile.txt");
                    List<string> wordList = new List<string>(filePath.Split(" "));
                    wordList.Sort();
                    BinarySearchWord.BinarySearch(wordList);
                    break;
                case 4:
                    List<int> arr = InsertionSort.ArrayInput();
                    InsertionSort.InsertionSorting(arr);
                    break;
                case 5:
                    List<int> arr1 = BubbleSort.ArrayInput();
                    BubbleSort.BubbleSorting(arr1);
                    break;
            }
        }
    }
}
