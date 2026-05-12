using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeterinaria.Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, int age, double weight, string color)
        {
            PetType = "Gato";
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            SpecificProperty = Color;
        }
        public string Color { get; set; }

        public override decimal ConsultationCost()
        {
            return 250m;
        }

        public override decimal SterilizationCost()
        {
            return (decimal)(Weight / 0.05);
        }

        public override decimal VaccinationCost()
        {
            switch (Color)
            {
                case "Blanco": return 800m;
                case "Naranja": return 500m;
                case "Negro": return 250m;
                default: return 0;
            }
        }
    }
}
