using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    class Program
    {
        static bool direction = false;

        public static void QuickSort(int[] array, int lowBound, int highBound)
        {
            int dirOfSort = 1;
            int first = lowBound;
            int last = highBound;
            int mid = array[(first + last) / 2];
            var pivot = array[highBound];
            if (direction) dirOfSort*=-1;
            for (int i = lowBound; i < highBound; i++)
            {
                if (dirOfSort * array[i] < dirOfSort * pivot)
                {
                    Swap(array, i, first);
                    first++;
                }
            }
            Swap(array, first, last);
            if (first > lowBound) QuickSort(array, lowBound, first - 1);
            if (first < highBound) QuickSort(array, first + 1, highBound);
        }

        public static void QuickSort(int[] array, bool w)
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
            Console.WriteLine("Введите направление сортировки: 0 - на возрастание, 1 - на убывание");
            int userW = Convert.ToInt32(Console.ReadLine());
            if (userW == 0) direction = false;
            else if (userW == 1) direction = true;
            else Console.WriteLine("Неправильно введено значение");
            Random rand = new Random();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 10);
            Console.Write("Неотсортированный массив: ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            QuickSort(array, direction);
            Console.Write("\nОтсортированный массив:   ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
