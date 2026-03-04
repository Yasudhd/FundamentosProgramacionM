using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.ConstrainedExecution;


namespace TallerPreparacionCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
             numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
             diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
             pantalla los números de menor a mayor.
             Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
             ingresar números diferentes. */


            /*int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Favor ingresar numeros para determinar cual es el mayor y ordenarlos de menor a mayor");
            Console.WriteLine("Ingresar numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar numero 3");
            num3 = Convert.ToInt32(Console.ReadLine()); 

            if (num1 != num2 && num2 != num3 && num1 != num3 )
            {
              if (num1 > num2 && num1 > num3)
              {
                    if (num2 > num3)
                    {
                        Console.WriteLine($"El numero mayor es {num1}");
                        Console.WriteLine($"El orden es {num3}, {num2} y {num1}");
                    }
                    else
                    {
                        Console.WriteLine($"El numero mayor es {num3}");
                        Console.WriteLine($"El orden es {num2},{num3} y {num1}");
                    }
              }
              else if (num1 < num2 && num1 < num3)
              {
                    if (num2 > num3)
                    {
                        Console.WriteLine($"El numero mayor es {num2}");
                        Console.WriteLine($"El orden es {num1}, {num3} y {num2}");
                    }
                    else
                    {
                        Console.WriteLine($"El numero mayor es {num3}");
                        Console.WriteLine($"El orden es {num1}, {num2} y {num3}");
                    }
              }

            }
            else
            {
                Console.WriteLine("Los numeros son iguales favor ingresar numeros diferentes");
            }*/




            /*El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
            cuenta con munición y si se encuentra en estado invencible, crear un programa que: 

            a.Permita ingresar por teclado si el personaje está en estado invencible(True).

            b.La cantidad de munición que tiene el personaje en el momento será calculada por el
            sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. 

            Ejemplo:

            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5 
            Console.WriteLine(numero);

            c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y
            10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
            no hacer nada.*/

            /*bool respuesta = false;
            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 11);
            Console.WriteLine("El personaje esta invencible?  True/False");
            respuesta = Convert.ToBoolean(Console.ReadLine().ToLower());
            Console.WriteLine($"El numero de balas es: {numero}");
            if (respuesta == true)
            {
               if (numero >= 1 && numero <= 10)
               {
                    Console.WriteLine("El personaje esta disparando");
               }
            }
            else
            {
                Console.WriteLine("El personaje no hace nada");
            }*/

            /*
            Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1, y1), 
            P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1 
            P3.La distancia entre dos puntos está dada por la siguiente formula:
            d = √((x2 - x1)² +(y2 - y1)²) 
            Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
            dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
            cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las
            condiciones no se cumplen.*/

            int CoordenadasX = 0;

        }
        
    }
}
