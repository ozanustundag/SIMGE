using System;
using System.Data;
namespace Tutorials
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Exception Handling

            int a = 8;
            int b = 0;
            /*  try
              {
                  //hata oluşabilecek kodların yazıldığı alan
                  Console.WriteLine(a / b);
              }
              catch (Exception)
              {
                  // hata oluşunca yaılacakların yazıldığı alan
                  Console.WriteLine("Error");

              }
            */
            int[] numbers = new int[3] { 5, 4, 6 };
            /*  try
              {
                  Console.WriteLine(numbers[5]);
                  Console.WriteLine(a / b);
              }
              catch (IndexOutOfRangeException ex)
              {
                  Console.WriteLine(ex.Message);
              }
              catch(DivideByZeroException ex)
              {
                  Console.WriteLine(ex.Message);
              }
              catch(Exception ex)
              {
                  Console.WriteLine(ex.Message);
              } */

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //hata olsa da olmasa da çalışır. hata olduğunda halledeilmesi gereken son işlemler burada yapılır
                //ve hata fırlatılır.
            }
        }     
    }
}
