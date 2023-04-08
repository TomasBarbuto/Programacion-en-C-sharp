namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            short nivelTinta = (short)(this.tinta + tinta);

            if (nivelTinta >= 0 && nivelTinta <= cantidadTintaMaxima)
            {
                this.tinta = nivelTinta;
            }
            else
            {
                Console.WriteLine("No se pudo realizar la carga\n");
            }
        }

        public void Recargar()
        {
            SetTinta((short)(cantidadTintaMaxima - tinta));
        }

        public string Pintar(short gasto, string dibujo)
        {

            short tintaGastada = Math.Min(gasto, tinta);
            SetTinta((short)-tintaGastada);
            Console.ForegroundColor = color;
            return new string('*', tintaGastada) + dibujo;
        }
    }
}