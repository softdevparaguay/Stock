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
            //CODIGO QUE GRABA LOS DATOS DEL CLIENE EN ALGUNA PARTE YA SEA BASE DE DATOS U OTRA PARTE
            return true;
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

            return new List<Cliente>();
        }
    }
}
