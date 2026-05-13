using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeterinaria.Animals
{
    internal class Hamster : Animal
    {
        public Hamster(string name, int age, double weight, string type)
        {
            PetType = "Hamster";
            Name = name;
            Age = age;
            Weight = weight;
            Type = type;
            SpecificProperty = Type;
        }

        public string Type { get; set; }

        public override decimal ConsultationCost()
        {
            return 250m;
        }

        public override decimal SterilizationCost()
        {
            return (decimal)(Weight * 0.05);
        }

        public override decimal VaccinationCost()
        {
            switch (Type)
            {
                case "Sirio": return 450m;
                case "Ruso": return 150m;
                case "Chino": return 90m;
                default: return 0;
            }
        }
    }
}
