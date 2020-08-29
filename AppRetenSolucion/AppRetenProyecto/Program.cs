using AppRetenProyecto.clases;
using System;

namespace AppRetenProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Causas por las que se retienen el vehículo
            Causa c1 = new Causa();
            c1.motivo = "Falta de Licencia de Conducir";
            Causa c2 = new Causa();
            c2.motivo = "Falla Total de Luces";
            Causa c3 = new Causa();
            c3.motivo = "Alcoholemia Positiva";


                                                     //VÉHÍCULOS

            //Creamos el Patio de Retención 
            Patio TransitoReten = new Patio();

            //Datos del Patio
            TransitoReten.Nombre = "Tránsito Retén";
            TransitoReten.Ubicacion = "Los Chillos";
            
            //Lista de los vehículos Retenidos
            TransitoReten.ListaDeVehiculo = new System.Collections.Generic.List<Vehiculo>();
            //Creamos los vehículos con sus respectivos datos
            Vehiculo vehiculo1 = new Vehiculo();
            vehiculo1.tipovehiculo = "Carro";
            vehiculo1.anoDefabricacion = "2017";
            vehiculo1.modelo = "Chevrolet";
            vehiculo1.color = "Gris";
            vehiculo1.numeroDeplaca = "GYE-8796";

            Vehiculo vehiculo2 = new Vehiculo();
            vehiculo2.tipovehiculo = "Carro";
            vehiculo2.anoDefabricacion = "2014";
            vehiculo2.modelo = "Nissan";
            vehiculo2.color = "Rojo";
            vehiculo2.numeroDeplaca = "GRW-9626";

            //Agregamos los vehículos a la lista

            TransitoReten.ListaDeVehiculo.Add(vehiculo1);
            TransitoReten.ListaDeVehiculo.Add(vehiculo2);
            

            Console.WriteLine(" Patio de Retención Vehicular: " + TransitoReten.Nombre);
            Console.WriteLine(" Ubicación: " + TransitoReten.Ubicacion);

            Console.WriteLine("");
            Console.WriteLine("======Lista de Vehículos Retenidos=====");

            foreach (var vehiculo in TransitoReten.ListaDeVehiculo)
            {
                Console.WriteLine("Tipo de Vehículo:");
                Console.WriteLine(vehiculo.tipovehiculo);
                Console.WriteLine("Año de Fabricación:");
                Console.WriteLine(vehiculo.anoDefabricacion);
                Console.WriteLine("Modelo del Vehículo:");
                Console.WriteLine(vehiculo.modelo);
                Console.WriteLine("Color del Vehículo:");
                Console.WriteLine(vehiculo.color);
                Console.WriteLine("Número de Placa:");
                Console.WriteLine(vehiculo.numeroDeplaca);
                Console.WriteLine("**********************");

            }


                                                                 //PERSONAS

            //Creamos Personas
            Persona persona = new Persona();
            //Lista de Personas
                persona.ListaDePersona = new System.Collections.Generic.List<Persona>();

            //Creamos a los propietarios 

                Persona propietario1 = new Persona();

                propietario1.genero = "Maculino";
                propietario1.nombre = "Eckerd Gabriel";
                propietario1.apellido = "Cedeño Sánchez";
                propietario1.edad = 21;
                propietario1.identificacion = "0958156934";


                Persona propietario2 = new Persona();

                propietario2.genero = "Fememino";
                propietario2.nombre = "Linda Verónica";
                propietario2.apellido = "Gutierrez Salavarría";
                propietario2.edad = 23;
                propietario2.identificacion = "0958654934";

            //Añadimos los propietarios a la lista 
                persona.ListaDePersona.Add(propietario1);
                persona.ListaDePersona.Add(propietario2);


            //Lista de Propietarios

                Console.WriteLine("========Lista de Propietarios=========");
                Console.WriteLine("");
                foreach (var personas in persona.ListaDePersona)
                {
                    Console.WriteLine(personas.nombre + " " + personas.apellido);
                    Console.WriteLine(" ");
                }

                                                                //Información

                Console.WriteLine("=========INFORMACIÓN GENERAL==========");

                Console.WriteLine("El vehículo " + vehiculo1.modelo + " con números de placa: " + vehiculo1.numeroDeplaca + " se retuvo a causa de: "+ c1.motivo);
                Console.WriteLine("El vehículo " + vehiculo2.modelo + " con números de placa: " + vehiculo2.numeroDeplaca + " se retuvo a causa de: " + c2.motivo);


            Console.ReadKey();

            //Aplicaciòn del Patron de Diseño Proxy

            CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();

            miProxyS.Peticion(1);
            Console.WriteLine("--------");
            miProxyS.Peticion(2);
            Console.WriteLine("--------");
        }
            

    }
    
}

