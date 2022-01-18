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
            Console.WriteLine("Class that we are lookin for: " + t.Name);
            Console.WriteLine("Methods that supperted by this class:\n");

            MethodInfo[] methods = t.GetMethods();

            foreach (MethodInfo methodInfo in methods)
            {
                Console.WriteLine("Method Name: " + methodInfo.Name);
                Console.WriteLine("Method Return Type: " + methodInfo.ReturnType.Name);
                
                ParameterInfo[] parameters = methodInfo.GetParameters();

                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.WriteLine("Paramater Type: "+
                   parameters[i].ParameterType.Name +" Parameter Name: "+ parameters[i].Name);
                }
                Console.WriteLine("**************");
            }       
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
                x = (int)a;
                y = (int)b;
            }
        } 
    }
    
}
