using System;
using System.Collections;
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

            /*int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            int x3 = 0;
            int y3 = 0;
            float d1 = 0;// distancia 1
            float d2 = 0;
            float d3 = 0;
            Console.WriteLine("Vamos con el primer punto");
            Console.WriteLine("Ingresar la coordenada en X");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar la  coordenada en y");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vamos con el segundo punto");
            Console.WriteLine("Ingresar la  coordenada en X");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar la  coordenada en X");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vamos con el tercer punto");
            Console.WriteLine("Ingresar la  coordenada en X");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar la  coordenada en X");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ahora veamos las distancias entre los puntos P1 a P2 , P2 a P3 y P1 a P3");

            d1 = (float)Math.Sqrt(Math.Pow(x2- x1, 2)+ Math.Pow(y2- y1, 2));// el (Float) pues lo convierte en float 
            d2 = (float)Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            d3 = (float)Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            Console.WriteLine($"La distancia de P1 a P2 es:{d1}, la distancia de P2 a P3 es:{d2} y la distancia de P1 a P3 es:{d3}");
            //ahora para decidir si  es posible construir un triangulo 
            if (d1 + d2 > d3 && d1 + d3 > d2 && d2 + d3 > d1)
            {
                Console.WriteLine("Se puede formar un triangulo");
            }
            else
            {
                Console.WriteLine("No se puede formar un triangulo");
            }*/

            /*El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha), 
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
             Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
            derecha
             Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
             En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
            dirección”*/

            /*char tecla = ' ';
            Console.WriteLine("Ingresar  el movimiento que desea realizar Izquierda: A o Derecha: D ");
            tecla = Convert.ToChar(Console.ReadLine().ToLower());
            switch (tecla)
            {
                case 'd':
                    Console.WriteLine("El personaje se mueve a la derecha");
                    break;
                case 'a':
                    Console.WriteLine("El personaje se mueve a la izquierda");
                    break;
                default:
                    Console.WriteLine("El pesonaje no se mueve hacia esa direccion");
                    break;
            }*/

            /*El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
            el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
             Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje. 
            (Función Random)
             Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego.En
            caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
            ninguna acción”.*/

            Random random = new Random();
            int vidas = random.Next(0, 6); // genera entre 0 y 5
            char accion;

            Console.WriteLine("El personaje tiene: " + vidas + " vidas");

            if (vidas > 0)
            {
                Console.WriteLine("Ingrese una accion (a = atacar, s = saltar, d = defender): ");
                accion = Convert.ToChar(Console.ReadLine());

                if (accion == 'a')
                {
                    Console.WriteLine("El personaje ataca");
                }
                else if (accion == 's')
                {
                    Console.WriteLine("El personaje salta");
                }
                else if (accion == 'd')
                {
                    Console.WriteLine("El personaje se defiende");
                }
                else
                {
                    Console.WriteLine("Accion no valida");
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas y no puede realizar ninguna accion");
            }
        }



    }

    
}
