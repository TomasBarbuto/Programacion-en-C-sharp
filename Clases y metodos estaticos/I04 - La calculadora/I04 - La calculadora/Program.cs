using Entidades;

namespace I04___La_calculadora
{
    public class Program
    {
        /* Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
         * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
         * Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
         * El método devolverá el resultado de la operación.
         * Validar (privado): Recibirá como parámetro el segundo operando. 
         * Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
         * Este método devolverá true si el operando es distinto de cero.
         * Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
         * El usuario decidirá cuándo finalizar el programa.
        */
        static void Main(string[] args)
        {
            string cadena;
            double numA;
            double numB;

            Console.WriteLine("***Hola Usuario***");
            do
            {
                do
                {
                    Console.WriteLine("***Por favor ingrese un numero***");
                    cadena = Console.ReadLine();
                    if (!EsNumero(cadena, out numA))
                    {
                        Console.WriteLine("***Error, ingrese un numero valido***");
                    }
                }while(!EsNumero(cadena, out _));

                do
                {
                    Console.WriteLine("***Por favor ingrese otro numero***");
                    cadena = Console.ReadLine();
                    if (!EsNumero(cadena, out numB))
                    {
                        Console.WriteLine("***Error, ingrese un numero valido***");   
                    }
                } while (!EsNumero(cadena, out _));

                do
                {
                    Console.WriteLine("***Ingrese operando (+,-,*,/)***");
                    cadena = Console.ReadLine();
                    if(!ValidarOperador(cadena))
                    {
                        Console.WriteLine("***Error, ingrese un operando valido valido***");
                    }
                }while(!ValidarOperador(cadena));

                Console.WriteLine("");
                Console.WriteLine($"***El resultado es {Calculadora.Calcular(numA,numB,cadena)}***");


                Console.WriteLine("***Presione 'S' si desea realizar otra operacion***");
                cadena = Console.ReadLine();
            } while(cadena.ToUpper() == "S");

        }

        /// <summary>
        /// Metodo para validar si se ingreso un numero
        /// </summary>
        /// <param name="cadena">valor a validar</param>
        /// <param name="numero">numero pasado por referencia</param>
        /// <returns>true si se pude hacer el parse</returns>
        public static bool EsNumero(string cadena, out double numero)
        {
            bool aux = false;
            if (double.TryParse(cadena, out numero))
            {
                aux = true;
            }
            return aux;
        }

        /// <summary>
        /// Metodo para validar el operador
        /// </summary>
        /// <param name="operador">operador ingresado</param>
        /// <returns>true si es un operador valido</returns>
        public static bool ValidarOperador(string operador)
        {
            return operador.Equals("+") || operador.Equals("-") || operador.Equals("*") || operador.Equals("/");
        }
    }
}