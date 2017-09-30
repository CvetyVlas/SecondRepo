using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZPIT._3._09._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            double broj = double.Parse(Console.ReadLine());
            double dyljinaMasi = double.Parse(Console.ReadLine());
            double shirochinaMasi = double.Parse(Console.ReadLine());

            double pokrivkaPlosht = broj*(dyljinaMasi + 2 * 0.30) * (shirochinaMasi + 2 * 0.30);
            double kareta = broj * (dyljinaMasi / 2) * (dyljinaMasi / 2);
          
            double priceDollars = pokrivkaPlosht * 7 + kareta * 9;
            Console.WriteLine("{0:f2} USD",priceDollars);
            double priceLeva = priceDollars * 1.85;
            Console.WriteLine("{0:f2} BGN",priceLeva);
        }
    }
}
