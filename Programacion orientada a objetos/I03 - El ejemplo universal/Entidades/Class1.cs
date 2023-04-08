using System;
using System.Text;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static readonly Random random = new Random();


        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }
        private float CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public int CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            else
            {
                return 0;
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + nombre);
            sb.AppendLine("Apellido: " + apellido);
            sb.AppendLine("Legajo: " + legajo);
            sb.AppendLine("Nota del primer parcial: " + notaPrimerParcial);
            sb.AppendLine("Nota del segundo parcial: " + notaSegundoParcial);
            sb.AppendLine("Promedio: " + CalcularPromedio());

            int notaFinal = CalcularNotaFinal();

            if (notaFinal != 0)
            {
                sb.AppendLine("Nota final: " + notaFinal);
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }
    }

}
