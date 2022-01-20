using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTutorials1
{
    class Teacher :Person
    {
        public decimal Salary { get; set; }
        public override int BusTicketPrice()
        {
            return base.BusTicketPrice()*5;
        }
    }
    
}
