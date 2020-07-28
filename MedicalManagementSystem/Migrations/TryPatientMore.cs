using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementSystem.Migrations
{
    class TryPatientMore
    {
        public TryPatientMore(int patientId, string symptom, string diagnosis, string medicine, string ward,string wardType)
        {
            try
            {
                var context = new HospitalContext();

                var patient = new PatientMore()
                {
                    pid = patientId,
                    Symptom = symptom,
                    Diagnosis = diagnosis,
                    Medicine = medicine,
                    Ward = ward,
                    WardType = wardType,
                };
                context.PatientMores.Add(patient);
                context.SaveChanges();
                MessageBox.Show("Additional Patient Info Successfully added!");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {

                MessageBox.Show("User already Exists or Incorrect data Added");
            }

        }
    }
}
