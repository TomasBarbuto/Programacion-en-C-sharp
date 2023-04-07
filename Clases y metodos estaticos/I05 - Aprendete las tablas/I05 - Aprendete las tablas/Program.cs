using System.Text;

namespace I05___Aprendete_las_tablas
{
    public class Program
    {
        /* Crear una aplicación de consola que permita al usuario ingresar un número entero.
         * Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación 
         * de ese número en formato string.
         * Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado
         * Mostrar en la consola el resultado.
        */
        static void Main(string[] args)
        {
            string cadena;
            int numero;
            Console.WriteLine("***Hola Usuario***");

            do
            {
                Console.WriteLine("***Ingrese la tabla que desea ver***");
                cadena = Console.ReadLine();

                if (!EsNumero(cadena, out numero))
                {
                    Console.WriteLine("***Error, ingrese un numero valido***");
                }
            }while(!EsNumero(cadena, out _));

            Console.WriteLine(MostrarTabla(numero));

        }

        /// <summary>
        /// Metodo que valida que se ingreso un entero
        /// </summary>
        /// <param name="cadena">valor a parsear</param>
        /// <param name="numero">valor por referencia</param>
        /// <returns>true si se pude parsear</returns>
        public static bool EsNumero(string cadena, out int numero)
        {
            bool aux = false;

            if(int.TryParse(cadena, out numero))
            {
                return true;
            }
            return aux;
        }
        

        /// <summary>
        /// Metodo que genera mediante StringBuilder la tabla de multiplicar
        /// </summary>
        /// <param name="numero">tabla a realizar</param>
        /// <returns>tabla completa</returns>
        public static string MostrarTabla(int numero)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine($"Tabla de multiplicar del numero {numero}:");
            for(int i = 1; i <= 10; i++)
            {
                sb.AppendLine("");
                sb.AppendLine($"{numero} x {i} = {numero * i}");
            }

            return sb.ToString();
        }
    }
}