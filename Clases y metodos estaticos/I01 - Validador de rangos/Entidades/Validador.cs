namespace Entidades
{
    public static class Validador
    {

        /// <summary>
        /// Metodo que valida si un numero esta entre dos rangos
        /// </summary>
        /// <param name="valor">numero a validar</param>
        /// <param name="min">rango minimo</param>
        /// <param name="max">rango maximo</param>
        /// <returns>true si es valido o false</returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool aux = false;
            if (valor >= min && valor <= max)
            {
                aux = true;
            }
            
            return aux;
        }

    }
}