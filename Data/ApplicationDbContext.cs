using DoctorsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorsApp.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Doctor; Integrated Security=True;TrustServerCertificate=True");
        }
     
    }
}
