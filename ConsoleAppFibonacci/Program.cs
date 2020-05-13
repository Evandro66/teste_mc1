using System;

namespace ConsoleAppFibonacci
{
    class Program
    {
        static double FibonacciInterativeSeries(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            if (n == 0) return 0;
            if (n == 1) return 1;

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }

        public static double FibonacciRecursiveSeries(int n, int a = 0, int b=1)
        {
            if (n == 0) return a;
            if (n == 1) return b;
           
            return FibonacciRecursiveSeries(n - 1, b, a + b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o e-nésimo elemento da Sequencia de Fibonacci: ");
            int length = Convert.ToInt32(Console.ReadLine());
            DateTime dateTimeStart = DateTime.Now;
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciInterativeSeries(i));
            }
            
            Console.WriteLine("\n\rDuration Interative {0}", DateTime.Now - dateTimeStart);
            Console.ReadKey();
            dateTimeStart = DateTime.Now;
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciRecursiveSeries(i));
            }
            Console.WriteLine("\n\rDuration Recursive {0}", DateTime.Now - dateTimeStart);
            Console.ReadKey();
        }
    }
}
