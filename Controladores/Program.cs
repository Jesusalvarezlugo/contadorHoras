using contadorHoras.Dtos;
using contadorHoras.Servicios;

namespace contadorHoras.Controladores
{
    /// <summary>
    /// Clase que controla el flujo de la aplicación
    /// 31012024-jal
    /// </summary>
    class Program
    {
        /// <summary>
        /// Clase por la que entra y sale el flujo de la aplicacion, donde se llaman a los metodos externos.
        /// 31012024-jal
        /// </summary>
        public static void Main(string[] args)
        {
            MenuInterfaz mi =new MenuImplementacion();
            OperativaInterfaz oi=new OperativaImplementacion();
            List<UsuarioDto> listaUsuarios = new List<UsuarioDto>();
            int opcionS;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionS=mi.mostrarMenuYSeleccion();

                switch (opcionS)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrara el menu");

                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] Se dara de alta a un nuevo usuario");

                        oi.aniadirUsuario(listaUsuarios);

                        foreach(UsuarioDto usuario in listaUsuarios)
                        {
                            Console.WriteLine(usuario.ToString());
                        }

                        break;

                    case 2:
                        Console.WriteLine("[INFO] se añadira mas horas de juego");

                        oi.aniadirHorasJugadas(listaUsuarios);
                        break;

                    case 3:
                        Console.WriteLine("[INFO] Se mostraran los usuarios con las horas reales jugadas.");

                        foreach (UsuarioDto usuario in listaUsuarios)
                        {
                            Console.WriteLine(usuario.ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("[INFO] opcion seleccionada erronea.");
                        break;
                }
            }
        }
    }
}
