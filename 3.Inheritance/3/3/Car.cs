using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Car: Vehicle
    {
        public Car(double price, double speed, int year)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
    }
}
