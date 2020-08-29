using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace AppRetenProyecto.clases
{
    public class CProxy
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

                Console.WriteLine("Ingrese el PassWord");
                password = Console.ReadLine();

                //Si este password no coincide con el ingresado, se negará el acceso al ususario y no podrán agregarse los datos
                if (password=="cte343")
                {
                    if (oficial == null)
                    {
                        Console.WriteLine("Activando el oficial");
                        oficial = new LoginOficial();
                    }
                    if (pOpcion==1)
                    {
                        Console.WriteLine("Ingrese los datos para almacenar el vehículo");
                        oficial.AgregarVehiculo();
                    }
                    if (pOpcion==2)
                    {
                        Console.WriteLine("Ingrese la causa de la retención");
                        oficial.AgregarCausa();
                    }
                    else
                    {
                        Console.WriteLine("Acceso Denegado");
                    }
                }
            }
        }
        //Clase Protegida por el proxy
        private class LoginOficial
        {
            public void AgregarVehiculo()
            {
                Vehiculo vehiculo3 = new Vehiculo();

                Console.WriteLine("Ingrese el Tipo de Vehículo");
                vehiculo3.tipovehiculo =Console.ReadLine();

                Console.WriteLine("Ingrese el Modelo del Vehículo");
                vehiculo3.modelo = Console.ReadLine();

                Console.WriteLine("Ingrese el color del Vehículo");
                vehiculo3.color = Console.ReadLine();

                Console.WriteLine("Ingrese el año de fabricación del Vehículo");
                vehiculo3.anoDefabricacion = Console.ReadLine();

                Console.WriteLine("Ingrese la placa del Vehículo");
                vehiculo3.numeroDeplaca = Console.ReadLine();

                

            }
            public void AgregarCausa()
            {
                Causa c4 = new Causa();
                Console.WriteLine("Ingrese la causa de la retención");
                c4.motivo = Console.ReadLine();

                Console.ReadKey();
            }
            

        }

    }
    
}

