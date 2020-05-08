using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static long Factorial(int N)
        {
            long factotial = 1;


            for (int i = 2; i <= N; i++)
            {
                factotial *= i;
            }

            return factotial;

        }


        public static long Factorial1(int x)
        {

            long f = 1;
            for (int i = 2; i <= x; i++)
            {
                f *= i;
            }
            return f;
        }

        public static long Factorial2(int M)
        {
            long factotial = 1;


            for (int i = 2; i <= M; i++)
            {
                factotial *= i;
            }

            return factotial;

        }

        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("Введите число М: ");
            int M = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Количество перестановок = {Factorial(N)}");
            int x = N - M;
            long A = Factorial(N) / Factorial1(x);
            Console.WriteLine("Количество размещений = " + A);
            long C = Factorial(N) / (Factorial2(M) * Factorial1(x));
            Console.Write("Количество сочетаний = " + C);
            Console.ReadKey();

        }
    }
}






