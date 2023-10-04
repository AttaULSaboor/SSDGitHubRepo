using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Employer
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public string Website { get; set; }

        [Display(Name = "Incorporated Date")]
        [DataType(DataType.Date)]
        public DateTime? IncorporatedDate { get; set; }
    }
}
