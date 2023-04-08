using Entidades;

namespace I04___Invento_argentino
{
    public class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine($"Boligrafo azul: color={boligrafoAzul.GetColor()}, tinta={boligrafoAzul.GetTinta()}");
            Console.WriteLine($"Boligrafo rojo: color={boligrafoRojo.GetColor()}, tinta={boligrafoRojo.GetTinta()}");

            Console.WriteLine("Recargando boli azul\n");
            boligrafoAzul.Recargar();
            Console.WriteLine($"color={boligrafoAzul.GetColor()}, tinta={boligrafoAzul.GetTinta()}\n");

            Console.WriteLine("Recargando boli Rojo\n");
            boligrafoRojo.Recargar();
            Console.WriteLine($"color={boligrafoRojo.GetColor()}, tinta={boligrafoRojo.GetTinta()}\n");

            string resultado = boligrafoRojo.Pintar(5, "*");
            Console.WriteLine($"5 unidades con boligrafo rojo...");
            Console.WriteLine($"Resultado: {resultado}, tinta restante: {boligrafoRojo.GetTinta()}");

            resultado = boligrafoAzul.Pintar(10, "*");
            Console.WriteLine($"10 unidades con boligrafo azul...");
            Console.WriteLine($"Resultado: {resultado}, tinta restante: {boligrafoAzul.GetTinta()}");

            resultado = boligrafoRojo.Pintar(7, "*");
            Console.WriteLine($"Intentando pintar 100 unidades con boligrafo rojo...");
            Console.WriteLine($"Resultado: {resultado}, tinta restante: {boligrafoRojo.GetTinta()}");

            Console.ReadLine();



        }
    }
}