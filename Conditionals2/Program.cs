using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;

            //if (number==10)
            //{
            //   Console.WriteLine("Number is 10");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("number is 20");
            //}

            //else
            //{
            //    Console.WriteLine("Number is not 10 or not 20");
            //}


            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is 10 or 20");
                    break;
            }



            //single if, yukarıdaki if in aynısı
            // Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");


            Console.ReadLine();
        }

    }
}
