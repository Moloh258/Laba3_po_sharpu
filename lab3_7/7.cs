using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A1, A2;
            Console.WriteLine("Введите число");
            int A = Convert.ToInt32(Console.ReadLine());
            A1 = A * A;
            A2 = A1 * A;
            A1 = A2 * A1;
            A2 = A1 * A1;
            A1 = A2 * A1;
            
            Console.WriteLine(A1);

        }
    }
}
