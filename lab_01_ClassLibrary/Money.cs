using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_ClassLibrary
{
    public class Money
    {
        public int dollars { get; private set; }
        public int cents { get; private set; }

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
            Normalize();
        }

        private void Normalize()
        {
            if (cents >= 100)
            {
               dollars += this.cents / 100;
                this.cents = this.cents % 100;
            }
        }

        public void SetAmount(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
            Normalize();
        }


        public void DisplayAmount()
        {
            Console.WriteLine("Dollars: " + this.dollars + " Cents: " + this.cents);
        }

        public override string ToString()
        {
            return $"${dollars}.{cents:00}";
        }



    }
}
