using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exceptionintro();
            //TryCatch();
            // ActionDemo();
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            


            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);//sistem bekletme 1000= 1 saniye
            Func<int> getRandomNumber2 = () => new Random().Next(1,100);
            Console.WriteLine(getRandomNumber2());


            //Console.WriteLine(Topla(2,3));
            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }


        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);

            }
            catch (Exception exception)
            {

            }
        }

        private static void HandleException(Action action)//action delegate
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Onur", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void Exceptionintro()
        {
            try
            {
                string[] students = new string[3] { "Onur", "Derin", "Salih" };



                students[3] = "Ahmet";

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);//son kullanıcıya göstermek yerine programcı için bir yere loglanır, sistem hakkında bilgi verir

            }
        }
    }
}
