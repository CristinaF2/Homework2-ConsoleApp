using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework2_ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person.DisplayUserDetails();  

            Console.WriteLine();
            int numar;

            while (true)
            {
                Console.WriteLine("Introduceti un număr:");
                string input = Console.ReadLine();

                //bool int.TryParse(string s, out int result);
                //s: The string you want to convert to an integer.
                //result: The output variable that will store the converted integer if the conversion is successful.
                //Return value: A bool indicating whether the conversion succeeded(true) or failed(false).

                if (int.TryParse(input, out numar))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Introduceti va rog un număr valid!");
                }
            }
            VerificaParPozitivSauNegativ(numar);
            Console.WriteLine();

            // Add skills
            Person.AddSkill("Cooking");
            Person.AddSkill("Photography");
            Person.AddSkill("Programming");
            Person.AddSkill("Testing");
            Person.AddSkill("Ninja");
            Person.AddSkill("Swimming");
            Person.AddSkill("CIA");
            Person.AddSkill("Dancing");
            Person.AddSkill("Singing");

            // Display skills
            Person.DisplaySkills();
        }

        public static void VerificaParPozitivSauNegativ(int numar)
            {
                if (numar == 0)
                {
                    Console.WriteLine("Numărul este zero si este par, dar nu este nici pozitiv, nici negativ");
                }
                else if (numar % 2 == 0)
                {
                    if (numar > 0)
                    {
                        Console.WriteLine("Numărul este par pozitiv");
                    }
                    else
                    {
                        Console.WriteLine("Numărul este par negativ");
                    }
                }
                else
                {
                   if (numar > 0)
                   {
                      Console.WriteLine("Numărul este impar pozitiv");
                   }
                   else
                   {
                      Console.WriteLine("Numărul este impar negativ");
                   }
                }
            }
     }
}

