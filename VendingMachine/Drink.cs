using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Drink : Product
    {
        public Drink(string productName, decimal price) : base(productName, price)
        {

        }
        public override string Examine()
        {
            string message = (Convert.ToString(this.ProductPrice) + " | " + this.ProductName);
            Console.WriteLine(message);
            return message;
        }

        public override string Use()
        {
            string message = "Drink the Drink";
            Console.WriteLine(message);
            return message;
        }
    }
}
