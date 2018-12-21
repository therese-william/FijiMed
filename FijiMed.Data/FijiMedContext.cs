using FijiMed.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FijiMed.Data
{
    public class FijiMedContext : DbContext
    {
        public FijiMedContext(DbContextOptions<FijiMedContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicineType> MedicineTypes { get; set; }
        public DbSet<PatientAlergy> PatientAlergies { get; set; }
        public DbSet<PatientNote> PatientNotes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Script> Scripts { get; set; }
        public DbSet<ScriptWarningDetail> ScriptWarningDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Visit> Visits { get; set; }

    }
}
