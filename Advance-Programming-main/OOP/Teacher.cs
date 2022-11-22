// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

namespace OOP
{
    public class Teacher
    {
        private string name;
        public string Name
        {
            get { return Name;}
            set
            {
                if (value == "") Name = "John";
                else Name = value;
            }
        }

        private string subject;
        public string Subject
        {
            get { return Subject;}
            set
            {
                if (value == "") Subject = "1651";
                else Subject = value;
            }
        }

        private int age;
        public int Age
        {
            get { return Age;}
            set
            {
                if (value == 0) Age = 30;
                else Age = value;
            }
        }
    }
}