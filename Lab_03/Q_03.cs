using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    public class Product
    {
        private int productId;
        private string productName;
        private double price;
        private int quantityInStock;

        public Product(int productId, string productName, double price, int quantityInStock)//constructor
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }
        
        public void AddProduct(int quantity)
        {
            quantityInStock += quantity;
            Console.WriteLine($"Quantity in stock : {quantityInStock}");
        }

        public void BuyProduct(int quantity)
        {
            if(quantity <= quantityInStock)
            {
                quantityInStock -= quantity;
                Console.WriteLine($"Quantity in stock : {quantityInStock}");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Id : {productId}");
            Console.WriteLine($"Product Name : {productName}");
            Console.WriteLine($"Price : ${price}");
            Console.WriteLine($"Quantity in stock : {quantityInStock}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(101 , "Laptop", 800 , 10);

            Console.WriteLine("Product Information \n");
            product.DisplayInfo();

        
            // We can't use any external code for modify the product Id.
            // Because product id field is a private field

            Console.ReadLine();
        }
    }
}
