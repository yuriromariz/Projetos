using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudosLacos.Models
{
    public class Tabuada
    {
        public int NumeroTabuada { get; set; }

        public void MostraTabuada()

        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{NumeroTabuada} X {i} = {NumeroTabuada * i}");
            }
        }

    }
}