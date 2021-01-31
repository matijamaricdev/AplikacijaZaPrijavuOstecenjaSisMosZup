using Microsoft.EntityFrameworkCore.Migrations;

namespace AplikacijaZaPrijavuOstecenjaSisMosZup.Data.Migrations
{
    public partial class InitialCrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RazinaOstecenja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RazinaOstecenja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prijavitelj",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Broj_Godina = table.Column<short>(nullable: false),
                    OIB = table.Column<double>(nullable: false),
                    Selo_Grad = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    RazinaOstecenjaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijavitelj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prijavitelj_RazinaOstecenja_RazinaOstecenjaId",
                        column: x => x.RazinaOstecenjaId,
                        principalTable: "RazinaOstecenja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RazinaOstecenja",
                columns: new[] { "Id", "Ime" },
                values: new object[,]
                {
                    { 1, "Krov se pomaknuo" },
                    { 2, "Crijep se pomaknuo" },
                    { 3, "Jedan unutarnji zid kuće ili stana je popucao" },
                    { 4, "Više unutarnjih zidova kuće ili stana je popucano" },
                    { 5, "Jedan vanjski zid kuće ili stana je popucao" },
                    { 6, "Više vanjskih zidova kuće ili stana je popucano" },
                    { 7, "Krov je srušen" },
                    { 8, "Srušen je krov i četvrtina kuće" },
                    { 9, "Srušen je krov i pola kuće" },
                    { 10, "Srušen je krov i cijela kuća" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prijavitelj_RazinaOstecenjaId",
                table: "Prijavitelj",
                column: "RazinaOstecenjaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prijavitelj");

            migrationBuilder.DropTable(
                name: "RazinaOstecenja");
        }
    }
}
