using System;

namespace Hello_World 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Person ozan = new Person();

            ozan.FirstName = "ozan";
            ozan.SurName = "ustundag";

            Console.WriteLine(ozan.GetFullName());
            Console.WriteLine(ozan.FullName);
        }           
    }
}
