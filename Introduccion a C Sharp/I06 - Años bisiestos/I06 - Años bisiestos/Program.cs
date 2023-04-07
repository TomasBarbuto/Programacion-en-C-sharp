namespace I06___Años_bisiestos
{
    public class Program
    {
        /* Escribir un programa que determine si un año es bisiesto.
         * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
         * salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
         * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
        */
        static void Main(string[] args)
        {
            string inicio;
            string fin;
            int anioInicio = 0;
            int anioFin = 0;

            Console.WriteLine("***Hola Usuario***");

            do
            {
                Console.WriteLine("***ingrese anio de inicio***");
                inicio = Console.ReadLine();
                if(EsAnio(inicio))
                {
                    anioInicio = int.Parse(inicio);
                }
            }while(!EsAnio(inicio));


            do
            {
                Console.WriteLine("***ingrese anio de fin***");
                fin = Console.ReadLine();
                if(EsAnio(fin))
                {
                    anioFin = int.Parse(fin);
                }
            } while(!EsAnio(fin));

            for(int i = anioInicio; i <= anioFin; i++)
            {
                if (EsBisiesto(i))
                {
                    Console.WriteLine($"***El anio {i} es bisiesto***");
                }
            }



        }

        /// <summary>
        /// Funcion que valida si el valor ingresado por teclado es valido como anio
        /// </summary>
        /// <param name="cadena">valor a validar</param>
        /// <returns>true si es valido como anio</returns>
        public static bool EsAnio(string cadena)
        {
            bool aux = false;
            int anio;
            if(int.TryParse(cadena, out anio))
            {
                if(anio >=0 && anio <=9999) 
                {
                    aux = true;
                }

            }
            return aux;
        }

        /// <summary>
        /// Funcion que determina si un anio es bisiesto o no
        /// </summary>
        /// <param name="anio">valor a verificar</param>
        /// <returns>true si es bisiesto o false si no lo es</returns>
        public static bool EsBisiesto(int anio)
        {
            return anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0);
        }
    }
}