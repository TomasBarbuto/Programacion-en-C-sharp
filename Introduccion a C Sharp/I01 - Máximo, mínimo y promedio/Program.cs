namespace Ejercicio1_2023
{
    public class Program
    {
        /* Ingresar 5 números entre -100 y 100 por consola, guardándolos en una variable escalar. 
        * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
        */
        static void Main(string[] args)
        {
            int max = -100;
            int min = 100;
            int prom = 0;
            int i;

            Console.WriteLine("Hola, Como estas?");
            for(i = 0; i < 5; i++)
            {
                Console.WriteLine("Por favor ingrese un numero: ");

                if(int.TryParse(Console.ReadLine(), out int valorIngresado))
                {
                    max = Maximo(max, valorIngresado);
                    min = Minimo(min, valorIngresado);
                    prom += valorIngresado;
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
        /// Esta funcion compara el maximo actual con el numero ingresado
        /// </summary>
        /// <param name="max">Valor actual de la variable max</param>
        /// <param name="valorIngresado">Ultimo valor ingresado</param>
        /// <returns>El valor mas alto numericamente</returns>
        public static int Maximo(int max, int valorIngresado)
        {
            int aux = max;
            if(max < valorIngresado)
            {
                aux = valorIngresado;
            }
            return aux;
        }

        /// <summary>
        /// Esta funcion compara el minimo actual con el numero ingresado
        /// </summary>
        /// <param name="min">Valor actual de la variable min</param>
        /// <param name="valorIngresado">Ultimo valor ingresado</param>
        /// <returns>El valor mas bajo numericamente</returns>
        public static int Minimo(int min, int valorIngresado)
        {
            int aux = min;
            if(min > valorIngresado)
            {
                aux = valorIngresado;
            }
            return aux;
        }

        /// <summary>
        /// Esta funcion muestra por consola los valores maximo, minimo y promedio ingresados
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