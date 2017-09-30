using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohodLeva = double.Parse(Console.ReadLine());
            double sredenUspeh = double.Parse(Console.ReadLine());
            double minRabZaplata = double.Parse(Console.ReadLine());

            double socStipendiq = Math.Floor(0.35 * minRabZaplata);
            double otlichnaStipend =Math.Floor(sredenUspeh * 25);


            if (dohodLeva > minRabZaplata)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (sredenUspeh > 5.5 && otlichnaStipend > socStipendiq)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", otlichnaStipend);
            }
            else if (sredenUspeh > 5.5 && otlichnaStipend < socStipendiq)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socStipendiq);
            }
            else if (sredenUspeh > 4.5 && dohodLeva < minRabZaplata)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socStipendiq);
            }

            //else if (dohodLeva < minRabZaplata && sredenUspeh > 4.50 && sredenUspeh<5.50)
            //{
            //    Console.WriteLine("You get a Social scholarship {0} BGN", socStipendiq);
            //}
            //else if (dohodLeva < minRabZaplata && sredenUspeh > 5.5 && socStipendiq > otlichnaStipend)
            //{
            //    Console.WriteLine("You get a Social scholarship {0} BGN", socStipendiq);
            //}
            //else if (sredenUspeh > 5.5)
            //{
            //    Console.WriteLine("You get a scholarship for excellent results {0} BGN", otlichnaStipend);
            //}
            
            
        }
    }
}
