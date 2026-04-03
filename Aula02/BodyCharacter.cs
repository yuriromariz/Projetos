using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BodyCharacter.Models
{
    public class BodyCharacter
    {
        public string helmet { get; set; } 
        public string armor { get; set; }
        public string boots { get; set; }
        public string gloves { get; set; }

        public void ShowEquipment()
        {
            Console.WriteLine($"Equipamento do personagem:\n- Capacete: {helmet}\n- Armadura: {armor}\n- Botas: {boots}\n- Luvas: {gloves}");
        }
    }
}