using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IrradApi.Migrations
{
    public partial class CreatingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CityIrradiationData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Lon = table.Column<float>(type: "float", nullable: false),
                    Lat = table.Column<float>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Annual = table.Column<int>(type: "int", nullable: false),
                    Jan = table.Column<int>(type: "int", nullable: false),
                    Feb = table.Column<int>(type: "int", nullable: false),
                    Mar = table.Column<int>(type: "int", nullable: false),
                    Apr = table.Column<int>(type: "int", nullable: false),
                    May = table.Column<int>(type: "int", nullable: false),
                    Jun = table.Column<int>(type: "int", nullable: false),
                    Jul = table.Column<int>(type: "int", nullable: false),
                    Aug = table.Column<int>(type: "int", nullable: false),
                    Sep = table.Column<int>(type: "int", nullable: false),
                    Oct = table.Column<int>(type: "int", nullable: false),
                    Nov = table.Column<int>(type: "int", nullable: false),
                    Dec = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityIrradiationData", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CityIrradiation",
                columns: table => new
                {
                    NameIdentification = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CityIrradiationDataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityIrradiation", x => x.NameIdentification);
                    table.ForeignKey(
                        name: "FK_CityIrradiation_CityIrradiationData_CityIrradiationDataId",
                        column: x => x.CityIrradiationDataId,
                        principalTable: "CityIrradiationData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CityIrradiation_CityIrradiationDataId",
                table: "CityIrradiation",
                column: "CityIrradiationDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityIrradiation");

            migrationBuilder.DropTable(
                name: "CityIrradiationData");
        }
    }
}
