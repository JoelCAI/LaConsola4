using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola4
{
    public class Validador
    {
        
        public static string ValidarString(string mensaje)
        {

            string opcion;
            do
            {
                
                Console.WriteLine(mensaje);
                opcion = Console.ReadLine();
                if (string.IsNullOrEmpty(opcion))
                {
                    Console.Clear();
                    Console.WriteLine(" \nEl valor ingresado no puede ser vacio.");
                    Console.WriteLine(" Por favor ingrese un valor.");
                }
            } while (string.IsNullOrEmpty(opcion));
            return opcion;

        }

        public static string ValidarStringSioNo(string mensaje)
        {

            string opcion;
            
            string mensError = "\n\n Por favor ingrese el valor solicitado";

            Console.WriteLine(mensaje);

            opcion = Console.ReadLine().ToUpper();
            string opcionC = "SI";
            string opcionD = "NO";

            /* validacion = (opcion == opcionA) || (opcion == opcionB);*/

            if (opcion == "" || (opcion != opcionC) & (opcion != opcionD))
            {
                Console.Clear();
                Console.WriteLine(mensError);
                return ValidarStringSioNo(mensaje);
            }
            else
                return opcion;
        }

        public static void VerNombre(string mensaje)
        {

            Console.Clear();
            Console.WriteLine(" \n Usted ingreso la frase: " + mensaje);
  
        }

        public static void VolverMenu()
        {
            Console.WriteLine("\n Presione cualquier tecla para volver al Menú ");
            Console.ReadKey();
        }

        public static int PedirIntMenu(string mensaje, int min, int max)
        {
            int valor;
            bool valido = false;
            string mensajeMenu = "\n Ingrese un valor entre " + min + " y " + max;
            string mensajeError = "\n El valor no puede ser vacio y tiene que estar entre el rango del Menu solicitado. ";

            do
            {

                Console.WriteLine(mensaje);
                Console.WriteLine(mensajeMenu);

                if (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max)
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(mensajeError);
                }
                else
                {
                    valido = true;
                }

            } while (!valido);

            return valor;

        }

    }
}
