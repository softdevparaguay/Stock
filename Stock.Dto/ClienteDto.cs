using System;
using System.ComponentModel.DataAnnotations;

namespace Stock.Dto
{
    public class ClienteDto
    {
        public int Id_Clientes { get; set; }

        [Required(ErrorMessage = "Es necesario colocar el primer nombre")]
        [StringLength(100)]
        public string PrimerNombre { get; set; }

        [Required]
        public string PrimerApellido { get; set; }

        [Required]
        public string Cedula { get; set; }

        //[Range(1,100)]
        public int Id_Vendedores { get; set; }
        public string Vendedor { get; set; }
        public string VendedorTelefono { get; set; }
        public string VendedorEmail { get; set; }
    }
}
