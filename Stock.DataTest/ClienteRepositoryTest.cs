using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock.Data;
using Stock.Model;

namespace Stock.DataTest
{
    [TestClass]
    public class ClienteRepositoryTest
    {
        [TestMethod]
        public void ObtenerExistente()
        {
            //--Arrange
            var clienteRepository = new ClienteRepository();
            var ResultadoEsperado = new Cliente(1)
            {
                Email = "softdevparaguay@hotmail.com",
                PrimerNombre = "Leonardo",
                PrimerApellido = "Testa"
            };

            //--Act
            var Actual = clienteRepository.Obtener(1);

            //--Assert
            Assert.AreEqual(ResultadoEsperado.Id_Clientes, Actual.Id_Clientes);
            Assert.AreEqual(ResultadoEsperado.Email, Actual.Email);
            Assert.AreEqual(ResultadoEsperado.PrimerNombre, Actual.PrimerNombre);
            Assert.AreEqual(ResultadoEsperado.PrimerApellido, Actual.PrimerApellido);

        }

        [TestMethod]
        public void ObtenerClienteConDirecciones()
        {
            //--ARRANGE
            var clienteRepository = new ClienteRepository();
            var ResultadoEsperado = new Cliente(1)
            {
                Email = "softdevparaguay@hotmail.com",
                PrimerNombre = "Leonardo",
                PrimerApellido = "Testa",
                ListadoDirecciones = new List<Direcciones>()
                {
                    new Direcciones()
                    {
                        Pais = "Paraguay",
                        Departamento = "Alto Parana",
                        Ciudad = "Ciudad Del Este",
                        Barrio = "La Victoria",
                        Direccion = "Calle 3",
                        TipoDireccion = "DireccionCasa"
                    },
                    new Direcciones()
                    {
                        Pais = "Paraguay",
                        Departamento = "Alto Parana",
                        Ciudad = "Ciudad Del Este",
                        Barrio = "Area 1",
                        Direccion = "Calle 5",
                        TipoDireccion = "DireccionTrabajo"
                    }
                }
            };

            //--ACT
            var Actual = clienteRepository.Obtener(1);

            //--ASSERT
            Assert.AreEqual(ResultadoEsperado.Id_Clientes, Actual.Id_Clientes);
            Assert.AreEqual(ResultadoEsperado.Email, Actual.Email);
            Assert.AreEqual(ResultadoEsperado.PrimerNombre, Actual.PrimerNombre);
            Assert.AreEqual(ResultadoEsperado.PrimerApellido, Actual.PrimerApellido);

            for (int i = 0; i < 1 ; i++)
            {
                Assert.AreEqual(ResultadoEsperado.ListadoDirecciones[i].Pais, Actual.ListadoDirecciones[i].Pais);
                Assert.AreEqual(ResultadoEsperado.ListadoDirecciones[i].Departamento, Actual.ListadoDirecciones[i].Departamento);
                Assert.AreEqual(ResultadoEsperado.ListadoDirecciones[i].Ciudad, Actual.ListadoDirecciones[i].Ciudad);
                Assert.AreEqual(ResultadoEsperado.ListadoDirecciones[i].Barrio, Actual.ListadoDirecciones[i].Barrio);
                Assert.AreEqual(ResultadoEsperado.ListadoDirecciones[i].Direccion, Actual.ListadoDirecciones[i].Direccion);
                Assert.AreEqual(ResultadoEsperado.ListadoDirecciones[i].TipoDireccion, Actual.ListadoDirecciones[i].TipoDireccion);
            }
        }
    }
}












