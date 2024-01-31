using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contadorHoras.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("################");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Dar alta usuario");
            Console.WriteLine("2. Añadir horas jugadas");
            Console.WriteLine("3. Mostrar usuarios y horas");
            Console.WriteLine("################");
            Console.WriteLine("Elija una opcion: ");
            opcion=Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
    }
}
