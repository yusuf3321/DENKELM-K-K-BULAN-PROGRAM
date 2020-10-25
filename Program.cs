using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EĞİTİM
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" A DEĞERİNİ GİRİNİZ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" B DEĞERİNİ GİRİNİZ");
            int B = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" C DEĞERİNİ GİRİNİZ");
            int C = Convert.ToInt32(Console.ReadLine());



            double d = (B * B) - 4 * A * C;

            if (d > 0)
            {
                double X1 = ((-B - Math.Sqrt(d)) / (2 * A));
                double X2 = ((-B + Math.Sqrt(d)) / (2 * A));

                Console.WriteLine(" DENKLEMİN İKİ KÖKÜ VARDIR !");
                Console.WriteLine(" X1 = " + X1);
                Console.WriteLine(" X2 = " + X2);
            }

            else if (d == 0)
            {
                double x = -B / (2 * A);
                Console.WriteLine("Denklemin bir kökü vardır ! ");
                Console.WriteLine(" X = " + x);
            }
            else
            {
                Console.WriteLine(" Gerçek kök yoktur ! ");
            }
            Console.ReadKey();
        }
    }
}
        
    



        