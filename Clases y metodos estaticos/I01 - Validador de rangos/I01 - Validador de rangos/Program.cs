using Entidades;
using System.ComponentModel.DataAnnotations;

namespace I01___Validador_de_rangos
{
    internal class Program
    {
        /* Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
         * bool Validar(int valor, int min, int max)
         * valor: dato a validar.
         * min: mínimo valor incluido.,
         * max: máximo valor incluido.
         * Pedir al usuario que ingrese 10 números enteros. 
         * Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
         * Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
         */
        static void Main(string[] args)
        {
            int max = -100;
            int min = 100;
            int prom = 0;
            int i;

            Console.WriteLine("Hola, Como estas?");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Por favor ingrese un numero: ");

                if(int.TryParse(Console.ReadLine(), out int valorIngresado))
                {
                    if(Validador.Validar(valorIngresado, -100, 100))
                    {
                        max = Maximo(max, valorIngresado);
                        min = Minimo(min, valorIngresado);
                        prom += valorIngresado;
                    }
                    else
                    {
                        Console.WriteLine("Tiene que ser entre -100 y 100");
                        i--;
                    }

                }
                else
                {
                    Console.WriteLine("Error, por favor ingrese un numero valido");
                    i--;
                }
            }
            Mostrar(max, min, (prom / 5));
        }

        /// <summary>
        /// Este Metodo compara el maximo actual con el numero ingresado
        /// </summary>
        /// <param name="max">Valor actual de la variable max</param>
        /// <param name="valorIngresado">Ultimo valor ingresado</param>
        /// <returns>El valor mas alto numericamente</returns>
        public static int Maximo(int max, int valorIngresado)
        {
            int aux = max;
            if (max < valorIngresado)
            {
                aux = valorIngresado;
            }
            return aux;
        }

        /// <summary>
        /// Este Metodo compara el minimo actual con el numero ingresado
        /// </summary>
        /// <param name="min">Valor actual de la variable min</param>
        /// <param name="valorIngresado">Ultimo valor ingresado</param>
        /// <returns>El valor mas bajo numericamente</returns>
        public static int Minimo(int min, int valorIngresado)
        {
            int aux = min;
            if (min > valorIngresado)
            {
                aux = valorIngresado;
            }
            return aux;
        }

        /// <summary>
        /// Este Metodo muestra por consola los valores maximo, minimo y promedio ingresados
        /// </summary>
        /// <param name="max">Valor maximo</param>
        /// <param name="min">Valor minimo</param>
        /// <param name="prom">Promedio</param>
        public static void Mostrar(int max, int min, int prom)
        {
            Console.WriteLine($"El maximo numero ingresado es {max}");
            Console.WriteLine($"El minimo numero ingresado es {min}");
            Console.WriteLine($"El promedio de todos los numeros ingresados es {prom}");
            Console.WriteLine("Muchas Gracias");
        }
    }
}