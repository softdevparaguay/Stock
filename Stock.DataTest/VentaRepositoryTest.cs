using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock.Data;
using Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DataTest
{
    [TestClass]
    public class VentaRepositoryTest
    {
        [TestMethod()]
        public void ObtenerVentaMostrarTest()
        {
            //--Arrage
            var ventaRepository = new VentaRepository();

            var ResultadoEsperado = new VentaMostrar()
            {
                PrimerNombre = "Leonardo",
                PrimerApellido = "Testa",
                FechaVenta = new DateTimeOffset(2020, 11, 19, 00, 00, 00, new TimeSpan(0)),
                DireccionEnvio = new Direcciones(1)
                {
                    Pais = "Paraguay",
                    Departamento = "Alto Parana",
                    Ciudad = "Ciudad Del Este",
                    Barrio = "La Victoria",
                    Direccion = "Calle 3",
                    TipoDireccion = "Direccion De Envio"
                },
                ListadoVentaProductoMostrar = new List<VentaProductoMostrar>()
                {
                    new VentaProductoMostrar()
                    {
                        ProductoNombre="PlayStation 5",
                        PrecioVenta = 500M,
                        CantidadVendida = 2
                    },
                    new VentaProductoMostrar()
                    {
                        ProductoNombre="XBOX X",
                        PrecioVenta = 600M,
                        CantidadVendida = 3
                    }
                }
            };

            //--Act
            var Actual = ventaRepository.ObtenerVentaMostrar(1);

            //--Assert
            Assert.AreEqual(ResultadoEsperado.Id_Ventas, Actual.Id_Ventas);
            Assert.AreEqual(ResultadoEsperado.PrimerNombre, Actual.PrimerNombre);
            Assert.AreEqual(ResultadoEsperado.PrimerApellido, Actual.PrimerApellido);
            Assert.AreEqual(ResultadoEsperado.FechaVenta, Actual.FechaVenta);

            Assert.AreEqual(ResultadoEsperado.DireccionEnvio.Pais, Actual.DireccionEnvio.Pais);
            Assert.AreEqual(ResultadoEsperado.DireccionEnvio.Departamento, Actual.DireccionEnvio.Departamento);
            Assert.AreEqual(ResultadoEsperado.DireccionEnvio.Ciudad, Actual.DireccionEnvio.Ciudad);
            Assert.AreEqual(ResultadoEsperado.DireccionEnvio.Direccion, Actual.DireccionEnvio.Direccion);
            Assert.AreEqual(ResultadoEsperado.DireccionEnvio.Barrio, Actual.DireccionEnvio.Barrio);
            Assert.AreEqual(ResultadoEsperado.DireccionEnvio.TipoDireccion, Actual.DireccionEnvio.TipoDireccion);
            Assert.AreEqual(ResultadoEsperado.DireccionEnvio.Id_Direcciones, Actual.DireccionEnvio.Id_Direcciones);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(ResultadoEsperado.ListadoVentaProductoMostrar[i].CantidadVendida,
                    Actual.ListadoVentaProductoMostrar[i].CantidadVendida);

                Assert.AreEqual(ResultadoEsperado.ListadoVentaProductoMostrar[i].ProductoNombre,
                    Actual.ListadoVentaProductoMostrar[i].ProductoNombre);

                Assert.AreEqual(ResultadoEsperado.ListadoVentaProductoMostrar[i].PrecioVenta,
                    Actual.ListadoVentaProductoMostrar[i].PrecioVenta);
            }


































        }
    }
}
