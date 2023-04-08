using Geometria;
namespace I05___Prueba_de_geometría
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(10, 5);
            Punto vertice3 = new Punto(20, 10);
            Rectangulo rectangulo = new Rectangulo(vertice1, vertice3);

            Console.WriteLine("Datos del rectangulo:");
            Console.WriteLine("Área: {0}", rectangulo.GetArea());
            Console.WriteLine("Perímetro: {0}", rectangulo.GetPerimetro());
        }
    }
}