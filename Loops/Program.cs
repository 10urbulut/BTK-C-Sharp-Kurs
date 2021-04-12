using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            // DoWhileLoop();

            //ForEachLoop();

            if (IsPrimeNumber(19))
            {
                Console.WriteLine("This is Prime Number ");
            }
            else
            {
                Console.WriteLine("This is nat a Prime Number");
            }

           



            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;//şarta tekrar girmemeyi sağlıyor boşa çalışmıyor
                }

            }
            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = { "Engin", "Derin", "Salih" };

            foreach (var student in students)
            {

                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now Number is :  {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 2; i = i - 2)
            {
                Console.WriteLine("Pairs  :" + i);
            }
        }
    }
}
