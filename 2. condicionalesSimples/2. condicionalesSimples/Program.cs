using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.condicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = "";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine();// es para pedirle datos a usuario pues para que los pueda ingresar desde la consola llega como una cadena de caracteres 
            Console.WriteLine("Ingrese el sueldo del usuario");
            sueldo =Convert.ToSingle (Console.ReadLine());// en este caso habia que convertr el ReadLine() en un tipo de dato float en este caso Single ya que Convierte la representación de cadena especificada de un número en un número de punto flotante de precisión sencilla equivalente, usando la información de formato específica de la referencia cultural indicada.

            if (sueldo >= 3000)
            {
                Console.WriteLine($"El usuario {nombre}, debe abonar impuestos");
            }*/


         
            byte edad = 0;
            Console.WriteLine("Debe ingresar su edad");
            edad= Convert.ToByte (Console.ReadLine());
            if (edad >10 )
            {
                Console.WriteLine("Bienvendoa mi sitio web");
            }


        }
    }
}
