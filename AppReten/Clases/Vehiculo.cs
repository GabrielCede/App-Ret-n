using System;
using System.Collections.Generic;
using System.Text;

namespace AppReten.Clases
{
    public class Vehiculo
    {
     
       

        //se ingresa si es carro o moto 

        private string TipoDeVehiculo;
        // constructor de la clase.
        public Vehiculo(string tipoDevehiculo, string color, string modelo, string anoDefabricacion, string numeroDeplaca)
        {
            this.tipoDevehiculo = tipoDevehiculo;
            this.color = color;
            this.modelo = modelo;
            this.anoDefabricacion = anoDefabricacion;
            this.numeroDeplaca = numeroDeplaca;
        }

        public string tipoDevehiculo
        {
            get { return TipoDeVehiculo; }
            set { TipoDeVehiculo = value; }
        }


        // cuàl es el color del vehiculo
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
