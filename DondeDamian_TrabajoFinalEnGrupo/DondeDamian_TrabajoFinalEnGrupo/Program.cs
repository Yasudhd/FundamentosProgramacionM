using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeDamian_TrabajoFinalEnGrupo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------menú----------- \n  1.Gestion de Usuarios \n  2.Gestion de Articulos  \n  3.Gestion de ventas \n  4.Salir del programa \n--------------------------");
            int Eleccion = int.Parse(Console.ReadLine());
            switch (Eleccion)
            {
                case 1:
                    Console.WriteLine("Estas en gestion de usuarios");
                    GestionUser();
                    break;
                case 2:
                    Console.WriteLine("Estas en Gestion de articulos");

                    break;
                case 3:
                    Console.WriteLine("Estas en Gestion de ventas");

                    break;
                case 4:
                    Console.WriteLine("Estas saliendo del programa");

                    break;
                default:
                    break;
            }



        }
        static void GestionUser()
        {
            Console.WriteLine("Menu Gestion de Usuarios: \n 1.Ver Lista de Usuarios \n 2.Ingresar un Nuevo Usuario \n 3.Editar Informacion de Usuario \n 4.Salir de Gestion de Usuarios");
            int  seleccion = int.Parse(Console.ReadLine());
            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado Ver lista de usuarios");
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado Ingresar Nuevo Usuario");
                    break;
                    
                case 3:
                    Console.WriteLine("Has seleccionado Editar Informacon de Usuarios");
                    break;
                    
                case 4:
                    Console.WriteLine("Has seleccionado Salir de Gestion de Usuarios");

                    break;
                default:
                    break;
            }
        }
    }
}
