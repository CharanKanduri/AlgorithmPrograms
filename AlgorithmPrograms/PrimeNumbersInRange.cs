using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class PrimeNumbersInRange
    {
        public static List<int> primeNumbers = new List<int>();
        public static List<int> AnagramNumbers = new List<int>();
        public static List<int> PalindromeNumbers = new List<int>();
        public static void PrimeNumbers()
        {
            int num, i, ctr, stno, enno;
            Console.Write("Input starting number of range: ");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

            for (num = stno; num <= enno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.WriteLine(num);
            }
            Console.Write("\n");
            PrimeNumbersInRange.AnagramCheck();
            PrimeNumbersInRange.Palindrome();
        }

        public static void AnagramCheck()
        {
            foreach (var i in primeNumbers)
            {
                char[] string1 = Convert.ToString(i).ToCharArray();
                Array.Sort(string1);

                foreach (var j in primeNumbers)
                {
                    char[] string2 = Convert.ToString(j).ToCharArray();
                    Array.Sort(string2);
                    string firstString = String.Join("", string1);
                    string secondString = String.Join("", string2);
                    if (i != j && firstString == secondString && AnagramNumbers.Contains(i) == false)
                    {
                        AnagramNumbers.Add(i);
                        AnagramNumbers.Add(j);
                    }
                }
            }
            Console.WriteLine("\n---------------- Printing Anagram of Prime Number ----------------");
            foreach (var i in AnagramNumbers)
            {
                Console.WriteLine(i);
            }
        }
        public static void Palindrome()
        {
            foreach (var i in primeNumbers)
            {
                char[] string1 = Convert.ToString(i).ToCharArray();

                char[] string2 = Convert.ToString(i).ToCharArray();
                Array.Reverse(string2);
                string firstString = String.Join("", string1);
                string secondString = String.Join("", string2);
                if (firstString == secondString)
                {
                    PalindromeNumbers.Add(i);
                }
            }
            Console.WriteLine("\n---------------- Printing Palindrome of Prime Number ----------------");
            foreach (var i in PalindromeNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}

