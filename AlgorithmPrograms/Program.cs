﻿using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs!");

            Console.WriteLine("\nEnter 1-to Calculate Permutation of a string using Recursion Method\nEnter 2-to Calculate Permutation of a string using Iterative Method ");
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
            }
        }
    }
}
