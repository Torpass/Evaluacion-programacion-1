using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Enunciado_3.entities
{
    internal class Torneo
    {
        public List<juego> juegos_torneo;

        public Torneo()
        {
            juegos_torneo = new List<juego>();
        }

        public void pedir_datos_juego()
        {
            juego auxiliar; 
            agregar_equipo salida = agregar_equipo.si;
            do
            {
                auxiliar = new juego("", "", 0, 0);
                do
                {
                    Write("Nombre del equipo local: ");
                    auxiliar.equipo_local = ReadLine();
                    if (auxiliar.equipo_local == "")
                    {
                        WriteLine("El nombre no puede estar vacio, intente de nuevo");
                    }
                } while (auxiliar.equipo_local == "");

                do
                {
                    Write("Goles del equipo local: ");
                    auxiliar.goles_local = Convert.ToInt16(ReadLine());
                    if (auxiliar.goles_local < 0)
                    {
                        WriteLine("El numero de goles no pueden ser negativos o no puede estar vacio");
                    }

                } while (auxiliar.goles_local < 0);

                do
                {
                    Write("Nombre del equipo visitante: ");
                    auxiliar.equipo_visitante = ReadLine();
                    if (auxiliar.equipo_visitante == "")
                    {
                        WriteLine("El nombre no puede estar vacio, intente de nuevo");
                    }
                } while (auxiliar.equipo_visitante == "");

                do
                {
                    Write("Goles del equipo visitante: ");
                    auxiliar.goles_visitante = Convert.ToInt16(ReadLine());
                    if (auxiliar.goles_visitante < 0)
                    {
                        WriteLine("El numero de goles no pueden ser negativos o no puede estar vacio");
                    }

                } while (auxiliar.goles_visitante < 0);
                juegos_torneo.Add(auxiliar);
                WriteLine("Quieres seguir agregando datos al torneo?\n1)Presione 1 para Seguir\n2)Presione 2 para detener");
                int b = Convert.ToInt16(ReadLine());
                b--;
                salida = (agregar_equipo)b;
            } while (salida == agregar_equipo.si);
        }

        public int partidos_empatados()
        {
            int contador_empatados = 0;
            foreach (juego i in juegos_torneo)
            {
                if (i.goles_visitante == i.goles_local)
                {
                    contador_empatados++;
                }
            }
            return contador_empatados;
        }

        public void mayor_goles_en_conjunto()
        {
            juego partido_goleador = new juego("a","b",0,0);
            foreach(juego i in juegos_torneo)
            {
                if (partido_goleador.goles_local + partido_goleador.goles_visitante <= i.goles_local + i.goles_visitante)
                {
                    partido_goleador = i;
                }
            }
            WriteLine($"El partido con mas goles fué el de {partido_goleador.equipo_local} contra {partido_goleador.equipo_visitante}");
            WriteLine($"Con un total de {partido_goleador.goles_local + partido_goleador.goles_visitante} goles");
            WriteLine($"De los cuales {partido_goleador.goles_local} fueron de {partido_goleador.equipo_local}");
            WriteLine($"Y {partido_goleador.goles_visitante} fueron de {partido_goleador.equipo_visitante}\n");
        }

        public bool participacion_barcelona()
        {
            foreach (juego i in juegos_torneo)
            {
                if ((i.equipo_visitante == "barcelona fc") || (i.equipo_local== "Barcelona fc") ||(i.equipo_visitante == "Barcelona fc") || (i.equipo_local == "barcelona fc"))
                {
                    return true;
                }
            }
            return false;
        }

        public void mostrar_juegos()
        {
            WriteLine("Todos los juegos registrados: ");
            foreach(juego i in juegos_torneo)
            {
                WriteLine("-----------------------------------------");
                WriteLine($"{i.equipo_local} contra {i.equipo_visitante}");
                WriteLine("-----------------------------------------");
            }
        }
    }
}
