using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаем через конструктор с заданными полями: ");
            Employee u = new Employee("Манагер", "Бальшой", "Васильев", "Лёшка", "Константинович", "21.02.2000", "18");
            EmploueePrinter<Employee> printer = new EmploueePrinter<Employee>();
            printer.Print(u);

            Boss b = new Boss("Королев", "Лев", "Львиный", "21.02.1980", "38");
            BaseUserPrinter<Boss> pr = new BaseUserPrinter<Boss>();
            pr.Print(b);

            b.Punish(u, "Карась");
            printer.Print(u);
            Console.ReadKey();
        }
    }
}
