using System.ComponentModel.DataAnnotations;

namespace MidTerm.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Species { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Medications { get; set; }
        [Required]
        public string MedicalHistory { get; set; }
        [Required]
        [Url]
        public string ImageUrl { get; set; }

    }
}
