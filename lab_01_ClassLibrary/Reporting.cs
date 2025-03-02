using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_ClassLibrary
{
    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void RegisterIncoming(Product product, DateTime deliveryDate)
        {
            warehouse.AddProduct(product, deliveryDate);
            Console.WriteLine("Product registered");
        }

        public void RegisterOutgoing(Product product, int quantity)
        {
            if (product.quantity < quantity)
            {
                throw new InvalidOperationException("Not enough products in stock.");
            }

            product.quantity -= quantity;

            Console.WriteLine($"Outgoing registered: {quantity} units of {product.name}");
        }

        public void PrintInventoryReport()
        {
            Console.WriteLine(warehouse.GetInventoryReport());
        }


    }
}
