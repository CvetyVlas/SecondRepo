using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n / 2; i++)
            //{
            //    Console.WriteLine("{0}{1}{0}", new string('.', n + i), new string('#', 3 * n - (i * 2)));
            //}

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', n-i));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n-1), new string('*', 5));
            Console.WriteLine("{0}", new string('*', 2 * n + 3));
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n-i-1), new string('.', i+1));
            }
        }
    }
}
