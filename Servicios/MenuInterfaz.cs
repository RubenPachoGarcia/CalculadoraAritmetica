using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra y recoge la seleccion del usuario
        /// 260923 - rpg
        /// </summary>
        /// <returns>entero con la opcion seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }
}
