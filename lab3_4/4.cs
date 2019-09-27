using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToInt32(Console.ReadLine());
            double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine("Ответ: {0}", y);
        }
    }
}
