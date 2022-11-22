using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class InventoryProgram
    {
        private Inventory myInventory;
        public InventoryProgram()
        {
            myInventory = new Inventory();
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                // Print menu consists of 3 options:
                // 1. Import Product
                // 2. Export Product
                // 3. Show all products
                // System.Console.WriteLine("1. Import Product");
                // System.Console.WriteLine("2. Export Product");
                // System.Console.WriteLine("3. Show All Products");
                // System.Console.WriteLine("0. Exit");

                PrintMenu();
                int choice = GetChoice();
                running = Process(choice);
                // Ask user to enter a choice

                // System.Console.WriteLine("Your Choice: ");
                // int choice = int.Parse(Console.ReadLine());

                // Based on the choice, call corresponding method of Inventory
                // switch (choice)
                // {
                //     case 1: myInventory.Import(); break;
                //     case 2: myInventory.Export(); break;
                //     case 3: myInventory.ShowProducts(); break;
                //     case 0: running = false; break;
                //     default: System.Console.WriteLine("Invalid Choice!"); break;
                // }
            }
        }
        public bool Process(int choice)
        {
            bool running = true;
            switch (choice)
            {
                case 1: myInventory.Import(); break;
                case 2: myInventory.Export(); break;
                case 3: myInventory.ShowProducts(); break;
                case 0: running = false; break;
                default: System.Console.WriteLine("Invalid Choice!"); break;
            }
            return running;
        }
        private int GetChoice()
        {
            System.Console.WriteLine("Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        private void PrintMenu()
        {
            System.Console.WriteLine("1. Import Product");
            System.Console.WriteLine("2. Export Product");
            System.Console.WriteLine("3. Show All Products");
            System.Console.WriteLine("0. Exit 69");
        }
    }
}