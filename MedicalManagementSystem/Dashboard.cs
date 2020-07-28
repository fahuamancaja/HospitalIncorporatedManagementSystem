using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using System.Xml;
using MedicalManagementSystem.Migrations;

namespace MedicalManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            lblAddPatient.ForeColor = Color.LightPink;
            lblAddDiagnosisInformation.ForeColor = Color.Black;
            lblPatientHistory.ForeColor = Color.Black;
            lblHospitalInformation.ForeColor = Color.Black;
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();

        }

        private void btnAddDiagnosisInformation_Click(object sender, EventArgs e)
        {
            lblAddPatient.ForeColor = Color.Black;
            lblAddDiagnosisInformation.ForeColor = Color.LightPink;
            lblPatientHistory.ForeColor = Color.Black;
            lblHospitalInformation.ForeColor = Color.Black;
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            panel4.Hide();



        }

        private void btnPatientHistory_Click(object sender, EventArgs e)
        {
            lblAddPatient.ForeColor = Color.Black;
            lblAddDiagnosisInformation.ForeColor = Color.Black;
            lblPatientHistory.ForeColor = Color.LightPink;
            lblHospitalInformation.ForeColor = Color.Black;
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel4.Hide();


            var context = new HospitalContext();
            var query = context.AddPatients.Join(context.PatientMores,
                c => c.pid,
                a => a.pid,
                (patient, more) => new
                {
                    PatientName = patient.Name,
                    FullAddress = patient.FullAddress,
                    ContactInfo = patient.Contact,
                    Age = patient.Age,
                    Gender = patient.Gender,
                    Blood = patient.BloodGroup,
                    MajorDisease = patient.MajorDisease,
                    SymptomName = more.Symptom,
                    Diagnosis = more.Diagnosis,
                    Medicine = more.Medicine,
                    Ward = more.Ward,
                    WardType = more.WardType
                });
            var list = new List<object>();

            foreach (var obj in query)
            {
                list.Add(obj);
            }

            dataGridView2.DataSource = list;

            //var column = new List<string>();


            //foreach (var obj in query)
            //{
            //    Console.WriteLine("{0} - {1}", obj.Age, obj.StandardName);
            //}

            //dataGridView2.DataSource = GetAllPeople(query);

            //var con = new SqlConnection();
            //con.ConnectionString = "data source = .\\SQLEXPRESS; database = Hospital; integrated security = True";

            //var cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "select * from AddPatients inner join PatientMores on AddPatients.pid = PatientMores.pid";
            //var dataAdapter = new SqlDataAdapter(cmd);
            //var dataSet = new DataSet();
            //dataAdapter.Fill(dataSet);

            //dataGridView2.DataSource = dataSet.Tables[0];

        }


        private void btnHospitalInformation_Click(object sender, EventArgs e)
        {
            lblAddPatient.ForeColor = Color.Black;
            lblAddDiagnosisInformation.ForeColor = Color.Black;
            lblPatientHistory.ForeColor = Color.Black;
            lblHospitalInformation.ForeColor = Color.LightPink;

            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.PatientMores' table. You can move, or remove it, as needed.
            this.patientMoresTableAdapter.Fill(this.hospitalDataSet.PatientMores);
            // TODO: This line of code loads data into the 'hospitalDataSet.AddPatients' table. You can move, or remove it, as needed.
            this.addPatientsTableAdapter.Fill(this.hospitalDataSet.AddPatients);
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var address = txtAddress.Text;
            var contactNumber = Convert.ToInt64(txtContactNumber.Text);
            var age = Convert.ToInt32(txtAge.Text);
            var gender = cmbGender.Text;
            var blood = txtBloodGroup.Text;
            var majorDisease = txtMajorDisease.Text;
            var pid = Convert.ToInt32(txtPatiendID.Text);

            var addPatient = new TryAddPatient(name, address, contactNumber, age, gender, blood, majorDisease, pid);

            PatientInformationClear();
        }
        public void PatientInformationClear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtContactNumber.Clear();
            txtAge.Clear();
            cmbGender.ResetText();
            txtBloodGroup.Clear();
            txtMajorDisease.Clear();
            txtPatiendID.Clear();

        }

        public void PatientMoreInformationClear()
        {
            textBox1.Clear();
            txtSymptoms.Clear();
            txtDiagnosis.Clear();
            txtMedicine.Clear();
            cmbWard.ResetText();
            cmbTypeOfWard.ResetText();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                int patiendID = Convert.ToInt32(textBox1.Text);

                //var con = new SqlConnection();
                //con.ConnectionString = "data source = .\\SQLEXPRESS; database = Hospital; integrated security = True";

                //var cmd = new SqlCommand(){
                //    Connection =  con, 
                //    CommandText = "select * from AddPatients where pid = " + pid + ""
                //};

                //////cmd.Connection = con;
                //////cmd.CommandText = "select * from AddPatients where pid = " + pid + "";
                //var dataAdapter = new SqlDataAdapter(cmd);
                //var dataSet = new DataSet();
                //dataAdapter.Fill(dataSet);
                //dataGridView1.DataSource = dataSet.Tables[0];

                var context = new HospitalContext();

                var query = context.AddPatients.SingleOrDefault(c => c.pid == patiendID);

                if (query != null)
                {
                    dataGridView1.DataSource = GetPeople(query);
                }
                else
                {
                    dataGridView1.DataSource = null;
                }


            }




        }

        private List<AddPatient> GetPeople(AddPatient query)
        {
            var list = new List<AddPatient>();

            list.Add(new AddPatient()
            {
                pid = query.pid,
                Name = query.Name,
                FullAddress = query.FullAddress,
                Contact = query.Contact,
                Age = query.Age,
                Gender = query.Gender,
                BloodGroup =  query.BloodGroup,
                MajorDisease = query.MajorDisease

            });


            return list;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var patientId = Convert.ToInt32(textBox1.Text);
            var symptom = txtSymptoms.Text;
            var diagnosis = txtDiagnosis.Text;
            var medicine = txtMedicine.Text;
            var ward = cmbWard.Text;
            var typeOfWard = cmbTypeOfWard.Text;

            var addPatient = new TryPatientMore(patientId, symptom, diagnosis, medicine, ward, typeOfWard);

            PatientMoreInformationClear();
        }
    }
}

