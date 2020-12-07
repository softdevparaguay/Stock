using Stock.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Data
{
    public class ProductoRepository
    {

        public bool Grabar(Producto producto)
        {
            var OperacionRealizadaConExito = true;

            if (producto.Modificado && producto.EsValido)
            {
                if (producto.EsNuevo)
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

        public Producto Obtener(int Id_Productos)
        {
            Producto producto = new Producto(Id_Productos);

            object MiObjeto = new object();


            Console.WriteLine($"Objeto: {MiObjeto.ToString()}");
            Console.WriteLine($"Producto: {producto.ToString()}");


            producto.Nombre = "Iphone 13";
            producto.Descripcion = "Celular Iphone 13";
            producto.Precio = 2000;

            return producto;
        }

        public List<Producto> Obtener()
        {
            //obtenemos el listado de producto 

            return new List<Producto>();
        }

    }
}
