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

        public Product(int productId, string productName, double price, int quantityInStock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public int ProductId => productId; //read only property
        
        public string ProductName
        {
            get => productName;
            set => productName = value;
        }
        public double Price
        {
            get => price;
            set => price = value;
        }
        public int QuantityInStock
        {
            get => quantityInStock;
            set => quantityInStock = value;
        }
        
        public void AddProduct()
        {
            quantityInStock++;
        }

        public void BuyProduct()
        {
            quantityInStock--;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Id : {ProductId}");
            Console.WriteLine($"Product Name : {ProductName}");
            Console.WriteLine($"Price : ${Price}");
            Console.WriteLine($"Quantity in stock : {QuantityInStock}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(101 , "Laptop", 800 , 10);

            Console.WriteLine("Product Information \n");
            product.DisplayInfo();

            /*product.ProductId = 100;
              Console.WriteLine($"Updated Product id : {product.ProductId}");
            */
            // We can't use any external code for modify the product Id.
            // Because we use read only property for the product Id...

            product.QuantityInStock = 10;
            Console.WriteLine($"Updated Quantity : {product.QuantityInStock}");

            Console.ReadLine();
        }
    }
}
