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
            
        }
    }
}
