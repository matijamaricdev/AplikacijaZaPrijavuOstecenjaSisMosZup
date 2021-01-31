using Microsoft.EntityFrameworkCore.Migrations;

namespace AplikacijaZaPrijavuOstecenjaSisMosZup.Data.Migrations
{
    public partial class AddedEmailAddressAndContactNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Prijavitelj",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Kontakt_Broj",
                table: "Prijavitelj",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Prijavitelj");

            migrationBuilder.DropColumn(
                name: "Kontakt_Broj",
                table: "Prijavitelj");
        }
    }
}
