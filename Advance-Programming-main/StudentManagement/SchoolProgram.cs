using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class SchoolProgram
    {
        // attribute: school
        private School GreenWich;

        // default constructor
        public SchoolProgram()
        {
            GreenWich = new School("GreenWich");
        }

        // PrintMenu
        public void PrintMenu()
        {
            System.Console.WriteLine("1. Enroll student ");
            System.Console.WriteLine("2. Drop Out student ");
            System.Console.WriteLine("3. Show all student ");
            System.Console.WriteLine("4. Exit ?");
        }

        // GetChoice
        public int GetChoice()
        {
            System.Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        // Process
        public bool Process(int choice)
        {
            bool running = true;
            switch (choice)
            {
                case 1:
                    GreenWich.Enroll();
                    break;
                case 2:
                    GreenWich.DropOut();
                    break;
                case 3:
                    GreenWich.ShowStudents();
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    System.Console.WriteLine("Invalid choice!!!!!");
                    break;
            }
            return running;
        }

        //run
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                running = Process(choice);
            }
        }
    }
}