using Microsoft.EntityFrameworkCore.Migrations;

namespace norcam.Migrations
{
    public partial class Ahorasi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Ordenes_cifid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Cliente_cod_clienteid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Ordenes_cod_ordenid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Ordenes_duaid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Ordenes_tcid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Recibos_Factura_facturaid",
                table: "Recibos");

            migrationBuilder.DropIndex(
                name: "IX_Recibos_facturaid",
                table: "Recibos");

            migrationBuilder.DropIndex(
                name: "IX_Factura_cifid",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_cod_clienteid",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_cod_ordenid",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_duaid",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_tcid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "facturaid",
                table: "Recibos");

            migrationBuilder.DropColumn(
                name: "cifid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "cod_clienteid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "cod_ordenid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "duaid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "tcid",
                table: "Factura");

            migrationBuilder.AddColumn<int>(
                name: "cod_factura",
                table: "Recibos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "cif_orden",
                table: "Factura",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "cod_cliente",
                table: "Factura",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cod_orden",
                table: "Factura",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "dua_orden",
                table: "Factura",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "tc_orden",
                table: "Factura",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cod_factura",
                table: "Recibos");

            migrationBuilder.DropColumn(
                name: "cif_orden",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "cod_cliente",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "cod_orden",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "dua_orden",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "tc_orden",
                table: "Factura");

            migrationBuilder.AddColumn<int>(
                name: "facturaid",
                table: "Recibos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cifid",
                table: "Factura",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cod_clienteid",
                table: "Factura",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cod_ordenid",
                table: "Factura",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "duaid",
                table: "Factura",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tcid",
                table: "Factura",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recibos_facturaid",
                table: "Recibos",
                column: "facturaid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_cifid",
                table: "Factura",
                column: "cifid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_cod_clienteid",
                table: "Factura",
                column: "cod_clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_cod_ordenid",
                table: "Factura",
                column: "cod_ordenid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_duaid",
                table: "Factura",
                column: "duaid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_tcid",
                table: "Factura",
                column: "tcid");

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Ordenes_cifid",
                table: "Factura",
                column: "cifid",
                principalTable: "Ordenes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Cliente_cod_clienteid",
                table: "Factura",
                column: "cod_clienteid",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Ordenes_cod_ordenid",
                table: "Factura",
                column: "cod_ordenid",
                principalTable: "Ordenes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Ordenes_duaid",
                table: "Factura",
                column: "duaid",
                principalTable: "Ordenes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Ordenes_tcid",
                table: "Factura",
                column: "tcid",
                principalTable: "Ordenes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recibos_Factura_facturaid",
                table: "Recibos",
                column: "facturaid",
                principalTable: "Factura",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
