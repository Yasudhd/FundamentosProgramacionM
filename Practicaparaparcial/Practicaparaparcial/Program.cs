using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practicaparaparcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            pantalla la suma de los elementos de cada columna.*/
/*
            int[,] a  = new int[2, 2];
            int[] sumaColumnas = new int[2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Ingresar numero de fila {i + 1} y columna {j + 1} ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "|");
                }
                Console.WriteLine();
            }


            for (int j = 0; j <2; j++)
            {
                sumaColumnas[j] = 0;
                for (int i = 0; i < 2; i++)
                {
                    sumaColumnas[j] +=  a[i, j];
                }
            }


            for (int j = 0; j < sumaColumnas.Length; j++)
            {
                Console.WriteLine("Columna " + (j + 1) + ": " + sumaColumnas[j]);
            }*/

            /*Desarrollar un programa que crea una matriz de n filas *m columnas, el usuario ingresa
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            matriz con el intercambio de filas.*/


           
            
            Console.WriteLine("Ingresar el numero que filas que desea en su matriz");
             int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el numero de columnas que desea en su matriz");
            int columnas = int.Parse(Console.ReadLine());
            int[,] Original = new int[filas , columnas];
            for (int i = 0; i < filas; i++)
            {
               for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingresar numero para fila { i + 1} y columna {j + 1}");
                    Original[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0;i < Original.GetLength(0); i++)
            {
                for (int j = 0; j < Original.GetLength(1); j++)
                {
                    Console.Write(Original[i, j] + "|");
                }
                Console.WriteLine();
            }


            // igualar
            int[,] Nueva = new int[filas , columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Nueva[i, j] = Original[i, j];
                }
            }
            // cambiar
            for (int j = 0; j < columnas; j++)
            {
                int temp = Nueva[0 , j];
                Nueva[0, j] = Nueva[filas - 1, j];
                Nueva[filas - 1, j] = temp;
            }
        }
    }
}
