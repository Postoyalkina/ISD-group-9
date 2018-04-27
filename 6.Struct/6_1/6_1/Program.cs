using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    struct Notebook
    {
        /* model -> модель блокноте
         * manufacturer -> производитель
         * price -> цена
         */
        private string model;
        private string manufacturer;
        private double price;

        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        //вывод информации о блокноте (модель, производитель, цена)
        public void Show()
        {
            Console.WriteLine("Model: " + model + "\nManufacturer: " + manufacturer + "\nPrice: " + price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter notebook model");
            string model = Console.ReadLine();
            Console.WriteLine("Enter notebook manufacturer");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Enter notebook price");
            double price = Convert.ToDouble(Console.ReadLine());
            Notebook notebook = new Notebook(model, manufacturer, price);
            notebook.Show();
            Console.ReadKey();
        }
    }
}
