using System;
using System.Collections.Generic;
using System.Text;

namespace AppReten.Clases
{
    public class Oficial : DatosPersonales
    {
        private string Rango;

        public Oficial(string genero, string nombre, string apellido, int edad, string identificacion, string rango) : base(genero, nombre, apellido, edad, identificacion)
        {
            Rango = rango;
        }

        public string rango
        {
            get { return Rango; }
            set { Rango = value; }
        }

    }   
}
