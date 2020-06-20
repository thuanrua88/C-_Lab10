using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper11
{
    class Product
    {
        private int quantity;
        private float price;
        private double sales;
        string productName;
        public Product()
        {
            productName = "Motherboard";
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter the number of " + productName + " sold");
            try
            {
                quantity = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException objFormat)
            {
                Console.WriteLine("Error: " +objFormat);
                return;
            }
            Console.WriteLine("Enter the price of the product");
            if (float.TryParse((Console.ReadLine()), out price) == true)
            {
                sales = price * quantity;
            }
            else
            {
                Console.WriteLine("Invalid price inserted");
            }
        }
        public void Display()
        {
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Product Price: " + price);
            Console.WriteLine("Quantity sold: " + quantity);
            Console.WriteLine("Total Sale Value: " + sales);
        }
        static void Main(string[] args)
        {
            Product objGoods = new Product();
            objGoods.AcceptDetails();
            objGoods.Display();
        }
    }
}