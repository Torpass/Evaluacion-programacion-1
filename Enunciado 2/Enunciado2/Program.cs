using Enunciado2;
using static System.Console;

var caracteres = new letras();

WriteLine($"Hay un total de: {caracteres.cantidad_m()} letras 'M'\n");
caracteres.posicion_letra_k();
WriteLine("\nLa lista al revés quedaría así: ");
caracteres.arreglo_al_reves();