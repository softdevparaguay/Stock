using Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Data
{
    public class ClienteRepository
    {
        private DireccionesRepository direccionesRepository { get; set; }

        public ClienteRepository()
        {
            direccionesRepository = new DireccionesRepository();
        }

        public bool Grabar(Cliente cliente)
        {
            var OperacionRealizadaConExito = true;

            if (cliente.Modificado && cliente.EsValido)
            {
                if (cliente.EsNuevo)
                {
                    //GRABA UN REGISTRO NUEVO EN LA BASE DE DATOS
                }
                else
                {
                    //MODIFICA EL REGISTRO EN LA BASE DE DATOS
                }
            }

            return OperacionRealizadaConExito;
        }

        public Cliente Obtener(int Id_Cliente)
        {
            Cliente cliente = new Cliente(Id_Cliente);

            cliente.Email = "softdevparaguay@hotmail.com";
            cliente.PrimerNombre = "Leonardo";
            cliente.PrimerApellido = "Testa";

            cliente.ListadoDirecciones = direccionesRepository.ObtenerPorId_Clientes(Id_Cliente);


            return cliente;
        }

        public List<Cliente> Obtener()
        {
            //CODIGO QUE BUSCA TODOS LOS CLIENTES
            var Retorno = new List<Cliente>();

            Cliente cliente1 = new Cliente(1);
            cliente1.Email = "softdevparaguay@hotmail.com";
            cliente1.PrimerNombre = "Leonardo";
            cliente1.PrimerApellido = "Testa";

            Cliente cliente2 = new Cliente(2);
            cliente2.Email = "raul@hotmail.com";
            cliente2.PrimerNombre = "Raul";
            cliente2.PrimerApellido = "Prieto";

            Cliente cliente3 = new Cliente(3);
            cliente3.Email = "guillermo@hotmail.com";
            cliente3.PrimerNombre = "Guillermo";
            cliente3.PrimerApellido = "Riveros";

            Retorno.Add(cliente1);
            Retorno.Add(cliente2);
            Retorno.Add(cliente3);

            return Retorno;
        }
    }
}
