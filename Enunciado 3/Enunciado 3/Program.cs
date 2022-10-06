using static System.Console;
using Enunciado_3.entities;

Console.WriteLine("Hello, World!");

var registro = new Torneo();

registro.pedir_datos_juego();
registro.mostrar_juegos();
WriteLine($"\nCantidad de partidos empatados: {registro.partidos_empatados()}");
registro.mayor_goles_en_conjunto();

WriteLine(registro.participacion_barcelona);
if(registro.participacion_barcelona() == true)
{
    WriteLine("En este torneo participó el FC BARCELONA");
}else WriteLine("");