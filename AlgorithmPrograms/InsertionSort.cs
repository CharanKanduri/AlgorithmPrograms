using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public static List<int> ArrayInput()
        {
            Console.WriteLine("Enter the Array size");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> array = new List<int>();
            while (number-- > 0)
            {
                Console.WriteLine("Enter a number:");
                array.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return array;
        }

        public static void InsertionSorting(List<int> Array)
        {
            for (int i = 0; i < Array.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (Array[j - 1] > Array[j])
                    {
                        Swap(Array, j - 1, j);
                    }
                }
            }
            Display(Array);
        }


        public static List<int> Swap(List<int> arrayList, int j, int i)
        {
            int temp = arrayList[j];
            arrayList[j] = arrayList[i];
            arrayList[i] = temp;
            return arrayList;
        }

        public static void Display(List<int> arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("Element {0} of Array: {1}", i + 1, arrayList[i]);

            }
        }
    }
}
