using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock.Comun;

namespace Stock.ComunTest
{
    [TestClass]
    public class ManejoStringsTest
    {
        [TestMethod]
        public void ColocarEspaciosTestValid()
        {

            //Arrange
            var Origen = "XboxOne";
            var ResultadoEsperado = "Xbox One";

            var Manejador = new ManejoStrings();

            //Act
            var Actual = Manejador.ColocarEspacios(Origen);

            //Assert
            Assert.AreEqual(ResultadoEsperado, Actual);

        }

        [TestMethod]
        public void ColocarEspaciosEnCadenaConEspaciosTest()
        {

            //Arrange
            var Origen = "Xbox One";
            var ResultadoEsperado = "Xbox One";

            var Manejador = new ManejoStrings();

            //Act
            var Actual = Manejador.ColocarEspacios(Origen);

            //Assert
            Assert.AreEqual(ResultadoEsperado, Actual);

        }
    }
}
