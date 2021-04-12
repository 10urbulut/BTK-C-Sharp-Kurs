using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 2147483647;//32 bit
            long number2 = -9223372036854775808;//64 bit
            short number3 = -32768;//16bit
            byte number4 = 255;//8bit
            bool condition = true;//şart,var yok, evet hayır
            char character = 'A';
            double number5 = 10.4;//16 karakter tutar virgülden sonra
            decimal number6 = 10.444444444m; //29 karakter tutar virgülden sonra
            var number7 = 10;
            number7 = 'A';//integer belirlenen değere char atanırsa ascii kodu verir


            Console.WriteLine("numberone7 is : {0} ", number7);
            Console.WriteLine((int)Days.Friday);//int dizideki sayısını verir
            Console.WriteLine("numberone1 is : {0} ",number1);
            Console.WriteLine("numberone2 is : {0} ", number2);
            Console.WriteLine("numberone3 is : {0} ", number3);
            Console.WriteLine("numberone4 is : {0} ", number4);
            Console.WriteLine("numberone5 is : {0} ", number5);
            Console.WriteLine("numberone6 is : {0} ", number6);
            Console.WriteLine("Hello everbody :)");
            Console.WriteLine("Character is : {0}", (int)character);// int asci kod verir
            Console.WriteLine(condition);



            Console.ReadLine();
        }
    }
    enum Days 
    {//başlangıç değeri değişebilir ya da her birinin değeri değişebilir
        Monday=1, Tuesday, Wednasday, Thursday, Friday, Saturday,Sunday
    }
}
