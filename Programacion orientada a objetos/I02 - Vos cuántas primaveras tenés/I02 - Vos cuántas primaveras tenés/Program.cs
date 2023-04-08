using Entidades;
namespace I02___Vos_cuántas_primaveras_tenés
{
    internal class Program
    {
        /*
         * 
        Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

        Deberá tener los atributos:

        nombre
        fechaDeNacimiento
        dni
        Deberá tener un constructor que inicialice todos los atributos.

        Construir los siguientes métodos para la clase:

        Setter y getter para cada uno de los atributos.
        CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
        Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
        EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
        Instanciar 3 objetos de tipo Persona en el método Main.
        Mostrar quiénes son mayores de edad y quiénes no.
        */
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan Pérez", new DateTime(2008, 5, 15), 12345678);
            Persona persona2 = new Persona("María González", new DateTime(2002, 10, 30), 87654321);
            Persona persona3 = new Persona("Pedro Rodríguez", new DateTime(1975, 1, 1), 45678901);

            Console.WriteLine("Personas:");
            Console.WriteLine(persona1.ShowPersona());
            Console.WriteLine();
            Console.WriteLine(persona2.ShowPersona());
            Console.WriteLine();
            Console.WriteLine(persona3.ShowPersona());
            Console.WriteLine();

            Console.WriteLine("Mayores de edad:");
            if (persona1.IsOlder() == "Es mayor de edad")
            {
                Console.WriteLine(persona1.Name);
            }
            if (persona2.IsOlder() == "Es mayor de edad")
            {
                Console.WriteLine(persona2.Name);
            }
            if (persona3.IsOlder() == "Es mayor de edad")
            {
                Console.WriteLine(persona3.Name);
            }

            Console.WriteLine("Menores de edad:");
            if (persona1.IsOlder() == "Es menor de edad")
            {
                Console.WriteLine(persona1.Name);
            }
            if (persona2.IsOlder() == "Es menor de edad")
            {
                Console.WriteLine(persona2.Name);
            }
        }
    }
}