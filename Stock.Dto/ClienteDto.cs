using System;

namespace Stock.Dto
{
    public class ClienteDto
    {
        public int Id_Clientes { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }

        public int Id_Vendedores { get; set; }
        public string Vendedor { get; set; }
        public string VendedorTelefono { get; set; }
        public string VendedorEmail { get; set; }
    }
}
