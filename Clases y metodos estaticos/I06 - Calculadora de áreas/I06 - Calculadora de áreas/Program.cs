using Entidades;

namespace I06___Calculadora_de_áreas
{
    public class Program
    {
        /* Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) 
         * que realicen el cálculo del área que corresponda:
         * public double CalcularAreaCuadrado(double longitudLado) {}
         * public double CalcularAreaTriangulo(double base, double altura) {}
         * public double CalcularAreaCirculo(double radio) {}
        */
        static void Main(string[] args)
        {
            string cadena;
            int numero;
            int altura;

            Console.WriteLine("***Hola Usuario***");

            do
            {
                Console.WriteLine("***Por favor seleccione la figura que desea calcular el area***");
                Console.WriteLine("***1 - Triangulo***");
                Console.WriteLine("***2 - Cuadrado***");
                Console.WriteLine("***3 - Circulo***");
                cadena = Console.ReadLine();
                if (!EsNumero(cadena, out numero))
                {
                    Console.WriteLine("***Error, ingrese un numero valido***");
                }
            } while (!EsNumero(cadena, out _));

            switch (numero)
            {
                case 1:
                    {
                        //Triangulo
                        do
                        {
                            Console.WriteLine("***Por favor ingrese la base del triangulo***");
                            cadena = Console.ReadLine();
                            if (!EsNumero(cadena, out numero))
                            {
                                Console.WriteLine("***Error, ingrese un numero valido***");
                            }
                        } while (!EsNumero(cadena, out _));
                        do
                        {
                            Console.WriteLine("***Por favor ingrese la altura del triangulo***");
                            cadena = Console.ReadLine();
                            if (!EsNumero(cadena, out altura))
                            {
                                Console.WriteLine("***Error, ingrese un numero valido***");
                            }
                        } while (!EsNumero(cadena, out _));

                        Console.WriteLine($"***El area del triangulo ingresado es " +
                            $"{CalculadoraDeAreas.CalcularAreaTriangulo(numero,altura)}***");

                        break;
                    }
                case 2:
                    {
                        //Cuadrado
                        do
                        {
                            Console.WriteLine("***Por favor ingrese la longitud del cuadrado***");
                            cadena = Console.ReadLine();
                            if (!EsNumero(cadena, out numero))
                            {
                                Console.WriteLine("***Error, ingrese un numero valido***");
                            }
                        } while (!EsNumero(cadena, out _));

                        Console.WriteLine($"***El area del cuadrado ingresado es " +
                            $"{CalculadoraDeAreas.CalcularAreaCuadrado(numero)}***");

                        break;
                    }
                case 3:
                    {
                        //Circulo
                        do
                        {
                            Console.WriteLine("***Por favor ingrese el radio del circulo***");
                            cadena = Console.ReadLine();
                            if (!EsNumero(cadena, out numero))
                            {
                                Console.WriteLine("***Error, ingrese un numero valido***");
                            }
                        } while (!EsNumero(cadena, out _));

                        Console.WriteLine($"***El area del circulo ingresado es " +
                            $"{CalculadoraDeAreas.CalcularAreaCirculo(numero)}***");

                        break;
                    }
            }

        }

        /// <summary>
        /// Metodo que valida si el numero ingresado es parseable
        /// </summary>
        /// <param name="cadena">valor tomado por teclado para parsear</param>
        /// <param name="numero">valor pasado por referencia</param>
        /// <returns>true si se pudo parsear</returns>
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