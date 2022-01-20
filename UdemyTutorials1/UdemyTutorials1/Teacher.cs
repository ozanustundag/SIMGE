using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTutorials1
{
   sealed class Teacher :Person ,ISchoolMember
    {
        public Teacher(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;

        }
        public decimal Salary { get; set; }
        public int SchoolId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int BusTicketPrice()
        {
            return 5;
        }

        public void SchoolMemberInfo()
        {
            throw new NotImplementedException();
        }
    }
    
}
