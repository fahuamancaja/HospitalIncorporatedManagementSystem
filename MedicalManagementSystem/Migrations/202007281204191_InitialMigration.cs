namespace MedicalManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddPatients",
                c => new
                    {
                        pid = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150, unicode: false),
                        FullAddress = c.String(maxLength: 300, unicode: false),
                        Contact = c.Long(),
                        Age = c.Int(),
                        Gender = c.String(maxLength: 10, unicode: false),
                        BloodGroup = c.String(maxLength: 20, unicode: false),
                        MajorDisease = c.String(maxLength: 400, unicode: false),
                    })
                .PrimaryKey(t => t.pid);
            
            CreateTable(
                "dbo.PatientMores",
                c => new
                    {
                        pid = c.Int(nullable: false, identity: true),
                        Symptom = c.String(maxLength: 150),
                        Diagnosis = c.String(maxLength: 150),
                        Medicine = c.String(maxLength: 150),
                        Ward = c.String(maxLength: 15),
                        WardType = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.pid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientMores");
            DropTable("dbo.AddPatients");
        }
    }
}
