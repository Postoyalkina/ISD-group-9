using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Vehicle
    {
        protected double price, speed;
        protected int year;

        public virtual void ShowInfo()
        {
            Console.WriteLine("Price: " + price + "\nSpeed: " + speed + "km/h\nYear: " + year);
        }

    }
}
