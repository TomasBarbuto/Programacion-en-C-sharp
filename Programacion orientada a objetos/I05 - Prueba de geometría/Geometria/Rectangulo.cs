namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3) 
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            float baseRectangulo = Math.Abs(vertice3.GetX() - vertice1.GetX());
            float alturaRectangulo = Math.Abs(vertice3.GetY() - vertice1.GetY());

            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());

            Console.WriteLine(baseRectangulo);
            Console.WriteLine(alturaRectangulo);
            this.area = baseRectangulo * alturaRectangulo;

            this.perimetro = (2 * baseRectangulo) + (2 * alturaRectangulo);
        }

        public float GetArea()
        {
            return area;
        }

        public float GetPerimetro() 
        {
            return perimetro;
        }


    }
}