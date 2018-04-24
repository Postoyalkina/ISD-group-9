using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    class Program
    {
        public static void QuickSort(int[] array, int lowBound, int highBound)
        {
            int first = lowBound;
            int last = highBound;
            int mid = array[(first + last) / 2];
            var pivot = array[highBound];
            for (int i = lowBound; i < highBound; i++)
            {
                if (array[i] < pivot)
                {
                    Swap(array, i, first);
                    first++;
                }
            }
            Swap(array, first, last);
            if (first > lowBound) QuickSort(array, lowBound, first - 1);
            if (first < highBound) QuickSort(array, first + 1, highBound);
        }

        public static void QuickSort(int[] array)
        {
            if (array.Length == 0) return;
            QuickSort(array, 0, array.Length - 1);
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 10);
            Console.Write (" Неотсортированный массив: ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            QuickSort(array);
            Console.Write(" \nОтсортированный массив: ");
            foreach (int item in array)
            {
                Console.Write( item +" ");
            }
            Console.ReadKey();
        }
    }
}
