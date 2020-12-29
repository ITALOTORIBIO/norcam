using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using norcam.Models;

namespace norcam.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Facturas> Factura { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Recibos> Recibos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}