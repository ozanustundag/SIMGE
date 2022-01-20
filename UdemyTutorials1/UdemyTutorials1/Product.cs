using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTutorials1
{
    class Product
    {
        public Product()
        {
            _staticNumber++;
            _number++;
        }
        static int _staticNumber=0;
        int _number = 0; 
        public static int StaticMethod()
        {           
           return _staticNumber;
        }
        public  int normalMethod()
        {
            return _number;
        }
       
    }
}
