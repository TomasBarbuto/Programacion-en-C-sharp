using Entidades;

namespace I03___El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Juan", "Pérez", "123");
            Estudiante e2 = new Estudiante("María", "González", "213");
            Estudiante e3 = new Estudiante("Pedro", "Rodríguez", "312");

            e1.SetNotaPrimerParcial(7);
            e1.SetNotaSegundoParcial(8);

            e2.SetNotaPrimerParcial(6);
            e2.SetNotaSegundoParcial(9);

            e3.SetNotaPrimerParcial(3);
            e3.SetNotaSegundoParcial(5);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
        }
    }
}