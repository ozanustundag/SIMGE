using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    class Person
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + SurName;
            }
        }
        public string GetFullName()
        {
            return FirstName + SurName;
        }
    }
}
