using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        public Cuenta(string titular, float cantidad)
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

        public float Cantidad
        {
            get
            {
                return cantidad;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine($"***El titular de la cuenta es {this.titular}***");
            sb.AppendLine($"***La cuenta tiene {this.cantidad}***");

            return sb.ToString();
        }

        public void Ingresar(float ingreso)
        {
            if (cantidad > 0)
            {
                this.cantidad += ingreso;
            }
        }

        public void Retirar(float retiro)
        {
            this.cantidad -= retiro;  
        }
    }
}