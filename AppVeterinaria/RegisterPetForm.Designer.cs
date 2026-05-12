namespace AppVeterinaria
{
    partial class RegisterPetForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbGeneralData = new GroupBox();
            cmbPetType = new ComboBox();
            lblPetType = new Label();
            txtWeight = new TextBox();
            lblWeight = new Label();
            lblAge = new Label();
            txtAge = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            cmbPetProperties = new ComboBox();
            lblPetProperty = new Label();
            btnRegister = new Button();
            dgvAnimals = new DataGridView();
            btnPrintTicket = new Button();
            gbGeneralData.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // gbGeneralData
            // 
            gbGeneralData.BackColor = SystemColors.Info;
            gbGeneralData.Controls.Add(cmbPetType);
            gbGeneralData.Controls.Add(lblPetType);
            gbGeneralData.Controls.Add(txtWeight);
            gbGeneralData.Controls.Add(lblWeight);
            gbGeneralData.Controls.Add(lblAge);
            gbGeneralData.Controls.Add(txtAge);
            gbGeneralData.Controls.Add(lblName);
            gbGeneralData.Controls.Add(txtName);
            gbGeneralData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbGeneralData.Location = new Point(12, 12);
            gbGeneralData.Name = "gbGeneralData";
            gbGeneralData.Size = new Size(186, 211);
            gbGeneralData.TabIndex = 0;
            gbGeneralData.TabStop = false;
            gbGeneralData.Text = "Datos generales";
            // 
            // cmbPetType
            // 
            cmbPetType.Font = new Font("Segoe UI", 9F);
            cmbPetType.FormattingEnabled = true;
            cmbPetType.Items.AddRange(new object[] { "Perro", "Gato", "Huron", "Hamster" });
            cmbPetType.Location = new Point(6, 169);
            cmbPetType.Name = "cmbPetType";
            cmbPetType.Size = new Size(121, 23);
            cmbPetType.TabIndex = 1;
            cmbPetType.SelectedIndexChanged += cmbPetType_SelectedIndexChanged;
            // 
            // lblPetType
            // 
            lblPetType.AutoSize = true;
            lblPetType.Font = new Font("Segoe UI", 9F);
            lblPetType.Location = new Point(7, 151);
            lblPetType.Name = "lblPetType";
            lblPetType.Size = new Size(78, 15);
            lblPetType.TabIndex = 6;
            lblPetType.Text = "Tipo mascota";
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Segoe UI", 9F);
            txtWeight.Location = new Point(6, 125);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 5;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 9F);
            lblWeight.Location = new Point(6, 107);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(32, 15);
            lblWeight.TabIndex = 4;
            lblWeight.Text = "Peso";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F);
            lblAge.Location = new Point(6, 63);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(33, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Edad";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9F);
            txtAge.Location = new Point(6, 81);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.Location = new Point(6, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.Location = new Point(6, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(cmbPetProperties);
            groupBox1.Controls.Add(lblPetProperty);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(204, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 78);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos especificos";
            // 
            // cmbPetProperties
            // 
            cmbPetProperties.Font = new Font("Segoe UI", 9F);
            cmbPetProperties.FormattingEnabled = true;
            cmbPetProperties.Location = new Point(5, 37);
            cmbPetProperties.Name = "cmbPetProperties";
            cmbPetProperties.Size = new Size(121, 23);
            cmbPetProperties.TabIndex = 1;
            // 
            // lblPetProperty
            // 
            lblPetProperty.AutoSize = true;
            lblPetProperty.Font = new Font("Segoe UI", 9F);
            lblPetProperty.Location = new Point(6, 19);
            lblPetProperty.Name = "lblPetProperty";
            lblPetProperty.Size = new Size(16, 15);
            lblPetProperty.TabIndex = 6;
            lblPetProperty.Text = "...";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.MenuHighlight;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(12, 229);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(106, 43);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.BackgroundColor = Color.LightSteelBlue;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(396, 12);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.Size = new Size(483, 211);
            dgvAnimals.TabIndex = 9;
            // 
            // btnPrintTicket
            // 
            btnPrintTicket.BackColor = SystemColors.GradientActiveCaption;
            btnPrintTicket.FlatStyle = FlatStyle.Flat;
            btnPrintTicket.Location = new Point(396, 229);
            btnPrintTicket.Name = "btnPrintTicket";
            btnPrintTicket.Size = new Size(109, 26);
            btnPrintTicket.TabIndex = 10;
            btnPrintTicket.Text = "Imprimir ticket";
            btnPrintTicket.UseVisualStyleBackColor = false;
            btnPrintTicket.Click += btnPrintTicket_Click;
            // 
            // RegisterPetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(891, 284);
            Controls.Add(btnPrintTicket);
            Controls.Add(dgvAnimals);
            Controls.Add(btnRegister);
            Controls.Add(groupBox1);
            Controls.Add(gbGeneralData);
            Name = "RegisterPetForm";
            Text = "Registro de mascotas";
            gbGeneralData.ResumeLayout(false);
            gbGeneralData.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbGeneralData;
        private ComboBox cmbPetType;
        private Label lblPetType;
        private TextBox txtWeight;
        private Label lblWeight;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblName;
        private TextBox txtName;
        private GroupBox groupBox1;
        private ComboBox cmbPetProperties;
        private Label lblPetProperty;
        private Button btnRegister;
        private DataGridView dgvAnimals;
        private Button btnPrintTicket;
    }
}
