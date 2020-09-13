using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinalproyecto.clases
{
    public class Cproxy
    {
        //Haremos uso de anidaminetO dentro de la clase 
        //Esto hace que cualquier clase colocada como privada y anidada,solo sea conocida por Cproxy


        //Creamos nuestra interface que tiene solo un metodo que no retorna nada y recibe como parametro un entero (pOpcion).
        //Aunque la interface esté anidada tiene acceso público

        public interface ISujeto
        {
            void Peticion(int pOpcion);

        }
        public class ProxySeguro : ISujeto
        {
            private LoginOficial oficial;
            public void Peticion(int pOpcion)
            {
                string password;

                Console.WriteLine("Ingrese el PassWord para agregar vehículo");
                password = Console.ReadLine();

                //Si este password no coincide con el ingresado, se negará el acceso al ususario y no podrán agregarse los datos
                if (password == "cte343")
                {
                    if (oficial == null)
                    {
                        Console.WriteLine("Activando el oficial");
                        oficial = new LoginOficial();
                    }
                    if (pOpcion == 1)
                    {
                        Console.WriteLine("Ingrese los datos para almacenar el vehículo");
                        oficial.AgregarVehiculo();

                        
                        oficial.AgregarCausa();

                        

                        //if (pOpcion == 2)
                        //{

                        //    Console.WriteLine("Ingrese la causa de la retención");
                        //    oficial.AgregarCausa();
                        //    Console.Read();
                        //}
                    }
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }
            }
        }
        //Clase Protegida por el proxy
        private class LoginOficial
        {
            public void AgregarVehiculo()
            {
                //new Vehiculo { Tipo = Console.ReadLine(), modelo=Console.ReadLine(),color= Console.ReadLine(), anoDeFabricacion= Console.ReadLine(),numeroDePlaca=Console.ReadLine()  };
                
                Vehiculo vehiculo = new Vehiculo();

                Console.WriteLine("INGRESE EL TIPO DE VEHICULO");
                vehiculo.Tipo = Console.ReadLine();

                Console.WriteLine("INGRESE EL MODELO DE VEHICULO");
                vehiculo.modelo = Console.ReadLine();

                Console.WriteLine("INGRESE EL COLOR DE VEHICULO");
                vehiculo.color = Console.ReadLine();

                Console.WriteLine("INGRESE EL AÑO DE FABRICACIÓN DEL VEHICULO");
                vehiculo.anoDeFabricacion = Console.ReadLine();

                Console.WriteLine("INGRESE LA PLACA DEL VEHICULO");
                vehiculo.numeroDePlaca = Console.ReadLine();


            }
            public void AgregarCausa()
            {

                Proceso causa = new Proceso();

                Console.WriteLine("Ingrese la Causa");
                causa.motivo = Console.ReadLine();


            }
        }
                
    }
                
}
