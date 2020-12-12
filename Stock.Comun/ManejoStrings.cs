using System;

namespace Stock.Comun
{
    public class ManejoStrings
    {
        public string ColocarEspacios(string Origen)
        {
            string Retorno = string.Empty;

            if (!string.IsNullOrWhiteSpace(Origen))
            {
                foreach (char Letra in Origen)
                {
                    if (char.IsUpper(Letra))
                    {
                        //Eliminamos cualquier espacio que ya 
                        //esté en el string de Retorno
                        Retorno = Retorno.Trim();

                        Retorno += " ";
                    }

                    Retorno += Letra;
                }

                Retorno = Retorno.Trim();
            }

            return Retorno;
        }
    }
}
