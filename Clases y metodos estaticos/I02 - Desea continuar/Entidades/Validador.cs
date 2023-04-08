namespace Entidades
{
    public class Validador
    {

        /// <summary>
        /// Metodo para validar si desea continuar
        /// </summary>
        /// <param name="respuesta">valor ingresado por teclado</param>
        /// <returns>true si es "S"</returns>
        public static bool ValidarRespuesta(string respuesta)
        {
            return respuesta.ToUpper() == "S";
        }
    }
}