using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Enunciado_3.entities
{
    internal class juego
    {
        public string equipo_local { get; set; }
        public string equipo_visitante { get; set; }
        public int goles_local { get; set; }
        public int goles_visitante { get; set; }

        public juego(string juego_equipo_local, string juego_equipo_visitante, int juego_goles_local, int juego_goles_visitantes) => (equipo_local, equipo_visitante, goles_local, goles_visitante) = (juego_equipo_local, juego_equipo_visitante, juego_goles_local, juego_goles_visitantes);


    }

}
