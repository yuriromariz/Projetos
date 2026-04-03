using System;
using Aula01.Models;

namespace Aula01
{
    public class PharmacyStaff
    {
        public static void Main()
        {
            PharmacyAssistant assistant1 = new() 
            {
                 Name = "Yuri", 
                 Age = 31, 
                 YearsOfExperience = 11 
            };
            assistant1.DisplayInfo();

            PharmacyAssistant assistant2 = new() 
            {
                 Name = "Air Fryer", 
                 Age = 12, 
                 YearsOfExperience = 1 
            };
            assistant2.DisplayInfo();

            PharmacyAssistant assistant3 = new() 
            {
                 Name = "Pedrinho", 
                 Age = 24, 
                 YearsOfExperience = 3 
            };
            assistant3.DisplayInfo();

            PharmacyAssistant assistant4 = new() 
            {
                 Name = "Alan", 
                 Age = 32, 
                 YearsOfExperience = 11 
            };
            assistant4.DisplayInfo();

            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Data atual: {currentDate:g}");
        }
    }
}