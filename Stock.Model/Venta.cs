using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public class Venta
    {
        public Venta()
        {
            VentaProductos = new List<VentaProducto>();
        }

        public Venta(int Id_Ventas) : this()
        {
            this.Id_Ventas = Id_Ventas;
        }

        public int Id_Ventas { get; private set; }
        public DateTimeOffset? Fecha { get; set; }
        public string DirecionEnvio { get; set; }

        public int Id_Clientes { get; set; }
        public int Id_Direcciones { get; set; }

        public List<VentaProducto> VentaProductos { get; set; }

        public bool Validar()
        {
            var EsValido = true;

            if (Fecha == null)
            {
                EsValido = false;
            }

            return EsValido;
        }
    }
}
