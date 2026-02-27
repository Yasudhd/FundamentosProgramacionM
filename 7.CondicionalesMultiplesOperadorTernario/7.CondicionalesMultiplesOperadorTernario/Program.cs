using System;
using System.Collections.Generic;


namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* char diaSemana = ' ';
             float tCompra = 0;
             float Descuento = 0;
             Console.WriteLine("Ingresar dia de la semana . l= lunes , m= martes, x= miercoles, j = jueves , v = viernes, s = sabado, d = domingo");
             diaSemana = Char.Parse(Console.ReadLine());
             Console.WriteLine("Ingresar el Total de la compra ");//yikes
             tCompra = Single.Parse(Console.ReadLine());

             switch (diaSemana)//estructura condicional segun el valor que esta en parentesis voy a evaluar una serie de valores en este caso el dia se amana
             {
                 case 'l':// se debe iniciar con caso y se termina con break
                     Descuento = tCompra * 0.1f;
                     Console.WriteLine($"hoy es Lunes, el descuento es de {Descuento}, el total de la compra es de la compra es {tCompra}");
                     break;
                 case 'm':
                     Descuento = tCompra * 0.15f;
                     Console.WriteLine($"Hoy es martes, el descuento es de {Descuento}, el total de la compra es  {tCompra}");
                     break;
                 case 'x':
                     Descuento = tCompra * 0.1f;
                     Console.WriteLine($"Hoy es miercoles, el descuento es de {Descuento}, el total de la compra es de {tCompra}");
                     break;
                 case 'j':
                     Descuento = tCompra * 0.15f;
                     Console.WriteLine($"hoy es jueves, el descuento es de {Descuento}, el total de la compra es de {tCompra}");
                     break;
                 case 'v':
                     Descuento = tCompra * 0.2f;
                     Console.WriteLine($"Hoy es viernes, el descuento es de {Descuento}, el total de la compra es de {tCompra}");
                     break;
                 case 's':
                     Descuento = tCompra * 0.2f;
                     Console.WriteLine($"Hoy es sabado, el descuento es de {Descuento}, el total de la compra es de {tCompra}");
                     break;
                 case 'd':
                     Descuento = 0;
                     Console.WriteLine($"Hoy es domingo, el descuento es de {Descuento}, el total de al compra es de {tCompra}");
                     break;
                 default:
                     Console.WriteLine("Sleccione un dia correcto de la semana");
                     break;
             }*/

            /*float num1 = 0; 
            float num2 = 0;
            string Operacion = "";
            float Suma = 0;
            float Resta = 0;
            float Division = 0;
            float Multiplicacion = 0;
            Console.WriteLine("Ingrese que operacion desea realizar: Suma, Resta, Multiplicación y División");
            Operacion = Convert.ToString(Console.ReadLine().ToLower());//Tolower es un metodo para que acepte las mayusculas en los strings 
            Console.WriteLine("Ingresar primer numero" +Operacion);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (Operacion)
            {
                case "suma":
                   Suma = (num1 + num2);
                    Console.WriteLine($"La suma entre {num1} y {num2} da como resultado {Suma}.");
                    break;
                case "resta":
                    Resta = (num1 - num2);
                    break;
                case "multiplicacion":
                    Multiplicacion = (num1 * num2);
                    Console.WriteLine($"La multiplicacion entre {num1} y {num2} da como resultado {Multiplicacion}");   
                    break;
                case "division":
                    Division = (num1 / num2);
                    Console.WriteLine($"La division entre {num1} y {num2} da como resultado {Division}");
                    break;
                default:
                    Console.WriteLine("Ingresar una de las operaciones disponibles");
                    break;
            }*/
          
            int edad = 0;
            Console.WriteLine("ingresar edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((edad >= 18) ?"Bienvenido a mi sitio web" :"no es apto para el contenido de este sitio web");
        }
    }
}
