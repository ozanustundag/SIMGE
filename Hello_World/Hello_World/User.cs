using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    class User
    {
         string _name ;
        string _surName;

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value.ToLower();
            }
        }
        public int age { get; set; }
        public string SurName {
            get
            {
                return _surName;
            }
            set 
            {
                _surName = value;
            }             
        }
        public string FullName {
            get 
            {
                return _name + " " + _surName;
            }
        }

        public string Output(int x)
        {
            string message = "";
            for (int i = 0; i < x; i++)
            {
              message += FullName+"\n ";
            }
            return message ;
        }
        public string Output()
        {
            return FullName ;
        }
        public static void PrintUser(User user)
        {
            Console.WriteLine(user.FullName);
        }
        public static void PrintUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }
    }
}
