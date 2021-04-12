using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","Kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");


           //Console.WriteLine(dictionary["table"]);
            // Console.WriteLine(dictionary["glass"]);//sözlükte yok hata verir

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary.ContainsKey("Glass"));//hata vermez değer yoksa false verir
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            // Console.WriteLine(cities.Contains("Ankara"));//içinde olan değeri true döndürür

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Onur" });
            customers.Add(new Customer { Id = 2, FirstName = "Derin" });

            var customer2 = new Customer
            {

                Id = 3,
                FirstName = "Salih"

            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]{// liste olarak eklemeyi sağlıyor
                new Customer {Id=4,FirstName="Ali" },
                new Customer { Id=5,FirstName="Ayşe"}
            });
            // customers.Clear();

            Console.WriteLine(customers.Contains(customer2));

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index  :  {0}", index);//baştan dizide kaçıncı sırada olduğunu gösterir

            customers.Add(customer2);

            var index2 = customers.LastIndexOf(customer2);//sondan kaçıncı sırada olduğunu gösterir
            Console.WriteLine("İndex sondan : {0}", index2);

            customers.Insert(0, customer2);// listenin arasına ekleme yapmak için kullanılır

            //customers.Remove(customer2);//ilk bulduğunu siler
            //customers.Remove(customer2);
            //customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Salih");// ismi salih olanların hepsini siler

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("Count  :  {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

    }

}

