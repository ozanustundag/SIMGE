using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace Tutorials
{
    class Program 
    {
        static void Main (string[] args)
        {

            Liste<string> liste = new Liste<string>();
            liste.Add("ozan");
            liste.Add("kamyon");
            liste.Get();

        }        

    }
    class Liste
    {

    }
    class Liste<T> // class overloading
    {
        List<T> list = new List<T>();

        public void Add(T element)
        {
            list.Add(element);
        }
        public void Get()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}
