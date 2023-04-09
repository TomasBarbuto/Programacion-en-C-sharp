namespace Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public void Sumar(long a, long b)
        {
            cantidadSumas++;
        }

        public void Sumar(string a, string b)
        {
            cantidadSumas++;
            Console.WriteLine($"La suma de los string sera: {a + b}");
        }

        // Conversión explícita que retorna cantidadSumas
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        // Sobrecarga del operador + para sumar los atributos cantidadSumas de dos objetos Sumador
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (long)s1.cantidadSumas + (long)s2.cantidadSumas;
        }

        // Sobrecarga del operador | para verificar que dos datos de tipo Sumador sean iguales.
        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }
    }
}