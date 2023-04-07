namespace Entidades
{
    public class Calculadora
    {

        /// <summary>
        /// Metodo que realiza la operacion matematica
        /// </summary>
        /// <param name="numA">primer numero</param>
        /// <param name="numB">segundo numero</param>
        /// <param name="operacion">operacion a realizar</param>
        /// <returns></returns>
        public static double Calcular(double numA, double numB, string operacion)
        {
            double resultado = 0.0;
            switch (operacion)
            {
                case "+":
                    {
                        resultado = numA + numB;
                        break;
                    }
                case "-":
                    {
                        resultado = numA - numB;
                        break;
                    }
                case "*":
                    {
                        resultado = numA * numB;
                        break;
                    }
                case "/":
                    {
                        if(Validar(numB))
                        {
                            resultado = numA / numB;
                        }
                        break;
                    }
            }
            return resultado;
        }

        /// <summary>
        /// Metodo que valida que el segundo numero no sea 0 en caso de division
        /// </summary>
        /// <param name="numB">numero a validar</param>
        /// <returns>true si es distinto de 0</returns>
        private static bool Validar(double numB)
        {
            return numB != 0;
        }
    }
}