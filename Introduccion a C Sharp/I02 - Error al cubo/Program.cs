namespace Ejercicio2_2023
{
    public class Program
    {
        /*Ingresar un número y mostrar el cuadrado y el cubo del mismo.
         * Se debe validar que el número sea mayor que cero, caso contrario,mostrar el mensaje: "ERROR. ¡Reingresar número!".
         */
        static void Main(string[] args)
        {
            int valorIngresado;
            bool numerico;
            Console.WriteLine("Hola, Como estas?");
            do
            {
                Console.WriteLine("Por favor ingrese un numero: ");
                numerico = int.TryParse(Console.ReadLine(), out valorIngresado);
                if (numerico && Validador(valorIngresado))
                {
                    Mostrar(valorIngresado);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            } while (!numerico && !Validador(valorIngresado));
        }

        /// <summary>
        /// Funcion para validar que el numero ingresado sea mayor a 0
        /// </summary>
        /// <param name="valorIngresado">Valor ingresado por teclado</param>
        /// <returns>True si es mayor que 0</returns>
        public static bool Validador(int valorIngresado)
        {
            return valorIngresado > 0;
        }

        /// <summary>
        /// Funcion para mostrar el valor ingresado, su cuadrado y su cubo
        /// </summary>
        /// <param name="valorIngresado">Valor ingresado por teclado</param>
        public static void Mostrar(int valorIngresado)
        {
            Console.WriteLine($"El valor ingresado es: {valorIngresado}");
            Console.WriteLine($"El cuadrado de ese valor es: {Math.Pow(valorIngresado, 2)}");
            Console.WriteLine($"El cubo de ese valor es: {Math.Pow(valorIngresado,3)}");
        }
    }
}