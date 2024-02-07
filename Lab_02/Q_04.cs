using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    public class Product
    {
        public string ProductName;
        public double price;

        public Product(string productName,double ProductPrice)
        {
            ProductName = productName;
            price = ProductPrice;
        }

        public void ProductDetails()
        {
            Console.WriteLine("Product Details : ");
            Console.WriteLine($"Product Name : {ProductName}");
            Console.WriteLine($"Price : {price}");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Product p1 = new Product("smart phone" , 120000.00);
            p1.ProductDetails();
            Console.ReadLine();
        }



    }
}
