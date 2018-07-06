using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class EmploueePrinter<T>: BaseUserPrinter<Employee> 
    {
        public override void Print(Employee u)
        {
            base.Print(u);
            Console.WriteLine("Position: {0}", u.Position);
            Console.WriteLine("Experience: {0}", u.Experience);
            Console.WriteLine("Status: {0}", u.Status);
            Console.WriteLine(new string('-', 20));
        }
    }
}
