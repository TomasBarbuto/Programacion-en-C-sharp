using Entidades;

namespace I03___Conversor_binario
{
    public class Program
    {
        /* Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
         * El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.
         * public string ConvertirDecimalABinario(int numeroEntero) {}
         * El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.
         * public int ConvertirBinarioADecimal(string numeroEntero) {}
        */
        static void Main(string[] args)
        {
            // Se pasan dos ejemplos para chequear ambos conversores
            Console.WriteLine(Conversor.ConvertirDecimalABinario(2));
            Console.WriteLine(Conversor.ConvertirBinarioADecimal("1100"));
        }
    }
}