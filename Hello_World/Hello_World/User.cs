using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    class User
    {
        public string Name;

        public int age { get; set; }
        public string SurName { get; set; }

        public string Output(int x)
        {
            string message = "";
            for (int i = 0; i < x; i++)
            {
              message += Name + " " + SurName + age +"\n ";
            }
            return message;
        }
    }
}
