using System;

namespace _15.CicloFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int acumulador = 0;
            for (int i = 0; i <= 5 ; i++)// i viene siendo lo que es el acumulador 
            {
                acumulador = i + acumulador;
            }
            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");*/

            /*int num = 0;
            int acumulador = 1;
            Console.WriteLine("Ingresar numero para hallar el factorial");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                acumulador *= i;
            }

            Console.WriteLine(acumulador);*/

            int inicio = 0;
            int tope = 0;
            Console.WriteLine("Vamos ahallar los numeros multiplos de 5 en un rango que ud desee:");
            Console.WriteLine("Ingresar el inicio:");
            inicio= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el tope:");
            tope = int.Parse(Console.ReadLine());
            for ( int i = inicio; i <= tope ; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} es multiplo de cinco");
                }
            }
           
        }

    }
}
