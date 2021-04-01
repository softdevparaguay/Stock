using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public class Vendedor
    {
        public Vendedor()
        {
            
        }

        public Vendedor(int Id_Vendedores) : this()
        {
            this.Id_Vendedores = Id_Vendedores;
        }

        public int Id_Vendedores { get; private set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
