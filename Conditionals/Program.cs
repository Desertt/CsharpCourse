using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 92;
            /* IF BLOĞU
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
                //Console.WriteLine(number==10 ? "Number is 10" : "Number is not 10");  // Single If BLOĞU -- "?" iSE ":" Değilse
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");

            }
            else
            {
                Console.WriteLine("Number is not 10");

            }
            
            */

            /* SWITCH BLOĞU
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 10");
                    break;
                default:   //else gibi kullanılır.
                    Console.WriteLine("Number is 10 or 20");
                    break;
            }
            Console.ReadLine();
            */

            /*ÇOKLU IFLER
            if (number>=0 && number <=100)
            {
                Console.WriteLine("Number is BETWEEN 0-100");
            }
            else if (number>100 && number<=200)
            {
                Console.WriteLine("Number is BETWEEN 101-200");
            }
            else if (number>200||number<0)
            {
                Console.WriteLine("Number is less then zero OR greater than 200");
            }
            Console.ReadLine();
            */
            if (number < 100)
            {
                if (number >= 90)
                {
                    Console.WriteLine("NUMBER İS BETWEEN 90-100");
                }
            }
            Console.ReadLine();
        }
    }
}
