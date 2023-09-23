using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEFApp.Models
{
    public class Appointment
    {
        [Key]
        [Column("Appointmentno")]
        public int Id { get; set; }
        [Required]
        public int DoctorId { get; set; }
        [Required]
        public DateTime DateOfAppointment { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
