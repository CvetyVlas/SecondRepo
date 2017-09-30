using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohodLeva = double.Parse(Console.ReadLine());
            double sredenUspeh = double.Parse(Console.ReadLine());
            double minRabZaplata = double.Parse(Console.ReadLine());

            double socStipendiq = Math.Floor(0.35 * minRabZaplata);
            double otlichnaStipend = Math.Floor(sredenUspeh * 25);

            if (sredenUspeh > 5.5 && dohodLeva > minRabZaplata)
            {

            }
            
        }
    }
}
