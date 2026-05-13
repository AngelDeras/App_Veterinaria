using AppVeterinaria.Animals;

namespace AppVeterinaria
{
    public partial class RegisterPetForm : Form
    {
        List<Animal> animals = new List<Animal>();
        public RegisterPetForm()
        {
            InitializeComponent();

            // Setup and fill pet property combo box
            cmbPetType.SelectedIndex = 0;
            FillCmb();
        }



        private void FillCmb()
        {
            cmbPetProperties.SelectedIndex = -1;

            string[] dogBreeds = { "San Bernardo", "Pitbull", "Chihuahua" };
            string[] catColors = { "Blanco", "Naranja", "Negro" };
            string[] ferretTypes = { "Albino", "Sable", "Canela" };
            string[] hamsterTypes = { "Sirio", "Ruso", "Chino" };

            cmbPetProperties.Items.Clear();

            switch (cmbPetType.Text)
            {
                case "Perro":
                    lblPetProperty.Text = "Raza";
                    cmbPetProperties.Items.AddRange(dogBreeds);
                    break;
                case "Gato":
                    lblPetProperty.Text = "Color";
                    cmbPetProperties.Items.AddRange(catColors);
                    break;
                case "Huron":
                    lblPetProperty.Text = "Tipo";
                    cmbPetProperties.Items.AddRange(ferretTypes);
                    break;
                case "Hamster":
                    lblPetProperty.Text = "Tipo";
                    cmbPetProperties.Items.AddRange(hamsterTypes);
                    break;
            }
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            Animal? animal = null;
            switch (cmbPetType.Text)
            {
                case "Perro":
                    animal = new Dog(txtName.Text, int.Parse(txtAge.Text), double.Parse(txtWeight.Text), cmbPetProperties.Text);
                    animals.Add(animal);
                    break;
                case "Gato":
                    animal = new Cat(txtName.Text, int.Parse(txtAge.Text), double.Parse(txtWeight.Text), cmbPetProperties.Text);
                    animals.Add(animal);
                    break;
                case "Huron":
                    animal = new Ferret(txtName.Text, int.Parse(txtAge.Text), double.Parse(txtWeight.Text), cmbPetProperties.Text);
                    animals.Add(animal);
                    break;
                case "Hamster":
                    animal = new Hamster(txtName.Text, int.Parse(txtAge.Text), double.Parse(txtWeight.Text), cmbPetProperties.Text);
                    animals.Add(animal);
                    break;
                default: throw new Exception("Tipo de mascota no encontrada.");
            }

            string wtfPetProperty;

            switch (animal.PetType)
            {
                case "Perro":
                    wtfPetProperty = "Raza"; break;
                case "Gato":
                    wtfPetProperty = "Color"; break;
                default:
                    wtfPetProperty = "Tipo"; break;
            }

            string isLaOrEl = wtfPetProperty == "Raza" ? "La" : "El";
            string petType = animal.PetType.ToLower();
            string yearPluralFormatter = animal.Age == 1 ? "año" : "años";

            lsbTicket.Items.Clear();
            lsbTicket.Items.Add("TICKET");
            lsbTicket.Items.Add($"El nombre del {petType} es: {animal.Name}");
            lsbTicket.Items.Add($"La edad del {petType} es de {animal.Age} {yearPluralFormatter}");
            lsbTicket.Items.Add($"El peso es de: {animal.Weight} gr");
            lsbTicket.Items.Add($"{isLaOrEl} {wtfPetProperty.ToLower()} del {petType} es: {animal.SpecificProperty}");

            decimal total = 0;

            if (ckbConsultation.Checked)
            {
                total += animal.ConsultationCost();
                lsbTicket.Items.Add($"Costo consulta: {animal.ConsultationCost():C2}");
            }
            if (ckbVaccination.Checked)
            {
                total += animal.VaccinationCost();
                lsbTicket.Items.Add($"Costo vacunacion: {animal.VaccinationCost():C2}");
            }
            if (ckbSterilization.Checked)
            {
                total += animal.SterilizationCost();
                lsbTicket.Items.Add($"Costo esterilizacion: {animal.SterilizationCost():C2}");
            }

            animal.Total = total;
            lsbTicket.Items.Add($"El total es: {animal.Total:C2}");
        }

        private void cmbPetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCmb();
        }
    }
}
