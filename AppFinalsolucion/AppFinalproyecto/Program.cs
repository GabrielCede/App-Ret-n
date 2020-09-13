using AppFinalproyecto.clases;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppFinalproyecto
{
    class Program
    {
        static void Main(string[] args)
        {



                                                                  //Fuente de Datos


            //Datos de Personas

            List<Persona> listaPersona = new List<Persona>
            {
                new Persona{ genero="Maculino" , nombre="Erick Eduardo" , apellido="Peralta Sánchez"  , edad=34 , identifacion="1325478456" },
                new Persona{ genero="Femenino" , nombre="Shayna Veronica" , apellido="Negrete Cedeño" , edad=17 , identifacion="1345478456" },
                new Persona{ genero="Masculino" , nombre="Eckerd Gabriel" , apellido="Cedeño Sánchez" , edad=21 , identifacion="0925784598" },

            };

            // Datos de Vehiculos

            List<Vehiculo> listaVehiculo = new List<Vehiculo>
            {
                new Vehiculo{Tipo="Carro" , modelo="Chevrolet" , color="Gris" , anoDeFabricacion= "2018" , numeroDePlaca="GYE-8796" },
                new Vehiculo{Tipo="Moto"  , modelo="Tundra"    , color="Rojo" , anoDeFabricacion= "2017" , numeroDePlaca="GE-4646" },
                new Vehiculo{Tipo="Carro" , modelo="Tesla"     , color="Negro" , anoDeFabricacion= "2012" , numeroDePlaca="GRW-9626" },


            };
           
            //Datos de Causas

            List<Proceso> listaCausa = new List<Proceso>
        {
            new Proceso{ numCausa=1 , motivo= "Falta de licencia de conducir" , gravedad= "Media" , monto= 200 },
            new Proceso{ numCausa=1 , motivo= "Falta de espejos retrovisores" , gravedad= "baja" , monto= 100 },
            new Proceso{ numCausa=2 , motivo= "Falla total de luces"          , gravedad="Baja"   , monto= 100 },
            new Proceso{ numCausa=3 , motivo= "Alcoholemia Positiva"          , gravedad = "Alta" , monto= 500 },
        };





                                                             //Información General


            Console.WriteLine("INFORMACIÓN GENERAL");
                                                        Console.WriteLine("");

            //Consulta de Nombres de los propietarios ordenados alfabeticamente #1

            Console.WriteLine("==== Lista de Propietarios ==== ");

            IEnumerable<Persona> listaPersonaQuery = from persona in listaPersona
                                                     orderby persona.nombre + persona.apellido ascending
                                                     select persona;
            foreach (var persona in listaPersonaQuery)
            {
                Console.WriteLine(persona.nombre +" "+ persona.apellido);
            }
            

                                                         Console.WriteLine("");


            //Modelo de los vehículos ordenados alfabeticamente #2

            Console.WriteLine("==== Vehículos Retenidos   ====");
            IEnumerable<Vehiculo> listaVehiculosQuery = from vehiculo in listaVehiculo
                                                        orderby vehiculo.modelo ascending
                                                        select vehiculo;
           
            //Se ejecuta la consulta

            foreach (var vehiculo in listaVehiculosQuery)

            {
                Console.WriteLine("Modelo : ");
                Console.WriteLine(vehiculo.modelo +" ---" + "Número de Placa : " + vehiculo.numeroDePlaca);
            }

                                                           Console.WriteLine(" ");
            Console.WriteLine("================================");


            //Consulta de Cuántos "Carros" hay retenidos #3

            IEnumerable<Vehiculo> listaVehiculoQuery = from vehiculo in listaVehiculo
                                                       where vehiculo.Tipo == "Carro"
                                                       select vehiculo;
            Console.WriteLine("Cantidad de Carros Retenidos = "+ listaVehiculoQuery.Count());

            //Consulta de Cuántas "Motos" hay retenidas #3

            IEnumerable<Vehiculo> listaVehiCuloQuery = from vehiculo in listaVehiculo
                                                       where vehiculo.Tipo == "Moto"
                                                       select vehiculo;
            Console.WriteLine("Cantidad de Motos Retenidas = " + listaVehiCuloQuery.Count());


            //Mostrar la o las causas más graves que casua la retención del vehículo #4

            IEnumerable<Proceso> listaCausaQuery = from proceso in listaCausa
                                                   where proceso.gravedad == "Alta"
                                                   select proceso;
            //Se ejecuta la consulta

            foreach (var proceso in listaCausaQuery)
            {
                Console.WriteLine("La causa más grave para retener un vehículo es : " + proceso.motivo);
            }

            //Mostrar la cantidad de Menores de edad que se les retuvo el vehículo #5
            IEnumerable<Persona> menorDeEdadQuery = from persona in listaPersona
                                               where persona.edad < 18
                                               select persona;
            Console.WriteLine("Menores de edad con vehículo retenido = " + menorDeEdadQuery.Count() );

            // Mostrar el nombre de las personas menores de edad y su identidicación#6

            var listaPersonasQuery = from persona in listaPersona
                                     where persona.edad< 18
                                     select persona;

            foreach (var persona in listaPersonasQuery)
            {
                    
                    Console.WriteLine("Nombre y Apellido : " + persona.nombre + " "
                        +persona.apellido + " - Identificación : " + persona.identifacion
                        + " Edad : " + persona.edad + " años");
                

            }
            


            Console.WriteLine(" ");
            Console.WriteLine("================================");

            Console.WriteLine("Personal Autorizado");

            //Aplicaciòn del Patron de Diseño Proxy

            Cproxy.ISujeto miProxyS = new Cproxy.ProxySeguro();

            miProxyS.Peticion(1);
            Console.WriteLine("¡Gracias!");

        }
    }
}
