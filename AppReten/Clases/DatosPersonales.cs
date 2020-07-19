using System;
using System.Collections.Generic;
using System.Text;

namespace AppReten.Clases
{
    public abstract class DatosPersonales
    {
        // (Masculino o Femenino)
        private string Genero;

        public string genero
        {
            get { return Genero; }
            set { Genero = value; }
        }

        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Apellido;

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }


        private int Edad;

        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        //cèdula de identificacion 
        private string Identificacion;

        public string identificacion
        {
            get { return Identificacion; }
            set { Identificacion = value; }
        }

        public DatosPersonales(string genero, string nombre, string apellido, int edad, string identificacion)
        {
            this.genero = genero;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.identificacion = identificacion;
        }
    }
}
