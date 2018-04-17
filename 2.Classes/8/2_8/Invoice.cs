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
        /*Мне кажется что следующие поля здесь не очень нужны:
        откуда там будут появляться данные?
        почему в счете всего одни товар, а не массив?
        почему у товара есть кол-во но нет цены?
        почему товар не сделать отдельным классом?*/
        private string article;
        private int quantity; 

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

        public void PriceOfOrderWithoutTax(double priceOfOneGood,int quantity,string article)
        {
            Console.WriteLine("Your customer: " + customer);
            Console.WriteLine("Your provider: " + provider);
            Console.WriteLine("Article: " + article);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("PriceOfGood: " + priceOfOneGood);
            Console.WriteLine("Total: " + quantity * priceOfOneGood);
        }
        public void PriceOfOrder(double priceOfOneGood, int quantity, string article)
        {
            PriceOfOrderWithoutTax(priceOfOneGood, quantity, article);
            Console.WriteLine("Tax: " + (quantity * priceOfOneGood * 0.20));
            Console.WriteLine("Total with tax: " + (quantity * priceOfOneGood * 1.20));
        }

    }
}
