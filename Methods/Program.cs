﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            //var result=Add2(20);
            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1,number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Add");
        }
        
        static int Add2(int number1, int number2=30)  //default parametre kullanılabilir.kdv gibi işlemlerde sabit değer olarak kullanılabilir.
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
