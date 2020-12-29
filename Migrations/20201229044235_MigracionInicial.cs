using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace norcam.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    razon_social = table.Column<string>(nullable: false),
                    ruc = table.Column<string>(nullable: false),
                    direccion = table.Column<string>(nullable: false),
                    telefono = table.Column<string>(nullable: false),
                    fax = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    DNI = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fec_rec = table.Column<string>(nullable: true),
                    cod_clienteid = table.Column<int>(nullable: true),
                    razon_socialid = table.Column<int>(nullable: true),
                    proveedor = table.Column<string>(nullable: true),
                    dua = table.Column<string>(nullable: true),
                    cif = table.Column<double>(nullable: false),
                    contenido = table.Column<string>(nullable: true),
                    peso = table.Column<double>(nullable: false),
                    ubicacion = table.Column<string>(nullable: true),
                    regimen = table.Column<string>(nullable: true),
                    fec_num = table.Column<string>(nullable: true),
                    fec_entrega = table.Column<string>(nullable: true),
                    tc = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ordenes_Cliente_cod_clienteid",
                        column: x => x.cod_clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ordenes_Cliente_razon_socialid",
                        column: x => x.razon_socialid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cod_ordenid = table.Column<int>(nullable: true),
                    fec_fac = table.Column<string>(nullable: true),
                    cod_clienteid = table.Column<int>(nullable: true),
                    fec_canc = table.Column<string>(nullable: true),
                    archivo = table.Column<string>(nullable: true),
                    duaid = table.Column<int>(nullable: true),
                    cifid = table.Column<int>(nullable: true),
                    tcid = table.Column<int>(nullable: true),
                    adval = table.Column<double>(nullable: false),
                    igv_adu = table.Column<double>(nullable: false),
                    ipm = table.Column<double>(nullable: false),
                    reintegro = table.Column<double>(nullable: false),
                    total_liq = table.Column<double>(nullable: false),
                    gasto_ope = table.Column<double>(nullable: false),
                    gasto_admin = table.Column<double>(nullable: false),
                    sup_cont = table.Column<double>(nullable: false),
                    comision = table.Column<double>(nullable: false),
                    igv_fact = table.Column<double>(nullable: false),
                    total_neto = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.id);
                    table.ForeignKey(
                        name: "FK_Factura_Ordenes_cifid",
                        column: x => x.cifid,
                        principalTable: "Ordenes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Cliente_cod_clienteid",
                        column: x => x.cod_clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Ordenes_cod_ordenid",
                        column: x => x.cod_ordenid,
                        principalTable: "Ordenes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Ordenes_duaid",
                        column: x => x.duaid,
                        principalTable: "Ordenes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Ordenes_tcid",
                        column: x => x.tcid,
                        principalTable: "Ordenes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ano = table.Column<string>(nullable: true),
                    mes = table.Column<string>(nullable: true),
                    fec_emi = table.Column<string>(nullable: true),
                    fec_pago = table.Column<string>(nullable: true),
                    tc = table.Column<string>(nullable: true),
                    doc_cob = table.Column<string>(nullable: true),
                    facturaid = table.Column<int>(nullable: true),
                    cheque = table.Column<int>(nullable: false),
                    banco = table.Column<string>(nullable: true),
                    dolares = table.Column<double>(nullable: false),
                    observaciones = table.Column<string>(nullable: true),
                    soles = table.Column<double>(nullable: false),
                    igv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recibos_Factura_facturaid",
                        column: x => x.facturaid,
                        principalTable: "Factura",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_cod_clienteid",
                table: "Ordenes",
                column: "cod_clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_razon_socialid",
                table: "Ordenes",
                column: "razon_socialid");

            migrationBuilder.CreateIndex(
                name: "IX_Recibos_facturaid",
                table: "Recibos",
                column: "facturaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recibos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
