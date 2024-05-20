using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MidTerm.Models;

namespace MidTerm.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Veterinarian> Veterinarians { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 1, Name = "Bella", Species = "Dog", Breed = "Labrador Retriever", Age = 4, Medications = "Heartworm prevention", MedicalHistory = "None", ImageUrl = "https://images.pexels.com/photos/16234651/pexels-photo-16234651/free-photo-of-close-up-of-a-labrador-retriever.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                new Patient { Id = 2, Name = "Max", Species = "Cat", Breed = "Siamese", Age = 3, Medications = "Flea prevention", MedicalHistory = "UTI Last Year", ImageUrl = "https://images.pexels.com/photos/596590/pexels-photo-596590.jpeg" },
                new Patient { Id = 3, Name = "Daisy", Species = "Dog", Breed = "Beagle", Age = 5, Medications = "Joint supplements", MedicalHistory = "Minor hip dysplasia", ImageUrl = "https://images.pexels.com/photos/6566630/pexels-photo-6566630.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                new Patient { Id = 4, Name = "Oliver", Species = "Cat", Breed = "Maine Coon", Age = 2, Medications = "None", MedicalHistory = "Allergies", ImageUrl = "https://images.pexels.com/photos/17006168/pexels-photo-17006168/free-photo-of-close-up-of-maine-coon.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                new Patient { Id = 5, Name = "Charlie", Species = "Dog", Breed = "German Shepherd", Age = 6, Medications = "Anti-inflammatory medication", MedicalHistory = "Arthritis", ImageUrl = "https://images.pexels.com/photos/351406/pexels-photo-351406.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" }
                );
            modelBuilder.Entity<Veterinarian>().HasData(
                new Veterinarian { Id = 1, Name = "Dr. Sarah Johnson", YearsOfExperience = 12, Bio = "Dr. Sarah Johnson specializes in small animal surgery and has a passion for helping pets recover from injuries. She graduated from the University of California, Davis, and has been working in a busy urban clinic for over a decade. Dr. Johnson is known for her gentle approach and dedication to animal welfare.", ImageUrl = "https://media.istockphoto.com/id/1303362255/photo/young-happy-veterinary-nurse-smiling-while-playing-with-a-dog-high-quality-photo.jpg?s=612x612&w=0&k=20&c=_kIKIzB4GF5WDLCf2yK1XMQk9JtxoL9XPK_nJmTZ5JQ=" },
                new Veterinarian { Id = 2, Name = "Dr. Michael Lee", YearsOfExperience = 8, Bio = "Dr. Michael Lee is an expert in veterinary cardiology and internal medicine. After completing his veterinary degree at Cornell University, he pursued further training in cardiac care for animals. Dr. Lee works at a renowned veterinary hospital and is committed to advancing heart health in pets through innovative treatments and research.", ImageUrl = "https://st2.depositphotos.com/3662505/6397/i/950/depositphotos_63976241-stock-photo-veterinarian.jpg" },
                new Veterinarian { Id = 3, Name = "Dr. Emily Rodriguez", YearsOfExperience = 15, Bio = "Dr. Emily Rodriguez has a wealth of experience in exotic animal care, having worked with a variety of species including reptiles, birds, and small mammals. She earned her degree from the University of Florida and has since dedicated her career to the care and conservation of exotic animals. Dr. Rodriguez frequently volunteers at wildlife rescue centers and is a respected voice in the field of exotic animal medicine.", ImageUrl = "https://st.depositphotos.com/1518767/4292/i/600/depositphotos_42928519-stock-photo-veterinarian-examining-dog.jpg" }
                );
        }
    }
}
///OpenAI. (2024). ChatGPT (May 13th version) [Large language model]. https://chat.openai.com
///Image Citations: 
///IslandHopper X. (2023, April 4). Close up of a labrador retriever. Pexels. Retrieved May 20, 2024, from https://www.pexels.com/photo/close-up-of-a-labrador-retriever-16234651/
///Newhouse, L. (2017, September 28). Siamese Cat. Pexels. Retrieved May 20, 2024, from https://www.pexels.com/photo/siamese-cat-596590/
///Ласаева, Г. (2021, January 22). Close-up Photo of a Beagle. Pexels. Retrieved May 20, 2024, from https://www.pexels.com/photo/close-up-photo-of-a-beagle-6566630/
///Kutsaiev, R. (2023, May 28). Close up of Maine Coon. Pexels. Retrieved May 20, 2024, from https://www.pexels.com/photo/close-up-of-maine-coon-17006168/
///Tsankov, V. (2017, March 15). Short-coated Beige and Brown Dog. Pexes. Retrieved May 20, 2024, from https://www.pexels.com/photo/short-coated-beige-and-brown-dog-351406/
///Herraez. (2021, April 5). Young happy veterinary nurse smiling while playing with a dog. High. . . iStock. https://www.istockphoto.com/photo/young-happy-veterinary-nurse-smiling-while-playing-with-a-dog-high-quality-photo-gm1303362255-394839617
///Veterinarian. (n.d.). Depositphotos. https://depositphotos.com/photo/veterinarian-63976241.html
///VeT Stock Photos, Royalty free VET Images | DepositPhotos. (n.d.). Depositphotos. https://depositphotos.com/photos/vet.html?qview=42928519
