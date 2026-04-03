using System;
using EstudosLacos.Models;

namespace EstudosLacos
{
    public class Program
    {
        public static void Main()
        {
            int c = -1;
            Tabuada t = new();
            while (c != 0)
            {
                Console.WriteLine("Digite um número para ver sua tabuada: ");
                c = Convert.ToInt32(Console.ReadLine());
                if (c != 0)
                {
                    t.NumeroTabuada = c;
                    t.MostraTabuada();
                }

            }
            Console.WriteLine("Encerrando Programa.");
        }
    }
}