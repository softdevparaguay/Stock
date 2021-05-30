using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Dto
{
    public class VentaDto
    {
        public int Id_Ventas { get; set; }
        public DateTimeOffset? Fecha { get; set; }
        public int Id_Clientes { get; set; }
    }
}
