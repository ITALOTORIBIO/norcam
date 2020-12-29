using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace norcam.Models
{
    public class Ordenes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="# Orden")]
        public int id { get; set; }
        [Display(Name="Fecha de recepción")]
        public string fec_rec { get; set; }
        [Display(Name="# Cliente")]
        public Cliente cod_cliente { get; set; }
        [Display(Name="Cliente")]
        public Cliente razon_social { get; set; }
        [Display(Name="Proveedor")]
        public string proveedor { get; set; }
        [Display(Name="D. U. A.")]
        public string dua { get; set; }
        [Display(Name="CIF-FOB US$")] 
        public double cif { get; set; }
        [Display(Name="Contenido")]
        public string contenido { get; set; }
        [Display(Name="Peso")]
        public double peso { get; set; }
        [Display(Name="Ubicación")]
        public string ubicacion { get; set; }
        [Display(Name="Régimen")]
        public string regimen { get; set; }
        [Display(Name="Fec. Numeración")]
        public string fec_num { get; set; }
        [Display(Name="Fec. Entrega")]
        public string fec_entrega { get; set; }
        [Display(Name="TC - S/")]
        public double tc { get; set; }
    }
}