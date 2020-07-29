namespace MedicalManagementSystem
{
    using System.Data.Entity;

    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
            : base("name=HospitalContext1")
        {
        }

        public virtual DbSet<AddPatient> AddPatients { get; set; }
        public virtual DbSet<PatientMore> PatientMores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adding Patient Initial Information
            modelBuilder.Entity<AddPatient>()
                .Property(e => e.Name)
                .IsUnicode(false)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<AddPatient>()
                .Property(e => e.FullAddress)
                .HasMaxLength(300)
                .IsUnicode(false);

            modelBuilder.Entity<AddPatient>()
                .Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);

            modelBuilder.Entity<AddPatient>()
                .Property(e => e.BloodGroup)
                .HasMaxLength(20)
                .IsUnicode(false);

            modelBuilder.Entity<AddPatient>()
                .Property(e => e.MajorDisease)
                .HasMaxLength(400)
                .IsUnicode(false);

            modelBuilder.Entity<AddPatient>()
                .HasKey(e => e.pid)
                .Property(e => e.pid)
                .IsRequired();
                

            //Adding More Patient Info
            modelBuilder.Entity<PatientMore>()
                .HasKey(e => e.pid)
                .Property(e => e.pid)
                .IsRequired();

            modelBuilder.Entity<PatientMore>()
                .Property(e => e.Symptom)
                .HasMaxLength(150);

            modelBuilder.Entity<PatientMore>()
                .Property(e => e.Diagnosis)
                .HasMaxLength(150);

            modelBuilder.Entity<PatientMore>()
                .Property(e => e.Medicine)
                .HasMaxLength(150);

            modelBuilder.Entity<PatientMore>()
                .Property(e => e.Ward)
                .HasMaxLength(15);

            modelBuilder.Entity<PatientMore>()
                .Property(e => e.WardType)
                .HasMaxLength(20);

            base.OnModelCreating(modelBuilder);
        }
    }
}
