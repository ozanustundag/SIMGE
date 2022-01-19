using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary 
            Dictionary<int, string> myDic = new Dictionary<int, string>() { {1, "ozan" },{ 5,"Aslı"} };

            foreach (var x in myDic)
            {
                Console.WriteLine(x.Key + "=" + x.Value);
            }
            //Queue
            Queue<string> myQue = new Queue<string>();
            myQue.Enqueue("ankara");
            myQue.Enqueue("izmir");
            for (int i = 0; i < myQue.Count; i++)
            {
                Console.WriteLine(myQue.Dequeue());
            }

        }
    }
}
