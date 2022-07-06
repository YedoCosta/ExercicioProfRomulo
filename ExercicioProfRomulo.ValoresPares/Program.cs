using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProfRomulo.ValoresPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //===================== Imprime numeros pares  ===============
            int ctc = 0;

            while (ctc <= 100)
            {
                ctc++;
                int mod = ctc % 2;
                int mod5 = ctc % 5;

                if (mod == 0)
                {
                    Console.WriteLine($"{ctc} É número par");
                  
                }
                else
                {
                    Console.WriteLine($"==========> {ctc} É número impar");
                }

                if (mod5 == 0)
                {
                    Console.WriteLine($"======================> {ctc} É divisível por 5");

                }


            }
            Console.ReadKey();
        }
    }
}
