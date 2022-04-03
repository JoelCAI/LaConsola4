using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola4
{
    public class Validador
    {
        public static void TeclaEnd(string mensaje)
        {
            
            string opcion = mensaje;
            ConsoleKeyInfo cki;
            string frase;
            Console.TreatControlCAsInput = true;
            Console.Clear();

            string pregunta;
            
            do
            {
                frase = Validador.ValidarString(" \nHola Bienvenido, Ingrese una frase");

                Console.WriteLine("\n" + "Usted Escribió: " + frase);

                pregunta = Validador.ValidarStringSioNo("\n\n Desea escribir mas frases? " +
                                           "\n Si esta seguro de ello escriba *" + "si" + "*" + " sin los asteriscos" +
                                           "\n De lo contrario escriba " + "*" + "no" + "*" + " sin los asteriscos");


            } while (pregunta != "NO");

  
            do
            {
                
                cki = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\nUsted Presiono: ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine(cki.Key.ToString());
                Console.WriteLine(opcion);

            } while (cki.Key != ConsoleKey.End);

            if (cki.Key == ConsoleKey.End)
            {
                Console.Clear();
                Console.WriteLine("Usted presionó la tecla " + "*" + "End" + "*" + " para salir. Hasta Luego");
            }


        }

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

    }
}
