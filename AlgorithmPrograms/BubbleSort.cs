using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class BubbleSort
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

        public static void BubbleSorting(List<int> arr)
        {
            for (int j = 0; j <= arr.Count - 2; j++)
            {
                for (int i = 0; i <= arr.Count - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Display(arr);
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
