using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola4
{
    public class Sistema
    {
        public void Saludo()
        {

            Validador.TeclaEnd("Si desea salir presione la tecla " + "*" + "End" + "*" + " para salir.");
        }

        public void Iniciar()
        {
            Saludo();
        }
    }
}
