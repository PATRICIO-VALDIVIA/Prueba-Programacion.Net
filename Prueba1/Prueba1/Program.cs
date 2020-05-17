using System;

namespace Prueba1
{
    class Program
    {
       

    static void Main(string[] args)
     {
            string usuario;
            string contraseña;
            string recubrimiento = "";
            string tipmezcla = "";

     do
     {
          Console.WriteLine("Ingrese usuario: ");
          usuario = Console.ReadLine();
          Console.WriteLine("Ingrese contraseña: ");
          contraseña = Console.ReadLine();

        if (usuario != "admin" || contraseña != "abc123")
         {
             Console.Clear();
             Console.WriteLine("Error!, Ingrese los datos correctos");
         }
         } while (usuario != "admin" || contraseña != "abc123");

            int Menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido!, ¿Que desea? " + "1-Agregar vehiculo " + "2-Ver datos de un vehiculo " + "0-Salir");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresar datos de un vehiculo: ");
                        Console.WriteLine("Marca: ");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Año: ");
                        int año = int.Parse(Console.ReadLine());
                        Console.WriteLine("Kilometraje: ");
                        int kilometraje = int.Parse(Console.ReadLine());
                        Console.WriteLine("ID_Motor: ");
                        int idmotor = int.Parse(Console.ReadLine());
                        Console.WriteLine("¿Cual es su tipo de motor? "  + "1)CUATRO_TIEMPOS "  + "2)DOS_TIEMPOS");
                        int opcionMotor = int.Parse(Console.ReadLine());
                        while (opcionMotor <= 2 && opcionMotor >= 1)
                        {
                            if (opcionMotor == 1)
                            {
                                recubrimiento = "CUATRO_TIEMPOS";
                            }
                            else if (opcionMotor == 2)
                            {
                                recubrimiento = "DOS_TIEMPOS";
                            }
                            else
                            {
                                Console.WriteLine("Error!, ingrese opciones validas");
                                opcionMotor = int.Parse(Console.ReadLine());
                            }
                        }
                        string tipoMotor = Console.ReadLine();
                        Console.WriteLine("Numero de ruedas: ");
                        int numRuedas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Seleccione el tipo de recub.: " + "1: " + TipoRecubrimiento.FENOL +
                        "2: " + TipoRecubrimiento.HULE + "3: " + TipoRecubrimiento.POLIUTERANO);
                        int opcionRecubrimiento = int.Parse(Console.ReadLine());
                        while (opcionRecubrimiento <= 3 && opcionRecubrimiento >= 1)
                        {
                            if (opcionRecubrimiento == 1)
                            {
                                recubrimiento = "FENOL";
                            }
                            else if (opcionRecubrimiento == 2)
                            {
                                recubrimiento = "HULE";
                            }
                            else if (opcionRecubrimiento == 3)
                            {
                                recubrimiento = "POLIUTERANO";
                            }
                            else
                            {
                                Console.WriteLine("Error!, ingrese opciones validas");
                                opcionRecubrimiento = int.Parse(Console.ReadLine());
                            }
                        }
                string tipoRecubrimiento = recubrimiento;
                        Console.WriteLine("Min. durometro: ");
                        int minDurometro = int.Parse(Console.ReadLine());
                        Console.WriteLine("Max. durometro: ");
                        int maxDurometro = int.Parse(Console.ReadLine());
                        Console.WriteLine("Seleccione tipo de mezclador: " + "1-CARBURADOR" + "2-INYECTORES");
                        int opcionMezclador = int.Parse(Console.ReadLine());
                        while (opcionMezclador <= 2 && opcionMezclador >= 1)
                        {
                            if (opcionMezclador == 1)
                            {
                                tipmezcla = "CARBURADOR";
                            }
                            else if (opcionMezclador == 2)
                            {
                                tipmezcla = "INYECTORES";
                            }
                            else
                            {
                                Console.WriteLine("Error!, ingrese opciones validas");
                                opcionRecubrimiento = int.Parse(Console.ReadLine());
                            }
                        }
                        string tipoMezclador = tipmezcla;
                        Console.WriteLine("Su Capacidad es: ");
                        int capacidad = int.Parse(Console.ReadLine());
               
                        Console.ReadKey();
                        break;
                    case 2:
                        string infoAutomovil = string.Format(
                             "Id_motor: \n" +
                             "Tipo_motor: \n" +
                             "Cilindrada:  cc\n" +
                             "N. de ruedas: \n" +
                             "Tipo_recubrimiento: \n" +
                             "Min. durometro: \n" +
                             "Max. durometro: \n" +
                             "Tipo_mezclador: \n" +
                             "Capacidad_estanque:  \n");
                        Console.WriteLine(infoAutomovil);
                        break;
                }
           

                } while(Menu != 0);

            } 
        }
    }
