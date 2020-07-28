using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementSystem
{
    class TryAddPatient
    {
        public TryAddPatient(string name, string address,long contactNumber,int age, string gender, string blood,string majorDisease,int pid)
        {
            try
            {
                var context = new HospitalContext();

                var patient = new AddPatient
                {
                    Name = name,
                    FullAddress = address,
                    Contact = contactNumber,
                    Age = age,
                    Gender = gender,
                    BloodGroup = blood,
                    MajorDisease = majorDisease,
                    pid = pid
                };
                context.AddPatients.Add(patient);
                context.SaveChanges();
                MessageBox.Show("Patient has been successfully Added!");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {

                MessageBox.Show("User already Exists or Incorrect data Added");
            }

        }
    }
}
