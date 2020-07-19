using System;
using AppReten.Clases;

namespace AppReten
{
    class Program
    {
        static void Main(string[] args)
        {
            Patio PatioReten = new Patio ( new System.Collections.Generic.List<Vehiculo>()
            {
                new Vehiculo("Moto", "Rojo", "Cross", "2015", "MDF123"),
                new Vehiculo("Moto", "Negra", "Deportiva", "2016", "MDF456"),
                new Vehiculo("Carro", "Blanco", "Hilux", "2017", "MDF789"),
                new Vehiculo("Carro", "Gris", "Rio", "2018", "MDF128")

            });

            Patio PatioDatos = new Patio(new System.Collections.Generic.List<DatosPersonales>()
            {
                new Oficial ("Maculino", "Tomy", "Anchundia", 22, "1313367789","General"),
                new Oficial ("Maculino", "Arnol", "Trivino", 23, "7895668445","Cabo"),
                new Propietario ("Masculino", "Tyrone", "Anchundia", 18,"468875131", "Tipo C"),
                new Propietario ("Femenino", "Gaby", "Mendoza", 20,"756455778", "Tipo B")

            });

            foreach (Vehiculo item in PatioReten.listaVehiculos)
            {
                Console.WriteLine(item.modelo+ item.tipoDevehiculo);
            }
            Console.ReadKey();

        
        }
    }
}
