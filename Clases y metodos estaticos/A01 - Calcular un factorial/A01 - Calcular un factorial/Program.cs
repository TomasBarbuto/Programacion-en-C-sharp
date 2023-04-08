namespace A01___Calcular_un_factorial
{
    public class Program
    {
        /* El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros
         * positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.
         * En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
        */
        static void Main(string[] args)
        {
            string cadena;
            int numero;
            int factorial;

            Console.WriteLine("***Hola Usuario***");

            do
            {
                Console.WriteLine("***Ingrese el numero que desea sacar el factorial***");
                cadena = Console.ReadLine();
                if (!EsNumero(cadena, out numero))
                {
                    Console.WriteLine("***Error, ingrese un numero valido***");
                }
                if(numero == 0)
                {
                    Console.WriteLine("***Error, debe ser un numero mayor a cero***");
                }
            } while (!EsNumero(cadena, out _) || numero == 0);

            factorial = CalcularFactorial(numero);

            Console.WriteLine($"***El factorial de {numero} es {factorial}***");
        }


        /// <summary>
        /// Metodo para calcular el factorial de un numero
        /// </summary>
        /// <param name="numero">valor a sacar factorial</param>
        /// <returns>el factorial del numero ingresado</returns>
        public static int CalcularFactorial(int numero)
        {
            int aux = 1;
            for (int i = 1; i <= numero; i++)
            {
                aux *= i;
            }
            return aux;
        }

        /// <summary>
        /// Metodo que valida si el numero ingresado por teclado es parseable
        /// </summary>
        /// <param name="cadena">valor a parsear</param>
        /// <param name="numero">valor por referencia</param>
        /// <returns>true si se pudo parsear</returns>
        public static bool EsNumero(string cadena, out int numero)
        {
            bool aux = false;
            if (int.TryParse(cadena, out numero))
            {
                aux = true;
            }
            return aux;
        }
    }
}