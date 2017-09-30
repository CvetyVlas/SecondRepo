using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoPicture2
{
    class Program
    {
        static void Main(string[] args)
        {
            double brojSnimki = double.Parse(Console.ReadLine());
            string vidSnimki = Console.ReadLine();
            string nachinPorychka = Console.ReadLine();

            string photo1 = "9x13";
            string photo2 = "10x15";
            string photo3 = "13x18";
            string photo4 = "20x30";

            double cena1 = 0.16;
            double cena2 = 0.16;
            double cena3 = 0.38;
            double cena4 = 2.90;

            

            if (vidSnimki==photo1)
            {
                if (brojSnimki > 50)
                {
                   decimal sum = brojSnimki * cena1;

                }

            }
            //string summer = "summer";
            //string winter = "winter";
            //string bulgaria = "bulgaria";
            //string abroad = "abroad";
            //if (sezon == summer)
            //{
            //    decimal sum = 0.0m;
            //    if (place == bulgaria)
            //    {
            //        sum = points * dancers;
            //        sum -= sum * 5 / 100; // <-- sum * 0.05;
            //    }
            //    else if (place == abroad)
            //    {
            //        sum = (dancers * points);
            //        sum += sum * 0.5m;
            //        sum -= sum * 10 / 100; // <-- sum * 0.10;
            //    }
            //    decimal charity = sum * 75 / 100; // < -- sum * 0.75;
            //    decimal remainingMoney = sum - charity;
            //    decimal sumForEveryDancer = remainingMoney / dancers;
            //    Console.WriteLine("Charity - {0:F2}", charity);
            //    Console.WriteLine("Money per dancer - {0:F2}", sumForEveryDancer);

            //}
            //else if (sezon == winter)
            //{
            //    decimal sum2 = 0.0m;
            //    if (place == bulgaria)
            //    {
            //        sum2 = points * dancers;
            //        sum2 -= sum2 * 8 / 100; // <--sum2 * 0.08;
            //    }
            //    else if (place == abroad)
            //    {
            //        sum2 = (dancers * points);
            //        sum2 += sum2 * 0.5m;
            //        sum2 -= sum2 * 15 / 100; // <-- sum2 * 0.15;
            //    }
            //    decimal charity = sum2 * 75 / 100; // <
            //    decimal remainingMoney = sum2 - charity;
            //    decimal sumForEveryDancer = remainingMoney / dancers;
            //    Console.WriteLine("Charity - {0:F2}", charity);
            //    Console.WriteLine("Money per dancer - {0:F2}", sumForEveryDancer);

        }
        }
}
