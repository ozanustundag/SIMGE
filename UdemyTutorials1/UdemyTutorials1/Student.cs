﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTutorials1
{
    class Student:Person
    {
        public Student(string name,string surName,int age)
        {
            Name = name;
            SurName = surName;
            Age = age;

        }
        public int Class { get; set; }
        public override int BusTicketPrice()
        {
            return base.BusTicketPrice()*2;
        }
    }
}
