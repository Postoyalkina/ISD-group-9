using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Ship: Vehicle
    {
        int maxNumberPassengers;
        string port;

        public Ship(double price, double speed, int year, string port, int maxNumberPassengers)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;
            this.port = port;
            this.maxNumberPassengers = maxNumberPassengers;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Price: " + price + "\nSpeed: " + speed + "km/h\nYear: " + year + "\nPort: " + port + "\nNumber of passengers: " + maxNumberPassengers);
        }
    }
}
