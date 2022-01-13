using System;

namespace Hello_World 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i==5)
                {
                    continue;
                }
            }
            Console.WriteLine("ozan");

            //Break ve Continue'nın kullanım mantığı çok basittir. Döngü çalışması sırasında Continue
            //ile karşılaşıldığı zaman continue'nin altında kalan kısım atlanır
            //ve tekrar döngünün başına dönülür. Break'te ise döngü tamamen kırılıp daha
            //dönecek sayaç'ı olmasına rağmen döngü biter.

        }
    }
}
