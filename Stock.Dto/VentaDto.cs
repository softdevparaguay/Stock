using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Dto
{
    public class VentaDto
    {
        public int Id_Ventas { get; set; }
        public DateTimeOffset? Fecha { get; set; }
        public int Id_Clientes { get; set; }

        private ClienteDto _Cliente;
        public ClienteDto Cliente
        {
            get
            {
                if (_Cliente == null) _Cliente = new ClienteDto();

                return _Cliente;
            }
            set
            {
                _Cliente = value;
            }
        }

    }
}
