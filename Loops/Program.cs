using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();  // Kodların metod haline getirilmesine Refactoring denir.
            //WhileLoop();
            //DoWhileLoop();

            #region ForLoops  //For 3 bloktan oluşur - I.Başlangıç-II.Şart- III.Her dönüş bittiğinde Başlangıç Değerini 1 arttır.
            //For 3 bloktan oluşur - I.Başlangıç-II.Şart- III.Her dönüş bittiğinde Başlangıç Değerini 1 arttır.
            //for (int i = 0; i <= 100; i++) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished");
            //Console.ReadLine();

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

            #endregion ForLoops

            #region While Loops  // Belli bir şart sağlanana kadar döngü çalışır...
            /*int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number); // Eğer altta ki şart olmaz ise sonsuz döngüye girer sürekli 100 yazar...
                number--; //Sayıyı 1 - 1 azalt... 0'a geldiğinde durur çünki number>=0 koşulu vardır.
            }
            Console.WriteLine("Now number is {0}", number);
            Console.ReadLine();
            */
            #endregion

            #region Do While Loops  // Do Çalışır Sonra döngü çalışır...
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 11);
            Console.ReadLine();
            #endregion

        }

        #region Metodlar


        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number); // Eğer altta ki şart olmaz ise sonsuz döngüye girer sürekli 100 yazar...
                number--; //Sayıyı 1 - 1 azalt... 0'a geldiğinde durur çünki number>=0 koşulu vardır.
            }
            Console.WriteLine("Now number is {0}", number);
            Console.ReadLine();

        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 11);
            Console.ReadLine();
        }

        #endregion
    }
}
