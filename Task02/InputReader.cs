using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class InputReader
    {
        public static int GetIntValue(string message)
        {
            bool b = false;
            int i;
            do
            {
                Console.WriteLine(message);
                b = int.TryParse(Console.ReadLine(), out i);
            } while (!b);
            return i;
        }
    }
}