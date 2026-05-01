using System;
using System.Collections.Generic;
using System.Security.Policy;


namespace _10.WhileEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.*/
            int num = 0;
            int suma = 0;


            while (num >= 0)
            {
                Console.WriteLine("Ingresar numeros enteros positivos para observar suma");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0)
                {
                    suma = suma + num;
                }
            }
            Console.WriteLine($"La suma total es: {suma}");

        }
    }
}
