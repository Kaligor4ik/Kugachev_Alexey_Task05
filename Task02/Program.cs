using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int inR = InputReader.GetIntValue("Введите внутренний радиус курга");
            int exR = InputReader.GetIntValue("Введите внешний радиус курга");

            Console.WriteLine("Создаем кольцо внутренним радиусом {0} и внешним радиусом {1} с центром в координатах (0, 0): Ring o = new Ring(0, 0, {0}, {1})", inR, exR);
            Round o = new Ring(0, 0, inR, exR);
            Console.WriteLine("Получаем радиус: o.R = {0}", o.R);
            Console.WriteLine("Получаем общую длину окружностей: o.L = {0}", o.L);
            Console.WriteLine("Получаем площадь кольца: o.S = {0}", o.S);
            Console.ReadKey();
        }
    }
}
