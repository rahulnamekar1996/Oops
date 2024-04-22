using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Shoping
    {
        private int pId;
        private string pName;
        private double pPrice;
        private int pQuantity;

     
        public Shoping(int id, string name, double price, int quantity)
        {
            pId = id;
            pName = name;
            pPrice = price;
            pQuantity = quantity;
        }

      
        public void AcceptProductDetails(int id, string name, double price, int quantity)
        {
            pId = id;
            pName = name;
            pPrice = price;
            pQuantity = quantity;
        }

      
        public double CalculateTotalBill()
        {
            if (pQuantity <= 0)
            {
                Console.WriteLine("Error: Quantity must be greater than zero.");
                return 0;
            }
            else
            {
                return pPrice * pQuantity;
            }
        }
       
        public void ShowShoppingDetails()
        {
            Console.WriteLine($"Product ID: {pId}");
            Console.WriteLine($"Product Name: {pName}");
            Console.WriteLine($"Product Price: {pPrice}");
            Console.WriteLine($"Product Quantity: {pQuantity}");
            Console.WriteLine($"Total Bill: {CalculateTotalBill()}");
        }

    }
}
