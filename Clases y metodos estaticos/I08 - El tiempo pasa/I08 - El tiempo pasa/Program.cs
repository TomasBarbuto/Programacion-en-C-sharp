using System.Globalization;

namespace I08___El_tiempo_pasa
{
    public class Program
    {
        /* Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa 
         * fecha hasta la fecha actual. Tener en cuenta los años bisiestos.
         * Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días 
         * vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.
         * Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("***Hola Usuario***");
            Console.WriteLine("***Ingrese su fecha de nacimiento (formato dd/mm/yyyy)***");
            string fechaNacimientoStr = Console.ReadLine();
            DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int diasVividos = CalcularDiasTranscurridos(fechaNacimiento);

            Console.WriteLine($"***Usted ha vivido {diasVividos} días***");
        }


        /// <summary>
        /// Metodo para contar cantidad de dias vividos
        /// </summary>
        /// <param name="fechaInicio">fecha ingresada por el usuario</param>
        /// <returns>cantidad de dias vividos</returns>
        public static int CalcularDiasTranscurridos(DateTime fechaInicio)
        {
            DateTime fechaActual = DateTime.Today;
            TimeSpan intervalo = fechaActual - fechaInicio;
            int diasTranscurridos = intervalo.Days;

            for (int i = fechaInicio.Year; i <= fechaActual.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    DateTime primerDiaBisiesto = new DateTime(i, 1, 1);
                    if (fechaInicio < primerDiaBisiesto && fechaActual >= primerDiaBisiesto)
                    {
                        diasTranscurridos++;
                    }
                }
            }
            return diasTranscurridos;
        }
    }
}