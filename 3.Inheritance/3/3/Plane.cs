using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Plane: Vehicle
    {
        double height;
        int maxNumberPassengers;

        public Plane(double price, double speed, int year, double height, int maxNumberPassengers)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;
            this.height = height;
            this.maxNumberPassengers = maxNumberPassengers;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Price: " + price + "\nSpeed: " + speed + "km/h\nYear: " + year+"\nHeight: "+height+"\nNumber of passengers: "+maxNumberPassengers);
        }
    }
}
