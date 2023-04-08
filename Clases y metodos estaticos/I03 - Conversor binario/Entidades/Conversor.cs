namespace Entidades
{
    public class Conversor
    {
        /// <summary>
        /// Metodo que convierte un numero decimal a binario
        /// </summary>
        /// <param name="numeroEntero">numero a convertir</param>
        /// <returns>numero binario en string</returns>
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string resultado = "";

            if(numeroEntero == 0)
            {
                resultado = "0";
            }
            while(numeroEntero > 0) 
            {
                int residuo = numeroEntero % 2;
                resultado = residuo.ToString() + resultado;
                numeroEntero /= 2;
            }
            return resultado;
        }

        /// <summary>
        /// Metodo para pasar un numero binario a entero
        /// </summary>
        /// <param name="numeroBinario">numero binario a convertir</param>
        /// <returns>numero entero en formato int</returns>
        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            int resultado = 0;
            int potencia = 1;

            for(int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                if(numeroBinario[i] == '1')
                {
                    resultado += potencia;
                }

                potencia *= 2;
            }

            return resultado;
        }
    }
}