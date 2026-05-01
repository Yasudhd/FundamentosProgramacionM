using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.VectoresBidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,]  numeros = new int[2, 3]; // el primer numero son las filas y  el segundo son las colmunas
            numeros[0, 0] = 1;
            numeros[0, 1] = 2;  
            numeros[0, 2] = 3;
            numeros[1,0] = 4;
            numeros[1, 1] = 2;

           
            string[,] nombres =
                                {
                                    {"agf","a"},
                                    {"labubu","e" },//asi se pone la cuestion
                                    {"carrandanga","A" }
                                 };*/

            /*char[,] simbolos = new char[2,5];
            for (int i = 0; i <2 ; i++)//recorre las filas 
            {
                for (int j = 0; j < 5 ; j++)// este va a recorrer las columnas 
                {
                    Console.WriteLine($"Ingresar simbolo para la P({i},{j}): ");
                    simbolos[i, j] = char.Parse(Console.ReadLine());

                }
            }

            //recorrer la matriz para recuperar los datos 

            for (int i = 0; i < simbolos.GetLength(0); i++)//GetLenght(0) obtiene el numero de filas
            {
                for (int j = 0; j <simbolos.GetLength(1); j++)//GetLenght(1) obtiene el numero de columnas 
                {
                    Console.Write(simbolos[i,j] + "|");
               
                }
                    Console.WriteLine();
            }*/
            /* int[,] m1 = new int[2, 3];
             int[,] m2 = new int[2, 3];

             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     Console.WriteLine($"ingresar datos de la matriz#1 en P({i},{j}):");
                   m1[i,j] = int.Parse(Console.ReadLine());

                 }
             }

             for (int i = 0; i < m1.GetLength(0); i++)//GetLenght(0) obtiene el numero de filas
             {
                 for (int j = 0; j < m1.GetLength(1); j++)//GetLenght(1) obtiene el numero de columnas 
                 {
                     Console.Write(m1[i, j] + "|");

                 }
                 Console.WriteLine();
             }
             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     Console.WriteLine($"ingresar datos de la matriz#2 en P({i},{j}):");
                     m2[i, j] = int.Parse(Console.ReadLine());

                 }
             }
             for (int i = 0; i < m1.GetLength(0); i++)//GetLenght(0) obtiene el numero de filas
             {
                 for (int j = 0; j < m1.GetLength(1); j++)//GetLenght(1) obtiene el numero de columnas 
                 {
                     Console.Write(m2[i, j] + "|");

                 }
                 Console.WriteLine();
             }
             Console.WriteLine();
             int[,] suma = new int[2, 3];

             for (int i = 0;i < 2;i++)
             {
                 for(int j = 0;j < 3;j++)
                 {
                     suma[i, j] = m1[i,j] + m2[i,j];
                 }
             }

             Console.WriteLine("El resultado de sumar la matriz#1 con la matriz#2 es: ");
             for (int i = 0; i < suma.GetLength(0); i++)//GetLenght(0) obtiene el numero de filas
             {
                 for (int j = 0; j < suma.GetLength(1); j++)//GetLenght(1) obtiene el numero de columnas 
                 {
                     Console.Write(suma[i, j] + "|");

                 }
                 Console.WriteLine();
             }*/

            string[] nombres = new string[4];
            float[,] sueldos = new float[4,3];
         
            //nombres
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingresar nombre del empleado/a #{i + 1}");
                nombres[i] = Console.ReadLine();

            }
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write(nombres[i] + "|");
               

            }
            Console.WriteLine();
            //sueldos 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingresar sueldo del empleado/a #{i + 1}");
                sueldos[i] = float.Parse(Console.ReadLine());

            }
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write(sueldos[i] + "|");


            }
            Console.WriteLine();
            //numeros
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingresar numero celular del empleado/a #{i + 1}");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + "|");
            }

        }
    }
}
