using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement02
{
    public class Shop
    {
        private List<Product> products;
        private List<SaleProduct> saleProducts;

        public Shop()
        {
            products = new List<Product>();
            saleProducts = new List<SaleProduct>();
        }

        public void PrintMenu()
        {
System.Console.WriteLine("1. Add new products");
System.Console.WriteLine("2. Sell Products");
System.Console.WriteLine("3. Quit");
        }

        public int GetChoice()
        {
            System.Console.WriteLine("Choose options: ");
            return int.Parse(Console.ReadLine());
        }

        public void AddNewProduct()
        {
            System.Console.WriteLine("Nomal product or sale Product? (n/s): ");
            string answer = Console.ReadLine();
            if (answer == "n")
            {

            }
            else{
                
            }
        }
    }
}