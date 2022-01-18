using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reflection 
            /*Reflection Nedir?
             Reflection bize hakkında bilgi sahibi olmadığımız programatik nesnelerle 
            ilegli çalışma zamnında (run-time) bilgi alabilmemizi sağlayan bir yöntemdir.
            Örneğin programın çalışma anında farklı bir dll dosyasınu uygulama içerisine dahil
            ederek içerisindeki meot ve dışarı açık nesnleri kulallanabilmemizi sağlar.
             */


            Type t = typeof(MyClass);
            MyClass reflect = new MyClass(10, 20);
            int val;

            Console.WriteLine("Kullanılan Sınıf: " + t.Name);
            Console.WriteLine();
            MethodInfo[] mi = t.GetMethods();



        }
        public class MyClass
        {
            int x;
            int y;
            public MyClass(int i, int j)
            {
                x = i;
                y = j;
            }
            public int Sum()
            {
                return x + y;
            }
            public bool IsBetween(int i)
            {
                if (x < i && i < y)
                {
                    return true;
                }
                else return false;
            }
            public void Set(double a,double b)
            {
                Console.Write("İnside Set(double,double).");
                x = (int)a;
                y = (int)b;
                Show();
            }
            public void Set(int a,int b)
            {
                Console.Write("İnside Set(int,int).");
                x = a;
                y = b;
                Show();
            }
            public void Show()
            {
                Console.WriteLine("Values are : {0},{1}", x, y);
            }
        } 
    }
    
}
