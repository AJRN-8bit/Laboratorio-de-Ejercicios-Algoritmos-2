using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Algoritmos
{
    public class Queue_Section
    {
        public static void Browser()
        {
            int numberSelection;
            do
            {
                Console.Clear();

                Display.QueueMenu();
                numberSelection = ExtraFunctions.NumberValidation("Número de Ejercicio: ");

                switch (numberSelection)
                {
                    case 0:
                        numberSelection = 0; break;

                    case 1: Exercise1(); break;

                    case 2: Exercise2(); break; 

                    case 3: Exercise3(); break;

                    case 4: Exercise4(); break;

                    case 5: Exercise5(); break;

                    default: Console.WriteLine("Porfavor selecciona una de la opciones."); break;
                }
            } while (numberSelection != 0);
        }





        private static void Exercise1()
        {
            // Exercise 1 of the laboratory.
            // Simulation of a cash register.
            int selectionNumber, howMany;
            Queue_Structure.Queue CashRegister_Queue = new Queue_Structure.Queue();

            do
            {
                Console.Clear();
                Display.ExersiceDescription("Simulación de una Caja Registradora.",
                    "Simula una caja registradora en donde se agregan, atendieden y ve a los cliente de la cola.");

                Display.ExerciseOptions("Agregar un cliente.", "Agregar varios clientes.", "Atender un cliente",
                    "Atender a varios cliente", "Ver cola de clientes.");

                selectionNumber = ExtraFunctions.NumberValidation("Elija una opción: ");

                switch (selectionNumber)
                {
                    case 0: selectionNumber = 0; break;

                    case 1: CashRegister_Queue.Add("Cliente", "llega."); break;

                    case 2:
                        howMany = ExtraFunctions.NumberValidation("Número de clientes a llegar: ");
                        Console.WriteLine();
                        for (int i = 0; i < howMany; i++)
                        {
                            CashRegister_Queue.Add("Cliente", "llega.");
                        }
                        break;

                    case 3: CashRegister_Queue.Delete("No hay clientes en espera", "a sido atendido."); break;

                    case 4:
                        howMany = ExtraFunctions.NumberValidation("Número de cliente a atender: ");
                        Console.WriteLine();
                        for (int i = 0; i < howMany; i++)
                        {
                            CashRegister_Queue.Delete("No hay clientes en espera", "a sido atendido.");
                        }
                        break;

                    case 5: CashRegister_Queue.ShowQueue("No hay clientes en espera.", "Clientes en espera:"); break;

                    default: Console.WriteLine("Porfavor selecciona una de la opciones."); break;
                }
                Console.ReadKey();
            } while (selectionNumber != 0);
        }

        



        private static void Exercise2()
        {
            // Exercise 2 of the laboratory.
            // Simulation of a clinic.
            int selectionNumber, howMany;
            Queue_Structure.Queue Clinic_Queue = new Queue_Structure.Queue();

            do
            {
                Console.Clear();
                Display.ExersiceDescription("Gestión de turnos de una Clinica", 
                    "Simula un clinica donde se agregan, atendien y ve a los pacientes de la cola.");

                Display.ExerciseOptions("Agregar un Paciente.", "Agregar varios Pacientes.", "Atender un paciente", 
                    "Atender a varios pacientes", "Ver cola de Pacientes.");

                selectionNumber = ExtraFunctions.NumberValidation("Elija una opción: ");

                switch (selectionNumber)
                {
                    case 0: selectionNumber = 0; break;

                    case 1: Clinic_Queue.Add("Paciente", "llega."); break;

                    case 2:
                        howMany = ExtraFunctions.NumberValidation("Número de pacientes a agregar: ");
                        Console.WriteLine();
                        for(int i = 0; i < howMany; i++) 
                        {
                            Clinic_Queue.Add("Paciente", "llega.");
                        }
                        break;

                    case 3: Clinic_Queue.Delete("No hay clientes en espera", "a sido atendido."); break;

                    case 4:
                        howMany = ExtraFunctions.NumberValidation("Número de pacientes a atender: ");
                        Console.WriteLine();
                        for (int i = 0; i < howMany; i++)
                        {
                            Clinic_Queue.Delete("No hay clientes en espera", "a sido atendido.");
                        }
                        break;

                    case 5: Clinic_Queue.ShowQueue("No hay pacientes en espera.", "Pacientes en espera:"); break;

                    default: Console.WriteLine("Porfavor selecciona una de la opciones."); break;
                }
            Console.ReadKey();
            } while (selectionNumber != 0);
        }





        private static void Exercise3() // Not compleated
        {
            // Exercise 3 in the laboratory
            // Description

            Console.WriteLine("Ejercicio no completado.");
            Console.ReadKey();

            /*
            int selectionNumber;
            Queue_Structure.Queue nameOfQueue = new Queue_Structure.Queue();

            do
            {
                Console.Clear();
                Display.ExersiceDescription("titulo", "descripción");
                //Display.ExerciseOptions("opción1", "opción2", "opción3");
                selectionNumber = ExtraFunctions.NumberValidation("Elija una opción: ");

                switch (selectionNumber)
                {
                    case 0: selectionNumber = 0; break;

                    case 1: selectionNumber = 1; break;

                    case 2: selectionNumber = 2; break;

                    case 3: selectionNumber = 3; break;

                    default: Console.WriteLine("Porfavor selecciona una de la opciones."); break;
                }
                Console.Clear();
            } while (selectionNumber != 0);
            */
        }





        private static void Exercise4() // Not compleated
        {
            // Exercise 4 in the laboratory
            // Description

            Console.WriteLine("Ejercicio no completado.");
            Console.ReadKey();

            /*
            int selectionNumber;
            Queue_Structure.Queue nameOfQueue = new Queue_Structure.Queue();

            do
            {
                Console.Clear();
                Display.ExersiceDescription("titulo", "descripción");
                //Display.ExerciseOptions("opción1", "opción2", "opción3");
                selectionNumber = ExtraFunctions.NumberValidation("Elija una opción: ");

                switch (selectionNumber)
                {
                    case 0: selectionNumber = 0; break;

                    case 1: selectionNumber = 1; break;

                    case 2: selectionNumber = 2; break;

                    case 3: selectionNumber = 3; break;

                    default: Console.WriteLine("Porfavor selecciona una de la opciones."); break;
                }
                Console.Clear();
            } while (selectionNumber != 0);
            */
        }





        private static void Exercise5()
        {
            // Exercise 6 in the laboratory
            // Simulates a task impresion server

            int selectionNumber, howMany;
            Queue_Structure.Queue Print_Queue = new Queue_Structure.Queue();

            do
            {
                Console.Clear();
                Display.ExersiceDescription("Simulación de un Servidor de Impresión.",
                    "Simula un servidor de impresiones en donde se agregan, atendieden y ven las tareas a imprimir.");

                Display.ExerciseOptions("Agregar una tarea.", "Agregar varias tareas.", "Imprimir una tarea",
                    "Imprimir a varias tarea", "Ver cola de clientes.");

                selectionNumber = ExtraFunctions.NumberValidation("Elija una opción: ");

                switch (selectionNumber)
                {
                    case 0: selectionNumber = 0; break;

                    case 1: Print_Queue.Add("Tarea", "llega."); break;

                    case 2:
                        howMany = ExtraFunctions.NumberValidation("Número de tareas a llegar: ");
                        Console.WriteLine();
                        for (int i = 0; i < howMany; i++)
                        {
                            Print_Queue.Add("Tarea", "llega.");
                        }
                        break;

                    case 3: Print_Queue.Delete("No hay tareas en espera", "a sido impresa."); break;

                    case 4:
                        howMany = ExtraFunctions.NumberValidation("Número de tareas a atender: ");
                        Console.WriteLine();
                        for (int i = 0; i < howMany; i++)
                        {
                            Print_Queue.Delete("No hay tareas en espera", "a sido impresa.");
                        }
                        break;

                    case 5: Print_Queue.ShowQueue("No hay tareas en espera.", "Tareas en espera:"); break;

                    default: Console.WriteLine("Porfavor selecciona una de la opciones."); break;
                }
                Console.ReadKey();
            } while (selectionNumber != 0);
        }
    }
}
