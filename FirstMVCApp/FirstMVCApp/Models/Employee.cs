using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace FirstMVCApp.Models
{
    public class Employee
    {
       
        [Key]
        [Required]
        public int eno { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name Must be Between 3 and 20 chars")]
        public string name { get; set; }
        [Required]
        public string city { get; set; } = string.Empty;

        public decimal salary
        {
            get; set;
                }
      

    }
}
