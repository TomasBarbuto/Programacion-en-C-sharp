using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get
            {
                return titular;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
        }

        public string Mostrar(string titular, int cantidad)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine($"***El titular de la cuenta es {this.titular}***");
            sb.AppendLine($"***La cuenta tiene {this.cantidad}***");

            return sb.ToString();
        }
    }
}