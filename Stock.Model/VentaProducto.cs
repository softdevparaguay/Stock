using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public class VentaProducto
    {
        public VentaProducto()
        {

        }

        public VentaProducto(int Id_VentasProductos)
        {
            this.Id_VentasProductos = Id_VentasProductos;
        }

        public int Id_VentasProductos { get; private set; }
        public int Id_Productos { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? PrecioVenta { get; set; }

        public bool Grabar()
        {
            //codigo para grabar la venta producto

            return true;
        }

        public VentaProducto Obtener(int Id_VentasProductos)
        {
            //codigo para obtener una venta producto

            return new VentaProducto();
        }

        public List<VentaProducto> Obtener()
        {
            //codigo para obtener el listado de venta producto

            return new List<VentaProducto>();
        }

        public bool Validar()
        {
            var EsValido = true;

            if (Cantidad<=0)
            {
                EsValido = false;
            }

            if (Id_Productos<=0)
            {
                EsValido = false;
            }

            if (PrecioVenta==null)
            {
                EsValido = false;
            }

            return EsValido;
        }

    }
}
