using System;
using System.Collections.Generic;
using System.Text;

namespace AppReten.Clases
{
    public class Patio
    {

        //constructor
        public Patio(List<Vehiculo> listaVehiculos)
        {
            this.listaVehiculos = listaVehiculos;
           
        }

        public Patio(List<DatosPersonales> listaDatos)
        {
            this.listaDatos = listaDatos;
        }

        private List<Vehiculo> ListaVehiculos;
        public List<Vehiculo> listaVehiculos
        {
            get { return ListaVehiculos; }
            set { ListaVehiculos = value; }
        }

        private List<DatosPersonales> ListaDatos;

        

        public List<DatosPersonales> listaDatos
        {
            get { return ListaDatos; }
            set { ListaDatos = value; }
        }
    }
}
