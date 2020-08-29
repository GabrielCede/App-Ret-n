using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetenProyecto
{
    public class Persona
    {
        public Persona()
        {

        }
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

        public List<Persona> ListaDePersona = new List<Persona>();

    }
}
