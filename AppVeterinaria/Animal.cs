using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeterinaria
{
    public abstract class Animal
    {
        // Common properties
        public string PetType { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string SpecificProperty { get; set; }

        // Abstract methods
        public abstract decimal SterilizationCost();
        public abstract decimal VaccinationCost();
        public abstract decimal ConsultationCost();
    }
}
