using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Algoritmos
{
    public class ExtraFunctions
    {
        // It helps know if the input of the user is correct.
        public static int NumberValidation(string text)
        {
            sbyte number;
            Console.Write(text);
            string userInput = Console.ReadLine();
            bool isvalid = sbyte.TryParse(userInput, out number);
            if (isvalid == true)
                return number;

            return -1;
        }




        // It return a boolean value if depending of the desition of the user.
        public static bool Repeat(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message + "  [1] Si, [ENTER] No");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                return true;
            }
            else { return false; }
        }




        // It only keeps the letters of a text
        public static string ClearText(string text)
        {
            foreach (char c in text)
            {
                if (char.IsLetter(c)) 
                {
                    text += char.ToLower(c);
                }
            }
            return text;
        }
    }
}
