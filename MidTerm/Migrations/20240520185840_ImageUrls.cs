using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MidTerm.Migrations
{
    /// <inheritdoc />
    public partial class ImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/16234651/pexels-photo-16234651/free-photo-of-close-up-of-a-labrador-retriever.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/596590/pexels-photo-596590.jpeg");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/6566630/pexels-photo-6566630.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/17006168/pexels-photo-17006168/free-photo-of-close-up-of-maine-coon.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/351406/pexels-photo-351406.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2");

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://media.istockphoto.com/id/1303362255/photo/young-happy-veterinary-nurse-smiling-while-playing-with-a-dog-high-quality-photo.jpg?s=612x612&w=0&k=20&c=_kIKIzB4GF5WDLCf2yK1XMQk9JtxoL9XPK_nJmTZ5JQ=");

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://st2.depositphotos.com/3662505/6397/i/950/depositphotos_63976241-stock-photo-veterinarian.jpg");

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://st.depositphotos.com/1518767/4292/i/600/depositphotos_42928519-stock-photo-veterinarian-examining-dog.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "None");
        }
    }
}
