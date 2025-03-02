using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_ClassLibrary
{
    public class Product
    {
        public string name { get; set; }
        public Money price { get; set; }
        public int quantity { get; set; }

        public Product(string name, Money price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void ReducePrice(Money amount)
        {
            int totalCents = this.price.dollars * 100 + this.price.cents;
            int amountCents = amount.dollars * 100 + amount.cents;
            int newTotalCents = totalCents - amountCents;

            if (newTotalCents < 0)
            {
                Console.WriteLine("Price cannot be negative");
            }
            
            price.SetAmount(newTotalCents / 100, newTotalCents % 100);



        }

        public override string ToString()
        {
            return "Name: " + this.name + " Price: " + this.price + " Quantity: " + this.quantity;
        }

    }
}
