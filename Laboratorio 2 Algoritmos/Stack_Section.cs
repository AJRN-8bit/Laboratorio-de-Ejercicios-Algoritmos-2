using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Laboratorio_2_Algoritmos
{
    public class Stack_Section
    {
        static public void Browser()
        {
            int numberSelection, inputNumber;
            string result;
            do
            {
                Console.Clear();

                // Display.
                Display.StackMenu();
                numberSelection = ExtraFunctions.NumberValidation("Número de Ejercicio: ");

                switch (numberSelection)
                {
                    case 0: numberSelection = 0; break;

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
            // It values a postfixed expression.

            string inputText; 
            bool ifYes;
            do
            {
                Console.Clear();
                Int_Stack_Structure.Pile PostFixed_Ex_Stack = new Int_Stack_Structure.Pile();

                Display.ExersiceDescription("Evaluación de una Expresión Postfija", "Se encuentra el número resultante de una expresión postfija.");

                Console.Write("Introdusca su expresión postfija: ");
                inputText = Console.ReadLine();
                inputText.Replace(" ", "");

                foreach(char c in inputText)
                {
                    if (char.IsDigit(c))
                    {
                        // Converts the char into an int
                        PostFixed_Ex_Stack.Push(c - '0'); 
                    }

                    // If there is an operand, 2 of the numbers are taken out to apply that operand.
                    else if (c == '+' || c == '-' || c == '*' || c == '/')
                    {
                        int operand1 = PostFixed_Ex_Stack.Pop();
                        int operand2 = PostFixed_Ex_Stack.Pop();
                        int result = 0;

                        // Operand usage.
                        switch (c)
                        {
                            case '+':
                                result =  operand1 + operand2; break;
                            case '-':
                                result = operand1 - operand2; break;
                            case '*':
                                result = operand1 * operand2; break;
                            case '/':
                                result = operand1 / operand2; break;
                            default:
                                Console.WriteLine("La expresión no es válida."); break;
                        }
                        PostFixed_Ex_Stack.Push(result);
                    }
                }
                Console.WriteLine($"La expresión {inputText} evaluda es: {PostFixed_Ex_Stack.Pop()}");

                ifYes = ExtraFunctions.Repeat("Desea ingresar otra expresión?");

            } while (ifYes != false);
        }





        private static void Exercise2()
        {
            // Exercise 2 of the laboratory.
            // Invert a text using a stack.

            bool ifYes;
            do
            {
                Console.Clear();
                string invertedString = "";

                Char_Stack_Structure.Pile Invert_Text_Stack = new Char_Stack_Structure.Pile();

                Display.ExersiceDescription("Invertir una Cadena de Texto", "Invierte un texto usando una pila.");

                // Text input
                Console.Write("Ingresa un texto: ");
                string inputString = Console.ReadLine();

                // It pushes all the chars in the text one by one.
                foreach (char c in inputString)
                {
                    Invert_Text_Stack.Push(c);
                }

                // It traverses the stack.
                while (!Invert_Text_Stack.IsEmpty())
                {
                    // Stores the all the chars in a string.
                    invertedString += Invert_Text_Stack.Pop();
                }

                Console.WriteLine($"El texto invertido de {inputString} es: " + invertedString);
                ifYes = ExtraFunctions.Repeat("¿Desea ingresar otro texto?");

            } while (ifYes != false);
        }





        private static void Exercise3()
        {   
            // Exercise 3 of the laboratory.
            // Convert a decimal number to binary using a stack.

            bool ifYes;
            do
            {
                Console.Clear();
                string answer = "";

                Int_Stack_Structure.Pile B_D_Stack = new Int_Stack_Structure.Pile();

                Display.ExersiceDescription("Convertor de Decimal a Binario", "Convierte un número decimal a su valor binario.");

                // Decimal number input.
                int inputNumber = ExtraFunctions.NumberValidation("Ingresa un número: ");
                int number = inputNumber;

                // It pushes the binary numbers in the stack while the number is different from 0.
                while (number != 0)
                {
                    B_D_Stack.Push(number % 2);

                    number /= 2; // It divides the decimal value by 2 every time until is 0.
                }

                // It stores all the values in a string, the cycles runs until the stack is empty.
                while (!B_D_Stack.IsEmpty())
                {
                    answer += B_D_Stack.Pop();
                }

                Console.WriteLine($"El valor binario de {inputNumber} es: " + answer);
                ifYes = ExtraFunctions.Repeat("¿Desea ingresar otro número?");

            } while(ifYes != false);
        }





        private static void Exercise4()
        {
            // Exercise 5 of the laboratory.
            // Shows if a text is the same when is inverted.

            bool ifYes;
            do
            {
                Console.Clear();
                string inputString, invertedString = "";

                Char_Stack_Structure.Pile Palindrome_Stack = new Char_Stack_Structure.Pile();

                Display.ExersiceDescription("Palíndromo usando Pila", "Muestra si un texto es igual cuando es invertido.");

                Console.Write("Ingresa un texto: ");
                inputString = Console.ReadLine();
                inputString = ExtraFunctions.ClearText(inputString);

                int length = inputString.Length;

                // Adds all the chars that are in the of the text
                foreach (char c in inputString)
                {
                    Palindrome_Stack.Push(c);
                }

                // It traverses the stack.
                while (!Palindrome_Stack.IsEmpty())
                {
                    // Stores the all the chars in a string.
                    invertedString += Palindrome_Stack.Pop();
                }

                if(inputString == invertedString)
                {
                    // If the original text and the reverse text is the same, show that the oiginal text is a palindrome.
                    Console.WriteLine($"El texto es palíndromo.");
                }
                else
                {
                    // If not, it shows that the original text is not a palindrome.
                    Console.WriteLine($"El texto no es palíndromo");
                }
                
                ifYes = ExtraFunctions.Repeat("¿Desea ingresar otro texto?");

            } while (ifYes != false);
        }





        private static void Exercise5() // Not compleated
        {
            // Exercise 6 of the laboratory.
            // Validates labels of HTML

            Console.WriteLine("Ejercicio no completado.");
            Console.ReadKey();

            /*
            Console.WriteLine("");
            bool ifYes;
            do
            {
                Console.Clear();
                Int_Stack_Structure.Pile stack = new Int_Stack_Structure.Pile();

                Display.ExersiceDescription("title", "description");
                int inputNumber = ExtraFunctions.NumberValidation("Ingresa un número: ");

                ifYes = ExtraFunctions.Repeat("Desea ingresar otro número?");

            } while (ifYes != false);
            */
        }
    }
}
