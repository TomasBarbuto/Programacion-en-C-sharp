using System;

namespace Entidades
{
    // DECLARACION DE LA CLASE
    public class Persona
    {

        private string name;
        private DateTime dateOfBirth;
        private int dni;


        // CONSTRUCTOR
        public Persona(string name, DateTime dateOfBirth, int dni)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.dni = dni;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private int CalculateAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dateOfBirth.Year;
            if (today.Month < dateOfBirth.Month ||
                (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
            {
                age--;
            }
            return age;
        }

        public string ShowPersona()
        {
            int age = CalculateAge();
            return $"Nombre: {name}\nFecha de nacimiento: {dateOfBirth.ToShortDateString()}\nDNI: {dni}\nEdad: {age}";
        }

        public string IsOlder()
        {
            int age = CalculateAge();

            if (age >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }
    }
}