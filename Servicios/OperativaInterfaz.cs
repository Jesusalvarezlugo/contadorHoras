using contadorHoras.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contadorHoras.Servicios
{
    /// <summary>
    /// Interfaz que relaciona con la implementacion de la operativa.
    /// 31012024
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que añade un usuario
        /// 31012024-jal
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void aniadirUsuario(List<UsuarioDto> listaAntigua);

        /// <summary>
        /// Metodo que añade horas de juego
        /// 31012024-jal
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void aniadirHorasJugadas(List<UsuarioDto> listaAntigua);
    }
}
