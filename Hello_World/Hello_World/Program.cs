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

            //Console.WriteLine(ozan.GetFullName());
            //Console.WriteLine(ozan.FullName);
            Console.WriteLine("Guess name: ");
            string guess1 = Console.ReadLine();
            Console.WriteLine("second guess for name:");
            string guess2 = Console.ReadLine();

            if (guess1 == ozan.FullName)
            {
                Console.WriteLine("+1 point");
            }
            else if (guess2 == ozan.FullName)
            {
                Console.WriteLine("+1/2 point ");
            }
            else
            {
                Console.WriteLine("0 point");
            }
        }           
    }
}
