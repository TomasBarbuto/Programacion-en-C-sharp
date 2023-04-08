namespace I04___Un_número_perfecto
{
    public class Program
    {
        /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
         *(excluido el mismo) que son divisores del número.
         *El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
         *Escribir una aplicación que valide si el numero ingresado es perfecto.
        */
        static void Main(string[] args)
        {
            int valorEntero = 0;
            Console.WriteLine("***Hola Usuario***");
            Console.WriteLine("***Por favor ingrese un numero a continuacion***");
            string entrada = Console.ReadLine();
            if(EsEntero(entrada))
            {
                valorEntero = int.Parse(entrada);
            }
            else
            {
                Console.WriteLine("No se ha ingresado un valor entero");
            }

            if(EsNumeroPerfecto(valorEntero))
            {
                Console.WriteLine(valorEntero + " es un numero perfecto");
            }
            else
            {
                Console.WriteLine(valorEntero + " no es un numero perfecto");
            }
        }

        /// <summary>
        /// Funcion para validar si es un numero perfecto
        /// </summary>
        /// <param name="num">numero a verificar</param>
        /// <returns>true si es un numero perfecto o false si no lo es</returns>
        public static bool EsNumeroPerfecto(int num)
        {
            int suma = 0;
            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    suma += i;
                }
            }
            return suma == num;
        }

        /// <summary>
        /// Funcion para validar si es un numero entero el ingresado
        /// </summary>
        /// <param name="valor">string a validar si parseable</param>
        /// <returns>true si es parseable o false si no es parseable a int</returns>
        public static bool EsEntero(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
    }
}