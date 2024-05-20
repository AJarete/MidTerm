using System.ComponentModel.DataAnnotations;

namespace MidTerm.Models
{
    public class Veterinarian
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int YearsOfExperience { get; set; }
        [Required]
        public string Bio {  get; set; }
        [Required]
        [Url]
        public string ImageUrl { get; set; }

    }
}
