using lab_01_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    class Program
    {
        static void Main()
        {
            Money price = new Money(940, 0);
            Money discount = new Money(120, 50);

            Product product = new Product("Rick Owens Hexagram", price, 10);

            Warehouse warehouse = new Warehouse();
            warehouse.AddProduct(product, DateTime.Now);

            Reporting reporting = new Reporting(warehouse);
            reporting.RegisterIncoming(product, DateTime.Now);

            try
            {
                reporting.RegisterOutgoing(product, 3); 
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            reporting.PrintInventoryReport();
        }
    }
}
