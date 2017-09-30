using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int brojSnimki = int.Parse(Console.ReadLine());
            string vidSnimki = Console.ReadLine();
            string nachinPorychka = Console.ReadLine();
            int typeSnimka = 0;           

            double[,] cenorazpis = new double[4,1];
            cenorazpis[0, 0] = 0.16;
            cenorazpis[1, 0] = 0.16;
            cenorazpis[2, 0] = 0.38;
            cenorazpis[3, 0] = 2.90;
            if (nachinPorychka=="online")
                            
            

           
            switch (vidSnimki)
            {
                case "9x13":typeSnimka = 0; break;
                case "10x15":typeSnimka = 1; break;
                case "13x18":typeSnimka = 2;break;
                case "20x30":typeSnimka = 3; break;
            }
            double totalPrice = brojSnimki*cenorazpis[typeSnimka, ;
            Console.WriteLine("{0:f2} lv.", totalPrice);
           


        }
    }
}
