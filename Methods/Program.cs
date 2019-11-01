using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            //var result=Add2(20);
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4,5));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Add");
        }

        static int Add2(int number1, int number2 = 30)  //default parametre kullanılabilir.kdv gibi işlemlerde sabit değer olarak kullanılabilir.
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2) //Çarpma İşlemi
        {
            return number1 * number2;

        }
        static int Multiply(int number1, int number2, int number3) //Çarpma İşlemi
        {
            return number1 * number2 * number3;

        }

        //Challenge param keyword 'de kaldık
    }
}
