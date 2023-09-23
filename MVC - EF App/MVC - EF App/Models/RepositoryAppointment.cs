using Microsoft.EntityFrameworkCore;
using MVCEFApp.Models;

namespace MVC___EF_App.Models
{
    public class RepositoryAppointment
    {
        public static List<Appointment> GetAppointment()
        {


            HospitalDbContext btx = new HospitalDbContext();
            var list = btx.Appointments.ToList();
            return list;

        }

        public static Appointment GetAppointmentById(int Id)
        {
            HospitalDbContext db = new HospitalDbContext();
            var appointment = db.Appointments.Find(Id);
            return appointment;
        }
        public static void AddNewAppointment(Appointment appointments)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Appointments.Add(appointments);
            ctx.SaveChanges();
        }
        public static void ModifyAppointment(Appointment appointments)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(appointments).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoveAppointment(int Id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var appointments = ctx.Appointments.Find(Id);
            ctx.Appointments.Remove(appointments);
            ctx.SaveChanges();

        }


    }
}

