using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.MatematicaBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 3- No projeto MatematicaBasica crie um 
               Programa que calcule a soma de dois números inteiros.
               Considere que o usuário vai digitar esses dois números
             */
            // declara as variáveis
            int n1;
            int n2;
            int soma;
            // entrada de dados
            Console.WriteLine("Digite dois números: ");
            n1 = int.Parse(Console.ReadLine());
            //---------------------------------------------------
            n2 = int.Parse(Console.ReadLine());
            //--------------------------------------------------
            soma = n1 + n2;
            Console.WriteLine($" A soma é: {soma}");
            Console.ReadLine();

            //===================== imprime numeros pares, impares e divisiveis por 5=================
            /*
            int ctc = 0;

            while (ctc < 100)
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
            */
        }
    }
}
