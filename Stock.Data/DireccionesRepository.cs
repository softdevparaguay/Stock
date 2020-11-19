using Stock.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Data
{
    public class DireccionesRepository
    {

        public bool Grabar(Direcciones direcciones)
        {
            //CODIGO QUE GRABA LOS DATOS DE LA DIRECCION EN ALGUNA PARTE YA SEA BASE DE DATOS U OTRA PARTE
            return true;
        }

        public Direcciones Obtener(int Id_Direcciones)
        {
            Direcciones direccion = new Direcciones(Id_Direcciones);

            direccion.Pais = "Paraguay";
            direccion.Departamento = "Alto Parana";
            direccion.Ciudad = "Ciudad Del Este";
            direccion.Barrio = "La Victoria";
            direccion.Direccion = "Calle 3";
            direccion.TipoDireccion = "DireccionCasa";

            return direccion;
        }

        public List<Direcciones> Obtener()
        {
            //CODIGO QUE BUSCA TODOS LAS DIRECCIONES

            return new List<Direcciones>();
        }

        public List<Direcciones> ObtenerPorId_Clientes(int Id_Clientes)
        {
            //CODIGO QUE BUSCA TODOS LAS DIRECCIONES DE UN CLIENTE ESPECIFICO

            //TEMPORAL HARDCODING PARA OBTENER UN CONJUNTO DE DIRECCIONES PARA EL CLIENTE
            var ListadoDirecciones = new List<Direcciones>();

            Direcciones direccion1 = new Direcciones(1)
            {
                Pais = "Paraguay",
                Departamento = "Alto Parana",
                Ciudad = "Ciudad Del Este",
                Barrio = "La Victoria",
                Direccion = "Calle 3",
                TipoDireccion = "DireccionCasa"
            };

            Direcciones direccion2 = new Direcciones(1)
            {
                Pais = "Paraguay",
                Departamento = "Alto Parana",
                Ciudad = "Ciudad Del Este",
                Barrio = "Area 1",
                Direccion = "Calle 5",
                TipoDireccion = "DireccionTrabajo"
            };

            ListadoDirecciones.Add(direccion1);
            ListadoDirecciones.Add(direccion2);

            return ListadoDirecciones;
        }

    }
}
