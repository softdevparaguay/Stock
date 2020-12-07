using System;
using System.Collections.Generic;

namespace Stock.Model
{
    public class Cliente : ClaseBase
    {
        public Cliente()
        {
            ListadoDirecciones = new List<Direcciones>();
        }

        public Cliente(int Id_Clientes) : this()
        {
            this.Id_Clientes = Id_Clientes;
        }

        public static int ContadorDeInstancias { get; set; }

        public List<Direcciones> ListadoDirecciones { get; set; }

        private string _PrimerNombre;
        public string PrimerNombre
        {
            get
            {
                /*
                 * CUALQUIER CODIGO
                 */
                return _PrimerNombre;
            }
            set
            {
                /*
                 * CUALQUIER CODIGO
                 */
                _PrimerNombre = value;
            }
        }

        public string PrimerApellido { get; set; }

        public string Email { get; set; }

        public int Id_Clientes { get; private set; }

        public string NombreCompleto
        {
            get
            {
                string nombreCompleto = PrimerNombre;
                if (!string.IsNullOrWhiteSpace(PrimerApellido))
                {
                    if (!string.IsNullOrWhiteSpace(PrimerNombre))
                    {
                        nombreCompleto += ", ";
                    }
                    nombreCompleto += PrimerApellido;
                }

                return nombreCompleto;
            }
        }

        public int TipoDeCliente { get; set; }

        public override bool Validar()
        {
            var EsValido = true;

            if (string.IsNullOrWhiteSpace(PrimerNombre))
            {
                EsValido = false;
            }

            if (string.IsNullOrWhiteSpace(PrimerApellido))
            {
                EsValido = false;
            }

            return EsValido;
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

    }
}













