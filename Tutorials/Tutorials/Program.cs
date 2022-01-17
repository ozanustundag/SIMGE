using System;

namespace Tutorials
{
    enum Acces
    {
        Admin = 1, Moderator = 5, User = 8
    }
    enum ShoesBrand
    {
        Adidas=50, Nike=250, Nixe=185
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*c# dilinde enum yapısı. Bu yapı yazılım dilinde enum, enumaration ya da enum sabitleri olarak
             adlandırılır. Değişkenlerin alabilceği değerlerin sabit(belli) olduğu durumlarda programı
            daha okunabilir hale getirmke için kullanılır. Programda birçok değişkene tek tek değer vermek yerine 
            enum kullanılabilir.
            */
            //Enum

            Shoes shoes = new Shoes();
            shoes.SelectBrand = ShoesBrand.Adidas;
            shoes.SearchByBrand(ShoesBrand.Adidas);

            

        }    
    }
     class Shoes
     {
        public ShoesBrand SelectBrand { get; set; }
        public  void SearchByBrand(ShoesBrand shoes)
        {
            if (shoes== SelectBrand)
            {
                Console.WriteLine("Shoes Matched");
            }
            else
            {
                Console.WriteLine("Shoes dont matched");
            }
        }
     }


}
