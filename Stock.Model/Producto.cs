using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public class Producto : ClaseBase
    {

        public Producto()
        {

        }

        public Producto(int Id_Productos)
        {
            this.Id_Productos = Id_Productos;
        }

        public int Id_Productos { get; private set; }

        private string _Nombre;
        public string Nombre
        {
            get 
            {   
                return _Nombre; 
            }
            set { _Nombre = value; }
        }


        public string Descripcion { get; set; }
        public Decimal? Precio { get; set; }

        public override bool Validar()
        {
            var EsValido = true;

            if (string.IsNullOrWhiteSpace(Nombre))
            {
                EsValido = false;
            }

            if (Precio == null)
            {
                EsValido = false;
            }

            return EsValido;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
