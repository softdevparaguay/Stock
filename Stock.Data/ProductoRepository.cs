using Stock.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Data
{
    public class ProductoRepository
    {

        public bool Grabar()
        {
            //codigo que graba el producto

            return true;
        }

        public Producto Obtener(int Id_Productos)
        {
            Producto producto = new Producto(Id_Productos);

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
