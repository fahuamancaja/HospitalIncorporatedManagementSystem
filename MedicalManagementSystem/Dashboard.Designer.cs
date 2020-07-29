namespace MedicalManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddDiagnosisInformation = new System.Windows.Forms.Button();
            this.btnPatientHistory = new System.Windows.Forms.Button();
            this.btnHospitalInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAddPatient = new System.Windows.Forms.Label();
            this.lblAddDiagnosisInformation = new System.Windows.Forms.Label();
            this.lblPatientHistory = new System.Windows.Forms.Label();
            this.lblHospitalInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPatiendID = new System.Windows.Forms.TextBox();
            this.txtMajorDisease = new System.Windows.Forms.TextBox();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbTypeOfWard = new System.Windows.Forms.ComboBox();
            this.cmbWard = new System.Windows.Forms.ComboBox();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.hospitalDataSet = new MedicalManagementSystem.HospitalDataSet();
            this.addPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPatientsTableAdapter = new MedicalManagementSystem.HospitalDataSetTableAdapters.AddPatientsTableAdapter();
            this.patientMoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientMoresTableAdapter = new MedicalManagementSystem.HospitalDataSetTableAdapters.PatientMoresTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMoresBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPatient.Location = new System.Drawing.Point(40, 98);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(183, 43);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Add New Patient Record";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAddDiagnosisInformation
            // 
            this.btnAddDiagnosisInformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddDiagnosisInformation.Location = new System.Drawing.Point(40, 146);
            this.btnAddDiagnosisInformation.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDiagnosisInformation.Name = "btnAddDiagnosisInformation";
            this.btnAddDiagnosisInformation.Size = new System.Drawing.Size(183, 43);
            this.btnAddDiagnosisInformation.TabIndex = 2;
            this.btnAddDiagnosisInformation.Text = "Add Diagnosis Information";
            this.btnAddDiagnosisInformation.UseVisualStyleBackColor = false;
            this.btnAddDiagnosisInformation.Click += new System.EventHandler(this.btnAddDiagnosisInformation_Click);
            // 
            // btnPatientHistory
            // 
            this.btnPatientHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatientHistory.Location = new System.Drawing.Point(40, 194);
            this.btnPatientHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatientHistory.Name = "btnPatientHistory";
            this.btnPatientHistory.Size = new System.Drawing.Size(183, 43);
            this.btnPatientHistory.TabIndex = 3;
            this.btnPatientHistory.Text = "Full History of Patient";
            this.btnPatientHistory.UseVisualStyleBackColor = false;
            this.btnPatientHistory.Click += new System.EventHandler(this.btnPatientHistory_Click);
            // 
            // btnHospitalInformation
            // 
            this.btnHospitalInformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHospitalInformation.Location = new System.Drawing.Point(40, 242);
            this.btnHospitalInformation.Margin = new System.Windows.Forms.Padding(2);
            this.btnHospitalInformation.Name = "btnHospitalInformation";
            this.btnHospitalInformation.Size = new System.Drawing.Size(183, 43);
            this.btnHospitalInformation.TabIndex = 4;
            this.btnHospitalInformation.Text = "Hospital Information";
            this.btnHospitalInformation.UseVisualStyleBackColor = false;
            this.btnHospitalInformation.Click += new System.EventHandler(this.btnHospitalInformation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONTROLLER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hospital Management System";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Thistle;
            this.btnExit.Location = new System.Drawing.Point(103, 290);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 22);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 326);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblAddPatient
            // 
            this.lblAddPatient.AutoSize = true;
            this.lblAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPatient.Location = new System.Drawing.Point(9, 102);
            this.lblAddPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddPatient.Name = "lblAddPatient";
            this.lblAddPatient.Size = new System.Drawing.Size(32, 36);
            this.lblAddPatient.TabIndex = 10;
            this.lblAddPatient.Text = "»";
            // 
            // lblAddDiagnosisInformation
            // 
            this.lblAddDiagnosisInformation.AutoSize = true;
            this.lblAddDiagnosisInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDiagnosisInformation.Location = new System.Drawing.Point(9, 150);
            this.lblAddDiagnosisInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddDiagnosisInformation.Name = "lblAddDiagnosisInformation";
            this.lblAddDiagnosisInformation.Size = new System.Drawing.Size(32, 36);
            this.lblAddDiagnosisInformation.TabIndex = 11;
            this.lblAddDiagnosisInformation.Text = "»";
            // 
            // lblPatientHistory
            // 
            this.lblPatientHistory.AutoSize = true;
            this.lblPatientHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientHistory.Location = new System.Drawing.Point(9, 198);
            this.lblPatientHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientHistory.Name = "lblPatientHistory";
            this.lblPatientHistory.Size = new System.Drawing.Size(32, 36);
            this.lblPatientHistory.TabIndex = 12;
            this.lblPatientHistory.Text = "»";
            // 
            // lblHospitalInformation
            // 
            this.lblHospitalInformation.AutoSize = true;
            this.lblHospitalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalInformation.Location = new System.Drawing.Point(9, 246);
            this.lblHospitalInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHospitalInformation.Name = "lblHospitalInformation";
            this.lblHospitalInformation.Size = new System.Drawing.Size(32, 36);
            this.lblHospitalInformation.TabIndex = 13;
            this.lblHospitalInformation.Text = "»";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.txtPatiendID);
            this.panel1.Controls.Add(this.txtMajorDisease);
            this.panel1.Controls.Add(this.txtBloodGroup);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(243, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 407);
            this.panel1.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(154, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "Add New Patien Record";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 336);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Patient ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Any Major Disease Suffered Earlier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Blood Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "N/A"});
            this.cmbGender.Location = new System.Drawing.Point(240, 212);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(312, 21);
            this.cmbGender.TabIndex = 7;
            // 
            // txtPatiendID
            // 
            this.txtPatiendID.Location = new System.Drawing.Point(27, 355);
            this.txtPatiendID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatiendID.Name = "txtPatiendID";
            this.txtPatiendID.Size = new System.Drawing.Size(436, 20);
            this.txtPatiendID.TabIndex = 6;
            // 
            // txtMajorDisease
            // 
            this.txtMajorDisease.Location = new System.Drawing.Point(27, 312);
            this.txtMajorDisease.Margin = new System.Windows.Forms.Padding(2);
            this.txtMajorDisease.Name = "txtMajorDisease";
            this.txtMajorDisease.Size = new System.Drawing.Size(525, 20);
            this.txtMajorDisease.TabIndex = 5;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(240, 245);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(2);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(312, 20);
            this.txtBloodGroup.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(240, 185);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(312, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(240, 156);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(312, 20);
            this.txtContactNumber.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(240, 127);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(312, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(240, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 20);
            this.txtName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cmbTypeOfWard);
            this.panel2.Controls.Add(this.cmbWard);
            this.panel2.Controls.Add(this.txtMedicine);
            this.panel2.Controls.Add(this.txtDiagnosis);
            this.panel2.Controls.Add(this.txtSymptoms);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(243, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 407);
            this.panel2.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(238, 262);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Type of Ward";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbTypeOfWard
            // 
            this.cmbTypeOfWard.FormattingEnabled = true;
            this.cmbTypeOfWard.Items.AddRange(new object[] {
            "General",
            "Duo",
            "Single"});
            this.cmbTypeOfWard.Location = new System.Drawing.Point(333, 258);
            this.cmbTypeOfWard.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTypeOfWard.Name = "cmbTypeOfWard";
            this.cmbTypeOfWard.Size = new System.Drawing.Size(92, 21);
            this.cmbTypeOfWard.TabIndex = 13;
            // 
            // cmbWard
            // 
            this.cmbWard.FormattingEnabled = true;
            this.cmbWard.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbWard.Location = new System.Drawing.Point(333, 210);
            this.cmbWard.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWard.Name = "cmbWard";
            this.cmbWard.Size = new System.Drawing.Size(92, 21);
            this.cmbWard.TabIndex = 12;
            // 
            // txtMedicine
            // 
            this.txtMedicine.Location = new System.Drawing.Point(131, 310);
            this.txtMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(76, 20);
            this.txtMedicine.TabIndex = 11;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(131, 262);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(76, 20);
            this.txtDiagnosis.TabIndex = 10;
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(131, 213);
            this.txtSymptoms.Margin = new System.Windows.Forms.Padding(2);
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(76, 20);
            this.txtSymptoms.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(238, 211);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Ward Required";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 314);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Medicines";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 264);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Diagnosis";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 217);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Symptoms";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 122);
            this.dataGridView1.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Patient Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(174, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Adding More Information About Patient";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(243, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 407);
            this.panel3.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(575, 355);
            this.dataGridView2.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(126, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(359, 32);
            this.label19.TabIndex = 0;
            this.label19.Text = "Full History of The Patient";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addPatientsBindingSource
            // 
            this.addPatientsBindingSource.DataMember = "AddPatients";
            this.addPatientsBindingSource.DataSource = this.hospitalDataSet;
            // 
            // addPatientsTableAdapter
            // 
            this.addPatientsTableAdapter.ClearBeforeFill = true;
            // 
            // patientMoresBindingSource
            // 
            this.patientMoresBindingSource.DataMember = "PatientMores";
            this.patientMoresBindingSource.DataSource = this.hospitalDataSet;
            // 
            // patientMoresTableAdapter
            // 
            this.patientMoresTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(243, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 407);
            this.panel4.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(154, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(316, 34);
            this.label20.TabIndex = 1;
            this.label20.Text = "Hospital Incorporated";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(576, 407);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(827, 427);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblHospitalInformation);
            this.Controls.Add(this.lblPatientHistory);
            this.Controls.Add(this.lblAddDiagnosisInformation);
            this.Controls.Add(this.lblAddPatient);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHospitalInformation);
            this.Controls.Add(this.btnPatientHistory);
            this.Controls.Add(this.btnAddDiagnosisInformation);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPatientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMoresBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddDiagnosisInformation;
        private System.Windows.Forms.Button btnPatientHistory;
        private System.Windows.Forms.Button btnHospitalInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAddPatient;
        private System.Windows.Forms.Label lblAddDiagnosisInformation;
        private System.Windows.Forms.Label lblPatientHistory;
        private System.Windows.Forms.Label lblHospitalInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtPatiendID;
        private System.Windows.Forms.TextBox txtMajorDisease;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbTypeOfWard;
        private System.Windows.Forms.ComboBox cmbWard;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView2;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource addPatientsBindingSource;
        private HospitalDataSetTableAdapters.AddPatientsTableAdapter addPatientsTableAdapter;
        private System.Windows.Forms.BindingSource patientMoresBindingSource;
        private HospitalDataSetTableAdapters.PatientMoresTableAdapter patientMoresTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label20;
    }
}