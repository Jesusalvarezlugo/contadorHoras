using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contadorHoras.Servicios
{
    /// <summary>
    /// Interfaz que relaciona la implementacion del menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y coge la opcion seleccionada
        /// 31012024-jal
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
    }
}
