using System;

namespace Hello_World 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            string name = "ozan";

            switch (name)
            {
                case "ozan":
                    Console.WriteLine("cool name");
                    return;
                case "aslı":
                    Console.WriteLine("not cool ");
                    break;
                 default:
                    Console.WriteLine("you r nothing");
                    break;


            }
       
        }           
    }
}
