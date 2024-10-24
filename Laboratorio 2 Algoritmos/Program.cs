using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Algoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Main menu.
            do
            {
                Console.Clear();

                Display.MainMenu();
                int input = ExtraFunctions.NumberValidation("Ingresa opción: ");

                switch(input)
                {
                    // Selecion of the exercises.
                    case 0: Environment.Exit(0);break;

                    case 1: Stack_Section.Browser(); break;

                    case 2: Queue_Section.Browser(); break;

                    default: Console.WriteLine("Seleccione una de la opciones"); break;

                }
                Console.ReadKey();
            }while (true);
        }
    }
}
