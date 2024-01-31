using contadorHoras.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contadorHoras.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        

        public void aniadirUsuario(List<UsuarioDto> listaAntigua)
        {
            UsuarioDto nuevoUsuario = crearUsuario();

            listaAntigua.Add(nuevoUsuario);
        }

        /// <summary>
        /// Metodo para crear un usuario nuevo
        /// 31012024-jal
        /// </summary>
        /// <returns></returns>
        private UsuarioDto crearUsuario()
        {
            UsuarioDto usuario = new UsuarioDto();

            Console.WriteLine("Introduzca el ID del usuario: ");
            usuario.IdUsuario=Int64.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del usuario: ");
            usuario.Apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca las horas jugadas: ");
            usuario.NumHorasJugadas=Int32.Parse(Console.ReadLine());

            return usuario;
        }

        public void aniadirHorasJugadas(List<UsuarioDto> listaAntigua)
        {
            long idABuscar;
            int cantidadAniadir;

            Console.WriteLine("Introduce el ID del usuario a buscar: ");
            idABuscar= Int64.Parse(Console.ReadLine());

            foreach(UsuarioDto usuario in listaAntigua)
            {
                if (usuario.IdUsuario.Equals(idABuscar))
                {
                    Console.WriteLine("Introduzca cuantas horas desea añadir: ");
                    cantidadAniadir=int.Parse(Console.ReadLine());

                    usuario.NumHorasJugadas = usuario.NumHorasJugadas + cantidadAniadir;
                    break;
                }
                else
                {
                    Console.WriteLine("El usuario no ha sido encontrado.");
                    break;
                }
            }

            


        }
    }
}
