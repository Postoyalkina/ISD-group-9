using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassRoom_inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new ExcelentPupil("Саша"), new BadPupil("Маша"), new GoodPupil("Вика"), new ExcelentPupil("Дима"));
            classRoom.Display();
            Console.ReadLine();
        }
    }
}
