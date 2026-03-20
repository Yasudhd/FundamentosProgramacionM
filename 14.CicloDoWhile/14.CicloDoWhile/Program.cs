using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _14.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int contadorN = 1;
            int divisores = 0;
            do
            {
                do
                {
                    if (contador % contadorN == 0)
                    {
                        divisores++;

                    }
                    contadorN++;

                } while (contadorN <= contador);
                contadorN = 1;

                if (divisores == 2)
                {
                    Console.WriteLine(contador);

                }
                divisores = 0;
                contador++;



            } while (contador <= 100);*/


            /*string operacion = "";
            float num1 = 0;
            float num2 = 0;
           
            do
            {
                Console.WriteLine("Que operacion desea realizar?: Suma, Resta, Multiplicacion, Division 0  salir en caso de que no desee realizar ninguna operacion");
                operacion = Convert.ToString(Console.ReadLine().ToLower());
                if (operacion == "suma")
                {
                    Console.WriteLine($"La operacion que desea realizar es: {operacion} favor ingresar dos numeros");
                    Console.WriteLine("Numero 1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Numero 2");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"La suma entre {num1} y {num2} es:" + (num1 + num2));
                }
                else
                {
                    if (operacion == "resta")
                    {
                        Console.WriteLine($"La operacion que desea realizar es: {operacion} favor ingresar dos numeros");
                        Console.WriteLine("Numero 1");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Numero 2");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"La resta entre {num1} y {num2} es:" + (num1 - num2));
                    }
                }
                
                if (operacion == "multiplicacion")
                {
                    Console.WriteLine($"La operacion que desea realizar es: {operacion} favor ingresar dos numeros");
                    Console.WriteLine("Numero 1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Numero 2");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"La multiplicacion entre {num1} y {num2} es:" + (num1 * num2));
                }
                else
                {
                    if (operacion == "division")
                    {
                        Console.WriteLine($"La operacion que desea realizar es: {operacion} favor ingresar dos numeros");
                        Console.WriteLine("Numero 1");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Numero 2");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"La division entre {num1} y {num2} es:" + (num1 / num2));
                    }
                }
            } while (operacion != "salir");*/
            int Cd = 0;
            int num = 0;
            int contadorNumero = 1;
            int acumulador = 0;
            Console.WriteLine("Ingresar cuantos numeros desee para determinar cuantos son pares e impares y al finalizar se le calculara un promedio. (Debe escribir finalizar)");
            do
            {
                do
                {
                    Console.WriteLine($"Ingresar numero:{contadorNumero}");
                    num = Convert.ToInt32(Console.ReadLine());
                    contadorNumero++;
                    acumulador = num + acumulador;
                    Cd = Convert.ToInt32(Console.ReadLine());
                } while (Cd <= 5);



            } while (Cd != 0);


        }
    }
}


