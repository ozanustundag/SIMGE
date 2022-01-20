using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTutorials1
{
    static class Static_Product
    {

        static int _staticNumber = 0;
        //int _number = 0;
        static int StaticMethod()
        {
            _staticNumber++;
            return _staticNumber;
        }
        //public int normalMethod()
        //{
        //    return ++_number;
        //}
    }
}
