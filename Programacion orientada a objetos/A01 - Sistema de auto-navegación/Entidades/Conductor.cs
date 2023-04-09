namespace Entidades
{
    public class Conductor
    {

        private string nombre;
        private int[] kmPorDia = new int[7];

        public Conductor(string nombre)
        { 
            this.nombre = nombre;   
        }

    }
}