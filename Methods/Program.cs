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
            //Add();
            //Add();
            //Add();
            //Add();
            //Add();
            var result = Add2(20);

            //int number1 ;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);//ref method içindeki aynı değişken ismini orjinali ile değiştiriyor
            //                    //out değişkende değer olmadan değer atayabilir, ref ise değişkende değer yoksa çalışmaz
            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);




            Console.WriteLine(Add4(5,6,9,3));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!!");

        }
        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {



            return number1 * number2;
        }


        static int Multiply(int number1, int number2, int number3)
        {



            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)//aynı tipte istediğin kadar değer (parametre) gönderebilirsin
        {//params son parametre olmak zorunda


            return numbers.Sum();
        }


      
    }

}