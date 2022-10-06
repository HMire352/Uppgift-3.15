using System;
namespace Uppgift_3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra?");
            int timmar = int.Parse(Console.ReadLine());
            int h = 80;

            if (timmar <=11 )

            {
                Console.WriteLine(timmar * h + "kr");

               
            }
            else if (timmar >= 12)
            {
                Console.WriteLine("Nej, du får inte hyra bilen mer än 11 timmar per dag");

            }
 }   }   }
