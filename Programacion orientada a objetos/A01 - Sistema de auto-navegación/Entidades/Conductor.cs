namespace Entidades
{
    public class Conductor
    {
        private string nombre;
        private int[] kmPorDia;

        public Conductor(string nombre, int[] kmPorDia)
        {
            this.nombre = nombre;
            this.kmPorDia = kmPorDia;
        }
    }
}