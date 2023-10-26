using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatriz2
{
    internal class Class1
    {
        public void ejercicio1() 
        {
            Console.WriteLine("Ingrese los numeros deseados separados por comas de la primera matriz");
            string numeros=Console.ReadLine();
            string[] numeroscadena = numeros.Split(',');
            int cantidad = numeroscadena.Length;
            int[] matrizNumeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                matrizNumeros[i] = int.Parse(numeroscadena[i]);
            }
            Console.WriteLine("Ingrese los numeros deseados separados por comas de la segunda matriz");
            string numeros2 = Console.ReadLine();
            string[] numeroscadena2 = numeros2.Split(',');
            int cantidad2 = numeroscadena2.Length;
            int[] matrizNumeros2 = new int[cantidad2];
            for (int i = 0; i < cantidad2; i++)
            {
                matrizNumeros2[i] = int.Parse(numeroscadena2[i]);
            }

            int[] matrizSuma = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                matrizSuma[i] = matrizNumeros[i] + matrizNumeros2[i];
                Console.WriteLine($"La suma de {matrizNumeros[i]} + {matrizNumeros2[i]} = {matrizSuma[i]}");

            }
        }
    
}
}
