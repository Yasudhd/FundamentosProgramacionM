using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;


namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
            le permitirá al usuario, introducir tantas calificaciones como así desee,
            en el momento en que seleccione que no desea continuar capturando
            calificaciones, el algoritmo debe presentar el promedio de las
            calificaciones capturadas previamente.*/

            /*float nota = 0;
            int contador = 0;
            float acumulador = 0;
            char confirmacion = ' ';
            Console.WriteLine("Introducir cuantas notas se desee para luego calcular el promedio");
            do
            {
                Console.WriteLine($"Ingregasar nota numero {contador}");
                nota = int.Parse( Console.ReadLine() );
                acumulador = nota + acumulador;
                Console.WriteLine($"en total llevas {acumulador}");
                Console.WriteLine("Desea continuar agregando notas? (s/n)");
                confirmacion = char.Parse( Console.ReadLine().ToLower());
                contador++;


            } while (confirmacion == 's');

            Console.WriteLine($"El promedio de las notas es:" + (acumulador / contador));*/


            /*Se requiere un algoritmo para mostrar por pantalla los divisores de un
            número ingresado por teclado. 
            Tener en cuenta que dados dos números enteros a y b, se dice que b es
            divisor de a si se cumple que al efectuar una división entera a/ b el
            residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            una división de dos números.
            Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
            2, 1 que son los divisores del número 6.*/

            /*int num = 0;
            int contador = 1;
            Console.WriteLine("Ingresar numero para hallar sus divisores");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
               
                contador++;
                if (num% contador == 0)
                {
                    Console.WriteLine($"El numero: {contador} es divisor del numero: {num}");
                }
                
                
            } while (contador <= num);*/


            /*Dados dos números enteros ingresados por teclado: b que es la base y
            e que es el exponente, se requiere calcular el resultado de la
            potenciación.
            Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
            Mostrar por pantalla el resultado de la potenciación. 
            Seguir pidiendo por teclado la base y el exponente y realizar la
            potenciación correspondiente, hasta que el usuario ingrese por teclado
            el carácter de escape ‘n’*/

            /*int a = 0;
            int b = 0;
            char confirmacion = 'n';

            do
            {
                Console.WriteLine("Ingresar Base B");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar exponente A");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("El resultado es:" + Math.Pow(b, a));

                Console.WriteLine("Desea continuar? (s/n)");
                confirmacion = char.Parse(Console.ReadLine().ToLower());

            } while (confirmacion != 'n');*/

            /*Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
            kilómetros durante 10 días, para determinar si es apto para la prueba de
            5 kilómetros.Para considerarlo apto debe cumplir las siguientes
            condiciones: 
             Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
             Que al menos en una de las pruebas realice un tiempo menor de 15
            minutos.
             Que su promedio sea menor o igual a 18 minutos.
            Diseñar un algoritmo para registrar los datos y decidir si es apto para la
            competencia.*/


            int tiempo = 0;  
            int contador = 0;
            int acumulador = 0;
            float promedio = 0;
            
            Console.WriteLine($"Ingresar tiempo prueba: {contador} ");
            tiempo = int.Parse(Console.ReadLine());
            if ( tiempo < 20 || tiempo < 15 || promedio <= 18 )
            {
            }






        }
    }
}
