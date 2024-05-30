using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        public class Product
        {
            private int productId;
            private string productName;
            private double price;
            private int quantityInStock;

            public string GetSetProductName
            {
                get { return productName; }
            }

            public double GetSetPrice
            {
                get { return price; }
            }

            public int GetSetQuantityInStock
            {
                get { return quantityInStock; }
            }

            public Product(int productId, string productName, double price, int quantityInStock)
            {
                this.productId = productId;
                this.productName = productName;
                this.price = price;
                this.quantityInStock = quantityInStock;

            }

            public void AddProduct()
            {
                Console.WriteLine("Adding product...");
            }

            public void BuyProduct()
            {
                Console.WriteLine("Buying product...");
            }

        }
        
        static void Main(string[] args)
        {
            Product product1 = new Product(101, "Laptop", 800.00, 10);

            Console.WriteLine($"Product Name : {product1.GetSetProductName}");
            Console.WriteLine($"Product Price : {product1.GetSetPrice}");
            Console.WriteLine($"Quantity In Stock : {product1.GetSetQuantityInStock}");

            //c). ProductID cannot be modified from the external code(outside the class).
            //To modify the ProductID it needs to use the Get-Set method.

            Console.ReadLine();

        }
    }
}
