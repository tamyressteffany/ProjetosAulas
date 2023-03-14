using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t--- Vererificar se o numero é impar ou par---\n");
            Console.Write("informe um numero:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("\nEste numero é par!");
            }
            else
            {
                Console.WriteLine("\nEste numero é impar!");
            }
            Console.ReadKey();
        }
    }
}
