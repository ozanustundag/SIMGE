using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTutorials1
{
   sealed class Student:Person ,ISchoolMember
    {
        public Student(string name,string surName,int age)
        {
            Name = name;
            SurName = surName;
            Age = age;

        }
        public int Class { get; set; }
        public int SchoolId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int BusTicketPrice()
        {
            return 2;
        }

        public void SchoolMemberInfo()
        {
            throw new NotImplementedException();
        }
    }
}
