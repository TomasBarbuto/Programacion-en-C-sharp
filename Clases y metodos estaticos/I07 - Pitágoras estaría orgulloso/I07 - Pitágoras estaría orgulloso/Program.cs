namespace I07___Pitágoras_estaría_orgulloso
{
    public class Program
    {
        /* Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.
         * El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
         * Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
         * Mostrar el resultado en la consola.
        */
        static void Main(string[] args)
        {
            string cadena;
            int baseTri;
            int altura;
            double hipotenusa;

            Console.WriteLine("***Hola Usuario***");
            do
            {
                Console.WriteLine("***Por favor ingrese la base del triangulo (en cm)***");
                cadena = Console.ReadLine();
                if (!EsNumero(cadena, out baseTri))
                {
                    Console.WriteLine("***Error, ingrese un numero valido***");
                }
            } while (!EsNumero(cadena, out _));

            do
            {
                Console.WriteLine("***Por favor ingrese la altura del triangulo (en cm)***");
                cadena = Console.ReadLine();
                if (!EsNumero(cadena, out altura))
                {
                    Console.WriteLine("***Error, ingrese un numero valido***");
                }
            } while (!EsNumero(cadena, out _));

            // Calculo la hipotenusa
            hipotenusa = Math.Sqrt(Math.Pow(baseTri, 2) + Math.Pow(altura, 2));
            Console.WriteLine($"***La hipotenusa es {hipotenusa}***");
        }


        /// <summary>
        /// Metodo para validar si el numero ingresado es parseable
        /// </summary>
        /// <param name="cadena">valor ingresado por teclado</param>
        /// <param name="numero">valor pasado por referencia</param>
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