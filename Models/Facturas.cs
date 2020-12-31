using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace norcam.Models
{
    public class Facturas
    {
        [Display(Name="# Orden")]
        public int cod_orden { get; set; }
        [Display(Name="Fec. Factura")]
        public string fec_fac { get; set; }
        [Display(Name="# Cliente")]
        public int cod_cliente { get; set; }
        [Display(Name="Fec. Cancela")]
        public string fec_canc { get; set; }
        [Display(Name="Archivo")]
        public string archivo { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="# Factura")]
        public int id { get; set; }
        [Display(Name="D. U. A.")]
        public string dua_orden { get; set; }
        [Display(Name="CIF. US$")]
        public double cif_orden { get; set; }
        [Display(Name="T/C S/")]
        public double tc_orden { get; set; }
        [Display(Name="Ad-Val US$")]
        public double adval { get; set; }
        [Display(Name="I. P. M")]
        public double ipm { get; set; }
        [Display(Name="Reintegro")]
        public double reintegro { get; set; }
        [Display(Name="Total Líquido US$")]
        public double total_liq { get; set; }
        
        [NotMapped]
        public double Respuesta1 { get; set; }

        [Display(Name="Gastos Operativos")]
        public double gasto_ope { get; set; }
        [Display(Name="Gastos Administrativos")]
        public double gasto_admin { get; set; }
        [Display(Name="Supervisión y control de entrega")]
        public double sup_cont { get; set; }
        [Display(Name="Comisión")]
        public double comision { get; set; }
        [Display(Name="I. G. V.")]
        public double igv_fact { get; set; }
        [Display(Name="US$.")]
        public double total_neto { get; set; }    
    }
}