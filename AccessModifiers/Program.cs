using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        int id;

    }
    class Student : Customer
    {
        public void Save()
        {

        }
    }
    public class Course
    {
        public string Name { get; set; }

        private class NestedClass
        {

        }
    }
}
