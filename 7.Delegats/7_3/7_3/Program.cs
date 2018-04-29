using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    //тип делегата возвращающего int
    public delegate int Delegates();
    public delegate double MyDelegate(Delegates[] delegates);
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            //массив делегатов возвращающих int
            Delegates[] delegates =
            {
                new Delegates(Method),
                new Delegates(Method),
                new Delegates(Method),
                new Delegates(Method)
            };           

            //анонимный метод
            MyDelegate myDelegate = delegate(Delegates[] array)
            {
                //получаем среднее значение массива делегатов, каждый делегат вызывает метод Method 
                double avg = array.Average(a => a.Invoke());
                return avg;
            };

            Console.WriteLine("Avarage: " + myDelegate(delegates));
            Console.ReadKey();
        }

        static int Method()
        {
            int result = random.Next(0, 1001);
            Console.WriteLine(result);
            return result;
        }
    }
}
