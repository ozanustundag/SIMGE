using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Params Keyword

            Console.WriteLine(Sum(4,8,99,8));
        }
        static int Sum(params int[] numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            return result;
        }
    }
}
