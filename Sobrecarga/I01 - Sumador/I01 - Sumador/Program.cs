using Entidades;
namespace I01___Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            s1.Sumar(2, 3);
            Console.WriteLine($"La suma de {2} y {5} es {2 + 5}");
            
            s1.Sumar("Hola", " Mundo");
            Console.WriteLine($"Cantidad de sumas de s1: {(int)s1}");

            Sumador s2 = new Sumador(8);
            Console.WriteLine($"Cantidad de sumas de s2: {(int)s2}");

            long sumaCantidadSumas = s1 + s2;
            Console.WriteLine($"La suma de cantidadSumas de s1 y s2 es: {sumaCantidadSumas}");

            bool iguales = s1 | s2;
            Console.WriteLine($"Los sumadores s1 y s2 tienen igual cantidad de sumas: {iguales}");

            //Instanciamos otro objeto
            Sumador s3 = new Sumador();
            s3.Sumar(2, 5);
            Console.WriteLine($"Cantidad de sumas de s1: {(int)s3}");
        }
    }
}