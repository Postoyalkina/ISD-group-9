using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value > 0)
                    index = value;
                else
                    throw new Exception("Index can't be less than 0! Address.Index{set}");
            }
        }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                if (value > 0)
                    house = value;
                else
                    throw new Exception("House can't be less than 0! Address.House{set}");
            }
        }
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                if (value > 0)
                    apartment = value;
                else
                    throw new Exception("Apartment can't be less than 0! Address.Apartment{set}");
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new Exception("Name of country can't be longer than 100 symbols! Address.Country{set}");
                }
                else
                {
                    country = value;
                }
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new Exception("Name of city can't be longer than 100 symbols! Address.City{set}");
                }
                else
                {
                    city = value;
                }
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new Exception("Name of street can't be longer than 100 symbols! Address.Street{set}");
                }
                else
                {
                    street = value;
                }
            }
        }

        public void WriteAddress()
        {
            Console.WriteLine("Индекс:"+index);
            Console.WriteLine("Страна:" + country);
            Console.WriteLine("Город:" + city);
            Console.WriteLine("Улица:" + street);
            Console.WriteLine("Дом:" + house);
            Console.WriteLine("Квартира:" + apartment);
        }
    }
}
