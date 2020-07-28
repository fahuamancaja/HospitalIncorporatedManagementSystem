namespace MedicalManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class AddPatient
    {
        public string Name { get; set; }

        public string FullAddress { get; set; }

        public long? Contact { get; set; }

        public int? Age { get; set; }

        public string Gender { get; set; }

        public string BloodGroup { get; set; }

        public string MajorDisease { get; set; }

        public long pid { get; set; }
    }
}
