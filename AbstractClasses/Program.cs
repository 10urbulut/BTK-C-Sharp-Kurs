using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database odatabase = new Oracle();
            odatabase.Add();
            odatabase.Delete();

            Database sdatabase = new SqlServer();
            sdatabase.Add();
            sdatabase.Delete();

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
