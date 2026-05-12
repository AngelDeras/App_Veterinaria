using AppVeterinaria.Animals;

namespace AppVeterinaria
{
    public partial class RegisterPetForm : Form
    {
        List<Animal> animals = new List<Animal>();
        public RegisterPetForm()
        {
            InitializeComponent();
            SetupDgv();

            // Setup and fill pet property combo box
            cmbPetType.SelectedIndex = 0;
            FillCmb();
        }

        private void SetupDgv()
        {
            dgvAnimals.ColumnCount = 8;
            dgvAnimals.Columns[0].Name = "Nombre";
            dgvAnimals.Columns[1].Name = "Edad";
            dgvAnimals.Columns[2].Name = "Peso";
            dgvAnimals.Columns[3].Name = "Tipo mascota";
            dgvAnimals.Columns[4].Name = "Propiedad especifica";
            dgvAnimals.Columns[5].Name = "Costo esterilizacion";
            dgvAnimals.Columns[6].Name = "Costo vacunacion";
            dgvAnimals.Columns[7].Name = "Costo cita";
        }

        private void FillDgv()
        {
            dgvAnimals.Rows.Clear();
            foreach (Animal animal in animals)
            {
                dgvAnimals.Rows.Add(
                    animal.Name,
                    animal.Age,
                    animal.Weight,
                    animal.PetType,
                    animal.SpecificProperty,
                    animal.SterilizationCost().ToString("C2"),
                    animal.VaccinationCost().ToString("C2"),
                    animal.ConsultationCost().ToString("C2")
                    );
            }
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            switch (cmbPetType.Text)
            {
                case "Perro":
                    Animal dog = new Dog(txtName.Text, int.Parse(txtAge.Text), double.Parse(txtWeight.Text), cmbPetProperties.Text);
                    animals.Add(dog);
                    break;
                case "Gato":
                    Animal cat = new Cat(txtName.Text, int.Parse(txtAge.Text), double.Parse(txtWeight.Text), cmbPetProperties.Text);
                    animals.Add(cat);
                    break;
                case "Huron":
                    Animal ferret = new Ferret(txtName.Text, int.Parse(txtAge.Text), double.Parse(txtWeight.Text), cmbPetProperties.Text);
                    animals.Add(ferret);
                    break;
                case "Hamster":
                    Animal hamster = new Hamster(txtName.Text, int.Parse(txtAge.Text), double.Parse(txtWeight.Text), cmbPetProperties.Text);
                    animals.Add(hamster);
                    break;
                default: throw new Exception("Tipo de mascota no encontrada.");
            }
            FillDgv();
        }

        private void cmbPetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCmb();
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Show();
        }
    }
}
