using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01.Models
{
    public class PharmacyAssistant
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public int YearsOfExperience { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Olá, meu nome é {Name}, tenho {Age} anos e " + 
                              $"{YearsOfExperience} anos de experiência como Auxiliar de Farmácia .");
            Console.WriteLine("--------------------------------------------------");  
        }
        
    }
}