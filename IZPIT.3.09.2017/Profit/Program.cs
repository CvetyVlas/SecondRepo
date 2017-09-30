using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneti1 = int.Parse(Console.ReadLine());
            int moneti2 = int.Parse(Console.ReadLine());
            int banknoti5 = int.Parse(Console.ReadLine());

            int suma = int.Parse(Console.ReadLine());
            bool no = true;
           
            for (int i = 1; i < moneti1; i++)
            {
                for (int j = 0; j < moneti2; j++)
                {
                    for (int k = 0; k < banknoti5; k++)
                    {
                        if (i<j &&j<k && i<k && i+j+k == suma)
                       
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5lv. = {3} lv.", moneti1, moneti2, banknoti5, suma);
                            no = false;
                        }
                        
                    }
                    

                }

            }
            
        }
    }
}
