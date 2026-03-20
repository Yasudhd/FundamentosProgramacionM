using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;
            while (contador <= 99)
            {
                acumulador += contador;
                Console.WriteLine($"contador:{contador} - Suma impares: {acumulador}");
                contador += 2;
            }*/

            /*            int contador = 1;
                        int num = 0;
                        int contadorCeros = 0;
                        int contadorMayorcero = 0;
                        int CantidadNum = 0;
                        int menorCero = 0;
                        Console.WriteLine("Ingresar la cantidad de numeros que va a introducir");// aca controlamos cuantos num debe ingresar el user
                        CantidadNum = Convert.ToInt32(Console.ReadLine());


                        while (contador <= CantidadNum)
                        {
                            Console.WriteLine($"Ingresar el valor del numero: {contador}");
                            num = Convert.ToInt32(Console.ReadLine());

                            if (num == 0)
                            {
                                contadorCeros++;
                            }
                            else
                            {
                                if (num > 0)
                                {
                                    contadorMayorcero++;
                                }
                                else
                                {
                                    menorCero++;
                                }
                            }
                            contador++;
                        }
                        Console.WriteLine($"Los numeros iguales a 0: {contadorCeros}");
                        Console.WriteLine($"Los numeros mayores que 0: {contadorMayorcero}");
                        Console.WriteLine($"Los numeros menores que  0: {menorCero}");*/

            int contador = 1;
            float acumulador = 0;
            float ahorroMes = 0;
            Console.WriteLine("Vamos a observar cuanto a ahorrado este año");
            while (contador <= 12 )
            {
                Console.WriteLine($"Ingresar cuando desea ahorror el mes: {contador}");
                ahorroMes = float.Parse(Console.ReadLine());
                acumulador += ahorroMes;
                Console.WriteLine($"Este ,es usted ahorro: ${ahorroMes}, para el mes {contador}, ud tiene ahorrado ${acumulador}");
                
                contador++;
            }
            Console.WriteLine($"llevas: ${acumulador} ");

        }
    }
}
