using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> serie = new List<int>();
            for (int i = 0; i < 33; i++)
            {
                int a = fibo(i);
                if(a %2 ==0)
                {
                    serie.Add(a);
                }

            }
            Console.WriteLine(serie.Sum());
            Console.ReadKey();
        }

         static int fibo(int x)
        {
            if(x <=1)
            {
                return 1;
            }
            return fibo(x - 1) + fibo
                (x - 2);
        }

    }
}
