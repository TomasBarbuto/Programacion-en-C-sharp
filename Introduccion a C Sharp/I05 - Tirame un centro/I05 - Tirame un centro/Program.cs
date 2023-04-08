using System;

namespace I05___Tirame_un_centro
{
    public class Program
    {
        /* Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números,
         * cuyas sumas son iguales.
         * El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
         * cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, 
         * el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
         * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
         */
        static void Main(string[] args)
        {
            string cadena;
            int numero = 0;

            Console.WriteLine("***Hola Usuario***");


            do
            {
                Console.WriteLine("***Por favor ingrese un numero***");
                cadena = Console.ReadLine();
                if(EsNumero(cadena))
                {
                    numero = int.Parse(cadena);
                    for(int i = 1; i <= numero; i++)
                    {
                        if(EsCentroNumerico(i))
                        {
                            Console.WriteLine($"***El numero {i} es centro numerico***");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("***Error, ingrese un numero valido***");
                }
            } while(true);
        }

        /// <summary>
        /// Funcion que valida que se ingreso un numero por teclado
        /// </summary>
        /// <param name="cadena">valor a validar</param>
        /// <returns>true si es parseable o false si no lo es</returns>
        public static bool EsNumero(string cadena)
        {
            return int.TryParse(cadena, out _);
        }

        /// <summary>
        /// Funcion que valida si el numero ingresado es un centro numerico
        /// </summary>
        /// <param name="numero">valor a validar</param>
        /// <returns>true si es centro numero o false</returns>
        public static bool EsCentroNumerico(int numero)
        {
            int sumaIzquierda = 0;
            int sumaDerecha = 0;

            // Suma los números a la izquierda
            for (int i = 1; i < numero; i++)
            {
                sumaIzquierda += i;
            }

            // Suma los números a la derecha
            for (int i = numero + 1; i <= sumaIzquierda * 2; i++)
            {
                sumaDerecha += i;
                if (sumaDerecha == sumaIzquierda)
                {
                    return true;
                }
            }

            // Si no se encuentra ningún centro numérico, devuelve false
            return false;
        }
    }
}