﻿using Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Data
{
    public class ClienteRepository
    {
        List<Cliente> Listado = new List<Cliente>();

        private DireccionesRepository direccionesRepository { get; set; }

        public ClienteRepository()
        {
            direccionesRepository = new DireccionesRepository();

            //Creacion de objetos de ejemplo

            Cliente cliente1 = new Cliente(1);
            cliente1.Email = "softdevparaguay@hotmail.com";
            cliente1.PrimerNombre = "Leonardo";
            cliente1.PrimerApellido = "Testa";

            Vendedor vendedor1 = new Vendedor(1);
            vendedor1.Nombre = "Vendedor 1";
            vendedor1.Telefono = "(0973) 123456";
            vendedor1.Email = "vendedor1@vendedor.com";

            cliente1.Vendedor = vendedor1;

            Cliente cliente2 = new Cliente(2);
            cliente2.Email = "raul@hotmail.com";
            cliente2.PrimerNombre = "Raul";
            cliente2.PrimerApellido = "Prieto";

            Vendedor vendedor2 = new Vendedor(2);
            vendedor2.Nombre = "Vendedor 2";
            vendedor2.Telefono = "(0973) 456789";
            vendedor2.Email = "vendedor2@vendedor.com";

            cliente2.Vendedor = vendedor2;

            Cliente cliente3 = new Cliente(3);
            cliente3.Email = "guillermo@hotmail.com";
            cliente3.PrimerNombre = "Guillermo";
            cliente3.PrimerApellido = "Riveros";

            Vendedor vendedor3 = new Vendedor(3);
            vendedor3.Nombre = "Vendedor 3";
            vendedor3.Telefono = "(0973) 987654";
            vendedor3.Email = "vendedor3@vendedor.com";

            cliente3.Vendedor = vendedor3;

            Listado.Add(cliente1);
            Listado.Add(cliente2);
            Listado.Add(cliente3);
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
            //Cliente cliente = new Cliente(Id_Cliente);

            //cliente.Email = "softdevparaguay@hotmail.com";
            //cliente.PrimerNombre = "Leonardo";
            //cliente.PrimerApellido = "Testa";

            //cliente.ListadoDirecciones = direccionesRepository.ObtenerPorId_Clientes(Id_Cliente);

            //return cliente;

            return Listado.FirstOrDefault(c => c.Id_Clientes == Id_Cliente);
        }

        public List<Cliente> Obtener()
        {
            //CODIGO QUE BUSCA TODOS LOS CLIENTES           
            return Listado;
        }
    }
}
