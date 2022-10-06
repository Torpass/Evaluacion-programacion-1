using System;
using System.Collections.Generic;
using System.Security.Principal;
using static System.Console;

namespace Enunciado_1
{
    internal class Multiplos_de_3
    {
        public List<int> Lista_Numeros;

        public Multiplos_de_3()
        {
            Lista_Numeros = new List<int>()
            { 
            618, 22, 621, 85, 747, 494, 230, 108, 76, 551, 883, 79, 925, 
            };
        }
     
        public int Numeros_multiplos3()
        {
            int contador_multiplos_3 = 0;
            foreach (int i in Lista_Numeros)
            {
                if (i % 3 == 0)
                {
                    contador_multiplos_3++;
                }
            }
            return contador_multiplos_3;
        }

        public void posicion_impar()
        {
            for (int i = 1; i < Lista_Numeros.Count; i+=2)
            {
                if (Lista_Numeros[i] % 2 == 0)
                {
                    WriteLine($"\nEn la posición {i} Se encuentra {Lista_Numeros[i]} el cual es par en un posición impar");
                }
            }
        }

        public int promedio_primeros_5()
        {
            int promedio = 0;
            int suma = 0;
            for (int i = 0; i <= 4; i++)
            {
                suma = suma + Lista_Numeros[i];
            }

            promedio = suma / 5;
            return promedio;
        }
     
    }


}
