using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");

            decimal number6 = 10.4m;//ondalıklı atanabilir fakat sonuna m harfi eklenmelidir.
            double number5 = 10.4; //ondalıklı sayılar için
            char character = 'A'; //char veri tipinde atamak için tek tırnak kullanılır
            string city = "Ankara"; //bir karakter dizisidir.
            bool condition = true;
            byte number4 = 255;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 9221561662147483648;
            //"var" Değişken tipi tutmak için kullanılır.
            var number7 = 10;
            number7 = 'A'; //ASCII karşılığı yazılıyor

            Console.WriteLine("Number 1 is {0}", number1);   //{0}{1},number1,number2 şeklindede parametre alınabilir.
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 4 is {0}", number4);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Character is {0}", (int)character);//karakter veri tipi integer tipine çevirilebilir.Başına (int) koyularak
            Console.WriteLine("Number 5 is {0}", number5);
            Console.WriteLine("Number 6 is {0}", number6);
            Console.WriteLine("Number 7 is {0}", number7);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);  //İndex değeride alınabilir.
            Console.ReadLine();
        }
        enum Days  //enum sabitleri toplu halde yazmak için kullanılır.
        {
            Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday //Başlangıç(Index) değeri değiştirilebilir.
        }
    }
}
