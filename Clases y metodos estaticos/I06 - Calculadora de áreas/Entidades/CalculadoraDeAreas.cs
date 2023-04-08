namespace Entidades
{
    public class CalculadoraDeAreas
    {

        /// <summary>
        /// Metodo que calcula el area de un cuadrado
        /// </summary>
        /// <param name="longitudLado">lado del cuadrado</param>
        /// <returns>area del cuadrado</returns>
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }


        /// <summary>
        /// Metodo que calcula el area de un triangulo
        /// </summary>
        /// <param name="tBase">base del triangulo</param>
        /// <param name="altura">altura del triangulo</param>
        /// <returns>area del triangulo</returns>
        public static double CalcularAreaTriangulo(double tBase, double altura)
        {
            return (tBase * altura) / 2;
        }


        /// <summary>
        /// Metodo para calcular el area de un circulo
        /// </summary>
        /// <param name="radio">radio del circulo</param>
        /// <returns>area del circulo</returns>
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * (radio * 2);
        }
    }
}