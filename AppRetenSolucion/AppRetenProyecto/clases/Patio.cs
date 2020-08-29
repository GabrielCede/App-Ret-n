using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetenProyecto.clases
{
    public class Patio
    {
        public Patio()
        {

        }
        //Nombre del Patio de Retención 
        private string  nombre;

        public string  Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //Ubicación de del Patio de Retención

        private string ubicacion;

        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }



        public List<Vehiculo> ListaDeVehiculo = new List<Vehiculo>();
    }
}
