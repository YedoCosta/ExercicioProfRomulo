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
            int ctc = 0;

            while (ctc <= 99)
            {
                ctc++;

                if (ctc % 2 == 0)
                {
                    //===================== Imprime numeros pares  ===============
                    Console.WriteLine($"" +
                        $" {ctc} É número par");                
                }
                else
                {
                    //===================== Imprime numeros impares  ===============
                    Console.WriteLine($"==========> {ctc} É número impar");
                }

                if (ctc % 5 == 0)
                {
                    //===================== Imprime numeros divisíveis por 5  ===============
                    Console.WriteLine($"======================> {ctc} É divisível por 5");
                }
            }

            ctc --;
            Console.WriteLine(ctc);
            ctc *= 2;
            Console.WriteLine(ctc);

            ctc ++;
            Console.WriteLine(ctc);
            ctc /= 2;
            Console.WriteLine(ctc);

            Console.ReadKey();

        }
    }
}
