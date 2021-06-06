using Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Data
{
    public class VentaRepository
    {
        static List<Venta> Listado = new List<Venta>();

        public VentaRepository()
        {
            if (Listado.Count == 0)
            {
                //Creacion de objetos de ejemplo
                Venta venta1 = new Venta(1);
                venta1.Fecha = new DateTimeOffset(new DateTime(2021, 5, 23));
                venta1.Id_Clientes = 1;

                Venta venta2 = new Venta(2);
                venta2.Fecha = new DateTimeOffset(new DateTime(2021, 4, 22));
                venta2.Id_Clientes = 2;

                Venta venta3 = new Venta(3);
                venta3.Fecha = new DateTimeOffset(new DateTime(2021, 3, 21));
                venta3.Id_Clientes = 1;

                Listado.Add(venta1);
                Listado.Add(venta2);
                Listado.Add(venta3);
            }
        }

        public bool Grabar(ref Venta venta)
        {
            var OperacionRealizadaConExito = true;

            if (venta.Modificado && venta.EsValido)
            {
                if (venta.EsNuevo)
                {
                    //GRABA UN REGISTRO NUEVO EN LA BASE DE DATOS

                    Venta VentaCreada = new Venta(Listado.Count + 1);
                    VentaCreada.Id_Clientes = venta.Id_Clientes;
                    VentaCreada.DirecionEnvio = venta.DirecionEnvio;
                    VentaCreada.Fecha = venta.Fecha;
                    VentaCreada.Id_Direcciones = venta.Id_Direcciones;

                    Listado.Add(VentaCreada);

                    venta = VentaCreada;
                }
                else
                {
                    //MODIFICA EL REGISTRO EN LA BASE DE DATOS
                }
            }

            return OperacionRealizadaConExito;
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

        public List<Venta> ObtenerPorId_Clientes(int Id_Clientes)
        {
            return Listado.Where(c => c.Id_Clientes == Id_Clientes).ToList();
        }

        public Venta ObtenerPorId_Clientes(int Id_Clientes, int Id_Ventas)
        {
            return Listado.Where(c => c.Id_Clientes == Id_Clientes &&
                                      c.Id_Ventas == Id_Ventas).FirstOrDefault();
        }
    }
}
