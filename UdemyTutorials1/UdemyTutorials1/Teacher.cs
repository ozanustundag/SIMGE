using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTutorials1
{
   sealed class Teacher :Person
    {
        public Teacher(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;

        }
        public decimal Salary { get; set; }
        public override int BusTicketPrice()
        {
            return 5;
        }
    }
    
}
