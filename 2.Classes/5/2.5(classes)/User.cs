using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_classes_
{
    class User
    {
        string Login { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        protected DateTime date;
        
        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public User()
        {
            Console.Write("Введите логин: ");
            Login = Console.ReadLine();
            Console.Write("Введите имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            Surname = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            Age = Convert.ToInt32(Console.ReadLine());
            date = DateTime.Now;
        }

        public void Display()
        {
            Console.Write("\n\nВас зовут - {0} {1}\n Ваш логин - {2} \n Ваш возраст - {3} \n Дата регистрации - {4}", Surname,Name,Login,Age,Date);
        }
    }
}
