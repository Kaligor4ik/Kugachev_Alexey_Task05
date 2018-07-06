using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class BaseUserPrinter<T> where T : User
    {
        public virtual void Print(T u)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Full Name: {0} {1} {2}", u.LastName, u.FirstName, u.MiddleName);
            Console.WriteLine("Birth Date: {0}", u.BirthDate);
            Console.WriteLine("Age: {0}", u.Age);
            Console.WriteLine(new string('-', 20));
        }
    }
}