using System.Text;

namespace I07___Recibo_de_sueldo
{
    public class Program
    {
        /* Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
         * trabajadas en el mes de N cantidad de empleados de una fábrica.
         * Se pide calcular el importe a cobrar teniendo en cuenta que el total 
         * (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
         * hay que sumarle la cantidad de años trabajados multiplicados por $150, 
         * y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
         * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y 
         * el total a cobrar neto de todos los empleados ingresados.
         * Utilizar sentencias de iteración y selectivas. No es necesario ni se deben utilizar vectores/arrays.
        */
        static void Main(string[] args)
        {
            string nombre;
            string entrada;
            double valorHora = 0;
            int antiguedad = 0;
            int horas = 0;
            double bruto;
            double neto;

            Console.WriteLine("***Hola Usuario***");
            do
            {
                Console.WriteLine("Ingrese nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese valor de la hora trabajada: ");
                entrada = Console.ReadLine();
                if (EsDouble(entrada))
                {
                    valorHora = double.Parse(entrada);
                }
                Console.WriteLine("Ingrese antiguedad del empleado: ");
                entrada = Console.ReadLine();
                if (EsInt(entrada))
                {
                    antiguedad = int.Parse(entrada);
                }
                Console.WriteLine("Ingrese horas trabajadas del empleado: ");
                entrada = Console.ReadLine();
                if (EsInt(entrada))
                {
                    horas = int.Parse(entrada);
                }
                bruto = CalcularSueldo(valorHora, antiguedad, horas);
                neto = (bruto * 0.87);
                Console.WriteLine(Mostrar(nombre, antiguedad, valorHora, bruto, neto));

                Console.WriteLine("***Si desea agregar otro empleado presione 'S' ***");
            } while(Continuar(Console.ReadLine()));



        }

        /// <summary>
        /// Metodo para validar si desea continuar
        /// </summary>
        /// <param name="respuesta">valor ingresado por teclado</param>
        /// <returns>true si presiono 'S'</returns>
        public static bool Continuar(string respuesta)
        {
            return respuesta.ToUpper() == "S";
        }

        /// <summary>
        /// Metodo para validar si es parseable a double el valor ingresado por teclado
        /// </summary>
        /// <param name="cadena">valor a validar</param>
        /// <returns>true si es parseable</returns>
        public static bool EsDouble(string cadena)
        {
            return double.TryParse(cadena, out _);
        }

        /// <summary>
        /// Metodo para validar si el numero ingresado es un int
        /// </summary>
        /// <param name="cadena">valor a validar</param>
        /// <returns>true si es parseable</returns>
        public static bool EsInt(string cadena)
        {
            return int.TryParse(cadena, out _);
        }

        /// <summary>
        /// Metodo para calcular el sueldo
        /// </summary>
        /// <param name="valorHora">valor de la hora</param>
        /// <param name="anios">antiguedad del empleado</param>
        /// <param name="horas">horas trabajadas</param>
        /// <returns>retorna el sueldo bruto</returns>
        public static double CalcularSueldo(double valorHora, int anios, int horas)
        {
            return ((valorHora * horas) + (150 * anios));
        }

        /// <summary>
        /// Metodo para mostrar en forma ordenada los datos del empleado
        /// </summary>
        /// <param name="nombre">nombre del empleado</param>
        /// <param name="anios">antiguedad del empleado</param>
        /// <param name="valorHora">valor de la hora del empleado</param>
        /// <param name="bruto">sueldo bruto</param>
        /// <param name="neto">sueldo neto</param>
        /// <returns>retorna el string</returns>
        public static string Mostrar(string nombre, int anios, double valorHora, double bruto, double neto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Empleado: {nombre}");
            sb.AppendLine($"Antiguedad: {anios}");
            sb.AppendLine($"Valor de hora: {valorHora}");
            sb.AppendLine($"Sueldo bruto: {bruto}");
            sb.AppendLine($"Sueldo neto: {neto}");

            return sb.ToString();
        }
    }
}