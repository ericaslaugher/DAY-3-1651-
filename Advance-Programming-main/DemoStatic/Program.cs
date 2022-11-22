// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using DemoStatic;

Student John = new Student("John", 69);
Student Paul = new Student("Paul", 96);
John.ShowInfo();
Paul.ShowInfo();

Student.School = "GreenWich VietNam";
John.ShowInfo();
Paul.ShowInfo();

