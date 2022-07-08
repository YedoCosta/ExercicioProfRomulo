using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProfRomulto.ExercicioSete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 100;

            while (i > 0)
            {
                Console.WriteLine(i);
                i--;

            }
               Console.ReadKey();
            */
            Console.WriteLine("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());
            long cal = 0;

            while (n1 > 0)

            {
                if (cal == 0)
                {
                    cal = cal + (n1 * (n1 - 1));
                    n1 = n1 - 2;

                }
                cal = cal * n1;      
                n1 = n1 - 1;
      
            }
            Console.WriteLine($"==== {cal}");
            Console.ReadKey();
        }


    }
}
