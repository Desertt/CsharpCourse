using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //For 3 bloktan oluşur - I.Başlangıç-II.Şart- III.Her dönüş bittiğinde Başlangıç Değerini 1 arttır.
            for (int i = 0; i <= 100; i++) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
               
            /*
             //For 3 bloktan oluşur - I.Başlangıç-II.Şart- III.Her dönüş bittiğinde Başlangıç Değerini 1 arttır.
            for (int i = 1; i <= 100; i=i+2) //Eğer tek sayıları yazdırmak istersek ==>i+=2 veya i=i+2
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
             
             */

            /*
            //For 3 bloktan oluşur - I.Başlangıç-II.Şart- III.Her dönüş bittiğinde Başlangıç Değerini 1 arttır.
           for (int i = 0; i <= 100; i=i+2) //Eğer çift sayıları yazdırmak istersek ==>Başlangıç çift ile başlamalıdır-->i+=2 veya i=i+2
           {
               Console.WriteLine(i);
           }
           Console.WriteLine("Finished");
           Console.ReadLine();

            */

            /*
            //For 3 bloktan oluşur - I.Başlangıç-II.Şart- III.Her dönüş bittiğinde Başlangıç Değerini 1 arttır.
           for (int i = 100; i <= 100; i=i-2) //Eğer Başlangıç 100 den itibaren geriye giderse--i=100  -- i=i-2 olmalıdır.
           {
               Console.WriteLine(i);
           }
           Console.WriteLine("Finished");
           Console.ReadLine();

            */

        }
    }
}
