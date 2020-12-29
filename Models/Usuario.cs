using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace norcam.Models
{
    public class Usuario
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]        
        public string DNI { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Tipo { get; set; }
    }
}