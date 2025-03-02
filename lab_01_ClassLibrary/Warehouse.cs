using lab_01_ClassLibrary;
using System.Collections.Generic;
using System.Text;
using System;

public class Warehouse
{
    private List<(Product Product, DateTime LastDeliveryDate)> products = new List<(Product, DateTime)>();

    public void AddProduct(Product product, DateTime lastDeliveryDate)
    {
        products.Add((product, lastDeliveryDate));
    }

    public string GetInventoryReport()
    {
        var report = new StringBuilder("All products in the warehouse:\n");

        foreach (var item in products)
        {
            report.AppendLine($"{item.Product}, Last delivery date: {item.LastDeliveryDate.ToShortDateString()}");
        }

        return report.ToString();
    }
}