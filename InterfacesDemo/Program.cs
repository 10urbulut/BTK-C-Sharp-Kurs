using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Worker();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    interface IEat
    {
        
        void Eat();
        
    }
    interface IWorker
    {
        void Worker();
        
    }
    interface ISalary
    {
       
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Worker()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }
        //SOLID, Interface Segregation
        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        void IWorker.Worker()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Worker()
        {
            throw new NotImplementedException();
        }
    }
}
