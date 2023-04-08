using Entidades;
using System;

namespace I01___Creo_que_necesito_un_préstamo
{
    public class Program
    {
        /* Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.
         * Deberá tener los atributos:
         * titular que contendrá la razón social del titular de la cuenta.
         * cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
         * Construir los siguientes métodos para la clase:
         * 
         * Un constructor que permita inicializar todos los atributos.
         * Un método getter para cada atributo.
         * mostrar retornará una cadena de texto con todos los datos de la cuenta.
         * ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
         * retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
         * En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
        */
        static void Main(string[] args)
        {
            Cuenta nuevaCuenta = new Cuenta("Tomas", 23000);
            int opcion;
            float input;
            do
            {
                Console.WriteLine(nuevaCuenta);

                Console.WriteLine("Bievenido al ATM \n" +
                    "1. Ingresar Dinero\n" +
                    "2. Retirar Dinero\n" +
                    "3. Salir");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {

                    switch (opcion)
                    {
                        case 1: //INGRESAR

                            Console.WriteLine("Cuanto Dinero desea Ingresar: ");

                            if (float.TryParse(Console.ReadLine(), out input))
                            {
                                nuevaCuenta.Ingresar(input);
                                Console.WriteLine("Se acredito correctamente");
                            }
                            else
                            {
                                Console.WriteLine("ERROR");
                            }
                            break;

                        case 2: //Retirar

                            Console.WriteLine("Cuanto Dinero desea retirar: ");

                            if (float.TryParse(Console.ReadLine(), out input))
                            {
                                nuevaCuenta.Retirar(input);
                                Console.WriteLine("Se retiro correctamente");
                            }
                            else
                            {
                                Console.WriteLine("ERROR");
                            }
                            break;

                        case 3:

                            Console.WriteLine("Gracias por utilizar el cajero automatico");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingresaste cualquier cosa REY a tu ksa");
                    break;
                }
            } while (opcion != 3);
        }
    }
}