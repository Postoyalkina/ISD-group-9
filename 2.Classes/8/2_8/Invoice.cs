using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8
{
    class Invoice
    {
        int account;
        string customer;
        string provider;
        private string article;
        private int quantity;
        private double price;

        public int Account
        {
            get
            {
                return account;
            }
        }
        public string Customer
        {
            get
            {
                return customer;
            }
        }
        public string Provider
        {
            get
            {
                return provider;
            }
        }

        public Invoice(int account,string customer,string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void SetDealParams(double priceOfOneGood, int quantity, string article)
        {
            price = priceOfOneGood;
            this.quantity = quantity;
            this.article = article;
        }
        public void PriceOfOrderWithoutTax()
        {
            Console.WriteLine("Your customer: " + customer);
            Console.WriteLine("Your provider: " + provider);
            Console.WriteLine("Article: " + article);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("PriceOfGood: " + price);
            Console.WriteLine("Total: " + quantity * price);
        }
        public void PriceOfOrder()
        {
            PriceOfOrderWithoutTax();
            Console.WriteLine("Tax: " + (quantity * price * 0.20));
            Console.WriteLine("Total with tax: " + (quantity * price * 1.20));
        }

    }
}
