using System;
using System.Collections.Generic;
using System.Text;

namespace AppReten.Clases
{
    public class Propietario : DatosPersonales
    {
        private string TipoLicencia;

        public Propietario(string genero, string nombre, string apellido, int edad, string identificacion, string tipoLicencia) : base(genero, nombre, apellido, edad, identificacion)
        {
            TipoLicencia = tipoLicencia;
        }

        public string tipoLicencia
        {
            get { return TipoLicencia; }
            set { TipoLicencia = value; }
        }


    }
}
