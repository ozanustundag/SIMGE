using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTutorials1
{
    class DelegateExample
    {
        public delegate void NoneInputDelegates();
        public delegate void TwoInputDelegates(int x,int y);

        public void Start()
        {
            NoneInputDelegates noneInputDelegates = new NoneInputDelegates(Method1);
            noneInputDelegates += Method2;

            TwoInputDelegates twoInputDelegates = new TwoInputDelegates(Method3);
            twoInputDelegates += Method4;

            noneInputDelegates?.Invoke();
            twoInputDelegates(5, 4);
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public void Method3(int x, int y)
        {
            Console.WriteLine("Method 3");
        }
        public void Method4(int x,int y)
        {
            Console.WriteLine("Method 4");
        }
    }
}
