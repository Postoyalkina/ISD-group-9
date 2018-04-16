using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Postoyalkina", "Anastasia", "Director", 15);
            employee.Show();
            Console.ReadKey();
        }
    }
}
