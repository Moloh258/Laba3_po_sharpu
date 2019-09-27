using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, a, c;
            Console.WriteLine("Введите число A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int C = Convert.ToInt32(Console.ReadLine());
            a = A;
            b = B;
            c = C;
            B = c;
            C = a;
            A = b;
            Console.WriteLine("Число A: {0}", A);
            Console.WriteLine("Число B: {0}", B);
            Console.WriteLine("Число C: {0}", C);
        }
    }
}
