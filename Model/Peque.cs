using System;
using System.Collections.Generic;


namespace Model
{
    public class Peque
    {
        private int id;
        private string nombre;
        private string apellidos;
        private DateTime fechaNacimiento;
        private string direccion;
        private string reyFavorito;
        private List<String> regalos;
        private Boolean bueno;
        private static int contador = 1;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string ReyFavorito { get => reyFavorito; set => reyFavorito = value; }
        public List<string> Regalos { get => regalos; set => regalos = value; }
        public bool Bueno { get => bueno; set => bueno = value; }
        public int Id { get => id; set => id = value; }


        public Peque(string nombre, string apellidos, DateTime fechaNacimiento, string direccion, string reyFavorito, List<string> regalos, bool bueno)
        {
            this.id = contador;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.reyFavorito = reyFavorito;
            this.regalos = regalos;
            this.bueno = bueno;
            contador++;
        }

        public Peque()
        {
            this.id = contador;
            this.nombre = "";
            this.apellidos = "";
            this.fechaNacimiento = new DateTime();
            this.direccion = "";
            this.reyFavorito = "";
            this.regalos = new List<String>();
            this.bueno = true;
            contador++;
        }

        // Devuelve la edad en int calculada a partir de la fecha actual
        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad =  fechaActual.Year - this.fechaNacimiento.Year;

            return edad;

        }

    }
}
