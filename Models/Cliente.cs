using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace norcam.Models
{
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="# Cliente")]
        public int id { get; set; }

        [Required(ErrorMessage="Por favor, Ingrese una razón social")]
        [Display(Name="Razón Social")]
        public string razon_social { get; set; }

        [Required(ErrorMessage="Por favor, Ingrese un ruc válido")]
        [Display(Name="RUC")]
        public string ruc { get; set; }

        [Required(ErrorMessage="Por favor, Ingrese una dirección")]
        [Display(Name="Dirección")]
        public string direccion { get; set; }

        [Required(ErrorMessage="Por favor, Ingrese un número de teléfono")]
        [Display(Name="Teléfono")]
        public string telefono { get; set; }

        [Required(ErrorMessage="Por favor, Ingrese un fax")]
        [Display(Name="FAX")]
        public string fax { get; set; }
        
    }
}