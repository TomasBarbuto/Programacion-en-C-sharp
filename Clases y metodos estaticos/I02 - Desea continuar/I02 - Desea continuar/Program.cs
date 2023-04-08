
using Entidades;

namespace I02___Desea_continuar
{
    public class Program
    {
        /* Realizar un programa que sume números enteros hasta que 
         * el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)"
         * Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
         * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
         */
        static void Main(string[] args)
        {
            string respuesta;
            int numero;
            int acumulador = 0;
            do
            {
                Console.WriteLine("***Hola Usuario***");
                
                do
                {
                    Console.WriteLine("***Por favor ingrese un numero***");
                    respuesta = Console.ReadLine();
                    if(EsNumero(respuesta, out numero))
                    {
                        acumulador += numero;
                        Console.WriteLine($"***La suma hasta ahora es {acumulador} ***");
                    }
                    {
                        Console.WriteLine("***Error***");
                        Console.WriteLine("--------------");
                    }
                }while(!EsNumero(respuesta, out _));

                Console.WriteLine("¿Desea continuar?");
                respuesta = Console.ReadLine();
            } while (Validador.ValidarRespuesta(respuesta));
        }

        /// <summary>
        /// Metodo para validar si el valor ingresado es un numero
        /// </summary>
        /// <param name="cadena">valor ingresado por teclado</param>
        /// <param name="numero">valor por referencia</param>
        /// <returns>true si se parseo correctamente</returns>
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