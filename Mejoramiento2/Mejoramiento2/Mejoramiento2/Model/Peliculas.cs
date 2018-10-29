using System;
using System.Collections.Generic;
using System.Text;

namespace Mejoramiento2.Model
{
    public class Peliculas
    {
        public String Nombre { get; set; }

        public DateTime FechaEstreno { get; set; }

        public String Genero { get; set; }

        public String Recomendacion { get; set; }

        public int Duracion { get; set; }

        public String Imagen { get; set; }

        public List<Funcion> Funciones { get; set; }
    }
}
