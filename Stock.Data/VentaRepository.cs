using Stock.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Data
{
    public class VentaRepository
    {

        public bool Grabar()
        {
            //codigo para grabar la venta

            return true;
        }

        public Venta Obtener(int Id_Ventas)
        {
            Venta venta = new Venta(Id_Ventas);

            venta.Fecha = new DateTimeOffset(2020, 10, 23, 13, 15, 0, TimeSpan.Zero);
            venta.DirecionEnvio = "Barrio La Victoria Calle 3 - Paraguay";

            return venta;
        }

        public List<Venta> Obtener()
        {
            //codigo para recuperar el listado de ventas

            return new List<Venta>();
        }

        public VentaMostrar ObtenerVentaMostrar(int Id_Ventas)
        {
            VentaMostrar ventaMostrar = new VentaMostrar();

            //Codigo que recupera los datos de la venta desde la fuente de datos o base de datos

            //Codigo Temporal Hard-Coded para realizar mas facilmente las pruebas
            ventaMostrar.PrimerNombre = "Leonardo";
            ventaMostrar.PrimerApellido = "Testa";
            ventaMostrar.FechaVenta = new DateTimeOffset(2020, 11, 19, 00, 00, 00, new TimeSpan(0));
            ventaMostrar.DireccionEnvio = new Direcciones(1)
            {
                Pais = "Paraguay",
                Departamento = "Alto Parana",
                Ciudad = "Ciudad Del Este",
                Barrio = "La Victoria",
                Direccion = "Calle 3",
                TipoDireccion = "Direccion De Envio"
            };

            ventaMostrar.ListadoVentaProductoMostrar = new List<VentaProductoMostrar>();

            //Codigo que recupera los productos vendidos de la venta desde la fuente de datos o base de datos

            //Codigo temporal Hard-Coded

            var ProductoVendido1 = new VentaProductoMostrar()
            {
                ProductoNombre = "PlayStation 5",
                PrecioVenta = 500M,
                CantidadVendida = 2
            };

            var ProductoVendido2 = new VentaProductoMostrar()
            {
                ProductoNombre = "XBOX X",
                PrecioVenta = 600M,
                CantidadVendida = 3
            };

            ventaMostrar.ListadoVentaProductoMostrar.Add(ProductoVendido1);
            ventaMostrar.ListadoVentaProductoMostrar.Add(ProductoVendido2);

            return ventaMostrar;
        }
    }
}
