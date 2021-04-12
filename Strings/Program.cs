using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();


            string sentence = "My name is Onur Bulut";

            var result = sentence.Length;
            var result2 = sentence.Clone();

            sentence = "my name is Buket BULUT";
            bool result3 = sentence.EndsWith("T");
            bool result4 = sentence.StartsWith("M");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.LastIndexOf(" ");
            var result7 = sentence.Insert(0,"Hello, ");
            var result8 = sentence.Substring(3,4);//üçüncü karakterden sonra dört tane al
            var result9 = sentence.ToLower();//hepsini küçük yapar
            var result10 = sentence.ToUpper();//hepsini büyük yapar
            var result11 = sentence.Replace(" ", "-");//boşluk yerine çizgi koyuyopr
            var result12=sentence.Remove(2,4);//2den sonra 4 tanesini siler diğerleri durur



            Console.WriteLine(result12);


           
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            // string result = city + city2;
            // Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }

}
