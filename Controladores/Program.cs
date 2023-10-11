using CalculadoraAritmetica.Servicios;

namespace CalculadoraAritmetica
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicacion
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de entrada a la aplicacion
        /// Contiene el flujo de la aplicacion
        /// 111023 - rpg
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Llamada al metodo. Imprime el mensaje por consola
            MenuInterfaz menuInterfaz = new MenuImplementacion();

            //Variable que controla la entrada y salida del while
            bool cerrarMenu = false;
            //Opcion del usuario
            int opcionElegida;

            while (!cerrarMenu)
            {
                opcionElegida = menuInterfaz.mostrarMenuYSeleccion();
                Console.WriteLine(opcionElegida);

                switch (opcionElegida)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se cierra el menu.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado la operación Sumar. ");
                        
                        Console.WriteLine("Introduzca el primer operando: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduzca el segundo operando: ");
                        double n2 = Convert.ToDouble(Console.ReadLine()); ;

                        double suma;
                        suma = n1 + n2;

                        Console.WriteLine("El resultado de la operacion es: " + suma);
                        
                        break;

                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionado la operación Restar. ");

                        Console.WriteLine("Introduzca el primer operando: ");
                        double n3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduzca el segundo operando: ");
                        double n4 = Convert.ToDouble(Console.ReadLine());

                        double resta;
                        resta = n3 - n4;

                        Console.WriteLine("El resultado de la operacion es: " + resta);
                        
                        break;

                    case 3:
                        Console.WriteLine("[INFO] - Ha seleccionado la operación Multiplicar. ");

                        Console.WriteLine("Introduzca el primer operando: ");
                        double n5 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduzca el segundo operando: ");
                        double n6 = Convert.ToDouble(Console.ReadLine());
                        
                        double multiplicacion;
                        multiplicacion = n5 * n6;

                        Console.WriteLine("El resultado de la operacion es: " + multiplicacion);
                        
                        break;

                    case 4:
                        Console.WriteLine("[INFO] - Ha seleccionado la operación Dividir. ");

                        Console.WriteLine("Introduzca el primer operando: ");
                        double n7 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Introduzca el segundo operando: ");
                        double n8 = Convert.ToDouble(Console.ReadLine());

                        double division;
                        division = n7 / n8;

                        Console.WriteLine("El resultado de la operacion es: " + division);
                        
                        break;
                                          
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}