using System;
using System.Collections.Generic;

namespace Parcial_1_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            string juegos = "";
            string sala = "";

            Console.WriteLine("Ingresar edad para determinar que sala estara habilitada para el usuario");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 1 && edad <= 5)
            {
                Console.WriteLine("Ahora veamos que sala esta habilitada para el usuario");
                Console.WriteLine("La sala habilitada sera la 1 y los juegos disponibles son: Juego 1 y Juego 5 ");
                Console.WriteLine("Seleccione que juego desea jugar");
                juegos = Convert.ToString(Console.ReadLine());

                if (juegos == "juego 1")
                {
                    Console.WriteLine("La sala asignada a el  usuario es sala 1");
                    Console.WriteLine($"La edad del usuario es {edad}");
                    Console.WriteLine("El juego elegido es Juego 1");
                    Console.WriteLine("El valor a pagar es de $3000");
                }
                if (juegos == "juego 5")
                {
                    Console.WriteLine("La sala asignada a el  usuario es sala 1");
                    Console.WriteLine($"La edad del usuario es {edad}");
                    Console.WriteLine("El juego elegido es Juego 5");
                    Console.WriteLine("El valor a pagar es de $7000");
                }

            }
            else if (edad > 6 && edad <= 16)
            {
                Console.WriteLine("Ahora veamos que sala esta habilitada para el usuario");
                Console.WriteLine("La sala habilitada sera la 2 y los juegos disponibles son: Juego 3 y Juego 6 ");
                Console.WriteLine("Seleccione que juego desea jugar");
                juegos = Convert.ToString(Console.ReadLine());

                if (juegos == "juego 3")
                {
                    Console.WriteLine("La sala asignada a el  usuario es sala 2");
                    Console.WriteLine($"La edad del usuario es {edad}");
                    Console.WriteLine("El juego elegido es Juego 3");
                    Console.WriteLine("El valor a pagar es de $7000");
                }
                else if (juegos == "juego 6")
                {
                    Console.WriteLine("La sala asignada a el  usuario es sala 2");
                    Console.WriteLine($"La edad del usuario es {edad}");
                    Console.WriteLine("El juego elegido es Juego 6");
                    Console.WriteLine("El valor a pagar es de $9000");
                }


            }
            else if (edad > 17 && edad <= 25)
            {
                Console.WriteLine("Ahora veamos que sala esta habilitada para el usuario");
                Console.WriteLine("La sala habilitada sera la 3 y la sala 4, para la sala 4");
                Console.WriteLine("Seleccione que sala desea jugar sala 3 o sala 4");
                sala = Convert.ToString(Console.ReadLine());
                if (sala == "sala 3")
                {
                    Console.WriteLine("Los juegos disponibles son Juego 2 y Juego 7");
                    juegos = Convert.ToString(Console.ReadLine());
                    if (juegos == "juego 2")
                    {

                        Console.WriteLine($"La edad del usuario es {edad}");
                        Console.WriteLine($"La sala del usuario es {sala}");
                        Console.WriteLine("El juego elegido es Juego 2");
                        Console.WriteLine("El valor a pagar es de $5000");
                    }
                    else if (juegos == "juego 7")
                    {
                        Console.WriteLine($"La edad del usuario es {edad}");
                        Console.WriteLine($"La sala del usuario es {sala}");
                        Console.WriteLine("El juego elegido es Juego 7");
                        Console.WriteLine("El valor a pagar es de $10000");
                    }
                    else
                    {
                        Console.WriteLine("Lo siento pero ese juego no esta disponible");
                    }

                }
                else if (sala == "sala 4")
                {
                    Console.WriteLine("Los juegos disponibles son Juego 4 y Juego 8");
                    juegos = Convert.ToString(Console.ReadLine());
                    if (juegos == "juego 4")
                    {
                        Console.WriteLine($"La edad del usuario es {edad}");
                        Console.WriteLine($"La sala del usuario es {sala}");
                        Console.WriteLine("El juego elegido es Juego 4");
                        Console.WriteLine("El valor a pagar es de $9000");
                    }
                    if (juegos == "juego 8")
                    {
                        Console.WriteLine($"La edad del usuario es {edad}");
                        Console.WriteLine($"La sala del usuario es {sala}");
                        Console.WriteLine("El juego elegido es Juego 8");
                        Console.WriteLine("El valor a pagar es de $7000");
                    }
                    else
                    {
                        Console.WriteLine("Lo siento pero ese juego no esta disponible");

                    }
                }

            }
            else if (edad > 26)
            {
                Console.WriteLine("Ahora veamos que sala esta habilitada para el usuario");
                Console.WriteLine("La sala habilitada sera la sala 5 y los juegos disponibles son juego 9 y juego 10");
                juegos = Convert.ToString(Console.ReadLine());
                if (juegos == "juego 9")
                {
                    Console.WriteLine($"La edad del usuario es {edad}");
                    Console.WriteLine("La sala del usuario es sala 5");
                    Console.WriteLine("El juego elegido es Juego 9");
                    Console.WriteLine("El valor a pagar es de $5000");
                }
                if (juegos == "juego 10")
                {
                    Console.WriteLine($"La edad del usuario es {edad}");
                    Console.WriteLine("La sala del usuario es sala 5");
                    Console.WriteLine("El juego elegido es Juego 10");
                    Console.WriteLine("El valor a pagar es de $3000");
                }
                else
                {
                    Console.WriteLine("Lo siento pero ese juego no esta disponible");
                }
            }
            
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}

