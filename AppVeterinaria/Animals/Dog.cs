using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeterinaria.Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, int age, double weight, string breed)
        {
            PetType = "Perro";
            Name = name;
            Age = age;
            Weight = weight;
            Breed = breed;
            SpecificProperty = Breed;
        }
        public string Breed { get; set; }
        public override decimal ConsultationCost()
        {
            return 100m;
        }

        public override decimal SterilizationCost()
        {
            return (decimal)(Weight / 0.05);
        }

        public override decimal VaccinationCost()
        {
            switch (Breed)
            {
                case "San Bernardo": return 500m;
                case "Pitbull": return 300m;
                case "Chihuahua": return 150m;
                default: return 0;
            }
        }
    }
}
