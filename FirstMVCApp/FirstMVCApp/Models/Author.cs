using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCApp.Models
{
    public class Author
    {
        //Author ID,  Author Name, Author Date of Birth, No of Books
        //Published,Royalty company.


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int Authorid { get; set; }
        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Name must have at least 3 chars")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "DateOfBirth is required.")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = " NoOfBooks is Required")]
        public int NoOfBooks { get; set; }
        [Required(ErrorMessage = "Royalty is Required")]
        public string Royalty { get; set; }
    }
}
