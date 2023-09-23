using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MVCEFApp.Models;

namespace MVCEFApp.Models
{
    public class HospitalDbContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }    
        public DbSet<Appointment> Appointments { get; set; }
        public object Patient { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            

            String conString = @"server=200411LTP2869\SQLEXPRESS;database=HospitaDB;integrated security=true;Encrypt=false;";

            options.UseSqlServer(conString);
        }
    }
}
