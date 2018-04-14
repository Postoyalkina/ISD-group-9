using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Task
{
    class Program
    {

        const int Count = 128;
        static void Main(string[] args)
        {
            int y = 0;
            while (y*2 <= Count)
            {
                if ( (Count - 2 * y) % 4 == 0)
                Console.WriteLine("Уточек: " + y + " Кроликов :" + (Count - 2 * y) / 4);
                y++;
            }
           
            Console.ReadKey();
        }
        
    }
}
