using Microsoft.EntityFrameworkCore;
using MVCEFApp.Models;

namespace MVC___EF_App.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatient()
        {
            HospitalDbContext btx = new HospitalDbContext();
            var list = btx.Patients.ToList();
            return list;
        }
        public static Patient GetPatientById(int Id)
        {
            HospitalDbContext db = new HospitalDbContext();
            var patient = db.Patients.Find(Id);
            return patient;
        }
        public static void AddNewPatient(Patient patients)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Patients.Add(patients);
            ctx.SaveChanges();
        }
        public static void ModifyPaitient(Patient patients)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(patients).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemovePatient(int Id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Patient patients = ctx.Patients.Find(Id);
            ctx.Patients.Remove(patients);
            ctx.SaveChanges();

        }
    }
}
