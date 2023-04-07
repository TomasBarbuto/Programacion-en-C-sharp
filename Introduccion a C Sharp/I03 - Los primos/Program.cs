namespace Ejercicio3_2023
{
    public class Program
    {
        /* Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
        * Validar que el dato ingresado por el usuario sea un número.
        * Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
        * Si ingresa "salir", cerrar la consola.
        * Al finalizar, preguntar al usuario si desea volver a operar.
        * Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
        */
        static void Main(string[] args)
        {
            int numero = 0;
            string cadena = null;
            Console.WriteLine("***Hola Usuario***");

            do
            {
                Console.WriteLine("***Por favor ingrese un numero***");
                cadena = Console.ReadLine();
                if (ValidarNumerico(cadena))
                {
                    numero = int.Parse(cadena);
                }
                for (int i = 0; i < numero; i++)
                {
                    if (EsPrimo(i))
                    {
                        Console.WriteLine($"***El numero {i} es primo***");
                    }
                }
                Console.WriteLine("***Si desea salir oprima la letra 'S'***");
                cadena = Console.ReadLine();

            } while (!Continuar(cadena));
            Environment.Exit(0);
        }

        /// <summary>
        /// Esta funcion toma un string ingresado por teclado y valida que sea numerico
        /// </summary>
        /// <param name="cadena">String ingresado para validar</param>
        /// <returns>True si se pudo parsear o false si no se pudo</returns>
        public static bool ValidarNumerico(string cadena)
        {
            return int.TryParse(cadena, out _);
        }

        /// <summary>
        /// Funcion para validar si ingreso la letra "S"
        /// </summary>
        /// <param name="valor">valor a validar</param>
        /// <returns>true si ingreso S o false si ingreso un valor distinto</returns>
        public static bool Continuar(string valor)
        {
            return valor.ToUpper() == "S";
        }

        /// <summary>
        /// Esta funcion valida si el numero ingresado es numero primo o no
        /// </summary>
        /// <param name="num">Numero a validar</param>
        /// <returns>True si es primo o False si no es un numero primo</returns>
        public static bool EsPrimo(int num)
        {
            bool aux = true;
            if(num <= 1) // 1 no es primo
            {
                aux = false;
            }
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0) // si i divide exactamente a n, entonces n no es primo
                {
                    aux = false;
                }
            }
            return aux; // si llegamos hasta aquí, entonces n es primo
        }
    }
}