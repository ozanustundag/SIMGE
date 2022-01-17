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
            //action and func

            //action-- GERİYE DEĞER DÖNDÜRMEYEN(VOID) metotlar için kullanılır
            //delegate'in geriye değer dönmeyen .net framework versiyonudur.

            Action<int, string> action = new Action<int, string>(UserInfo);

            action(5, "OZAN");

            //func---GERİYE DEĞER döndüren(VOID) metotlar için kullanılır

            Func<int, string, string> func = new Func<int, string, string>(UserInfo1);
           Console.WriteLine( func(1, "ozi"));


        }

        static void UserInfo(int userId, string fullName)
        {
            Console.WriteLine(userId + " "+ fullName);
        }
        static string UserInfo1(int userId, string fullName)
        {
            return userId + fullName;
        }
    }
}
