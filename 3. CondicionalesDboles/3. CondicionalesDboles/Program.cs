using System;

namespace _3.CondicionalesDboles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string nombre = "";
            //    float sueldo = 0;
            //    Console.WriteLine("Ingresar nombre");
            //    nombre = Console.ReadLine();
            //    Console.WriteLine("ingresar sueldo");
            //   sueldo =  Single.Parse(Console.ReadLine());
            //    if (sueldo >= 3000)
            //    {
            //        Console.WriteLine($" El usuario {nombre}, debe abonar impuestos");
            //    }
            //    else
            //    {
            //            Console.WriteLine($"El usuario {nombre} esta excento de impuestos");    
            //    }


            /*float num1 = 0;
            float num2 = 0;
            Console.WriteLine("Ingresar primer numero");
            num1 = Single.Parse (Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Single.Parse (Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("La suma de estos numeros es:"+ (num1 + num2)+ "\n la diferencia de estos numeros es:"+ (num2 - num1));
            }
            else
            {
                Console.WriteLine("el producto de los dos numeros es:"+ (num1 * num2)+ "\n la division del primero respecto al segundo es:"+ (num1 / num2));
            */

            byte num1 = 0;
            Console.WriteLine("Ingresar un numero positivo de 1 o dos digitos");// checar
            num1 =Convert.ToByte( Console.ReadLine());
            if (10 <= num1 && num1<99)
            {
                Console.WriteLine("el numero tiene dos digitos");
            }
            else 
            {
                   Console.WriteLine("tiene un digito");
            }
        }

    }
}
