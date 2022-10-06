// See https://aka.ms/new-console-template for more information
using Enunciado_1;
using static System.Console;

var multiplos_3 = new Multiplos_de_3();

WriteLine($"Hay un total de -{multiplos_3.Numeros_multiplos3()}- Multiplos de 3\n");
multiplos_3.posicion_impar();
WriteLine($"\nEl promedio de la suma de los primeros 5 números es de -{multiplos_3.promedio_primeros_5()}-");


