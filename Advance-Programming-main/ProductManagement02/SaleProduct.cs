using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement02
{
    public class SaleProduct
    {
        private double sale;
        public double Sale
        {
            get { return sale; }
            set
            {
                if (value < 0 || value > 1) sale = 0.5;
                else sale = value;
            }
        }

        public SaleProduct()
        {
            sale = 0.5;
        }
        public SaleProduct(string name, double price, double sale) : base(name, price)
        {
            Sale = sale;
        }

        public void ShowInfo()
        {
            double new_price = sale * new_price;
            System.Console.WriteLine(nameof + ": $" + new_price);
        }
        public void AddNewProduct()
        {
            System.Console.WriteLine("Normal product or sale product? (n/s): " );
            string answer = Console.ReadLine();
            
        }
    }
}