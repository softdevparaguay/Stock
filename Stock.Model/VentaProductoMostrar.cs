using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public class VentaProductoMostrar
    {
        public int Id_VentasProductos { get; set; }
        public int CantidadVendida { get; set; }
        public string ProductoNombre { get; set; }
        public decimal? PrecioVenta { get; set; }
    }
}
