using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(123, 500, 2017, 5000, 1000);
            Console.WriteLine("\nPlane");
            plane.ShowInfo();

            Car car = new Car(20, 200, 2017);
            Console.WriteLine("\nCar");
            car.ShowInfo();

            Ship ship = new Ship(100, 300, 2017, "New port 20143", 2000);
            Console.WriteLine("\nShip");
            ship.ShowInfo();

            Console.ReadKey();
        }
    }
}
