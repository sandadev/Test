using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer {Id=1,Name="jhin" };
            var person = new Person();
            person.Birthday = new DateTime(1987,09,18);
            Console.WriteLine(person.Age);
        }
    }
}
