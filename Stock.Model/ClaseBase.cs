using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Model
{
    public abstract class ClaseBase
    {
        public bool EsNuevo { get; set; }
        public bool Modificado { get; set; }
        public EstadoEntidadOpciones EstadoEntidad { get; set; }

        public bool EsValido
        {
            get 
            {
                return Validar();
            }
        }

        public abstract bool Validar();

    }

    public enum EstadoEntidadOpciones
    { 
        Activo,
        Eliminado
    }
}
