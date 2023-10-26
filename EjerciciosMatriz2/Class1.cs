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

        //Buscar un elemento ingresado desde el teclado en un arreglo y guardar las posiciones en otro arreglo. Si hay más de una coincidencia, indicar igualmente la posición.

        public void ejercicio2()
        {
            int[] numeros= {4,5,6,3,2,1}; ;
            int[] arreglo= new int[numeros.Length];
            Console.WriteLine("Ingrese un numero a buscar del 1 al 10");
            arreglo[0]=Convert.ToInt32(Console.ReadLine());
            bool centinela=false;
            for(int i=0; i<arreglo.Length; i++) 
            {
                if (arreglo[0] == numeros[i])
                {   
                    centinela=true;
                    Console.WriteLine($"Su numero {arreglo[0]} esta en la posicion {numeros[i]}");
                }
             
            }
            if (centinela == false)
                Console.WriteLine("Su numero no existe");
        }

        //Solicitaremos los IDs (números) de los alumnos de dos clases y los guardaremos en dos arreglos con los nombres 'álgebra' y 'análisis'
        //. Queremos mostrar a todos los alumnos que están inscritos en ambas asignaturas. Estos alumnos se guardarán en un tercer arreglo, el cual se mostrará. También se indicará el número de alumnos que se repiten.
        public void ejercicio3()
        {
            int[] algebra = new int[5];
            int[] analisis = new int[5];
            int[] duales = new int[5];


            Console.WriteLine("Ingrese el ID de los 5 alumnos de Algebra");
            bool centinela = false;
            for (int i = 0; i < algebra.Length; i++)
            {
                
              algebra[i]=Convert.ToInt32(Console.ReadLine());
               

            }


            Console.WriteLine("Ingrese el ID de los 5 alumnos de clase análisis");
           
            for (int i = 0; i < analisis.Length; i++)
            {

                analisis[i] = Convert.ToInt32(Console.ReadLine());
              

            }
            for (int i = 0; i < analisis.Length; i++)
            {

                if (algebra[i] == analisis[i])
                {
                    duales[i] = algebra[i];

                    Console.WriteLine("Los alumnos que coinciden son los del ID " + duales[i]+" ");

                }

            }
            
        }
        //Solicitar por entrada de teclado el tamaño de un arreglo de números y luego ingresar los valores numéricos para llenarlo.
        //Los valores no deben repetirse. Al finalizar, mostrar el contenido del arreglo con los valores ingresados.

        public void ejercicio4()
        {
        
            Console.WriteLine("Ingrese cual desea sea el tamaño de su arreglo Señor");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] arreglo = new int[tamaño];

            Console.WriteLine("Ingrese los numeros");
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i]= Convert.ToInt32(Console.ReadLine());

            }
         Console.WriteLine("Los valores son "+ string.Join(",", arreglo));
        }

        //Dado un arreglo de N notas, cada una en un rango de 0 a 20, calcule el promedio de las notas aprobadas y el promedio de las notas desaprobadas. Además, indique la cantidad de notas aprobadas y desaprobadas en el arreglo. Los rangos son los siguientes:

        //Deficientes 0-5 Regulares 6-10, Buenos 11-15 ,Excelentes 16-20

        public void ejercicio5()
        {

            Console.WriteLine("Ingrese cuantas notas son");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            int total=0;
            int[] arreglo = new int[tamaño];
            int[] arreglo2 = new int[tamaño];
            int promedio=0;
            int deficientes=0, regulares=0, buenos = 0, excelentes = 0;
            Console.WriteLine("Ingrese las notas del 1 al 20");
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > 0 && arreglo[i] <= 5)
                { deficientes++; } 
                else if (arreglo[i] > 5 && arreglo[i] <= 10)
                    regulares++;
                else if (arreglo[i] > 10 && arreglo[i] <= 15)
                    buenos++;
                else if (arreglo[i] > 15 && arreglo[i] <= 20)
                   excelentes++;


            }

            for (int i = 0; i < arreglo.Length; i++)
            {
             promedio += arreglo[i];
                 total = promedio / tamaño;


            }

            Console.WriteLine("su promedio es de " + total);
            Console.WriteLine($"Su total de notas deficientes son {deficientes}, las Regulares {regulares}, las Buenas {buenos} y las Excelentes {excelentes}");
        }
    }
}
