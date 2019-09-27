using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_6
{
    class Program
    {
        static void Main(string[] args)
        {

            int A1;
            Console.WriteLine("Введите число");
            int A = Convert.ToInt32(Console.ReadLine());
            A1 = A * A;
            A = A1 * A1;
            A1 = A * A;
            Console.WriteLine("Ответ: {0}", A1);

        }
    }
}
