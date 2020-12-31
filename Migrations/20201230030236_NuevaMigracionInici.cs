using Microsoft.EntityFrameworkCore.Migrations;

namespace norcam.Migrations
{
    public partial class NuevaMigracionInici : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordenes_Cliente_cod_clienteid",
                table: "Ordenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordenes_Cliente_razon_socialid",
                table: "Ordenes");

            migrationBuilder.DropIndex(
                name: "IX_Ordenes_cod_clienteid",
                table: "Ordenes");

            migrationBuilder.DropIndex(
                name: "IX_Ordenes_razon_socialid",
                table: "Ordenes");

            migrationBuilder.DropColumn(
                name: "cod_clienteid",
                table: "Ordenes");

            migrationBuilder.DropColumn(
                name: "razon_socialid",
                table: "Ordenes");

            migrationBuilder.AddColumn<int>(
                name: "cod_cliente",
                table: "Ordenes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "razon_social",
                table: "Ordenes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cod_cliente",
                table: "Ordenes");

            migrationBuilder.DropColumn(
                name: "razon_social",
                table: "Ordenes");

            migrationBuilder.AddColumn<int>(
                name: "cod_clienteid",
                table: "Ordenes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "razon_socialid",
                table: "Ordenes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_cod_clienteid",
                table: "Ordenes",
                column: "cod_clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_razon_socialid",
                table: "Ordenes",
                column: "razon_socialid");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordenes_Cliente_cod_clienteid",
                table: "Ordenes",
                column: "cod_clienteid",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordenes_Cliente_razon_socialid",
                table: "Ordenes",
                column: "razon_socialid",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
