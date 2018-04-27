using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass
            {
                change = "не изменено"
            };
            ClassTaker(myClass);
            MyStruct myStruct = new MyStruct
            {
                change = "не изменено"
            };
            StruktTaker(myStruct);
            Console.WriteLine("Class: " + myClass.change);
            Console.WriteLine("Struct: " + myStruct.change);
            Console.ReadKey();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
}
