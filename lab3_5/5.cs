using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToInt32(Console.ReadLine());
            double y = 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 2;
            Console.WriteLine("Ответ: {0}", y);
        }
    }
}
