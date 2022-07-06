using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProfRomulo.EscolinhaTictic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 4- Crie um programa para a escolinha Tic Tic
               calcular 3 notas de um aluno.
               Entrar com o nome do aluno e as três notas
               Mostrar a soma das notas e a média.
             * 
             */
            double n1;
            double n2;
            double n3;
            double soma;
            string nome, resultado;

            //=================== entrada de dados

            Console.WriteLine("\r\nDigite o nome do aluno: \r\n");
            nome = Console.ReadLine();
            //--------------------------------------------------
            Console.WriteLine("\r\nDigite três números: \r\n");
            n1 = double.Parse(Console.ReadLine());
            //---------------------------------------------------
            n2 = double.Parse(Console.ReadLine());
            //--------------------------------------------------
            n3 = double.Parse(Console.ReadLine());
            //--------------------------------------------------

            soma = n1 + n2 + n3 ;
            Console.WriteLine(soma);

            //------------------ faz arredondamento ---------------
            // sum += Math.Round(value, 1, MidpointRounding.AwayFromZero);
            double media = soma / 3;
            double arred = Math.Round(media, 2, MidpointRounding.AwayFromZero);

            Console.WriteLine($"\r\n Nome do Aluno: {nome}; \r\n A soma das notas é: {soma}; \r\nA média das notas é: {arred}");

            // ----------------------- usando Operador ternário ----------------

            resultado = arred > 7 ? "Aprovado" : "Reprovado";

            //------------------------ usando IF ----------------------------------
            /*
            if (arred < 7)
            {
                resultado = "Reprovado"; 
            }
            else
            {
                resultado = "Aprovado";
            }*/
            //------------------------------------------------------------------
            Console.WriteLine($"Sua média {(arred)}, voce está {resultado}....");
            Console.ReadLine();
        }
    }
}

