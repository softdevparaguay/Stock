using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public class Producto
    {

        public Producto()
        {

        }

        public Producto(int Id_Productos)
        {
            this.Id_Productos = Id_Productos;
        }

        public int Id_Productos { get; private set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal? Precio { get; set; }

        public bool Validar()
        {
            var EsValido = true;

            if (string.IsNullOrWhiteSpace(Nombre))
            {
                EsValido = false;
            }

            if (Precio==null)
            {
                EsValido = false;
            }

            return EsValido;
        }

    }
}
