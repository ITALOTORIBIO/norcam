using Microsoft.EntityFrameworkCore.Migrations;

namespace norcam.Migrations
{
    public partial class Ahorasis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "igv_adu",
                table: "Factura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "igv_adu",
                table: "Factura",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
