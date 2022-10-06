using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Enunciado2
{
    public class letras
    {
        public char[] lista_letras;
        public letras()
        {
            lista_letras = new char[] 
            {
                'T','M', 'F', 'O', 'Q', 'G', 'H', 'M', 'A', 'K', 'N', 'I', 'M', 'K', 'R'
            };
        }

        public int cantidad_m()
        {
            int contador_m = 0;
            for (int i = 0; i < lista_letras.Length; i++)
            {
                if (lista_letras[i] == 'M')
                {
                    contador_m++;
                }
            }
            return contador_m;
        }

        public void posicion_letra_k()
        {
            for (int i = lista_letras.Length-1; i >= 0; i--)
            {
                if (lista_letras[i] == 'K')
                {
                    WriteLine($"La última posición de la K es: {i}");
                    break;
                }
            }
        }

        public void arreglo_al_reves()
        {
            for (int i = lista_letras.Length - 1; i >= 0; i--)
            {
               Write($"{lista_letras[i]} ");
            }
        }


    }

}
