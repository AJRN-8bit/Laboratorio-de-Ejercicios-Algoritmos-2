using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Algoritmos
{
    public class Display
    {
        public static void MainMenu()
        {
            Console.WriteLine("--- LABORATORIO DE ESTRUCTURAS ---");
            Console.WriteLine();
            Console.WriteLine("Selecciona un tipo de Estructura para usar los ejercicios.");
            Console.WriteLine("[1] Estructura de Pilas");
            Console.WriteLine("[2] Estructura de Colas");
            Console.WriteLine("[0] Cerrar programa");
            Console.WriteLine();
        }

        public static void StackMenu()
        {
            Console.WriteLine("--- Pilas ---");
            Console.WriteLine();
            Console.WriteLine("Selecciona un ejercicio:");
            Console.WriteLine();
            Console.WriteLine("[1] Evaluación de una Expresión Postfija.");
            Console.WriteLine("[2] Invertir una Cadena de Texto.");
            Console.WriteLine("[3] Convertor de Decimal a Binario.");
            Console.WriteLine("[4] Palíndromo");
            Console.WriteLine("[5] Validación de Secuencia de Etiquetas HTML.");
            Console.WriteLine("[0] Volver a menu principal");
            Console.WriteLine();
        }

        public static void QueueMenu()
        {
            Console.WriteLine("--- Colas ---");
            Console.WriteLine();
            Console.WriteLine("Selecciona un ejercicio:");
            Console.WriteLine();
            Console.WriteLine("[1] Simulación de una Caja Registradora.");
            Console.WriteLine("[2] Gestión de turnos de una Clinica.");
            Console.WriteLine("[3] Sistema de cola de Banco.");
            Console.WriteLine("[4] Simulación de Atención en Soporte Técnico.");
            Console.WriteLine("[5] Simulación de un Servidor de Impresión.");
            Console.WriteLine("[0] Volver a menu principal");
            Console.WriteLine();
        }

        public static void ExerciseOptions(string option1, string option2, string option3, string option4, string option5)
        {
            Console.WriteLine("[1] " + option1);
            Console.WriteLine("[2] " + option2);
            Console.WriteLine("[3] " + option3);
            Console.WriteLine("[4] " + option4);
            Console.WriteLine("[5] " + option5);
            Console.WriteLine("[0] Salir a menu Colas.");
            Console.WriteLine();
        }

        public static void ExersiceDescription(string title, string description)
        {
            Console.Clear();
            Console.WriteLine("---=-=- " + title + " -=-=---");
            Console.WriteLine("Funcionamiento: " + description);
            Console.WriteLine();
        }
        
    }
}
