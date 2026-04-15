using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerVectores_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] num = new int[15];
            int min = num[0];
            int max = 0;
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"ingresar numero {i +1}");
                num [i] = int.Parse(Console.ReadLine());
                if (num [i] < min )
                {
                    min = num [i];
                }
                else if (num [i] > max )
                {
                    max = num [i];
                }
            }
            Console.WriteLine($"El numero mayor es: {max} y el numero menor es: {min}");*/

            int vR = 0;
            Console.WriteLine("Indicar el numero que letras que desea ingresar");
            vR = int.Parse(Console.ReadLine());
            char[] v1 = new char[vR];
            for (int i = 0; i < vR; i++)
            {
                Console.WriteLine($"ingresar caracter numero {i + 1}");
                v1[i] = char.Parse((Console.ReadLine())); 

            }
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write(v1[i]+ "|");
            }
            for(int i = 0;i < vR; i++)
            {
                v1[i]
            }
            

        }
    }
}
