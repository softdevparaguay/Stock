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
    public class ProductoRepositoryTest
    {
        [TestMethod]
        public void VerificarObtener()
        {
            //--Arrange
            var productoRepository = new ProductoRepository();
            var ResultadoEsperado = new Producto(1)
            {
                Nombre = "Iphone 13",
                Descripcion = "Celular Iphone 13",
                Precio = 2000,
            };

            //--Act
            var Actual = productoRepository.Obtener(1);

            //--Assert
            Assert.AreEqual(ResultadoEsperado.Id_Productos, Actual.Id_Productos);
            Assert.AreEqual(ResultadoEsperado.Nombre, Actual.Nombre);
            Assert.AreEqual(ResultadoEsperado.Descripcion, Actual.Descripcion);
            Assert.AreEqual(ResultadoEsperado.Precio, Actual.Precio);

        }
    }
}
