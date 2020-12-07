using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public class Direcciones : ClaseBase
    {
        public Direcciones()
        {

        }

        public Direcciones(int Id_Direcciones)
        {
            this.Id_Direcciones = Id_Direcciones;
        }

        public int Id_Direcciones { get; private set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Barrio { get; set; }
        public string Direccion { get; set; }
        public string TipoDireccion { get; set; }

        public override bool Validar()
        {
            var EsValido = true;

            if (string.IsNullOrWhiteSpace(Pais))
            {
                EsValido = false;
            }

            if (string.IsNullOrWhiteSpace(Departamento))
            {
                EsValido = false;
            }

            return EsValido;
        }
    }
}
