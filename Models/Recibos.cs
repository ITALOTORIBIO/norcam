using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace norcam.Models
{
    public class Recibos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="Número")]
        public int id { get; set; }
        [Display(Name="Año")]
        public string ano { get; set; }
        [Display(Name="Mes")]
        public string mes { get; set; }
        [Display(Name="Fec. Emisión")]
        public string fec_emi { get; set; }
        [Display(Name="Fec. Pago")]
        public string fec_pago { get; set; }
        [Display(Name="TC - S/")]
        public string tc { get; set; }
        [Display(Name="Doc. Cobranza")]
        public string doc_cob { get; set; }
        [Display(Name="Factura")]
        public Facturas factura { get; set; }
        [Display(Name="# Cheque")]
        public int cheque { get; set; }
        [Display(Name="Banco")]
        public string banco { get; set; }
        [Display(Name="Dólares")]
        public double dolares { get; set; }
        [Display(Name="Observaciones")]
        public string observaciones { get; set; }
        [Display(Name="S/")]
        public double soles { get; set; }
        [Display(Name="I. G. V.")]
        public string igv { get; set; }
    }
}