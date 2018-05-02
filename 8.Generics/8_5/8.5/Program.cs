using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> T = new CarCollection<Car>();
            T.AddCar(new Car("ford mustang",2017));
            Console.WriteLine(T.Length);
            T.RemoveAll();
            Console.WriteLine(T.Length);
            Console.ReadKey();
        }
    }

    class CarCollection<T> where T: Car
    {
        List<T> Collection;
        public CarCollection()
        {
            Collection = new List<T>();
        }
        public void AddCar(T C)
        {            
            Collection.Add(C);
        }

        public int Length
        {
            get {return Collection.Count; }
        }
        public T this[int i]
        {
            get
            {
                return Collection[i];
            }
            set
            {
                Collection[i] = value;
            }
        }
        public void RemoveAll()
        {
            Collection.RemoveAll((T)=>true);
        }

    }
    class Car
    {
        string name;
        int year;
        public Car(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
    }
}
