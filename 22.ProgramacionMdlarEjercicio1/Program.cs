using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.ProgramacionMdlarEjercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            int Op = Opcion();
            realizarOperacion(Op);
        }
        static void Menu()
        {
            Console.WriteLine("--------------Menu operaciones--------------");
            Console.WriteLine("1. Suma                   2. Resta");
            Console.WriteLine("3. Multiplicacion         4. Division");
            Console.WriteLine("--------------------------------------------");
        }
        static int Opcion()
        {
            Console.WriteLine("Ingrese una opcion del menu");
            return int.Parse(Console.ReadLine());   
        }
        static void  realizarOperacion(int Op)
        {
            switch (Op)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Restar();
                    break;
                case 3: 
                    Multiplicion();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    break;
            }
        }

        static void Suma()
        {
            Console.WriteLine("Usted va a sumar");

        }
        static void Restar()
        {
            Console.WriteLine("Usted va a restar");

        }
        static void Multiplicion()
        {
            Console.WriteLine("Usted va a multiplica");

        }
        static void Division()
        {
            Console.WriteLine("Usted va a dividir");

        }
    }
}
