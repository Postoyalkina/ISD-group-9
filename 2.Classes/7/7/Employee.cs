using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Employee
    {
        string lastName;
        string firstName;
        string position;
        double experience;
        double taxFree = 15;

        public Employee(string lastName, string firstName, string position, double experience)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.position = position;
            this.experience = experience;
        }

        public double GetSalary()
        {
            int positionSalary;
            switch (position)
            {
                case "Director":
                    positionSalary = 30;
                    break;
                case "Manager":
                    positionSalary = 20;
                    break;
                case "Programmer":
                    positionSalary = 15;
                    break;
                default:
                    positionSalary = 10;
                    break;
            }

            return positionSalary * experience - taxFree;
        }
        public void Show()
        {
            Console.WriteLine("Last name: " + lastName + "\nFirstName: " + firstName + "\nPosition: " + position
                + "\nSalary: " + GetSalary() + "\nTax free: " + taxFree);
        }
    }
}
