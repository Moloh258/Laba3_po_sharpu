using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            Console.WriteLine("Введите первое число");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int B = Convert.ToInt32(Console.ReadLine());
            C = A;
            A = B;
            B = C;
            Console.WriteLine("Новое первое число: {0}. Новое второе число: {1}", A, B);
            
        }
    }
}
