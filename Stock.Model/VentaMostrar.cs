using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public class VentaMostrar
    {
        public int Id_Ventas { get; set; }
        public DateTimeOffset? FechaVenta { get; set; }
        public Direcciones DireccionEnvio { get; set; }

        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }

        public List<VentaProductoMostrar> ListadoVentaProductoMostrar { get; set; }
    }
}
