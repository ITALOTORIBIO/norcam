﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using norcam.Data;

namespace norcam.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201231181919_Ahorasis")]
    partial class Ahorasis
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("norcam.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("fax")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("razon_social")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ruc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("norcam.Models.Facturas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("adval")
                        .HasColumnType("double precision");

                    b.Property<string>("archivo")
                        .HasColumnType("text");

                    b.Property<double>("cif_orden")
                        .HasColumnType("double precision");

                    b.Property<int>("cod_cliente")
                        .HasColumnType("integer");

                    b.Property<int>("cod_orden")
                        .HasColumnType("integer");

                    b.Property<double>("comision")
                        .HasColumnType("double precision");

                    b.Property<string>("dua_orden")
                        .HasColumnType("text");

                    b.Property<string>("fec_canc")
                        .HasColumnType("text");

                    b.Property<string>("fec_fac")
                        .HasColumnType("text");

                    b.Property<double>("gasto_admin")
                        .HasColumnType("double precision");

                    b.Property<double>("gasto_ope")
                        .HasColumnType("double precision");

                    b.Property<double>("igv_fact")
                        .HasColumnType("double precision");

                    b.Property<double>("ipm")
                        .HasColumnType("double precision");

                    b.Property<double>("reintegro")
                        .HasColumnType("double precision");

                    b.Property<double>("sup_cont")
                        .HasColumnType("double precision");

                    b.Property<double>("tc_orden")
                        .HasColumnType("double precision");

                    b.Property<double>("total_liq")
                        .HasColumnType("double precision");

                    b.Property<double>("total_neto")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("norcam.Models.Ordenes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("cif")
                        .HasColumnType("double precision");

                    b.Property<int>("cod_cliente")
                        .HasColumnType("integer");

                    b.Property<string>("contenido")
                        .HasColumnType("text");

                    b.Property<string>("dua")
                        .HasColumnType("text");

                    b.Property<string>("fec_entrega")
                        .HasColumnType("text");

                    b.Property<string>("fec_num")
                        .HasColumnType("text");

                    b.Property<string>("fec_rec")
                        .HasColumnType("text");

                    b.Property<double>("peso")
                        .HasColumnType("double precision");

                    b.Property<string>("proveedor")
                        .HasColumnType("text");

                    b.Property<string>("razon_social")
                        .HasColumnType("text");

                    b.Property<string>("regimen")
                        .HasColumnType("text");

                    b.Property<double>("tc")
                        .HasColumnType("double precision");

                    b.Property<string>("ubicacion")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("norcam.Models.Recibos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ano")
                        .HasColumnType("text");

                    b.Property<string>("banco")
                        .HasColumnType("text");

                    b.Property<int>("cheque")
                        .HasColumnType("integer");

                    b.Property<int>("cod_factura")
                        .HasColumnType("integer");

                    b.Property<string>("doc_cob")
                        .HasColumnType("text");

                    b.Property<double>("dolares")
                        .HasColumnType("double precision");

                    b.Property<string>("fec_emi")
                        .HasColumnType("text");

                    b.Property<string>("fec_pago")
                        .HasColumnType("text");

                    b.Property<string>("igv")
                        .HasColumnType("text");

                    b.Property<string>("mes")
                        .HasColumnType("text");

                    b.Property<string>("observaciones")
                        .HasColumnType("text");

                    b.Property<double>("soles")
                        .HasColumnType("double precision");

                    b.Property<string>("tc")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Recibos");
                });

            modelBuilder.Entity("norcam.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
