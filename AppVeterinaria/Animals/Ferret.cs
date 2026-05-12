using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeterinaria.Animals
{
    internal class Ferret : Animal
    {
        public Ferret(string name, int age, double weight, string type)
        {
            PetType = "Huron";
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
            return (decimal)(Weight / 0.05);
        }

        public override decimal VaccinationCost()
        {
            switch (Type)
            {
                case "Albino": return 400m;
                case "Sable": return 100m;
                case "Canela": return 80m;
                default: return 0;
            }
        }
    }
}
