using System.Text;

namespace I08___Dibujando_un_triángulo_rectángulo
{
    public class Program
    {
        /*Escribir un programa que imprima por consola un triángulo como el siguiente:
         * *
         * ***
         * *****
         * *******
         * *********
         * El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
         * Para el ejemplo anterior, la altura ingresada fue de 5.
        */
        static void Main(string[] args)
        {
            string cadena;
            int numero;

            Console.WriteLine("***Hola Usuario***");
            do
            {
                Console.WriteLine("***Ingrese la altura del triangulo***");
                cadena = Console.ReadLine();
                if(EsNumero(cadena, out numero))
                {
                    Console.WriteLine("");
                    DibujarTriangulo(numero);
                }
            }while(!EsNumero(cadena, out _));


        }

        /// <summary>
        /// Metodo para dibujar un triangulo en la consola
        /// </summary>
        /// <param name="numero">altura del triangulo</param>
        public static void DibujarTriangulo(int numero)
        {
            for (int i = 0; i < numero; i++)
            {
                // Dibujar los asteriscos de la línea del triángulo
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Nueva línea
            }
        }

        /// <summary>
        /// Metodo para validar si es numero el valor ingresado
        /// </summary>
        /// <param name="cadena">Valor a validar</param>
        /// <param name="numero">Valor a asignar</param>
        /// <returns></returns>
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