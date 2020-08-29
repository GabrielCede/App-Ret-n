using System;
using System.Collections.Generic;
using System.Text;

namespace AppRetenProyecto.clases
{
    public class Vehiculo
    {
        public Vehiculo()
        {

        }

        private string TipoVehiculo;

        public string tipovehiculo
        {
            get { return TipoVehiculo; }
            set { TipoVehiculo = value; }
        }

        private string Color;

        public string color
        {
            get { return Color; }
            set { Color = value; }
        }
        // Modelo del vehiculo
        private string Modelo;

        public string modelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }

        //Año de fabricaciòn del vehiculo

        private string AnodeFabricacion;

        public string anoDefabricacion
        {
            get { return AnodeFabricacion; }
            set { AnodeFabricacion = value; }
        }

        //identificaciòn del Vehiculo
        private string NumeroDePlaca;

        public string numeroDeplaca
        {
            get { return NumeroDePlaca; }
            set { NumeroDePlaca = value; }
        }
    }
}
