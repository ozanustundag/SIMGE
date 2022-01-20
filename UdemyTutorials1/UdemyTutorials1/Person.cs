using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTutorials1
{
    abstract class Person
    {
        int _age;
        string _name;
        string _surname;

        public int Age
        {
            get { return _age; }
            set
            {
                if (Age > 10)
                {
                    Console.WriteLine("ERROR");
                }
                else
                    _age = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value.ToLower(); }
        }
        public string SurName
        {
            get { return _surname; }
            set { _surname = value.ToUpper(); }
        }

        abstract public int BusTicketPrice();
       
    }
}
