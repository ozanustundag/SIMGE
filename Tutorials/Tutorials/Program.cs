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
            string path = @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\system.dll";
            Assembly assembly = Assembly.LoadFile(path);
            AsmShowInfo(assembly);
            Assembly ourAsm = Assembly.GetExecutingAssembly();
            AsmShowInfo(ourAsm);


        }
        static void AsmShowInfo(Assembly asm)
        {
            Console.WriteLine("-------------");
            Console.WriteLine(asm.FullName);
            Console.WriteLine("In Gac? =" + (asm.GlobalAssemblyCache ? "True":"False"));
            Console.WriteLine("Path: " + asm.Location);
            Console.WriteLine("Version: " + asm.ImageRuntimeVersion);
        }
    }
}
