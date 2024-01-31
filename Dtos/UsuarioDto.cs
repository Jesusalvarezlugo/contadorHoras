using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contadorHoras.Dtos
{
    /// <summary>
    /// Clase de la entidad usuario
    /// 31012024-jal
    /// </summary>
    internal class UsuarioDto
    {

        //Atributos

        long idUsuario;
        string nombreUsuario = "aaaaa";
        string apellidos = "aaaaa";
        int numHorasJugadas = 00000;

        

        //Getters y Setters
        public long IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int NumHorasJugadas { get => numHorasJugadas; set => numHorasJugadas = value; }

        //Constructores

        public UsuarioDto()
        {

        } 
        public UsuarioDto(long idUsuario, string nombreUsuario, string apellidos, int numHorasJugadas)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.apellidos = apellidos;
            this.numHorasJugadas = numHorasJugadas;
        }

        //Metodo ToString

        override
        public string ToString()
        {
            string texto = "ID: "+this.idUsuario+"\n NOMBRE: "+this.nombreUsuario+"\n APELLIDOS: "+this.apellidos+"\n Nº HORAS JUGADAS: "+this.numHorasJugadas;
            return texto;
        }

    }
}
