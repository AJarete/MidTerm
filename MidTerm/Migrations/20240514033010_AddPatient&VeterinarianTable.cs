using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MidTerm.Migrations
{
    /// <inheritdoc />
    public partial class AddPatientVeterinarianTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Medications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veterinarians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarians", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "Breed", "ImageUrl", "MedicalHistory", "Medications", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 4, "Labrador Retriever", "None", "None", "Heartworm prevention", "Bella", "Dog" },
                    { 2, 3, "Siamese", "None", "UTI Last Year", "Flea prevention", "Max", "Cat" },
                    { 3, 5, "Beagle", "None", "Minor hip dysplasia", "Joint supplements", "Daisy", "Dog" },
                    { 4, 2, "Maine Coon", "None", "Allergies", "None", "Oliver", "Cat" },
                    { 5, 6, "German Shepherd", "None", "Arthritis", "Anti-inflammatory medication", "Charlie", "Dog" }
                });

            migrationBuilder.InsertData(
                table: "Veterinarians",
                columns: new[] { "Id", "Bio", "ImageUrl", "Name", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "Dr. Sarah Johnson specializes in small animal surgery and has a passion for helping pets recover from injuries. She graduated from the University of California, Davis, and has been working in a busy urban clinic for over a decade. Dr. Johnson is known for her gentle approach and dedication to animal welfare.", "None", "Dr. Sarah Johnson", 12 },
                    { 2, "Dr. Michael Lee is an expert in veterinary cardiology and internal medicine. After completing his veterinary degree at Cornell University, he pursued further training in cardiac care for animals. Dr. Lee works at a renowned veterinary hospital and is committed to advancing heart health in pets through innovative treatments and research.", "None", "Dr. Michael Lee", 8 },
                    { 3, "Dr. Emily Rodriguez has a wealth of experience in exotic animal care, having worked with a variety of species including reptiles, birds, and small mammals. She earned her degree from the University of Florida and has since dedicated her career to the care and conservation of exotic animals. Dr. Rodriguez frequently volunteers at wildlife rescue centers and is a respected voice in the field of exotic animal medicine.", "None", "Dr. Emily Rodriguez", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Veterinarians");
        }
    }
}
