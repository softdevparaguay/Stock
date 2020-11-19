using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stock.Model;

namespace Stock.ModelTest
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void NombreCompletoTestValido()
        {
            //Patron AAA
            //Arrage
            Cliente cliente = new Cliente();
            cliente.PrimerNombre = "Leonardo";
            cliente.PrimerApellido = "Testa";

            string ResultadoEsperado = "Leonardo, Testa";

            //Act
            string Actual = cliente.NombreCompleto;

            //Assert
            Assert.AreEqual(ResultadoEsperado, Actual);

        }

        [TestMethod]
        public void NombreCompletoPrimerNombreVacio()
        {
            //Patron AAA
            //Arrage
            Cliente cliente = new Cliente();
            cliente.PrimerApellido = "Testa";

            string ResultadoEsperado = "Testa";

            //Act
            string Actual = cliente.NombreCompleto;

            //Assert
            Assert.AreEqual(ResultadoEsperado, Actual);

        }

        [TestMethod]
        public void NombreCompletoPrimerApellidoVacio()
        {
            //Patron AAA
            //Arrage
            Cliente cliente = new Cliente();
            cliente.PrimerNombre = "Leonardo";

            string ResultadoEsperado = "Leonardo";

            //Act
            string Actual = cliente.NombreCompleto;

            //Assert
            Assert.AreEqual(ResultadoEsperado, Actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            //Patron AAA
            //Arrage
            Cliente cliente1 = new Cliente();
            cliente1.PrimerNombre = "Leonardo";
            Cliente.ContadorDeInstancias += 1;

            Cliente cliente2 = new Cliente();
            cliente2.PrimerNombre = "Raul";
            Cliente.ContadorDeInstancias += 1;

            Cliente cliente3 = new Cliente();
            cliente3.PrimerNombre = "Guillermo";
            Cliente.ContadorDeInstancias += 1;

            //Act
            
            //Assert
            Assert.AreEqual(3, Cliente.ContadorDeInstancias);

        }

        [TestMethod]
        public void VerificarValidarValido()
        {
            //Patron AAA
            //Arrage
            Cliente cliente = new Cliente();
            cliente.PrimerNombre = "Leonardo";
            cliente.PrimerApellido = "Testa";

            bool ResultadoEsperado = true;

            //Act
            bool Actual = cliente.Validar();

            //Assert
            Assert.AreEqual(ResultadoEsperado, Actual);

        }

        [TestMethod]
        public void VerificarValidarSinPrimerApellido()
        {
            //Patron AAA
            //Arrage
            Cliente cliente = new Cliente();
            cliente.PrimerNombre = "Leonardo";
            
            bool ResultadoEsperado = false;

            //Act
            bool Actual = cliente.Validar();

            //Assert
            Assert.AreEqual(ResultadoEsperado, Actual);

        }


    }
}
