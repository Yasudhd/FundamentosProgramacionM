using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Arreglos_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vector
            /*int[] vector = new int[4];
            vector[0] = 67;
            vector[1] = 14;
            vector[2] = 11;
            vector[3] = 1;


            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "|" );
            }*/
            // en caso de tener un indice 4 este estaria por fuera del rango 
            /* int i = 0;
             char confirmacion = ' ';
             string[] nombre = new string[i];
             do
             {
                 Console.WriteLine("Ingresar nombres");
                 nombre[i] = Console.ReadLine();
                 i++;
                 Console.WriteLine("Desea contunuar y/n");
             } while (confirmacion != 'n' );*/
            //otras formas para declarar e inicializar vectores
            /*char[] simbolo = new char[] { 'd', 'a', 'f', '!', '?'};
            float[] notas = { 3.5f, 4.6f, 6.7f };



            //prueba
            int[] numeros = new int[4];
            Console.WriteLine("Ingresar valor x de vector");
            numeros[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar valor y de vector");
            numeros[1] = int.Parse(Console.ReadLine());
            Console.WriteLine($"El punto A({numeros[0]},{numeros[1]})");
            ///////////////////////////
            string[] estudiantes = new string[7];
            //recorrer el vector estudiantes para llenarlo
           
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Ingresar elnombre para la posicion {i + 1} con indice {i}");
                estudiantes[i] = Console.ReadLine();
            }*/

            /* int[] numeros = new int[100];
             for (int i = 0; i < 100; i++)
             {
                 numeros[i] = 10;
                 Console.WriteLine(numeros[i]);
             }*/

            int[] numeros = new int[5]; // podemos colocar numeros mas pequeños para ser mas practicos 
            int mayor = 0;
            int menor = 0;
            int[] posiciones = new int[2];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingresar numero {i +1}");
                numeros[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = numeros[0];
                    menor = numeros[0];
                    posiciones[0] = i;
                    posiciones[1] = i;
                }
                else
                {
                    if (numeros[i] > mayor)
                    {
                        mayor = numeros[i];
                        posiciones[0] = i;

                    }

                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                        posiciones[1] = i;
                    }
                }
            }
            for (int i = 0;i < numeros.Length;i++)
            {
                Console.WriteLine(numeros[i]+ '|');
            }

            
        }
    }
}
