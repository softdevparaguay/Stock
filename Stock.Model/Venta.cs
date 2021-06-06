using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public sealed class Venta : ClaseBase
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

        private Cliente _Cliente;
        public Cliente Cliente
        {
            get
            {
                if (_Cliente == null) _Cliente = new Cliente();

                return _Cliente;
            }
            set
            {
                _Cliente = value;
            }
        }

        public List<VentaProducto> VentaProductos { get; set; }

        public override bool Validar()
        {
            var EsValido = true;

            if (Fecha == null)
            {
                EsValido = false;
            }

            return EsValido;
        }

        public override string ToString()
        {
            return $"{Fecha.Value.Date} ({Id_Ventas})";
        }
    }
}
