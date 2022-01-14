using System;
using System.Linq;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods to Sort and Reverse List
            List<string> myGames = new List<string> { "last of us", "gow", "rdr2" };
            myGames.Sort();
            myGames.Reverse();
            foreach (string games in myGames )
            {
                Console.WriteLine(games);
            }
        }
    }
}   

