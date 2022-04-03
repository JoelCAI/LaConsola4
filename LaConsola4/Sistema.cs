using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola4
{
    public class Sistema
    {
        
		public void MenuPrincipal()
		{
			Console.Clear();
			int opcion;
			ConsoleKeyInfo cki;
			string frase;

			do
			{
				Console.Clear();
				opcion = Validador.PedirIntMenu("\n Menú del Sistema" +
									   "\n [1] Ingresar Frases." +
									   "\n [2] Salir.", 1, 2);
				switch (opcion)
				{
					case 1:
						{ 
						Console.Clear();
						frase = Validador.ValidarString("\n Bienvenido, Ingrese una frase");
						Validador.VerNombre(frase);
						Validador.VolverMenu();

						}
						break;
	
				}
			} while (opcion != 2);

			Console.Clear();

			do
			{
				Console.WriteLine("Presione la tecla " + "*" + "End" + "*" + " para salir.");
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
			};
		}

		public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
