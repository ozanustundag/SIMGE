using System;
using System.Linq;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert between list and array
            List<string> movies = new List<string> { "pulp fiction", "dark knight rises" };
            string[] myArray = movies.ToArray();
            foreach (string movie in myArray)
            {
                Console.WriteLine(movie + "\n");
            }
            int[][] myLuckyNumbers =
            {
               new int[] {5,2,8,9},
               new int[] {45,88,78},
               new int[] {4,7}
            };
            List<int> myNewList = myLuckyNumbers[1].ToList();
            foreach (int numbers in myNewList)
            {
                Console.WriteLine(numbers + "\n");
            }
        }
    }
}   

